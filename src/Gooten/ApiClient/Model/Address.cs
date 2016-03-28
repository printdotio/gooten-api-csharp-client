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



namespace Gooten.ApiClient.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Address :  IEquatable<Address>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// Initializes a new instance of the <see cref="Address" />class.
        /// </summary>
        /// <param name="City">City (required).</param>
        /// <param name="CountryCode">CountryCode (required).</param>
        /// <param name="PostalCode">PostalCode (required).</param>
        /// <param name="StateOrProvinceCode">StateOrProvinceCode (required).</param>
        /// <param name="StreetLines">StreetLines (required).</param>

        public Address(string City = null, string CountryCode = null, string PostalCode = null, string StateOrProvinceCode = null, List<string> StreetLines = null)
        {
            // to ensure "City" is required (not null)
            if (City == null)
            {
                throw new InvalidDataException("City is a required property for Address and cannot be null");
            }
            else
            {
                this.City = City;
            }
            // to ensure "CountryCode" is required (not null)
            if (CountryCode == null)
            {
                throw new InvalidDataException("CountryCode is a required property for Address and cannot be null");
            }
            else
            {
                this.CountryCode = CountryCode;
            }
            // to ensure "PostalCode" is required (not null)
            if (PostalCode == null)
            {
                throw new InvalidDataException("PostalCode is a required property for Address and cannot be null");
            }
            else
            {
                this.PostalCode = PostalCode;
            }
            // to ensure "StateOrProvinceCode" is required (not null)
            if (StateOrProvinceCode == null)
            {
                throw new InvalidDataException("StateOrProvinceCode is a required property for Address and cannot be null");
            }
            else
            {
                this.StateOrProvinceCode = StateOrProvinceCode;
            }
            // to ensure "StreetLines" is required (not null)
            if (StreetLines == null)
            {
                throw new InvalidDataException("StreetLines is a required property for Address and cannot be null");
            }
            else
            {
                this.StreetLines = StreetLines;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="City", EmitDefaultValue=false)]
        public string City { get; set; }
    
        /// <summary>
        /// Gets or Sets CountryCode
        /// </summary>
        [DataMember(Name="CountryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }
    
        /// <summary>
        /// Gets or Sets PostalCode
        /// </summary>
        [DataMember(Name="PostalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }
    
        /// <summary>
        /// Gets or Sets StateOrProvinceCode
        /// </summary>
        [DataMember(Name="StateOrProvinceCode", EmitDefaultValue=false)]
        public string StateOrProvinceCode { get; set; }
    
        /// <summary>
        /// Gets or Sets StreetLines
        /// </summary>
        [DataMember(Name="StreetLines", EmitDefaultValue=false)]
        public List<string> StreetLines { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Address {\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  StateOrProvinceCode: ").Append(StateOrProvinceCode).Append("\n");
            sb.Append("  StreetLines: ").Append(StreetLines).Append("\n");
            
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
            return this.Equals(obj as Address);
        }

        /// <summary>
        /// Returns true if Address instances are equal
        /// </summary>
        /// <param name="other">Instance of Address to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Address other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.CountryCode == other.CountryCode ||
                    this.CountryCode != null &&
                    this.CountryCode.Equals(other.CountryCode)
                ) && 
                (
                    this.PostalCode == other.PostalCode ||
                    this.PostalCode != null &&
                    this.PostalCode.Equals(other.PostalCode)
                ) && 
                (
                    this.StateOrProvinceCode == other.StateOrProvinceCode ||
                    this.StateOrProvinceCode != null &&
                    this.StateOrProvinceCode.Equals(other.StateOrProvinceCode)
                ) && 
                (
                    this.StreetLines == other.StreetLines ||
                    this.StreetLines != null &&
                    this.StreetLines.SequenceEqual(other.StreetLines)
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
                
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                
                if (this.CountryCode != null)
                    hash = hash * 59 + this.CountryCode.GetHashCode();
                
                if (this.PostalCode != null)
                    hash = hash * 59 + this.PostalCode.GetHashCode();
                
                if (this.StateOrProvinceCode != null)
                    hash = hash * 59 + this.StateOrProvinceCode.GetHashCode();
                
                if (this.StreetLines != null)
                    hash = hash * 59 + this.StreetLines.GetHashCode();
                
                return hash;
            }
        }

    }


}
