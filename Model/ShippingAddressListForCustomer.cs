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
    /// A paginated container of Shipping Addresses. 
    /// </summary>
    [DataContract]
    public partial class ShippingAddressListForCustomer :  IEquatable<ShippingAddressListForCustomer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingAddressListForCustomer" /> class.
        /// </summary>
        /// <param name="Links">Links.</param>
        /// <param name="Embedded">Embedded.</param>
        public ShippingAddressListForCustomer(ShippingAddressListForCustomerLinks Links = default(ShippingAddressListForCustomerLinks), ShippingAddressListForCustomerEmbedded Embedded = default(ShippingAddressListForCustomerEmbedded))
        {
            this.Links = Links;
            this.Embedded = Embedded;
        }
        
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="_links", EmitDefaultValue=false)]
        public ShippingAddressListForCustomerLinks Links { get; set; }

        /// <summary>
        /// The offset parameter supplied in the request.
        /// </summary>
        /// <value>The offset parameter supplied in the request.</value>
        [DataMember(Name="offset", EmitDefaultValue=false)]
        public int? Offset { get; private set; }

        /// <summary>
        /// The limit parameter supplied in the request.
        /// </summary>
        /// <value>The limit parameter supplied in the request.</value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int? Limit { get; private set; }

        /// <summary>
        /// The number of Shipping Addresses returned in the array.
        /// </summary>
        /// <value>The number of Shipping Addresses returned in the array.</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; private set; }

        /// <summary>
        /// The total number of Shipping Addresses associated with the Customer.
        /// </summary>
        /// <value>The total number of Shipping Addresses associated with the Customer.</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public int? Total { get; private set; }

        /// <summary>
        /// Gets or Sets Embedded
        /// </summary>
        [DataMember(Name="_embedded", EmitDefaultValue=false)]
        public ShippingAddressListForCustomerEmbedded Embedded { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShippingAddressListForCustomer {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Embedded: ").Append(Embedded).Append("\n");
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
            return this.Equals(obj as ShippingAddressListForCustomer);
        }

        /// <summary>
        /// Returns true if ShippingAddressListForCustomer instances are equal
        /// </summary>
        /// <param name="other">Instance of ShippingAddressListForCustomer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShippingAddressListForCustomer other)
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
                    this.Offset == other.Offset ||
                    this.Offset != null &&
                    this.Offset.Equals(other.Offset)
                ) && 
                (
                    this.Limit == other.Limit ||
                    this.Limit != null &&
                    this.Limit.Equals(other.Limit)
                ) && 
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
                ) && 
                (
                    this.Total == other.Total ||
                    this.Total != null &&
                    this.Total.Equals(other.Total)
                ) && 
                (
                    this.Embedded == other.Embedded ||
                    this.Embedded != null &&
                    this.Embedded.Equals(other.Embedded)
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
                if (this.Offset != null)
                    hash = hash * 59 + this.Offset.GetHashCode();
                if (this.Limit != null)
                    hash = hash * 59 + this.Limit.GetHashCode();
                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();
                if (this.Total != null)
                    hash = hash * 59 + this.Total.GetHashCode();
                if (this.Embedded != null)
                    hash = hash * 59 + this.Embedded.GetHashCode();
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
