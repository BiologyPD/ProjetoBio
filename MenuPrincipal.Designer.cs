
namespace ProjetoBio
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.pbAqua = new System.Windows.Forms.PictureBox();
            this.pbAir = new System.Windows.Forms.PictureBox();
            this.dgAir = new System.Windows.Forms.DataGridView();
            this.dgParasite = new System.Windows.Forms.DataGridView();
            this.dgGround = new System.Windows.Forms.DataGridView();
            this.dgAqua = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.pbGround = new System.Windows.Forms.PictureBox();
            this.pbParasite = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAqua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgParasite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAqua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbParasite)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(809, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione uma categoria";
            // 
            // pbAqua
            // 
            this.pbAqua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAqua.Image = ((System.Drawing.Image)(resources.GetObject("pbAqua.Image")));
            this.pbAqua.Location = new System.Drawing.Point(18, 44);
            this.pbAqua.Name = "pbAqua";
            this.pbAqua.Size = new System.Drawing.Size(335, 335);
            this.pbAqua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAqua.TabIndex = 4;
            this.pbAqua.TabStop = false;
            this.pbAqua.Click += new System.EventHandler(this.pbAqua_Click);
            this.pbAqua.MouseHover += new System.EventHandler(this.pbAqua_Hover);
            // 
            // pbAir
            // 
            this.pbAir.Image = ((System.Drawing.Image)(resources.GetObject("pbAir.Image")));
            this.pbAir.Location = new System.Drawing.Point(1574, 44);
            this.pbAir.Name = "pbAir";
            this.pbAir.Size = new System.Drawing.Size(335, 335);
            this.pbAir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAir.TabIndex = 5;
            this.pbAir.TabStop = false;
            // 
            // dgAir
            // 
            this.dgAir.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.dgAir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAir.Location = new System.Drawing.Point(1077, 82);
            this.dgAir.Name = "dgAir";
            this.dgAir.Size = new System.Drawing.Size(499, 297);
            this.dgAir.TabIndex = 9;
            // 
            // dgParasite
            // 
            this.dgParasite.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.dgParasite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgParasite.Location = new System.Drawing.Point(1074, 748);
            this.dgParasite.Name = "dgParasite";
            this.dgParasite.Size = new System.Drawing.Size(499, 297);
            this.dgParasite.TabIndex = 10;
            // 
            // dgGround
            // 
            this.dgGround.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.dgGround.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGround.Location = new System.Drawing.Point(355, 748);
            this.dgGround.Name = "dgGround";
            this.dgGround.Size = new System.Drawing.Size(499, 297);
            this.dgGround.TabIndex = 11;
            // 
            // dgAqua
            // 
            this.dgAqua.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.dgAqua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAqua.Location = new System.Drawing.Point(353, 82);
            this.dgAqua.Name = "dgAqua";
            this.dgAqua.Size = new System.Drawing.Size(499, 297);
            this.dgAqua.TabIndex = 7;
            this.dgAqua.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAqua_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkCyan;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.label2.Location = new System.Drawing.Point(506, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "Vida Aquática";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSair.Location = new System.Drawing.Point(1792, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(128, 46);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pbGround
            // 
            this.pbGround.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbGround.BackgroundImage")));
            this.pbGround.Location = new System.Drawing.Point(18, 710);
            this.pbGround.Name = "pbGround";
            this.pbGround.Size = new System.Drawing.Size(335, 335);
            this.pbGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGround.TabIndex = 13;
            this.pbGround.TabStop = false;
            // 
            // pbParasite
            // 
            this.pbParasite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbParasite.BackgroundImage")));
            this.pbParasite.Location = new System.Drawing.Point(1574, 710);
            this.pbParasite.Name = "pbParasite";
            this.pbParasite.Size = new System.Drawing.Size(335, 335);
            this.pbParasite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbParasite.TabIndex = 14;
            this.pbParasite.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkCyan;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.label3.Location = new System.Drawing.Point(1251, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 37);
            this.label3.TabIndex = 15;
            this.label3.Text = "Vida Aérea";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkCyan;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.label4.Location = new System.Drawing.Point(1222, 708);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 37);
            this.label4.TabIndex = 16;
            this.label4.Text = "Vida Parasitária";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkCyan;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.label5.Location = new System.Drawing.Point(506, 708);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 37);
            this.label5.TabIndex = 17;
            this.label5.Text = "Vida Terrestre";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1920, 1057);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbParasite);
            this.Controls.Add(this.pbGround);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dgAqua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgAir);
            this.Controls.Add(this.dgParasite);
            this.Controls.Add(this.dgGround);
            this.Controls.Add(this.pbAqua);
            this.Controls.Add(this.pbAir);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.ShowIcon = false;
            this.Text = "  ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAqua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgParasite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAqua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbParasite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbAqua;
        private System.Windows.Forms.PictureBox pbAir;
        private System.Windows.Forms.DataGridView dgAir;
        private System.Windows.Forms.DataGridView dgParasite;
        private System.Windows.Forms.DataGridView dgGround;
        private System.Windows.Forms.DataGridView dgAqua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pbGround;
        private System.Windows.Forms.PictureBox pbParasite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}