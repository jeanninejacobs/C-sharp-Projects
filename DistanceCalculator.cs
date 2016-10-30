using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Distance_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Declare variables
            int speed;
            int hours;
            int distance;
            int count = 1;

            //Get user information
            speed = int.Parse(speedTextBox.Text);
            hours = int.Parse(hoursTextBox.Text);

            //Calculate distance and display in ListBox
            while (count <= hours)
            {
                //Calculate the distance
                distance = speed * count;

                //Add this iteration to the ListBox
                outputListBox.Items.Add("After hour " + count + " the distance is " + distance);

                //Add one to the count variable
                count += 1;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }
    }
}
