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
    public partial class ProductBuildOption :  IEquatable<ProductBuildOption>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductBuildOption" /> class.
        /// Initializes a new instance of the <see cref="ProductBuildOption" />class.
        /// </summary>
        /// <param name="Name">Name (required).</param>
        /// <param name="ImageUrl">ImageUrl (required).</param>
        /// <param name="IsDefault">IsDefault (required).</param>
        /// <param name="Category">Category (required).</param>
        /// <param name="IsPartnerSpecific">IsPartnerSpecific (required).</param>
        /// <param name="Spaces">Spaces (required).</param>

        public ProductBuildOption(string Name = null, string ImageUrl = null, bool? IsDefault = null, string Category = null, bool? IsPartnerSpecific = null, List<ProductBuildInfoSpace> Spaces = null)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for ProductBuildOption and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "ImageUrl" is required (not null)
            if (ImageUrl == null)
            {
                throw new InvalidDataException("ImageUrl is a required property for ProductBuildOption and cannot be null");
            }
            else
            {
                this.ImageUrl = ImageUrl;
            }
            // to ensure "IsDefault" is required (not null)
            if (IsDefault == null)
            {
                throw new InvalidDataException("IsDefault is a required property for ProductBuildOption and cannot be null");
            }
            else
            {
                this.IsDefault = IsDefault;
            }
            // to ensure "Category" is required (not null)
            if (Category == null)
            {
                throw new InvalidDataException("Category is a required property for ProductBuildOption and cannot be null");
            }
            else
            {
                this.Category = Category;
            }
            // to ensure "IsPartnerSpecific" is required (not null)
            if (IsPartnerSpecific == null)
            {
                throw new InvalidDataException("IsPartnerSpecific is a required property for ProductBuildOption and cannot be null");
            }
            else
            {
                this.IsPartnerSpecific = IsPartnerSpecific;
            }
            // to ensure "Spaces" is required (not null)
            if (Spaces == null)
            {
                throw new InvalidDataException("Spaces is a required property for ProductBuildOption and cannot be null");
            }
            else
            {
                this.Spaces = Spaces;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets ImageUrl
        /// </summary>
        [DataMember(Name="ImageUrl", EmitDefaultValue=false)]
        public string ImageUrl { get; set; }
    
        /// <summary>
        /// Gets or Sets IsDefault
        /// </summary>
        [DataMember(Name="IsDefault", EmitDefaultValue=false)]
        public bool? IsDefault { get; set; }
    
        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="Category", EmitDefaultValue=false)]
        public string Category { get; set; }
    
        /// <summary>
        /// Gets or Sets IsPartnerSpecific
        /// </summary>
        [DataMember(Name="IsPartnerSpecific", EmitDefaultValue=false)]
        public bool? IsPartnerSpecific { get; set; }
    
        /// <summary>
        /// Gets or Sets Spaces
        /// </summary>
        [DataMember(Name="Spaces", EmitDefaultValue=false)]
        public List<ProductBuildInfoSpace> Spaces { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductBuildOption {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  IsPartnerSpecific: ").Append(IsPartnerSpecific).Append("\n");
            sb.Append("  Spaces: ").Append(Spaces).Append("\n");
            
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
            return this.Equals(obj as ProductBuildOption);
        }

        /// <summary>
        /// Returns true if ProductBuildOption instances are equal
        /// </summary>
        /// <param name="other">Instance of ProductBuildOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductBuildOption other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.ImageUrl == other.ImageUrl ||
                    this.ImageUrl != null &&
                    this.ImageUrl.Equals(other.ImageUrl)
                ) && 
                (
                    this.IsDefault == other.IsDefault ||
                    this.IsDefault != null &&
                    this.IsDefault.Equals(other.IsDefault)
                ) && 
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
                ) && 
                (
                    this.IsPartnerSpecific == other.IsPartnerSpecific ||
                    this.IsPartnerSpecific != null &&
                    this.IsPartnerSpecific.Equals(other.IsPartnerSpecific)
                ) && 
                (
                    this.Spaces == other.Spaces ||
                    this.Spaces != null &&
                    this.Spaces.SequenceEqual(other.Spaces)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.ImageUrl != null)
                    hash = hash * 59 + this.ImageUrl.GetHashCode();
                
                if (this.IsDefault != null)
                    hash = hash * 59 + this.IsDefault.GetHashCode();
                
                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();
                
                if (this.IsPartnerSpecific != null)
                    hash = hash * 59 + this.IsPartnerSpecific.GetHashCode();
                
                if (this.Spaces != null)
                    hash = hash * 59 + this.Spaces.GetHashCode();
                
                return hash;
            }
        }

    }
}
