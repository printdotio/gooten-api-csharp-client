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
    public partial class SkuQuantityPair :  IEquatable<SkuQuantityPair>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SkuQuantityPair" /> class.
        /// Initializes a new instance of the <see cref="SkuQuantityPair" />class.
        /// </summary>
        /// <param name="SKU">SKU (required).</param>
        /// <param name="Quantity">Quantity (required).</param>

        public SkuQuantityPair(string SKU = null, long? Quantity = null)
        {
            // to ensure "SKU" is required (not null)
            if (SKU == null)
            {
                throw new InvalidDataException("SKU is a required property for SkuQuantityPair and cannot be null");
            }
            else
            {
                this.SKU = SKU;
            }
            // to ensure "Quantity" is required (not null)
            if (Quantity == null)
            {
                throw new InvalidDataException("Quantity is a required property for SkuQuantityPair and cannot be null");
            }
            else
            {
                this.Quantity = Quantity;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets SKU
        /// </summary>
        [DataMember(Name="SKU", EmitDefaultValue=false)]
        public string SKU { get; set; }
    
        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="Quantity", EmitDefaultValue=false)]
        public long? Quantity { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SkuQuantityPair {\n");
            sb.Append("  SKU: ").Append(SKU).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            
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
            return this.Equals(obj as SkuQuantityPair);
        }

        /// <summary>
        /// Returns true if SkuQuantityPair instances are equal
        /// </summary>
        /// <param name="other">Instance of SkuQuantityPair to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SkuQuantityPair other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SKU == other.SKU ||
                    this.SKU != null &&
                    this.SKU.Equals(other.SKU)
                ) && 
                (
                    this.Quantity == other.Quantity ||
                    this.Quantity != null &&
                    this.Quantity.Equals(other.Quantity)
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
                
                if (this.SKU != null)
                    hash = hash * 59 + this.SKU.GetHashCode();
                
                if (this.Quantity != null)
                    hash = hash * 59 + this.Quantity.GetHashCode();
                
                return hash;
            }
        }

    }
}
