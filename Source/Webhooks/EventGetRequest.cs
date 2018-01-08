// This class was generated on Mon, 08 Jan 2018 16:11:34 CST by version 0.1 of Braintree SDK Generator
// EventGetRequest.cs
// @version 0.1
// @type request
// @data H4sIAAAAAAAC/8yWXU/bShCG78+vGM254UhOzDnoINV3EYSC1BZaot6gCCb2JF6wd93ZMSFF+e/VxgkK+YBWINrbd2dX7zMfu3uPn6hkTJBv2Wp7xIoRHrJPxVRqnMUEz3M39pCxkik8DJ0AwZgHuXM3MNsF1qkZmpTChggGEzg5bGOEn2uWyRkJlawsHpOLfoTHTBnLqnrkpFzVzkjzR9o99iZV8OpVjB1hhF9JDA0KXma4NNkaQi9nODkENwTN+QnzM7pxbtIc1IHP3XjBHXg6IjRpLOxG+IUpO7XFBJMhFZ6D8K02whkmKjVHeCauYlHDHhNbF8W038Sw1+aQIAbJV856brQHxm4wt464htZ5AueXTM+FZdfPZzwVJuVLNSVvTHpGykA2gxAB45ztcxUYk4fm1CwCY+HixCqLZV05a+ikJO3v5KqVT+JYnSt827AO205Gca5lEcsw3dvbe/e35zSc3fq/vf/PS3Myq2T0k62oIWhTXhpwzUlBxYxGLJw9k5k3NX7L4oPb7d7nEaFEy75/g+MXzPsrO/xg7A0sOYHTwTWnG6a4MPbGr4+yBQpmgm9pLoqWcBFGAS6OO73uaeccZlv7O3HmUh9TZeKclB351mxhtb33X0jktgAIe1dLurm5F4t/ZH8vzG2fTUslL1rnAWVRB3Vb271heiMMX5clyWTDczBfgWypD8Ozpg+j+yjrcOQE+I7KquAIrjpQ0aQMUVRr7sR8X7uW21evgdifRnjgrLKdv4ZIVVXMXcXXfnb5HKtWH1lzl2GC77s9bH4FmGB8+2+8zOHjeUl8awbp4/vFb2CKEXbvKk6Vs3Mlrf2ByxiT/3Z3p3/9AAAA//8=
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
    /// Shows details for a webhook event notification, by ID.
    /// </summary>
    public class EventGetRequest : HttpRequest
    {
        public EventGetRequest(string EventId) : base("/v1/notifications/webhooks-events/{event_id}?", HttpMethod.Get, typeof(Event))
        {
            try {
                this.Path = this.Path.Replace("{event_id}", Uri.EscapeDataString(Convert.ToString(EventId) ));
            } catch (IOException) {}
            
            this.ContentType =  "application/json";
        }
        
    }
}
