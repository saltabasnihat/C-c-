using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab5_Statistic_Calculator
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtFirst.Text, out double firstNumber) &&
                double.TryParse(txtSecond.Text, out double secondNumber) &&
                double.TryParse(txtThird.Text, out double thirdNumber))
            {
                //calculateation
                double maximum = Math.Max(firstNumber, Math.Max(secondNumber, thirdNumber));
                double minimum = Math.Min(firstNumber, Math.Min(secondNumber, thirdNumber));
                double average = (firstNumber + secondNumber + thirdNumber) / 3;
                double total = firstNumber + secondNumber + thirdNumber;

                //display
                lblMax.Text = maximum.ToString();
                lblMin.Text = minimum.ToString();
                lblAverage.Text = average.ToString();
                lblTotal.Text = total.ToString();

                result.Visible = true;
            }
            else
            {
                // Display an error message for invalid input
                lblMax.Text = string.Empty;
                lblMin.Text = string.Empty;
                lblAverage.Text = string.Empty;
                lblTotal.Text = string.Empty;

                result.Visible = false;

                ClientScript.RegisterStartupScript(this.GetType(), "showError", "alert('Input string was not in a correct format.');", true);
            }
        }
    }
}
