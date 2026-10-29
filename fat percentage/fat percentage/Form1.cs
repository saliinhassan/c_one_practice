using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace fat_percentage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            //creating  a variables
            double totalnumberofCalories , fatGrams;
            

            //validate using try parse
            if (double.TryParse(txtcalories.Text, out totalnumberofCalories) &&
                double.TryParse(txtfatgrams.Text, out fatGrams))
            {
                 //calculate  the total 
                if (totalnumberofCalories > 0 && fatGrams >= 0)
                {
                    // Check if the entered values are valid
                    double caloriesFromFat = fatGrams * 9;
                    //calculate the fat 
                    double percentage = (caloriesFromFat / totalnumberofCalories) * 100;
                    // Display calories from fat
                    lblnumber.Text = caloriesFromFat.ToString();
                    lblpercentage.Text = percentage.ToString("F2") + "%";
                    // Check if fat percentage is less than 30%
                    if (percentage < 30)
                    {
                        checkfat.Checked = true;
                    }
                    else
                    {
                        checkfat.Checked = false;
                    }
                }
                else
                {
                    // Display an error message for invalid values

                    MessageBox.Show("value sax ah so geli.");
                }
            }
            else
            {
                // Display an error message if input is not numeric
                MessageBox.Show("please  number so geli.");
            }
        }

        

        private void btnclear_Click_1(object sender, EventArgs e)
        {
            //using  clear
            txtcalories.Clear();
            txtfatgrams.Clear();

            lblnumber.Text = "";
            lblpercentage.Text = "";

            checkfat.Checked = false;
        }
    }
}
