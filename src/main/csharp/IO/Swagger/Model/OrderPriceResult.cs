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
    public partial class OrderPriceResult :  IEquatable<OrderPriceResult>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderPriceResult" /> class.
        /// Initializes a new instance of the <see cref="OrderPriceResult" />class.
        /// </summary>
        /// <param name="Items">Items (required).</param>
        /// <param name="Shipping">Shipping (required).</param>
        /// <param name="Tax">Tax (required).</param>
        /// <param name="CouponCode">CouponCode (required).</param>
        /// <param name="CouponType">CouponType (required).</param>
        /// <param name="CouponUsed">CouponUsed (required).</param>
        /// <param name="HadCouponApply">HadCouponApply (required).</param>
        /// <param name="DollarsOff">DollarsOff (required).</param>
        /// <param name="PercentOff">PercentOff (required).</param>
        /// <param name="HadError">HadError (required).</param>

        public OrderPriceResult(PriceInfo Items = null, PriceInfo Shipping = null, PriceInfo Tax = null, PriceInfo CouponCode = null, string CouponType = null, string CouponUsed = null, bool? HadCouponApply = null, long? DollarsOff = null, long? PercentOff = null, bool? HadError = null)
        {
            // to ensure "Items" is required (not null)
            if (Items == null)
            {
                throw new InvalidDataException("Items is a required property for OrderPriceResult and cannot be null");
            }
            else
            {
                this.Items = Items;
            }
            // to ensure "Shipping" is required (not null)
            if (Shipping == null)
            {
                throw new InvalidDataException("Shipping is a required property for OrderPriceResult and cannot be null");
            }
            else
            {
                this.Shipping = Shipping;
            }
            // to ensure "Tax" is required (not null)
            if (Tax == null)
            {
                throw new InvalidDataException("Tax is a required property for OrderPriceResult and cannot be null");
            }
            else
            {
                this.Tax = Tax;
            }
            // to ensure "CouponCode" is required (not null)
            if (CouponCode == null)
            {
                throw new InvalidDataException("CouponCode is a required property for OrderPriceResult and cannot be null");
            }
            else
            {
                this.CouponCode = CouponCode;
            }
            // to ensure "CouponType" is required (not null)
            if (CouponType == null)
            {
                throw new InvalidDataException("CouponType is a required property for OrderPriceResult and cannot be null");
            }
            else
            {
                this.CouponType = CouponType;
            }
            // to ensure "CouponUsed" is required (not null)
            if (CouponUsed == null)
            {
                throw new InvalidDataException("CouponUsed is a required property for OrderPriceResult and cannot be null");
            }
            else
            {
                this.CouponUsed = CouponUsed;
            }
            // to ensure "HadCouponApply" is required (not null)
            if (HadCouponApply == null)
            {
                throw new InvalidDataException("HadCouponApply is a required property for OrderPriceResult and cannot be null");
            }
            else
            {
                this.HadCouponApply = HadCouponApply;
            }
            // to ensure "DollarsOff" is required (not null)
            if (DollarsOff == null)
            {
                throw new InvalidDataException("DollarsOff is a required property for OrderPriceResult and cannot be null");
            }
            else
            {
                this.DollarsOff = DollarsOff;
            }
            // to ensure "PercentOff" is required (not null)
            if (PercentOff == null)
            {
                throw new InvalidDataException("PercentOff is a required property for OrderPriceResult and cannot be null");
            }
            else
            {
                this.PercentOff = PercentOff;
            }
            // to ensure "HadError" is required (not null)
            if (HadError == null)
            {
                throw new InvalidDataException("HadError is a required property for OrderPriceResult and cannot be null");
            }
            else
            {
                this.HadError = HadError;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="Items", EmitDefaultValue=false)]
        public PriceInfo Items { get; set; }
    
        /// <summary>
        /// Gets or Sets Shipping
        /// </summary>
        [DataMember(Name="Shipping", EmitDefaultValue=false)]
        public PriceInfo Shipping { get; set; }
    
        /// <summary>
        /// Gets or Sets Tax
        /// </summary>
        [DataMember(Name="Tax", EmitDefaultValue=false)]
        public PriceInfo Tax { get; set; }
    
        /// <summary>
        /// Gets or Sets CouponCode
        /// </summary>
        [DataMember(Name="CouponCode", EmitDefaultValue=false)]
        public PriceInfo CouponCode { get; set; }
    
        /// <summary>
        /// Gets or Sets CouponType
        /// </summary>
        [DataMember(Name="CouponType", EmitDefaultValue=false)]
        public string CouponType { get; set; }
    
        /// <summary>
        /// Gets or Sets CouponUsed
        /// </summary>
        [DataMember(Name="CouponUsed", EmitDefaultValue=false)]
        public string CouponUsed { get; set; }
    
        /// <summary>
        /// Gets or Sets HadCouponApply
        /// </summary>
        [DataMember(Name="HadCouponApply", EmitDefaultValue=false)]
        public bool? HadCouponApply { get; set; }
    
        /// <summary>
        /// Gets or Sets DollarsOff
        /// </summary>
        [DataMember(Name="DollarsOff", EmitDefaultValue=false)]
        public long? DollarsOff { get; set; }
    
        /// <summary>
        /// Gets or Sets PercentOff
        /// </summary>
        [DataMember(Name="PercentOff", EmitDefaultValue=false)]
        public long? PercentOff { get; set; }
    
        /// <summary>
        /// Gets or Sets HadError
        /// </summary>
        [DataMember(Name="HadError", EmitDefaultValue=false)]
        public bool? HadError { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderPriceResult {\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Shipping: ").Append(Shipping).Append("\n");
            sb.Append("  Tax: ").Append(Tax).Append("\n");
            sb.Append("  CouponCode: ").Append(CouponCode).Append("\n");
            sb.Append("  CouponType: ").Append(CouponType).Append("\n");
            sb.Append("  CouponUsed: ").Append(CouponUsed).Append("\n");
            sb.Append("  HadCouponApply: ").Append(HadCouponApply).Append("\n");
            sb.Append("  DollarsOff: ").Append(DollarsOff).Append("\n");
            sb.Append("  PercentOff: ").Append(PercentOff).Append("\n");
            sb.Append("  HadError: ").Append(HadError).Append("\n");
            
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
            return this.Equals(obj as OrderPriceResult);
        }

        /// <summary>
        /// Returns true if OrderPriceResult instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderPriceResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderPriceResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Items == other.Items ||
                    this.Items != null &&
                    this.Items.Equals(other.Items)
                ) && 
                (
                    this.Shipping == other.Shipping ||
                    this.Shipping != null &&
                    this.Shipping.Equals(other.Shipping)
                ) && 
                (
                    this.Tax == other.Tax ||
                    this.Tax != null &&
                    this.Tax.Equals(other.Tax)
                ) && 
                (
                    this.CouponCode == other.CouponCode ||
                    this.CouponCode != null &&
                    this.CouponCode.Equals(other.CouponCode)
                ) && 
                (
                    this.CouponType == other.CouponType ||
                    this.CouponType != null &&
                    this.CouponType.Equals(other.CouponType)
                ) && 
                (
                    this.CouponUsed == other.CouponUsed ||
                    this.CouponUsed != null &&
                    this.CouponUsed.Equals(other.CouponUsed)
                ) && 
                (
                    this.HadCouponApply == other.HadCouponApply ||
                    this.HadCouponApply != null &&
                    this.HadCouponApply.Equals(other.HadCouponApply)
                ) && 
                (
                    this.DollarsOff == other.DollarsOff ||
                    this.DollarsOff != null &&
                    this.DollarsOff.Equals(other.DollarsOff)
                ) && 
                (
                    this.PercentOff == other.PercentOff ||
                    this.PercentOff != null &&
                    this.PercentOff.Equals(other.PercentOff)
                ) && 
                (
                    this.HadError == other.HadError ||
                    this.HadError != null &&
                    this.HadError.Equals(other.HadError)
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
                
                if (this.Items != null)
                    hash = hash * 59 + this.Items.GetHashCode();
                
                if (this.Shipping != null)
                    hash = hash * 59 + this.Shipping.GetHashCode();
                
                if (this.Tax != null)
                    hash = hash * 59 + this.Tax.GetHashCode();
                
                if (this.CouponCode != null)
                    hash = hash * 59 + this.CouponCode.GetHashCode();
                
                if (this.CouponType != null)
                    hash = hash * 59 + this.CouponType.GetHashCode();
                
                if (this.CouponUsed != null)
                    hash = hash * 59 + this.CouponUsed.GetHashCode();
                
                if (this.HadCouponApply != null)
                    hash = hash * 59 + this.HadCouponApply.GetHashCode();
                
                if (this.DollarsOff != null)
                    hash = hash * 59 + this.DollarsOff.GetHashCode();
                
                if (this.PercentOff != null)
                    hash = hash * 59 + this.PercentOff.GetHashCode();
                
                if (this.HadError != null)
                    hash = hash * 59 + this.HadError.GetHashCode();
                
                return hash;
            }
        }

    }
}
