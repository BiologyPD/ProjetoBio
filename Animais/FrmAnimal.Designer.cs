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
            this.panelBase = new System.Windows.Forms.Panel();
            this.lblRespiracao = new System.Windows.Forms.Label();
            this.cbRespiracao = new System.Windows.Forms.ComboBox();
            this.cbFilo = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblFilo = new System.Windows.Forms.Label();
            this.panelBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(3, 11);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelBase
            // 
            this.panelBase.Controls.Add(this.lblRespiracao);
            this.panelBase.Controls.Add(this.cbRespiracao);
            this.panelBase.Controls.Add(this.cbFilo);
            this.panelBase.Controls.Add(this.txtNome);
            this.panelBase.Controls.Add(this.lblFilo);
            this.panelBase.Controls.Add(this.lblNome);
            this.panelBase.Location = new System.Drawing.Point(12, 12);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(214, 106);
            this.panelBase.TabIndex = 1;
            // 
            // lblRespiracao
            // 
            this.lblRespiracao.AutoSize = true;
            this.lblRespiracao.Location = new System.Drawing.Point(3, 66);
            this.lblRespiracao.Name = "lblRespiracao";
            this.lblRespiracao.Size = new System.Drawing.Size(61, 13);
            this.lblRespiracao.TabIndex = 5;
            this.lblRespiracao.Text = "Respiração";
            // 
            // cbRespiracao
            // 
            this.cbRespiracao.FormattingEnabled = true;
            this.cbRespiracao.Location = new System.Drawing.Point(86, 63);
            this.cbRespiracao.Name = "cbRespiracao";
            this.cbRespiracao.Size = new System.Drawing.Size(121, 21);
            this.cbRespiracao.TabIndex = 4;
            // 
            // cbFilo
            // 
            this.cbFilo.FormattingEnabled = true;
            this.cbFilo.Location = new System.Drawing.Point(86, 35);
            this.cbFilo.Name = "cbFilo";
            this.cbFilo.Size = new System.Drawing.Size(121, 21);
            this.cbFilo.TabIndex = 3;
            this.cbFilo.SelectedIndexChanged += new System.EventHandler(this.cbFilo_SelectedIndexChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(86, 8);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(121, 20);
            this.txtNome.TabIndex = 2;
            // 
            // lblFilo
            // 
            this.lblFilo.AutoSize = true;
            this.lblFilo.Location = new System.Drawing.Point(3, 38);
            this.lblFilo.Name = "lblFilo";
            this.lblFilo.Size = new System.Drawing.Size(23, 13);
            this.lblFilo.TabIndex = 1;
            this.lblFilo.Text = "Filo";
            this.lblFilo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 548);
            this.Controls.Add(this.panelBase);
            this.Name = "FrmAnimal";
            this.Text = "FrmAnimal";
            this.panelBase.ResumeLayout(false);
            this.panelBase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Panel panelBase;
        private System.Windows.Forms.Label lblFilo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblRespiracao;
        private System.Windows.Forms.ComboBox cbRespiracao;
        private System.Windows.Forms.ComboBox cbFilo;
    }
}