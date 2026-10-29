using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assigment_lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // declare variables
                int number = int.Parse(txtnumberpackage.Text);
                double packagePrice = double.Parse(txtperpackage.Text);

                if (number <= 0 || packagePrice <= 0)
                {
                    MessageBox.Show("Invalid input ");
                   
                }

                // Calculate the subtotal
                double subtotal = number * packagePrice;
                double discountrate=0;

                // Determine the discount
                if (number < 10)
                {
                    discountrate = 0;
                }
                else if (number < 19)
                {
                    discountrate = 20;
                }
                else if (number < 49)
                {
                    discountrate = 30;
                }
                else if (number < 99)
                {
                    discountrate = 40;
                }
                else 
                {
                    discountrate = 50;
                }

                // Calculate discount amount and total
                double discount = subtotal * discountrate / 100;
                double total = subtotal - discount;

                // Show the results in ListBox
                purchaseresults.Items.Add("Number of Packages: " + number);
                purchaseresults.Items.Add("Price per Package: " +packagePrice.ToString("C2"));
                purchaseresults.Items.Add("Subtotal (before discount): " + subtotal.ToString("C2"));
                purchaseresults.Items.Add("Discount Rate: " + discountrate + "%");
                purchaseresults.Items.Add("Discount Amount: " +discount.ToString("C2"));
                purchaseresults.Items.Add("Total (after discount): " + total.ToString("C2"));
            }
            catch 
            {
                MessageBox.Show("error only accept numeric");
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            //using clear
            txtnumberpackage.Clear();
            txtperpackage.Clear();
            purchaseresults.Items.Clear();

        }

        private void exit_Click(object sender, EventArgs e)
        {
          //Application exit
          this.Close();
        }
    }
    }

