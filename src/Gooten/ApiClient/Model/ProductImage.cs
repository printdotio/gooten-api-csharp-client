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
    public partial class ProductImage :  IEquatable<ProductImage>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductImage" /> class.
        /// Initializes a new instance of the <see cref="ProductImage" />class.
        /// </summary>
        /// <param name="Url">Url (required).</param>
        /// <param name="Description">Description (required).</param>
        /// <param name="Index">Index (required).</param>
        /// <param name="Id">Id (required).</param>
        /// <param name="ImageTypes">ImageTypes (required).</param>

        public ProductImage(string Url = null, string Description = null, long? Index = null, string Id = null, List<string> ImageTypes = null)
        {
            // to ensure "Url" is required (not null)
            if (Url == null)
            {
                throw new InvalidDataException("Url is a required property for ProductImage and cannot be null");
            }
            else
            {
                this.Url = Url;
            }
            // to ensure "Description" is required (not null)
            if (Description == null)
            {
                throw new InvalidDataException("Description is a required property for ProductImage and cannot be null");
            }
            else
            {
                this.Description = Description;
            }
            // to ensure "Index" is required (not null)
            if (Index == null)
            {
                throw new InvalidDataException("Index is a required property for ProductImage and cannot be null");
            }
            else
            {
                this.Index = Index;
            }
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for ProductImage and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "ImageTypes" is required (not null)
            if (ImageTypes == null)
            {
                throw new InvalidDataException("ImageTypes is a required property for ProductImage and cannot be null");
            }
            else
            {
                this.ImageTypes = ImageTypes;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="Url", EmitDefaultValue=false)]
        public string Url { get; set; }
    
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or Sets Index
        /// </summary>
        [DataMember(Name="Index", EmitDefaultValue=false)]
        public long? Index { get; set; }
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or Sets ImageTypes
        /// </summary>
        [DataMember(Name="ImageTypes", EmitDefaultValue=false)]
        public List<string> ImageTypes { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductImage {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ImageTypes: ").Append(ImageTypes).Append("\n");
            
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
            return this.Equals(obj as ProductImage);
        }

        /// <summary>
        /// Returns true if ProductImage instances are equal
        /// </summary>
        /// <param name="other">Instance of ProductImage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductImage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Index == other.Index ||
                    this.Index != null &&
                    this.Index.Equals(other.Index)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.ImageTypes == other.ImageTypes ||
                    this.ImageTypes != null &&
                    this.ImageTypes.SequenceEqual(other.ImageTypes)
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
                
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.Index != null)
                    hash = hash * 59 + this.Index.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.ImageTypes != null)
                    hash = hash * 59 + this.ImageTypes.GetHashCode();
                
                return hash;
            }
        }

    }


}
