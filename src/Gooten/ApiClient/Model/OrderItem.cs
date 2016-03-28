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
    public partial class OrderItem :  IEquatable<OrderItem>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderItem" /> class.
        /// Initializes a new instance of the <see cref="OrderItem" />class.
        /// </summary>
        /// <param name="Quantity">Quantity (required).</param>
        /// <param name="SKU">SKU (required).</param>
        /// <param name="ShipCarrierMethodId">ShipCarrierMethodId (required).</param>
        /// <param name="Images">Images (required).</param>

        public OrderItem(long? Quantity = null, string SKU = null, long? ShipCarrierMethodId = null, List<OrderItemImage> Images = null)
        {
            // to ensure "Quantity" is required (not null)
            if (Quantity == null)
            {
                throw new InvalidDataException("Quantity is a required property for OrderItem and cannot be null");
            }
            else
            {
                this.Quantity = Quantity;
            }
            // to ensure "SKU" is required (not null)
            if (SKU == null)
            {
                throw new InvalidDataException("SKU is a required property for OrderItem and cannot be null");
            }
            else
            {
                this.SKU = SKU;
            }
            // to ensure "ShipCarrierMethodId" is required (not null)
            if (ShipCarrierMethodId == null)
            {
                throw new InvalidDataException("ShipCarrierMethodId is a required property for OrderItem and cannot be null");
            }
            else
            {
                this.ShipCarrierMethodId = ShipCarrierMethodId;
            }
            // to ensure "Images" is required (not null)
            if (Images == null)
            {
                throw new InvalidDataException("Images is a required property for OrderItem and cannot be null");
            }
            else
            {
                this.Images = Images;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="Quantity", EmitDefaultValue=false)]
        public long? Quantity { get; set; }
    
        /// <summary>
        /// Gets or Sets SKU
        /// </summary>
        [DataMember(Name="SKU", EmitDefaultValue=false)]
        public string SKU { get; set; }
    
        /// <summary>
        /// Gets or Sets ShipCarrierMethodId
        /// </summary>
        [DataMember(Name="ShipCarrierMethodId", EmitDefaultValue=false)]
        public long? ShipCarrierMethodId { get; set; }
    
        /// <summary>
        /// Gets or Sets Images
        /// </summary>
        [DataMember(Name="Images", EmitDefaultValue=false)]
        public List<OrderItemImage> Images { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderItem {\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  SKU: ").Append(SKU).Append("\n");
            sb.Append("  ShipCarrierMethodId: ").Append(ShipCarrierMethodId).Append("\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
            
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
            return this.Equals(obj as OrderItem);
        }

        /// <summary>
        /// Returns true if OrderItem instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Quantity == other.Quantity ||
                    this.Quantity != null &&
                    this.Quantity.Equals(other.Quantity)
                ) && 
                (
                    this.SKU == other.SKU ||
                    this.SKU != null &&
                    this.SKU.Equals(other.SKU)
                ) && 
                (
                    this.ShipCarrierMethodId == other.ShipCarrierMethodId ||
                    this.ShipCarrierMethodId != null &&
                    this.ShipCarrierMethodId.Equals(other.ShipCarrierMethodId)
                ) && 
                (
                    this.Images == other.Images ||
                    this.Images != null &&
                    this.Images.SequenceEqual(other.Images)
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
                
                if (this.Quantity != null)
                    hash = hash * 59 + this.Quantity.GetHashCode();
                
                if (this.SKU != null)
                    hash = hash * 59 + this.SKU.GetHashCode();
                
                if (this.ShipCarrierMethodId != null)
                    hash = hash * 59 + this.ShipCarrierMethodId.GetHashCode();
                
                if (this.Images != null)
                    hash = hash * 59 + this.Images.GetHashCode();
                
                return hash;
            }
        }

    }


}
