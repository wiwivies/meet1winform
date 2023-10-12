namespace meet1winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateDateDifference_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxDate1.Text) || string.IsNullOrWhiteSpace(txtBoxDate2.Text))
            {
                MessageBox.Show("Please enter valid dates in both fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DateTime.TryParse(txtBoxDate1.Text, out DateTime date1) && DateTime.TryParse(txtBoxDate2.Text, out DateTime date2))
            {
                if (date1 >= date2)
                {
                    MessageBox.Show("Date 1 must be less than Date 2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Проверка, выбран ли хотя бы один радиобаттон внутри groupOptions
                if (!groupOptions.Controls.OfType<RadioButton>().Any(rb => rb.Checked))
                {
                    MessageBox.Show("Please select a time unit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Рассчитываем разницу между датами
                TimeSpan timeDifference = date2 - date1;

                // Определяем выбранную единицу измерения
                string result = string.Empty;
                if (radioBtnYears.Checked)
                {
                    decimal years = (decimal)timeDifference.TotalDays / 365.25M;
                    result = $"{years:F4} years";
                }
                else if (radioBtnMonths.Checked)
                {
                    decimal months = (decimal)timeDifference.TotalDays / 30.44M;
                    result = $"{months:F4} months";
                }
                else if (radioBtnDays.Checked)
                {
                    result = $"{timeDifference.TotalDays:F0} days";
                }
                else if (radioBtnMins.Checked)
                {
                    result = $"{timeDifference.TotalMinutes:F0} minutes";
                }
                else if (radioBtnSecs.Checked)
                {
                    result = $"{timeDifference.TotalSeconds:F0} seconds";
                }

                lblResult.Text = $" {result}"; /*Difference:*/
            }
            else
            {
                lblResult.Text = "Invalid date format!";
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            txtBoxDate1.Text = DateTime.Now.ToString("dd/MM/yyyy"); // Устанавливаем сегодняшнюю дату по умолчанию
        }
    }
}