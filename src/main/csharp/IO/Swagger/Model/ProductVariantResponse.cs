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
    public partial class ProductVariantResponse :  IEquatable<ProductVariantResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductVariantResponse" /> class.
        /// Initializes a new instance of the <see cref="ProductVariantResponse" />class.
        /// </summary>
        /// <param name="ProductVariants">ProductVariants (required).</param>
        /// <param name="Options">Options (required).</param>

        public ProductVariantResponse(List<ProductVariant> ProductVariants = null, List<ProductOptionList> Options = null)
        {
            // to ensure "ProductVariants" is required (not null)
            if (ProductVariants == null)
            {
                throw new InvalidDataException("ProductVariants is a required property for ProductVariantResponse and cannot be null");
            }
            else
            {
                this.ProductVariants = ProductVariants;
            }
            // to ensure "Options" is required (not null)
            if (Options == null)
            {
                throw new InvalidDataException("Options is a required property for ProductVariantResponse and cannot be null");
            }
            else
            {
                this.Options = Options;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets ProductVariants
        /// </summary>
        [DataMember(Name="ProductVariants", EmitDefaultValue=false)]
        public List<ProductVariant> ProductVariants { get; set; }
    
        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name="Options", EmitDefaultValue=false)]
        public List<ProductOptionList> Options { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductVariantResponse {\n");
            sb.Append("  ProductVariants: ").Append(ProductVariants).Append("\n");
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
            return this.Equals(obj as ProductVariantResponse);
        }

        /// <summary>
        /// Returns true if ProductVariantResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ProductVariantResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductVariantResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ProductVariants == other.ProductVariants ||
                    this.ProductVariants != null &&
                    this.ProductVariants.SequenceEqual(other.ProductVariants)
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
                
                if (this.ProductVariants != null)
                    hash = hash * 59 + this.ProductVariants.GetHashCode();
                
                if (this.Options != null)
                    hash = hash * 59 + this.Options.GetHashCode();
                
                return hash;
            }
        }

    }
}
