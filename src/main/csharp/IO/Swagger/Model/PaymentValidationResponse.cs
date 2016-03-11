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
    public partial class PaymentValidationResponse :  IEquatable<PaymentValidationResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentValidationResponse" /> class.
        /// Initializes a new instance of the <see cref="PaymentValidationResponse" />class.
        /// </summary>
        /// <param name="IsValid">IsValid (required).</param>

        public PaymentValidationResponse(bool? IsValid = null)
        {
            // to ensure "IsValid" is required (not null)
            if (IsValid == null)
            {
                throw new InvalidDataException("IsValid is a required property for PaymentValidationResponse and cannot be null");
            }
            else
            {
                this.IsValid = IsValid;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets IsValid
        /// </summary>
        [DataMember(Name="IsValid", EmitDefaultValue=false)]
        public bool? IsValid { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentValidationResponse {\n");
            sb.Append("  IsValid: ").Append(IsValid).Append("\n");
            
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
            return this.Equals(obj as PaymentValidationResponse);
        }

        /// <summary>
        /// Returns true if PaymentValidationResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentValidationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentValidationResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IsValid == other.IsValid ||
                    this.IsValid != null &&
                    this.IsValid.Equals(other.IsValid)
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
                
                if (this.IsValid != null)
                    hash = hash * 59 + this.IsValid.GetHashCode();
                
                return hash;
            }
        }

    }
}
