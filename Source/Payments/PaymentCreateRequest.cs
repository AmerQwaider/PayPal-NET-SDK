// This class was generated on Wed, 13 Dec 2017 14:31:56 CST by version 0.1 of Braintree SDK Generator
// PaymentCreateRequest.cs
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
    /// Creates a sale, an authorized payment to be captured later, or an order. To create a sale, authorization, or order, include the payment details in the JSON request body. Set the `intent` to `sale`, `authorize`, or `order`. Include payer, transaction details, and, for PayPal payments only, redirect URLs. The combination of the `payment_method` and `funding_instrument` determines the type of payment that is created. For more information, see [Payments REST API](/docs/integration/direct/payments/).<blockquote><strong>Note:</strong> Authorizations are guaranteed for up to three days, though you can attempt to capture an authorization for up to 29 days. After the three-day honor period authorization expires, you can [reauthorize](#authorization_reauthorize) the payment.</blockquote>
    /// </summary>
    public class PaymentCreateRequest : HttpRequest
    {
        public PaymentCreateRequest() : base("/v1/payments/payment?", HttpMethod.Post, typeof(Payment))
        {
            
            this.ContentType =  "application/json";
        }
        

        public PaymentCreateRequest RequestBody(Payment Payment) 
        {
            this.Body = Payment;
            return this;
        }
    }
}
