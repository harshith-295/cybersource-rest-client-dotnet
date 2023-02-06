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
    /// PushFunds201ResponseProcessorInformation
    /// </summary>
    [DataContract]
    public partial class PushFunds201ResponseProcessorInformation :  IEquatable<PushFunds201ResponseProcessorInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PushFunds201ResponseProcessorInformation" /> class.
        /// </summary>
        /// <param name="TransactionId">Network transaction identifier (TID). This value can be used to identify a specific transaction when you are discussing the transaction with your processor. .</param>
        /// <param name="ResponseCode">Transaction status from the processor. .</param>
        /// <param name="ApprovalCode">Issuer-generated approval code for the transaction. .</param>
        /// <param name="SystemTraceAuditNumber">System audit number. Returned by authorization and incremental authorization services.  Visa Platform Connect  System trace number that must be printed on the customer’s receipt. .</param>
        /// <param name="ResponseCodeSource">Used by Visa only and contains the response source/reason code that identifies the source of the response decision. .</param>
        /// <param name="RetrievalReferenceNumber">Unique reference number returned by the processor that identifies the transaction at the network.  Supported by Mastercard Send .</param>
        public PushFunds201ResponseProcessorInformation(int? TransactionId = default(int?), string ResponseCode = default(string), string ApprovalCode = default(string), string SystemTraceAuditNumber = default(string), string ResponseCodeSource = default(string), string RetrievalReferenceNumber = default(string))
        {
            this.TransactionId = TransactionId;
            this.ResponseCode = ResponseCode;
            this.ApprovalCode = ApprovalCode;
            this.SystemTraceAuditNumber = SystemTraceAuditNumber;
            this.ResponseCodeSource = ResponseCodeSource;
            this.RetrievalReferenceNumber = RetrievalReferenceNumber;
        }
        
        /// <summary>
        /// Network transaction identifier (TID). This value can be used to identify a specific transaction when you are discussing the transaction with your processor. 
        /// </summary>
        /// <value>Network transaction identifier (TID). This value can be used to identify a specific transaction when you are discussing the transaction with your processor. </value>
        [DataMember(Name="transactionId", EmitDefaultValue=false)]
        public int? TransactionId { get; set; }

        /// <summary>
        /// Transaction status from the processor. 
        /// </summary>
        /// <value>Transaction status from the processor. </value>
        [DataMember(Name="responseCode", EmitDefaultValue=false)]
        public string ResponseCode { get; set; }

        /// <summary>
        /// Issuer-generated approval code for the transaction. 
        /// </summary>
        /// <value>Issuer-generated approval code for the transaction. </value>
        [DataMember(Name="approvalCode", EmitDefaultValue=false)]
        public string ApprovalCode { get; set; }

        /// <summary>
        /// System audit number. Returned by authorization and incremental authorization services.  Visa Platform Connect  System trace number that must be printed on the customer’s receipt. 
        /// </summary>
        /// <value>System audit number. Returned by authorization and incremental authorization services.  Visa Platform Connect  System trace number that must be printed on the customer’s receipt. </value>
        [DataMember(Name="systemTraceAuditNumber", EmitDefaultValue=false)]
        public string SystemTraceAuditNumber { get; set; }

        /// <summary>
        /// Used by Visa only and contains the response source/reason code that identifies the source of the response decision. 
        /// </summary>
        /// <value>Used by Visa only and contains the response source/reason code that identifies the source of the response decision. </value>
        [DataMember(Name="responseCodeSource", EmitDefaultValue=false)]
        public string ResponseCodeSource { get; set; }

        /// <summary>
        /// Unique reference number returned by the processor that identifies the transaction at the network.  Supported by Mastercard Send 
        /// </summary>
        /// <value>Unique reference number returned by the processor that identifies the transaction at the network.  Supported by Mastercard Send </value>
        [DataMember(Name="retrievalReferenceNumber", EmitDefaultValue=false)]
        public string RetrievalReferenceNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PushFunds201ResponseProcessorInformation {\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  ResponseCode: ").Append(ResponseCode).Append("\n");
            sb.Append("  ApprovalCode: ").Append(ApprovalCode).Append("\n");
            sb.Append("  SystemTraceAuditNumber: ").Append(SystemTraceAuditNumber).Append("\n");
            sb.Append("  ResponseCodeSource: ").Append(ResponseCodeSource).Append("\n");
            sb.Append("  RetrievalReferenceNumber: ").Append(RetrievalReferenceNumber).Append("\n");
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
            return this.Equals(obj as PushFunds201ResponseProcessorInformation);
        }

        /// <summary>
        /// Returns true if PushFunds201ResponseProcessorInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of PushFunds201ResponseProcessorInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PushFunds201ResponseProcessorInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TransactionId == other.TransactionId ||
                    this.TransactionId != null &&
                    this.TransactionId.Equals(other.TransactionId)
                ) && 
                (
                    this.ResponseCode == other.ResponseCode ||
                    this.ResponseCode != null &&
                    this.ResponseCode.Equals(other.ResponseCode)
                ) && 
                (
                    this.ApprovalCode == other.ApprovalCode ||
                    this.ApprovalCode != null &&
                    this.ApprovalCode.Equals(other.ApprovalCode)
                ) && 
                (
                    this.SystemTraceAuditNumber == other.SystemTraceAuditNumber ||
                    this.SystemTraceAuditNumber != null &&
                    this.SystemTraceAuditNumber.Equals(other.SystemTraceAuditNumber)
                ) && 
                (
                    this.ResponseCodeSource == other.ResponseCodeSource ||
                    this.ResponseCodeSource != null &&
                    this.ResponseCodeSource.Equals(other.ResponseCodeSource)
                ) && 
                (
                    this.RetrievalReferenceNumber == other.RetrievalReferenceNumber ||
                    this.RetrievalReferenceNumber != null &&
                    this.RetrievalReferenceNumber.Equals(other.RetrievalReferenceNumber)
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
                if (this.TransactionId != null)
                    hash = hash * 59 + this.TransactionId.GetHashCode();
                if (this.ResponseCode != null)
                    hash = hash * 59 + this.ResponseCode.GetHashCode();
                if (this.ApprovalCode != null)
                    hash = hash * 59 + this.ApprovalCode.GetHashCode();
                if (this.SystemTraceAuditNumber != null)
                    hash = hash * 59 + this.SystemTraceAuditNumber.GetHashCode();
                if (this.ResponseCodeSource != null)
                    hash = hash * 59 + this.ResponseCodeSource.GetHashCode();
                if (this.RetrievalReferenceNumber != null)
                    hash = hash * 59 + this.RetrievalReferenceNumber.GetHashCode();
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
