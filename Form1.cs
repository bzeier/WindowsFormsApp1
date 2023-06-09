﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            float total = 0.0f;
            foreach (Item item in Manager.Items)
            {
                total += item.Price * item.Quantity;
            }
            if (Manager.CurrentCustomer.Cash >= total)
            {
                Manager.CurrentCustomer.Cash = Manager.CurrentCustomer.Cash-total;
                Manager.Items.Clear();
            }
            UpdateListbox();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox box = (ListBox)sender;
            Item item = Manager.Items.ElementAt(box.SelectedIndex);
            textBox1.Text = item.Name;
            textBox2.Text = item.Price.ToString();


            UpdateListbox();//
        }

        private void UpdateListbox()
        {
            label9.Text = (Manager.CurrentCustomer.Name).ToString();
            label8.Text = (Manager.CurrentCustomer.Cash).ToString() + "$";



            listBox1.Items.Clear();
            float total = 0.0f;
            foreach (Item item in Manager.Items)
            {
                listBox1.Items.Add(item.Quantity + "   | " + item.Name + " | " + item.Price * item.Quantity);
                total += item.Price*item.Quantity;
            }

            label6.Text = total + "$";
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
            if (textBox2.Text == "") return;


            string name = textBox1.Text;
            float price;
            try
            {
                price = float.Parse(textBox2.Text);
            }
            catch {
                Console.WriteLine("Invalid price input");
                return;
            }

            int i = 0;
            foreach (Item item in Manager.Items)
            {
                if (item.Name.ToLower() == textBox1.Text.ToLower()) {
                    Manager.Items[i].Quantity += 1;
                    UpdateListbox();
                    return;
                }
                i++;
            }



            Manager.Items.Add(new Item(name, price));
            UpdateListbox();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Item item in Manager.Items)
            {
                if (item.Name.ToLower() == textBox1.Text.ToLower())
                {
                    try
                    {
                        listBox1.Items.RemoveAt(i);
                        Manager.Items.RemoveAt(i);
                    }
                    catch
                    {

                    }
                    return;
                }
                i++;
            }
            UpdateListbox();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Manager.Items.Clear();
            UpdateListbox();
        }
    }
}
