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
    public partial class ProductPreviewResponse :  IEquatable<ProductPreviewResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductPreviewResponse" /> class.
        /// Initializes a new instance of the <see cref="ProductPreviewResponse" />class.
        /// </summary>
        /// <param name="Url">Url (required).</param>
        /// <param name="HadError">HadError (required).</param>
        /// <param name="ErrorMessage">ErrorMessage (required).</param>

        public ProductPreviewResponse(string Url = null, bool? HadError = null, string ErrorMessage = null)
        {
            // to ensure "Url" is required (not null)
            if (Url == null)
            {
                throw new InvalidDataException("Url is a required property for ProductPreviewResponse and cannot be null");
            }
            else
            {
                this.Url = Url;
            }
            // to ensure "HadError" is required (not null)
            if (HadError == null)
            {
                throw new InvalidDataException("HadError is a required property for ProductPreviewResponse and cannot be null");
            }
            else
            {
                this.HadError = HadError;
            }
            // to ensure "ErrorMessage" is required (not null)
            if (ErrorMessage == null)
            {
                throw new InvalidDataException("ErrorMessage is a required property for ProductPreviewResponse and cannot be null");
            }
            else
            {
                this.ErrorMessage = ErrorMessage;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="Url", EmitDefaultValue=false)]
        public string Url { get; set; }
    
        /// <summary>
        /// Gets or Sets HadError
        /// </summary>
        [DataMember(Name="HadError", EmitDefaultValue=false)]
        public bool? HadError { get; set; }
    
        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name="ErrorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductPreviewResponse {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  HadError: ").Append(HadError).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            
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
            return this.Equals(obj as ProductPreviewResponse);
        }

        /// <summary>
        /// Returns true if ProductPreviewResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ProductPreviewResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductPreviewResponse other)
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
                    this.HadError == other.HadError ||
                    this.HadError != null &&
                    this.HadError.Equals(other.HadError)
                ) && 
                (
                    this.ErrorMessage == other.ErrorMessage ||
                    this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(other.ErrorMessage)
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
                
                if (this.HadError != null)
                    hash = hash * 59 + this.HadError.GetHashCode();
                
                if (this.ErrorMessage != null)
                    hash = hash * 59 + this.ErrorMessage.GetHashCode();
                
                return hash;
            }
        }

    }
}
