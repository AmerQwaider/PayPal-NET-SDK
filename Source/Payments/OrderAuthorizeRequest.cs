// This class was generated on Mon, 11 Dec 2017 13:16:32 CST by version 0.1 of Braintree SDK Generator
// OrderAuthorizeRequest.cs
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
     * Authorizes an order, by ID. In the JSON request body, include an `amount` object.
     */
    public class OrderAuthorizeRequest : HttpRequest
    {
        public OrderAuthorizeRequest(string OrderId) : base("/v1/payments/orders/{order_id}/authorize?", HttpMethod.Post, typeof(Authorization))
        {
            try {
                this.Path = this.Path.Replace("{order_id}", Uri.EscapeDataString(Convert.ToString(OrderId) ));
            } catch (IOException ignored) {}
            
            this.ContentType =  "application/json";
        }
        

        public OrderAuthorizeRequest RequestBody(Order Order) 
        {
            this.Body = Order;
            return this;
        }
    }
}
