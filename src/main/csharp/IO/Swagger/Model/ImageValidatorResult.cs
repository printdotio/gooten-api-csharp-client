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
    public partial class ImageValidatorResult :  IEquatable<ImageValidatorResult>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageValidatorResult" /> class.
        /// Initializes a new instance of the <see cref="ImageValidatorResult" />class.
        /// </summary>
        /// <param name="HadError">HadError (required).</param>
        /// <param name="Issues">Issues (required).</param>

        public ImageValidatorResult(bool? HadError = null, List<ValidationFailure> Issues = null)
        {
            // to ensure "HadError" is required (not null)
            if (HadError == null)
            {
                throw new InvalidDataException("HadError is a required property for ImageValidatorResult and cannot be null");
            }
            else
            {
                this.HadError = HadError;
            }
            // to ensure "Issues" is required (not null)
            if (Issues == null)
            {
                throw new InvalidDataException("Issues is a required property for ImageValidatorResult and cannot be null");
            }
            else
            {
                this.Issues = Issues;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets HadError
        /// </summary>
        [DataMember(Name="HadError", EmitDefaultValue=false)]
        public bool? HadError { get; set; }
    
        /// <summary>
        /// Gets or Sets Issues
        /// </summary>
        [DataMember(Name="Issues", EmitDefaultValue=false)]
        public List<ValidationFailure> Issues { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageValidatorResult {\n");
            sb.Append("  HadError: ").Append(HadError).Append("\n");
            sb.Append("  Issues: ").Append(Issues).Append("\n");
            
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
            return this.Equals(obj as ImageValidatorResult);
        }

        /// <summary>
        /// Returns true if ImageValidatorResult instances are equal
        /// </summary>
        /// <param name="other">Instance of ImageValidatorResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageValidatorResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.HadError == other.HadError ||
                    this.HadError != null &&
                    this.HadError.Equals(other.HadError)
                ) && 
                (
                    this.Issues == other.Issues ||
                    this.Issues != null &&
                    this.Issues.SequenceEqual(other.Issues)
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
                
                if (this.Issues != null)
                    hash = hash * 59 + this.Issues.GetHashCode();
                
                return hash;
            }
        }

    }
}
