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
                    MessageBox.Show("����� ��������� ������ ��������������.");
                }
                else if (
                    (currentPoint.X == rect.Left || currentPoint.X == rect.Right) ||
                    (currentPoint.Y == rect.Top || currentPoint.Y == rect.Bottom)
                )
                {
                    MessageBox.Show("����� ��������� �� ������� ��������������.");
                }
                else
                {
                    MessageBox.Show("����� ��������� ������� ��������������.");
                }
            }

            if (e.Button == MouseButtons.Right)
            {
                string clientSizeInfo = $"������ = {this.ClientSize.Width}, ������ = {this.ClientSize.Height}";
                this.Text = clientSizeInfo;// ������������ ������ ���������

                // ����� ��������� ����� (� �������������� �������), ��������� ������������� ��������� �������
                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                timer.Interval = 10000; // ����� 10 ������� ������ ������������ ���������
                timer.Tick += (s, args) =>
                {
                    this.Text = originalTitle; // �������������� ������������� ���������
                    timer.Stop();
                };
                timer.Start();
            }
        }

        private void MMEvent(object sender, MouseEventArgs e)
        {
            // �������� ������� ���������� ����
            int mouseX = e.Location.X;
            int mouseY = e.Location.Y;

            // ����������� ����� ��� ����������� � ���������
            string mouseCoordinates = $"X = {mouseX}, Y = {mouseY}";

            // ������������� ����������������� ����� � ��������� ����
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