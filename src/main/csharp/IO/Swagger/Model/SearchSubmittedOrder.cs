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
    public partial class SearchSubmittedOrder :  IEquatable<SearchSubmittedOrder>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchSubmittedOrder" /> class.
        /// Initializes a new instance of the <see cref="SearchSubmittedOrder" />class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="NiceId">NiceId (required).</param>
        /// <param name="SourceId">Clients can submit an ID they use for the order here. (required).</param>
        /// <param name="Items">Items (required).</param>
        /// <param name="Total">Total (required).</param>
        /// <param name="ShippingTotal">ShippingTotal (required).</param>
        /// <param name="DiscountCode">DiscountCode (required).</param>
        /// <param name="DiscountAmount">DiscountAmount (required).</param>
        /// <param name="Meta">An optional Map&lt;string,string&gt; of misc properties. (required).</param>

        public SearchSubmittedOrder(string Id = null, string NiceId = null, string SourceId = null, List<PostSubmittedItem> Items = null, ProductPriceInfo Total = null, ProductPriceInfo ShippingTotal = null, string DiscountCode = null, ProductPriceInfo DiscountAmount = null, Meta Meta = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for SearchSubmittedOrder and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "NiceId" is required (not null)
            if (NiceId == null)
            {
                throw new InvalidDataException("NiceId is a required property for SearchSubmittedOrder and cannot be null");
            }
            else
            {
                this.NiceId = NiceId;
            }
            // to ensure "SourceId" is required (not null)
            if (SourceId == null)
            {
                throw new InvalidDataException("SourceId is a required property for SearchSubmittedOrder and cannot be null");
            }
            else
            {
                this.SourceId = SourceId;
            }
            // to ensure "Items" is required (not null)
            if (Items == null)
            {
                throw new InvalidDataException("Items is a required property for SearchSubmittedOrder and cannot be null");
            }
            else
            {
                this.Items = Items;
            }
            // to ensure "Total" is required (not null)
            if (Total == null)
            {
                throw new InvalidDataException("Total is a required property for SearchSubmittedOrder and cannot be null");
            }
            else
            {
                this.Total = Total;
            }
            // to ensure "ShippingTotal" is required (not null)
            if (ShippingTotal == null)
            {
                throw new InvalidDataException("ShippingTotal is a required property for SearchSubmittedOrder and cannot be null");
            }
            else
            {
                this.ShippingTotal = ShippingTotal;
            }
            // to ensure "DiscountCode" is required (not null)
            if (DiscountCode == null)
            {
                throw new InvalidDataException("DiscountCode is a required property for SearchSubmittedOrder and cannot be null");
            }
            else
            {
                this.DiscountCode = DiscountCode;
            }
            // to ensure "DiscountAmount" is required (not null)
            if (DiscountAmount == null)
            {
                throw new InvalidDataException("DiscountAmount is a required property for SearchSubmittedOrder and cannot be null");
            }
            else
            {
                this.DiscountAmount = DiscountAmount;
            }
            // to ensure "Meta" is required (not null)
            if (Meta == null)
            {
                throw new InvalidDataException("Meta is a required property for SearchSubmittedOrder and cannot be null");
            }
            else
            {
                this.Meta = Meta;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or Sets NiceId
        /// </summary>
        [DataMember(Name="NiceId", EmitDefaultValue=false)]
        public string NiceId { get; set; }
    
        /// <summary>
        /// Clients can submit an ID they use for the order here.
        /// </summary>
        /// <value>Clients can submit an ID they use for the order here.</value>
        [DataMember(Name="SourceId", EmitDefaultValue=false)]
        public string SourceId { get; set; }
    
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
        /// Gets or Sets DiscountCode
        /// </summary>
        [DataMember(Name="DiscountCode", EmitDefaultValue=false)]
        public string DiscountCode { get; set; }
    
        /// <summary>
        /// Gets or Sets DiscountAmount
        /// </summary>
        [DataMember(Name="DiscountAmount", EmitDefaultValue=false)]
        public ProductPriceInfo DiscountAmount { get; set; }
    
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
            sb.Append("class SearchSubmittedOrder {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  NiceId: ").Append(NiceId).Append("\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  ShippingTotal: ").Append(ShippingTotal).Append("\n");
            sb.Append("  DiscountCode: ").Append(DiscountCode).Append("\n");
            sb.Append("  DiscountAmount: ").Append(DiscountAmount).Append("\n");
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
            return this.Equals(obj as SearchSubmittedOrder);
        }

        /// <summary>
        /// Returns true if SearchSubmittedOrder instances are equal
        /// </summary>
        /// <param name="other">Instance of SearchSubmittedOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchSubmittedOrder other)
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
                    this.SourceId == other.SourceId ||
                    this.SourceId != null &&
                    this.SourceId.Equals(other.SourceId)
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
                    this.DiscountCode == other.DiscountCode ||
                    this.DiscountCode != null &&
                    this.DiscountCode.Equals(other.DiscountCode)
                ) && 
                (
                    this.DiscountAmount == other.DiscountAmount ||
                    this.DiscountAmount != null &&
                    this.DiscountAmount.Equals(other.DiscountAmount)
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
                
                if (this.SourceId != null)
                    hash = hash * 59 + this.SourceId.GetHashCode();
                
                if (this.Items != null)
                    hash = hash * 59 + this.Items.GetHashCode();
                
                if (this.Total != null)
                    hash = hash * 59 + this.Total.GetHashCode();
                
                if (this.ShippingTotal != null)
                    hash = hash * 59 + this.ShippingTotal.GetHashCode();
                
                if (this.DiscountCode != null)
                    hash = hash * 59 + this.DiscountCode.GetHashCode();
                
                if (this.DiscountAmount != null)
                    hash = hash * 59 + this.DiscountAmount.GetHashCode();
                
                if (this.Meta != null)
                    hash = hash * 59 + this.Meta.GetHashCode();
                
                return hash;
            }
        }

    }
}
