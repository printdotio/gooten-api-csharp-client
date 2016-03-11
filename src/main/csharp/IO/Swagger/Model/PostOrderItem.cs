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
    public partial class PostOrderItem :  IEquatable<PostOrderItem>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PostOrderItem" /> class.
        /// Initializes a new instance of the <see cref="PostOrderItem" />class.
        /// </summary>
        /// <param name="Quantity">Quantity (required).</param>
        /// <param name="SKU">SKU (required).</param>
        /// <param name="ShipCarrierMethodId">ShipCarrierMethodId (required).</param>
        /// <param name="ShipType">If one does not want to pass a ShipCarrierMethodId of a specific shipping method, one can instead pass &#39;Standard&#39;, &#39;Overnight&#39;, or &#39;Expedited&#39; here. (required).</param>
        /// <param name="Images">Images (required).</param>
        /// <param name="SourceId">An optional place to pass in an ID for the OrderItem. (required).</param>
        /// <param name="Meta">An optional Map&lt;string,string&gt; of misc properties. (required).</param>

        public PostOrderItem(long? Quantity = null, string SKU = null, long? ShipCarrierMethodId = null, string ShipType = null, List<Image> Images = null, string SourceId = null, Meta Meta = null)
        {
            // to ensure "Quantity" is required (not null)
            if (Quantity == null)
            {
                throw new InvalidDataException("Quantity is a required property for PostOrderItem and cannot be null");
            }
            else
            {
                this.Quantity = Quantity;
            }
            // to ensure "SKU" is required (not null)
            if (SKU == null)
            {
                throw new InvalidDataException("SKU is a required property for PostOrderItem and cannot be null");
            }
            else
            {
                this.SKU = SKU;
            }
            // to ensure "ShipCarrierMethodId" is required (not null)
            if (ShipCarrierMethodId == null)
            {
                throw new InvalidDataException("ShipCarrierMethodId is a required property for PostOrderItem and cannot be null");
            }
            else
            {
                this.ShipCarrierMethodId = ShipCarrierMethodId;
            }
            // to ensure "ShipType" is required (not null)
            if (ShipType == null)
            {
                throw new InvalidDataException("ShipType is a required property for PostOrderItem and cannot be null");
            }
            else
            {
                this.ShipType = ShipType;
            }
            // to ensure "Images" is required (not null)
            if (Images == null)
            {
                throw new InvalidDataException("Images is a required property for PostOrderItem and cannot be null");
            }
            else
            {
                this.Images = Images;
            }
            // to ensure "SourceId" is required (not null)
            if (SourceId == null)
            {
                throw new InvalidDataException("SourceId is a required property for PostOrderItem and cannot be null");
            }
            else
            {
                this.SourceId = SourceId;
            }
            // to ensure "Meta" is required (not null)
            if (Meta == null)
            {
                throw new InvalidDataException("Meta is a required property for PostOrderItem and cannot be null");
            }
            else
            {
                this.Meta = Meta;
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
        /// If one does not want to pass a ShipCarrierMethodId of a specific shipping method, one can instead pass &#39;Standard&#39;, &#39;Overnight&#39;, or &#39;Expedited&#39; here.
        /// </summary>
        /// <value>If one does not want to pass a ShipCarrierMethodId of a specific shipping method, one can instead pass &#39;Standard&#39;, &#39;Overnight&#39;, or &#39;Expedited&#39; here.</value>
        [DataMember(Name="ShipType", EmitDefaultValue=false)]
        public string ShipType { get; set; }
    
        /// <summary>
        /// Gets or Sets Images
        /// </summary>
        [DataMember(Name="Images", EmitDefaultValue=false)]
        public List<Image> Images { get; set; }
    
        /// <summary>
        /// An optional place to pass in an ID for the OrderItem.
        /// </summary>
        /// <value>An optional place to pass in an ID for the OrderItem.</value>
        [DataMember(Name="SourceId", EmitDefaultValue=false)]
        public string SourceId { get; set; }
    
        /// <summary>
        /// An optional Map&lt;string,string&gt; of misc properties.
        /// </summary>
        /// <value>An optional Map&lt;string,string&gt; of misc properties.</value>
        [DataMember(Name="Meta", EmitDefaultValue=false)]
        public Meta Meta { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostOrderItem {\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  SKU: ").Append(SKU).Append("\n");
            sb.Append("  ShipCarrierMethodId: ").Append(ShipCarrierMethodId).Append("\n");
            sb.Append("  ShipType: ").Append(ShipType).Append("\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
            
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
            return this.Equals(obj as PostOrderItem);
        }

        /// <summary>
        /// Returns true if PostOrderItem instances are equal
        /// </summary>
        /// <param name="other">Instance of PostOrderItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostOrderItem other)
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
                    this.ShipType == other.ShipType ||
                    this.ShipType != null &&
                    this.ShipType.Equals(other.ShipType)
                ) && 
                (
                    this.Images == other.Images ||
                    this.Images != null &&
                    this.Images.SequenceEqual(other.Images)
                ) && 
                (
                    this.SourceId == other.SourceId ||
                    this.SourceId != null &&
                    this.SourceId.Equals(other.SourceId)
                ) && 
                (
                    this.Meta == other.Meta ||
                    this.Meta != null &&
                    this.Meta.Equals(other.Meta)
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
                
                if (this.ShipType != null)
                    hash = hash * 59 + this.ShipType.GetHashCode();
                
                if (this.Images != null)
                    hash = hash * 59 + this.Images.GetHashCode();
                
                if (this.SourceId != null)
                    hash = hash * 59 + this.SourceId.GetHashCode();
                
                if (this.Meta != null)
                    hash = hash * 59 + this.Meta.GetHashCode();
                
                return hash;
            }
        }

    }
}
