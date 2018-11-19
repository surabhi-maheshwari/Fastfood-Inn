<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Payment_Gateway.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <script>
        function closeWindow() {
            alert("Your order is ready for processing. \nYou can pay to the delivery person in cash on arrival. \nThank you for choosing FastFood Inn")
            setTimeout(function() { window.close() }, 2000);
        }
    </script>
</head>


<body style="position: absolute; top: 36%; left: 45%">

    <button type="button" onclick="closeWindow()" class="stripe-button-el" style="visibility: visible;">
        <span style="display: block; min-height: 30px; min-width: 100px">Pay with Cash</span>
    </button>
    <br />
    <br />

    <form action="/Charge" method="POST">
        <script
            src="https://checkout.stripe.com/checkout.js" class="stripe-button"
            data-key="<%= stripePublishableKey %>"
            data-amount="<%= totalPayment %>"
            data-name="Stripe.com"
            data-description="Sample Charge"
            data-locale="auto"
            data-label="Pay with Stripe"
            data-zip-code="true">
        </script>
    </form>
    <%--<asp:Button text="Pay By Cash" ID="Button1" runat="server" CssClass="stripe-button-el"/>--%>
</body>
</html>
