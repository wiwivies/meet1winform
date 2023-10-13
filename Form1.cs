namespace meet1winform
{
    public partial class Form1 : Form
    {
        public class MyRectangle
        {
            public Rectangle Rectangle { get; set; }
            public int Order { get; set; }

            public MyRectangle(Rectangle rect, int order)
            {
                Rectangle = rect;
                Order = order;
            }
        }

        private List<MyRectangle> rectangles = new();
        private Rectangle currentRectangle = Rectangle.Empty;
        private int currentOrder = 0;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Двойная буферизация для более плавной отрисовки
            currentOrder = 1;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currentRectangle = new Rectangle(e.Location, new Size(0, 0));
            }

            if (e.Button == MouseButtons.Right)
            {
                MyRectangle? selectedRect = null;
                int maxOrder = -1;

                foreach (MyRectangle myRect in rectangles)
                {
                    if (myRect.Rectangle.Contains(e.Location) && myRect.Order > maxOrder)
                    {
                        selectedRect = myRect;
                        maxOrder = myRect.Order;
                    }
                }

                if (selectedRect != null)
                {
                    // Получить информацию о площади и координатах
                    int area = selectedRect.Rectangle.Width * selectedRect.Rectangle.Height;
                    Point relativeLocation = this.PointToClient(selectedRect.Rectangle.Location);

                    // Отобразить информацию в заголовке окна 
                    this.Text = $"Площадь: {area}, Координаты: X={relativeLocation.X}, Y={relativeLocation.Y}";

                    // Задержка в течение 50 секунд
                    Task.Delay(5000).ContinueWith(t =>
                    {
                        // Вернуть обычное значение в заголовок окна
                        this.Invoke(new Action(() => this.Text = "Rectangles"));
                    });
                }
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currentRectangle.Width = e.X - currentRectangle.Left;
                currentRectangle.Height = e.Y - currentRectangle.Top;
                this.Invalidate();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (currentRectangle.Width >= 10 && currentRectangle.Height >= 10)
                {
                    MyRectangle myRect = new MyRectangle(currentRectangle, currentOrder);
                    rectangles.Add(myRect);
                    currentOrder++;
                    currentRectangle = Rectangle.Empty;
                    this.Invalidate();
                }
                else
                {
                    MessageBox.Show("Минимальный размер статика составляет 10x10.");
                }
            }
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MyRectangle? minOrderRect = null;
            int minOrder = int.MaxValue;

            foreach (MyRectangle myRect in rectangles)
            {
                if (myRect.Rectangle.Contains(e.Location) && myRect.Order < minOrder)
                {
                    minOrderRect = myRect;
                    minOrder = myRect.Order;
                }
            }

            if (minOrderRect != null)
            {
                rectangles.Remove(minOrderRect);
                this.Invalidate(); // Перерисовать форму после удаления "статика"
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (MyRectangle myRect in rectangles)
            {
                e.Graphics.FillRectangle(Brushes.Blue, myRect.Rectangle);
                e.Graphics.DrawString(myRect.Order.ToString(), this.Font, Brushes.White, myRect.Rectangle.Location);
            }
        }
    }
}