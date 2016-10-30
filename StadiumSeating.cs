using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stadium_Seating
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void instructionsLabel_Click(object sender, EventArgs e)
        {

        }

        private void calculateRevenueButton_Click(object sender, EventArgs e)
        {
            //Create variables for ticket prices
            double classATicket;
            double classBTicket;
            double classCTicket;
            classATicket = 15;
            classBTicket = 12;
            classCTicket = 9;
            
            //Calculate revenue based on user input
            double revenueClassA;
            double revenueClassB;
            double revenueClassC;
            revenueClassA = double.Parse(classATicketsSoldTextBox.Text) * classATicket;
            revenueClassB = double.Parse(classBTicketsSoldTextBox.Text) * classBTicket;
            revenueClassC = double.Parse(classCTicketsSoldTextBox.Text) * classCTicket;
            
            //Display revenue for ticket sales
            classARevenueLabel.Text = revenueClassA.ToString("c");
            classBRevenueLabel.Text = revenueClassB.ToString("c");
            classCRevenueLabel.Text = revenueClassC.ToString("c");
            
            //Calculate overall total revenue and display
            double totalRevenue;
            totalRevenue = revenueClassA + revenueClassB + revenueClassC;
            totalRevenueLabel.Text = totalRevenue.ToString("c");

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Reset form
            classATicketsSoldTextBox.Text = " ";
            classBTicketsSoldTextBox.Text = " ";
            classCTicketsSoldTextBox.Text = " ";
            classARevenueLabel.Text = " ";
            classBRevenueLabel.Text = " ";
            classCRevenueLabel.Text = " ";
            totalRevenueLabel.Text = " ";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Exit Form
            this.Close();
        }
    }
}
