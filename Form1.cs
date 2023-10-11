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
            // Создаем массив строк для предложений
            string[] sentences = new string[]
            {
                "My name is Victoria.",
                "I was born in Ukraine and live in Kiev.",
                "You can find all my work on GitHub.",
                "I am looking forward to working with you."
            };

            // Количество MessageBox'ов
            int messageBoxCount = sentences.Length;

            int totalChars = 0;
            foreach (string sentence in sentences)
            {
                totalChars += sentence.Length;
            }
            // MessageBox.Show(totalChars.ToString()); // 135

            // Выводим резюме с использованием MessageBox
            int currentPage = 1;

            for (int i = 0; i < messageBoxCount; i++)
            {
                if (i == messageBoxCount - 1)
                {
                    // Выводим последний MessageBox с средним числом символов в заголовке
                    MessageBox.Show(sentences[i], "Resume - Page " + currentPage + " (Average: " + totalChars / messageBoxCount + " characters)");
                }
                else
                {
                    // Выводим MessageBox с текущим предложением
                    MessageBox.Show(sentences[i], "Resume - Sentence " + (i + 1));
                }

                currentPage++;
            }

            // Завершаем приложение
            Application.Exit();
        }
    }
}