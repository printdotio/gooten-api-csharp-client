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
    public partial class CountryList :  IEquatable<CountryList>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CountryList" /> class.
        /// Initializes a new instance of the <see cref="CountryList" />class.
        /// </summary>
        /// <param name="Countries">Countries (required).</param>

        public CountryList(List<Country> Countries = null)
        {
            // to ensure "Countries" is required (not null)
            if (Countries == null)
            {
                throw new InvalidDataException("Countries is a required property for CountryList and cannot be null");
            }
            else
            {
                this.Countries = Countries;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets Countries
        /// </summary>
        [DataMember(Name="Countries", EmitDefaultValue=false)]
        public List<Country> Countries { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CountryList {\n");
            sb.Append("  Countries: ").Append(Countries).Append("\n");
            
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
            return this.Equals(obj as CountryList);
        }

        /// <summary>
        /// Returns true if CountryList instances are equal
        /// </summary>
        /// <param name="other">Instance of CountryList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CountryList other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Countries == other.Countries ||
                    this.Countries != null &&
                    this.Countries.SequenceEqual(other.Countries)
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
                
                if (this.Countries != null)
                    hash = hash * 59 + this.Countries.GetHashCode();
                
                return hash;
            }
        }

    }
}
