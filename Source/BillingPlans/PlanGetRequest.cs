// This class was generated on Wed, 13 Dec 2017 14:32:50 CST by version 0.1 of Braintree SDK Generator
// PlanGetRequest.cs
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

namespace PayPal.BillingPlans
{
    /// <summary>
    /// Shows details for a billing plan, by ID.
    /// </summary>
    public class PlanGetRequest : HttpRequest
    {
        public PlanGetRequest(string PlanId) : base("/v1/payments/billing-plans/{plan_id}?", HttpMethod.Get, typeof(Plan))
        {
            try {
                this.Path = this.Path.Replace("{plan_id}", Uri.EscapeDataString(Convert.ToString(PlanId) ));
            } catch (IOException) {}
            
            this.ContentType =  "application/json";
        }
        
    }
}
