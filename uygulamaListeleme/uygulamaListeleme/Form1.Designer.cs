
namespace uygulamaListeleme
{
    partial class Form1
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
            this.yenile = new System.Windows.Forms.Button();
            this.sonlandir = new System.Windows.Forms.Button();
            this.islemler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // yenile
            // 
            this.yenile.BackColor = System.Drawing.Color.White;
            this.yenile.Location = new System.Drawing.Point(60, 13);
            this.yenile.Name = "yenile";
            this.yenile.Size = new System.Drawing.Size(85, 23);
            this.yenile.TabIndex = 0;
            this.yenile.Text = "YENİLE";
            this.yenile.UseVisualStyleBackColor = false;
            this.yenile.Click += new System.EventHandler(this.yenile_Click);
            // 
            // sonlandir
            // 
            this.sonlandir.BackColor = System.Drawing.Color.White;
            this.sonlandir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sonlandir.Location = new System.Drawing.Point(202, 13);
            this.sonlandir.Name = "sonlandir";
            this.sonlandir.Size = new System.Drawing.Size(85, 23);
            this.sonlandir.TabIndex = 1;
            this.sonlandir.Text = "SONLANDIR";
            this.sonlandir.UseVisualStyleBackColor = false;
            this.sonlandir.Click += new System.EventHandler(this.sonlandir_Click);
            // 
            // islemler
            // 
            this.islemler.FormattingEnabled = true;
            this.islemler.Location = new System.Drawing.Point(59, 53);
            this.islemler.Name = "islemler";
            this.islemler.Size = new System.Drawing.Size(233, 316);
            this.islemler.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 386);
            this.Controls.Add(this.islemler);
            this.Controls.Add(this.sonlandir);
            this.Controls.Add(this.yenile);
            this.Name = "Form1";
            this.Text = "UYGULAMA LİSTELEME&SONLANDIRMA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button yenile;
        private System.Windows.Forms.Button sonlandir;
        private System.Windows.Forms.ListBox islemler;
    }
}

