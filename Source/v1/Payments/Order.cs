// This class was generated on Tue, 30 Jan 2018 11:15:39 PST by version 0.1.0-dev+6beb51-dirty of Braintree SDK Generator
// Order.cs
// @version 0.1.0-dev+6beb51-dirty
// @type object
// @data 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
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// An order transaction.
    /// </summary>
    [DataContract]
    public class Order
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Order() {}

        /// <summary>
        /// REQUIRED
        /// The payment amount, with break-ups.
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue = false)]
        public Amount Amount;

        /// <summary>
        /// The date and time when the resource was created, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [DataMember(Name="create_time", EmitDefaultValue = false)]
        public string CreateTime;

        /// <summary>
        /// The [Fraud Management Filter (FMF)](/docs/classic/fmf/integration-guide/FMFSummary/) details.
        /// </summary>
        [DataMember(Name="fmf_details", EmitDefaultValue = false)]
        public FmfDetails FmfDetails;

        /// <summary>
        /// The ID of the order transaction.
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue = false)]
        public string Id;

        /// <summary>
        /// An array of request-related [HATEOAS links](/docs/api/overview/#hateoas-links).
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue = false)]
        public List<LinkDescriptionObject> Links;

        /// <summary>
        /// The ID of the payment on which this transaction is based.
        /// </summary>
        [DataMember(Name="parent_payment", EmitDefaultValue = false)]
        public string ParentPayment;

        /// <summary>
        /// The transaction payment mode.
        /// </summary>
        [DataMember(Name="payment_mode", EmitDefaultValue = false)]
        public string PaymentMode;

        /// <summary>
        /// [DEPRECATED] The reason code for the pending transaction state. Obsolete. Use `reason_code` instead.
        /// </summary>
        [DataMember(Name="pending_reason", EmitDefaultValue = false)]
        public string PendingReason;

        /// <summary>
        /// The level of seller protection in effect for the transaction.
        /// </summary>
        [DataMember(Name="protection_eligibility", EmitDefaultValue = false)]
        public string ProtectionEligibility;

        /// <summary>
        /// The kind of seller protection in effect for the transaction. Returned only when the `protection_eligibility` property is `ELIGIBLE` or `PARTIALLY_ELIGIBLE`. Supported only when the `payment_method` is `paypal`. One or both of these values can be returned:<ul><li><code>ITEM_NOT_RECEIVED_ELIGIBLE</code>. Sellers are protected against claims for items not received.</li><li><code>UNAUTHORIZED_PAYMENT_ELIGIBLE</code>. Sellers are protected against claims for unauthorized payments.</li></ul>
        /// </summary>
        [DataMember(Name="protection_eligibility_type", EmitDefaultValue = false)]
        public string ProtectionEligibilityType;

        /// <summary>
        /// The reason code that describes why the transaction state is pending or reversed. Eventually, this parameter will replace the `pending_reason` parameter. Supported only when the `payment_method` is `paypal`.
        /// </summary>
        [DataMember(Name="reason_code", EmitDefaultValue = false)]
        public string ReasonCode;

        /// <summary>
        /// The ID of the purchase unit that is associated with this object. Obsolete. Used only in `cart_base`.
        /// </summary>
        [DataMember(Name="reference_id", EmitDefaultValue = false)]
        public string ReferenceId;

        /// <summary>
        /// The order transaction state. Value is:<ul><li><code>pending</code>. The order was created but no authorizations/captures were made against the order.</li><li><code>authorized</code>. The order has only been authorized. No capture was made against the order.</li><li><code>captured</code>. The order has at least one capture initiated.</li><li><code>completed</code>. The order is complete as a capture was made against the order with <code>is_final_capture</code> set to <code>TRUE</code>. No more authorizations/captures can be made against this order.</li><li><code>voided</code>. The order was voided. No more authorizations/captures can be made against this order.</li></ul>
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue = false)]
        public string State;

        /// <summary>
        /// The date and time when the resource was last updated, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [DataMember(Name="update_time", EmitDefaultValue = false)]
        public string UpdateTime;
    }
}

