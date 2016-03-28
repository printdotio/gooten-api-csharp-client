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
    public partial class OrderPayment :  IEquatable<OrderPayment>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderPayment" /> class.
        /// Initializes a new instance of the <see cref="OrderPayment" />class.
        /// </summary>
        /// <param name="BraintreeEncryptedCCNumber">BraintreeEncryptedCCNumber (required).</param>
        /// <param name="BraintreeEncryptedCCExpDate">BraintreeEncryptedCCExpDate (required).</param>
        /// <param name="BraintreeEncryptedCCV">BraintreeEncryptedCCV (required).</param>
        /// <param name="BraintreePaymentNonce">BraintreePaymentNonce (required).</param>
        /// <param name="PartnerBillingKey">A code that when passed allows the order to be submitted on credit. (required).</param>
        /// <param name="Total">Total (required).</param>
        /// <param name="CurrencyCode">CurrencyCode (required).</param>

        public OrderPayment(string BraintreeEncryptedCCNumber = null, string BraintreeEncryptedCCExpDate = null, string BraintreeEncryptedCCV = null, string BraintreePaymentNonce = null, string PartnerBillingKey = null, long? Total = null, string CurrencyCode = null)
        {
            // to ensure "BraintreeEncryptedCCNumber" is required (not null)
            if (BraintreeEncryptedCCNumber == null)
            {
                throw new InvalidDataException("BraintreeEncryptedCCNumber is a required property for OrderPayment and cannot be null");
            }
            else
            {
                this.BraintreeEncryptedCCNumber = BraintreeEncryptedCCNumber;
            }
            // to ensure "BraintreeEncryptedCCExpDate" is required (not null)
            if (BraintreeEncryptedCCExpDate == null)
            {
                throw new InvalidDataException("BraintreeEncryptedCCExpDate is a required property for OrderPayment and cannot be null");
            }
            else
            {
                this.BraintreeEncryptedCCExpDate = BraintreeEncryptedCCExpDate;
            }
            // to ensure "BraintreeEncryptedCCV" is required (not null)
            if (BraintreeEncryptedCCV == null)
            {
                throw new InvalidDataException("BraintreeEncryptedCCV is a required property for OrderPayment and cannot be null");
            }
            else
            {
                this.BraintreeEncryptedCCV = BraintreeEncryptedCCV;
            }
            // to ensure "BraintreePaymentNonce" is required (not null)
            if (BraintreePaymentNonce == null)
            {
                throw new InvalidDataException("BraintreePaymentNonce is a required property for OrderPayment and cannot be null");
            }
            else
            {
                this.BraintreePaymentNonce = BraintreePaymentNonce;
            }
            // to ensure "PartnerBillingKey" is required (not null)
            if (PartnerBillingKey == null)
            {
                throw new InvalidDataException("PartnerBillingKey is a required property for OrderPayment and cannot be null");
            }
            else
            {
                this.PartnerBillingKey = PartnerBillingKey;
            }
            // to ensure "Total" is required (not null)
            if (Total == null)
            {
                throw new InvalidDataException("Total is a required property for OrderPayment and cannot be null");
            }
            else
            {
                this.Total = Total;
            }
            // to ensure "CurrencyCode" is required (not null)
            if (CurrencyCode == null)
            {
                throw new InvalidDataException("CurrencyCode is a required property for OrderPayment and cannot be null");
            }
            else
            {
                this.CurrencyCode = CurrencyCode;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets BraintreeEncryptedCCNumber
        /// </summary>
        [DataMember(Name="BraintreeEncryptedCCNumber", EmitDefaultValue=false)]
        public string BraintreeEncryptedCCNumber { get; set; }
    
        /// <summary>
        /// Gets or Sets BraintreeEncryptedCCExpDate
        /// </summary>
        [DataMember(Name="BraintreeEncryptedCCExpDate", EmitDefaultValue=false)]
        public string BraintreeEncryptedCCExpDate { get; set; }
    
        /// <summary>
        /// Gets or Sets BraintreeEncryptedCCV
        /// </summary>
        [DataMember(Name="BraintreeEncryptedCCV", EmitDefaultValue=false)]
        public string BraintreeEncryptedCCV { get; set; }
    
        /// <summary>
        /// Gets or Sets BraintreePaymentNonce
        /// </summary>
        [DataMember(Name="BraintreePaymentNonce", EmitDefaultValue=false)]
        public string BraintreePaymentNonce { get; set; }
    
        /// <summary>
        /// A code that when passed allows the order to be submitted on credit.
        /// </summary>
        /// <value>A code that when passed allows the order to be submitted on credit.</value>
        [DataMember(Name="PartnerBillingKey", EmitDefaultValue=false)]
        public string PartnerBillingKey { get; set; }
    
        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="Total", EmitDefaultValue=false)]
        public long? Total { get; set; }
    
        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        [DataMember(Name="CurrencyCode", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderPayment {\n");
            sb.Append("  BraintreeEncryptedCCNumber: ").Append(BraintreeEncryptedCCNumber).Append("\n");
            sb.Append("  BraintreeEncryptedCCExpDate: ").Append(BraintreeEncryptedCCExpDate).Append("\n");
            sb.Append("  BraintreeEncryptedCCV: ").Append(BraintreeEncryptedCCV).Append("\n");
            sb.Append("  BraintreePaymentNonce: ").Append(BraintreePaymentNonce).Append("\n");
            sb.Append("  PartnerBillingKey: ").Append(PartnerBillingKey).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            
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
            return this.Equals(obj as OrderPayment);
        }

        /// <summary>
        /// Returns true if OrderPayment instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderPayment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderPayment other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BraintreeEncryptedCCNumber == other.BraintreeEncryptedCCNumber ||
                    this.BraintreeEncryptedCCNumber != null &&
                    this.BraintreeEncryptedCCNumber.Equals(other.BraintreeEncryptedCCNumber)
                ) && 
                (
                    this.BraintreeEncryptedCCExpDate == other.BraintreeEncryptedCCExpDate ||
                    this.BraintreeEncryptedCCExpDate != null &&
                    this.BraintreeEncryptedCCExpDate.Equals(other.BraintreeEncryptedCCExpDate)
                ) && 
                (
                    this.BraintreeEncryptedCCV == other.BraintreeEncryptedCCV ||
                    this.BraintreeEncryptedCCV != null &&
                    this.BraintreeEncryptedCCV.Equals(other.BraintreeEncryptedCCV)
                ) && 
                (
                    this.BraintreePaymentNonce == other.BraintreePaymentNonce ||
                    this.BraintreePaymentNonce != null &&
                    this.BraintreePaymentNonce.Equals(other.BraintreePaymentNonce)
                ) && 
                (
                    this.PartnerBillingKey == other.PartnerBillingKey ||
                    this.PartnerBillingKey != null &&
                    this.PartnerBillingKey.Equals(other.PartnerBillingKey)
                ) && 
                (
                    this.Total == other.Total ||
                    this.Total != null &&
                    this.Total.Equals(other.Total)
                ) && 
                (
                    this.CurrencyCode == other.CurrencyCode ||
                    this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(other.CurrencyCode)
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
                
                if (this.BraintreeEncryptedCCNumber != null)
                    hash = hash * 59 + this.BraintreeEncryptedCCNumber.GetHashCode();
                
                if (this.BraintreeEncryptedCCExpDate != null)
                    hash = hash * 59 + this.BraintreeEncryptedCCExpDate.GetHashCode();
                
                if (this.BraintreeEncryptedCCV != null)
                    hash = hash * 59 + this.BraintreeEncryptedCCV.GetHashCode();
                
                if (this.BraintreePaymentNonce != null)
                    hash = hash * 59 + this.BraintreePaymentNonce.GetHashCode();
                
                if (this.PartnerBillingKey != null)
                    hash = hash * 59 + this.PartnerBillingKey.GetHashCode();
                
                if (this.Total != null)
                    hash = hash * 59 + this.Total.GetHashCode();
                
                if (this.CurrencyCode != null)
                    hash = hash * 59 + this.CurrencyCode.GetHashCode();
                
                return hash;
            }
        }

    }


}
