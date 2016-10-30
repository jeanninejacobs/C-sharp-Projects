using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roman_Numeral_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numberConversionButton_Click(object sender, EventArgs e)
        {
            int number;     //To hold the number to be converted.

            //Get the number
            if (int.TryParse(numberTextBox.Text, out number)
            {
                if (number > 0 && number < 11)  //Test if number is in range
                {
                    switch (number)     //Convert to roman numeral
                    {
                        case 1:
                            outputRomanNumeralLabel.Text = "I";
                            break;
                        case 2:
                            outputRomanNumeralLabel.Text = "II";
                            break;
                        case 3:
                            outputRomanNumeralLabel.Text = "III";
                            break;
                        case 4:
                            outputRomanNumeralLabel.Text = "IV";
                            break;
                        case 5:
                            outputRomanNumeralLabel.Text = "V";
                            break;
                        case 6:
                            outputRomanNumeralLabel.Text = "VI";
                            break;
                        case 7:
                            outputRomanNumeralLabel.Text = "VII";
                            break;
                        case 8:
                            outputRomanNumeralLabel.Text = "VIII";
                            break;
                        case 9:
                            outputRomanNumeralLabel.Text = "IX";
                            break;
                        case 10:
                            outputRomanNumeralLabel.Text = "X";
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a number between 1-10");
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear form
            numberTextBox.Text = " ";
            outputRomanNumeralLabel.Text = " ";

            //Reset focus
            numberTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close form
            this.Close();
        }
    }
}
