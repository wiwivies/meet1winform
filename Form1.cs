using System.Globalization;
using System.Windows.Forms;

namespace meet1winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateDayOfWeek_Click(object sender, EventArgs e)
        {
            // Получаем введенную дату из TextBox
            if (DateTime.TryParse(txtBoxDate.Text, out DateTime inputDate))
            {
                // Определяем день недели
                string dayOfWeek = inputDate.ToString("dddd", new CultureInfo("en-US")); // new CultureInfo("ru-RU"

                // Выводим результат в Label
                lblresult.Text = $"Day of the week: {dayOfWeek}";

                mnthCalendar.SetDate(inputDate);
            }
            else
            {
                lblresult.Text = "Invalid date format!";
            }
        }
    }
}