// This class was generated on Tue, 30 Jan 2018 11:15:39 PST by version 0.1.0-dev+6beb51-dirty of Braintree SDK Generator
// PaymentExecution.cs
// @version 0.1.0-dev+6beb51-dirty
// @type object
// @data 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
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// Executes a PayPal account-based payment with the `payer_id` obtained from the web approval URL.
    /// </summary>
    [DataContract]
    public class PaymentExecution
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public PaymentExecution() {}

        /// <summary>
        /// The ID of the payer that PayPal passes in the `return_url`.
        /// </summary>
        [DataMember(Name="payer_id", EmitDefaultValue = false)]
        public string PayerId;

        /// <summary>
        /// An array of transaction details. Includes the amount and item details. For update and execute payment calls, the `transactions` object accepts only the `amount` object.
        /// </summary>
        [DataMember(Name="transactions", EmitDefaultValue = false)]
        public List<CartBase> Transactions;
    }
}

