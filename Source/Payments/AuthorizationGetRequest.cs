// This class was generated on Mon, 11 Dec 2017 13:16:30 CST by version 0.1 of Braintree SDK Generator
// AuthorizationGetRequest.cs
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
     * Shows details for an authorization, by ID.
     */
    public class AuthorizationGetRequest : HttpRequest
    {
        public AuthorizationGetRequest(string AuthorizationId) : base("/v1/payments/authorization/{authorization_id}?", HttpMethod.Get, typeof(Authorization))
        {
            try {
                this.Path = this.Path.Replace("{authorization_id}", Uri.EscapeDataString(Convert.ToString(AuthorizationId) ));
            } catch (IOException ignored) {}
            
            this.ContentType =  "application/json";
        }
        
    }
}
