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
            this.lblinfo1 = new System.Windows.Forms.Label();
            this.lblinfo2 = new System.Windows.Forms.Label();
            this.lbDate1 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.radioBtnYears = new System.Windows.Forms.RadioButton();
            this.radioBtnMonths = new System.Windows.Forms.RadioButton();
            this.radioBtnDays = new System.Windows.Forms.RadioButton();
            this.radioBtnMins = new System.Windows.Forms.RadioButton();
            this.radioBtnSecs = new System.Windows.Forms.RadioButton();
            this.txtBoxDate1 = new System.Windows.Forms.TextBox();
            this.lblResInfo = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupOptions = new System.Windows.Forms.GroupBox();
            this.txtBoxDate2 = new System.Windows.Forms.TextBox();
            this.lbDate2 = new System.Windows.Forms.Label();
            this.groupOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblinfo1
            // 
            this.lblinfo1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblinfo1.AutoSize = true;
            this.lblinfo1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblinfo1.ForeColor = System.Drawing.Color.Indigo;
            this.lblinfo1.Location = new System.Drawing.Point(123, 42);
            this.lblinfo1.Name = "lblinfo1";
            this.lblinfo1.Size = new System.Drawing.Size(737, 35);
            this.lblinfo1.TabIndex = 1;
            this.lblinfo1.Text = "To find out the difference in dates enter them in the fields\r\n";
            // 
            // lblinfo2
            // 
            this.lblinfo2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblinfo2.AutoSize = true;
            this.lblinfo2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblinfo2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblinfo2.Location = new System.Drawing.Point(334, 77);
            this.lblinfo2.Name = "lblinfo2";
            this.lblinfo2.Size = new System.Drawing.Size(526, 20);
            this.lblinfo2.TabIndex = 2;
            this.lblinfo2.Text = "* by default the first date will denote today\'s date until you change";
            // 
            // lbDate1
            // 
            this.lbDate1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDate1.AutoSize = true;
            this.lbDate1.Font = new System.Drawing.Font("Times New Roman", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lbDate1.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbDate1.Location = new System.Drawing.Point(123, 158);
            this.lbDate1.Name = "lbDate1";
            this.lbDate1.Size = new System.Drawing.Size(146, 25);
            this.lbDate1.TabIndex = 3;
            this.lbDate1.Text = "The first date:";
            // 
            // btnCalc
            // 
            this.btnCalc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCalc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalc.ForeColor = System.Drawing.Color.Indigo;
            this.btnCalc.Location = new System.Drawing.Point(216, 421);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(120, 46);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.CalculateDateDifference_Click);
            // 
            // radioBtnYears
            // 
            this.radioBtnYears.AutoSize = true;
            this.radioBtnYears.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioBtnYears.Location = new System.Drawing.Point(25, 54);
            this.radioBtnYears.Name = "radioBtnYears";
            this.radioBtnYears.Size = new System.Drawing.Size(85, 29);
            this.radioBtnYears.TabIndex = 6;
            this.radioBtnYears.TabStop = true;
            this.radioBtnYears.Text = "Years";
            this.radioBtnYears.UseVisualStyleBackColor = true;
            // 
            // radioBtnMonths
            // 
            this.radioBtnMonths.AutoSize = true;
            this.radioBtnMonths.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioBtnMonths.Location = new System.Drawing.Point(25, 110);
            this.radioBtnMonths.Name = "radioBtnMonths";
            this.radioBtnMonths.Size = new System.Drawing.Size(104, 29);
            this.radioBtnMonths.TabIndex = 7;
            this.radioBtnMonths.TabStop = true;
            this.radioBtnMonths.Text = "Months";
            this.radioBtnMonths.UseVisualStyleBackColor = true;
            // 
            // radioBtnDays
            // 
            this.radioBtnDays.AutoSize = true;
            this.radioBtnDays.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioBtnDays.Location = new System.Drawing.Point(25, 162);
            this.radioBtnDays.Name = "radioBtnDays";
            this.radioBtnDays.Size = new System.Drawing.Size(79, 29);
            this.radioBtnDays.TabIndex = 8;
            this.radioBtnDays.TabStop = true;
            this.radioBtnDays.Text = "Days";
            this.radioBtnDays.UseVisualStyleBackColor = true;
            // 
            // radioBtnMins
            // 
            this.radioBtnMins.AutoSize = true;
            this.radioBtnMins.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioBtnMins.Location = new System.Drawing.Point(25, 215);
            this.radioBtnMins.Name = "radioBtnMins";
            this.radioBtnMins.Size = new System.Drawing.Size(109, 29);
            this.radioBtnMins.TabIndex = 9;
            this.radioBtnMins.TabStop = true;
            this.radioBtnMins.Text = "Minutes";
            this.radioBtnMins.UseVisualStyleBackColor = true;
            // 
            // radioBtnSecs
            // 
            this.radioBtnSecs.AutoSize = true;
            this.radioBtnSecs.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioBtnSecs.Location = new System.Drawing.Point(25, 264);
            this.radioBtnSecs.Name = "radioBtnSecs";
            this.radioBtnSecs.Size = new System.Drawing.Size(109, 29);
            this.radioBtnSecs.TabIndex = 10;
            this.radioBtnSecs.TabStop = true;
            this.radioBtnSecs.Text = "Seconds";
            this.radioBtnSecs.UseVisualStyleBackColor = true;
            // 
            // txtBoxDate1
            // 
            this.txtBoxDate1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxDate1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxDate1.Location = new System.Drawing.Point(123, 211);
            this.txtBoxDate1.Name = "txtBoxDate1";
            this.txtBoxDate1.Size = new System.Drawing.Size(155, 30);
            this.txtBoxDate1.TabIndex = 11;
            this.txtBoxDate1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblResInfo
            // 
            this.lblResInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblResInfo.AutoSize = true;
            this.lblResInfo.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResInfo.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblResInfo.Location = new System.Drawing.Point(334, 551);
            this.lblResInfo.Name = "lblResInfo";
            this.lblResInfo.Size = new System.Drawing.Size(103, 25);
            this.lblResInfo.TabIndex = 12;
            this.lblResInfo.Text = "RESULT:";
            // 
            // lblResult
            // 
            this.lblResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResult.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblResult.Location = new System.Drawing.Point(478, 551);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(137, 25);
            this.lblResult.TabIndex = 13;
            this.lblResult.Text = "*difference*";
            // 
            // groupOptions
            // 
            this.groupOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupOptions.Controls.Add(this.radioBtnDays);
            this.groupOptions.Controls.Add(this.radioBtnYears);
            this.groupOptions.Controls.Add(this.radioBtnMonths);
            this.groupOptions.Controls.Add(this.radioBtnMins);
            this.groupOptions.Controls.Add(this.radioBtnSecs);
            this.groupOptions.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupOptions.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.groupOptions.Location = new System.Drawing.Point(488, 143);
            this.groupOptions.Name = "groupOptions";
            this.groupOptions.Size = new System.Drawing.Size(372, 324);
            this.groupOptions.TabIndex = 14;
            this.groupOptions.TabStop = false;
            this.groupOptions.Text = "Choose one of the options";
            // 
            // txtBoxDate2
            // 
            this.txtBoxDate2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxDate2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxDate2.Location = new System.Drawing.Point(123, 336);
            this.txtBoxDate2.Name = "txtBoxDate2";
            this.txtBoxDate2.Size = new System.Drawing.Size(155, 30);
            this.txtBoxDate2.TabIndex = 16;
            this.txtBoxDate2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbDate2
            // 
            this.lbDate2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDate2.AutoSize = true;
            this.lbDate2.Font = new System.Drawing.Font("Times New Roman", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lbDate2.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbDate2.Location = new System.Drawing.Point(123, 289);
            this.lbDate2.Name = "lbDate2";
            this.lbDate2.Size = new System.Drawing.Size(172, 25);
            this.lbDate2.TabIndex = 17;
            this.lbDate2.Text = "The second date:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.lbDate2);
            this.Controls.Add(this.txtBoxDate2);
            this.Controls.Add(this.groupOptions);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblResInfo);
            this.Controls.Add(this.txtBoxDate1);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lbDate1);
            this.Controls.Add(this.lblinfo2);
            this.Controls.Add(this.lblinfo1);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Remaining Calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupOptions.ResumeLayout(false);
            this.groupOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblinfo1;
        private Label lblinfo2;
        private Label lbDate1;
        private Button btnCalc;
        private RadioButton radioBtnYears;
        private RadioButton radioBtnMonths;
        private RadioButton radioBtnDays;
        private RadioButton radioBtnMins;
        private RadioButton radioBtnSecs;
        private TextBox txtBoxDate1;
        private Label lblResInfo;
        private Label lblResult;
        private GroupBox groupOptions;
        private TextBox txtBoxDate2;
        private Label lbDate2;
    }
}