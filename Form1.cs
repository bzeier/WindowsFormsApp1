using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateListbox();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            UpdateListbox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateListbox();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListbox();
        }

        private void UpdateListbox()
        {
            listBox1.Items.Clear();
            foreach (Customer customer in Manager.Customers)
            {
                listBox1.Items.Add(customer.Id + "|" + customer.Name);
            }
        }
    }
}
