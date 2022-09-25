namespace ProjetoBio
{
    partial class AnimalSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.gbBusca = new System.Windows.Forms.GroupBox();
            this.chkPersonagem = new System.Windows.Forms.CheckBox();
            this.chkParasita = new System.Windows.Forms.CheckBox();
            this.lblAlimentacao = new System.Windows.Forms.Label();
            this.cbAlimentacao = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblFilo = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.cbFilo = new System.Windows.Forms.ComboBox();
            this.dgAnimals = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.gbBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAnimals)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 22);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(86, 20);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.Search);
            // 
            // gbBusca
            // 
            this.gbBusca.Controls.Add(this.btnNovo);
            this.gbBusca.Controls.Add(this.btnExcluir);
            this.gbBusca.Controls.Add(this.btnEditar);
            this.gbBusca.Controls.Add(this.chkPersonagem);
            this.gbBusca.Controls.Add(this.chkParasita);
            this.gbBusca.Controls.Add(this.lblAlimentacao);
            this.gbBusca.Controls.Add(this.cbAlimentacao);
            this.gbBusca.Controls.Add(this.lblTipo);
            this.gbBusca.Controls.Add(this.lblFilo);
            this.gbBusca.Controls.Add(this.cbTipo);
            this.gbBusca.Controls.Add(this.cbFilo);
            this.gbBusca.Controls.Add(this.txtNome);
            this.gbBusca.Controls.Add(this.lblNome);
            this.gbBusca.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbBusca.Location = new System.Drawing.Point(0, 0);
            this.gbBusca.Name = "gbBusca";
            this.gbBusca.Size = new System.Drawing.Size(292, 450);
            this.gbBusca.TabIndex = 1;
            this.gbBusca.TabStop = false;
            this.gbBusca.Text = "Fazer busca";
            // 
            // chkPersonagem
            // 
            this.chkPersonagem.AutoSize = true;
            this.chkPersonagem.Location = new System.Drawing.Point(15, 151);
            this.chkPersonagem.Name = "chkPersonagem";
            this.chkPersonagem.Size = new System.Drawing.Size(91, 17);
            this.chkPersonagem.TabIndex = 9;
            this.chkPersonagem.Text = "Personagem?";
            this.chkPersonagem.UseVisualStyleBackColor = true;
            this.chkPersonagem.CheckedChanged += new System.EventHandler(this.Search);
            // 
            // chkParasita
            // 
            this.chkParasita.AutoSize = true;
            this.chkParasita.Location = new System.Drawing.Point(15, 128);
            this.chkParasita.Name = "chkParasita";
            this.chkParasita.Size = new System.Drawing.Size(70, 17);
            this.chkParasita.TabIndex = 8;
            this.chkParasita.Text = "Parasita?";
            this.chkParasita.UseVisualStyleBackColor = true;
            this.chkParasita.CheckedChanged += new System.EventHandler(this.Search);
            // 
            // lblAlimentacao
            // 
            this.lblAlimentacao.AutoSize = true;
            this.lblAlimentacao.Location = new System.Drawing.Point(12, 104);
            this.lblAlimentacao.Name = "lblAlimentacao";
            this.lblAlimentacao.Size = new System.Drawing.Size(65, 13);
            this.lblAlimentacao.TabIndex = 7;
            this.lblAlimentacao.Text = "Alimentação";
            // 
            // cbAlimentacao
            // 
            this.cbAlimentacao.FormattingEnabled = true;
            this.cbAlimentacao.Location = new System.Drawing.Point(86, 101);
            this.cbAlimentacao.Name = "cbAlimentacao";
            this.cbAlimentacao.Size = new System.Drawing.Size(200, 21);
            this.cbAlimentacao.TabIndex = 6;
            this.cbAlimentacao.SelectedIndexChanged += new System.EventHandler(this.Search);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(12, 77);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 5;
            this.lblTipo.Text = "Tipo";
            // 
            // lblFilo
            // 
            this.lblFilo.AutoSize = true;
            this.lblFilo.Location = new System.Drawing.Point(12, 49);
            this.lblFilo.Name = "lblFilo";
            this.lblFilo.Size = new System.Drawing.Size(23, 13);
            this.lblFilo.TabIndex = 4;
            this.lblFilo.Text = "Filo";
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(86, 74);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(200, 21);
            this.cbTipo.TabIndex = 3;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.Search);
            // 
            // cbFilo
            // 
            this.cbFilo.FormattingEnabled = true;
            this.cbFilo.Location = new System.Drawing.Point(86, 46);
            this.cbFilo.Name = "cbFilo";
            this.cbFilo.Size = new System.Drawing.Size(200, 21);
            this.cbFilo.TabIndex = 2;
            this.cbFilo.SelectedIndexChanged += new System.EventHandler(this.Search);
            // 
            // dgAnimals
            // 
            this.dgAnimals.AllowUserToAddRows = false;
            this.dgAnimals.AllowUserToDeleteRows = false;
            this.dgAnimals.AllowUserToOrderColumns = true;
            this.dgAnimals.AllowUserToResizeColumns = false;
            this.dgAnimals.AllowUserToResizeRows = false;
            this.dgAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAnimals.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgAnimals.Location = new System.Drawing.Point(298, 0);
            this.dgAnimals.MultiSelect = false;
            this.dgAnimals.Name = "dgAnimals";
            this.dgAnimals.ReadOnly = true;
            this.dgAnimals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAnimals.Size = new System.Drawing.Size(502, 450);
            this.dgAnimals.TabIndex = 0;
            this.dgAnimals.SelectionChanged += new System.EventHandler(this.dgAnimals_SelectionChanged);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(211, 421);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(130, 421);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(12, 421);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 12;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // AnimalSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbBusca);
            this.Controls.Add(this.dgAnimals);
            this.Name = "AnimalSearch";
            this.Text = "Consulta";
            this.gbBusca.ResumeLayout(false);
            this.gbBusca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAnimals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox gbBusca;
        private System.Windows.Forms.CheckBox chkPersonagem;
        private System.Windows.Forms.CheckBox chkParasita;
        private System.Windows.Forms.Label lblAlimentacao;
        private System.Windows.Forms.ComboBox cbAlimentacao;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblFilo;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.ComboBox cbFilo;
        private System.Windows.Forms.DataGridView dgAnimals;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
    }
}