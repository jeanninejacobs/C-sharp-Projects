using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic_Dates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void magicButton_Click(object sender, EventArgs e)
        {
            //Declare variables for month, day and year.
            int month, day, year;

            //Validate the month entry
            if (int.TryParse(monthTextBox.Text, out month) && month < 13)
            {
                //Validate the day entry
                if (int.TryParse(dayTextBox.Text, out day) && day < 32)
                {
                    //Validate the year entry
                    if (int.TryParse(yearTextBox.Text, out year) && year < 100)
                    {
                        //Test to see if date is magic.
                        if (month * day == year)
                        {
                            //Display message showing date is magic.
                            MessageBox.Show("Your Date is Magic!");
                        }
                        else
                        {
                            //Display message showing date is not magic.
                            MessageBox.Show("Your Date is NOT Magic.");
                        }
                    }
                    else
                    {
                        //Display message showing entry for year is invalid.
                        MessageBox.Show("Invalid Year.  Try again.");
                    }
                }
                else
                {
                    //Display message showing entry for day is invalid.
                    MessageBox.Show("Invalid Day.  Try again.");
                }
            }
            else
            {
                //Display message showing entry for month is invalid.
                MessageBox.Show("Invalid Month.  Try again.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }
    }
}
