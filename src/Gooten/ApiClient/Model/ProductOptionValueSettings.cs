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
    public partial class ProductOptionValueSettings :  IEquatable<ProductOptionValueSettings>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductOptionValueSettings" /> class.
        /// Initializes a new instance of the <see cref="ProductOptionValueSettings" />class.
        /// </summary>
        /// <param name="IconUrl">IconUrl (required).</param>
        /// <param name="IconType">IconType (required).</param>
        /// <param name="ColorRgba">ColorRgba (required).</param>

        public ProductOptionValueSettings(string IconUrl = null, string IconType = null, string ColorRgba = null)
        {
            // to ensure "IconUrl" is required (not null)
            if (IconUrl == null)
            {
                throw new InvalidDataException("IconUrl is a required property for ProductOptionValueSettings and cannot be null");
            }
            else
            {
                this.IconUrl = IconUrl;
            }
            // to ensure "IconType" is required (not null)
            if (IconType == null)
            {
                throw new InvalidDataException("IconType is a required property for ProductOptionValueSettings and cannot be null");
            }
            else
            {
                this.IconType = IconType;
            }
            // to ensure "ColorRgba" is required (not null)
            if (ColorRgba == null)
            {
                throw new InvalidDataException("ColorRgba is a required property for ProductOptionValueSettings and cannot be null");
            }
            else
            {
                this.ColorRgba = ColorRgba;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets IconUrl
        /// </summary>
        [DataMember(Name="IconUrl", EmitDefaultValue=false)]
        public string IconUrl { get; set; }
    
        /// <summary>
        /// Gets or Sets IconType
        /// </summary>
        [DataMember(Name="IconType", EmitDefaultValue=false)]
        public string IconType { get; set; }
    
        /// <summary>
        /// Gets or Sets ColorRgba
        /// </summary>
        [DataMember(Name="ColorRgba", EmitDefaultValue=false)]
        public string ColorRgba { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductOptionValueSettings {\n");
            sb.Append("  IconUrl: ").Append(IconUrl).Append("\n");
            sb.Append("  IconType: ").Append(IconType).Append("\n");
            sb.Append("  ColorRgba: ").Append(ColorRgba).Append("\n");
            
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
            return this.Equals(obj as ProductOptionValueSettings);
        }

        /// <summary>
        /// Returns true if ProductOptionValueSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of ProductOptionValueSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductOptionValueSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IconUrl == other.IconUrl ||
                    this.IconUrl != null &&
                    this.IconUrl.Equals(other.IconUrl)
                ) && 
                (
                    this.IconType == other.IconType ||
                    this.IconType != null &&
                    this.IconType.Equals(other.IconType)
                ) && 
                (
                    this.ColorRgba == other.ColorRgba ||
                    this.ColorRgba != null &&
                    this.ColorRgba.Equals(other.ColorRgba)
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
                
                if (this.IconUrl != null)
                    hash = hash * 59 + this.IconUrl.GetHashCode();
                
                if (this.IconType != null)
                    hash = hash * 59 + this.IconType.GetHashCode();
                
                if (this.ColorRgba != null)
                    hash = hash * 59 + this.ColorRgba.GetHashCode();
                
                return hash;
            }
        }

    }


}
