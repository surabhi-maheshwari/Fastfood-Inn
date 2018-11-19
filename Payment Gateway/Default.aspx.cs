/*
 * Credits to 
 *  "https://stripe.com/docs/checkout/webforms"
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Payment_Gateway
{
    public partial class Default : System.Web.UI.Page
    {
        public string stripePublishableKey = WebConfigurationManager.AppSettings["StripePublishableKey"];
        public string totalPayment = "8000";
        protected void Page_Load(object sender, EventArgs e)
        {
               totalPayment = System.IO.File.ReadAllText("C:\\Users\\Surabhi Maheshwari\\source\\repos\\FastFoodDemo\\Payment Gateway\\Payment.txt");
        }
    }
}