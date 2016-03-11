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
    public partial class ProductBuildInfoResponse :  IEquatable<ProductBuildInfoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductBuildInfoResponse" /> class.
        /// Initializes a new instance of the <see cref="ProductBuildInfoResponse" />class.
        /// </summary>
        /// <param name="Options">Options (required).</param>

        public ProductBuildInfoResponse(List<ProductBuildOption> Options = null)
        {
            // to ensure "Options" is required (not null)
            if (Options == null)
            {
                throw new InvalidDataException("Options is a required property for ProductBuildInfoResponse and cannot be null");
            }
            else
            {
                this.Options = Options;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name="Options", EmitDefaultValue=false)]
        public List<ProductBuildOption> Options { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductBuildInfoResponse {\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            
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
            return this.Equals(obj as ProductBuildInfoResponse);
        }

        /// <summary>
        /// Returns true if ProductBuildInfoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ProductBuildInfoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductBuildInfoResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Options == other.Options ||
                    this.Options != null &&
                    this.Options.SequenceEqual(other.Options)
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
                
                if (this.Options != null)
                    hash = hash * 59 + this.Options.GetHashCode();
                
                return hash;
            }
        }

    }
}
