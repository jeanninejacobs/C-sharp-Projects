using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automotive
{
    public partial class Form1 : Form
    {
        //Set constant for sales tax.
        private const double SALES_TAX = 0.06;

        //Set all variables.
        double lubeSubTotal = 0, flushSubTotal = 0, miscSubTotal = 0,
            laborSubTotal = 0, servicesSubTotal = 0,
            partsCost = 0, partsSubTotal = 0, taxForParts = 0, totalFees = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        //The OilLubeCharges method returns the total charges for an oil
        //change and/or a lube job, if any.
        private double OilLubeCharges(out double lubeSubTotal)
        {
            double oilChangeCost = 0, lubeJobCost = 0;
            
            if (oilChangeCheckBox.Checked == true)
            {
                oilChangeCost = 26;
            }

            if (lubeJobCheckBox.Checked == true)
            {
                lubeJobCost = 18;
            }

            return lubeSubTotal = oilChangeCost + lubeJobCost;

        }

        //The FlushCharges method returns the total charges for a
        //radiator flush and/or a transmission flush, if any.
        private double FlushCharges(out double flushSubTotal)
        {
            double radFlushCost = 0, tranFlushCost = 0;
            
            if (radFlushCheckBox.Checked == true)
            {
                radFlushCost = 30;
            }

            if (tranFlushCheckBox.Checked == true)
            {
                tranFlushCost = 80;
            }

            return flushSubTotal = radFlushCost + tranFlushCost;
        }

        //The MiscCharges method returns the total charges for an 
        //inspection, muffler replacement, and/or tire rotation, if any.
        private double MiscCharges(out double miscSubTotal)
        {
            double inspCost = 0, muffCost = 0, tireCost = 0;
            
            if (inspectionCheckBox.Checked == true)
            {
                inspCost = 15;
            }

            if (mufflerCheckBox.Checked == true)
            {
                muffCost = 100;
            }

            if (tireCheckBox.Checked == true)
            {
                tireCost = 20;
            }

            return miscSubTotal = inspCost + muffCost + tireCost;
        }

        //The PartsCost method returns the total charges for parts, if any.
        private double PartsCost(out double partsCost)
        {
            if (double.TryParse(partsTextBox.Text, out partsCost))
            {
                partsCost = double.Parse(partsTextBox.Text);
                return partsCost;
            }
            else
            {
                return partsCost = 0;
            }
        }

        //The PartsTax method returns the tax for parts, if any.
        private double PartsTaxAndCharges(out double taxForParts)
        {
            if (partsCost > 0)
            {
                return taxForParts = partsCost * SALES_TAX;
            }
            else
            {
                return taxForParts = 0;
            }
        }

        //The ServicesSubTotal method returns the subtotal for all services, without parts, if any.
        private double ServicesSubTotal(out double servicesSubTotal)
        {
            if (double.TryParse(laborTextBox.Text, out laborSubTotal))
            {
                laborSubTotal = double.Parse(laborTextBox.Text);
            }
            
            return servicesSubTotal = lubeSubTotal + flushSubTotal + miscSubTotal + laborSubTotal;
        }

        //The TotalCharges method returns the total charges.
        private double TotalCharges(out double totalFees)
        {
            return totalFees = partsCost + miscSubTotal + lubeSubTotal + taxForParts +
                flushSubTotal + laborSubTotal;
        }

        //ClearOilLube method clears any checked boxes and total values in the Oil & Lube group
        private void ClearOilLube()
        {
            oilChangeCheckBox.Checked = false;
            lubeJobCheckBox.Checked = false;
        }

        //ClearLubeSubTotal clears any values set to the group's variable
        private void ClearLubeSubTotal(ref double lubeSubTotal)
        {
            lubeSubTotal = 0;
        }


        //ClearFlushes method clears and checked boxes in the Flushes group
        private void ClearFlushes()
        {
            radFlushCheckBox.Checked = false;
            tranFlushCheckBox.Checked = false;
        }

        //ClearFlushSubTotal clears any values set to the group's vairable
        private void ClearFlushSubTotal(ref double flushSubTotal)
        {
            flushSubTotal = 0;
        }

        //ClearMisc method clears any checked boxes in the Misc group
        private void ClearMisc()
        {
            inspectionCheckBox.Checked = false;
            mufflerCheckBox.Checked = false;
            tireCheckBox.Checked = false;
        }

        //ClearMiscSubTotal method clears any values set to the group's variable
        private void ClearMiscSubTotal(ref double miscSubTotal)
        {
            miscSubTotal = 0;
        }

        //ClearOther method clears any input in the parts and labor group
        private void ClearOther()
        {
            partsTextBox.Text = " ";
            laborTextBox.Text = " ";
        }

        //ClearPartsCost method clears any values set to the variable.
        private void ClearPartsCost(ref double partsCost)
        {
            partsCost = 0;
        }

        //ClearTax method clears any value set to the variable.
        private void ClearTax(ref double taxForParts)
        {
            taxForParts = 0;
        }

        //ClearServicesSubTotal method clears any value set to the variable.
        private void ClearServicesSubTotal(ref double servicesSubTotal)
        {
            servicesSubTotal = 0;
        }

        //ClearTotalFees method clears any value set to the variable.
        private void ClearTotalFees(ref double totalFees)
        {
            totalFees = 0;
        }

        //ClearFees method clears all labels in the summary group
        private void ClearFees()
        {
            outputLaborLabel.Text = " ";
            outputPartsLabel.Text = " ";
            outputTaxLabel.Text = " ";
            outputTotalLabel.Text = " ";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Call all methods to calculate subtotals and total charges.
            OilLubeCharges(out lubeSubTotal);
            FlushCharges(out flushSubTotal);
            MiscCharges(out miscSubTotal);
            PartsCost(out partsCost);
            PartsTaxAndCharges(out taxForParts);
            ServicesSubTotal(out servicesSubTotal);
            TotalCharges(out totalFees);

            //Display all totals.
            outputLaborLabel.Text = servicesSubTotal.ToString("c");
            outputPartsLabel.Text = partsCost.ToString("c");
            outputTaxLabel.Text = taxForParts.ToString("c");
            outputTotalLabel.Text = totalFees.ToString("c");

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Call all methods to clear items in form.
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();

            //Call all methods to clear values from variables.
            ClearLubeSubTotal(ref lubeSubTotal);
            ClearFlushSubTotal(ref flushSubTotal);
            ClearMiscSubTotal(ref miscSubTotal);
            ClearPartsCost(ref partsCost);
            ClearTax(ref taxForParts);
            ClearServicesSubTotal(ref servicesSubTotal);
            ClearTotalFees(ref totalFees);

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Exit the form
            this.Close();
        }

    }
}
