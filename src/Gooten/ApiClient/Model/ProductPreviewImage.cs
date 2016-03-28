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
    public partial class ProductPreviewImage :  IEquatable<ProductPreviewImage>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductPreviewImage" /> class.
        /// Initializes a new instance of the <see cref="ProductPreviewImage" />class.
        /// </summary>
        /// <param name="LayerId">LayerId (required).</param>
        /// <param name="Image">Image (required).</param>

        public ProductPreviewImage(string LayerId = null, ProductPreviewImageSpec Image = null)
        {
            // to ensure "LayerId" is required (not null)
            if (LayerId == null)
            {
                throw new InvalidDataException("LayerId is a required property for ProductPreviewImage and cannot be null");
            }
            else
            {
                this.LayerId = LayerId;
            }
            // to ensure "Image" is required (not null)
            if (Image == null)
            {
                throw new InvalidDataException("Image is a required property for ProductPreviewImage and cannot be null");
            }
            else
            {
                this.Image = Image;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets LayerId
        /// </summary>
        [DataMember(Name="LayerId", EmitDefaultValue=false)]
        public string LayerId { get; set; }
    
        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name="Image", EmitDefaultValue=false)]
        public ProductPreviewImageSpec Image { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductPreviewImage {\n");
            sb.Append("  LayerId: ").Append(LayerId).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            
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
            return this.Equals(obj as ProductPreviewImage);
        }

        /// <summary>
        /// Returns true if ProductPreviewImage instances are equal
        /// </summary>
        /// <param name="other">Instance of ProductPreviewImage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductPreviewImage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LayerId == other.LayerId ||
                    this.LayerId != null &&
                    this.LayerId.Equals(other.LayerId)
                ) && 
                (
                    this.Image == other.Image ||
                    this.Image != null &&
                    this.Image.Equals(other.Image)
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
                
                if (this.LayerId != null)
                    hash = hash * 59 + this.LayerId.GetHashCode();
                
                if (this.Image != null)
                    hash = hash * 59 + this.Image.GetHashCode();
                
                return hash;
            }
        }

    }


}
