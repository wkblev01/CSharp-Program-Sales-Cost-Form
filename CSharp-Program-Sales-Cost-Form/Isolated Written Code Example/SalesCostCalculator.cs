// Program 3
// CIS 199-01
// Due: 11/05/2020
// By: R1466

// This program creates a form with a combo box to select a state, and accepts text input for a product code and quantity.
// Form uses parallel arrays and for loops to match inputs with product price, tax, and discount. These totals are then calculated and output to the form.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program3
{
    public partial class SalesCostCalculator : Form
    {
        public string[] states = { "KY", "OH", "IN", "IL" };                        // Array that holds states listed in combo box. Used in for loop to determine tax rate.
        public double[] taxRates = { 0.06, 0.0717, 0.07, 0.0874 };                  // Parallel array that holds state tax rates. Once correct state is found, corresponding tax rate is pulled from here.
        public int[] products = { 1001, 1002, 1003, 1004, 1005, 1006, 1007 };       // Array that holds product codes. Used in for loop to determine product price per.
        public double[] prices = { 7.87, 9.51, 10.73, 9.99, 11.99, 5.00, 4.58 };    // Parallel array that holds product prices. Once correct product is found, corresponding price is pulled from here.
        public int[] qtyLowLimits = { 0, 5, 10, 20 };                               // Array that holds floor value for each discount tier. Used in while loop to determine discount rate.
        public double[] discountRates = { 0.0, 0.05, 0.10, 0.15 };                  // Parallel array that holds discount rate. Once correct discount tier is found, corresponding rate is pulled from here.

        public const int MIN_QTY = 0;               // Used in TryParse for Quantity to insure a positive value is entered.
        public const int PRODUCT_MIN = 1001;        // Used in TryParse for Product to insure product code is >= this number.
        public const int PRODUCT_MAX = 1007;        // Used in TryParse for Product to insure product code is <= this number.

        public int product,             // Variable that holds product code entered. Used in for loop determining product price.
                quantity,               // Variable that holds quantity of product entered. Used in while loop to find discount rate, and in initial cost calculation. 
                index;                  // Variable used to set threshold in while loop to determine discount rate.
        public double costPer,          // Holds applicable product price after found by for loop.
            taxPercent,                 // Holds applicable tax rate after found by for loop.
            discountPercent,            // Holds applicable discount rate after found by while loop.
            initialTotal,               // Holds calculation of initial total and is output to form.
            discountedTotal,            // Holds calculation of discounted total and is output to form.
            taxTotal,                   // Holds calculation of tax added and is output to form.
            grandTotal;                 // Holds calculation of total cost and is output to form.

        public SalesCostCalculator()
        {
            InitializeComponent();
        }

        // Event that triggers upon activation of calcButton.
        // Input is validated with TryParse in nested if statements. Then, two for loops and one while loop compare inputs to arrays, then provide data via parallel arrays.
        // Needed totals are then calculated and output to form.
        private void calcButton_Click(object sender, EventArgs e)
        {
            bool validInput = false,        // Boolean variable to hold if TryParse was successful.
                productFound = false,       // Used to stop for loop once correct product is found in array.
                stateFound = false,         // Used to stop for loop once correct state is found in array.
                quantityFound = false;      // Used to stop while loop once correct discount tier is found in array.




            // Tryparse for valid inputs
            if (stateComboBox.SelectedIndex >=0)        // Checks if a state is chosen from the combo box.
            {
                if (int.TryParse(productTxtBox.Text, out product) && product <= PRODUCT_MAX && product >= PRODUCT_MIN)      // Checks if product is an int as well as within valid range of codes.
                {
                    if (int.TryParse(quantityTxtBox.Text, out quantity) && quantity > MIN_QTY)          // Checks if quantity is a positive int.
                        validInput = true;                                                              // True if all TryParses succeed. Used to trigger rest of event code.
                    else
                        MessageBox.Show("Please enter a positive quantity of products needed.");    // Message if quantity is not valid.
                }
                else
                    MessageBox.Show("Please enter a valid product code.");                          // Message if product code is not valid.
            }
            else
                MessageBox.Show("Please select a state from the drop-down list.");                  // Message if state is not selected.


            // Calculation and Output
            if (validInput)                 // Only triggers if TryParses succeed.
            {
                // Find Product Cost
                for (int i = 0; i < products.Length && !productFound; ++i)      // Loops through products array until match is found.
                    if (products[i] == product)
                    {
                        productFound = true;                                    // Stops loop once match is found.
                        costPer = prices[i];                                    // Cost is assigned from parallel array.
                    }

                // Find Tax Rate
                for (int i = 0; i < states.Length && !stateFound; ++i)          // Loops through states array until match is found.
                    if (states[i] == stateComboBox.Text)
                    {
                        stateFound = true;                                      // Stops loop once match is found.
                        taxPercent = taxRates[i];                               // Tax Rate is assigned from parallel array.
                    }

                // Find Discount
                index = qtyLowLimits.Length - 1;
                while (index >= 0 && !quantityFound)                            // Loops through discount floor array until range match is found.
                {
                    if (quantity >= qtyLowLimits[index])
                        quantityFound = true;                                   // Stops loop once match is found.
                    else
                        --index;
                }
                if (quantityFound)
                    discountPercent = discountRates[index];                     // Discount Rate is assigned from parallel array.

                // Calculate output variables
                initialTotal = quantity * costPer;                                          
                discountedTotal = initialTotal - (initialTotal * discountPercent);
                taxTotal = discountedTotal * taxPercent;
                grandTotal = discountedTotal + taxTotal;

                // Output to Form Labels
                initCostOutLbl.Text = $"{initialTotal.ToString("C")}";
                discCostOutLbl.Text = $"{discountedTotal.ToString("C")}";
                taxOutLbl.Text = $"{taxTotal.ToString("C")}";
                totalCostOutLbl.Text = $"{grandTotal.ToString("C")}";
            }

        }
    }
}
