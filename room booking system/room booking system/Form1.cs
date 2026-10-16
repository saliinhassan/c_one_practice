using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace room_booking_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            // Get guest name
            string guestName = txtguestname.Text;

            // Declare variables for numeric inputs
            int age, nights, guests;

            // Validate numeric inputs using TryParse
            bool isAgeValid = int.TryParse(txtguestage.Text, out age);
            bool isNightsValid = int.TryParse(txtneights.Text, out nights);
            bool isGuestsValid = int.TryParse(txtguests.Text, out guests);

            // Validate guest name
            if (string.IsNullOrWhiteSpace(guestName))
            {
                MessageBox.Show("Please enter guest name!", "Error");
                return;
            }

            // Validate age: must be between 18 and 90
            else if (!isAgeValid || age < 18 || age > 90)
            {
                MessageBox.Show("Age must be numeric and between 18 and 90!");
                return;
            }

            // Validate nights: must be between 1 and 30
            else if (!isNightsValid || nights < 1 || nights > 30)
            {
                MessageBox.Show("Nights must be numeric and between 1 and 30!");
                return;
            }

            // Validate guests: must be between 1 and 6
            else if (!isGuestsValid || guests < 1 || guests > 6)
            {
                MessageBox.Show("Guests must be numeric and between 1 and 6!");
                return;
            }

            // Check whether a room type has been selected
            else if (!radiostandard.Checked &&
                     !radionormal.Checked &&
                     !radiohight.Checked)
            {
                MessageBox.Show("Please select a room type!", "Error");
                return;
            }

            else
            {
                // Declare room variables
                string roomType = "";
                double rate = 0;
                int maxCapacity = 0;

                // Identify the selected room and its maximum capacity
                if (radiostandard.Checked)
                {
                    roomType = "Standard Room";
                    maxCapacity = 2;
                }
                else if (radionormal.Checked)
                {
                    roomType = "Normal Room";
                    maxCapacity = 4;
                }
                else if (radiohight.Checked)
                {
                    roomType = "High Room";
                    maxCapacity = 6;
                }

                // Determine the room rate using switch
                // IMPORTANT: Case names must match roomType exactly
                switch (roomType)
                {
                    case "Standard Room":
                        rate = 50;
                        break;

                    case "Normal Room":
                        rate = 80;
                        break;

                    case "High Room":
                        rate = 130;
                        break;
                }

                // Use a bool flag to approve or reject the booking
                bool approved = true;

                // Reject if guests exceed the room's capacity
                if (guests > maxCapacity)
                {
                    approved = false;
                }

                // Display rejection if booking is not approved
                if (approved == false)
                {
                    bookingdetails.Items.Add("----- BOOKING REJECTED -----");
                    bookingdetails.Items.Add("Guest Name: " + guestName);
                    bookingdetails.Items.Add("Room Type: " + roomType);
                    bookingdetails.Items.Add("Maximum Capacity: " + maxCapacity);
                    bookingdetails.Items.Add("Number of Guests: " + guests);
                    MessageBox.Show("Booking rejected! Too many guests for this room.");
                    return;
                }

                // Calculate base cost using room rate and nights
                double baseCost = rate * nights;

                // Calculate discount based on length of stay
                double staydiscount = 0;

                if (nights >= 10)
                {
                    // 12% discount for 10 or more nights
                    staydiscount = baseCost * 0.12;
                }
                else if (nights >= 5 && nights <= 9)
                {
                    // 5% discount for 5 to 9 nights
                    staydiscount = baseCost * 0.05;
                }
                // 1 to 4 nights receive no stay discount

                // Calculate senior discount
                double seniordiscount = 0;

                if (age >= 60)
                {
                    // Additional 5% senior discount
                    seniordiscount = baseCost * 0.05;
                }

                // Calculate breakfast cost
                double breakfastCost = 0;

                if (checkBox1.Checked)
                {
                    // Breakfast costs $10 per guest per night
                    breakfastCost = 10 * guests * nights;
                }

                // Calculate subtotal after discounts and breakfast
                double subtotal = baseCost - staydiscount
                                  - seniordiscount + breakfastCost;

                // Calculate service surcharge
                double servicesurcharge = 0;

                if (guests > 4)
                {
                    // Add 5% surcharge for more than 4 guests
                    servicesurcharge = subtotal * 0.05;
                }

                // Calculate final cost
                double finalCost = subtotal + servicesurcharge;

                // Display booking summary in the ListBox
                bookingdetails.Items.Add("----- BOOKING SUMMARY -----");
                bookingdetails.Items.Add("Guest Name: " + guestName);
                bookingdetails.Items.Add("Guest Age: " + age);
                bookingdetails.Items.Add("Nights: " + nights);
                bookingdetails.Items.Add("Guests: " + guests);
                bookingdetails.Items.Add("Room Type: " + roomType);
                bookingdetails.Items.Add("Status: Approved");
                bookingdetails.Items.Add("---------------------------");

                // Display room rate and costs
                bookingdetails.Items.Add("Rate Per Night: $" + rate.ToString("F2"));
                bookingdetails.Items.Add("Base Cost: $" + baseCost.ToString("F2"));
                bookingdetails.Items.Add("Stay Discount: $" + staydiscount.ToString("F2"));
                bookingdetails.Items.Add("Senior Discount: $" + seniordiscount.ToString("F2"));
                bookingdetails.Items.Add("Breakfast: $" + breakfastCost.ToString("F2"));
                bookingdetails.Items.Add("Service Surcharge: $" + servicesurcharge.ToString("F2"));
                bookingdetails.Items.Add("---------------------------");
                bookingdetails.Items.Add("FINAL COST: $" + finalCost.ToString("F2"));
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            // Clear all input fields
            txtguestname.Clear();
            txtguestage.Clear();
            txtneights.Clear();
            txtguests.Clear();

            // Reset room selections
            radiostandard.Checked = false;
            radionormal.Checked = false;
            radiohight.Checked = false;

            // Uncheck breakfast
            checkBox1.Checked = false;

            // Clear booking details
            bookingdetails.Items.Clear();

            // Focus on guest name
            txtguestname.Focus();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            // Close the application
            this.Close();

        }
    }
    }
