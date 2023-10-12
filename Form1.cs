namespace meet1winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonMoveEvent(object sender, EventArgs e)
        {
            Random random = new Random();

            int x = random.Next(0, 800);
            int y = random.Next(0, 500);

            btnCatch.Location = new Point(x, y);
            btnCatch.Update();
        }
    }
}