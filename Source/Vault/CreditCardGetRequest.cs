// This class was generated on Wed, 13 Dec 2017 14:34:03 CST by version 0.1 of Braintree SDK Generator
// CreditCardGetRequest.cs
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

namespace PayPal.Vault
{
    /// <summary>
    /// Shows details for a vaulted credit card, by ID.
    /// </summary>
    public class CreditCardGetRequest : HttpRequest
    {
        public CreditCardGetRequest(string CreditCardId) : base("/v1/vault/credit-cards/{credit_card_id}?", HttpMethod.Get, typeof(CreditCard))
        {
            try {
                this.Path = this.Path.Replace("{credit_card_id}", Uri.EscapeDataString(Convert.ToString(CreditCardId) ));
            } catch (IOException) {}
            
            this.ContentType =  "application/json";
        }
        
    }
}
