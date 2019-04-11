// Grading ID: B9073
// Program Number: 1
// Due Date: September 27, 2016 11:59 PM
// Course Section: 75
// Brief Description: Creates tool that allows the user to enter square feet to pbe painted, coats of paint desired, and price of paint per gallon and the tool then calculates 6 different values based off of this information

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program1
{
    public partial class program1Form : Form
    {
        public program1Form()
        {
            InitializeComponent();
        }

        // Creates a click event for the calculate button
        private void calculateButton_Click(object sender, EventArgs e)
        {
            const double LABOR_PER_HOUR = 12.50; // Establishes LABOR_PER_HOUR as a constant double with its value equal to 12.50
            const double SQUARE_FEET_PER_PAINT_GALLON = 275; // Establishes SQUARE_FEET_PER_PAINT_GALLON as a constant double with its value equal to 275
            const double HOURS_OF_LABOR_PER_PAINT_GALLON = 8; // Establishes HOURS_OF_LABOR_PER_PAINT_GALLON as a constant double with its value equal to 8

            double squareFeetToBePainted; // Establishes squareFeetToBePainted as a double value
            int paintCoatsDesired; // Establishes paintCoatsDesired as an integer value
            double paintPricePerGallon; // Establishes paintPricePerGallon as a double value
            double totalSquareFeetToBePainted; // Establishes totalSquareFeetToBePainted as a double value
            int paintGallonsRequired; // Establishes paintGallonsRequired as an integer value
            double paintGallonsRequiredCalculation; // Estblishes paintGallonsRequiredCalculatoin as a double value
            double hoursOfLaborRequired; // Establishes hoursOfLaborRequired as a double value
            double costOfPaintGallons; // Establishes costOfPaintGallons as a double value
            double totalCostOfLabor; // Establishes totalCostOfLabor as a double value
            double totalCostOfPaintJob; // Establishes totalCostOfPaintJob as a double value

            squareFeetToBePainted = double.Parse(squareFeetTextBox.Text); // Use of double.Parse to convert numeric value in the squareFeetTextBox to the squareFeetToBePainted variable
            paintCoatsDesired = int.Parse(paintCoatTextBox.Text); // Use of int.Parse to convert numeric value in te paintCoatTextBox to the paintCoatsDesired variable
            totalSquareFeetToBePainted = squareFeetToBePainted * paintCoatsDesired; // Multiplies the values stores in squareFeetToBePainted and paintCoatsDesired variables and stores the result in the variable totalSquareFeetToBePainted
            totalSquareFeetOutputLabel.Text = totalSquareFeetToBePainted.ToString("n1"); // Converts value stored in totalSquareFeetToBePainted into a string with the use of ToString in the number format to one decimal point of accuracy and displays it in the totalSquareFeetOutputLabel

            paintGallonsRequiredCalculation = totalSquareFeetToBePainted / SQUARE_FEET_PER_PAINT_GALLON; // Divides total SquareFeetToBePainted value by constant SQUARE_FEET_PER_PAINT_GALLON and stores the quotient in the paintGallonsRequiredCalculation variable
            paintGallonsRequired = (int) Math.Ceiling(paintGallonsRequiredCalculation); // Uses Math.Ceiling operation on paintGallonsRequiredCalculation to make the value always round to the next highest integer. This double value is then cast as an integer value so that it can be stored in the paintGallonsRequired variable
            totalPaintGallonsOutputLabel.Text = paintGallonsRequired.ToString("n0"); // Converts value stored in paintGallonsRequired to a string with the use of ToString in the number format to zero decimal point accuracy and disaplys it in the totalPaintGallonsOutputLabel  

            hoursOfLaborRequired = paintGallonsRequiredCalculation * HOURS_OF_LABOR_PER_PAINT_GALLON; // Multiplies paintGallonsRequiredCalculation by the constant HOURS_OF_LABOR_PER_PAINT_GALLON with the product being stored in the hoursOfLaborRequired variable
            hoursOfLaborOutputLabel.Text = hoursOfLaborRequired.ToString("n1"); // Converts value stored in hoursOfLaborRequired variable to a string with the use of ToString in the number format to one decimal point of accuracy and displays it in the hoursOfLaborOutputLabel

            paintPricePerGallon = double.Parse(paintPriceTextBox.Text); // Use of double.Parse to convert numeric value in paintPriceTextBox to the paintPricePerGallon variable
            costOfPaintGallons = paintPricePerGallon * paintGallonsRequired; // Multiplies value stored in paintPricePerGallon by value stored in paintGallonsRequired with the product being stored in costOfPaintGallons
            costOfPaintOutputLabel.Text = costOfPaintGallons.ToString("c"); // Converts value stored in costOfPaintGallons to string by using ToString in the currency format and then displays value in the costOfPaintOutputLabel 

            totalCostOfLabor = hoursOfLaborRequired * LABOR_PER_HOUR; // Multiplies hoursOfLaborRequired by constant LABOR_PER_HOUR and stores product in totalCostOfLabor
            costOfLaborOutputLabel.Text = totalCostOfLabor.ToString("c"); // Converts totalCostOfLabor value to string by using ToString in the currency format and displays value in costOfLaborOutputLabel

            totalCostOfPaintJob = totalCostOfLabor + costOfPaintGallons; // Adds values stored in totalCostOfLabor and costOfPaintGallons and stores sum in totalCostOfPaintJob
            totalCostOutputLabel.Text = totalCostOfPaintJob.ToString("c"); // Converts totalCostOfPaintJob to string by using ToString in the currency format and displays value in totalCostOutputLabel

          

            

        
        }
    }
}
