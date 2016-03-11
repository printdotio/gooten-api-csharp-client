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
    public partial class ShipEstimate :  IEquatable<ShipEstimate>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipEstimate" /> class.
        /// Initializes a new instance of the <see cref="ShipEstimate" />class.
        /// </summary>
        /// <param name="MinPrice">MinPrice (required).</param>
        /// <param name="MaxPrice">MaxPrice (required).</param>
        /// <param name="VendorCountryCode">VendorCountryCode (required).</param>
        /// <param name="CanShipExpedited">CanShipExpedited (required).</param>
        /// <param name="EstShipDays">EstShipDays (required).</param>

        public ShipEstimate(ShipPrice MinPrice = null, ShipPrice MaxPrice = null, string VendorCountryCode = null, bool? CanShipExpedited = null, long? EstShipDays = null)
        {
            // to ensure "MinPrice" is required (not null)
            if (MinPrice == null)
            {
                throw new InvalidDataException("MinPrice is a required property for ShipEstimate and cannot be null");
            }
            else
            {
                this.MinPrice = MinPrice;
            }
            // to ensure "MaxPrice" is required (not null)
            if (MaxPrice == null)
            {
                throw new InvalidDataException("MaxPrice is a required property for ShipEstimate and cannot be null");
            }
            else
            {
                this.MaxPrice = MaxPrice;
            }
            // to ensure "VendorCountryCode" is required (not null)
            if (VendorCountryCode == null)
            {
                throw new InvalidDataException("VendorCountryCode is a required property for ShipEstimate and cannot be null");
            }
            else
            {
                this.VendorCountryCode = VendorCountryCode;
            }
            // to ensure "CanShipExpedited" is required (not null)
            if (CanShipExpedited == null)
            {
                throw new InvalidDataException("CanShipExpedited is a required property for ShipEstimate and cannot be null");
            }
            else
            {
                this.CanShipExpedited = CanShipExpedited;
            }
            // to ensure "EstShipDays" is required (not null)
            if (EstShipDays == null)
            {
                throw new InvalidDataException("EstShipDays is a required property for ShipEstimate and cannot be null");
            }
            else
            {
                this.EstShipDays = EstShipDays;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets MinPrice
        /// </summary>
        [DataMember(Name="MinPrice", EmitDefaultValue=false)]
        public ShipPrice MinPrice { get; set; }
    
        /// <summary>
        /// Gets or Sets MaxPrice
        /// </summary>
        [DataMember(Name="MaxPrice", EmitDefaultValue=false)]
        public ShipPrice MaxPrice { get; set; }
    
        /// <summary>
        /// Gets or Sets VendorCountryCode
        /// </summary>
        [DataMember(Name="VendorCountryCode", EmitDefaultValue=false)]
        public string VendorCountryCode { get; set; }
    
        /// <summary>
        /// Gets or Sets CanShipExpedited
        /// </summary>
        [DataMember(Name="CanShipExpedited", EmitDefaultValue=false)]
        public bool? CanShipExpedited { get; set; }
    
        /// <summary>
        /// Gets or Sets EstShipDays
        /// </summary>
        [DataMember(Name="EstShipDays", EmitDefaultValue=false)]
        public long? EstShipDays { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShipEstimate {\n");
            sb.Append("  MinPrice: ").Append(MinPrice).Append("\n");
            sb.Append("  MaxPrice: ").Append(MaxPrice).Append("\n");
            sb.Append("  VendorCountryCode: ").Append(VendorCountryCode).Append("\n");
            sb.Append("  CanShipExpedited: ").Append(CanShipExpedited).Append("\n");
            sb.Append("  EstShipDays: ").Append(EstShipDays).Append("\n");
            
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
            return this.Equals(obj as ShipEstimate);
        }

        /// <summary>
        /// Returns true if ShipEstimate instances are equal
        /// </summary>
        /// <param name="other">Instance of ShipEstimate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShipEstimate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MinPrice == other.MinPrice ||
                    this.MinPrice != null &&
                    this.MinPrice.Equals(other.MinPrice)
                ) && 
                (
                    this.MaxPrice == other.MaxPrice ||
                    this.MaxPrice != null &&
                    this.MaxPrice.Equals(other.MaxPrice)
                ) && 
                (
                    this.VendorCountryCode == other.VendorCountryCode ||
                    this.VendorCountryCode != null &&
                    this.VendorCountryCode.Equals(other.VendorCountryCode)
                ) && 
                (
                    this.CanShipExpedited == other.CanShipExpedited ||
                    this.CanShipExpedited != null &&
                    this.CanShipExpedited.Equals(other.CanShipExpedited)
                ) && 
                (
                    this.EstShipDays == other.EstShipDays ||
                    this.EstShipDays != null &&
                    this.EstShipDays.Equals(other.EstShipDays)
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
                
                if (this.MinPrice != null)
                    hash = hash * 59 + this.MinPrice.GetHashCode();
                
                if (this.MaxPrice != null)
                    hash = hash * 59 + this.MaxPrice.GetHashCode();
                
                if (this.VendorCountryCode != null)
                    hash = hash * 59 + this.VendorCountryCode.GetHashCode();
                
                if (this.CanShipExpedited != null)
                    hash = hash * 59 + this.CanShipExpedited.GetHashCode();
                
                if (this.EstShipDays != null)
                    hash = hash * 59 + this.EstShipDays.GetHashCode();
                
                return hash;
            }
        }

    }
}
