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
    public partial class PaymentValidationRequest :  IEquatable<PaymentValidationRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentValidationRequest" /> class.
        /// Initializes a new instance of the <see cref="PaymentValidationRequest" />class.
        /// </summary>
        /// <param name="OrderId">OrderId (required).</param>
        /// <param name="PayPalKey">PayPalKey (required).</param>

        public PaymentValidationRequest(string OrderId = null, string PayPalKey = null)
        {
            // to ensure "OrderId" is required (not null)
            if (OrderId == null)
            {
                throw new InvalidDataException("OrderId is a required property for PaymentValidationRequest and cannot be null");
            }
            else
            {
                this.OrderId = OrderId;
            }
            // to ensure "PayPalKey" is required (not null)
            if (PayPalKey == null)
            {
                throw new InvalidDataException("PayPalKey is a required property for PaymentValidationRequest and cannot be null");
            }
            else
            {
                this.PayPalKey = PayPalKey;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets OrderId
        /// </summary>
        [DataMember(Name="OrderId", EmitDefaultValue=false)]
        public string OrderId { get; set; }
    
        /// <summary>
        /// Gets or Sets PayPalKey
        /// </summary>
        [DataMember(Name="PayPalKey", EmitDefaultValue=false)]
        public string PayPalKey { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentValidationRequest {\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  PayPalKey: ").Append(PayPalKey).Append("\n");
            
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
            return this.Equals(obj as PaymentValidationRequest);
        }

        /// <summary>
        /// Returns true if PaymentValidationRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentValidationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentValidationRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.OrderId == other.OrderId ||
                    this.OrderId != null &&
                    this.OrderId.Equals(other.OrderId)
                ) && 
                (
                    this.PayPalKey == other.PayPalKey ||
                    this.PayPalKey != null &&
                    this.PayPalKey.Equals(other.PayPalKey)
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
                
                if (this.OrderId != null)
                    hash = hash * 59 + this.OrderId.GetHashCode();
                
                if (this.PayPalKey != null)
                    hash = hash * 59 + this.PayPalKey.GetHashCode();
                
                return hash;
            }
        }

    }


}
