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
            this.btnCatch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCatch
            // 
            this.btnCatch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCatch.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCatch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCatch.Location = new System.Drawing.Point(411, 242);
            this.btnCatch.Name = "btnCatch";
            this.btnCatch.Size = new System.Drawing.Size(114, 35);
            this.btnCatch.TabIndex = 0;
            this.btnCatch.Text = "Catch Me!";
            this.btnCatch.UseVisualStyleBackColor = true;
            this.btnCatch.MouseEnter += new System.EventHandler(this.ButtonMoveEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.btnCatch);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catch Me";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCatch;
    }
}