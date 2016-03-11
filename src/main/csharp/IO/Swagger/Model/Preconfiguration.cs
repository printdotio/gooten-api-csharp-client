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
    public partial class Preconfiguration :  IEquatable<Preconfiguration>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Preconfiguration" /> class.
        /// Initializes a new instance of the <see cref="Preconfiguration" />class.
        /// </summary>
        /// <param name="SpaceId">Required only for multi-image items. The ID of the space where an image is to be placed. One can attain the SpaceId via inspecting the template data. (required).</param>
        /// <param name="Url">The url of the image to be placed in the referenced layer. (required).</param>

        public Preconfiguration(string SpaceId = null, string Url = null)
        {
            // to ensure "SpaceId" is required (not null)
            if (SpaceId == null)
            {
                throw new InvalidDataException("SpaceId is a required property for Preconfiguration and cannot be null");
            }
            else
            {
                this.SpaceId = SpaceId;
            }
            // to ensure "Url" is required (not null)
            if (Url == null)
            {
                throw new InvalidDataException("Url is a required property for Preconfiguration and cannot be null");
            }
            else
            {
                this.Url = Url;
            }
            
        }
        
    
        /// <summary>
        /// Required only for multi-image items. The ID of the space where an image is to be placed. One can attain the SpaceId via inspecting the template data.
        /// </summary>
        /// <value>Required only for multi-image items. The ID of the space where an image is to be placed. One can attain the SpaceId via inspecting the template data.</value>
        [DataMember(Name="SpaceId", EmitDefaultValue=false)]
        public string SpaceId { get; set; }
    
        /// <summary>
        /// The url of the image to be placed in the referenced layer.
        /// </summary>
        /// <value>The url of the image to be placed in the referenced layer.</value>
        [DataMember(Name="Url", EmitDefaultValue=false)]
        public string Url { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Preconfiguration {\n");
            sb.Append("  SpaceId: ").Append(SpaceId).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            
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
            return this.Equals(obj as Preconfiguration);
        }

        /// <summary>
        /// Returns true if Preconfiguration instances are equal
        /// </summary>
        /// <param name="other">Instance of Preconfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Preconfiguration other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SpaceId == other.SpaceId ||
                    this.SpaceId != null &&
                    this.SpaceId.Equals(other.SpaceId)
                ) && 
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
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
                
                if (this.SpaceId != null)
                    hash = hash * 59 + this.SpaceId.GetHashCode();
                
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
                
                return hash;
            }
        }

    }
}
