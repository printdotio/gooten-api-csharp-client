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
    public partial class OrderStatusUpdateResult :  IEquatable<OrderStatusUpdateResult>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderStatusUpdateResult" /> class.
        /// Initializes a new instance of the <see cref="OrderStatusUpdateResult" />class.
        /// </summary>
        /// <param name="HadError">HadError (required).</param>

        public OrderStatusUpdateResult(bool? HadError = null)
        {
            // to ensure "HadError" is required (not null)
            if (HadError == null)
            {
                throw new InvalidDataException("HadError is a required property for OrderStatusUpdateResult and cannot be null");
            }
            else
            {
                this.HadError = HadError;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets HadError
        /// </summary>
        [DataMember(Name="HadError", EmitDefaultValue=false)]
        public bool? HadError { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderStatusUpdateResult {\n");
            sb.Append("  HadError: ").Append(HadError).Append("\n");
            
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
            return this.Equals(obj as OrderStatusUpdateResult);
        }

        /// <summary>
        /// Returns true if OrderStatusUpdateResult instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderStatusUpdateResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderStatusUpdateResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.HadError == other.HadError ||
                    this.HadError != null &&
                    this.HadError.Equals(other.HadError)
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
                
                if (this.HadError != null)
                    hash = hash * 59 + this.HadError.GetHashCode();
                
                return hash;
            }
        }

    }


}
