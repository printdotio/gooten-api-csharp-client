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
    public partial class PreconfiguredProductsResponse :  IEquatable<PreconfiguredProductsResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PreconfiguredProductsResponse" /> class.
        /// Initializes a new instance of the <see cref="PreconfiguredProductsResponse" />class.
        /// </summary>
        /// <param name="PreconfiguredProducts">PreconfiguredProducts (required).</param>

        public PreconfiguredProductsResponse(List<PreconfiguredProduct> PreconfiguredProducts = null)
        {
            // to ensure "PreconfiguredProducts" is required (not null)
            if (PreconfiguredProducts == null)
            {
                throw new InvalidDataException("PreconfiguredProducts is a required property for PreconfiguredProductsResponse and cannot be null");
            }
            else
            {
                this.PreconfiguredProducts = PreconfiguredProducts;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets PreconfiguredProducts
        /// </summary>
        [DataMember(Name="PreconfiguredProducts", EmitDefaultValue=false)]
        public List<PreconfiguredProduct> PreconfiguredProducts { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PreconfiguredProductsResponse {\n");
            sb.Append("  PreconfiguredProducts: ").Append(PreconfiguredProducts).Append("\n");
            
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
            return this.Equals(obj as PreconfiguredProductsResponse);
        }

        /// <summary>
        /// Returns true if PreconfiguredProductsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PreconfiguredProductsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PreconfiguredProductsResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PreconfiguredProducts == other.PreconfiguredProducts ||
                    this.PreconfiguredProducts != null &&
                    this.PreconfiguredProducts.SequenceEqual(other.PreconfiguredProducts)
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
                
                if (this.PreconfiguredProducts != null)
                    hash = hash * 59 + this.PreconfiguredProducts.GetHashCode();
                
                return hash;
            }
        }

    }
}
