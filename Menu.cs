using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meet1winform
{
    public class Menu_item
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public double DefaultPrice { get; set; }
        public double PriceAll { get; set; }

        public Menu_item()
        {
            Name = "";
            Count = 0;
            DefaultPrice = 0;
            PriceAll = 0;
        }

        public Menu_item(string name, int count, double defaultPrice)
        {
            Name = name;
            Count = count;
            DefaultPrice = defaultPrice;

            if(count > 0)
                SetCount(count);
            else
                PriceAll = 0;
        }

        public void SetCount(int count)
        {
            Count = count;

            if (count > 0)
                PriceAll = DefaultPrice * count;
            else
                PriceAll = 0;
        }

        public override string ToString()
        {
            return $"{Name} - Count: {Count}, Price: {PriceAll.ToString("F2")}";
        }
    }

    public class Menu
    {
        public List<Menu_item> items = new List<Menu_item>();
    }

}
