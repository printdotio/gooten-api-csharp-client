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
    public partial class UserInfo :  IEquatable<UserInfo>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserInfo" /> class.
        /// Initializes a new instance of the <see cref="UserInfo" />class.
        /// </summary>
        /// <param name="LanguageCode">LanguageCode (required).</param>
        /// <param name="CountryCode">CountryCode (required).</param>
        /// <param name="CountryName">CountryName (required).</param>
        /// <param name="CurrencyName">CurrencyName (required).</param>
        /// <param name="CurrencyCode">CurrencyCode (required).</param>
        /// <param name="CurrencyFormat">CurrencyFormat (required).</param>

        public UserInfo(string LanguageCode = null, string CountryCode = null, string CountryName = null, string CurrencyName = null, string CurrencyCode = null, string CurrencyFormat = null)
        {
            // to ensure "LanguageCode" is required (not null)
            if (LanguageCode == null)
            {
                throw new InvalidDataException("LanguageCode is a required property for UserInfo and cannot be null");
            }
            else
            {
                this.LanguageCode = LanguageCode;
            }
            // to ensure "CountryCode" is required (not null)
            if (CountryCode == null)
            {
                throw new InvalidDataException("CountryCode is a required property for UserInfo and cannot be null");
            }
            else
            {
                this.CountryCode = CountryCode;
            }
            // to ensure "CountryName" is required (not null)
            if (CountryName == null)
            {
                throw new InvalidDataException("CountryName is a required property for UserInfo and cannot be null");
            }
            else
            {
                this.CountryName = CountryName;
            }
            // to ensure "CurrencyName" is required (not null)
            if (CurrencyName == null)
            {
                throw new InvalidDataException("CurrencyName is a required property for UserInfo and cannot be null");
            }
            else
            {
                this.CurrencyName = CurrencyName;
            }
            // to ensure "CurrencyCode" is required (not null)
            if (CurrencyCode == null)
            {
                throw new InvalidDataException("CurrencyCode is a required property for UserInfo and cannot be null");
            }
            else
            {
                this.CurrencyCode = CurrencyCode;
            }
            // to ensure "CurrencyFormat" is required (not null)
            if (CurrencyFormat == null)
            {
                throw new InvalidDataException("CurrencyFormat is a required property for UserInfo and cannot be null");
            }
            else
            {
                this.CurrencyFormat = CurrencyFormat;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets LanguageCode
        /// </summary>
        [DataMember(Name="LanguageCode", EmitDefaultValue=false)]
        public string LanguageCode { get; set; }
    
        /// <summary>
        /// Gets or Sets CountryCode
        /// </summary>
        [DataMember(Name="CountryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }
    
        /// <summary>
        /// Gets or Sets CountryName
        /// </summary>
        [DataMember(Name="CountryName", EmitDefaultValue=false)]
        public string CountryName { get; set; }
    
        /// <summary>
        /// Gets or Sets CurrencyName
        /// </summary>
        [DataMember(Name="CurrencyName", EmitDefaultValue=false)]
        public string CurrencyName { get; set; }
    
        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        [DataMember(Name="CurrencyCode", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }
    
        /// <summary>
        /// Gets or Sets CurrencyFormat
        /// </summary>
        [DataMember(Name="CurrencyFormat", EmitDefaultValue=false)]
        public string CurrencyFormat { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserInfo {\n");
            sb.Append("  LanguageCode: ").Append(LanguageCode).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  CountryName: ").Append(CountryName).Append("\n");
            sb.Append("  CurrencyName: ").Append(CurrencyName).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  CurrencyFormat: ").Append(CurrencyFormat).Append("\n");
            
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
            return this.Equals(obj as UserInfo);
        }

        /// <summary>
        /// Returns true if UserInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of UserInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LanguageCode == other.LanguageCode ||
                    this.LanguageCode != null &&
                    this.LanguageCode.Equals(other.LanguageCode)
                ) && 
                (
                    this.CountryCode == other.CountryCode ||
                    this.CountryCode != null &&
                    this.CountryCode.Equals(other.CountryCode)
                ) && 
                (
                    this.CountryName == other.CountryName ||
                    this.CountryName != null &&
                    this.CountryName.Equals(other.CountryName)
                ) && 
                (
                    this.CurrencyName == other.CurrencyName ||
                    this.CurrencyName != null &&
                    this.CurrencyName.Equals(other.CurrencyName)
                ) && 
                (
                    this.CurrencyCode == other.CurrencyCode ||
                    this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(other.CurrencyCode)
                ) && 
                (
                    this.CurrencyFormat == other.CurrencyFormat ||
                    this.CurrencyFormat != null &&
                    this.CurrencyFormat.Equals(other.CurrencyFormat)
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
                
                if (this.LanguageCode != null)
                    hash = hash * 59 + this.LanguageCode.GetHashCode();
                
                if (this.CountryCode != null)
                    hash = hash * 59 + this.CountryCode.GetHashCode();
                
                if (this.CountryName != null)
                    hash = hash * 59 + this.CountryName.GetHashCode();
                
                if (this.CurrencyName != null)
                    hash = hash * 59 + this.CurrencyName.GetHashCode();
                
                if (this.CurrencyCode != null)
                    hash = hash * 59 + this.CurrencyCode.GetHashCode();
                
                if (this.CurrencyFormat != null)
                    hash = hash * 59 + this.CurrencyFormat.GetHashCode();
                
                return hash;
            }
        }

    }
}
