using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Michaeltask1
{
    public partial class Form1 : Form
    {
        
        float total;
        public Form1()
        {
            InitializeComponent();
        }
        // function: to reset the values put on the numAge and numericPrice
        private void resetInputs()
        {
            numAge.Value = 0;
            numericPrice.Value = 0;
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            
            float purchasedvalue = (float)numericPrice.Value;
            int age = (int)numAge.Value;
            //if the input is 0 then remind the user that there is an error and they should enter a valid price or year
            //input: purchasedvalue,age
            //output: "Please enter a valid price or year"
            if (purchasedvalue == 0 | age == 0) 
            {
                lblWorth.Text = "Please enter a valid price or year";
            }
            else
            {
            //if user did enter a valid price and year,the program will calculate the current value and the collection so far is worth
            //input:purchasedvalue,age
            //output: currentValue and total
                float currentValue = CalculateCurrentValue(purchasedvalue, age);
                total += currentValue;
                lblWorth.Text = $"It is worth${currentValue}\n The collection so far is worth ${total}";

            }
            resetInputs();
        }

        //the textbook will depreciate 20% of its original value when purchased after one year,after the second year it will loses 40% then third year will be 60% and so on and after five years the textbook will be worthless
       
        private float CalculateCurrentValue(float purchasedValue, int age)
        {
            float depreciation = purchasedValue * 0.2f * age;
            if (depreciation > purchasedValue) return 0f;
            return purchasedValue - depreciation;
        }
        //user click the end button to clear the numAge and numericPrice and also the lblWorth
        private void btnEnd_Click(object sender, EventArgs e)
        {
            resetInputs();
            lblWorth.Text = "";
        }
    }
}
