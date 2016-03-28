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
    public partial class PostSubmittedItem :  IEquatable<PostSubmittedItem>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PostSubmittedItem" /> class.
        /// Initializes a new instance of the <see cref="PostSubmittedItem" />class.
        /// </summary>
        /// <param name="Sku">Sku (required).</param>
        /// <param name="ProductId">ProductId (required).</param>
        /// <param name="Product">The type of product that was bought (required).</param>
        /// <param name="Quantity">Quantity (required).</param>
        /// <param name="Status">Status (required).</param>
        /// <param name="TrackingNumber">Deprecated. Use the Shipments array as this will be removed in a future release. (required).</param>
        /// <param name="TrackingUrl">Deprecated. Use the Shipments array as this will be removed in a future release. (required).</param>
        /// <param name="ShipCarrierName">Deprecated. Use the Shipments array as this will be removed in a future release. (required).</param>
        /// <param name="Price">Price (required).</param>
        /// <param name="DiscountAmount">DiscountAmount (required).</param>
        /// <param name="SourceId">Partner&#39;s internal ID-- entirely optional (required).</param>
        /// <param name="Meta">An optional Map&lt;string,string&gt; of misc properties. (required).</param>
        /// <param name="Shipments">Shipments (required).</param>

        public PostSubmittedItem(string Sku = null, long? ProductId = null, string Product = null, long? Quantity = null, string Status = null, string TrackingNumber = null, string TrackingUrl = null, string ShipCarrierName = null, ProductPriceInfo Price = null, ProductPriceInfo DiscountAmount = null, string SourceId = null, Meta Meta = null, List<Shipment> Shipments = null)
        {
            // to ensure "Sku" is required (not null)
            if (Sku == null)
            {
                throw new InvalidDataException("Sku is a required property for PostSubmittedItem and cannot be null");
            }
            else
            {
                this.Sku = Sku;
            }
            // to ensure "ProductId" is required (not null)
            if (ProductId == null)
            {
                throw new InvalidDataException("ProductId is a required property for PostSubmittedItem and cannot be null");
            }
            else
            {
                this.ProductId = ProductId;
            }
            // to ensure "Product" is required (not null)
            if (Product == null)
            {
                throw new InvalidDataException("Product is a required property for PostSubmittedItem and cannot be null");
            }
            else
            {
                this.Product = Product;
            }
            // to ensure "Quantity" is required (not null)
            if (Quantity == null)
            {
                throw new InvalidDataException("Quantity is a required property for PostSubmittedItem and cannot be null");
            }
            else
            {
                this.Quantity = Quantity;
            }
            // to ensure "Status" is required (not null)
            if (Status == null)
            {
                throw new InvalidDataException("Status is a required property for PostSubmittedItem and cannot be null");
            }
            else
            {
                this.Status = Status;
            }
            // to ensure "TrackingNumber" is required (not null)
            if (TrackingNumber == null)
            {
                throw new InvalidDataException("TrackingNumber is a required property for PostSubmittedItem and cannot be null");
            }
            else
            {
                this.TrackingNumber = TrackingNumber;
            }
            // to ensure "TrackingUrl" is required (not null)
            if (TrackingUrl == null)
            {
                throw new InvalidDataException("TrackingUrl is a required property for PostSubmittedItem and cannot be null");
            }
            else
            {
                this.TrackingUrl = TrackingUrl;
            }
            // to ensure "ShipCarrierName" is required (not null)
            if (ShipCarrierName == null)
            {
                throw new InvalidDataException("ShipCarrierName is a required property for PostSubmittedItem and cannot be null");
            }
            else
            {
                this.ShipCarrierName = ShipCarrierName;
            }
            // to ensure "Price" is required (not null)
            if (Price == null)
            {
                throw new InvalidDataException("Price is a required property for PostSubmittedItem and cannot be null");
            }
            else
            {
                this.Price = Price;
            }
            // to ensure "DiscountAmount" is required (not null)
            if (DiscountAmount == null)
            {
                throw new InvalidDataException("DiscountAmount is a required property for PostSubmittedItem and cannot be null");
            }
            else
            {
                this.DiscountAmount = DiscountAmount;
            }
            // to ensure "SourceId" is required (not null)
            if (SourceId == null)
            {
                throw new InvalidDataException("SourceId is a required property for PostSubmittedItem and cannot be null");
            }
            else
            {
                this.SourceId = SourceId;
            }
            // to ensure "Meta" is required (not null)
            if (Meta == null)
            {
                throw new InvalidDataException("Meta is a required property for PostSubmittedItem and cannot be null");
            }
            else
            {
                this.Meta = Meta;
            }
            // to ensure "Shipments" is required (not null)
            if (Shipments == null)
            {
                throw new InvalidDataException("Shipments is a required property for PostSubmittedItem and cannot be null");
            }
            else
            {
                this.Shipments = Shipments;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets Sku
        /// </summary>
        [DataMember(Name="Sku", EmitDefaultValue=false)]
        public string Sku { get; set; }
    
        /// <summary>
        /// Gets or Sets ProductId
        /// </summary>
        [DataMember(Name="ProductId", EmitDefaultValue=false)]
        public long? ProductId { get; set; }
    
        /// <summary>
        /// The type of product that was bought
        /// </summary>
        /// <value>The type of product that was bought</value>
        [DataMember(Name="Product", EmitDefaultValue=false)]
        public string Product { get; set; }
    
        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="Quantity", EmitDefaultValue=false)]
        public long? Quantity { get; set; }
    
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public string Status { get; set; }
    
        /// <summary>
        /// Deprecated. Use the Shipments array as this will be removed in a future release.
        /// </summary>
        /// <value>Deprecated. Use the Shipments array as this will be removed in a future release.</value>
        [DataMember(Name="TrackingNumber", EmitDefaultValue=false)]
        public string TrackingNumber { get; set; }
    
        /// <summary>
        /// Deprecated. Use the Shipments array as this will be removed in a future release.
        /// </summary>
        /// <value>Deprecated. Use the Shipments array as this will be removed in a future release.</value>
        [DataMember(Name="TrackingUrl", EmitDefaultValue=false)]
        public string TrackingUrl { get; set; }
    
        /// <summary>
        /// Deprecated. Use the Shipments array as this will be removed in a future release.
        /// </summary>
        /// <value>Deprecated. Use the Shipments array as this will be removed in a future release.</value>
        [DataMember(Name="ShipCarrierName", EmitDefaultValue=false)]
        public string ShipCarrierName { get; set; }
    
        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name="Price", EmitDefaultValue=false)]
        public ProductPriceInfo Price { get; set; }
    
        /// <summary>
        /// Gets or Sets DiscountAmount
        /// </summary>
        [DataMember(Name="DiscountAmount", EmitDefaultValue=false)]
        public ProductPriceInfo DiscountAmount { get; set; }
    
        /// <summary>
        /// Partner&#39;s internal ID-- entirely optional
        /// </summary>
        /// <value>Partner&#39;s internal ID-- entirely optional</value>
        [DataMember(Name="SourceId", EmitDefaultValue=false)]
        public string SourceId { get; set; }
    
        /// <summary>
        /// An optional Map&lt;string,string&gt; of misc properties.
        /// </summary>
        /// <value>An optional Map&lt;string,string&gt; of misc properties.</value>
        [DataMember(Name="Meta", EmitDefaultValue=false)]
        public Meta Meta { get; set; }
    
        /// <summary>
        /// Gets or Sets Shipments
        /// </summary>
        [DataMember(Name="Shipments", EmitDefaultValue=false)]
        public List<Shipment> Shipments { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostSubmittedItem {\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TrackingNumber: ").Append(TrackingNumber).Append("\n");
            sb.Append("  TrackingUrl: ").Append(TrackingUrl).Append("\n");
            sb.Append("  ShipCarrierName: ").Append(ShipCarrierName).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  DiscountAmount: ").Append(DiscountAmount).Append("\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
            sb.Append("  Shipments: ").Append(Shipments).Append("\n");
            
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
            return this.Equals(obj as PostSubmittedItem);
        }

        /// <summary>
        /// Returns true if PostSubmittedItem instances are equal
        /// </summary>
        /// <param name="other">Instance of PostSubmittedItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostSubmittedItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Sku == other.Sku ||
                    this.Sku != null &&
                    this.Sku.Equals(other.Sku)
                ) && 
                (
                    this.ProductId == other.ProductId ||
                    this.ProductId != null &&
                    this.ProductId.Equals(other.ProductId)
                ) && 
                (
                    this.Product == other.Product ||
                    this.Product != null &&
                    this.Product.Equals(other.Product)
                ) && 
                (
                    this.Quantity == other.Quantity ||
                    this.Quantity != null &&
                    this.Quantity.Equals(other.Quantity)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.TrackingNumber == other.TrackingNumber ||
                    this.TrackingNumber != null &&
                    this.TrackingNumber.Equals(other.TrackingNumber)
                ) && 
                (
                    this.TrackingUrl == other.TrackingUrl ||
                    this.TrackingUrl != null &&
                    this.TrackingUrl.Equals(other.TrackingUrl)
                ) && 
                (
                    this.ShipCarrierName == other.ShipCarrierName ||
                    this.ShipCarrierName != null &&
                    this.ShipCarrierName.Equals(other.ShipCarrierName)
                ) && 
                (
                    this.Price == other.Price ||
                    this.Price != null &&
                    this.Price.Equals(other.Price)
                ) && 
                (
                    this.DiscountAmount == other.DiscountAmount ||
                    this.DiscountAmount != null &&
                    this.DiscountAmount.Equals(other.DiscountAmount)
                ) && 
                (
                    this.SourceId == other.SourceId ||
                    this.SourceId != null &&
                    this.SourceId.Equals(other.SourceId)
                ) && 
                (
                    this.Meta == other.Meta ||
                    this.Meta != null &&
                    this.Meta.Equals(other.Meta)
                ) && 
                (
                    this.Shipments == other.Shipments ||
                    this.Shipments != null &&
                    this.Shipments.SequenceEqual(other.Shipments)
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
                
                if (this.Sku != null)
                    hash = hash * 59 + this.Sku.GetHashCode();
                
                if (this.ProductId != null)
                    hash = hash * 59 + this.ProductId.GetHashCode();
                
                if (this.Product != null)
                    hash = hash * 59 + this.Product.GetHashCode();
                
                if (this.Quantity != null)
                    hash = hash * 59 + this.Quantity.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.TrackingNumber != null)
                    hash = hash * 59 + this.TrackingNumber.GetHashCode();
                
                if (this.TrackingUrl != null)
                    hash = hash * 59 + this.TrackingUrl.GetHashCode();
                
                if (this.ShipCarrierName != null)
                    hash = hash * 59 + this.ShipCarrierName.GetHashCode();
                
                if (this.Price != null)
                    hash = hash * 59 + this.Price.GetHashCode();
                
                if (this.DiscountAmount != null)
                    hash = hash * 59 + this.DiscountAmount.GetHashCode();
                
                if (this.SourceId != null)
                    hash = hash * 59 + this.SourceId.GetHashCode();
                
                if (this.Meta != null)
                    hash = hash * 59 + this.Meta.GetHashCode();
                
                if (this.Shipments != null)
                    hash = hash * 59 + this.Shipments.GetHashCode();
                
                return hash;
            }
        }

    }


}
