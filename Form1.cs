namespace meet1winform
{
    public partial class Form1 : Form
    {
        private bool isCTRLdown = false;
        private string originalTitle;

        public Form1()
        {
            InitializeComponent();
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            originalTitle = this.Text;
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                if(isCTRLdown == true)
                {
                    this.Close();
                }

                var currentPoint = e.Location;
                Rectangle rect = new Rectangle(10, 10, this.ClientSize.Width - 20, this.ClientSize.Height - 20);

                if (rect.Contains(currentPoint))
                {
                    MessageBox.Show("Точка находится внутри прямоугольника.");
                }
                else if (
                    (currentPoint.X == rect.Left || currentPoint.X == rect.Right) ||
                    (currentPoint.Y == rect.Top || currentPoint.Y == rect.Bottom)
                )
                {
                    MessageBox.Show("Точка находится на границе прямоугольника.");
                }
                else
                {
                    MessageBox.Show("Точка находится снаружи прямоугольника.");
                }
            }

            if (e.Button == MouseButtons.Right)
            {
                string clientSizeInfo = $"Ширина = {this.ClientSize.Width}, Высота = {this.ClientSize.Height}";
                this.Text = clientSizeInfo;// Установление нового заголовка

                // Через некоторое время (с использованием таймера), установка оригинального заголовка обратно
                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                timer.Interval = 10000; // Через 10 секунды вернем оригинальный заголовок
                timer.Tick += (s, args) =>
                {
                    this.Text = originalTitle; // Восстановление оригинального заголовка
                    timer.Stop();
                };
                timer.Start();
            }
        }

        private void MMEvent(object sender, MouseEventArgs e)
        {
            // Получаем текущие координаты мыши
            int mouseX = e.Location.X;
            int mouseY = e.Location.Y;

            // Форматируем текст для отображения в заголовке
            string mouseCoordinates = $"X = {mouseX}, Y = {mouseY}";

            // Устанавливаем отформатированный текст в заголовок окна
            this.Text = mouseCoordinates;

            lb_cord.Text = $"Mouse Move: { e.Location.X} : { e.Location.Y}";
        }

        private void KD_Form(object sender, KeyEventArgs e)
        {
            isCTRLdown = true;
        }

        private void KU_Form(object sender, KeyEventArgs e)
        {
            isCTRLdown = false;
        }
    }
}