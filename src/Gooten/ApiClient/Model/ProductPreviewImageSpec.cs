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
    public partial class ProductPreviewImageSpec :  IEquatable<ProductPreviewImageSpec>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductPreviewImageSpec" /> class.
        /// Initializes a new instance of the <see cref="ProductPreviewImageSpec" />class.
        /// </summary>
        /// <param name="Url">Url (required).</param>
        /// <param name="X1">X1 (required).</param>
        /// <param name="X2">X2 (required).</param>
        /// <param name="Y1">Y1 (required).</param>
        /// <param name="Y2">Y2 (required).</param>

        public ProductPreviewImageSpec(string Url = null, long? X1 = null, long? X2 = null, long? Y1 = null, long? Y2 = null)
        {
            // to ensure "Url" is required (not null)
            if (Url == null)
            {
                throw new InvalidDataException("Url is a required property for ProductPreviewImageSpec and cannot be null");
            }
            else
            {
                this.Url = Url;
            }
            // to ensure "X1" is required (not null)
            if (X1 == null)
            {
                throw new InvalidDataException("X1 is a required property for ProductPreviewImageSpec and cannot be null");
            }
            else
            {
                this.X1 = X1;
            }
            // to ensure "X2" is required (not null)
            if (X2 == null)
            {
                throw new InvalidDataException("X2 is a required property for ProductPreviewImageSpec and cannot be null");
            }
            else
            {
                this.X2 = X2;
            }
            // to ensure "Y1" is required (not null)
            if (Y1 == null)
            {
                throw new InvalidDataException("Y1 is a required property for ProductPreviewImageSpec and cannot be null");
            }
            else
            {
                this.Y1 = Y1;
            }
            // to ensure "Y2" is required (not null)
            if (Y2 == null)
            {
                throw new InvalidDataException("Y2 is a required property for ProductPreviewImageSpec and cannot be null");
            }
            else
            {
                this.Y2 = Y2;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="Url", EmitDefaultValue=false)]
        public string Url { get; set; }
    
        /// <summary>
        /// Gets or Sets X1
        /// </summary>
        [DataMember(Name="X1", EmitDefaultValue=false)]
        public long? X1 { get; set; }
    
        /// <summary>
        /// Gets or Sets X2
        /// </summary>
        [DataMember(Name="X2", EmitDefaultValue=false)]
        public long? X2 { get; set; }
    
        /// <summary>
        /// Gets or Sets Y1
        /// </summary>
        [DataMember(Name="Y1", EmitDefaultValue=false)]
        public long? Y1 { get; set; }
    
        /// <summary>
        /// Gets or Sets Y2
        /// </summary>
        [DataMember(Name="Y2", EmitDefaultValue=false)]
        public long? Y2 { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductPreviewImageSpec {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  X1: ").Append(X1).Append("\n");
            sb.Append("  X2: ").Append(X2).Append("\n");
            sb.Append("  Y1: ").Append(Y1).Append("\n");
            sb.Append("  Y2: ").Append(Y2).Append("\n");
            
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
            return this.Equals(obj as ProductPreviewImageSpec);
        }

        /// <summary>
        /// Returns true if ProductPreviewImageSpec instances are equal
        /// </summary>
        /// <param name="other">Instance of ProductPreviewImageSpec to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductPreviewImageSpec other)
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
                    this.X1 == other.X1 ||
                    this.X1 != null &&
                    this.X1.Equals(other.X1)
                ) && 
                (
                    this.X2 == other.X2 ||
                    this.X2 != null &&
                    this.X2.Equals(other.X2)
                ) && 
                (
                    this.Y1 == other.Y1 ||
                    this.Y1 != null &&
                    this.Y1.Equals(other.Y1)
                ) && 
                (
                    this.Y2 == other.Y2 ||
                    this.Y2 != null &&
                    this.Y2.Equals(other.Y2)
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
                
                if (this.X1 != null)
                    hash = hash * 59 + this.X1.GetHashCode();
                
                if (this.X2 != null)
                    hash = hash * 59 + this.X2.GetHashCode();
                
                if (this.Y1 != null)
                    hash = hash * 59 + this.Y1.GetHashCode();
                
                if (this.Y2 != null)
                    hash = hash * 59 + this.Y2.GetHashCode();
                
                return hash;
            }
        }

    }


}
