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
    public partial class Product :  IEquatable<Product>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Product" /> class.
        /// Initializes a new instance of the <see cref="Product" />class.
        /// </summary>
        /// <param name="Id">The product type id. Represents a type/class of products. Can later be passed into the productvariant service to get available product variations. (required).</param>
        /// <param name="UId">An id that syncs between printio&#39;s staging and live environments. (required).</param>
        /// <param name="Name">Name (required).</param>
        /// <param name="ShortDescription">ShortDescription (required).</param>
        /// <param name="HasAvailableProductVariants">Whether or not the item returned is a Product, or ProductVariant. Items with a Sku will not have other product variants (required).</param>
        /// <param name="HasProductTemplates">Whether or not the product has variants with templates. (required).</param>
        /// <param name="FeaturedIndex">A value to sort featured items by. Note that this is null if IsFeatured=false (required).</param>
        /// <param name="MaxZoom">MaxZoom (required).</param>
        /// <param name="RetailPrice">RetailPrice (required).</param>
        /// <param name="Info">Content describing the product. (required).</param>
        /// <param name="ProductImage">Product images. Note that this contains large and small images for web, mobile, etc (required).</param>
        /// <param name="PriceInfo">PriceInfo (required).</param>
        /// <param name="Categories">Categories (required).</param>

        public Product(long? Id = null, string UId = null, string Name = null, string ShortDescription = null, bool? HasAvailableProductVariants = null, bool? HasProductTemplates = null, long? FeaturedIndex = null, long? MaxZoom = null, ProductPriceInfo RetailPrice = null, List<ProductInfo> Info = null, List<ProductImage> ProductImage = null, ProductPriceInfo PriceInfo = null, List<Category> Categories = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for Product and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "UId" is required (not null)
            if (UId == null)
            {
                throw new InvalidDataException("UId is a required property for Product and cannot be null");
            }
            else
            {
                this.UId = UId;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for Product and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "ShortDescription" is required (not null)
            if (ShortDescription == null)
            {
                throw new InvalidDataException("ShortDescription is a required property for Product and cannot be null");
            }
            else
            {
                this.ShortDescription = ShortDescription;
            }
            // to ensure "HasAvailableProductVariants" is required (not null)
            if (HasAvailableProductVariants == null)
            {
                throw new InvalidDataException("HasAvailableProductVariants is a required property for Product and cannot be null");
            }
            else
            {
                this.HasAvailableProductVariants = HasAvailableProductVariants;
            }
            // to ensure "HasProductTemplates" is required (not null)
            if (HasProductTemplates == null)
            {
                throw new InvalidDataException("HasProductTemplates is a required property for Product and cannot be null");
            }
            else
            {
                this.HasProductTemplates = HasProductTemplates;
            }
            // to ensure "FeaturedIndex" is required (not null)
            if (FeaturedIndex == null)
            {
                throw new InvalidDataException("FeaturedIndex is a required property for Product and cannot be null");
            }
            else
            {
                this.FeaturedIndex = FeaturedIndex;
            }
            // to ensure "MaxZoom" is required (not null)
            if (MaxZoom == null)
            {
                throw new InvalidDataException("MaxZoom is a required property for Product and cannot be null");
            }
            else
            {
                this.MaxZoom = MaxZoom;
            }
            // to ensure "RetailPrice" is required (not null)
            if (RetailPrice == null)
            {
                throw new InvalidDataException("RetailPrice is a required property for Product and cannot be null");
            }
            else
            {
                this.RetailPrice = RetailPrice;
            }
            // to ensure "Info" is required (not null)
            if (Info == null)
            {
                throw new InvalidDataException("Info is a required property for Product and cannot be null");
            }
            else
            {
                this.Info = Info;
            }
            // to ensure "ProductImage" is required (not null)
            if (ProductImage == null)
            {
                throw new InvalidDataException("ProductImage is a required property for Product and cannot be null");
            }
            else
            {
                this.ProductImage = ProductImage;
            }
            // to ensure "PriceInfo" is required (not null)
            if (PriceInfo == null)
            {
                throw new InvalidDataException("PriceInfo is a required property for Product and cannot be null");
            }
            else
            {
                this.PriceInfo = PriceInfo;
            }
            // to ensure "Categories" is required (not null)
            if (Categories == null)
            {
                throw new InvalidDataException("Categories is a required property for Product and cannot be null");
            }
            else
            {
                this.Categories = Categories;
            }
            
        }
        
    
        /// <summary>
        /// The product type id. Represents a type/class of products. Can later be passed into the productvariant service to get available product variations.
        /// </summary>
        /// <value>The product type id. Represents a type/class of products. Can later be passed into the productvariant service to get available product variations.</value>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// An id that syncs between printio&#39;s staging and live environments.
        /// </summary>
        /// <value>An id that syncs between printio&#39;s staging and live environments.</value>
        [DataMember(Name="UId", EmitDefaultValue=false)]
        public string UId { get; set; }
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets ShortDescription
        /// </summary>
        [DataMember(Name="ShortDescription", EmitDefaultValue=false)]
        public string ShortDescription { get; set; }
    
        /// <summary>
        /// Whether or not the item returned is a Product, or ProductVariant. Items with a Sku will not have other product variants
        /// </summary>
        /// <value>Whether or not the item returned is a Product, or ProductVariant. Items with a Sku will not have other product variants</value>
        [DataMember(Name="HasAvailableProductVariants", EmitDefaultValue=false)]
        public bool? HasAvailableProductVariants { get; set; }
    
        /// <summary>
        /// Whether or not the product has variants with templates.
        /// </summary>
        /// <value>Whether or not the product has variants with templates.</value>
        [DataMember(Name="HasProductTemplates", EmitDefaultValue=false)]
        public bool? HasProductTemplates { get; set; }
    
        /// <summary>
        /// A value to sort featured items by. Note that this is null if IsFeatured=false
        /// </summary>
        /// <value>A value to sort featured items by. Note that this is null if IsFeatured=false</value>
        [DataMember(Name="FeaturedIndex", EmitDefaultValue=false)]
        public long? FeaturedIndex { get; set; }
    
        /// <summary>
        /// Gets or Sets MaxZoom
        /// </summary>
        [DataMember(Name="MaxZoom", EmitDefaultValue=false)]
        public long? MaxZoom { get; set; }
    
        /// <summary>
        /// Gets or Sets RetailPrice
        /// </summary>
        [DataMember(Name="RetailPrice", EmitDefaultValue=false)]
        public ProductPriceInfo RetailPrice { get; set; }
    
        /// <summary>
        /// Content describing the product.
        /// </summary>
        /// <value>Content describing the product.</value>
        [DataMember(Name="Info", EmitDefaultValue=false)]
        public List<ProductInfo> Info { get; set; }
    
        /// <summary>
        /// Product images. Note that this contains large and small images for web, mobile, etc
        /// </summary>
        /// <value>Product images. Note that this contains large and small images for web, mobile, etc</value>
        [DataMember(Name="ProductImage", EmitDefaultValue=false)]
        public List<ProductImage> ProductImage { get; set; }
    
        /// <summary>
        /// Gets or Sets PriceInfo
        /// </summary>
        [DataMember(Name="PriceInfo", EmitDefaultValue=false)]
        public ProductPriceInfo PriceInfo { get; set; }
    
        /// <summary>
        /// Gets or Sets Categories
        /// </summary>
        [DataMember(Name="Categories", EmitDefaultValue=false)]
        public List<Category> Categories { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Product {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UId: ").Append(UId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
            sb.Append("  HasAvailableProductVariants: ").Append(HasAvailableProductVariants).Append("\n");
            sb.Append("  HasProductTemplates: ").Append(HasProductTemplates).Append("\n");
            sb.Append("  FeaturedIndex: ").Append(FeaturedIndex).Append("\n");
            sb.Append("  MaxZoom: ").Append(MaxZoom).Append("\n");
            sb.Append("  RetailPrice: ").Append(RetailPrice).Append("\n");
            sb.Append("  Info: ").Append(Info).Append("\n");
            sb.Append("  ProductImage: ").Append(ProductImage).Append("\n");
            sb.Append("  PriceInfo: ").Append(PriceInfo).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            
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
            return this.Equals(obj as Product);
        }

        /// <summary>
        /// Returns true if Product instances are equal
        /// </summary>
        /// <param name="other">Instance of Product to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Product other)
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
                    this.UId == other.UId ||
                    this.UId != null &&
                    this.UId.Equals(other.UId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.ShortDescription == other.ShortDescription ||
                    this.ShortDescription != null &&
                    this.ShortDescription.Equals(other.ShortDescription)
                ) && 
                (
                    this.HasAvailableProductVariants == other.HasAvailableProductVariants ||
                    this.HasAvailableProductVariants != null &&
                    this.HasAvailableProductVariants.Equals(other.HasAvailableProductVariants)
                ) && 
                (
                    this.HasProductTemplates == other.HasProductTemplates ||
                    this.HasProductTemplates != null &&
                    this.HasProductTemplates.Equals(other.HasProductTemplates)
                ) && 
                (
                    this.FeaturedIndex == other.FeaturedIndex ||
                    this.FeaturedIndex != null &&
                    this.FeaturedIndex.Equals(other.FeaturedIndex)
                ) && 
                (
                    this.MaxZoom == other.MaxZoom ||
                    this.MaxZoom != null &&
                    this.MaxZoom.Equals(other.MaxZoom)
                ) && 
                (
                    this.RetailPrice == other.RetailPrice ||
                    this.RetailPrice != null &&
                    this.RetailPrice.Equals(other.RetailPrice)
                ) && 
                (
                    this.Info == other.Info ||
                    this.Info != null &&
                    this.Info.SequenceEqual(other.Info)
                ) && 
                (
                    this.ProductImage == other.ProductImage ||
                    this.ProductImage != null &&
                    this.ProductImage.SequenceEqual(other.ProductImage)
                ) && 
                (
                    this.PriceInfo == other.PriceInfo ||
                    this.PriceInfo != null &&
                    this.PriceInfo.Equals(other.PriceInfo)
                ) && 
                (
                    this.Categories == other.Categories ||
                    this.Categories != null &&
                    this.Categories.SequenceEqual(other.Categories)
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
                
                if (this.UId != null)
                    hash = hash * 59 + this.UId.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.ShortDescription != null)
                    hash = hash * 59 + this.ShortDescription.GetHashCode();
                
                if (this.HasAvailableProductVariants != null)
                    hash = hash * 59 + this.HasAvailableProductVariants.GetHashCode();
                
                if (this.HasProductTemplates != null)
                    hash = hash * 59 + this.HasProductTemplates.GetHashCode();
                
                if (this.FeaturedIndex != null)
                    hash = hash * 59 + this.FeaturedIndex.GetHashCode();
                
                if (this.MaxZoom != null)
                    hash = hash * 59 + this.MaxZoom.GetHashCode();
                
                if (this.RetailPrice != null)
                    hash = hash * 59 + this.RetailPrice.GetHashCode();
                
                if (this.Info != null)
                    hash = hash * 59 + this.Info.GetHashCode();
                
                if (this.ProductImage != null)
                    hash = hash * 59 + this.ProductImage.GetHashCode();
                
                if (this.PriceInfo != null)
                    hash = hash * 59 + this.PriceInfo.GetHashCode();
                
                if (this.Categories != null)
                    hash = hash * 59 + this.Categories.GetHashCode();
                
                return hash;
            }
        }

    }
}
