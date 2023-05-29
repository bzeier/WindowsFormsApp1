using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    class Customer
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public Customer(string name) {
            this.Name = name;
            this.Id = Manager.Customers.Count+1;
        }
    }
}
