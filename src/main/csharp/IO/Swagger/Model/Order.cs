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
    public partial class Order :  IEquatable<Order>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Order" /> class.
        /// Initializes a new instance of the <see cref="Order" />class.
        /// </summary>
        /// <param name="ShipToAddress">ShipToAddress (required).</param>
        /// <param name="Items">Items (required).</param>
        /// <param name="Payment">Payment (required).</param>
        /// <param name="CouponCode">CouponCode (required).</param>

        public Order(ShipToAddress ShipToAddress = null, List<OrderItem> Items = null, Payment Payment = null, string CouponCode = null)
        {
            // to ensure "ShipToAddress" is required (not null)
            if (ShipToAddress == null)
            {
                throw new InvalidDataException("ShipToAddress is a required property for Order and cannot be null");
            }
            else
            {
                this.ShipToAddress = ShipToAddress;
            }
            // to ensure "Items" is required (not null)
            if (Items == null)
            {
                throw new InvalidDataException("Items is a required property for Order and cannot be null");
            }
            else
            {
                this.Items = Items;
            }
            // to ensure "Payment" is required (not null)
            if (Payment == null)
            {
                throw new InvalidDataException("Payment is a required property for Order and cannot be null");
            }
            else
            {
                this.Payment = Payment;
            }
            // to ensure "CouponCode" is required (not null)
            if (CouponCode == null)
            {
                throw new InvalidDataException("CouponCode is a required property for Order and cannot be null");
            }
            else
            {
                this.CouponCode = CouponCode;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets ShipToAddress
        /// </summary>
        [DataMember(Name="ShipToAddress", EmitDefaultValue=false)]
        public ShipToAddress ShipToAddress { get; set; }
    
        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="Items", EmitDefaultValue=false)]
        public List<OrderItem> Items { get; set; }
    
        /// <summary>
        /// Gets or Sets Payment
        /// </summary>
        [DataMember(Name="Payment", EmitDefaultValue=false)]
        public Payment Payment { get; set; }
    
        /// <summary>
        /// Gets or Sets CouponCode
        /// </summary>
        [DataMember(Name="CouponCode", EmitDefaultValue=false)]
        public string CouponCode { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Order {\n");
            sb.Append("  ShipToAddress: ").Append(ShipToAddress).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Payment: ").Append(Payment).Append("\n");
            sb.Append("  CouponCode: ").Append(CouponCode).Append("\n");
            
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
            return this.Equals(obj as Order);
        }

        /// <summary>
        /// Returns true if Order instances are equal
        /// </summary>
        /// <param name="other">Instance of Order to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Order other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ShipToAddress == other.ShipToAddress ||
                    this.ShipToAddress != null &&
                    this.ShipToAddress.Equals(other.ShipToAddress)
                ) && 
                (
                    this.Items == other.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(other.Items)
                ) && 
                (
                    this.Payment == other.Payment ||
                    this.Payment != null &&
                    this.Payment.Equals(other.Payment)
                ) && 
                (
                    this.CouponCode == other.CouponCode ||
                    this.CouponCode != null &&
                    this.CouponCode.Equals(other.CouponCode)
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
                
                if (this.ShipToAddress != null)
                    hash = hash * 59 + this.ShipToAddress.GetHashCode();
                
                if (this.Items != null)
                    hash = hash * 59 + this.Items.GetHashCode();
                
                if (this.Payment != null)
                    hash = hash * 59 + this.Payment.GetHashCode();
                
                if (this.CouponCode != null)
                    hash = hash * 59 + this.CouponCode.GetHashCode();
                
                return hash;
            }
        }

    }
}
