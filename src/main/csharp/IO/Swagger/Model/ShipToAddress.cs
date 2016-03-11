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
    public partial class ShipToAddress :  IEquatable<ShipToAddress>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipToAddress" /> class.
        /// Initializes a new instance of the <see cref="ShipToAddress" />class.
        /// </summary>
        /// <param name="FirstName">FirstName (required).</param>
        /// <param name="LastName">LastName (required).</param>
        /// <param name="Line1">Line1 (required).</param>
        /// <param name="Line2">Line2 (required).</param>
        /// <param name="City">City (required).</param>
        /// <param name="State">State (required).</param>
        /// <param name="CountryCode">CountryCode (required).</param>
        /// <param name="PostalCode">PostalCode (required).</param>
        /// <param name="IsBusinessAddress">IsBusinessAddress (required).</param>
        /// <param name="Phone">Phone (required).</param>
        /// <param name="Email">Email (required).</param>

        public ShipToAddress(string FirstName = null, string LastName = null, string Line1 = null, string Line2 = null, string City = null, string State = null, string CountryCode = null, string PostalCode = null, bool? IsBusinessAddress = null, string Phone = null, string Email = null)
        {
            // to ensure "FirstName" is required (not null)
            if (FirstName == null)
            {
                throw new InvalidDataException("FirstName is a required property for ShipToAddress and cannot be null");
            }
            else
            {
                this.FirstName = FirstName;
            }
            // to ensure "LastName" is required (not null)
            if (LastName == null)
            {
                throw new InvalidDataException("LastName is a required property for ShipToAddress and cannot be null");
            }
            else
            {
                this.LastName = LastName;
            }
            // to ensure "Line1" is required (not null)
            if (Line1 == null)
            {
                throw new InvalidDataException("Line1 is a required property for ShipToAddress and cannot be null");
            }
            else
            {
                this.Line1 = Line1;
            }
            // to ensure "Line2" is required (not null)
            if (Line2 == null)
            {
                throw new InvalidDataException("Line2 is a required property for ShipToAddress and cannot be null");
            }
            else
            {
                this.Line2 = Line2;
            }
            // to ensure "City" is required (not null)
            if (City == null)
            {
                throw new InvalidDataException("City is a required property for ShipToAddress and cannot be null");
            }
            else
            {
                this.City = City;
            }
            // to ensure "State" is required (not null)
            if (State == null)
            {
                throw new InvalidDataException("State is a required property for ShipToAddress and cannot be null");
            }
            else
            {
                this.State = State;
            }
            // to ensure "CountryCode" is required (not null)
            if (CountryCode == null)
            {
                throw new InvalidDataException("CountryCode is a required property for ShipToAddress and cannot be null");
            }
            else
            {
                this.CountryCode = CountryCode;
            }
            // to ensure "PostalCode" is required (not null)
            if (PostalCode == null)
            {
                throw new InvalidDataException("PostalCode is a required property for ShipToAddress and cannot be null");
            }
            else
            {
                this.PostalCode = PostalCode;
            }
            // to ensure "IsBusinessAddress" is required (not null)
            if (IsBusinessAddress == null)
            {
                throw new InvalidDataException("IsBusinessAddress is a required property for ShipToAddress and cannot be null");
            }
            else
            {
                this.IsBusinessAddress = IsBusinessAddress;
            }
            // to ensure "Phone" is required (not null)
            if (Phone == null)
            {
                throw new InvalidDataException("Phone is a required property for ShipToAddress and cannot be null");
            }
            else
            {
                this.Phone = Phone;
            }
            // to ensure "Email" is required (not null)
            if (Email == null)
            {
                throw new InvalidDataException("Email is a required property for ShipToAddress and cannot be null");
            }
            else
            {
                this.Email = Email;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="FirstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }
    
        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="LastName", EmitDefaultValue=false)]
        public string LastName { get; set; }
    
        /// <summary>
        /// Gets or Sets Line1
        /// </summary>
        [DataMember(Name="Line1", EmitDefaultValue=false)]
        public string Line1 { get; set; }
    
        /// <summary>
        /// Gets or Sets Line2
        /// </summary>
        [DataMember(Name="Line2", EmitDefaultValue=false)]
        public string Line2 { get; set; }
    
        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="City", EmitDefaultValue=false)]
        public string City { get; set; }
    
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="State", EmitDefaultValue=false)]
        public string State { get; set; }
    
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
        /// Gets or Sets IsBusinessAddress
        /// </summary>
        [DataMember(Name="IsBusinessAddress", EmitDefaultValue=false)]
        public bool? IsBusinessAddress { get; set; }
    
        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="Phone", EmitDefaultValue=false)]
        public string Phone { get; set; }
    
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="Email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShipToAddress {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Line1: ").Append(Line1).Append("\n");
            sb.Append("  Line2: ").Append(Line2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  IsBusinessAddress: ").Append(IsBusinessAddress).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            
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
            return this.Equals(obj as ShipToAddress);
        }

        /// <summary>
        /// Returns true if ShipToAddress instances are equal
        /// </summary>
        /// <param name="other">Instance of ShipToAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShipToAddress other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) && 
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) && 
                (
                    this.Line1 == other.Line1 ||
                    this.Line1 != null &&
                    this.Line1.Equals(other.Line1)
                ) && 
                (
                    this.Line2 == other.Line2 ||
                    this.Line2 != null &&
                    this.Line2.Equals(other.Line2)
                ) && 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
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
                    this.IsBusinessAddress == other.IsBusinessAddress ||
                    this.IsBusinessAddress != null &&
                    this.IsBusinessAddress.Equals(other.IsBusinessAddress)
                ) && 
                (
                    this.Phone == other.Phone ||
                    this.Phone != null &&
                    this.Phone.Equals(other.Phone)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
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
                
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                
                if (this.Line1 != null)
                    hash = hash * 59 + this.Line1.GetHashCode();
                
                if (this.Line2 != null)
                    hash = hash * 59 + this.Line2.GetHashCode();
                
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                
                if (this.CountryCode != null)
                    hash = hash * 59 + this.CountryCode.GetHashCode();
                
                if (this.PostalCode != null)
                    hash = hash * 59 + this.PostalCode.GetHashCode();
                
                if (this.IsBusinessAddress != null)
                    hash = hash * 59 + this.IsBusinessAddress.GetHashCode();
                
                if (this.Phone != null)
                    hash = hash * 59 + this.Phone.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                return hash;
            }
        }

    }
}
