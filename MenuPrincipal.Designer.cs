
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
            this.dgAqua = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.grpDg = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAqua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAqua)).BeginInit();
            this.grpDg.SuspendLayout();
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
            this.pictureBox1.Size = new System.Drawing.Size(335, 335);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // dgAqua
            // 
            this.dgAqua.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.dgAqua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAqua.Location = new System.Drawing.Point(0, 57);
            this.dgAqua.Name = "dgAqua";
            this.dgAqua.Size = new System.Drawing.Size(499, 297);
            this.dgAqua.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkCyan;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.label2.Location = new System.Drawing.Point(162, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "Vida Aquática";
            // 
            // grpDg
            // 
            this.grpDg.Controls.Add(this.label2);
            this.grpDg.Controls.Add(this.dgAqua);
            this.grpDg.Location = new System.Drawing.Point(353, 25);
            this.grpDg.Name = "grpDg";
            this.grpDg.Size = new System.Drawing.Size(499, 354);
            this.grpDg.TabIndex = 9;
            this.grpDg.TabStop = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1920, 1057);
            this.Controls.Add(this.pbAqua);
            this.Controls.Add(this.grpDg);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgAqua)).EndInit();
            this.grpDg.ResumeLayout(false);
            this.grpDg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbAqua;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgAqua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpDg;
    }
}