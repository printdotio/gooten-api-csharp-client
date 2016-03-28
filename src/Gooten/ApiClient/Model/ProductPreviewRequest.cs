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
    public partial class ProductPreviewRequest :  IEquatable<ProductPreviewRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductPreviewRequest" /> class.
        /// Initializes a new instance of the <see cref="ProductPreviewRequest" />class.
        /// </summary>
        /// <param name="Sku">Sku (required).</param>
        /// <param name="Template">Template (required).</param>
        /// <param name="Images">Images (required).</param>
        /// <param name="MaxHeight">Max height of the resultant image. Defaults to 500px (required).</param>
        /// <param name="MaxWidth">Max width of the resultant image. Defaults to 500px (required).</param>

        public ProductPreviewRequest(string Sku = null, string Template = null, List<ProductPreviewImage> Images = null, long? MaxHeight = null, long? MaxWidth = null)
        {
            // to ensure "Sku" is required (not null)
            if (Sku == null)
            {
                throw new InvalidDataException("Sku is a required property for ProductPreviewRequest and cannot be null");
            }
            else
            {
                this.Sku = Sku;
            }
            // to ensure "Template" is required (not null)
            if (Template == null)
            {
                throw new InvalidDataException("Template is a required property for ProductPreviewRequest and cannot be null");
            }
            else
            {
                this.Template = Template;
            }
            // to ensure "Images" is required (not null)
            if (Images == null)
            {
                throw new InvalidDataException("Images is a required property for ProductPreviewRequest and cannot be null");
            }
            else
            {
                this.Images = Images;
            }
            // to ensure "MaxHeight" is required (not null)
            if (MaxHeight == null)
            {
                throw new InvalidDataException("MaxHeight is a required property for ProductPreviewRequest and cannot be null");
            }
            else
            {
                this.MaxHeight = MaxHeight;
            }
            // to ensure "MaxWidth" is required (not null)
            if (MaxWidth == null)
            {
                throw new InvalidDataException("MaxWidth is a required property for ProductPreviewRequest and cannot be null");
            }
            else
            {
                this.MaxWidth = MaxWidth;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets Sku
        /// </summary>
        [DataMember(Name="Sku", EmitDefaultValue=false)]
        public string Sku { get; set; }
    
        /// <summary>
        /// Gets or Sets Template
        /// </summary>
        [DataMember(Name="Template", EmitDefaultValue=false)]
        public string Template { get; set; }
    
        /// <summary>
        /// Gets or Sets Images
        /// </summary>
        [DataMember(Name="Images", EmitDefaultValue=false)]
        public List<ProductPreviewImage> Images { get; set; }
    
        /// <summary>
        /// Max height of the resultant image. Defaults to 500px
        /// </summary>
        /// <value>Max height of the resultant image. Defaults to 500px</value>
        [DataMember(Name="MaxHeight", EmitDefaultValue=false)]
        public long? MaxHeight { get; set; }
    
        /// <summary>
        /// Max width of the resultant image. Defaults to 500px
        /// </summary>
        /// <value>Max width of the resultant image. Defaults to 500px</value>
        [DataMember(Name="MaxWidth", EmitDefaultValue=false)]
        public long? MaxWidth { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductPreviewRequest {\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
            sb.Append("  MaxHeight: ").Append(MaxHeight).Append("\n");
            sb.Append("  MaxWidth: ").Append(MaxWidth).Append("\n");
            
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
            return this.Equals(obj as ProductPreviewRequest);
        }

        /// <summary>
        /// Returns true if ProductPreviewRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ProductPreviewRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductPreviewRequest other)
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
                    this.Template == other.Template ||
                    this.Template != null &&
                    this.Template.Equals(other.Template)
                ) && 
                (
                    this.Images == other.Images ||
                    this.Images != null &&
                    this.Images.SequenceEqual(other.Images)
                ) && 
                (
                    this.MaxHeight == other.MaxHeight ||
                    this.MaxHeight != null &&
                    this.MaxHeight.Equals(other.MaxHeight)
                ) && 
                (
                    this.MaxWidth == other.MaxWidth ||
                    this.MaxWidth != null &&
                    this.MaxWidth.Equals(other.MaxWidth)
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
                
                if (this.Template != null)
                    hash = hash * 59 + this.Template.GetHashCode();
                
                if (this.Images != null)
                    hash = hash * 59 + this.Images.GetHashCode();
                
                if (this.MaxHeight != null)
                    hash = hash * 59 + this.MaxHeight.GetHashCode();
                
                if (this.MaxWidth != null)
                    hash = hash * 59 + this.MaxWidth.GetHashCode();
                
                return hash;
            }
        }

    }


}
