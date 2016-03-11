using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace IO.Swagger.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Country :  IEquatable<Country>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Country" /> class.
        /// Initializes a new instance of the <see cref="Country" />class.
        /// </summary>
        /// <param name="Name">Name (required).</param>
        /// <param name="Code">Code (required).</param>
        /// <param name="IsSupported">IsSupported (required).</param>
        /// <param name="MeasurementCode">MeasurementCode (required).</param>
        /// <param name="FlagUrl">FlagUrl (required).</param>
        /// <param name="DefaultCurrency">DefaultCurrency (required).</param>

        public Country(string Name = null, string Code = null, bool? IsSupported = null, string MeasurementCode = null, string FlagUrl = null, Currency DefaultCurrency = null)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for Country and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Code" is required (not null)
            if (Code == null)
            {
                throw new InvalidDataException("Code is a required property for Country and cannot be null");
            }
            else
            {
                this.Code = Code;
            }
            // to ensure "IsSupported" is required (not null)
            if (IsSupported == null)
            {
                throw new InvalidDataException("IsSupported is a required property for Country and cannot be null");
            }
            else
            {
                this.IsSupported = IsSupported;
            }
            // to ensure "MeasurementCode" is required (not null)
            if (MeasurementCode == null)
            {
                throw new InvalidDataException("MeasurementCode is a required property for Country and cannot be null");
            }
            else
            {
                this.MeasurementCode = MeasurementCode;
            }
            // to ensure "FlagUrl" is required (not null)
            if (FlagUrl == null)
            {
                throw new InvalidDataException("FlagUrl is a required property for Country and cannot be null");
            }
            else
            {
                this.FlagUrl = FlagUrl;
            }
            // to ensure "DefaultCurrency" is required (not null)
            if (DefaultCurrency == null)
            {
                throw new InvalidDataException("DefaultCurrency is a required property for Country and cannot be null");
            }
            else
            {
                this.DefaultCurrency = DefaultCurrency;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="Code", EmitDefaultValue=false)]
        public string Code { get; set; }
    
        /// <summary>
        /// Gets or Sets IsSupported
        /// </summary>
        [DataMember(Name="IsSupported", EmitDefaultValue=false)]
        public bool? IsSupported { get; set; }
    
        /// <summary>
        /// Gets or Sets MeasurementCode
        /// </summary>
        [DataMember(Name="MeasurementCode", EmitDefaultValue=false)]
        public string MeasurementCode { get; set; }
    
        /// <summary>
        /// Gets or Sets FlagUrl
        /// </summary>
        [DataMember(Name="FlagUrl", EmitDefaultValue=false)]
        public string FlagUrl { get; set; }
    
        /// <summary>
        /// Gets or Sets DefaultCurrency
        /// </summary>
        [DataMember(Name="DefaultCurrency", EmitDefaultValue=false)]
        public Currency DefaultCurrency { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Country {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  IsSupported: ").Append(IsSupported).Append("\n");
            sb.Append("  MeasurementCode: ").Append(MeasurementCode).Append("\n");
            sb.Append("  FlagUrl: ").Append(FlagUrl).Append("\n");
            sb.Append("  DefaultCurrency: ").Append(DefaultCurrency).Append("\n");
            
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
            return this.Equals(obj as Country);
        }

        /// <summary>
        /// Returns true if Country instances are equal
        /// </summary>
        /// <param name="other">Instance of Country to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Country other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this.IsSupported == other.IsSupported ||
                    this.IsSupported != null &&
                    this.IsSupported.Equals(other.IsSupported)
                ) && 
                (
                    this.MeasurementCode == other.MeasurementCode ||
                    this.MeasurementCode != null &&
                    this.MeasurementCode.Equals(other.MeasurementCode)
                ) && 
                (
                    this.FlagUrl == other.FlagUrl ||
                    this.FlagUrl != null &&
                    this.FlagUrl.Equals(other.FlagUrl)
                ) && 
                (
                    this.DefaultCurrency == other.DefaultCurrency ||
                    this.DefaultCurrency != null &&
                    this.DefaultCurrency.Equals(other.DefaultCurrency)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                
                if (this.IsSupported != null)
                    hash = hash * 59 + this.IsSupported.GetHashCode();
                
                if (this.MeasurementCode != null)
                    hash = hash * 59 + this.MeasurementCode.GetHashCode();
                
                if (this.FlagUrl != null)
                    hash = hash * 59 + this.FlagUrl.GetHashCode();
                
                if (this.DefaultCurrency != null)
                    hash = hash * 59 + this.DefaultCurrency.GetHashCode();
                
                return hash;
            }
        }

    }
}
