/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = CyberSource.Client.SwaggerDateConverter;

namespace CyberSource.Model
{
    /// <summary>
    /// PtsV2PaymentsPost201ResponseTokenInformation
    /// </summary>
    [DataContract]
    public partial class PtsV2PaymentsPost201ResponseTokenInformation :  IEquatable<PtsV2PaymentsPost201ResponseTokenInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PtsV2PaymentsPost201ResponseTokenInformation" /> class.
        /// </summary>
        /// <param name="InstrumentidentifierNew">A value of true means the card number or bank account used to create an Instrument Identifier was new and did not already exist in the token vault. A value of false means the card number or bank account used to create an Instrument Identifier already existed in the token vault. .</param>
        /// <param name="Customer">Customer.</param>
        /// <param name="PaymentInstrument">PaymentInstrument.</param>
        /// <param name="ShippingAddress">ShippingAddress.</param>
        /// <param name="InstrumentIdentifier">InstrumentIdentifier.</param>
        public PtsV2PaymentsPost201ResponseTokenInformation(bool? InstrumentidentifierNew = default(bool?), PtsV2PaymentsPost201ResponseTokenInformationCustomer Customer = default(PtsV2PaymentsPost201ResponseTokenInformationCustomer), PtsV2PaymentsPost201ResponseTokenInformationPaymentInstrument PaymentInstrument = default(PtsV2PaymentsPost201ResponseTokenInformationPaymentInstrument), PtsV2PaymentsPost201ResponseTokenInformationShippingAddress ShippingAddress = default(PtsV2PaymentsPost201ResponseTokenInformationShippingAddress), PtsV2PaymentsPost201ResponseTokenInformationInstrumentIdentifier InstrumentIdentifier = default(PtsV2PaymentsPost201ResponseTokenInformationInstrumentIdentifier))
        {
            this.InstrumentidentifierNew = InstrumentidentifierNew;
            this.Customer = Customer;
            this.PaymentInstrument = PaymentInstrument;
            this.ShippingAddress = ShippingAddress;
            this.InstrumentIdentifier = InstrumentIdentifier;
        }
        
        /// <summary>
        /// A value of true means the card number or bank account used to create an Instrument Identifier was new and did not already exist in the token vault. A value of false means the card number or bank account used to create an Instrument Identifier already existed in the token vault. 
        /// </summary>
        /// <value>A value of true means the card number or bank account used to create an Instrument Identifier was new and did not already exist in the token vault. A value of false means the card number or bank account used to create an Instrument Identifier already existed in the token vault. </value>
        [DataMember(Name="instrumentidentifierNew", EmitDefaultValue=false)]
        public bool? InstrumentidentifierNew { get; set; }

        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name="customer", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponseTokenInformationCustomer Customer { get; set; }

        /// <summary>
        /// Gets or Sets PaymentInstrument
        /// </summary>
        [DataMember(Name="paymentInstrument", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponseTokenInformationPaymentInstrument PaymentInstrument { get; set; }

        /// <summary>
        /// Gets or Sets ShippingAddress
        /// </summary>
        [DataMember(Name="shippingAddress", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponseTokenInformationShippingAddress ShippingAddress { get; set; }

        /// <summary>
        /// Gets or Sets InstrumentIdentifier
        /// </summary>
        [DataMember(Name="instrumentIdentifier", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponseTokenInformationInstrumentIdentifier InstrumentIdentifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PtsV2PaymentsPost201ResponseTokenInformation {\n");
            sb.Append("  InstrumentidentifierNew: ").Append(InstrumentidentifierNew).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  PaymentInstrument: ").Append(PaymentInstrument).Append("\n");
            sb.Append("  ShippingAddress: ").Append(ShippingAddress).Append("\n");
            sb.Append("  InstrumentIdentifier: ").Append(InstrumentIdentifier).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as PtsV2PaymentsPost201ResponseTokenInformation);
        }

        /// <summary>
        /// Returns true if PtsV2PaymentsPost201ResponseTokenInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of PtsV2PaymentsPost201ResponseTokenInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PtsV2PaymentsPost201ResponseTokenInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.InstrumentidentifierNew == other.InstrumentidentifierNew ||
                    this.InstrumentidentifierNew != null &&
                    this.InstrumentidentifierNew.Equals(other.InstrumentidentifierNew)
                ) && 
                (
                    this.Customer == other.Customer ||
                    this.Customer != null &&
                    this.Customer.Equals(other.Customer)
                ) && 
                (
                    this.PaymentInstrument == other.PaymentInstrument ||
                    this.PaymentInstrument != null &&
                    this.PaymentInstrument.Equals(other.PaymentInstrument)
                ) && 
                (
                    this.ShippingAddress == other.ShippingAddress ||
                    this.ShippingAddress != null &&
                    this.ShippingAddress.Equals(other.ShippingAddress)
                ) && 
                (
                    this.InstrumentIdentifier == other.InstrumentIdentifier ||
                    this.InstrumentIdentifier != null &&
                    this.InstrumentIdentifier.Equals(other.InstrumentIdentifier)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.InstrumentidentifierNew != null)
                    hash = hash * 59 + this.InstrumentidentifierNew.GetHashCode();
                if (this.Customer != null)
                    hash = hash * 59 + this.Customer.GetHashCode();
                if (this.PaymentInstrument != null)
                    hash = hash * 59 + this.PaymentInstrument.GetHashCode();
                if (this.ShippingAddress != null)
                    hash = hash * 59 + this.ShippingAddress.GetHashCode();
                if (this.InstrumentIdentifier != null)
                    hash = hash * 59 + this.InstrumentIdentifier.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
