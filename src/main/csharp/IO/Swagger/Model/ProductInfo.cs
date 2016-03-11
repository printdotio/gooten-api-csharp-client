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
    public partial class ProductInfo :  IEquatable<ProductInfo>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductInfo" /> class.
        /// Initializes a new instance of the <see cref="ProductInfo" />class.
        /// </summary>
        /// <param name="ContentType">ContentType (required).</param>
        /// <param name="Content">Content (required).</param>
        /// <param name="Key">Key (required).</param>
        /// <param name="Index">The suggested ordering of the content about the product. (required).</param>

        public ProductInfo(string ContentType = null, List<string> Content = null, string Key = null, long? Index = null)
        {
            // to ensure "ContentType" is required (not null)
            if (ContentType == null)
            {
                throw new InvalidDataException("ContentType is a required property for ProductInfo and cannot be null");
            }
            else
            {
                this.ContentType = ContentType;
            }
            // to ensure "Content" is required (not null)
            if (Content == null)
            {
                throw new InvalidDataException("Content is a required property for ProductInfo and cannot be null");
            }
            else
            {
                this.Content = Content;
            }
            // to ensure "Key" is required (not null)
            if (Key == null)
            {
                throw new InvalidDataException("Key is a required property for ProductInfo and cannot be null");
            }
            else
            {
                this.Key = Key;
            }
            // to ensure "Index" is required (not null)
            if (Index == null)
            {
                throw new InvalidDataException("Index is a required property for ProductInfo and cannot be null");
            }
            else
            {
                this.Index = Index;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets ContentType
        /// </summary>
        [DataMember(Name="ContentType", EmitDefaultValue=false)]
        public string ContentType { get; set; }
    
        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name="Content", EmitDefaultValue=false)]
        public List<string> Content { get; set; }
    
        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name="Key", EmitDefaultValue=false)]
        public string Key { get; set; }
    
        /// <summary>
        /// The suggested ordering of the content about the product.
        /// </summary>
        /// <value>The suggested ordering of the content about the product.</value>
        [DataMember(Name="Index", EmitDefaultValue=false)]
        public long? Index { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductInfo {\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            
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
            return this.Equals(obj as ProductInfo);
        }

        /// <summary>
        /// Returns true if ProductInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of ProductInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ContentType == other.ContentType ||
                    this.ContentType != null &&
                    this.ContentType.Equals(other.ContentType)
                ) && 
                (
                    this.Content == other.Content ||
                    this.Content != null &&
                    this.Content.SequenceEqual(other.Content)
                ) && 
                (
                    this.Key == other.Key ||
                    this.Key != null &&
                    this.Key.Equals(other.Key)
                ) && 
                (
                    this.Index == other.Index ||
                    this.Index != null &&
                    this.Index.Equals(other.Index)
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
                
                if (this.ContentType != null)
                    hash = hash * 59 + this.ContentType.GetHashCode();
                
                if (this.Content != null)
                    hash = hash * 59 + this.Content.GetHashCode();
                
                if (this.Key != null)
                    hash = hash * 59 + this.Key.GetHashCode();
                
                if (this.Index != null)
                    hash = hash * 59 + this.Index.GetHashCode();
                
                return hash;
            }
        }

    }
}
