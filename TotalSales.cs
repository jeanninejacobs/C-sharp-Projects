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

namespace Total_Sales
{
    public partial class Form1 : Form
    {
        //Create array to hold items read from the file.
                const int SIZE = 7;
                decimal[] sales = new decimal[SIZE];
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //Counter variable for loop
                int index = 0;

                //Declare a StreamReader variable
                StreamReader inputFile;

                //Open the file and get StreamReader object
                inputFile = File.OpenText("Sales.txt");

                //Read the file's contents into the array
                while (index < sales.Length)
                {
                    sales[index] = decimal.Parse(inputFile.ReadLine());
                    index++;
                }

                //Close file
                inputFile.Close();

                //Display the array elements in list box
                foreach (decimal value in sales)
                {
                    salesListBox.Items.Add(value);
                }
            }
            catch (Exception ex)
            {
                //Display an error message
                MessageBox.Show(ex.Message);
            }
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            //Declare and initalize an accumulator variable
            decimal total = 0;

            //Step through the array, adding each value to total
            for (int i = 0; i < sales.Length; i++)
            {
                total += sales[i];
            }

            //Display the total
            totalOutputLabel.Text = total.ToString("n2");

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }
    }
}
