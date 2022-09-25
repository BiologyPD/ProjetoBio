using ProjetoBio.Animais;
using ProjetoBio.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enum = ProjetoBio.Animais.Enum;

namespace ProjetoBio
{
    public partial class AnimalSearch : Form
    {
        private static AnimalSearch _instance = null;
        private static object @lock = new object();

        const string DefaultEmptyMessage = "Todos";
        private readonly AnimalControl control = AnimalControl.Instance;

        public static AnimalSearch GetInstance()
        {
            if (_instance == null )
            {
                lock (@lock)
                {
                    if (_instance == null || _instance.IsDisposed)
                    {
                        _instance = new AnimalSearch();
                        _instance.FormClosed += delegate { _instance = null; };
                    }
                }
            }

            _instance.Show();
            _instance.WindowState = FormWindowState.Normal;
            _instance.Focus();
            return _instance;
        }

        private AnimalSearch()
        {
            InitializeComponent();
            cbFilo.SetFrom<Filo>(DefaultEmptyMessage);
            cbTipo.SetFrom<Tipo>(DefaultEmptyMessage);
            cbAlimentacao.SetFrom<EMetodoAlimentacao>(DefaultEmptyMessage);

            InitGrid();
            FillGrid(control.ToList());
        }

        private void gbBusca_Enter(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e) => Search();

        private void InitGrid()
        {
            dgAnimals.ColumnCount = 4;

            dgAnimals.Columns[0].HeaderText = "HashCode";
            dgAnimals.Columns[0].DataPropertyName = "Hash";

            dgAnimals.Columns[1].HeaderText = "Nome";
            dgAnimals.Columns[1].DataPropertyName = "Nome";

            dgAnimals.Columns[2].HeaderText = "Filo";
            dgAnimals.Columns[2].DataPropertyName = "Filo";

            dgAnimals.Columns[3].HeaderText = "Tipo";
            dgAnimals.Columns[3].DataPropertyName = "Tipo";
        }

        private Dictionary<DataGridViewColumn, PropertyInfo> GetDict()
        {
            var animalProprieties = typeof(Animal).GetProperties(BindingFlags.Instance | BindingFlags.Public);

            var columns = dgAnimals.Columns.Cast<DataGridViewColumn>();
            var columnsProp = columns.Select(x => x.DataPropertyName);

            var animalPropsInColumns = animalProprieties.Where(x => columnsProp.Contains(x.Name));

            var dict = animalPropsInColumns.ToDictionary(x => columns.First(y => y.DataPropertyName == x.Name));
            
            return dict;
        }

        private void FillGrid(IEnumerable<Animal> animals)
        {
            var dict = GetDict();
            dgAnimals.RowCount = animals.Count();

            int index = 0;
            foreach (Animal an in animals)
            {
                if (dgAnimals.Columns.Cast<DataGridViewColumn>().Select(x => x.DataPropertyName).Contains("Hash")) // trata de reescrever isso aqui, ta extremamente ineficiente.
                {
                    int hashPos = dgAnimals.Columns.Cast<DataGridViewColumn>().First(x => x.DataPropertyName == "Hash").Index;
                    dgAnimals.Rows[index].Cells[hashPos].Value = an.GetHashCode();
                }

                for (int i = 0; i < 3; i++)
                {
                    try { dgAnimals.Rows[index].Cells[i+1].Value = dict[dgAnimals.Columns[i+1]].GetValue(an); }
                    catch { }
                }
                index++;
            }

            /*
            foreach(Animal animal in animals)
            {
                for (int row = 0; row < dgAnimals.RowCount; row++)
                {
                    for (int col = 0; col < dgAnimals.ColumnCount; col++)
                    {
                        if (dgAnimals.Columns[col].DataPropertyName == "Hash")
                        {
                            dgAnimals.Rows[row].Cells[col].Value = animal.GetHashCode();
                            continue;
                        }

                        var value = animalProprieties.FirstOrDefault(prop => dgAnimals.Columns[col].DataPropertyName == prop.Name)?.GetValue(animal);

                        if (value == null)
                            continue;

                        dgAnimals.Rows[row].Cells[col].Value = value.ToString();
                    }
                }
            }
            */
        }

        private void Search(object sender = null, EventArgs e = null)
        {
            var lstAnimals = control.AsEnumerable();

            if (txtNome.Text.Trim() != string.Empty)
                lstAnimals = lstAnimals.Where(an => an.Nome.StartsWith(txtNome.Text));

            if (chkParasita.Checked)
                lstAnimals = lstAnimals.Where(an => an is Parasita);

            if (chkPersonagem.Checked)
                lstAnimals = lstAnimals.Where(an => an.HasPersonagem);

            foreach(var cb in gbBusca.Controls.OfType<ComboBox>().Where(cb => cb.SelectedValue != null))
            {
                lstAnimals = lstAnimals.Intersect(AnimalControl.Instance.FindType((Enum)cb.SelectedValue));
            }

            FillGrid(lstAnimals);
        }

        private void dgAnimals_SelectionChanged(object sender, EventArgs e)
        {
            bool validRow = dgAnimals.SelectedRows.Count > 0 && dgAnimals.SelectedRows[0].Index >= 0;

            btnEditar.Visible = validRow;
            btnExcluir.Visible = validRow;
        }
    }
}
