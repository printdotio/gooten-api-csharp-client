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
    public partial class ShippingPricesResult :  IEquatable<ShippingPricesResult>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingPricesResult" /> class.
        /// Initializes a new instance of the <see cref="ShippingPricesResult" />class.
        /// </summary>
        /// <param name="Result">Result (required).</param>

        public ShippingPricesResult(List<ShipItem> Result = null)
        {
            // to ensure "Result" is required (not null)
            if (Result == null)
            {
                throw new InvalidDataException("Result is a required property for ShippingPricesResult and cannot be null");
            }
            else
            {
                this.Result = Result;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name="Result", EmitDefaultValue=false)]
        public List<ShipItem> Result { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShippingPricesResult {\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            
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
            return this.Equals(obj as ShippingPricesResult);
        }

        /// <summary>
        /// Returns true if ShippingPricesResult instances are equal
        /// </summary>
        /// <param name="other">Instance of ShippingPricesResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShippingPricesResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Result == other.Result ||
                    this.Result != null &&
                    this.Result.SequenceEqual(other.Result)
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
                
                if (this.Result != null)
                    hash = hash * 59 + this.Result.GetHashCode();
                
                return hash;
            }
        }

    }
}
