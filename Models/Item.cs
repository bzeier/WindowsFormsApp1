using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    internal class Item
    {
        public Item(string name, float price) {
            this.Name = name;
            this.Price = price;
        }
        public string Name { get; set; }
        public float Price { get; set; }
    }
}
