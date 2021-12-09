/* 
 * bSDD API prototype
 *
 * API to access the buildingSMART Data Dictionary
 *
 * OpenAPI spec version: v1
 * Contact: bsdd_support@buildingsmart.org
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// DomainWithClassificationsContractV2
    /// </summary>
    [DataContract]
        public partial class DomainWithClassificationsContractV2 :  IEquatable<DomainWithClassificationsContractV2>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainWithClassificationsContractV2" /> class.
        /// </summary>
        /// <param name="classifications">classifications.</param>
        /// <param name="namespaceUri">namespaceUri.</param>
        /// <param name="name">name (required).</param>
        /// <param name="version">version (required).</param>
        /// <param name="organizationNameOwner">organizationNameOwner (required).</param>
        /// <param name="defaultLanguageCode">defaultLanguageCode (required).</param>
        /// <param name="license">license.</param>
        /// <param name="licenseUrl">licenseUrl.</param>
        /// <param name="qualityAssuranceProcedure">qualityAssuranceProcedure.</param>
        /// <param name="qualityAssuranceProcedureUrl">qualityAssuranceProcedureUrl.</param>
        public DomainWithClassificationsContractV2(List<ClassificationListItemContractV2> classifications = default(List<ClassificationListItemContractV2>), string namespaceUri = default(string), string name = default(string), string version = default(string), string organizationNameOwner = default(string), string defaultLanguageCode = default(string), string license = default(string), string licenseUrl = default(string), string qualityAssuranceProcedure = default(string), string qualityAssuranceProcedureUrl = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for DomainWithClassificationsContractV2 and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for DomainWithClassificationsContractV2 and cannot be null");
            }
            else
            {
                this.Version = version;
            }
            // to ensure "organizationNameOwner" is required (not null)
            if (organizationNameOwner == null)
            {
                throw new InvalidDataException("organizationNameOwner is a required property for DomainWithClassificationsContractV2 and cannot be null");
            }
            else
            {
                this.OrganizationNameOwner = organizationNameOwner;
            }
            // to ensure "defaultLanguageCode" is required (not null)
            if (defaultLanguageCode == null)
            {
                throw new InvalidDataException("defaultLanguageCode is a required property for DomainWithClassificationsContractV2 and cannot be null");
            }
            else
            {
                this.DefaultLanguageCode = defaultLanguageCode;
            }
            this.Classifications = classifications;
            this.NamespaceUri = namespaceUri;
            this.License = license;
            this.LicenseUrl = licenseUrl;
            this.QualityAssuranceProcedure = qualityAssuranceProcedure;
            this.QualityAssuranceProcedureUrl = qualityAssuranceProcedureUrl;
        }
        
        /// <summary>
        /// Gets or Sets Classifications
        /// </summary>
        [DataMember(Name="classifications", EmitDefaultValue=false)]
        public List<ClassificationListItemContractV2> Classifications { get; set; }

        /// <summary>
        /// Gets or Sets NamespaceUri
        /// </summary>
        [DataMember(Name="namespaceUri", EmitDefaultValue=false)]
        public string NamespaceUri { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationNameOwner
        /// </summary>
        [DataMember(Name="organizationNameOwner", EmitDefaultValue=false)]
        public string OrganizationNameOwner { get; set; }

        /// <summary>
        /// Gets or Sets DefaultLanguageCode
        /// </summary>
        [DataMember(Name="defaultLanguageCode", EmitDefaultValue=false)]
        public string DefaultLanguageCode { get; set; }

        /// <summary>
        /// Gets or Sets License
        /// </summary>
        [DataMember(Name="license", EmitDefaultValue=false)]
        public string License { get; set; }

        /// <summary>
        /// Gets or Sets LicenseUrl
        /// </summary>
        [DataMember(Name="licenseUrl", EmitDefaultValue=false)]
        public string LicenseUrl { get; set; }

        /// <summary>
        /// Gets or Sets QualityAssuranceProcedure
        /// </summary>
        [DataMember(Name="qualityAssuranceProcedure", EmitDefaultValue=false)]
        public string QualityAssuranceProcedure { get; set; }

        /// <summary>
        /// Gets or Sets QualityAssuranceProcedureUrl
        /// </summary>
        [DataMember(Name="qualityAssuranceProcedureUrl", EmitDefaultValue=false)]
        public string QualityAssuranceProcedureUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainWithClassificationsContractV2 {\n");
            sb.Append("  Classifications: ").Append(Classifications).Append("\n");
            sb.Append("  NamespaceUri: ").Append(NamespaceUri).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  OrganizationNameOwner: ").Append(OrganizationNameOwner).Append("\n");
            sb.Append("  DefaultLanguageCode: ").Append(DefaultLanguageCode).Append("\n");
            sb.Append("  License: ").Append(License).Append("\n");
            sb.Append("  LicenseUrl: ").Append(LicenseUrl).Append("\n");
            sb.Append("  QualityAssuranceProcedure: ").Append(QualityAssuranceProcedure).Append("\n");
            sb.Append("  QualityAssuranceProcedureUrl: ").Append(QualityAssuranceProcedureUrl).Append("\n");
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
            return this.Equals(input as DomainWithClassificationsContractV2);
        }

        /// <summary>
        /// Returns true if DomainWithClassificationsContractV2 instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainWithClassificationsContractV2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainWithClassificationsContractV2 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Classifications == input.Classifications ||
                    this.Classifications != null &&
                    input.Classifications != null &&
                    this.Classifications.SequenceEqual(input.Classifications)
                ) && 
                (
                    this.NamespaceUri == input.NamespaceUri ||
                    (this.NamespaceUri != null &&
                    this.NamespaceUri.Equals(input.NamespaceUri))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.OrganizationNameOwner == input.OrganizationNameOwner ||
                    (this.OrganizationNameOwner != null &&
                    this.OrganizationNameOwner.Equals(input.OrganizationNameOwner))
                ) && 
                (
                    this.DefaultLanguageCode == input.DefaultLanguageCode ||
                    (this.DefaultLanguageCode != null &&
                    this.DefaultLanguageCode.Equals(input.DefaultLanguageCode))
                ) && 
                (
                    this.License == input.License ||
                    (this.License != null &&
                    this.License.Equals(input.License))
                ) && 
                (
                    this.LicenseUrl == input.LicenseUrl ||
                    (this.LicenseUrl != null &&
                    this.LicenseUrl.Equals(input.LicenseUrl))
                ) && 
                (
                    this.QualityAssuranceProcedure == input.QualityAssuranceProcedure ||
                    (this.QualityAssuranceProcedure != null &&
                    this.QualityAssuranceProcedure.Equals(input.QualityAssuranceProcedure))
                ) && 
                (
                    this.QualityAssuranceProcedureUrl == input.QualityAssuranceProcedureUrl ||
                    (this.QualityAssuranceProcedureUrl != null &&
                    this.QualityAssuranceProcedureUrl.Equals(input.QualityAssuranceProcedureUrl))
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
                if (this.Classifications != null)
                    hashCode = hashCode * 59 + this.Classifications.GetHashCode();
                if (this.NamespaceUri != null)
                    hashCode = hashCode * 59 + this.NamespaceUri.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.OrganizationNameOwner != null)
                    hashCode = hashCode * 59 + this.OrganizationNameOwner.GetHashCode();
                if (this.DefaultLanguageCode != null)
                    hashCode = hashCode * 59 + this.DefaultLanguageCode.GetHashCode();
                if (this.License != null)
                    hashCode = hashCode * 59 + this.License.GetHashCode();
                if (this.LicenseUrl != null)
                    hashCode = hashCode * 59 + this.LicenseUrl.GetHashCode();
                if (this.QualityAssuranceProcedure != null)
                    hashCode = hashCode * 59 + this.QualityAssuranceProcedure.GetHashCode();
                if (this.QualityAssuranceProcedureUrl != null)
                    hashCode = hashCode * 59 + this.QualityAssuranceProcedureUrl.GetHashCode();
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