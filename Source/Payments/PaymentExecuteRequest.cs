// This class was generated on Mon, 11 Dec 2017 13:16:34 CST by version 0.1 of Braintree SDK Generator
// PaymentExecuteRequest.cs
// @version 0.1
// @type request
// @data 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
// DO NOT EDIT
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;

namespace PayPal.Payments
{
    /**
     * Executes a PayPal payment that the customer has approved. You can optionally update one or more transactions when you execute the payment.<blockquote><strong>Important:</strong> This call works only after a customer has approved the payment. For more information, learn about [PayPal payments](/docs/integration/direct/payments/paypal-payments/).</blockquote>
     */
    public class PaymentExecuteRequest : HttpRequest
    {
        public PaymentExecuteRequest(string PaymentId) : base("/v1/payments/payment/{payment_id}/execute?", HttpMethod.Post, typeof(Payment))
        {
            try {
                this.Path = this.Path.Replace("{payment_id}", Uri.EscapeDataString(Convert.ToString(PaymentId) ));
            } catch (IOException ignored) {}
            
            this.ContentType =  "application/json";
        }
        

        public PaymentExecuteRequest RequestBody(PaymentExecution PaymentExecution) 
        {
            this.Body = PaymentExecution;
            return this;
        }
    }
}
