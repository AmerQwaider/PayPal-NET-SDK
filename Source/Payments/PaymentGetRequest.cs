// This class was generated on Wed, 13 Dec 2017 14:31:57 CST by version 0.1 of Braintree SDK Generator
// PaymentGetRequest.cs
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
    /// <summary>
    /// Shows details for a payment, by ID, that has yet to complete. For example, shows details for a payment that was created, approved, or failed.
    /// </summary>
    public class PaymentGetRequest : HttpRequest
    {
        public PaymentGetRequest(string PaymentId) : base("/v1/payments/payment/{payment_id}?", HttpMethod.Get, typeof(Payment))
        {
            try {
                this.Path = this.Path.Replace("{payment_id}", Uri.EscapeDataString(Convert.ToString(PaymentId) ));
            } catch (IOException) {}
            
            this.ContentType =  "application/json";
        }
        
    }
}
