using System.Text;

namespace meet1winform
{
    public partial class Form1 : Form
    {
        Menu menu;

        public Form1()
        {
            InitializeComponent();
            menu = new Menu();
        }

        private void Load_Window(object sender, EventArgs e)
        {
            menu.items.Add(new Menu_item("Latte", 0, 57.50));
            menu.items.Add(new Menu_item("Espresso", 0, 34.00));
            menu.items.Add(new Menu_item("Cappuccino", 0, 45.00));
            menu.items.Add(new Menu_item("Mocha", 0, 49.50));
            menu.items.Add(new Menu_item("Americano", 0, 40.99));

            menu.items.Add(new Menu_item("Cheesecake", 0, 65.50));
            menu.items.Add(new Menu_item("Brownie", 0, 55.98));
            menu.items.Add(new Menu_item("Tiramisu", 0, 70.50));
            menu.items.Add(new Menu_item("ApplePie", 0, 60.00));
            menu.items.Add(new Menu_item("iceCream", 0, 50.50));

            //MessageBox.Show("Form_Load executed");
        }

        // универсальный для всех чекбоксов
        private void CheckBox_Changed(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            if (checkBox.Checked)
            {
                // Включить соответствующий нумерикапдаун на основе имени чекбокса
                string itemName = checkBox.Name.Substring(3); // Удалите префикс "CB_"
                Control[] controls = this.Controls.Find("count_" + itemName, true);
                if (controls.Length > 0 && controls[0] is NumericUpDown)
                {
                    NumericUpDown numericUpDown = (NumericUpDown)controls[0];
                    numericUpDown.Enabled = true;
                }
            }
            else
            {
                // Отключить соответствующий нумерикапдаун на основе имени чекбокса
                string itemName = checkBox.Name.Substring(3); // Удалите префикс "CB_"
                Control[] controls = this.Controls.Find("count_" + itemName, true);
                if (controls.Length > 0 && controls[0] is NumericUpDown)
                {
                    NumericUpDown numericUpDown = (NumericUpDown)controls[0];
                    numericUpDown.Enabled = false;
                }
            }
        }

        // универсальный для всех нумерикапдаун
        private void Count_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;

            if (numericUpDown != null)
            {
                string itemName = numericUpDown.Name.Substring(6); // Удалите префикс "count_"
                Control[] priceControls = this.Controls.Find("price_" + itemName, true);

                if (priceControls.Length > 0 && priceControls[0] is TextBox)
                {
                    TextBox textBox = (TextBox)priceControls[0];
                    int count = (int)numericUpDown.Value; // Получаем значение нумерикапдауна
                    double defaultPrice = menu.items.Find(item => item.Name == itemName).DefaultPrice; // Получаем стандартную цену

                    if (count >= 1)
                    {
                        textBox.Text = (count * defaultPrice).ToString("F2"); // Устанавливаем текст в формате "Цена * Количество"
                    }
                    else
                    {
                        textBox.Text = "0.00"; // Если количество равно 0, устанавливаем цену в 0.00
                    }

                    //menu.items.Find(item => item.Name == itemName).Count = count;
                    menu.items.Find(item => item.Name == itemName).SetCount(count);

                    // Обновляем ListBox с товарами
                    UpdateListBoxGoods();
                }
            }
        }

        private void UpdateListBoxGoods()
        {
            listBoxGoods.Items.Clear();
            double totalOrderPrice = 0;

            foreach (Menu_item item in menu.items)
            {
                if (item.Count > 0)
                {
                    listBoxGoods.Items.Add(item);
                    totalOrderPrice += item.PriceAll;
                }
            }

            lb_price.Text = /*"Total Price: " + */totalOrderPrice.ToString("F2") + " grn";
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            bool itemsPurchased = false; // Флаг для отслеживания, были ли выбраны товары

            foreach (Menu_item item in menu.items)
            {
                if (item.Count >= 1)
                {
                    itemsPurchased = true;
                    break; // Если хотя бы один товар выбран, выходим из цикла
                }
            }

            if (!itemsPurchased)
            {
                MessageBox.Show("You haven't selected any items for purchase.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Останавливаем выполнение кода
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Получаем имя выбранного файла
                string fileName = saveFileDialog.FileName;

                // Создаем текстовую строку для хранения информации о заказе
                StringBuilder orderInfo = new StringBuilder();
                orderInfo.AppendLine("Order Details");
                orderInfo.AppendLine("Timestamp: " + DateTime.Now.ToString());
                orderInfo.AppendLine("Total Price: " + lb_price.Text);

                orderInfo.AppendLine("Items Purchased:");
                foreach (Menu_item item in menu.items)
                {
                    if (item.Count >= 1)
                    {
                        orderInfo.AppendLine(item.ToString());
                    }
                }

                try
                {
                    // Записываем информацию о заказе в выбранный файл
                    File.WriteAllText(fileName, orderInfo.ToString());
                    MessageBox.Show("The receipt has been generated and saved to the file: " + fileName, "Receipt Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Отобразим краткую информацию в сообщении
                    string briefInfo = "Receipt Time: " + DateTime.Now.ToString() + "\n" +
                        "Total Price: " + lb_price.Text + "\n" +
                        "Items Purchased:\n";
                    foreach (Menu_item item in menu.items)
                    {
                        if (item.Count >= 1)
                        {
                            briefInfo += item.ToString() + "\n";
                        }
                    }
                    MessageBox.Show(briefInfo, "Order Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while saving the receipt: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}