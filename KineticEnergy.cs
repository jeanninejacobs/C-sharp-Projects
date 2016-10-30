using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kinetic_Energy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //The KineticEnergy method accepts an object's mass and velocity 
        //as arguments and returns it's kinetic energy.
        private decimal KineticEnergy(decimal arg1, decimal arg2)
        {
            return (arg1 * arg2)/2;
        }
        
        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Variables to hold user input of mass, velocity, and energy.
            decimal mass, velocity, energy;

            //Get value of mass.
            if (decimal.TryParse(massTextBox.Text, out mass))
            {
                //Get value of velocity.
                if (decimal.TryParse(velocityTextBox.Text, out velocity))
                {
                    //Calculate kinetic energy
                    energy = KineticEnergy(mass, velocity);

                    //Display the kinetic energy
                    energyOutputLabel.Text = energy.ToString("n2");
                }
                else
                {
                    //Display an error message
                    MessageBox.Show("Enter a valid number for the object's velocity.");
                }
            }
            else
            {
                //Display an error message
                MessageBox.Show("Enter a valid number for the object's mass.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }
    }
}
