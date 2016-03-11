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
    public partial class OrderItemImage :  IEquatable<OrderItemImage>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderItemImage" /> class.
        /// Initializes a new instance of the <see cref="OrderItemImage" />class.
        /// </summary>
        /// <param name="Url">Url (required).</param>
        /// <param name="Index">Index (required).</param>
        /// <param name="ThumbnailUrl">ThumbnailUrl (required).</param>
        /// <param name="ManipCommand">ManipCommand (required).</param>
        /// <param name="SpaceId">SpaceId (required).</param>

        public OrderItemImage(string Url = null, long? Index = null, string ThumbnailUrl = null, string ManipCommand = null, string SpaceId = null)
        {
            // to ensure "Url" is required (not null)
            if (Url == null)
            {
                throw new InvalidDataException("Url is a required property for OrderItemImage and cannot be null");
            }
            else
            {
                this.Url = Url;
            }
            // to ensure "Index" is required (not null)
            if (Index == null)
            {
                throw new InvalidDataException("Index is a required property for OrderItemImage and cannot be null");
            }
            else
            {
                this.Index = Index;
            }
            // to ensure "ThumbnailUrl" is required (not null)
            if (ThumbnailUrl == null)
            {
                throw new InvalidDataException("ThumbnailUrl is a required property for OrderItemImage and cannot be null");
            }
            else
            {
                this.ThumbnailUrl = ThumbnailUrl;
            }
            // to ensure "ManipCommand" is required (not null)
            if (ManipCommand == null)
            {
                throw new InvalidDataException("ManipCommand is a required property for OrderItemImage and cannot be null");
            }
            else
            {
                this.ManipCommand = ManipCommand;
            }
            // to ensure "SpaceId" is required (not null)
            if (SpaceId == null)
            {
                throw new InvalidDataException("SpaceId is a required property for OrderItemImage and cannot be null");
            }
            else
            {
                this.SpaceId = SpaceId;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="Url", EmitDefaultValue=false)]
        public string Url { get; set; }
    
        /// <summary>
        /// Gets or Sets Index
        /// </summary>
        [DataMember(Name="Index", EmitDefaultValue=false)]
        public long? Index { get; set; }
    
        /// <summary>
        /// Gets or Sets ThumbnailUrl
        /// </summary>
        [DataMember(Name="ThumbnailUrl", EmitDefaultValue=false)]
        public string ThumbnailUrl { get; set; }
    
        /// <summary>
        /// Gets or Sets ManipCommand
        /// </summary>
        [DataMember(Name="ManipCommand", EmitDefaultValue=false)]
        public string ManipCommand { get; set; }
    
        /// <summary>
        /// Gets or Sets SpaceId
        /// </summary>
        [DataMember(Name="SpaceId", EmitDefaultValue=false)]
        public string SpaceId { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderItemImage {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  ThumbnailUrl: ").Append(ThumbnailUrl).Append("\n");
            sb.Append("  ManipCommand: ").Append(ManipCommand).Append("\n");
            sb.Append("  SpaceId: ").Append(SpaceId).Append("\n");
            
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
            return this.Equals(obj as OrderItemImage);
        }

        /// <summary>
        /// Returns true if OrderItemImage instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderItemImage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderItemImage other)
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
                    this.Index == other.Index ||
                    this.Index != null &&
                    this.Index.Equals(other.Index)
                ) && 
                (
                    this.ThumbnailUrl == other.ThumbnailUrl ||
                    this.ThumbnailUrl != null &&
                    this.ThumbnailUrl.Equals(other.ThumbnailUrl)
                ) && 
                (
                    this.ManipCommand == other.ManipCommand ||
                    this.ManipCommand != null &&
                    this.ManipCommand.Equals(other.ManipCommand)
                ) && 
                (
                    this.SpaceId == other.SpaceId ||
                    this.SpaceId != null &&
                    this.SpaceId.Equals(other.SpaceId)
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
                
                if (this.Index != null)
                    hash = hash * 59 + this.Index.GetHashCode();
                
                if (this.ThumbnailUrl != null)
                    hash = hash * 59 + this.ThumbnailUrl.GetHashCode();
                
                if (this.ManipCommand != null)
                    hash = hash * 59 + this.ManipCommand.GetHashCode();
                
                if (this.SpaceId != null)
                    hash = hash * 59 + this.SpaceId.GetHashCode();
                
                return hash;
            }
        }

    }
}
