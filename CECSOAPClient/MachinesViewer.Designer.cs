namespace CECSOAPClient
{
    partial class MachinesViewer
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
            this.cbMachines = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbMachineID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbVIPPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbCCPlusAllowed = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbCourtesyAllowed = new System.Windows.Forms.Label();
            this.lbBonusAllowed = new System.Windows.Forms.Label();
            this.lbCreditsAllowed = new System.Windows.Forms.Label();
            this.lbCreditsBeforeBonus = new System.Windows.Forms.Label();
            this.lbGamesAllowed = new System.Windows.Forms.Label();
            this.tbGameProfileID = new System.Windows.Forms.TextBox();
            this.tbGameID = new System.Windows.Forms.TextBox();
            this.pbMachinePreview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMachinePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMachines
            // 
            this.cbMachines.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbMachines.FormattingEnabled = true;
            this.cbMachines.Location = new System.Drawing.Point(298, 9);
            this.cbMachines.Name = "cbMachines";
            this.cbMachines.Size = new System.Drawing.Size(489, 32);
            this.cbMachines.TabIndex = 3;
            this.cbMachines.SelectedValueChanged += new System.EventHandler(this.cbMachines_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Arcade Machine Viewer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(17, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Machine ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(17, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price:";
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbPrice.Location = new System.Drawing.Point(75, 135);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(328, 29);
            this.tbPrice.TabIndex = 6;
            // 
            // tbMachineID
            // 
            this.tbMachineID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbMachineID.Location = new System.Drawing.Point(135, 100);
            this.tbMachineID.Name = "tbMachineID";
            this.tbMachineID.Size = new System.Drawing.Size(268, 29);
            this.tbMachineID.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.Location = new System.Drawing.Point(17, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "VIP Price:";
            // 
            // tbVIPPrice
            // 
            this.tbVIPPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbVIPPrice.Location = new System.Drawing.Point(109, 173);
            this.tbVIPPrice.Name = "tbVIPPrice";
            this.tbVIPPrice.Size = new System.Drawing.Size(294, 29);
            this.tbVIPPrice.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.Location = new System.Drawing.Point(17, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Game Profile ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label6.Location = new System.Drawing.Point(17, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Game ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label7.Location = new System.Drawing.Point(17, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Games Allowed:";
            // 
            // lbCCPlusAllowed
            // 
            this.lbCCPlusAllowed.AutoSize = true;
            this.lbCCPlusAllowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbCCPlusAllowed.ForeColor = System.Drawing.Color.Green;
            this.lbCCPlusAllowed.Location = new System.Drawing.Point(215, 401);
            this.lbCCPlusAllowed.Name = "lbCCPlusAllowed";
            this.lbCCPlusAllowed.Size = new System.Drawing.Size(0, 24);
            this.lbCCPlusAllowed.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label9.Location = new System.Drawing.Point(17, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(192, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "Credits Before Bonus:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label10.Location = new System.Drawing.Point(17, 329);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 24);
            this.label10.TabIndex = 15;
            this.label10.Text = "Credits Allowed:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label11.Location = new System.Drawing.Point(19, 353);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 24);
            this.label11.TabIndex = 16;
            this.label11.Text = "Bonus Allowed:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label12.Location = new System.Drawing.Point(20, 377);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 24);
            this.label12.TabIndex = 17;
            this.label12.Text = "Courtesy Allowed:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label13.Location = new System.Drawing.Point(20, 401);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(155, 24);
            this.label13.TabIndex = 18;
            this.label13.Text = "CC Plus Allowed:";
            // 
            // lbCourtesyAllowed
            // 
            this.lbCourtesyAllowed.AutoSize = true;
            this.lbCourtesyAllowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbCourtesyAllowed.ForeColor = System.Drawing.Color.Green;
            this.lbCourtesyAllowed.Location = new System.Drawing.Point(215, 377);
            this.lbCourtesyAllowed.Name = "lbCourtesyAllowed";
            this.lbCourtesyAllowed.Size = new System.Drawing.Size(0, 24);
            this.lbCourtesyAllowed.TabIndex = 19;
            // 
            // lbBonusAllowed
            // 
            this.lbBonusAllowed.AutoSize = true;
            this.lbBonusAllowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbBonusAllowed.ForeColor = System.Drawing.Color.Green;
            this.lbBonusAllowed.Location = new System.Drawing.Point(215, 353);
            this.lbBonusAllowed.Name = "lbBonusAllowed";
            this.lbBonusAllowed.Size = new System.Drawing.Size(0, 24);
            this.lbBonusAllowed.TabIndex = 20;
            // 
            // lbCreditsAllowed
            // 
            this.lbCreditsAllowed.AutoSize = true;
            this.lbCreditsAllowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbCreditsAllowed.ForeColor = System.Drawing.Color.Green;
            this.lbCreditsAllowed.Location = new System.Drawing.Point(215, 329);
            this.lbCreditsAllowed.Name = "lbCreditsAllowed";
            this.lbCreditsAllowed.Size = new System.Drawing.Size(0, 24);
            this.lbCreditsAllowed.TabIndex = 21;
            // 
            // lbCreditsBeforeBonus
            // 
            this.lbCreditsBeforeBonus.AutoSize = true;
            this.lbCreditsBeforeBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbCreditsBeforeBonus.ForeColor = System.Drawing.Color.Green;
            this.lbCreditsBeforeBonus.Location = new System.Drawing.Point(215, 305);
            this.lbCreditsBeforeBonus.Name = "lbCreditsBeforeBonus";
            this.lbCreditsBeforeBonus.Size = new System.Drawing.Size(0, 24);
            this.lbCreditsBeforeBonus.TabIndex = 22;
            // 
            // lbGamesAllowed
            // 
            this.lbGamesAllowed.AutoSize = true;
            this.lbGamesAllowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbGamesAllowed.ForeColor = System.Drawing.Color.Green;
            this.lbGamesAllowed.Location = new System.Drawing.Point(215, 281);
            this.lbGamesAllowed.Name = "lbGamesAllowed";
            this.lbGamesAllowed.Size = new System.Drawing.Size(0, 24);
            this.lbGamesAllowed.TabIndex = 23;
            // 
            // tbGameProfileID
            // 
            this.tbGameProfileID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbGameProfileID.Location = new System.Drawing.Point(168, 209);
            this.tbGameProfileID.Name = "tbGameProfileID";
            this.tbGameProfileID.Size = new System.Drawing.Size(235, 29);
            this.tbGameProfileID.TabIndex = 24;
            // 
            // tbGameID
            // 
            this.tbGameID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbGameID.Location = new System.Drawing.Point(111, 244);
            this.tbGameID.Name = "tbGameID";
            this.tbGameID.Size = new System.Drawing.Size(292, 29);
            this.tbGameID.TabIndex = 25;
            // 
            // pbMachinePreview
            // 
            this.pbMachinePreview.Location = new System.Drawing.Point(440, 100);
            this.pbMachinePreview.Name = "pbMachinePreview";
            this.pbMachinePreview.Size = new System.Drawing.Size(347, 325);
            this.pbMachinePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMachinePreview.TabIndex = 26;
            this.pbMachinePreview.TabStop = false;
            // 
            // MachinesViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbMachinePreview);
            this.Controls.Add(this.tbGameID);
            this.Controls.Add(this.tbGameProfileID);
            this.Controls.Add(this.lbGamesAllowed);
            this.Controls.Add(this.lbCreditsBeforeBonus);
            this.Controls.Add(this.lbCreditsAllowed);
            this.Controls.Add(this.lbBonusAllowed);
            this.Controls.Add(this.lbCourtesyAllowed);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbCCPlusAllowed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbVIPPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMachineID);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMachines);
            this.Controls.Add(this.label1);
            this.Name = "MachinesViewer";
            this.Text = "MachinesViewer";
            this.Load += new System.EventHandler(this.MachinesViewer_Load);
            this.Shown += new System.EventHandler(this.MachinesViewer_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbMachinePreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMachines;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbMachineID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbVIPPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbCCPlusAllowed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbCourtesyAllowed;
        private System.Windows.Forms.Label lbBonusAllowed;
        private System.Windows.Forms.Label lbCreditsAllowed;
        private System.Windows.Forms.Label lbCreditsBeforeBonus;
        private System.Windows.Forms.Label lbGamesAllowed;
        private System.Windows.Forms.TextBox tbGameProfileID;
        private System.Windows.Forms.TextBox tbGameID;
        private System.Windows.Forms.PictureBox pbMachinePreview;
    }
}