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
    /// ShippingAddress
    /// </summary>
    [DataContract]
    public partial class ShippingAddress :  IEquatable<ShippingAddress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingAddress" /> class.
        /// </summary>
        /// <param name="Links">Links.</param>
        /// <param name="Id">The id of the Shipping Address Token..</param>
        /// <param name="ShipTo">ShipTo.</param>
        /// <param name="Metadata">Metadata.</param>
        public ShippingAddress(Tmsv2customersEmbeddedDefaultShippingAddressLinks Links = default(Tmsv2customersEmbeddedDefaultShippingAddressLinks), string Id = default(string), Tmsv2customersEmbeddedDefaultShippingAddressShipTo ShipTo = default(Tmsv2customersEmbeddedDefaultShippingAddressShipTo), Tmsv2customersEmbeddedDefaultShippingAddressMetadata Metadata = default(Tmsv2customersEmbeddedDefaultShippingAddressMetadata))
        {
            this.Links = Links;
            this.Id = Id;
            this.ShipTo = ShipTo;
            this.Metadata = Metadata;
        }
        
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="_links", EmitDefaultValue=false)]
        public Tmsv2customersEmbeddedDefaultShippingAddressLinks Links { get; set; }

        /// <summary>
        /// The id of the Shipping Address Token.
        /// </summary>
        /// <value>The id of the Shipping Address Token.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ShipTo
        /// </summary>
        [DataMember(Name="shipTo", EmitDefaultValue=false)]
        public Tmsv2customersEmbeddedDefaultShippingAddressShipTo ShipTo { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Tmsv2customersEmbeddedDefaultShippingAddressMetadata Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShippingAddress {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ShipTo: ").Append(ShipTo).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(obj as ShippingAddress);
        }

        /// <summary>
        /// Returns true if ShippingAddress instances are equal
        /// </summary>
        /// <param name="other">Instance of ShippingAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShippingAddress other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.Equals(other.Links)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.ShipTo == other.ShipTo ||
                    this.ShipTo != null &&
                    this.ShipTo.Equals(other.ShipTo)
                ) && 
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
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
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.ShipTo != null)
                    hash = hash * 59 + this.ShipTo.GetHashCode();
                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();
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
            // Id (string) maxLength
            if(this.Id != null && this.Id.Length >= 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, length must be less than or equal to 32.", new [] { "Id" });
            }

            // Id (string) minLength
            if(this.Id != null && this.Id.Length <= 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, length must be greater than or equal to 1.", new [] { "Id" });
            }

            yield break;
        }
    }

}
