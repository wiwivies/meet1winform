using System.Text;
using System.Text.RegularExpressions;

namespace meet1winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ������� ������ ����� ��� �����������
            string[] sentences = new string[]
            {
                "My name is Victoria.",
                "I was born in Ukraine and live in Kiev.",
                "You can find all my work on GitHub.",
                "I am looking forward to working with you."
            };

            // ���������� MessageBox'��
            int messageBoxCount = sentences.Length;

            int totalChars = 0;
            foreach (string sentence in sentences)
            {
                totalChars += sentence.Length;
            }
            // MessageBox.Show(totalChars.ToString()); // 135

            // ������� ������ � �������������� MessageBox
            int currentPage = 1;

            for (int i = 0; i < messageBoxCount; i++)
            {
                if (i == messageBoxCount - 1)
                {
                    // ������� ��������� MessageBox � ������� ������ �������� � ���������
                    MessageBox.Show(sentences[i], "Resume - Page " + currentPage + " (Average: " + totalChars / messageBoxCount + " characters)");
                }
                else
                {
                    // ������� MessageBox � ������� ������������
                    MessageBox.Show(sentences[i], "Resume - Sentence " + (i + 1));
                }

                currentPage++;
            }

            // ��������� ����������
            Application.Exit();
        }
    }
}