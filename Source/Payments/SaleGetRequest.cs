// This class was generated on Mon, 11 Dec 2017 13:16:36 CST by version 0.1 of Braintree SDK Generator
// SaleGetRequest.cs
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
     * Shows details for a sale, by ID. Returns only sales that were created through the REST API.
     */
    public class SaleGetRequest : HttpRequest
    {
        public SaleGetRequest(string SaleId) : base("/v1/payments/sale/{sale_id}?", HttpMethod.Get, typeof(Sale))
        {
            try {
                this.Path = this.Path.Replace("{sale_id}", Uri.EscapeDataString(Convert.ToString(SaleId) ));
            } catch (IOException ignored) {}
            
            this.ContentType =  "application/json";
        }
        
    }
}
