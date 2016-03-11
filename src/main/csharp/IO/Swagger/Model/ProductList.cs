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
    public partial class ProductList :  IEquatable<ProductList>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductList" /> class.
        /// Initializes a new instance of the <see cref="ProductList" />class.
        /// </summary>
        /// <param name="Products">Products (required).</param>

        public ProductList(List<Product> Products = null)
        {
            // to ensure "Products" is required (not null)
            if (Products == null)
            {
                throw new InvalidDataException("Products is a required property for ProductList and cannot be null");
            }
            else
            {
                this.Products = Products;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets Products
        /// </summary>
        [DataMember(Name="Products", EmitDefaultValue=false)]
        public List<Product> Products { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductList {\n");
            sb.Append("  Products: ").Append(Products).Append("\n");
            
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
            return this.Equals(obj as ProductList);
        }

        /// <summary>
        /// Returns true if ProductList instances are equal
        /// </summary>
        /// <param name="other">Instance of ProductList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductList other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Products == other.Products ||
                    this.Products != null &&
                    this.Products.SequenceEqual(other.Products)
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
                
                if (this.Products != null)
                    hash = hash * 59 + this.Products.GetHashCode();
                
                return hash;
            }
        }

    }
}
