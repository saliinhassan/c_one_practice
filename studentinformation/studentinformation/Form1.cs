using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentinformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnshowinfo_Click(object sender, EventArgs e)
        {
            //declare variable
            string studentname, department, allinformation;
            int studentid, semester;
            //assign variable
            studentname = txtstudentname.Text;

           studentid= int.Parse(txtstudentid.Text); 
            department=txtdepartment.Text;
           semester=int.Parse(txtsemeter.Text); 
            //process  concatination
            allinformation=studentname+" "+studentid+" "+department+" "+semester;
            //display
            lbloutput.Text = allinformation;

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            // this is clear

            txtstudentname.Clear();
            txtstudentid.Clear();
            txtdepartment.Clear();
            txtsemeter.Clear();
            lbloutput.Text = "  ";
            
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            //this close
            this.Close();
        }
    }
}
