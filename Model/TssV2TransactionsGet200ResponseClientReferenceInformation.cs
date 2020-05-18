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
    /// TssV2TransactionsGet200ResponseClientReferenceInformation
    /// </summary>
    [DataContract]
    public partial class TssV2TransactionsGet200ResponseClientReferenceInformation :  IEquatable<TssV2TransactionsGet200ResponseClientReferenceInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TssV2TransactionsGet200ResponseClientReferenceInformation" /> class.
        /// </summary>
        /// <param name="Code">Merchant-generated order reference or tracking number. It is recommended that you send a unique value for each transaction so that you can perform meaningful searches for the transaction.  #### Used by **Authorization**\\ Required field.  #### FDC Nashville Global Certain circumstances can cause the processor to truncate this value to 15 or 17 characters for Level II and Level III processing, which can cause a discrepancy between the value you submit and the value included in some processor reports. .</param>
        /// <param name="ApplicationVersion">Version of the CyberSource application or integration used for a transaction. .</param>
        /// <param name="ApplicationName">The name of the Connection Method client (such as Virtual Terminal or SOAP Toolkit API) that the merchant uses to send a transaction request to CyberSource. .</param>
        /// <param name="ApplicationUser">The entity that is responsible for running the transaction and submitting the processing request to CyberSource. This could be a person, a system, or a connection method. .</param>
        /// <param name="Comments">Brief description of the order or any comment you wish to add to the order. .</param>
        public TssV2TransactionsGet200ResponseClientReferenceInformation(string Code = default(string), string ApplicationVersion = default(string), string ApplicationName = default(string), string ApplicationUser = default(string), string Comments = default(string))
        {
            this.Code = Code;
            this.ApplicationVersion = ApplicationVersion;
            this.ApplicationName = ApplicationName;
            this.ApplicationUser = ApplicationUser;
            this.Comments = Comments;
        }
        
        /// <summary>
        /// Merchant-generated order reference or tracking number. It is recommended that you send a unique value for each transaction so that you can perform meaningful searches for the transaction.  #### Used by **Authorization**\\ Required field.  #### FDC Nashville Global Certain circumstances can cause the processor to truncate this value to 15 or 17 characters for Level II and Level III processing, which can cause a discrepancy between the value you submit and the value included in some processor reports. 
        /// </summary>
        /// <value>Merchant-generated order reference or tracking number. It is recommended that you send a unique value for each transaction so that you can perform meaningful searches for the transaction.  #### Used by **Authorization**\\ Required field.  #### FDC Nashville Global Certain circumstances can cause the processor to truncate this value to 15 or 17 characters for Level II and Level III processing, which can cause a discrepancy between the value you submit and the value included in some processor reports. </value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Version of the CyberSource application or integration used for a transaction. 
        /// </summary>
        /// <value>Version of the CyberSource application or integration used for a transaction. </value>
        [DataMember(Name="applicationVersion", EmitDefaultValue=false)]
        public string ApplicationVersion { get; set; }

        /// <summary>
        /// The name of the Connection Method client (such as Virtual Terminal or SOAP Toolkit API) that the merchant uses to send a transaction request to CyberSource. 
        /// </summary>
        /// <value>The name of the Connection Method client (such as Virtual Terminal or SOAP Toolkit API) that the merchant uses to send a transaction request to CyberSource. </value>
        [DataMember(Name="applicationName", EmitDefaultValue=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// The entity that is responsible for running the transaction and submitting the processing request to CyberSource. This could be a person, a system, or a connection method. 
        /// </summary>
        /// <value>The entity that is responsible for running the transaction and submitting the processing request to CyberSource. This could be a person, a system, or a connection method. </value>
        [DataMember(Name="applicationUser", EmitDefaultValue=false)]
        public string ApplicationUser { get; set; }

        /// <summary>
        /// Brief description of the order or any comment you wish to add to the order. 
        /// </summary>
        /// <value>Brief description of the order or any comment you wish to add to the order. </value>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public string Comments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TssV2TransactionsGet200ResponseClientReferenceInformation {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  ApplicationVersion: ").Append(ApplicationVersion).Append("\n");
            sb.Append("  ApplicationName: ").Append(ApplicationName).Append("\n");
            sb.Append("  ApplicationUser: ").Append(ApplicationUser).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
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
            return this.Equals(obj as TssV2TransactionsGet200ResponseClientReferenceInformation);
        }

        /// <summary>
        /// Returns true if TssV2TransactionsGet200ResponseClientReferenceInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of TssV2TransactionsGet200ResponseClientReferenceInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TssV2TransactionsGet200ResponseClientReferenceInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this.ApplicationVersion == other.ApplicationVersion ||
                    this.ApplicationVersion != null &&
                    this.ApplicationVersion.Equals(other.ApplicationVersion)
                ) && 
                (
                    this.ApplicationName == other.ApplicationName ||
                    this.ApplicationName != null &&
                    this.ApplicationName.Equals(other.ApplicationName)
                ) && 
                (
                    this.ApplicationUser == other.ApplicationUser ||
                    this.ApplicationUser != null &&
                    this.ApplicationUser.Equals(other.ApplicationUser)
                ) && 
                (
                    this.Comments == other.Comments ||
                    this.Comments != null &&
                    this.Comments.Equals(other.Comments)
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
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                if (this.ApplicationVersion != null)
                    hash = hash * 59 + this.ApplicationVersion.GetHashCode();
                if (this.ApplicationName != null)
                    hash = hash * 59 + this.ApplicationName.GetHashCode();
                if (this.ApplicationUser != null)
                    hash = hash * 59 + this.ApplicationUser.GetHashCode();
                if (this.Comments != null)
                    hash = hash * 59 + this.Comments.GetHashCode();
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
            // Code (string) maxLength
            if(this.Code != null && this.Code.Length >= 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Code, length must be less than or equal to 50.", new [] { "Code" });
            }

            // Comments (string) maxLength
            if(this.Comments != null && this.Comments.Length >= 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Comments, length must be less than or equal to 255.", new [] { "Comments" });
            }

            yield break;
        }
    }

}
