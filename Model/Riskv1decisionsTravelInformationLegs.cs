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
    /// Riskv1decisionsTravelInformationLegs
    /// </summary>
    [DataContract]
    public partial class Riskv1decisionsTravelInformationLegs :  IEquatable<Riskv1decisionsTravelInformationLegs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Riskv1decisionsTravelInformationLegs" /> class.
        /// </summary>
        /// <param name="Origination">Use to specify the airport code for the origin of the leg of the trip, which is designated by the pound (#) symbol in the field name. This code is usually three digits long, for example: SFO &#x3D; San Francisco. Do not use the colon (:) or the dash (-). For airport codes, see the IATA Airline and Airport Code Search. The leg number can be a positive integer from 0 to N. For example: &#x60;travelInformation.legs.0.origination&#x3D;SFO&#x60; &#x60;travelInformation.legs.1.origination&#x3D;SFO&#x60;  **Note** In your request, send either the complete route or the individual legs (&#x60;legs.0.origination&#x60; and &#x60;legs.n.destination&#x60;). If you send all the fields, the complete route takes precedence over the individual legs.  For details, see the &#x60;decision_manager_travel_leg#_orig&#x60; field description in _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). .</param>
        /// <param name="Destination">Use to specify the airport code for the destination of the leg of the trip, which is designated by the pound (#) symbol in the field name. This code is usually three digits long, for example: SFO &#x3D; San Francisco. Do not use the colon (:) or the dash (-). For airport codes, see [IATA Airline and Airport Code Search](https://www.iata.org/publications/Pages/code-search.aspx). The leg number can be a positive integer from 0 to N. For example:  &#x60;travelInformation.legs.0.destination&#x3D;SFO&#x60; &#x60;travelInformation.legs.1.destination&#x3D;SFO&#x60;  **Note** In your request, send either the complete route or the individual legs (&#x60;legs.0.origination&#x60; and &#x60;legs.n.destination&#x60;). If you send all the fields, the complete route takes precedence over the individual legs.  For details, see the &#x60;decision_manager_travel_leg#_dest&#x60; field description in _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). .</param>
        /// <param name="CarrierCode">International Air Transport Association (IATA) code for the carrier for this leg of the trip. Required for each leg. Required for American Express SafeKey (U.S.) for travel-related requests. .</param>
        /// <param name="DepartureDate">Departure date for the first leg of the trip. Format: YYYYMMDD. Required for American Express SafeKey (U.S.) for travel-related requests. .</param>
        public Riskv1decisionsTravelInformationLegs(string Origination = default(string), string Destination = default(string), string CarrierCode = default(string), string DepartureDate = default(string))
        {
            this.Origination = Origination;
            this.Destination = Destination;
            this.CarrierCode = CarrierCode;
            this.DepartureDate = DepartureDate;
        }
        
        /// <summary>
        /// Use to specify the airport code for the origin of the leg of the trip, which is designated by the pound (#) symbol in the field name. This code is usually three digits long, for example: SFO &#x3D; San Francisco. Do not use the colon (:) or the dash (-). For airport codes, see the IATA Airline and Airport Code Search. The leg number can be a positive integer from 0 to N. For example: &#x60;travelInformation.legs.0.origination&#x3D;SFO&#x60; &#x60;travelInformation.legs.1.origination&#x3D;SFO&#x60;  **Note** In your request, send either the complete route or the individual legs (&#x60;legs.0.origination&#x60; and &#x60;legs.n.destination&#x60;). If you send all the fields, the complete route takes precedence over the individual legs.  For details, see the &#x60;decision_manager_travel_leg#_orig&#x60; field description in _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). 
        /// </summary>
        /// <value>Use to specify the airport code for the origin of the leg of the trip, which is designated by the pound (#) symbol in the field name. This code is usually three digits long, for example: SFO &#x3D; San Francisco. Do not use the colon (:) or the dash (-). For airport codes, see the IATA Airline and Airport Code Search. The leg number can be a positive integer from 0 to N. For example: &#x60;travelInformation.legs.0.origination&#x3D;SFO&#x60; &#x60;travelInformation.legs.1.origination&#x3D;SFO&#x60;  **Note** In your request, send either the complete route or the individual legs (&#x60;legs.0.origination&#x60; and &#x60;legs.n.destination&#x60;). If you send all the fields, the complete route takes precedence over the individual legs.  For details, see the &#x60;decision_manager_travel_leg#_orig&#x60; field description in _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). </value>
        [DataMember(Name="origination", EmitDefaultValue=false)]
        public string Origination { get; set; }

        /// <summary>
        /// Use to specify the airport code for the destination of the leg of the trip, which is designated by the pound (#) symbol in the field name. This code is usually three digits long, for example: SFO &#x3D; San Francisco. Do not use the colon (:) or the dash (-). For airport codes, see [IATA Airline and Airport Code Search](https://www.iata.org/publications/Pages/code-search.aspx). The leg number can be a positive integer from 0 to N. For example:  &#x60;travelInformation.legs.0.destination&#x3D;SFO&#x60; &#x60;travelInformation.legs.1.destination&#x3D;SFO&#x60;  **Note** In your request, send either the complete route or the individual legs (&#x60;legs.0.origination&#x60; and &#x60;legs.n.destination&#x60;). If you send all the fields, the complete route takes precedence over the individual legs.  For details, see the &#x60;decision_manager_travel_leg#_dest&#x60; field description in _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). 
        /// </summary>
        /// <value>Use to specify the airport code for the destination of the leg of the trip, which is designated by the pound (#) symbol in the field name. This code is usually three digits long, for example: SFO &#x3D; San Francisco. Do not use the colon (:) or the dash (-). For airport codes, see [IATA Airline and Airport Code Search](https://www.iata.org/publications/Pages/code-search.aspx). The leg number can be a positive integer from 0 to N. For example:  &#x60;travelInformation.legs.0.destination&#x3D;SFO&#x60; &#x60;travelInformation.legs.1.destination&#x3D;SFO&#x60;  **Note** In your request, send either the complete route or the individual legs (&#x60;legs.0.origination&#x60; and &#x60;legs.n.destination&#x60;). If you send all the fields, the complete route takes precedence over the individual legs.  For details, see the &#x60;decision_manager_travel_leg#_dest&#x60; field description in _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link). </value>
        [DataMember(Name="destination", EmitDefaultValue=false)]
        public string Destination { get; set; }

        /// <summary>
        /// International Air Transport Association (IATA) code for the carrier for this leg of the trip. Required for each leg. Required for American Express SafeKey (U.S.) for travel-related requests. 
        /// </summary>
        /// <value>International Air Transport Association (IATA) code for the carrier for this leg of the trip. Required for each leg. Required for American Express SafeKey (U.S.) for travel-related requests. </value>
        [DataMember(Name="carrierCode", EmitDefaultValue=false)]
        public string CarrierCode { get; set; }

        /// <summary>
        /// Departure date for the first leg of the trip. Format: YYYYMMDD. Required for American Express SafeKey (U.S.) for travel-related requests. 
        /// </summary>
        /// <value>Departure date for the first leg of the trip. Format: YYYYMMDD. Required for American Express SafeKey (U.S.) for travel-related requests. </value>
        [DataMember(Name="departureDate", EmitDefaultValue=false)]
        public string DepartureDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Riskv1decisionsTravelInformationLegs {\n");
            sb.Append("  Origination: ").Append(Origination).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  CarrierCode: ").Append(CarrierCode).Append("\n");
            sb.Append("  DepartureDate: ").Append(DepartureDate).Append("\n");
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
            return this.Equals(obj as Riskv1decisionsTravelInformationLegs);
        }

        /// <summary>
        /// Returns true if Riskv1decisionsTravelInformationLegs instances are equal
        /// </summary>
        /// <param name="other">Instance of Riskv1decisionsTravelInformationLegs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Riskv1decisionsTravelInformationLegs other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Origination == other.Origination ||
                    this.Origination != null &&
                    this.Origination.Equals(other.Origination)
                ) && 
                (
                    this.Destination == other.Destination ||
                    this.Destination != null &&
                    this.Destination.Equals(other.Destination)
                ) && 
                (
                    this.CarrierCode == other.CarrierCode ||
                    this.CarrierCode != null &&
                    this.CarrierCode.Equals(other.CarrierCode)
                ) && 
                (
                    this.DepartureDate == other.DepartureDate ||
                    this.DepartureDate != null &&
                    this.DepartureDate.Equals(other.DepartureDate)
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
                if (this.Origination != null)
                    hash = hash * 59 + this.Origination.GetHashCode();
                if (this.Destination != null)
                    hash = hash * 59 + this.Destination.GetHashCode();
                if (this.CarrierCode != null)
                    hash = hash * 59 + this.CarrierCode.GetHashCode();
                if (this.DepartureDate != null)
                    hash = hash * 59 + this.DepartureDate.GetHashCode();
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
            // Origination (string) maxLength
            if(this.Origination != null && this.Origination.Length >= 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Origination, length must be less than or equal to 3.", new [] { "Origination" });
            }

            // Destination (string) maxLength
            if(this.Destination != null && this.Destination.Length >= 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Destination, length must be less than or equal to 3.", new [] { "Destination" });
            }

            // CarrierCode (string) maxLength
            if(this.CarrierCode != null && this.CarrierCode.Length >= 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CarrierCode, length must be less than or equal to 2.", new [] { "CarrierCode" });
            }

            yield break;
        }
    }

}
