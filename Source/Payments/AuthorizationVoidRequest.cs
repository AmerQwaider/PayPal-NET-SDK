// This class was generated on Wed, 13 Dec 2017 14:31:53 CST by version 0.1 of Braintree SDK Generator
// AuthorizationVoidRequest.cs
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
    /// Voids, or cancels, an authorization, by ID. You cannot void a fully captured authorization.
    /// </summary>
    public class AuthorizationVoidRequest : HttpRequest
    {
        public AuthorizationVoidRequest(string AuthorizationId) : base("/v1/payments/authorization/{authorization_id}/void?", HttpMethod.Post, typeof(Authorization))
        {
            try {
                this.Path = this.Path.Replace("{authorization_id}", Uri.EscapeDataString(Convert.ToString(AuthorizationId)));
            } catch (IOException) {}
            
            this.ContentType =  "application/json";
        }
    }
}
