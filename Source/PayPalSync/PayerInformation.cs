// This class was generated on Thu, 25 Jan 2018 15:50:03 CST by version 0.1.0-dev+27d306 of Braintree SDK Generator
// PayerInformation.cs
// @version 0.1.0-dev+27d306
// @type object
// @data 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
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace PayPal.PayPalSync
{
    /// <summary>
    /// The payer information.
    /// </summary>
    [DataContract]
    public class PayerInformation
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public PayerInformation() {}

        /// <summary>
        /// The PayPal` customer account ID.
        /// </summary>
        [DataMember(Name="account_id", EmitDefaultValue = false)]
        public string AccountId;

        /// <summary>
        /// A simple postal address with coarse-grained fields. Do not use for an international address. Use for backward compatibility only. Does not contain phone.
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue = false)]
        public SimplePostalAddress Address;

        /// <summary>
        /// The address status of the payer. Value is either:<ul><li><code>Y</code>. Verified.</li><li><code>N</code>. Not verified.</li></ul>
        /// </summary>
        [DataMember(Name="address_status", EmitDefaultValue = false)]
        public string AddressStatus;

        /// <summary>
        /// The [two-character ISO 3166-1 code](/docs/integration/direct/rest/country-codes/) that identifies the country or region.<blockquote><strong>Note:</strong> The country code for Great Britain is <code>GB</code> and not <code>UK</code> as used in the top-level domain names for that country. Use the `C2` country code for China worldwide for comparable uncontrolled price (CUP) method, bank card, and cross-border transactions.</blockquote>
        /// </summary>
        [DataMember(Name="country_code", EmitDefaultValue = false)]
        public string CountryCode;

        /// <summary>
        /// The internationalized email address.<blockquote><strong>Note:</strong> Up to 64 characters are allowed before and 255 characters are allowed after the <code>@</code> sign. However, the generally accepted maximum length for an email address is 254 characters. The pattern verifies that an unquoted <code>@</code> sign exists.</blockquote>
        /// </summary>
        [DataMember(Name="email_address", EmitDefaultValue = false)]
        public string EmailAddress;

        /// <summary>
        /// The name of the party.
        /// </summary>
        [DataMember(Name="payer_name", EmitDefaultValue = false)]
        public Name PayerName;

        /// <summary>
        /// The status of the payer. Value is `Verified` or `Unverified`.
        /// </summary>
        [DataMember(Name="payer_status", EmitDefaultValue = false)]
        public string PayerStatus;

        /// <summary>
        /// The phone number, in its canonical international [E.164 numbering plan format](https://www.itu.int/rec/T-REC-E.164/en).
        /// </summary>
        [DataMember(Name="phone_number", EmitDefaultValue = false)]
        public Phone PhoneNumber;
    }
}

