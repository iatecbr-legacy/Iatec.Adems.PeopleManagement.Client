/*
 * People Management API - BRA
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 0.2.1
 *
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Iatec.Adems.PeopleManagement.Client.Model
{
    /// <summary>
    /// CountryPhoneCodeModel
    /// </summary>
    [DataContract]
    public partial class CountryPhoneCodeModel : IEquatable<CountryPhoneCodeModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CountryPhoneCodeModel" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Abbreviation">Abbreviation.</param>
        /// <param name="Code">Code.</param>
        /// <param name="InternationalCodePhone">InternationalCodePhone.</param>
        /// <param name="Name">Name.</param>
        public CountryPhoneCodeModel(Guid Id = default(Guid), string Abbreviation = default(string), string Code = default(string), string InternationalCodePhone = default(string), 
            string Name = default(string))
        {
            this.Id = Id;
            this.Abbreviation = Abbreviation;
            this.Code = Code;
            this.InternationalCodePhone = InternationalCodePhone;
            this.Name = Name;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Abbreviation
        /// </summary>
        [DataMember(Name = "abbreviation", EmitDefaultValue = false)]
        public string Abbreviation { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets InternationalCodePhone
        /// </summary>
        [DataMember(Name = "internationalCodePhone", EmitDefaultValue = false)]
        public string InternationalCodePhone { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CountryPhoneCodeModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Abbreviation: ").Append(Abbreviation).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  InternationalCodePhone: ").Append(InternationalCodePhone).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CountryPhoneCodeModel);
        }

        /// <summary>
        /// Returns true if CountryPhoneCodeModel instances are equal
        /// </summary>
        /// <param name="input">Instance of CountryPhoneCodeModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CountryPhoneCodeModel input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Id == input.Id ||
                    (this.Id != default(Guid) &&
                    this.Id.Equals(input.Id))
                ) &&
                (
                    this.Abbreviation == input.Abbreviation ||
                    (this.Abbreviation != null &&
                    this.Abbreviation.Equals(input.Abbreviation))
                ) &&
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) &&
                (
                    this.InternationalCodePhone == input.InternationalCodePhone ||
                    (this.InternationalCodePhone != null &&
                    this.InternationalCodePhone.Equals(input.InternationalCodePhone))
                ) &&
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Id != default(Guid))
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Abbreviation != null)
                    hashCode = hashCode * 59 + this.Abbreviation.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.InternationalCodePhone != null)
                    hashCode = hashCode * 59 + this.InternationalCodePhone.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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