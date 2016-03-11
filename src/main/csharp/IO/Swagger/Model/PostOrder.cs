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
    public partial class PostOrder :  IEquatable<PostOrder>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PostOrder" /> class.
        /// Initializes a new instance of the <see cref="PostOrder" />class.
        /// </summary>
        /// <param name="ShipToAddress">ShipToAddress (required).</param>
        /// <param name="BillingAddress">BillingAddress (required).</param>
        /// <param name="Items">Items (required).</param>
        /// <param name="Payment">Payment (required).</param>
        /// <param name="SourceId">Clients can submit an ID they use for the order here. (required).</param>
        /// <param name="IsPreSubmit">Submit the order into PrePayment status. (required).</param>
        /// <param name="CouponCode">CouponCode (required).</param>
        /// <param name="Meta">An optional Map&lt;string,string&gt; of misc properties. (required).</param>

        public PostOrder(ShipToAddress ShipToAddress = null, ShipToAddress BillingAddress = null, List<PostOrderItem> Items = null, OrderPayment Payment = null, string SourceId = null, bool? IsPreSubmit = null, string CouponCode = null, Meta Meta = null)
        {
            // to ensure "ShipToAddress" is required (not null)
            if (ShipToAddress == null)
            {
                throw new InvalidDataException("ShipToAddress is a required property for PostOrder and cannot be null");
            }
            else
            {
                this.ShipToAddress = ShipToAddress;
            }
            // to ensure "BillingAddress" is required (not null)
            if (BillingAddress == null)
            {
                throw new InvalidDataException("BillingAddress is a required property for PostOrder and cannot be null");
            }
            else
            {
                this.BillingAddress = BillingAddress;
            }
            // to ensure "Items" is required (not null)
            if (Items == null)
            {
                throw new InvalidDataException("Items is a required property for PostOrder and cannot be null");
            }
            else
            {
                this.Items = Items;
            }
            // to ensure "Payment" is required (not null)
            if (Payment == null)
            {
                throw new InvalidDataException("Payment is a required property for PostOrder and cannot be null");
            }
            else
            {
                this.Payment = Payment;
            }
            // to ensure "SourceId" is required (not null)
            if (SourceId == null)
            {
                throw new InvalidDataException("SourceId is a required property for PostOrder and cannot be null");
            }
            else
            {
                this.SourceId = SourceId;
            }
            // to ensure "IsPreSubmit" is required (not null)
            if (IsPreSubmit == null)
            {
                throw new InvalidDataException("IsPreSubmit is a required property for PostOrder and cannot be null");
            }
            else
            {
                this.IsPreSubmit = IsPreSubmit;
            }
            // to ensure "CouponCode" is required (not null)
            if (CouponCode == null)
            {
                throw new InvalidDataException("CouponCode is a required property for PostOrder and cannot be null");
            }
            else
            {
                this.CouponCode = CouponCode;
            }
            // to ensure "Meta" is required (not null)
            if (Meta == null)
            {
                throw new InvalidDataException("Meta is a required property for PostOrder and cannot be null");
            }
            else
            {
                this.Meta = Meta;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets ShipToAddress
        /// </summary>
        [DataMember(Name="ShipToAddress", EmitDefaultValue=false)]
        public ShipToAddress ShipToAddress { get; set; }
    
        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name="BillingAddress", EmitDefaultValue=false)]
        public ShipToAddress BillingAddress { get; set; }
    
        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="Items", EmitDefaultValue=false)]
        public List<PostOrderItem> Items { get; set; }
    
        /// <summary>
        /// Gets or Sets Payment
        /// </summary>
        [DataMember(Name="Payment", EmitDefaultValue=false)]
        public OrderPayment Payment { get; set; }
    
        /// <summary>
        /// Clients can submit an ID they use for the order here.
        /// </summary>
        /// <value>Clients can submit an ID they use for the order here.</value>
        [DataMember(Name="SourceId", EmitDefaultValue=false)]
        public string SourceId { get; set; }
    
        /// <summary>
        /// Submit the order into PrePayment status.
        /// </summary>
        /// <value>Submit the order into PrePayment status.</value>
        [DataMember(Name="IsPreSubmit", EmitDefaultValue=false)]
        public bool? IsPreSubmit { get; set; }
    
        /// <summary>
        /// Gets or Sets CouponCode
        /// </summary>
        [DataMember(Name="CouponCode", EmitDefaultValue=false)]
        public string CouponCode { get; set; }
    
        /// <summary>
        /// An optional Map&lt;string,string&gt; of misc properties.
        /// </summary>
        /// <value>An optional Map&lt;string,string&gt; of misc properties.</value>
        [DataMember(Name="Meta", EmitDefaultValue=false)]
        public Meta Meta { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostOrder {\n");
            sb.Append("  ShipToAddress: ").Append(ShipToAddress).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Payment: ").Append(Payment).Append("\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  IsPreSubmit: ").Append(IsPreSubmit).Append("\n");
            sb.Append("  CouponCode: ").Append(CouponCode).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
            
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
            return this.Equals(obj as PostOrder);
        }

        /// <summary>
        /// Returns true if PostOrder instances are equal
        /// </summary>
        /// <param name="other">Instance of PostOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostOrder other)
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
                    this.BillingAddress == other.BillingAddress ||
                    this.BillingAddress != null &&
                    this.BillingAddress.Equals(other.BillingAddress)
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
                    this.SourceId == other.SourceId ||
                    this.SourceId != null &&
                    this.SourceId.Equals(other.SourceId)
                ) && 
                (
                    this.IsPreSubmit == other.IsPreSubmit ||
                    this.IsPreSubmit != null &&
                    this.IsPreSubmit.Equals(other.IsPreSubmit)
                ) && 
                (
                    this.CouponCode == other.CouponCode ||
                    this.CouponCode != null &&
                    this.CouponCode.Equals(other.CouponCode)
                ) && 
                (
                    this.Meta == other.Meta ||
                    this.Meta != null &&
                    this.Meta.Equals(other.Meta)
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
                
                if (this.BillingAddress != null)
                    hash = hash * 59 + this.BillingAddress.GetHashCode();
                
                if (this.Items != null)
                    hash = hash * 59 + this.Items.GetHashCode();
                
                if (this.Payment != null)
                    hash = hash * 59 + this.Payment.GetHashCode();
                
                if (this.SourceId != null)
                    hash = hash * 59 + this.SourceId.GetHashCode();
                
                if (this.IsPreSubmit != null)
                    hash = hash * 59 + this.IsPreSubmit.GetHashCode();
                
                if (this.CouponCode != null)
                    hash = hash * 59 + this.CouponCode.GetHashCode();
                
                if (this.Meta != null)
                    hash = hash * 59 + this.Meta.GetHashCode();
                
                return hash;
            }
        }

    }
}
