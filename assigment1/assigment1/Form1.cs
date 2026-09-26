using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assigment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        

        private void button3_Click(object sender, EventArgs e)
        {
         string dayoftheweek,dayofmonth,month,year, showdata;
            dayoftheweek=txtdayoftheweek.Text;  
            month=txtmonthtext.Text;
            dayofmonth=txtdayofmonth.Text;
             year = txtyeartext.Text;
            showdata=dayoftheweek+" "+month+" "+dayofmonth+" "+year;
            dateoutputlabel.Text=showdata;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtdayoftheweek.Clear();
            txtmonthtext.Clear();
            txtdayofmonth.Clear();
            txtyeartext.Clear();
            dateoutputlabel.Text = " ";

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
