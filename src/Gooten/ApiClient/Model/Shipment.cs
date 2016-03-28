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
    public partial class Shipment :  IEquatable<Shipment>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Shipment" /> class.
        /// Initializes a new instance of the <see cref="Shipment" />class.
        /// </summary>
        /// <param name="TrackingNumber">TrackingNumber (required).</param>
        /// <param name="TrackingUrl">TrackingUrl (required).</param>
        /// <param name="ShipCarrierName">ShipCarrierName (required).</param>

        public Shipment(string TrackingNumber = null, string TrackingUrl = null, string ShipCarrierName = null)
        {
            // to ensure "TrackingNumber" is required (not null)
            if (TrackingNumber == null)
            {
                throw new InvalidDataException("TrackingNumber is a required property for Shipment and cannot be null");
            }
            else
            {
                this.TrackingNumber = TrackingNumber;
            }
            // to ensure "TrackingUrl" is required (not null)
            if (TrackingUrl == null)
            {
                throw new InvalidDataException("TrackingUrl is a required property for Shipment and cannot be null");
            }
            else
            {
                this.TrackingUrl = TrackingUrl;
            }
            // to ensure "ShipCarrierName" is required (not null)
            if (ShipCarrierName == null)
            {
                throw new InvalidDataException("ShipCarrierName is a required property for Shipment and cannot be null");
            }
            else
            {
                this.ShipCarrierName = ShipCarrierName;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets TrackingNumber
        /// </summary>
        [DataMember(Name="TrackingNumber", EmitDefaultValue=false)]
        public string TrackingNumber { get; set; }
    
        /// <summary>
        /// Gets or Sets TrackingUrl
        /// </summary>
        [DataMember(Name="TrackingUrl", EmitDefaultValue=false)]
        public string TrackingUrl { get; set; }
    
        /// <summary>
        /// Gets or Sets ShipCarrierName
        /// </summary>
        [DataMember(Name="ShipCarrierName", EmitDefaultValue=false)]
        public string ShipCarrierName { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Shipment {\n");
            sb.Append("  TrackingNumber: ").Append(TrackingNumber).Append("\n");
            sb.Append("  TrackingUrl: ").Append(TrackingUrl).Append("\n");
            sb.Append("  ShipCarrierName: ").Append(ShipCarrierName).Append("\n");
            
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
            return this.Equals(obj as Shipment);
        }

        /// <summary>
        /// Returns true if Shipment instances are equal
        /// </summary>
        /// <param name="other">Instance of Shipment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Shipment other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TrackingNumber == other.TrackingNumber ||
                    this.TrackingNumber != null &&
                    this.TrackingNumber.Equals(other.TrackingNumber)
                ) && 
                (
                    this.TrackingUrl == other.TrackingUrl ||
                    this.TrackingUrl != null &&
                    this.TrackingUrl.Equals(other.TrackingUrl)
                ) && 
                (
                    this.ShipCarrierName == other.ShipCarrierName ||
                    this.ShipCarrierName != null &&
                    this.ShipCarrierName.Equals(other.ShipCarrierName)
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
                
                if (this.TrackingNumber != null)
                    hash = hash * 59 + this.TrackingNumber.GetHashCode();
                
                if (this.TrackingUrl != null)
                    hash = hash * 59 + this.TrackingUrl.GetHashCode();
                
                if (this.ShipCarrierName != null)
                    hash = hash * 59 + this.ShipCarrierName.GetHashCode();
                
                return hash;
            }
        }

    }


}
