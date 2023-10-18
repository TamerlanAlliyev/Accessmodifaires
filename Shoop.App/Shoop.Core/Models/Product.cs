using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Shoop.Core.Models
{

    public class Product
    {
        public string Name;
        public double Price;
        public string Category;
        public string StockCount;

        public Product(string name, double price, string category, string stockcount)
        {
            Name = name;
            Price = price;
            Category = category;
            StockCount = stockcount;
        }

        public string GetFullInfo()
        {
            return $"Name : {Name} , Price {Price} , Category {Category} , Stock Count {StockCount}";
        }

    }

}
