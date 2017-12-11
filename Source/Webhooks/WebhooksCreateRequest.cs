// This class was generated on Mon, 11 Dec 2017 17:22:29 CST by version 0.1 of Braintree SDK Generator
// WebhooksCreateRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/+xWQW8aPRC9f79i5O+SRAub9NDD3lCSKpXSQgNtDxHqDuuBdTC2a8+GrqL898q7gAg0aaMeeuEEfh573rw3O/KD+IgLEplY0qS0dh66hSdkEom4oFB45VhZIzIxrCZxOaEAta08rOJBq8BkyANboHsyHLoiEZ8q8vUAPS6IyQeR3Y4TcUUoye+i76xf7GID5HIXu6HvFQUe1Y5E9iDaX/G1pSES8QW9wommp/Xs1dE3BNbDwnra1GAnd1S0xHveY93efRpzouwbXYtsijpQS0J5khtg4K0jz4oiyw2ryygENIs9Yo1I37h2FPbI9QxgJAB2CpWLkjKZlaxxtSxVUcY/Ye3GEzO6MNreYguo9fq4MoWupDIzMLRcgxiAS6oBPQFKSTKB4KhQ0zrigIHJqzCHo/wkP4al0hIK9LJJ5MlpLKgJzLeqytsant6Un+Q7x2PjNPxC5Zz1THJFKoHbdu8elY7CrfDx0f8bqNNAnZivG4OPd7x7+6J37Ksd60yl9WOy8S+wV2a2752Se5aNSoL3F9GwWObaiL/spB0618rMYSst9JuG3eenlZm/3FW+/Yo6njRGyW+veqPLfm8IzdHxUSptEVJ0Ki2RyWLoNBvp6wT+fUnPKVx5/UuJP99cA5fIoAIU1kzVrPIkY4u3AwisgVzbAnVpA+cwtT52vF3Ehs8H/eEoB2NZTVWBjYQLCgFnFNpbC2sY1epTA2Wm1i+auFc5+UxfjR9jUHDWBPrT8XWYW4e5dZhbh7n1r+fWuTVMZvXqEuicXhFJ74I1IhFXzO4DcWmlyETkK9rnm8hEen+WbnMP6fqRKRJx+cNRwSSHjFyFcytJZG9Ozx7/+wkAAP//
// DO NOT EDIT
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;

namespace PayPal.Webhooks
{
    /**
     * Subscribes your webhook listener to events.
     */
    public class WebhooksCreateRequest : HttpRequest
    {
        public WebhooksCreateRequest() : base("/v1/notifications/webhooks?", HttpMethod.Post, typeof(Webhook))
        {
            
            this.ContentType =  "application/json";
        }
        

        public WebhooksCreateRequest RequestBody(Webhook Webhook) 
        {
            this.Body = Webhook;
            return this;
        }
    }
}
