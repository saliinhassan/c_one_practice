using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assigmentfile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //creatingfiles
            StreamWriter lines;
            lines = File.CreateText("myfile.doc");
            lines.WriteLine("ether functions of reading include");
            lines.WriteLine("welcome to jamhuuriya");
            lines.WriteLine("class ca244");
            lines.WriteLine("this is my first project");
            MessageBox.Show("File successfully created and written!");
            //closing the lines
            lines.Close();

        }
        // Read lines button 
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (File.Exists("myfile.doc"))
            {
                foreach (string line in File.ReadLines("myfile.doc"))
                {
                    listBox1.Items.Add(line);
                }
            }
            else
            {
                MessageBox.Show("File not found Please click 'WriteLine' first ");
            }
        }
        //  Read all lines button 
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (File.Exists("myfile.doc"))
            {
                string[] lines = File.ReadAllLines("myfile.doc");

                foreach (string line in lines)
                {
                    listBox1.Items.Add(line);
                }
            }
            else
            {
                MessageBox.Show("File not found Please click 'WriteLine' first");
            }
        }
        // Read block button 
        private void btnreadblock_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (File.Exists("myfile.doc"))
            {
                using (StreamReader reader = File.OpenText("myfile.doc"))
                {
                    char[] buffer = new char[20];
                    int count = reader.ReadBlock(buffer, 0, 20);
                    string blockText = new string(buffer, 0, count);
                    listBox1.Items.Add(blockText);
                }
            }
            else
            {
                MessageBox.Show("File not found Please click 'WriteLine' first");
            }
        }
        //  Delete items / Clear ListBox
        private void btndeleteitems_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
        //  Delete file button delete files
        private void btndeletefile_Click(object sender, EventArgs e)
        {
            if (File.Exists("myfile.doc"))
            {
                File.Delete("myfile.doc");
                listBox1.Items.Clear();
                MessageBox.Show(".file is clear");
            }
            else
            {
                MessageBox.Show("File not found");
            }
        
    }

        private void btnclear_Click(object sender, EventArgs e)
        {
            // . Clear button
            listBox1.Items.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            //  Exit button
            this.Close();

        }
    }
}
