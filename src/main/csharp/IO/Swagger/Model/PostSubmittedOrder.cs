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
    public partial class PostSubmittedOrder :  IEquatable<PostSubmittedOrder>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PostSubmittedOrder" /> class.
        /// Initializes a new instance of the <see cref="PostSubmittedOrder" />class.
        /// </summary>
        /// <param name="Id">The unique ID we use within our system. (required).</param>
        /// <param name="NiceId">A short, non-unique ID that is optionally used for customer service. (required).</param>
        /// <param name="SouceId">Partner&#39;s internal ID-- entirely optional (required).</param>
        /// <param name="Items">Items (required).</param>
        /// <param name="Total">Total (required).</param>
        /// <param name="ShippingTotal">ShippingTotal (required).</param>
        /// <param name="DiscountAmount">DiscountAmount (required).</param>
        /// <param name="DiscountCode">DiscountCode (required).</param>
        /// <param name="BillingAddress">BillingAddress (required).</param>
        /// <param name="ShippingAddress">ShippingAddress (required).</param>
        /// <param name="Meta">An optional Map&lt;string,string&gt; of misc properties. (required).</param>

        public PostSubmittedOrder(string Id = null, string NiceId = null, string SouceId = null, List<PostSubmittedItem> Items = null, ProductPriceInfo Total = null, ProductPriceInfo ShippingTotal = null, ProductPriceInfo DiscountAmount = null, string DiscountCode = null, ShipToAddress BillingAddress = null, ShipToAddress ShippingAddress = null, Meta Meta = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for PostSubmittedOrder and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "NiceId" is required (not null)
            if (NiceId == null)
            {
                throw new InvalidDataException("NiceId is a required property for PostSubmittedOrder and cannot be null");
            }
            else
            {
                this.NiceId = NiceId;
            }
            // to ensure "SouceId" is required (not null)
            if (SouceId == null)
            {
                throw new InvalidDataException("SouceId is a required property for PostSubmittedOrder and cannot be null");
            }
            else
            {
                this.SouceId = SouceId;
            }
            // to ensure "Items" is required (not null)
            if (Items == null)
            {
                throw new InvalidDataException("Items is a required property for PostSubmittedOrder and cannot be null");
            }
            else
            {
                this.Items = Items;
            }
            // to ensure "Total" is required (not null)
            if (Total == null)
            {
                throw new InvalidDataException("Total is a required property for PostSubmittedOrder and cannot be null");
            }
            else
            {
                this.Total = Total;
            }
            // to ensure "ShippingTotal" is required (not null)
            if (ShippingTotal == null)
            {
                throw new InvalidDataException("ShippingTotal is a required property for PostSubmittedOrder and cannot be null");
            }
            else
            {
                this.ShippingTotal = ShippingTotal;
            }
            // to ensure "DiscountAmount" is required (not null)
            if (DiscountAmount == null)
            {
                throw new InvalidDataException("DiscountAmount is a required property for PostSubmittedOrder and cannot be null");
            }
            else
            {
                this.DiscountAmount = DiscountAmount;
            }
            // to ensure "DiscountCode" is required (not null)
            if (DiscountCode == null)
            {
                throw new InvalidDataException("DiscountCode is a required property for PostSubmittedOrder and cannot be null");
            }
            else
            {
                this.DiscountCode = DiscountCode;
            }
            // to ensure "BillingAddress" is required (not null)
            if (BillingAddress == null)
            {
                throw new InvalidDataException("BillingAddress is a required property for PostSubmittedOrder and cannot be null");
            }
            else
            {
                this.BillingAddress = BillingAddress;
            }
            // to ensure "ShippingAddress" is required (not null)
            if (ShippingAddress == null)
            {
                throw new InvalidDataException("ShippingAddress is a required property for PostSubmittedOrder and cannot be null");
            }
            else
            {
                this.ShippingAddress = ShippingAddress;
            }
            // to ensure "Meta" is required (not null)
            if (Meta == null)
            {
                throw new InvalidDataException("Meta is a required property for PostSubmittedOrder and cannot be null");
            }
            else
            {
                this.Meta = Meta;
            }
            
        }
        
    
        /// <summary>
        /// The unique ID we use within our system.
        /// </summary>
        /// <value>The unique ID we use within our system.</value>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// A short, non-unique ID that is optionally used for customer service.
        /// </summary>
        /// <value>A short, non-unique ID that is optionally used for customer service.</value>
        [DataMember(Name="NiceId", EmitDefaultValue=false)]
        public string NiceId { get; set; }
    
        /// <summary>
        /// Partner&#39;s internal ID-- entirely optional
        /// </summary>
        /// <value>Partner&#39;s internal ID-- entirely optional</value>
        [DataMember(Name="SouceId", EmitDefaultValue=false)]
        public string SouceId { get; set; }
    
        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="Items", EmitDefaultValue=false)]
        public List<PostSubmittedItem> Items { get; set; }
    
        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="Total", EmitDefaultValue=false)]
        public ProductPriceInfo Total { get; set; }
    
        /// <summary>
        /// Gets or Sets ShippingTotal
        /// </summary>
        [DataMember(Name="ShippingTotal", EmitDefaultValue=false)]
        public ProductPriceInfo ShippingTotal { get; set; }
    
        /// <summary>
        /// Gets or Sets DiscountAmount
        /// </summary>
        [DataMember(Name="DiscountAmount", EmitDefaultValue=false)]
        public ProductPriceInfo DiscountAmount { get; set; }
    
        /// <summary>
        /// Gets or Sets DiscountCode
        /// </summary>
        [DataMember(Name="DiscountCode", EmitDefaultValue=false)]
        public string DiscountCode { get; set; }
    
        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name="BillingAddress", EmitDefaultValue=false)]
        public ShipToAddress BillingAddress { get; set; }
    
        /// <summary>
        /// Gets or Sets ShippingAddress
        /// </summary>
        [DataMember(Name="ShippingAddress", EmitDefaultValue=false)]
        public ShipToAddress ShippingAddress { get; set; }
    
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
            sb.Append("class PostSubmittedOrder {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  NiceId: ").Append(NiceId).Append("\n");
            sb.Append("  SouceId: ").Append(SouceId).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  ShippingTotal: ").Append(ShippingTotal).Append("\n");
            sb.Append("  DiscountAmount: ").Append(DiscountAmount).Append("\n");
            sb.Append("  DiscountCode: ").Append(DiscountCode).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  ShippingAddress: ").Append(ShippingAddress).Append("\n");
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
            return this.Equals(obj as PostSubmittedOrder);
        }

        /// <summary>
        /// Returns true if PostSubmittedOrder instances are equal
        /// </summary>
        /// <param name="other">Instance of PostSubmittedOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostSubmittedOrder other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.NiceId == other.NiceId ||
                    this.NiceId != null &&
                    this.NiceId.Equals(other.NiceId)
                ) && 
                (
                    this.SouceId == other.SouceId ||
                    this.SouceId != null &&
                    this.SouceId.Equals(other.SouceId)
                ) && 
                (
                    this.Items == other.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(other.Items)
                ) && 
                (
                    this.Total == other.Total ||
                    this.Total != null &&
                    this.Total.Equals(other.Total)
                ) && 
                (
                    this.ShippingTotal == other.ShippingTotal ||
                    this.ShippingTotal != null &&
                    this.ShippingTotal.Equals(other.ShippingTotal)
                ) && 
                (
                    this.DiscountAmount == other.DiscountAmount ||
                    this.DiscountAmount != null &&
                    this.DiscountAmount.Equals(other.DiscountAmount)
                ) && 
                (
                    this.DiscountCode == other.DiscountCode ||
                    this.DiscountCode != null &&
                    this.DiscountCode.Equals(other.DiscountCode)
                ) && 
                (
                    this.BillingAddress == other.BillingAddress ||
                    this.BillingAddress != null &&
                    this.BillingAddress.Equals(other.BillingAddress)
                ) && 
                (
                    this.ShippingAddress == other.ShippingAddress ||
                    this.ShippingAddress != null &&
                    this.ShippingAddress.Equals(other.ShippingAddress)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.NiceId != null)
                    hash = hash * 59 + this.NiceId.GetHashCode();
                
                if (this.SouceId != null)
                    hash = hash * 59 + this.SouceId.GetHashCode();
                
                if (this.Items != null)
                    hash = hash * 59 + this.Items.GetHashCode();
                
                if (this.Total != null)
                    hash = hash * 59 + this.Total.GetHashCode();
                
                if (this.ShippingTotal != null)
                    hash = hash * 59 + this.ShippingTotal.GetHashCode();
                
                if (this.DiscountAmount != null)
                    hash = hash * 59 + this.DiscountAmount.GetHashCode();
                
                if (this.DiscountCode != null)
                    hash = hash * 59 + this.DiscountCode.GetHashCode();
                
                if (this.BillingAddress != null)
                    hash = hash * 59 + this.BillingAddress.GetHashCode();
                
                if (this.ShippingAddress != null)
                    hash = hash * 59 + this.ShippingAddress.GetHashCode();
                
                if (this.Meta != null)
                    hash = hash * 59 + this.Meta.GetHashCode();
                
                return hash;
            }
        }

    }
}
