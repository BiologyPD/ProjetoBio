using ProjetoBio.Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enum = ProjetoBio.Animais.Enum;

namespace ProjetoBio.Utils
{
    public static class ComboBoxExtensions
    {
        public static void SetFromEmpty<T>(this ComboBox comboBox, string emptyMessage = KeyPair.DefaultEmptyText) where T : Enum
            => comboBox.SetFrom<T>(emptyMessage);

        public static void SetFrom<T>(this ComboBox comboBox) where T : Enum
            => comboBox.Set(KeyPair.GetKeyPairs<T>());


        public static void SetFrom<T>(this ComboBox comboBox, string emptyMessage) where T : Enum
            => comboBox.Set(KeyPair.GetKeyPairs<T>(emptyMessage));

        public static void Set<T>(this ComboBox comboBox, KeyPair<T>[] keyPairs) where T : Enum
        {
            comboBox.Items.Clear();
            comboBox.DisplayMember = "Key";
            comboBox.ValueMember = "Value";
            comboBox.DataSource = keyPairs;
        }
    }

    public static class CheckedListBoxExtensions
    {
        public static void EmptySetFrom<T>(this CheckedListBox checkedListBox) where T : Enum
        {
            checkedListBox.CheckOnClick = true;
            checkedListBox.Items.Clear();
            checkedListBox.DataSource = KeyPair.GetKeyPairs<T>();
            checkedListBox.DisplayMember = "Key";
            checkedListBox.ValueMember = "Value";
        }

        public static T[] CheckedValues<T>(this CheckedListBox checkedListBox) where T : Enum
        {
            return
                (from KeyPair<T> keypair in checkedListBox.CheckedItems
                 select keypair.Value).ToArray();
            
            // auto-generated
            // checkedListBox.CheckedItems[0].GetType().GetType().GetProperty("Value").GetValue(checkedListBox.CheckedItems[0], null); 
        }

        public static void CheckFrom<T>(this CheckedListBox checkedListBox, params T[] values) where T : Enum
        {
            foreach (var value in values)
                checkedListBox.SetItemChecked(checkedListBox.FindString(value.Text), true);
        }

        public static void CheckAll(this CheckedListBox checkedListBox)
        {
            for (int i = 0; i < checkedListBox.Items.Count; i++)
                checkedListBox.SetItemChecked(i, true);
        }

        public static void UncheckAll(this CheckedListBox checkedListBox)
        {
            for (int i = 0; i < checkedListBox.Items.Count; i++)
                checkedListBox.SetItemChecked(i, false);
        }
    }

    public static class FormExtensions
    {
        public static void TrimAll(this Form form)
        {
            foreach (var control in form.Controls.OfType<TextBoxBase>())
                control.Text = control.Text.Trim();
        }

        public static string Trim(this TextBoxBase textBox)
        {
            textBox.Text = textBox.Text.Trim();
            return textBox.Text;
        }
    }

    public static class StringExtensions
    {
        public static string ToTrimmed(this string s)
        {
            if (s == null)
                s = string.Empty;
            else
                s = s.Trim();
            return s;
        }

        public static bool IsBlank(this string s) => string.IsNullOrWhiteSpace(s.ToTrimmed());

        public static string Check(this string s) => s.IsBlank() ? throw new ArgumentNullException(nameof(s) + " cannot be null!") : s;

        public static string AddQuote(this string s) => '"' + s.ToTrimmed() + '"';
    }

    public static class StringBuilderExtensions
    {
        public static StringBuilder AppendQuote(this StringBuilder stringBuilder, string value) => stringBuilder.AppendLine(value.AddQuote() + ",");

        public static StringBuilder AppendComma(this StringBuilder stringBuiler, string value = "") => stringBuiler.AppendLine(value + ",");
    }

    public static class ControlExtensions
    {
        private static readonly ToolTip toolTip = ToolTipModel;

        public static ToolTip ToolTipModel { 
            get
            {
                var tool = new ToolTip();
                tool.InitialDelay = 2;
                tool.ReshowDelay = 2;
                return tool;
            }
        }

        public static void AddToolTip(this Control control, string caption)
            => toolTip.SetToolTip(control, caption);
    }
}
