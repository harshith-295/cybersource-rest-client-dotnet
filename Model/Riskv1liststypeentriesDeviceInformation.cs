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
    /// Riskv1liststypeentriesDeviceInformation
    /// </summary>
    [DataContract]
    public partial class Riskv1liststypeentriesDeviceInformation :  IEquatable<Riskv1liststypeentriesDeviceInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Riskv1liststypeentriesDeviceInformation" /> class.
        /// </summary>
        /// <param name="IpAddress">IP address of the customer.  #### Used by **Authorization, Capture, and Credit** Optional field. .</param>
        /// <param name="NetworkIpAddress">Network IP address of the customer (for example, 10.1.27). A network IP address includes up to 256 IP addresses. .</param>
        public Riskv1liststypeentriesDeviceInformation(string IpAddress = default(string), string NetworkIpAddress = default(string))
        {
            this.IpAddress = IpAddress;
            this.NetworkIpAddress = NetworkIpAddress;
        }
        
        /// <summary>
        /// IP address of the customer.  #### Used by **Authorization, Capture, and Credit** Optional field. 
        /// </summary>
        /// <value>IP address of the customer.  #### Used by **Authorization, Capture, and Credit** Optional field. </value>
        [DataMember(Name="ipAddress", EmitDefaultValue=false)]
        public string IpAddress { get; set; }

        /// <summary>
        /// Network IP address of the customer (for example, 10.1.27). A network IP address includes up to 256 IP addresses. 
        /// </summary>
        /// <value>Network IP address of the customer (for example, 10.1.27). A network IP address includes up to 256 IP addresses. </value>
        [DataMember(Name="networkIpAddress", EmitDefaultValue=false)]
        public string NetworkIpAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Riskv1liststypeentriesDeviceInformation {\n");
            sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  NetworkIpAddress: ").Append(NetworkIpAddress).Append("\n");
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
            return this.Equals(obj as Riskv1liststypeentriesDeviceInformation);
        }

        /// <summary>
        /// Returns true if Riskv1liststypeentriesDeviceInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Riskv1liststypeentriesDeviceInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Riskv1liststypeentriesDeviceInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IpAddress == other.IpAddress ||
                    this.IpAddress != null &&
                    this.IpAddress.Equals(other.IpAddress)
                ) && 
                (
                    this.NetworkIpAddress == other.NetworkIpAddress ||
                    this.NetworkIpAddress != null &&
                    this.NetworkIpAddress.Equals(other.NetworkIpAddress)
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
                if (this.IpAddress != null)
                    hash = hash * 59 + this.IpAddress.GetHashCode();
                if (this.NetworkIpAddress != null)
                    hash = hash * 59 + this.NetworkIpAddress.GetHashCode();
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
            // IpAddress (string) maxLength
            if(this.IpAddress != null && this.IpAddress.Length >= 48)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IpAddress, length must be less than or equal to 48.", new [] { "IpAddress" });
            }

            // NetworkIpAddress (string) maxLength
            if(this.NetworkIpAddress != null && this.NetworkIpAddress.Length >= 11)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NetworkIpAddress, length must be less than or equal to 11.", new [] { "NetworkIpAddress" });
            }

            yield break;
        }
    }

}
