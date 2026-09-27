namespace Sinema_Oto_Ece
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSec = new Button();
            btnSil = new Button();
            SuspendLayout();
            // 
            // btnSec
            // 
            btnSec.Location = new Point(694, 360);
            btnSec.Name = "btnSec";
            btnSec.Size = new Size(94, 29);
            btnSec.TabIndex = 0;
            btnSec.Text = "ekle";
            btnSec.UseVisualStyleBackColor = true;
            btnSec.Click += btnSec_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(694, 409);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 1;
            btnSil.Text = "sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSil);
            Controls.Add(btnSec);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnSec;
        private Button btnSil;
    }
}
