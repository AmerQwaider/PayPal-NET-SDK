// This class was generated on Wed, 13 Dec 2017 14:31:58 CST by version 0.1 of Braintree SDK Generator
// PaymentUpdateRequest.cs
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
    /// Partially updates a payment, by ID. You can update the amount, shipping address, invoice ID, and custom data. You cannot update a payment after the payment executes.
    /// </summary>
    public class PaymentUpdateRequest<T> : HttpRequest
    {
        public PaymentUpdateRequest(string PaymentId) : base("/v1/payments/payment/{payment_id}?", new HttpMethod("PATCH"), typeof(Payment))
        {
            try {
                this.Path = this.Path.Replace("{payment_id}", Uri.EscapeDataString(Convert.ToString(PaymentId) ));
            } catch (IOException) {}
            
            this.ContentType =  "application/json";
        }
        

        public PaymentUpdateRequest<T> RequestBody(List<JsonPatch<T>> PatchRequest) 
        {
            this.Body = PatchRequest;
            return this;
        }
    }
}
