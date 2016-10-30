using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coin_Toss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tossButton_Click(object sender, EventArgs e)
        {
            //variable to indicate which side it up
            int sideUp;

            //Create a Random object
            Random rand = new Random();

            //Get random integer in the range of 0 through 1
            //0 means tails, 1 means heads
            sideUp = rand.Next(2);

            //display the side that is up
            if (sideUp == 0)
            {
                //display tails up
                tailsPictureBox.Visible = true;
                headsPictureBox.Visible = false;
            }
            else
            {
                //display heads up
                headsPictureBox.Visible = true;
                tailsPictureBox.Visible = false;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }
    }
}
