using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace airline_ticket_booking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Variables
                string name = txtname.Text.Trim();
                int age;
                int tickets;
                double baggage;
                double ticketPrice = 0;
                double total;
                double insurance = 0;

                // 2. Validate passenger name
                if (name == "" || int.TryParse(name, out _))
                {
                    MessageBox.Show("Enter a valid passenger name.");
                    txtname.Focus();
                    return;
                }

                // 3. Validate age
                if (!int.TryParse(txtage.Text, out age) ||
                    age < 1 || age > 120)
                {
                    MessageBox.Show("Enter a valid age (1-120).");
                    txtage.Focus();
                    return;
                }

                // 4. Validate number of tickets
                if (!int.TryParse(txttickets.Text, out tickets) ||
                    tickets < 1 || tickets > 10)
                {
                    MessageBox.Show("Enter tickets between 1 and 10.");
                    txttickets.Focus();
                    return;
                }

                // 5. Validate baggage weight
                if (!double.TryParse(txtBaggageWeights.Text, out baggage) ||
                    baggage < 0)
                {
                    MessageBox.Show("Enter a valid baggage weight.");
                    txtBaggageWeights.Focus();
                    return;
                }

                // 6. Decision structure: Travel class
                if (radiofirst.Checked)
                {
                    ticketPrice = 500;
                }
                else if (radionormal.Checked)
                {
                    ticketPrice = 250;
                }
                else if (radiobussiness.Checked)
                {
                    ticketPrice = 400;
                }
                else
                {
                    MessageBox.Show("Please select a travel class.");
                    return;
                }

                // 7. Calculate ticket cost
                total = ticketPrice * tickets;

                // 8. Optional travel insurance ($25 per ticket)
                if (checkaddtravel.Checked)
                {
                    insurance = 25 * tickets;
                }

                total = total + insurance;

                // 9. Display results in ListBox
                AirlineBookDetails.Items.Clear();
                AirlineBookDetails.Items.Add("AIRLINE BOOKING DETAILS");
                AirlineBookDetails.Items.Add("----------------------------");
                AirlineBookDetails.Items.Add("Passenger: " + name);
                AirlineBookDetails.Items.Add("Age: " + age);
                AirlineBookDetails.Items.Add("Number of Tickets: " + tickets);
                AirlineBookDetails.Items.Add("Baggage Weight: " + baggage + " kg");

                AirlineBookDetails.Items.Add("Travel Class: " +
                    (radiofirst.Checked ? "First Class" :
                    radionormal.Checked ? "Normal Class" :
                    "Business Class"));

                AirlineBookDetails.Items.Add("Ticket Price: $" + ticketPrice);
                AirlineBookDetails.Items.Add("Insurance: $" + insurance);
                AirlineBookDetails.Items.Add("Total Amount: $" + total);

                MessageBox.Show("Booking calculated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            // Clear user input
            txtname.Clear();
            txtage.Clear();
            txttickets.Clear();
            txtBaggageWeights.Clear();
            radiofirst.Checked = false;
            radionormal.Checked = false;
            radiobussiness.Checked = false;
            checkaddtravel.Checked = false;
            AirlineBookDetails.Items.Clear();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }
    }
}
     
