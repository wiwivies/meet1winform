namespace meet1winform
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
            this.txtBoxDate = new System.Windows.Forms.TextBox();
            this.lbInfo = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblInforesult = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.mnthCalendar = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // txtBoxDate
            // 
            this.txtBoxDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBoxDate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBoxDate.Location = new System.Drawing.Point(131, 150);
            this.txtBoxDate.MaximumSize = new System.Drawing.Size(400, 20);
            this.txtBoxDate.MinimumSize = new System.Drawing.Size(400, 30);
            this.txtBoxDate.Name = "txtBoxDate";
            this.txtBoxDate.Size = new System.Drawing.Size(400, 30);
            this.txtBoxDate.TabIndex = 0;
            this.txtBoxDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbInfo
            // 
            this.lbInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.lbInfo.Location = new System.Drawing.Point(128, 51);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(736, 35);
            this.lbInfo.TabIndex = 1;
            this.lbInfo.Text = "To find out the day of the week, enter the date in the field";
            // 
            // btnFind
            // 
            this.btnFind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFind.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnFind.Location = new System.Drawing.Point(691, 138);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(130, 55);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.CalculateDayOfWeek_Click);
            // 
            // lblInforesult
            // 
            this.lblInforesult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInforesult.AutoSize = true;
            this.lblInforesult.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblInforesult.ForeColor = System.Drawing.SystemColors.Control;
            this.lblInforesult.Location = new System.Drawing.Point(128, 276);
            this.lblInforesult.Name = "lblInforesult";
            this.lblInforesult.Size = new System.Drawing.Size(414, 25);
            this.lblInforesult.TabIndex = 3;
            this.lblInforesult.Text = "Found day of the week after the search:";
            // 
            // lblresult
            // 
            this.lblresult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblresult.ForeColor = System.Drawing.Color.DarkSalmon;
            this.lblresult.Location = new System.Drawing.Point(197, 343);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(247, 25);
            this.lblresult.TabIndex = 4;
            this.lblresult.Text = "Day of the week: *day*";
            // 
            // mnthCalendar
            // 
            this.mnthCalendar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mnthCalendar.Enabled = false;
            this.mnthCalendar.Location = new System.Drawing.Point(635, 276);
            this.mnthCalendar.MinimumSize = new System.Drawing.Size(250, 0);
            this.mnthCalendar.Name = "mnthCalendar";
            this.mnthCalendar.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.mnthCalendar);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lblInforesult);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.txtBoxDate);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Date";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtBoxDate;
        private Label lbInfo;
        private Button btnFind;
        private Label lblInforesult;
        private Label lblresult;
        private MonthCalendar mnthCalendar;
    }
}