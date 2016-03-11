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
    public partial class PreconfiguredItem :  IEquatable<PreconfiguredItem>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PreconfiguredItem" /> class.
        /// Initializes a new instance of the <see cref="PreconfiguredItem" />class.
        /// </summary>
        /// <param name="ProductId">The ID of the product this item references. (required).</param>
        /// <param name="ProductVariantSku">The sku of the product variant this item references. (required).</param>
        /// <param name="Preconfigurations">Preconfigurations (required).</param>

        public PreconfiguredItem(long? ProductId = null, string ProductVariantSku = null, List<Preconfiguration> Preconfigurations = null)
        {
            // to ensure "ProductId" is required (not null)
            if (ProductId == null)
            {
                throw new InvalidDataException("ProductId is a required property for PreconfiguredItem and cannot be null");
            }
            else
            {
                this.ProductId = ProductId;
            }
            // to ensure "ProductVariantSku" is required (not null)
            if (ProductVariantSku == null)
            {
                throw new InvalidDataException("ProductVariantSku is a required property for PreconfiguredItem and cannot be null");
            }
            else
            {
                this.ProductVariantSku = ProductVariantSku;
            }
            // to ensure "Preconfigurations" is required (not null)
            if (Preconfigurations == null)
            {
                throw new InvalidDataException("Preconfigurations is a required property for PreconfiguredItem and cannot be null");
            }
            else
            {
                this.Preconfigurations = Preconfigurations;
            }
            
        }
        
    
        /// <summary>
        /// The ID of the product this item references.
        /// </summary>
        /// <value>The ID of the product this item references.</value>
        [DataMember(Name="ProductId", EmitDefaultValue=false)]
        public long? ProductId { get; set; }
    
        /// <summary>
        /// The sku of the product variant this item references.
        /// </summary>
        /// <value>The sku of the product variant this item references.</value>
        [DataMember(Name="ProductVariantSku", EmitDefaultValue=false)]
        public string ProductVariantSku { get; set; }
    
        /// <summary>
        /// Gets or Sets Preconfigurations
        /// </summary>
        [DataMember(Name="Preconfigurations", EmitDefaultValue=false)]
        public List<Preconfiguration> Preconfigurations { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PreconfiguredItem {\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  ProductVariantSku: ").Append(ProductVariantSku).Append("\n");
            sb.Append("  Preconfigurations: ").Append(Preconfigurations).Append("\n");
            
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
            return this.Equals(obj as PreconfiguredItem);
        }

        /// <summary>
        /// Returns true if PreconfiguredItem instances are equal
        /// </summary>
        /// <param name="other">Instance of PreconfiguredItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PreconfiguredItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ProductId == other.ProductId ||
                    this.ProductId != null &&
                    this.ProductId.Equals(other.ProductId)
                ) && 
                (
                    this.ProductVariantSku == other.ProductVariantSku ||
                    this.ProductVariantSku != null &&
                    this.ProductVariantSku.Equals(other.ProductVariantSku)
                ) && 
                (
                    this.Preconfigurations == other.Preconfigurations ||
                    this.Preconfigurations != null &&
                    this.Preconfigurations.SequenceEqual(other.Preconfigurations)
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
                
                if (this.ProductId != null)
                    hash = hash * 59 + this.ProductId.GetHashCode();
                
                if (this.ProductVariantSku != null)
                    hash = hash * 59 + this.ProductVariantSku.GetHashCode();
                
                if (this.Preconfigurations != null)
                    hash = hash * 59 + this.Preconfigurations.GetHashCode();
                
                return hash;
            }
        }

    }
}
