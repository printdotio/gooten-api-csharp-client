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
    public partial class ProductVariant :  IEquatable<ProductVariant>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductVariant" /> class.
        /// Initializes a new instance of the <see cref="ProductVariant" />class.
        /// </summary>
        /// <param name="Sku">Sku (required).</param>
        /// <param name="MaxImages">MaxImages (required).</param>
        /// <param name="HasTemplates">HasTemplates (required).</param>
        /// <param name="Options">Options (required).</param>

        public ProductVariant(string Sku = null, long? MaxImages = null, bool? HasTemplates = null, List<ProductOption> Options = null)
        {
            // to ensure "Sku" is required (not null)
            if (Sku == null)
            {
                throw new InvalidDataException("Sku is a required property for ProductVariant and cannot be null");
            }
            else
            {
                this.Sku = Sku;
            }
            // to ensure "MaxImages" is required (not null)
            if (MaxImages == null)
            {
                throw new InvalidDataException("MaxImages is a required property for ProductVariant and cannot be null");
            }
            else
            {
                this.MaxImages = MaxImages;
            }
            // to ensure "HasTemplates" is required (not null)
            if (HasTemplates == null)
            {
                throw new InvalidDataException("HasTemplates is a required property for ProductVariant and cannot be null");
            }
            else
            {
                this.HasTemplates = HasTemplates;
            }
            // to ensure "Options" is required (not null)
            if (Options == null)
            {
                throw new InvalidDataException("Options is a required property for ProductVariant and cannot be null");
            }
            else
            {
                this.Options = Options;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets Sku
        /// </summary>
        [DataMember(Name="Sku", EmitDefaultValue=false)]
        public string Sku { get; set; }
    
        /// <summary>
        /// Gets or Sets MaxImages
        /// </summary>
        [DataMember(Name="MaxImages", EmitDefaultValue=false)]
        public long? MaxImages { get; set; }
    
        /// <summary>
        /// Gets or Sets HasTemplates
        /// </summary>
        [DataMember(Name="HasTemplates", EmitDefaultValue=false)]
        public bool? HasTemplates { get; set; }
    
        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name="Options", EmitDefaultValue=false)]
        public List<ProductOption> Options { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductVariant {\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  MaxImages: ").Append(MaxImages).Append("\n");
            sb.Append("  HasTemplates: ").Append(HasTemplates).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            
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
            return this.Equals(obj as ProductVariant);
        }

        /// <summary>
        /// Returns true if ProductVariant instances are equal
        /// </summary>
        /// <param name="other">Instance of ProductVariant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductVariant other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Sku == other.Sku ||
                    this.Sku != null &&
                    this.Sku.Equals(other.Sku)
                ) && 
                (
                    this.MaxImages == other.MaxImages ||
                    this.MaxImages != null &&
                    this.MaxImages.Equals(other.MaxImages)
                ) && 
                (
                    this.HasTemplates == other.HasTemplates ||
                    this.HasTemplates != null &&
                    this.HasTemplates.Equals(other.HasTemplates)
                ) && 
                (
                    this.Options == other.Options ||
                    this.Options != null &&
                    this.Options.SequenceEqual(other.Options)
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
                
                if (this.Sku != null)
                    hash = hash * 59 + this.Sku.GetHashCode();
                
                if (this.MaxImages != null)
                    hash = hash * 59 + this.MaxImages.GetHashCode();
                
                if (this.HasTemplates != null)
                    hash = hash * 59 + this.HasTemplates.GetHashCode();
                
                if (this.Options != null)
                    hash = hash * 59 + this.Options.GetHashCode();
                
                return hash;
            }
        }

    }
}
