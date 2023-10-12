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
            this.lb_cord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_cord
            // 
            this.lb_cord.AutoSize = true;
            this.lb_cord.BackColor = System.Drawing.Color.MediumPurple;
            this.lb_cord.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_cord.Location = new System.Drawing.Point(9, 11);
            this.lb_cord.Name = "lb_cord";
            this.lb_cord.Size = new System.Drawing.Size(126, 21);
            this.lb_cord.TabIndex = 0;
            this.lb_cord.Text = "Mouse Move: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.lb_cord);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ex 3";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KD_Form);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KU_Form);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MMEvent);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_cord;
    }
}