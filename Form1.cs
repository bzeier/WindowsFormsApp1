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
            UpdateListbox();//
        }

        private void UpdateListbox()
        {
            listBox1.Items.Clear();
            foreach (Item item in Manager.Items)
            {
                listBox1.Items.Add(item.Name + "|" + item.Price);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Item item in Manager.Items)
            {
                if (item.Name.ToLower() == textBox1.Text.ToLower()) return;
            }


            string name = textBox1.Text;
            float price = float.Parse(textBox2.Text);
            Manager.Items.Add(new Item(name, price));
            UpdateListbox();
        }
    }
}
