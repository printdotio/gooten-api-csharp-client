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
    public partial class ImageSizeVm :  IEquatable<ImageSizeVm>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSizeVm" /> class.
        /// Initializes a new instance of the <see cref="ImageSizeVm" />class.
        /// </summary>
        /// <param name="SpaceId">SpaceId (required).</param>
        /// <param name="Width">Width (required).</param>
        /// <param name="Height">Height (required).</param>

        public ImageSizeVm(string SpaceId = null, long? Width = null, long? Height = null)
        {
            // to ensure "SpaceId" is required (not null)
            if (SpaceId == null)
            {
                throw new InvalidDataException("SpaceId is a required property for ImageSizeVm and cannot be null");
            }
            else
            {
                this.SpaceId = SpaceId;
            }
            // to ensure "Width" is required (not null)
            if (Width == null)
            {
                throw new InvalidDataException("Width is a required property for ImageSizeVm and cannot be null");
            }
            else
            {
                this.Width = Width;
            }
            // to ensure "Height" is required (not null)
            if (Height == null)
            {
                throw new InvalidDataException("Height is a required property for ImageSizeVm and cannot be null");
            }
            else
            {
                this.Height = Height;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets SpaceId
        /// </summary>
        [DataMember(Name="SpaceId", EmitDefaultValue=false)]
        public string SpaceId { get; set; }
    
        /// <summary>
        /// Gets or Sets Width
        /// </summary>
        [DataMember(Name="Width", EmitDefaultValue=false)]
        public long? Width { get; set; }
    
        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        [DataMember(Name="Height", EmitDefaultValue=false)]
        public long? Height { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageSizeVm {\n");
            sb.Append("  SpaceId: ").Append(SpaceId).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            
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
            return this.Equals(obj as ImageSizeVm);
        }

        /// <summary>
        /// Returns true if ImageSizeVm instances are equal
        /// </summary>
        /// <param name="other">Instance of ImageSizeVm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageSizeVm other)
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
                    this.Width == other.Width ||
                    this.Width != null &&
                    this.Width.Equals(other.Width)
                ) && 
                (
                    this.Height == other.Height ||
                    this.Height != null &&
                    this.Height.Equals(other.Height)
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
                
                if (this.Width != null)
                    hash = hash * 59 + this.Width.GetHashCode();
                
                if (this.Height != null)
                    hash = hash * 59 + this.Height.GetHashCode();
                
                return hash;
            }
        }

    }
}
