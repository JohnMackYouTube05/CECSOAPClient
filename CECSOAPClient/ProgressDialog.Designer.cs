namespace CECSOAPClient
{
    partial class ProgressDialog
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
            this.progText = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // progText
            // 
            this.progText.AutoSize = true;
            this.progText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.progText.Location = new System.Drawing.Point(12, 29);
            this.progText.Name = "progText";
            this.progText.Size = new System.Drawing.Size(107, 20);
            this.progText.TabIndex = 0;
            this.progText.Text = "Please wait...";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 68);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(444, 55);
            this.progressBar1.TabIndex = 1;
            // 
            // ProgressDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 144);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.progText);
            this.Name = "ProgressDialog";
            this.Text = "ProgressDialog";
            this.Load += new System.EventHandler(this.ProgressDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label progText;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}