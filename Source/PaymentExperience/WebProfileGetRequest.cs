// This class was generated on Thu, 07 Dec 2017 14:41:28 PST by version 0.1 of Braintree SDK Generator
// WebProfileGetRequest.cs
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

namespace PayPal.PaymentExperience
{
    /**
     * Shows details for a web experience profile, by ID.
     */
    public class WebProfileGetRequest : HttpRequest
    {
        public WebProfileGetRequest(string ProfileId) : base("/v1/payment-experience/web-profiles/{profile_id}?", HttpMethod.Get, typeof(WebProfile))
        {
            try {
                this.Path = this.Path.Replace("{profile_id}", Uri.EscapeDataString(Convert.ToString(ProfileId) ));
            } catch (IOException ignored) {}
            
            this.ContentType =  "application/json";
        }
        
    }
}
