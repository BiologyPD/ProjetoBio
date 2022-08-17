
namespace ProjetoBio
{
    partial class AnimaisAqua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimaisAqua));
            this.pbNiphates = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbNiphates)).BeginInit();
            this.SuspendLayout();
            // 
            // pbNiphates
            // 
            this.pbNiphates.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbNiphates.BackgroundImage")));
            this.pbNiphates.Location = new System.Drawing.Point(12, 12);
            this.pbNiphates.Name = "pbNiphates";
            this.pbNiphates.Size = new System.Drawing.Size(267, 191);
            this.pbNiphates.TabIndex = 0;
            this.pbNiphates.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.label1.Location = new System.Drawing.Point(285, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Niphates alba Van Soest";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.label2.Location = new System.Drawing.Point(285, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Porífera";
            // 
            // AnimaisAqua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbNiphates);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnimaisAqua";
            this.Text = "AnimaisAqua";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbNiphates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbNiphates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}