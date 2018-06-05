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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Iatec.Adems.PeopleManagement.Client.Model
{
    /// <summary>
    /// NaturalPersonLiteExternalModel
    /// </summary>
    [DataContract]
    public partial class NaturalPersonLiteExternalModel : IEquatable<NaturalPersonLiteExternalModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NaturalPersonLiteExternalModel" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="AuthenticationUserName">AuthenticationUserName.</param>
        /// <param name="MotherName">MotherName.</param>
        /// <param name="SocialName">SocialName.</param>
        /// <param name="BaptismDate">BaptismDate.</param>
        /// <param name="BirthCity">BirthCity.</param>
        /// <param name="BirthCountry">BirthCountry.</param>
        /// <param name="BirthDate">BirthDate.</param>
        /// <param name="BloodType">BloodType.</param>
        /// <param name="DeceaseDate">DeceaseDate.</param>
        /// <param name="Ethnicity">Ethnicity.</param>
        /// <param name="FirstName">FirstName.</param>
        /// <param name="FullName">FullName.</param>
        /// <param name="Gender">Gender.</param>
        /// <param name="IdentifierDocumentNumber">IdentifierDocumentNumber.</param>
        /// <param name="LastName">LastName.</param>
        /// <param name="LastUpdate">LastUpdate.</param>
        /// <param name="MaritalStatus">MaritalStatus.</param>
        /// <param name="MiddleName">MiddleName.</param>
        /// <param name="Parent01">Parent01.</param>
        /// <param name="Parent02">Parent02.</param>
        /// <param name="NaturalPersonNationality">NaturalPersonNationality.</param>
        /// <param name="NewIdentity">NewIdentity.</param>
        /// <param name="Occupation">Occupation.</param>
        /// <param name="Photo">Photo.</param>
        /// <param name="Religion">Religion.</param>
        /// <param name="Spouse">Spouse.</param>
        /// <param name="Scholarity">Scholarity.</param>
        public NaturalPersonLiteExternalModel(Guid Id = default(Guid), string AuthenticationUserName = default(string), string MotherName = default(string), string SocialName = default(string),
            DateTime? BaptismDate = default(DateTime?), LocalityLiteSearchModel BirthCity = default(LocalityLiteSearchModel), CountryLiteSearchModel BirthCountry = default(CountryLiteSearchModel),
            DateTime BirthDate = default(DateTime), BloodTypeModel BloodType = default(BloodTypeModel), DateTime? DeceaseDate = default(DateTime?), EthnicityModel Ethnicity = default(EthnicityModel), 
            string FirstName = default(string), string FullName = default(string), GenderModel Gender = default(GenderModel), string IdentifierDocumentNumber = default(string), 
            string LastName = default(string), DateTime LastUpdate = default(DateTime), MaritalStatusModel MaritalStatus = default(MaritalStatusModel), string MiddleName = default(string),
            NaturalPersonRelationshipLiteModel Parent01 = default(NaturalPersonRelationshipLiteModel), NaturalPersonRelationshipLiteModel Parent02 = default(NaturalPersonRelationshipLiteModel),
            List<CountryLiteSearchModel> NaturalPersonNationality = default(List<CountryLiteSearchModel>), Guid? NewIdentity = default(Guid?), OccupationModel Occupation = default(OccupationModel),
            Guid? Photo = default(Guid?), ReligionModel Religion = default(ReligionModel), NaturalPersonRelationshipLiteModel Spouse = default(NaturalPersonRelationshipLiteModel),
            ScholarityModel Scholarity = default(ScholarityModel))
        {
            this.Id = Id;
            this.AuthenticationUserName = AuthenticationUserName;
            this.MotherName = MotherName;
            this.SocialName = SocialName;
            this.BaptismDate = BaptismDate;
            this.BirthCity = BirthCity;
            this.BirthCountry = BirthCountry;
            this.BirthDate = BirthDate;
            this.BloodType = BloodType;
            this.DeceaseDate = DeceaseDate;
            this.Ethnicity = Ethnicity;
            this.FirstName = FirstName;
            this.FullName = FullName;
            this.Gender = Gender;
            this.IdentifierDocumentNumber = IdentifierDocumentNumber;
            this.LastName = LastName;
            this.LastUpdate = LastUpdate;
            this.MaritalStatus = MaritalStatus;
            this.MiddleName = MiddleName;
            this.Parent01 = Parent01;
            this.Parent02 = Parent02;
            this.NaturalPersonNationality = NaturalPersonNationality;
            this.NewIdentity = NewIdentity;
            this.Occupation = Occupation;
            this.Photo = Photo;
            this.Religion = Religion;
            this.Spouse = Spouse;
            this.Scholarity = Scholarity;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets AuthenticationUserName
        /// </summary>
        [DataMember(Name = "authenticationUserName", EmitDefaultValue = false)]
        public string AuthenticationUserName { get; set; }

        /// <summary>
        /// Gets or Sets MotherName
        /// </summary>
        [DataMember(Name = "motherName", EmitDefaultValue = false)]
        public string MotherName { get; set; }

        /// <summary>
        /// Gets or Sets SocialName
        /// </summary>
        [DataMember(Name = "socialName", EmitDefaultValue = false)]
        public string SocialName { get; set; }

        /// <summary>
        /// Gets or Sets BaptismDate
        /// </summary>
        [DataMember(Name = "baptismDate", EmitDefaultValue = false)]
        public DateTime? BaptismDate { get; set; }

        /// <summary>
        /// Gets or Sets BirthCity
        /// </summary>
        [DataMember(Name = "birthCity", EmitDefaultValue = false)]
        public LocalityLiteSearchModel BirthCity { get; set; }

        /// <summary>
        /// Gets or Sets BirthCountry
        /// </summary>
        [DataMember(Name = "birthCountry", EmitDefaultValue = false)]
        public CountryLiteSearchModel BirthCountry { get; set; }

        /// <summary>
        /// Gets or Sets BirthDate
        /// </summary>
        [DataMember(Name = "birthDate", EmitDefaultValue = false)]
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Gets or Sets BloodType
        /// </summary>
        [DataMember(Name = "bloodType", EmitDefaultValue = false)]
        public BloodTypeModel BloodType { get; set; }

        /// <summary>
        /// Gets or Sets DeceaseDate
        /// </summary>
        [DataMember(Name = "deceaseDate", EmitDefaultValue = false)]
        public DateTime? DeceaseDate { get; set; }

        /// <summary>
        /// Gets or Sets Ethnicity
        /// </summary>
        [DataMember(Name = "ethnicity", EmitDefaultValue = false)]
        public EthnicityModel Ethnicity { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name = "firstName", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets FullName
        /// </summary>
        [DataMember(Name = "fullName", EmitDefaultValue = false)]
        public string FullName { get; set; }

        /// <summary>
        /// Gets or Sets Gender
        /// </summary>
        [DataMember(Name = "gender", EmitDefaultValue = false)]
        public GenderModel Gender { get; set; }

        /// <summary>
        /// Gets or Sets IdentifierDocumentNumber
        /// </summary>
        [DataMember(Name = "identifierDocumentNumber", EmitDefaultValue = false)]
        public string IdentifierDocumentNumber { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name = "lastName", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets LastUpdate
        /// </summary>
        [DataMember(Name = "lastUpdate", EmitDefaultValue = false)]
        public DateTime LastUpdate { get; set; }

        /// <summary>
        /// Gets or Sets MaritalStatus
        /// </summary>
        [DataMember(Name = "maritalStatus", EmitDefaultValue = false)]
        public MaritalStatusModel MaritalStatus { get; set; }

        /// <summary>
        /// Gets or Sets MiddleName
        /// </summary>
        [DataMember(Name = "middleName", EmitDefaultValue = false)]
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or Sets Parent01
        /// </summary>
        [DataMember(Name = "parent01", EmitDefaultValue = false)]
        public NaturalPersonRelationshipLiteModel Parent01 { get; set; }

        /// <summary>
        /// Gets or Sets Parent02
        /// </summary>
        [DataMember(Name = "parent02", EmitDefaultValue = false)]
        public NaturalPersonRelationshipLiteModel Parent02 { get; set; }

        /// <summary>
        /// Gets or Sets NaturalPersonNationality
        /// </summary>
        [DataMember(Name = "naturalPersonNationality", EmitDefaultValue = false)]
        public List<CountryLiteSearchModel> NaturalPersonNationality { get; set; }

        /// <summary>
        /// Gets or Sets NewIdentity
        /// </summary>
        [DataMember(Name = "newIdentity", EmitDefaultValue = false)]
        public Guid? NewIdentity { get; set; }

        /// <summary>
        /// Gets or Sets Occupation
        /// </summary>
        [DataMember(Name = "occupation", EmitDefaultValue = false)]
        public OccupationModel Occupation { get; set; }

        /// <summary>
        /// Gets or Sets Photo
        /// </summary>
        [DataMember(Name = "photo", EmitDefaultValue = false)]
        public Guid? Photo { get; set; }

        /// <summary>
        /// Gets or Sets Religion
        /// </summary>
        [DataMember(Name = "religion", EmitDefaultValue = false)]
        public ReligionModel Religion { get; set; }

        /// <summary>
        /// Gets or Sets Spouse
        /// </summary>
        [DataMember(Name = "spouse", EmitDefaultValue = false)]
        public NaturalPersonRelationshipLiteModel Spouse { get; set; }

        /// <summary>
        /// Gets or Sets Scholarity
        /// </summary>
        [DataMember(Name = "scholarity", EmitDefaultValue = false)]
        public ScholarityModel Scholarity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NaturalPersonLiteExternalModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AuthenticationUserName: ").Append(AuthenticationUserName).Append("\n");
            sb.Append("  MotherName: ").Append(MotherName).Append("\n");
            sb.Append("  SocialName: ").Append(SocialName).Append("\n");
            sb.Append("  BaptismDate: ").Append(BaptismDate).Append("\n");
            sb.Append("  BirthCity: ").Append(BirthCity).Append("\n");
            sb.Append("  BirthCountry: ").Append(BirthCountry).Append("\n");
            sb.Append("  BirthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  BloodType: ").Append(BloodType).Append("\n");
            sb.Append("  DeceaseDate: ").Append(DeceaseDate).Append("\n");
            sb.Append("  Ethnicity: ").Append(Ethnicity).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  IdentifierDocumentNumber: ").Append(IdentifierDocumentNumber).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  LastUpdate: ").Append(LastUpdate).Append("\n");
            sb.Append("  MaritalStatus: ").Append(MaritalStatus).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  Parent01: ").Append(Parent01).Append("\n");
            sb.Append("  Parent02: ").Append(Parent02).Append("\n");
            sb.Append("  NaturalPersonNationality: ").Append(NaturalPersonNationality).Append("\n");
            sb.Append("  NewIdentity: ").Append(NewIdentity).Append("\n");
            sb.Append("  Occupation: ").Append(Occupation).Append("\n");
            sb.Append("  Photo: ").Append(Photo).Append("\n");
            sb.Append("  Religion: ").Append(Religion).Append("\n");
            sb.Append("  Spouse: ").Append(Spouse).Append("\n");
            sb.Append("  Scholarity: ").Append(Scholarity).Append("\n");
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
            return this.Equals(input as NaturalPersonLiteExternalModel);
        }

        /// <summary>
        /// Returns true if NaturalPersonLiteExternalModel instances are equal
        /// </summary>
        /// <param name="input">Instance of NaturalPersonLiteExternalModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NaturalPersonLiteExternalModel input)
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
                    this.AuthenticationUserName == input.AuthenticationUserName ||
                    (this.AuthenticationUserName != null &&
                    this.AuthenticationUserName.Equals(input.AuthenticationUserName))
                ) &&
                (
                    this.MotherName == input.MotherName ||
                    (this.MotherName != null &&
                    this.MotherName.Equals(input.MotherName))
                ) &&
                (
                    this.SocialName == input.SocialName ||
                    (this.SocialName != null &&
                    this.SocialName.Equals(input.SocialName))
                ) &&
                (
                    this.BaptismDate == input.BaptismDate ||
                    (this.BaptismDate != null &&
                    this.BaptismDate.Equals(input.BaptismDate))
                ) &&
                (
                    this.BirthCity == input.BirthCity ||
                    (this.BirthCity != null &&
                    this.BirthCity.Equals(input.BirthCity))
                ) &&
                (
                    this.BirthCountry == input.BirthCountry ||
                    (this.BirthCountry != null &&
                    this.BirthCountry.Equals(input.BirthCountry))
                ) &&
                (
                    this.BirthDate == input.BirthDate ||
                    (this.BirthDate != null &&
                    this.BirthDate.Equals(input.BirthDate))
                ) &&
                (
                    this.BloodType == input.BloodType ||
                    (this.BloodType != null &&
                    this.BloodType.Equals(input.BloodType))
                ) &&
                (
                    this.DeceaseDate == input.DeceaseDate ||
                    (this.DeceaseDate != null &&
                    this.DeceaseDate.Equals(input.DeceaseDate))
                ) &&
                (
                    this.Ethnicity == input.Ethnicity ||
                    (this.Ethnicity != null &&
                    this.Ethnicity.Equals(input.Ethnicity))
                ) &&
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) &&
                (
                    this.FullName == input.FullName ||
                    (this.FullName != null &&
                    this.FullName.Equals(input.FullName))
                ) &&
                (
                    this.Gender == input.Gender ||
                    (this.Gender != null &&
                    this.Gender.Equals(input.Gender))
                ) &&
                (
                    this.IdentifierDocumentNumber == input.IdentifierDocumentNumber ||
                    (this.IdentifierDocumentNumber != null &&
                    this.IdentifierDocumentNumber.Equals(input.IdentifierDocumentNumber))
                ) &&
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) &&
                (
                    this.LastUpdate == input.LastUpdate ||
                    (this.LastUpdate != null &&
                    this.LastUpdate.Equals(input.LastUpdate))
                ) &&
                (
                    this.MaritalStatus == input.MaritalStatus ||
                    (this.MaritalStatus != null &&
                    this.MaritalStatus.Equals(input.MaritalStatus))
                ) &&
                (
                    this.MiddleName == input.MiddleName ||
                    (this.MiddleName != null &&
                    this.MiddleName.Equals(input.MiddleName))
                ) &&
                (
                    this.Parent01 == input.Parent01 ||
                    (this.Parent01 != null &&
                    this.Parent01.Equals(input.Parent01))
                ) &&
                (
                    this.Parent02 == input.Parent02 ||
                    (this.Parent02 != null &&
                    this.Parent02.Equals(input.Parent02))
                ) &&
                (
                    this.NaturalPersonNationality == input.NaturalPersonNationality ||
                    this.NaturalPersonNationality != null &&
                    this.NaturalPersonNationality.SequenceEqual(input.NaturalPersonNationality)
                ) &&
                (
                    this.NewIdentity == input.NewIdentity ||
                    (this.NewIdentity != null &&
                    this.NewIdentity.Equals(input.NewIdentity))
                ) &&
                (
                    this.Occupation == input.Occupation ||
                    (this.Occupation != null &&
                    this.Occupation.Equals(input.Occupation))
                ) &&
                (
                    this.Photo == input.Photo ||
                    (this.Photo != null &&
                    this.Photo.Equals(input.Photo))
                ) &&
                (
                    this.Religion == input.Religion ||
                    (this.Religion != null &&
                    this.Religion.Equals(input.Religion))
                ) &&
                (
                    this.Spouse == input.Spouse ||
                    (this.Spouse != null &&
                    this.Spouse.Equals(input.Spouse))
                ) &&
                (
                    this.Scholarity == input.Scholarity ||
                    (this.Scholarity != null &&
                    this.Scholarity.Equals(input.Scholarity))
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
                if (this.AuthenticationUserName != null)
                    hashCode = hashCode * 59 + this.AuthenticationUserName.GetHashCode();
                if (this.MotherName != null)
                    hashCode = hashCode * 59 + this.MotherName.GetHashCode();
                if (this.SocialName != null)
                    hashCode = hashCode * 59 + this.SocialName.GetHashCode();
                if (this.BaptismDate != null)
                    hashCode = hashCode * 59 + this.BaptismDate.GetHashCode();
                if (this.BirthCity != null)
                    hashCode = hashCode * 59 + this.BirthCity.GetHashCode();
                if (this.BirthCountry != null)
                    hashCode = hashCode * 59 + this.BirthCountry.GetHashCode();
                if (this.BirthDate != null)
                    hashCode = hashCode * 59 + this.BirthDate.GetHashCode();
                if (this.BloodType != null)
                    hashCode = hashCode * 59 + this.BloodType.GetHashCode();
                if (this.DeceaseDate != null)
                    hashCode = hashCode * 59 + this.DeceaseDate.GetHashCode();
                if (this.Ethnicity != null)
                    hashCode = hashCode * 59 + this.Ethnicity.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.FullName != null)
                    hashCode = hashCode * 59 + this.FullName.GetHashCode();
                if (this.Gender != null)
                    hashCode = hashCode * 59 + this.Gender.GetHashCode();
                if (this.IdentifierDocumentNumber != null)
                    hashCode = hashCode * 59 + this.IdentifierDocumentNumber.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.LastUpdate != null)
                    hashCode = hashCode * 59 + this.LastUpdate.GetHashCode();
                if (this.MaritalStatus != null)
                    hashCode = hashCode * 59 + this.MaritalStatus.GetHashCode();
                if (this.MiddleName != null)
                    hashCode = hashCode * 59 + this.MiddleName.GetHashCode();
                if (this.Parent01 != null)
                    hashCode = hashCode * 59 + this.Parent01.GetHashCode();
                if (this.Parent02 != null)
                    hashCode = hashCode * 59 + this.Parent02.GetHashCode();
                if (this.NaturalPersonNationality != null)
                    hashCode = hashCode * 59 + this.NaturalPersonNationality.GetHashCode();
                if (this.NewIdentity != null)
                    hashCode = hashCode * 59 + this.NewIdentity.GetHashCode();
                if (this.Occupation != null)
                    hashCode = hashCode * 59 + this.Occupation.GetHashCode();
                if (this.Photo != null)
                    hashCode = hashCode * 59 + this.Photo.GetHashCode();
                if (this.Religion != null)
                    hashCode = hashCode * 59 + this.Religion.GetHashCode();
                if (this.Spouse != null)
                    hashCode = hashCode * 59 + this.Spouse.GetHashCode();
                if (this.Scholarity != null)
                    hashCode = hashCode * 59 + this.Scholarity.GetHashCode();
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