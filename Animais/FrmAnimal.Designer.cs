namespace ProjetoBio.Animais
{
    partial class FrmAnimal
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
            this.lblPersonagem = new System.Windows.Forms.Label();
            this.txtPersonagem = new System.Windows.Forms.TextBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cbFilo = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblFilo = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabGeral = new System.Windows.Forms.TabPage();
            this.txtHabitat = new System.Windows.Forms.TextBox();
            this.lblHabitat = new System.Windows.Forms.Label();
            this.txtAdaptacoes = new System.Windows.Forms.TextBox();
            this.lblAdaptacoes = new System.Windows.Forms.Label();
            this.checkCampoPersonagem = new System.Windows.Forms.CheckBox();
            this.tabCaracteristicas = new System.Windows.Forms.TabPage();
            this.chkHasBoca = new System.Windows.Forms.CheckBox();
            this.chkHasAnus = new System.Windows.Forms.CheckBox();
            this.lblDescAnus = new System.Windows.Forms.Label();
            this.txtDescAnus = new System.Windows.Forms.TextBox();
            this.txtDescBoca = new System.Windows.Forms.TextBox();
            this.lblDescBoca = new System.Windows.Forms.Label();
            this.lblNomeCientifico = new System.Windows.Forms.Label();
            this.txtNomeCientifico = new System.Windows.Forms.TextBox();
            this.txtBioma = new System.Windows.Forms.TextBox();
            this.lblBioma = new System.Windows.Forms.Label();
            this.cbRespiracao = new System.Windows.Forms.ComboBox();
            this.lblRespiracao = new System.Windows.Forms.Label();
            this.tabAlimentacao = new System.Windows.Forms.TabPage();
            this.txtRegulacaoAgua = new System.Windows.Forms.TextBox();
            this.lblRegulacaoAgua = new System.Windows.Forms.Label();
            this.txtAlimentacaoDescricao = new System.Windows.Forms.TextBox();
            this.lblAlimentacaoDescricao = new System.Windows.Forms.Label();
            this.cbEMetodoAlimentacao = new System.Windows.Forms.ComboBox();
            this.lblAlimentacaoMetodo = new System.Windows.Forms.Label();
            this.cbEAlimentacao = new System.Windows.Forms.ComboBox();
            this.lblAlimentacaoTipo = new System.Windows.Forms.Label();
            this.tabDefesaLocomocao = new System.Windows.Forms.TabPage();
            this.txtDescricaoLocomocao = new System.Windows.Forms.TextBox();
            this.lblLocomocaoDescricao = new System.Windows.Forms.Label();
            this.txtDefesaDescricao = new System.Windows.Forms.TextBox();
            this.lblDefesaDescricao = new System.Windows.Forms.Label();
            this.lblELocomocao = new System.Windows.Forms.Label();
            this.chkLstELocomocao = new System.Windows.Forms.CheckedListBox();
            this.chkLstEDefesa = new System.Windows.Forms.CheckedListBox();
            this.lblEDefesa = new System.Windows.Forms.Label();
            this.tabDesenvolvimentoEmbrionario = new System.Windows.Forms.TabPage();
            this.txtEpocaReproducao = new System.Windows.Forms.TextBox();
            this.chkHasEpocaSexo = new System.Windows.Forms.CheckBox();
            this.txtReproducaoDescricaoCorte = new System.Windows.Forms.TextBox();
            this.chkReproducaoHasCorte = new System.Windows.Forms.CheckBox();
            this.txtReproducaoDescricao = new System.Windows.Forms.TextBox();
            this.lblReproducaoDescricao = new System.Windows.Forms.Label();
            this.lblEDevEmbrionario = new System.Windows.Forms.Label();
            this.cbEDevEmbrionario = new System.Windows.Forms.ComboBox();
            this.lblEReproducao = new System.Windows.Forms.Label();
            this.cbEReproducao = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblAparencia = new System.Windows.Forms.Label();
            this.txtAparencia = new System.Windows.Forms.TextBox();
            this.lblMembros = new System.Windows.Forms.Label();
            this.txtDescMembros = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabGeral.SuspendLayout();
            this.tabCaracteristicas.SuspendLayout();
            this.tabAlimentacao.SuspendLayout();
            this.tabDefesaLocomocao.SuspendLayout();
            this.tabDesenvolvimentoEmbrionario.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(3, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPersonagem
            // 
            this.lblPersonagem.AutoSize = true;
            this.lblPersonagem.Location = new System.Drawing.Point(3, 88);
            this.lblPersonagem.Name = "lblPersonagem";
            this.lblPersonagem.Size = new System.Drawing.Size(70, 13);
            this.lblPersonagem.TabIndex = 11;
            this.lblPersonagem.Text = "Personagem*";
            // 
            // txtPersonagem
            // 
            this.txtPersonagem.Enabled = false;
            this.txtPersonagem.Location = new System.Drawing.Point(109, 85);
            this.txtPersonagem.Name = "txtPersonagem";
            this.txtPersonagem.Size = new System.Drawing.Size(193, 20);
            this.txtPersonagem.TabIndex = 10;
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(109, 31);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(193, 21);
            this.cbTipo.TabIndex = 7;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(3, 34);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 6;
            this.lblTipo.Text = "Tipo";
            // 
            // cbFilo
            // 
            this.cbFilo.FormattingEnabled = true;
            this.cbFilo.Location = new System.Drawing.Point(109, 58);
            this.cbFilo.Name = "cbFilo";
            this.cbFilo.Size = new System.Drawing.Size(193, 21);
            this.cbFilo.TabIndex = 3;
            this.cbFilo.SelectedIndexChanged += new System.EventHandler(this.cbFilo_SelectedIndexChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(109, 6);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(193, 20);
            this.txtNome.TabIndex = 2;
            // 
            // lblFilo
            // 
            this.lblFilo.AutoSize = true;
            this.lblFilo.Location = new System.Drawing.Point(3, 61);
            this.lblFilo.Name = "lblFilo";
            this.lblFilo.Size = new System.Drawing.Size(23, 13);
            this.lblFilo.TabIndex = 1;
            this.lblFilo.Text = "Filo";
            this.lblFilo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabGeral);
            this.tabControl.Controls.Add(this.tabCaracteristicas);
            this.tabControl.Controls.Add(this.tabAlimentacao);
            this.tabControl.Controls.Add(this.tabDefesaLocomocao);
            this.tabControl.Controls.Add(this.tabDesenvolvimentoEmbrionario);
            this.tabControl.Location = new System.Drawing.Point(8, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(316, 375);
            this.tabControl.TabIndex = 2;
            // 
            // tabGeral
            // 
            this.tabGeral.Controls.Add(this.txtHabitat);
            this.tabGeral.Controls.Add(this.lblHabitat);
            this.tabGeral.Controls.Add(this.txtAdaptacoes);
            this.tabGeral.Controls.Add(this.lblAdaptacoes);
            this.tabGeral.Controls.Add(this.checkCampoPersonagem);
            this.tabGeral.Controls.Add(this.lblPersonagem);
            this.tabGeral.Controls.Add(this.txtPersonagem);
            this.tabGeral.Controls.Add(this.lblNome);
            this.tabGeral.Controls.Add(this.lblFilo);
            this.tabGeral.Controls.Add(this.txtNome);
            this.tabGeral.Controls.Add(this.cbTipo);
            this.tabGeral.Controls.Add(this.cbFilo);
            this.tabGeral.Controls.Add(this.lblTipo);
            this.tabGeral.Location = new System.Drawing.Point(4, 22);
            this.tabGeral.Name = "tabGeral";
            this.tabGeral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeral.Size = new System.Drawing.Size(308, 349);
            this.tabGeral.TabIndex = 0;
            this.tabGeral.Text = "Geral";
            this.tabGeral.UseVisualStyleBackColor = true;
            // 
            // txtHabitat
            // 
            this.txtHabitat.Location = new System.Drawing.Point(3, 283);
            this.txtHabitat.Multiline = true;
            this.txtHabitat.Name = "txtHabitat";
            this.txtHabitat.Size = new System.Drawing.Size(296, 60);
            this.txtHabitat.TabIndex = 16;
            // 
            // lblHabitat
            // 
            this.lblHabitat.AutoSize = true;
            this.lblHabitat.Location = new System.Drawing.Point(0, 267);
            this.lblHabitat.Name = "lblHabitat";
            this.lblHabitat.Size = new System.Drawing.Size(41, 13);
            this.lblHabitat.TabIndex = 15;
            this.lblHabitat.Text = "Habitat";
            // 
            // txtAdaptacoes
            // 
            this.txtAdaptacoes.Location = new System.Drawing.Point(6, 200);
            this.txtAdaptacoes.Multiline = true;
            this.txtAdaptacoes.Name = "txtAdaptacoes";
            this.txtAdaptacoes.Size = new System.Drawing.Size(297, 65);
            this.txtAdaptacoes.TabIndex = 14;
            // 
            // lblAdaptacoes
            // 
            this.lblAdaptacoes.AutoSize = true;
            this.lblAdaptacoes.Location = new System.Drawing.Point(3, 184);
            this.lblAdaptacoes.Name = "lblAdaptacoes";
            this.lblAdaptacoes.Size = new System.Drawing.Size(104, 13);
            this.lblAdaptacoes.TabIndex = 13;
            this.lblAdaptacoes.Text = "Adaptações ao meio";
            // 
            // checkCampoPersonagem
            // 
            this.checkCampoPersonagem.AutoSize = true;
            this.checkCampoPersonagem.Location = new System.Drawing.Point(88, 88);
            this.checkCampoPersonagem.Name = "checkCampoPersonagem";
            this.checkCampoPersonagem.Size = new System.Drawing.Size(15, 14);
            this.checkCampoPersonagem.TabIndex = 12;
            this.checkCampoPersonagem.UseVisualStyleBackColor = true;
            this.checkCampoPersonagem.CheckedChanged += new System.EventHandler(this.checkCampoPersonagem_CheckedChanged);
            // 
            // tabCaracteristicas
            // 
            this.tabCaracteristicas.Controls.Add(this.txtDescMembros);
            this.tabCaracteristicas.Controls.Add(this.lblMembros);
            this.tabCaracteristicas.Controls.Add(this.txtAparencia);
            this.tabCaracteristicas.Controls.Add(this.lblAparencia);
            this.tabCaracteristicas.Controls.Add(this.chkHasBoca);
            this.tabCaracteristicas.Controls.Add(this.chkHasAnus);
            this.tabCaracteristicas.Controls.Add(this.lblDescAnus);
            this.tabCaracteristicas.Controls.Add(this.txtDescAnus);
            this.tabCaracteristicas.Controls.Add(this.txtDescBoca);
            this.tabCaracteristicas.Controls.Add(this.lblDescBoca);
            this.tabCaracteristicas.Controls.Add(this.lblNomeCientifico);
            this.tabCaracteristicas.Controls.Add(this.txtNomeCientifico);
            this.tabCaracteristicas.Controls.Add(this.txtBioma);
            this.tabCaracteristicas.Controls.Add(this.lblBioma);
            this.tabCaracteristicas.Controls.Add(this.cbRespiracao);
            this.tabCaracteristicas.Controls.Add(this.lblRespiracao);
            this.tabCaracteristicas.Location = new System.Drawing.Point(4, 22);
            this.tabCaracteristicas.Name = "tabCaracteristicas";
            this.tabCaracteristicas.Padding = new System.Windows.Forms.Padding(3);
            this.tabCaracteristicas.Size = new System.Drawing.Size(308, 349);
            this.tabCaracteristicas.TabIndex = 4;
            this.tabCaracteristicas.Text = "Características";
            this.tabCaracteristicas.UseVisualStyleBackColor = true;
            // 
            // chkHasBoca
            // 
            this.chkHasBoca.AutoSize = true;
            this.chkHasBoca.Location = new System.Drawing.Point(112, 88);
            this.chkHasBoca.Name = "chkHasBoca";
            this.chkHasBoca.Size = new System.Drawing.Size(15, 14);
            this.chkHasBoca.TabIndex = 21;
            this.chkHasBoca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkHasBoca.UseVisualStyleBackColor = true;
            this.chkHasBoca.CheckedChanged += new System.EventHandler(this.chkHasBoca_CheckedChanged);
            // 
            // chkHasAnus
            // 
            this.chkHasAnus.AutoSize = true;
            this.chkHasAnus.Location = new System.Drawing.Point(112, 113);
            this.chkHasAnus.Name = "chkHasAnus";
            this.chkHasAnus.Size = new System.Drawing.Size(15, 14);
            this.chkHasAnus.TabIndex = 20;
            this.chkHasAnus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkHasAnus.UseVisualStyleBackColor = true;
            this.chkHasAnus.CheckedChanged += new System.EventHandler(this.chkHasAnus_CheckedChanged);
            // 
            // lblDescAnus
            // 
            this.lblDescAnus.AutoSize = true;
            this.lblDescAnus.Location = new System.Drawing.Point(3, 114);
            this.lblDescAnus.Name = "lblDescAnus";
            this.lblDescAnus.Size = new System.Drawing.Size(96, 13);
            this.lblDescAnus.TabIndex = 19;
            this.lblDescAnus.Text = "Descrição do ânus";
            // 
            // txtDescAnus
            // 
            this.txtDescAnus.Location = new System.Drawing.Point(130, 111);
            this.txtDescAnus.Name = "txtDescAnus";
            this.txtDescAnus.Size = new System.Drawing.Size(172, 20);
            this.txtDescAnus.TabIndex = 18;
            // 
            // txtDescBoca
            // 
            this.txtDescBoca.Location = new System.Drawing.Point(130, 85);
            this.txtDescBoca.Name = "txtDescBoca";
            this.txtDescBoca.Size = new System.Drawing.Size(172, 20);
            this.txtDescBoca.TabIndex = 17;
            // 
            // lblDescBoca
            // 
            this.lblDescBoca.AutoSize = true;
            this.lblDescBoca.Location = new System.Drawing.Point(3, 88);
            this.lblDescBoca.Name = "lblDescBoca";
            this.lblDescBoca.Size = new System.Drawing.Size(97, 13);
            this.lblDescBoca.TabIndex = 16;
            this.lblDescBoca.Text = "Descrição da boca";
            // 
            // lblNomeCientifico
            // 
            this.lblNomeCientifico.AutoSize = true;
            this.lblNomeCientifico.Location = new System.Drawing.Point(3, 9);
            this.lblNomeCientifico.Name = "lblNomeCientifico";
            this.lblNomeCientifico.Size = new System.Drawing.Size(82, 13);
            this.lblNomeCientifico.TabIndex = 15;
            this.lblNomeCientifico.Text = "Nome científico";
            // 
            // txtNomeCientifico
            // 
            this.txtNomeCientifico.Location = new System.Drawing.Point(109, 6);
            this.txtNomeCientifico.Name = "txtNomeCientifico";
            this.txtNomeCientifico.Size = new System.Drawing.Size(193, 20);
            this.txtNomeCientifico.TabIndex = 14;
            // 
            // txtBioma
            // 
            this.txtBioma.Location = new System.Drawing.Point(109, 59);
            this.txtBioma.Name = "txtBioma";
            this.txtBioma.Size = new System.Drawing.Size(193, 20);
            this.txtBioma.TabIndex = 13;
            // 
            // lblBioma
            // 
            this.lblBioma.AutoSize = true;
            this.lblBioma.Location = new System.Drawing.Point(3, 62);
            this.lblBioma.Name = "lblBioma";
            this.lblBioma.Size = new System.Drawing.Size(36, 13);
            this.lblBioma.TabIndex = 12;
            this.lblBioma.Text = "Bioma";
            // 
            // cbRespiracao
            // 
            this.cbRespiracao.FormattingEnabled = true;
            this.cbRespiracao.Location = new System.Drawing.Point(109, 32);
            this.cbRespiracao.Name = "cbRespiracao";
            this.cbRespiracao.Size = new System.Drawing.Size(193, 21);
            this.cbRespiracao.TabIndex = 10;
            // 
            // lblRespiracao
            // 
            this.lblRespiracao.AutoSize = true;
            this.lblRespiracao.Location = new System.Drawing.Point(3, 35);
            this.lblRespiracao.Name = "lblRespiracao";
            this.lblRespiracao.Size = new System.Drawing.Size(61, 13);
            this.lblRespiracao.TabIndex = 11;
            this.lblRespiracao.Text = "Respiração";
            // 
            // tabAlimentacao
            // 
            this.tabAlimentacao.Controls.Add(this.txtRegulacaoAgua);
            this.tabAlimentacao.Controls.Add(this.lblRegulacaoAgua);
            this.tabAlimentacao.Controls.Add(this.txtAlimentacaoDescricao);
            this.tabAlimentacao.Controls.Add(this.lblAlimentacaoDescricao);
            this.tabAlimentacao.Controls.Add(this.cbEMetodoAlimentacao);
            this.tabAlimentacao.Controls.Add(this.lblAlimentacaoMetodo);
            this.tabAlimentacao.Controls.Add(this.cbEAlimentacao);
            this.tabAlimentacao.Controls.Add(this.lblAlimentacaoTipo);
            this.tabAlimentacao.Location = new System.Drawing.Point(4, 22);
            this.tabAlimentacao.Name = "tabAlimentacao";
            this.tabAlimentacao.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlimentacao.Size = new System.Drawing.Size(308, 349);
            this.tabAlimentacao.TabIndex = 1;
            this.tabAlimentacao.Text = "Alimentação";
            this.tabAlimentacao.UseVisualStyleBackColor = true;
            // 
            // txtRegulacaoAgua
            // 
            this.txtRegulacaoAgua.Location = new System.Drawing.Point(9, 180);
            this.txtRegulacaoAgua.Multiline = true;
            this.txtRegulacaoAgua.Name = "txtRegulacaoAgua";
            this.txtRegulacaoAgua.Size = new System.Drawing.Size(275, 65);
            this.txtRegulacaoAgua.TabIndex = 9;
            // 
            // lblRegulacaoAgua
            // 
            this.lblRegulacaoAgua.AutoSize = true;
            this.lblRegulacaoAgua.Location = new System.Drawing.Point(9, 163);
            this.lblRegulacaoAgua.Name = "lblRegulacaoAgua";
            this.lblRegulacaoAgua.Size = new System.Drawing.Size(102, 13);
            this.lblRegulacaoAgua.TabIndex = 8;
            this.lblRegulacaoAgua.Text = "Regulação de Água";
            // 
            // txtAlimentacaoDescricao
            // 
            this.txtAlimentacaoDescricao.Location = new System.Drawing.Point(9, 84);
            this.txtAlimentacaoDescricao.Multiline = true;
            this.txtAlimentacaoDescricao.Name = "txtAlimentacaoDescricao";
            this.txtAlimentacaoDescricao.Size = new System.Drawing.Size(275, 65);
            this.txtAlimentacaoDescricao.TabIndex = 7;
            // 
            // lblAlimentacaoDescricao
            // 
            this.lblAlimentacaoDescricao.AutoSize = true;
            this.lblAlimentacaoDescricao.Location = new System.Drawing.Point(6, 67);
            this.lblAlimentacaoDescricao.Name = "lblAlimentacaoDescricao";
            this.lblAlimentacaoDescricao.Size = new System.Drawing.Size(130, 13);
            this.lblAlimentacaoDescricao.TabIndex = 6;
            this.lblAlimentacaoDescricao.Text = "Descrição da alimentação";
            // 
            // cbEMetodoAlimentacao
            // 
            this.cbEMetodoAlimentacao.FormattingEnabled = true;
            this.cbEMetodoAlimentacao.Location = new System.Drawing.Point(113, 36);
            this.cbEMetodoAlimentacao.Name = "cbEMetodoAlimentacao";
            this.cbEMetodoAlimentacao.Size = new System.Drawing.Size(170, 21);
            this.cbEMetodoAlimentacao.TabIndex = 3;
            // 
            // lblAlimentacaoMetodo
            // 
            this.lblAlimentacaoMetodo.AutoSize = true;
            this.lblAlimentacaoMetodo.Location = new System.Drawing.Point(5, 39);
            this.lblAlimentacaoMetodo.Name = "lblAlimentacaoMetodo";
            this.lblAlimentacaoMetodo.Size = new System.Drawing.Size(43, 13);
            this.lblAlimentacaoMetodo.TabIndex = 2;
            this.lblAlimentacaoMetodo.Text = "Método";
            // 
            // cbEAlimentacao
            // 
            this.cbEAlimentacao.FormattingEnabled = true;
            this.cbEAlimentacao.Location = new System.Drawing.Point(113, 8);
            this.cbEAlimentacao.Name = "cbEAlimentacao";
            this.cbEAlimentacao.Size = new System.Drawing.Size(170, 21);
            this.cbEAlimentacao.TabIndex = 1;
            // 
            // lblAlimentacaoTipo
            // 
            this.lblAlimentacaoTipo.AutoSize = true;
            this.lblAlimentacaoTipo.Location = new System.Drawing.Point(5, 11);
            this.lblAlimentacaoTipo.Name = "lblAlimentacaoTipo";
            this.lblAlimentacaoTipo.Size = new System.Drawing.Size(28, 13);
            this.lblAlimentacaoTipo.TabIndex = 0;
            this.lblAlimentacaoTipo.Text = "Tipo";
            // 
            // tabDefesaLocomocao
            // 
            this.tabDefesaLocomocao.Controls.Add(this.txtDescricaoLocomocao);
            this.tabDefesaLocomocao.Controls.Add(this.lblLocomocaoDescricao);
            this.tabDefesaLocomocao.Controls.Add(this.txtDefesaDescricao);
            this.tabDefesaLocomocao.Controls.Add(this.lblDefesaDescricao);
            this.tabDefesaLocomocao.Controls.Add(this.lblELocomocao);
            this.tabDefesaLocomocao.Controls.Add(this.chkLstELocomocao);
            this.tabDefesaLocomocao.Controls.Add(this.chkLstEDefesa);
            this.tabDefesaLocomocao.Controls.Add(this.lblEDefesa);
            this.tabDefesaLocomocao.Location = new System.Drawing.Point(4, 22);
            this.tabDefesaLocomocao.Name = "tabDefesaLocomocao";
            this.tabDefesaLocomocao.Size = new System.Drawing.Size(308, 349);
            this.tabDefesaLocomocao.TabIndex = 2;
            this.tabDefesaLocomocao.Text = "Def | Loc";
            this.tabDefesaLocomocao.UseVisualStyleBackColor = true;
            // 
            // txtDescricaoLocomocao
            // 
            this.txtDescricaoLocomocao.Location = new System.Drawing.Point(9, 280);
            this.txtDescricaoLocomocao.Multiline = true;
            this.txtDescricaoLocomocao.Name = "txtDescricaoLocomocao";
            this.txtDescricaoLocomocao.Size = new System.Drawing.Size(290, 60);
            this.txtDescricaoLocomocao.TabIndex = 7;
            // 
            // lblLocomocaoDescricao
            // 
            this.lblLocomocaoDescricao.AutoSize = true;
            this.lblLocomocaoDescricao.Location = new System.Drawing.Point(6, 264);
            this.lblLocomocaoDescricao.Name = "lblLocomocaoDescricao";
            this.lblLocomocaoDescricao.Size = new System.Drawing.Size(175, 13);
            this.lblLocomocaoDescricao.TabIndex = 6;
            this.lblLocomocaoDescricao.Text = "Descrição dos meios de locomoção";
            // 
            // txtDefesaDescricao
            // 
            this.txtDefesaDescricao.Location = new System.Drawing.Point(9, 184);
            this.txtDefesaDescricao.Multiline = true;
            this.txtDefesaDescricao.Name = "txtDefesaDescricao";
            this.txtDefesaDescricao.Size = new System.Drawing.Size(290, 60);
            this.txtDefesaDescricao.TabIndex = 5;
            // 
            // lblDefesaDescricao
            // 
            this.lblDefesaDescricao.AutoSize = true;
            this.lblDefesaDescricao.Location = new System.Drawing.Point(6, 168);
            this.lblDefesaDescricao.Name = "lblDefesaDescricao";
            this.lblDefesaDescricao.Size = new System.Drawing.Size(155, 13);
            this.lblDefesaDescricao.TabIndex = 4;
            this.lblDefesaDescricao.Text = "Descrição dos meios de defesa";
            // 
            // lblELocomocao
            // 
            this.lblELocomocao.AutoSize = true;
            this.lblELocomocao.Location = new System.Drawing.Point(161, 10);
            this.lblELocomocao.Name = "lblELocomocao";
            this.lblELocomocao.Size = new System.Drawing.Size(105, 13);
            this.lblELocomocao.TabIndex = 3;
            this.lblELocomocao.Text = "Meios de locomoção";
            // 
            // chkLstELocomocao
            // 
            this.chkLstELocomocao.FormattingEnabled = true;
            this.chkLstELocomocao.Items.AddRange(new object[] {
            " "});
            this.chkLstELocomocao.Location = new System.Drawing.Point(164, 26);
            this.chkLstELocomocao.Name = "chkLstELocomocao";
            this.chkLstELocomocao.Size = new System.Drawing.Size(135, 124);
            this.chkLstELocomocao.TabIndex = 2;
            // 
            // chkLstEDefesa
            // 
            this.chkLstEDefesa.FormattingEnabled = true;
            this.chkLstEDefesa.Items.AddRange(new object[] {
            " "});
            this.chkLstEDefesa.Location = new System.Drawing.Point(9, 26);
            this.chkLstEDefesa.Name = "chkLstEDefesa";
            this.chkLstEDefesa.Size = new System.Drawing.Size(135, 124);
            this.chkLstEDefesa.TabIndex = 1;
            // 
            // lblEDefesa
            // 
            this.lblEDefesa.AutoSize = true;
            this.lblEDefesa.Location = new System.Drawing.Point(6, 10);
            this.lblEDefesa.Name = "lblEDefesa";
            this.lblEDefesa.Size = new System.Drawing.Size(85, 13);
            this.lblEDefesa.TabIndex = 0;
            this.lblEDefesa.Text = "Meios de defesa";
            // 
            // tabDesenvolvimentoEmbrionario
            // 
            this.tabDesenvolvimentoEmbrionario.Controls.Add(this.txtEpocaReproducao);
            this.tabDesenvolvimentoEmbrionario.Controls.Add(this.chkHasEpocaSexo);
            this.tabDesenvolvimentoEmbrionario.Controls.Add(this.txtReproducaoDescricaoCorte);
            this.tabDesenvolvimentoEmbrionario.Controls.Add(this.chkReproducaoHasCorte);
            this.tabDesenvolvimentoEmbrionario.Controls.Add(this.txtReproducaoDescricao);
            this.tabDesenvolvimentoEmbrionario.Controls.Add(this.lblReproducaoDescricao);
            this.tabDesenvolvimentoEmbrionario.Controls.Add(this.lblEDevEmbrionario);
            this.tabDesenvolvimentoEmbrionario.Controls.Add(this.cbEDevEmbrionario);
            this.tabDesenvolvimentoEmbrionario.Controls.Add(this.lblEReproducao);
            this.tabDesenvolvimentoEmbrionario.Controls.Add(this.cbEReproducao);
            this.tabDesenvolvimentoEmbrionario.Location = new System.Drawing.Point(4, 22);
            this.tabDesenvolvimentoEmbrionario.Name = "tabDesenvolvimentoEmbrionario";
            this.tabDesenvolvimentoEmbrionario.Size = new System.Drawing.Size(308, 349);
            this.tabDesenvolvimentoEmbrionario.TabIndex = 3;
            this.tabDesenvolvimentoEmbrionario.Text = "Dev. Emb";
            this.tabDesenvolvimentoEmbrionario.UseVisualStyleBackColor = true;
            // 
            // txtEpocaReproducao
            // 
            this.txtEpocaReproducao.Enabled = false;
            this.txtEpocaReproducao.Location = new System.Drawing.Point(6, 266);
            this.txtEpocaReproducao.Multiline = true;
            this.txtEpocaReproducao.Name = "txtEpocaReproducao";
            this.txtEpocaReproducao.Size = new System.Drawing.Size(297, 60);
            this.txtEpocaReproducao.TabIndex = 10;
            // 
            // chkHasEpocaSexo
            // 
            this.chkHasEpocaSexo.AutoSize = true;
            this.chkHasEpocaSexo.Location = new System.Drawing.Point(6, 243);
            this.chkHasEpocaSexo.Name = "chkHasEpocaSexo";
            this.chkHasEpocaSexo.Size = new System.Drawing.Size(168, 17);
            this.chkHasEpocaSexo.TabIndex = 9;
            this.chkHasEpocaSexo.Text = "Possui época de reprodução?";
            this.chkHasEpocaSexo.UseVisualStyleBackColor = true;
            // 
            // txtReproducaoDescricaoCorte
            // 
            this.txtReproducaoDescricaoCorte.Enabled = false;
            this.txtReproducaoDescricaoCorte.Location = new System.Drawing.Point(6, 176);
            this.txtReproducaoDescricaoCorte.Multiline = true;
            this.txtReproducaoDescricaoCorte.Name = "txtReproducaoDescricaoCorte";
            this.txtReproducaoDescricaoCorte.Size = new System.Drawing.Size(297, 60);
            this.txtReproducaoDescricaoCorte.TabIndex = 8;
            // 
            // chkReproducaoHasCorte
            // 
            this.chkReproducaoHasCorte.AutoSize = true;
            this.chkReproducaoHasCorte.Location = new System.Drawing.Point(6, 153);
            this.chkReproducaoHasCorte.Name = "chkReproducaoHasCorte";
            this.chkReproducaoHasCorte.Size = new System.Drawing.Size(181, 17);
            this.chkReproducaoHasCorte.TabIndex = 7;
            this.chkReproducaoHasCorte.Text = "Possui comportamento de corte?";
            this.chkReproducaoHasCorte.UseVisualStyleBackColor = true;
            this.chkReproducaoHasCorte.CheckedChanged += new System.EventHandler(this.chkReproducaoHasCorte_CheckedChanged);
            // 
            // txtReproducaoDescricao
            // 
            this.txtReproducaoDescricao.Location = new System.Drawing.Point(6, 84);
            this.txtReproducaoDescricao.Multiline = true;
            this.txtReproducaoDescricao.Name = "txtReproducaoDescricao";
            this.txtReproducaoDescricao.Size = new System.Drawing.Size(297, 60);
            this.txtReproducaoDescricao.TabIndex = 5;
            // 
            // lblReproducaoDescricao
            // 
            this.lblReproducaoDescricao.AutoSize = true;
            this.lblReproducaoDescricao.Location = new System.Drawing.Point(3, 68);
            this.lblReproducaoDescricao.Name = "lblReproducaoDescricao";
            this.lblReproducaoDescricao.Size = new System.Drawing.Size(127, 13);
            this.lblReproducaoDescricao.TabIndex = 4;
            this.lblReproducaoDescricao.Text = "Descrição da reprodução";
            // 
            // lblEDevEmbrionario
            // 
            this.lblEDevEmbrionario.AutoSize = true;
            this.lblEDevEmbrionario.Location = new System.Drawing.Point(3, 39);
            this.lblEDevEmbrionario.Name = "lblEDevEmbrionario";
            this.lblEDevEmbrionario.Size = new System.Drawing.Size(85, 13);
            this.lblEDevEmbrionario.TabIndex = 3;
            this.lblEDevEmbrionario.Text = "Meio do embrião";
            // 
            // cbEDevEmbrionario
            // 
            this.cbEDevEmbrionario.FormattingEnabled = true;
            this.cbEDevEmbrionario.Location = new System.Drawing.Point(108, 36);
            this.cbEDevEmbrionario.Name = "cbEDevEmbrionario";
            this.cbEDevEmbrionario.Size = new System.Drawing.Size(195, 21);
            this.cbEDevEmbrionario.TabIndex = 2;
            // 
            // lblEReproducao
            // 
            this.lblEReproducao.AutoSize = true;
            this.lblEReproducao.Location = new System.Drawing.Point(3, 11);
            this.lblEReproducao.Name = "lblEReproducao";
            this.lblEReproducao.Size = new System.Drawing.Size(100, 13);
            this.lblEReproducao.TabIndex = 1;
            this.lblEReproducao.Text = "Tipo de reprodução";
            // 
            // cbEReproducao
            // 
            this.cbEReproducao.FormattingEnabled = true;
            this.cbEReproducao.Location = new System.Drawing.Point(107, 8);
            this.cbEReproducao.Name = "cbEReproducao";
            this.cbEReproducao.Size = new System.Drawing.Size(196, 21);
            this.cbEReproducao.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAparencia
            // 
            this.lblAparencia.AutoSize = true;
            this.lblAparencia.Location = new System.Drawing.Point(3, 150);
            this.lblAparencia.Name = "lblAparencia";
            this.lblAparencia.Size = new System.Drawing.Size(55, 13);
            this.lblAparencia.TabIndex = 22;
            this.lblAparencia.Text = "Aparência";
            // 
            // txtAparencia
            // 
            this.txtAparencia.Location = new System.Drawing.Point(6, 166);
            this.txtAparencia.Multiline = true;
            this.txtAparencia.Name = "txtAparencia";
            this.txtAparencia.Size = new System.Drawing.Size(296, 65);
            this.txtAparencia.TabIndex = 23;
            // 
            // lblMembros
            // 
            this.lblMembros.AutoSize = true;
            this.lblMembros.Location = new System.Drawing.Point(3, 253);
            this.lblMembros.Name = "lblMembros";
            this.lblMembros.Size = new System.Drawing.Size(50, 13);
            this.lblMembros.TabIndex = 24;
            this.lblMembros.Text = "Membros";
            // 
            // txtDescMembros
            // 
            this.txtDescMembros.Location = new System.Drawing.Point(6, 269);
            this.txtDescMembros.Multiline = true;
            this.txtDescMembros.Name = "txtDescMembros";
            this.txtDescMembros.Size = new System.Drawing.Size(296, 65);
            this.txtDescMembros.TabIndex = 25;
            // 
            // FrmAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 427);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAnimal";
            this.Text = "FrmAnimal";
            this.tabControl.ResumeLayout(false);
            this.tabGeral.ResumeLayout(false);
            this.tabGeral.PerformLayout();
            this.tabCaracteristicas.ResumeLayout(false);
            this.tabCaracteristicas.PerformLayout();
            this.tabAlimentacao.ResumeLayout(false);
            this.tabAlimentacao.PerformLayout();
            this.tabDefesaLocomocao.ResumeLayout(false);
            this.tabDefesaLocomocao.PerformLayout();
            this.tabDesenvolvimentoEmbrionario.ResumeLayout(false);
            this.tabDesenvolvimentoEmbrionario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblFilo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cbFilo;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabGeral;
        private System.Windows.Forms.TabPage tabAlimentacao;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblPersonagem;
        private System.Windows.Forms.TextBox txtPersonagem;
        private System.Windows.Forms.CheckBox checkCampoPersonagem;
        private System.Windows.Forms.TextBox txtAdaptacoes;
        private System.Windows.Forms.Label lblAdaptacoes;
        private System.Windows.Forms.Label lblAlimentacaoTipo;
        private System.Windows.Forms.ComboBox cbEAlimentacao;
        private System.Windows.Forms.ComboBox cbEMetodoAlimentacao;
        private System.Windows.Forms.Label lblAlimentacaoMetodo;
        private System.Windows.Forms.Label lblAlimentacaoDescricao;
        private System.Windows.Forms.Label lblRegulacaoAgua;
        private System.Windows.Forms.TextBox txtAlimentacaoDescricao;
        private System.Windows.Forms.TextBox txtRegulacaoAgua;
        private System.Windows.Forms.Label lblEDefesa;
        private System.Windows.Forms.Label lblELocomocao;
        private System.Windows.Forms.CheckedListBox chkLstELocomocao;
        private System.Windows.Forms.CheckedListBox chkLstEDefesa;
        private System.Windows.Forms.TabPage tabDefesaLocomocao;
        private System.Windows.Forms.TextBox txtDefesaDescricao;
        private System.Windows.Forms.Label lblDefesaDescricao;
        private System.Windows.Forms.TextBox txtDescricaoLocomocao;
        private System.Windows.Forms.Label lblLocomocaoDescricao;
        private System.Windows.Forms.TabPage tabDesenvolvimentoEmbrionario;
        private System.Windows.Forms.Label lblEReproducao;
        private System.Windows.Forms.ComboBox cbEReproducao;
        private System.Windows.Forms.ComboBox cbEDevEmbrionario;
        private System.Windows.Forms.Label lblEDevEmbrionario;
        private System.Windows.Forms.TextBox txtReproducaoDescricao;
        private System.Windows.Forms.Label lblReproducaoDescricao;
        private System.Windows.Forms.CheckBox chkReproducaoHasCorte;
        private System.Windows.Forms.TextBox txtReproducaoDescricaoCorte;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtEpocaReproducao;
        private System.Windows.Forms.CheckBox chkHasEpocaSexo;
        private System.Windows.Forms.TextBox txtHabitat;
        private System.Windows.Forms.Label lblHabitat;
        private System.Windows.Forms.TabPage tabCaracteristicas;
        private System.Windows.Forms.TextBox txtBioma;
        private System.Windows.Forms.Label lblBioma;
        private System.Windows.Forms.ComboBox cbRespiracao;
        private System.Windows.Forms.Label lblRespiracao;
        private System.Windows.Forms.TextBox txtDescBoca;
        private System.Windows.Forms.Label lblDescBoca;
        private System.Windows.Forms.Label lblNomeCientifico;
        private System.Windows.Forms.TextBox txtNomeCientifico;
        private System.Windows.Forms.TextBox txtDescAnus;
        private System.Windows.Forms.CheckBox chkHasBoca;
        private System.Windows.Forms.CheckBox chkHasAnus;
        private System.Windows.Forms.Label lblDescAnus;
        private System.Windows.Forms.Label lblAparencia;
        private System.Windows.Forms.Label lblMembros;
        private System.Windows.Forms.TextBox txtAparencia;
        private System.Windows.Forms.TextBox txtDescMembros;
    }
}