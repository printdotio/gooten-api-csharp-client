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
    public partial class ImageValidationVm :  IEquatable<ImageValidationVm>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageValidationVm" /> class.
        /// Initializes a new instance of the <see cref="ImageValidationVm" />class.
        /// </summary>
        /// <param name="Sku">Sku (required).</param>
        /// <param name="Images">Images (required).</param>

        public ImageValidationVm(string Sku = null, List<ImageSizeVm> Images = null)
        {
            // to ensure "Sku" is required (not null)
            if (Sku == null)
            {
                throw new InvalidDataException("Sku is a required property for ImageValidationVm and cannot be null");
            }
            else
            {
                this.Sku = Sku;
            }
            // to ensure "Images" is required (not null)
            if (Images == null)
            {
                throw new InvalidDataException("Images is a required property for ImageValidationVm and cannot be null");
            }
            else
            {
                this.Images = Images;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets Sku
        /// </summary>
        [DataMember(Name="Sku", EmitDefaultValue=false)]
        public string Sku { get; set; }
    
        /// <summary>
        /// Gets or Sets Images
        /// </summary>
        [DataMember(Name="Images", EmitDefaultValue=false)]
        public List<ImageSizeVm> Images { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageValidationVm {\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
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
            return this.Equals(obj as ImageValidationVm);
        }

        /// <summary>
        /// Returns true if ImageValidationVm instances are equal
        /// </summary>
        /// <param name="other">Instance of ImageValidationVm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageValidationVm other)
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
                
                if (this.Sku != null)
                    hash = hash * 59 + this.Sku.GetHashCode();
                
                if (this.Images != null)
                    hash = hash * 59 + this.Images.GetHashCode();
                
                return hash;
            }
        }

    }


}
