/* 
 * IIMMPACT API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2020-09-14T13:01:14Z
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
using SwaggerDateConverter = iimmpact.Client.SwaggerDateConverter;

namespace iimmpact.Model
{
    /// <summary>
    /// DrivingLicenseResponeInner
    /// </summary>
    [DataContract]
    public partial class DrivingLicenseResponeInner :  IEquatable<DrivingLicenseResponeInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DrivingLicenseResponeInner" /> class.
        /// </summary>
        /// <param name="typeOfDrivingLicense">typeOfDrivingLicense.</param>
        /// <param name="dateOfCommencement">dateOfCommencement.</param>
        /// <param name="expiryDate">expiryDate.</param>
        public DrivingLicenseResponeInner(string typeOfDrivingLicense = default(string), string dateOfCommencement = default(string), string expiryDate = default(string))
        {
            this.TypeOfDrivingLicense = typeOfDrivingLicense;
            this.DateOfCommencement = dateOfCommencement;
            this.ExpiryDate = expiryDate;
        }
        
        /// <summary>
        /// Gets or Sets TypeOfDrivingLicense
        /// </summary>
        [DataMember(Name="Type of Driving License", EmitDefaultValue=false)]
        public string TypeOfDrivingLicense { get; set; }

        /// <summary>
        /// Gets or Sets DateOfCommencement
        /// </summary>
        [DataMember(Name="Date of Commencement", EmitDefaultValue=false)]
        public string DateOfCommencement { get; set; }

        /// <summary>
        /// Gets or Sets ExpiryDate
        /// </summary>
        [DataMember(Name="Expiry Date", EmitDefaultValue=false)]
        public string ExpiryDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DrivingLicenseResponeInner {\n");
            sb.Append("  TypeOfDrivingLicense: ").Append(TypeOfDrivingLicense).Append("\n");
            sb.Append("  DateOfCommencement: ").Append(DateOfCommencement).Append("\n");
            sb.Append("  ExpiryDate: ").Append(ExpiryDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DrivingLicenseResponeInner);
        }

        /// <summary>
        /// Returns true if DrivingLicenseResponeInner instances are equal
        /// </summary>
        /// <param name="input">Instance of DrivingLicenseResponeInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DrivingLicenseResponeInner input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TypeOfDrivingLicense == input.TypeOfDrivingLicense ||
                    (this.TypeOfDrivingLicense != null &&
                    this.TypeOfDrivingLicense.Equals(input.TypeOfDrivingLicense))
                ) && 
                (
                    this.DateOfCommencement == input.DateOfCommencement ||
                    (this.DateOfCommencement != null &&
                    this.DateOfCommencement.Equals(input.DateOfCommencement))
                ) && 
                (
                    this.ExpiryDate == input.ExpiryDate ||
                    (this.ExpiryDate != null &&
                    this.ExpiryDate.Equals(input.ExpiryDate))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.TypeOfDrivingLicense != null)
                    hashCode = hashCode * 59 + this.TypeOfDrivingLicense.GetHashCode();
                if (this.DateOfCommencement != null)
                    hashCode = hashCode * 59 + this.DateOfCommencement.GetHashCode();
                if (this.ExpiryDate != null)
                    hashCode = hashCode * 59 + this.ExpiryDate.GetHashCode();
                return hashCode;
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