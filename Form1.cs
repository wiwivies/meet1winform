namespace meet1winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtYesClickEvent(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Well, we had no doubt that you think so!");
        }

        private void BtNoMouseMove(object sender, MouseEventArgs e)
        {
            buttonNo.Top -= e.Y;
            buttonNo.Left += e.X;

            if(buttonNo.Top < -10 || buttonNo.Top > 100)
            {
                buttonNo.Top = 60;
            }
            if (buttonNo.Left < -80 || buttonNo.Left > 250)
                buttonNo.Left = 120;
        }
    }
}