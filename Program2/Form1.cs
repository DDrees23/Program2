using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//K7151
//CIS-199-01
//Program4
//11/30./2022
//This program is a simple program to calculate policy totals while showing messageboxes if there is any errors in code.

namespace Program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void policyButton_Click(object sender, EventArgs e)
        {
            
            const double SMOKERFEE = 30;

            double healthInsPrice;
            double smokePrice;
            double healthCoverageCost;
            double yearlyHealthCost;

            int age;
            int carYear;
            double youthPremium;
            double newCarPremium;
            double autoIns;
            double accidentFactor;
            double autoCost;
            double yearlyAutoCost;

            double totalCost;

            string ageString;
            ageString = ageTextBox.Text;

            string carString;
            carString = carYearTextBox.Text;

            //gave the two text boxes a string then assigned all data types to ater use in code and equations.


            if (healthComboBox.SelectedIndex == 0)
            {
                
              healthInsPrice = 100;
            }
            else if (healthComboBox.SelectedIndex == 1)
            {
                healthInsPrice = 75;
            }
            else if(healthComboBox.SelectedIndex == 2)
            {
                    healthInsPrice = 25;
            }
            else
            {
                healthInsPrice = 0;
            }
            
            if (smokeYesButton.Checked)
            {
                smokePrice = SMOKERFEE;
            }
            else
            {
                smokePrice = 0;
            }

            healthCoverageCost = healthInsPrice + smokePrice;
            yearlyHealthCost = healthCoverageCost * 12;
            string healthString = $"{yearlyHealthCost:C}";
            healthOutputLabel.Text = healthString;


            //used a if else statement for combo box that selects each value and gives that value that the user selects a value and if user selects none, return a zero.
            //used a button.checked for the yes or no bullets and gave the yes and no eacha  value
            //converted the two values user selects and plugged them intoa  equation then converted to a yearly rate then displayed it in output boc using string interpolation.


            if(int.TryParse(ageString, out age) && age < 25)
            {
                youthPremium = 10;
            }
            
            else
            {
                youthPremium = 0;
            }
               

            

            if (int.TryParse(carString, out carYear) && carYear >= 2012)
            {
                newCarPremium = 15;
            }
            else
            {
                newCarPremium = 0;
            }

            
            if(carComboBox.SelectedIndex == 0)
            {
                autoIns = 115;
            }
                else if(carComboBox.SelectedIndex == 1)
                {
                    autoIns = 60;
                }
                else
                {
                    autoIns = 0;
                }



            if (carYesButton.Checked)
            {
                accidentFactor = 1.3;
            }
            else
            {
                accidentFactor = 1;
            }

            autoCost = autoIns * accidentFactor + youthPremium + newCarPremium;
            yearlyAutoCost = autoCost * 12;
            string autoString = $"{yearlyAutoCost:C}";
            carOutputLabel.Text = autoString;

            //used if statement with tryparse so the user has to enter integers then gave the value the user enters a conversion to convert to for both age and car year.
            //used nested if for the combo box and gave each selected value within the box a value for later equations, If user left blank, this equals zero.
            //Gave yes and no buttons a value of 1.3 for a wreck and just 1 so the total would calculate normally for either way
            //converted monthly cost based on user data and then converted that monthly cost to yearly then displayed it in a label using string interpolation.

            totalCost = yearlyAutoCost + yearlyHealthCost;
            string totalString = $"{totalCost:C}";
            totalOutputLabel.Text = totalString;

            //Converted total cost and displayed it into the overal total using string interpolation

            if (int.TryParse(carString, out carYear) && int.TryParse(ageString, out age))
            {
                MessageBox.Show("Policy Totals Calculated");
            }
            else if (int.TryParse(carString, out carYear))
            {
                MessageBox.Show("Invalid Format, Please Enter Age");
            }
            else if (int.TryParse(ageString, out age))
            {
                MessageBox.Show("Invalid Format, Please Enter Car Year");
            }
            else
            {
                MessageBox.Show("Please Fill in Age and Car Year");
            }

            //Used a series of nested if statements to display a messagebox if the user leaves any of the text boxes blank and if both left blank, tells the user to fill in both.
        }
    }
}