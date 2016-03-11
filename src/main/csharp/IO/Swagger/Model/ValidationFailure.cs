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
    public partial class ValidationFailure :  IEquatable<ValidationFailure>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationFailure" /> class.
        /// Initializes a new instance of the <see cref="ValidationFailure" />class.
        /// </summary>
        /// <param name="PropertyName">PropertyName (required).</param>
        /// <param name="ErrorMessage">ErrorMessage (required).</param>
        /// <param name="AttemptedValue">AttemptedValue (required).</param>

        public ValidationFailure(string PropertyName = null, string ErrorMessage = null, string AttemptedValue = null)
        {
            // to ensure "PropertyName" is required (not null)
            if (PropertyName == null)
            {
                throw new InvalidDataException("PropertyName is a required property for ValidationFailure and cannot be null");
            }
            else
            {
                this.PropertyName = PropertyName;
            }
            // to ensure "ErrorMessage" is required (not null)
            if (ErrorMessage == null)
            {
                throw new InvalidDataException("ErrorMessage is a required property for ValidationFailure and cannot be null");
            }
            else
            {
                this.ErrorMessage = ErrorMessage;
            }
            // to ensure "AttemptedValue" is required (not null)
            if (AttemptedValue == null)
            {
                throw new InvalidDataException("AttemptedValue is a required property for ValidationFailure and cannot be null");
            }
            else
            {
                this.AttemptedValue = AttemptedValue;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets PropertyName
        /// </summary>
        [DataMember(Name="PropertyName", EmitDefaultValue=false)]
        public string PropertyName { get; set; }
    
        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name="ErrorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }
    
        /// <summary>
        /// Gets or Sets AttemptedValue
        /// </summary>
        [DataMember(Name="AttemptedValue", EmitDefaultValue=false)]
        public string AttemptedValue { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidationFailure {\n");
            sb.Append("  PropertyName: ").Append(PropertyName).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  AttemptedValue: ").Append(AttemptedValue).Append("\n");
            
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
            return this.Equals(obj as ValidationFailure);
        }

        /// <summary>
        /// Returns true if ValidationFailure instances are equal
        /// </summary>
        /// <param name="other">Instance of ValidationFailure to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidationFailure other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PropertyName == other.PropertyName ||
                    this.PropertyName != null &&
                    this.PropertyName.Equals(other.PropertyName)
                ) && 
                (
                    this.ErrorMessage == other.ErrorMessage ||
                    this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(other.ErrorMessage)
                ) && 
                (
                    this.AttemptedValue == other.AttemptedValue ||
                    this.AttemptedValue != null &&
                    this.AttemptedValue.Equals(other.AttemptedValue)
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
                
                if (this.PropertyName != null)
                    hash = hash * 59 + this.PropertyName.GetHashCode();
                
                if (this.ErrorMessage != null)
                    hash = hash * 59 + this.ErrorMessage.GetHashCode();
                
                if (this.AttemptedValue != null)
                    hash = hash * 59 + this.AttemptedValue.GetHashCode();
                
                return hash;
            }
        }

    }
}
