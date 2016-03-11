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
    public partial class Result :  IEquatable<Result>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Result" /> class.
        /// Initializes a new instance of the <see cref="Result" />class.
        /// </summary>
        /// <param name="IsValid">IsValid (required).</param>
        /// <param name="Reason">Reason (required).</param>
        /// <param name="Score">Score (required).</param>
        /// <param name="ProposedAddress">ProposedAddress (required).</param>

        public Result(bool? IsValid = null, string Reason = null, long? Score = null, Address ProposedAddress = null)
        {
            // to ensure "IsValid" is required (not null)
            if (IsValid == null)
            {
                throw new InvalidDataException("IsValid is a required property for Result and cannot be null");
            }
            else
            {
                this.IsValid = IsValid;
            }
            // to ensure "Reason" is required (not null)
            if (Reason == null)
            {
                throw new InvalidDataException("Reason is a required property for Result and cannot be null");
            }
            else
            {
                this.Reason = Reason;
            }
            // to ensure "Score" is required (not null)
            if (Score == null)
            {
                throw new InvalidDataException("Score is a required property for Result and cannot be null");
            }
            else
            {
                this.Score = Score;
            }
            // to ensure "ProposedAddress" is required (not null)
            if (ProposedAddress == null)
            {
                throw new InvalidDataException("ProposedAddress is a required property for Result and cannot be null");
            }
            else
            {
                this.ProposedAddress = ProposedAddress;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets IsValid
        /// </summary>
        [DataMember(Name="IsValid", EmitDefaultValue=false)]
        public bool? IsValid { get; set; }
    
        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="Reason", EmitDefaultValue=false)]
        public string Reason { get; set; }
    
        /// <summary>
        /// Gets or Sets Score
        /// </summary>
        [DataMember(Name="Score", EmitDefaultValue=false)]
        public long? Score { get; set; }
    
        /// <summary>
        /// Gets or Sets ProposedAddress
        /// </summary>
        [DataMember(Name="ProposedAddress", EmitDefaultValue=false)]
        public Address ProposedAddress { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Result {\n");
            sb.Append("  IsValid: ").Append(IsValid).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  ProposedAddress: ").Append(ProposedAddress).Append("\n");
            
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
            return this.Equals(obj as Result);
        }

        /// <summary>
        /// Returns true if Result instances are equal
        /// </summary>
        /// <param name="other">Instance of Result to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Result other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IsValid == other.IsValid ||
                    this.IsValid != null &&
                    this.IsValid.Equals(other.IsValid)
                ) && 
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
                ) && 
                (
                    this.Score == other.Score ||
                    this.Score != null &&
                    this.Score.Equals(other.Score)
                ) && 
                (
                    this.ProposedAddress == other.ProposedAddress ||
                    this.ProposedAddress != null &&
                    this.ProposedAddress.Equals(other.ProposedAddress)
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
                
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
                
                if (this.Score != null)
                    hash = hash * 59 + this.Score.GetHashCode();
                
                if (this.ProposedAddress != null)
                    hash = hash * 59 + this.ProposedAddress.GetHashCode();
                
                return hash;
            }
        }

    }
}
