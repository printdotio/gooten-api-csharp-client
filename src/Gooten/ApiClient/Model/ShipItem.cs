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
    public partial class ShipItem :  IEquatable<ShipItem>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipItem" /> class.
        /// Initializes a new instance of the <see cref="ShipItem" />class.
        /// </summary>
        /// <param name="SKUs">SKUs (required).</param>
        /// <param name="ShipOptions">ShipOptions (required).</param>

        public ShipItem(List<string> SKUs = null, List<ShipOption> ShipOptions = null)
        {
            // to ensure "SKUs" is required (not null)
            if (SKUs == null)
            {
                throw new InvalidDataException("SKUs is a required property for ShipItem and cannot be null");
            }
            else
            {
                this.SKUs = SKUs;
            }
            // to ensure "ShipOptions" is required (not null)
            if (ShipOptions == null)
            {
                throw new InvalidDataException("ShipOptions is a required property for ShipItem and cannot be null");
            }
            else
            {
                this.ShipOptions = ShipOptions;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets SKUs
        /// </summary>
        [DataMember(Name="SKUs", EmitDefaultValue=false)]
        public List<string> SKUs { get; set; }
    
        /// <summary>
        /// Gets or Sets ShipOptions
        /// </summary>
        [DataMember(Name="ShipOptions", EmitDefaultValue=false)]
        public List<ShipOption> ShipOptions { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShipItem {\n");
            sb.Append("  SKUs: ").Append(SKUs).Append("\n");
            sb.Append("  ShipOptions: ").Append(ShipOptions).Append("\n");
            
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
            return this.Equals(obj as ShipItem);
        }

        /// <summary>
        /// Returns true if ShipItem instances are equal
        /// </summary>
        /// <param name="other">Instance of ShipItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShipItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SKUs == other.SKUs ||
                    this.SKUs != null &&
                    this.SKUs.SequenceEqual(other.SKUs)
                ) && 
                (
                    this.ShipOptions == other.ShipOptions ||
                    this.ShipOptions != null &&
                    this.ShipOptions.SequenceEqual(other.ShipOptions)
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
                
                if (this.SKUs != null)
                    hash = hash * 59 + this.SKUs.GetHashCode();
                
                if (this.ShipOptions != null)
                    hash = hash * 59 + this.ShipOptions.GetHashCode();
                
                return hash;
            }
        }

    }


}
