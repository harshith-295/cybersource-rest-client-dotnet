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
    /// Ptsv1pushfundstransferSenderInformationPaymentInformationCard
    /// </summary>
    [DataContract]
    public partial class Ptsv1pushfundstransferSenderInformationPaymentInformationCard :  IEquatable<Ptsv1pushfundstransferSenderInformationPaymentInformationCard>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv1pushfundstransferSenderInformationPaymentInformationCard" /> class.
        /// </summary>
        /// <param name="Type">Three-digit value that indicates the card type.  IMPORTANT It is strongly recommended that you include the card type field in request messages even if it is optional for your processor and card type. Omitting the card type can cause the transaction to be processed with the wrong card type.  Possible values:  - &#x60;001&#x60;: Visa. For card-present transactions on all processors except SIX, the Visa Electron card type is processed the same way that the Visa debit card is processed. Use card type value 001 for Visa Electron. - &#x60;002&#x60;: Mastercard, Eurocard[^1], which is a European regional brand of Mastercard. .</param>
        /// <param name="SecurityCode">3-digit value that indicates the card Cvv2Value. Values can be 0-9.  This field is supported in Mastercard Send. .</param>
        /// <param name="SourceAccountType">Flag that specifies the type of account associated with the card. The cardholder provides this information during the payment process.  Valid values for Visa Platform Connect: - &#x60;CHECKING&#x60;: Checking account - &#x60;CREDIT&#x60;: Credit card account - &#x60;SAVING&#x60;: Saving account - &#x60;LINE_OF_CREDIT&#x60;: Line of credit or credit portion of combo card - &#x60;PREPAID&#x60;: Prepaid card account or prepaid portion of combo card - &#x60;UNIVERSAL&#x60;: Universal account  Valid values for Mastercard Send: - &#x60;00&#x60;: Other, - &#x60;01&#x60;: RTN + Bank Account, - &#x60;02&#x60;: IBAN, - &#x60;03&#x60;: Card Account, - &#x60;04&#x60;: Email, - &#x60;05&#x60;: Phone Number, - &#x60;06&#x60;: Bank account number (BAN) + Bank Identification Сode (BIC), - &#x60;07&#x60;: Wallet ID, - &#x60;08&#x60;: Social Network ID. Numeric, 2 characters.  This field is supported in Mastercard Send. .</param>
        /// <param name="Number">The customer’s payment card number, also known as the Primary Account Number (PAN).  This field is supported in Mastercard Send. .</param>
        /// <param name="ExpirationMonth">Two-digit month in which the payment card expires.  Format: MM.  Valid values: 01 through 12. Leading 0 is required.  This field is supported for Mastercard Send. .</param>
        /// <param name="ExpirationYear">Four-digit year in which the payment card expires.  This field is supported for Mastercard Send. .</param>
        public Ptsv1pushfundstransferSenderInformationPaymentInformationCard(string Type = default(string), string SecurityCode = default(string), string SourceAccountType = default(string), string Number = default(string), string ExpirationMonth = default(string), string ExpirationYear = default(string))
        {
            this.Type = Type;
            this.SecurityCode = SecurityCode;
            this.SourceAccountType = SourceAccountType;
            this.Number = Number;
            this.ExpirationMonth = ExpirationMonth;
            this.ExpirationYear = ExpirationYear;
        }
        
        /// <summary>
        /// Three-digit value that indicates the card type.  IMPORTANT It is strongly recommended that you include the card type field in request messages even if it is optional for your processor and card type. Omitting the card type can cause the transaction to be processed with the wrong card type.  Possible values:  - &#x60;001&#x60;: Visa. For card-present transactions on all processors except SIX, the Visa Electron card type is processed the same way that the Visa debit card is processed. Use card type value 001 for Visa Electron. - &#x60;002&#x60;: Mastercard, Eurocard[^1], which is a European regional brand of Mastercard. 
        /// </summary>
        /// <value>Three-digit value that indicates the card type.  IMPORTANT It is strongly recommended that you include the card type field in request messages even if it is optional for your processor and card type. Omitting the card type can cause the transaction to be processed with the wrong card type.  Possible values:  - &#x60;001&#x60;: Visa. For card-present transactions on all processors except SIX, the Visa Electron card type is processed the same way that the Visa debit card is processed. Use card type value 001 for Visa Electron. - &#x60;002&#x60;: Mastercard, Eurocard[^1], which is a European regional brand of Mastercard. </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// 3-digit value that indicates the card Cvv2Value. Values can be 0-9.  This field is supported in Mastercard Send. 
        /// </summary>
        /// <value>3-digit value that indicates the card Cvv2Value. Values can be 0-9.  This field is supported in Mastercard Send. </value>
        [DataMember(Name="securityCode", EmitDefaultValue=false)]
        public string SecurityCode { get; set; }

        /// <summary>
        /// Flag that specifies the type of account associated with the card. The cardholder provides this information during the payment process.  Valid values for Visa Platform Connect: - &#x60;CHECKING&#x60;: Checking account - &#x60;CREDIT&#x60;: Credit card account - &#x60;SAVING&#x60;: Saving account - &#x60;LINE_OF_CREDIT&#x60;: Line of credit or credit portion of combo card - &#x60;PREPAID&#x60;: Prepaid card account or prepaid portion of combo card - &#x60;UNIVERSAL&#x60;: Universal account  Valid values for Mastercard Send: - &#x60;00&#x60;: Other, - &#x60;01&#x60;: RTN + Bank Account, - &#x60;02&#x60;: IBAN, - &#x60;03&#x60;: Card Account, - &#x60;04&#x60;: Email, - &#x60;05&#x60;: Phone Number, - &#x60;06&#x60;: Bank account number (BAN) + Bank Identification Сode (BIC), - &#x60;07&#x60;: Wallet ID, - &#x60;08&#x60;: Social Network ID. Numeric, 2 characters.  This field is supported in Mastercard Send. 
        /// </summary>
        /// <value>Flag that specifies the type of account associated with the card. The cardholder provides this information during the payment process.  Valid values for Visa Platform Connect: - &#x60;CHECKING&#x60;: Checking account - &#x60;CREDIT&#x60;: Credit card account - &#x60;SAVING&#x60;: Saving account - &#x60;LINE_OF_CREDIT&#x60;: Line of credit or credit portion of combo card - &#x60;PREPAID&#x60;: Prepaid card account or prepaid portion of combo card - &#x60;UNIVERSAL&#x60;: Universal account  Valid values for Mastercard Send: - &#x60;00&#x60;: Other, - &#x60;01&#x60;: RTN + Bank Account, - &#x60;02&#x60;: IBAN, - &#x60;03&#x60;: Card Account, - &#x60;04&#x60;: Email, - &#x60;05&#x60;: Phone Number, - &#x60;06&#x60;: Bank account number (BAN) + Bank Identification Сode (BIC), - &#x60;07&#x60;: Wallet ID, - &#x60;08&#x60;: Social Network ID. Numeric, 2 characters.  This field is supported in Mastercard Send. </value>
        [DataMember(Name="sourceAccountType", EmitDefaultValue=false)]
        public string SourceAccountType { get; set; }

        /// <summary>
        /// The customer’s payment card number, also known as the Primary Account Number (PAN).  This field is supported in Mastercard Send. 
        /// </summary>
        /// <value>The customer’s payment card number, also known as the Primary Account Number (PAN).  This field is supported in Mastercard Send. </value>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public string Number { get; set; }

        /// <summary>
        /// Two-digit month in which the payment card expires.  Format: MM.  Valid values: 01 through 12. Leading 0 is required.  This field is supported for Mastercard Send. 
        /// </summary>
        /// <value>Two-digit month in which the payment card expires.  Format: MM.  Valid values: 01 through 12. Leading 0 is required.  This field is supported for Mastercard Send. </value>
        [DataMember(Name="expirationMonth", EmitDefaultValue=false)]
        public string ExpirationMonth { get; set; }

        /// <summary>
        /// Four-digit year in which the payment card expires.  This field is supported for Mastercard Send. 
        /// </summary>
        /// <value>Four-digit year in which the payment card expires.  This field is supported for Mastercard Send. </value>
        [DataMember(Name="expirationYear", EmitDefaultValue=false)]
        public string ExpirationYear { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv1pushfundstransferSenderInformationPaymentInformationCard {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SecurityCode: ").Append(SecurityCode).Append("\n");
            sb.Append("  SourceAccountType: ").Append(SourceAccountType).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  ExpirationMonth: ").Append(ExpirationMonth).Append("\n");
            sb.Append("  ExpirationYear: ").Append(ExpirationYear).Append("\n");
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
            return this.Equals(obj as Ptsv1pushfundstransferSenderInformationPaymentInformationCard);
        }

        /// <summary>
        /// Returns true if Ptsv1pushfundstransferSenderInformationPaymentInformationCard instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv1pushfundstransferSenderInformationPaymentInformationCard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv1pushfundstransferSenderInformationPaymentInformationCard other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.SecurityCode == other.SecurityCode ||
                    this.SecurityCode != null &&
                    this.SecurityCode.Equals(other.SecurityCode)
                ) && 
                (
                    this.SourceAccountType == other.SourceAccountType ||
                    this.SourceAccountType != null &&
                    this.SourceAccountType.Equals(other.SourceAccountType)
                ) && 
                (
                    this.Number == other.Number ||
                    this.Number != null &&
                    this.Number.Equals(other.Number)
                ) && 
                (
                    this.ExpirationMonth == other.ExpirationMonth ||
                    this.ExpirationMonth != null &&
                    this.ExpirationMonth.Equals(other.ExpirationMonth)
                ) && 
                (
                    this.ExpirationYear == other.ExpirationYear ||
                    this.ExpirationYear != null &&
                    this.ExpirationYear.Equals(other.ExpirationYear)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.SecurityCode != null)
                    hash = hash * 59 + this.SecurityCode.GetHashCode();
                if (this.SourceAccountType != null)
                    hash = hash * 59 + this.SourceAccountType.GetHashCode();
                if (this.Number != null)
                    hash = hash * 59 + this.Number.GetHashCode();
                if (this.ExpirationMonth != null)
                    hash = hash * 59 + this.ExpirationMonth.GetHashCode();
                if (this.ExpirationYear != null)
                    hash = hash * 59 + this.ExpirationYear.GetHashCode();
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
