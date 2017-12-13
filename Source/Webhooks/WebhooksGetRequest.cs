// This class was generated on Wed, 13 Dec 2017 14:33:09 CST by version 0.1 of Braintree SDK Generator
// WebhooksGetRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/6yVwXPrNBDG7/wVO+LS98aJCwcOvmXaQDtTSGgCHDqZemNtYjWK1kjrBk8n/zsjO2nSBCiFd/QnrfT7Pq3kF/UTrkllakPzknkV+ksSlahrCoU3lRh2KlOTkjcBNAkaG2DBHhB2BQnMG7i97qtE/VyTb8bocU1CPqjsYZaoG0JN/lT9nv36VBujlG+0FzVtqsgWxBu3VIn6Fb3BuaW3zI9GnxFPS4Lba+AFSEl71pZ8U5qiBGEIJW/2niL+wHtsuh0vE3VPqEfONipboA0Uhd9r40mrTHxNiRp7rsiLoaAyV1u7nXVzKEi3SBSjFCp2gTrt1dJvHdG5pzMnI0fAHtbsDz54/kSFfIx6JxxjHxIePpMTaD/OiCiOPUpTUTiDGzjACBCDrquYqpCDtiLEr0PY9TzWzQkarv3eSB+mx0PCgNbuy40rbK2NW4KjzV7EEA+0AfQEqDXpBEJFhVk07UFjEPImrOAi/5x/go2xGgr0ut3IU2WxoHZifuQq7zy8XSn/nJ+UWxOk5Qt1VbEX0juoBB66sWc0Nga302cXX79KvVbqxf36cfKnk7P77r90XPLuDfm3N+P/dtIJzp1xKzjaFkZtw57zWeNW/9xVvrtSPU8WY+QPN4PpcDSYQFs6u0g1FyHFyqQlCjGGXjuQfizg9y39XcK1t38Z8S/3dyAlCpgABbuFWdaedGzxePzkgB3klgu0JQfJ26fJuILXseHz8WgyzcGxmIUpsI1wTSHgkkK3asFO0OyuGhi3YL9u532Rl2ybqCt2Qm73lCmsKrsDSZ8CO5WoG5HqR5KStcrUD8Op6l5wlan0+Zv0GD2k+59L+nJ4srcqUcM/KiqE9ERQ6nDFmlT27eXl9qs/AQAA//8=
// DO NOT EDIT
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;

namespace PayPal.Webhooks
{
    /// <summary>
    /// Shows details for a webhook, by ID.
    /// </summary>
    public class WebhooksGetRequest : HttpRequest
    {
        public WebhooksGetRequest(string WebhookId) : base("/v1/notifications/webhooks/{webhook_id}?", HttpMethod.Get, typeof(Webhook))
        {
            try {
                this.Path = this.Path.Replace("{webhook_id}", Uri.EscapeDataString(Convert.ToString(WebhookId) ));
            } catch (IOException) {}
            
            this.ContentType =  "application/json";
        }
        
    }
}
