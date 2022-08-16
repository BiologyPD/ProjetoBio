
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgAir = new System.Windows.Forms.DataGridView();
            this.dgParasite = new System.Windows.Forms.DataGridView();
            this.dgGround = new System.Windows.Forms.DataGridView();
            this.dgAqua = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAqua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgParasite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAqua)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(855, 9);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1574, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 354);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
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
            this.dgParasite.Location = new System.Drawing.Point(1077, 748);
            this.dgParasite.Name = "dgParasite";
            this.dgParasite.Size = new System.Drawing.Size(499, 297);
            this.dgParasite.TabIndex = 10;
            // 
            // dgGround
            // 
            this.dgGround.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.dgGround.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGround.Location = new System.Drawing.Point(353, 748);
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
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1920, 1057);
            this.Controls.Add(this.dgAqua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgAir);
            this.Controls.Add(this.dgParasite);
            this.Controls.Add(this.dgGround);
            this.Controls.Add(this.pbAqua);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MenuPrincipal";
            this.ShowIcon = false;
            this.Text = "  ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAqua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgParasite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAqua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbAqua;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgAir;
        private System.Windows.Forms.DataGridView dgParasite;
        private System.Windows.Forms.DataGridView dgGround;
        private System.Windows.Forms.DataGridView dgAqua;
        private System.Windows.Forms.Label label2;
    }
}