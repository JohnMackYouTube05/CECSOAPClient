namespace CECSOAPClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnLocationsMenu = new System.Windows.Forms.Button();
            this.btnMachinesMenu = new System.Windows.Forms.Button();
            this.btnCardServicesMenu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CEC SOAP Client";
            // 
            // btnLocationsMenu
            // 
            this.btnLocationsMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btnLocationsMenu.Location = new System.Drawing.Point(18, 74);
            this.btnLocationsMenu.Name = "btnLocationsMenu";
            this.btnLocationsMenu.Size = new System.Drawing.Size(167, 60);
            this.btnLocationsMenu.TabIndex = 1;
            this.btnLocationsMenu.Text = "Locations";
            this.btnLocationsMenu.UseVisualStyleBackColor = true;
            this.btnLocationsMenu.Click += new System.EventHandler(this.btnLocationsMenu_Click);
            // 
            // btnMachinesMenu
            // 
            this.btnMachinesMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btnMachinesMenu.Location = new System.Drawing.Point(215, 74);
            this.btnMachinesMenu.Name = "btnMachinesMenu";
            this.btnMachinesMenu.Size = new System.Drawing.Size(167, 60);
            this.btnMachinesMenu.TabIndex = 2;
            this.btnMachinesMenu.Text = "Machines";
            this.btnMachinesMenu.UseVisualStyleBackColor = true;
            this.btnMachinesMenu.Click += new System.EventHandler(this.btnMachinesMenu_Click);
            // 
            // btnCardServicesMenu
            // 
            this.btnCardServicesMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btnCardServicesMenu.Location = new System.Drawing.Point(412, 74);
            this.btnCardServicesMenu.Name = "btnCardServicesMenu";
            this.btnCardServicesMenu.Size = new System.Drawing.Size(167, 60);
            this.btnCardServicesMenu.TabIndex = 3;
            this.btnCardServicesMenu.Text = "Card Services";
            this.btnCardServicesMenu.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.Location = new System.Drawing.Point(609, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 60);
            this.button1.TabIndex = 4;
            this.button1.Text = "Customer Services";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCardServicesMenu);
            this.Controls.Add(this.btnMachinesMenu);
            this.Controls.Add(this.btnLocationsMenu);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CEC SOAP Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLocationsMenu;
        private System.Windows.Forms.Button btnMachinesMenu;
        private System.Windows.Forms.Button btnCardServicesMenu;
        private System.Windows.Forms.Button button1;
    }
}

