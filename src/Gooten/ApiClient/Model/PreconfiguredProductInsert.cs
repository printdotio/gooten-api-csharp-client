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
    public partial class PreconfiguredProductInsert :  IEquatable<PreconfiguredProductInsert>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PreconfiguredProductInsert" /> class.
        /// Initializes a new instance of the <see cref="PreconfiguredProductInsert" />class.
        /// </summary>
        /// <param name="Sku">A sku that uniquely identifies the preconfigured product. (required).</param>
        /// <param name="Name">Name (required).</param>
        /// <param name="Description">Description (required).</param>
        /// <param name="Price">Optional price. (required).</param>
        /// <param name="Items">The item[s] that constitue the product. (required).</param>
        /// <param name="Images">Product images. Can contain large and small images for web, mobile, etc (required).</param>

        public PreconfiguredProductInsert(string Sku = null, string Name = null, string Description = null, long? Price = null, List<PreconfiguredItem> Items = null, List<PreconfiguredProductImage> Images = null)
        {
            // to ensure "Sku" is required (not null)
            if (Sku == null)
            {
                throw new InvalidDataException("Sku is a required property for PreconfiguredProductInsert and cannot be null");
            }
            else
            {
                this.Sku = Sku;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for PreconfiguredProductInsert and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Description" is required (not null)
            if (Description == null)
            {
                throw new InvalidDataException("Description is a required property for PreconfiguredProductInsert and cannot be null");
            }
            else
            {
                this.Description = Description;
            }
            // to ensure "Price" is required (not null)
            if (Price == null)
            {
                throw new InvalidDataException("Price is a required property for PreconfiguredProductInsert and cannot be null");
            }
            else
            {
                this.Price = Price;
            }
            // to ensure "Items" is required (not null)
            if (Items == null)
            {
                throw new InvalidDataException("Items is a required property for PreconfiguredProductInsert and cannot be null");
            }
            else
            {
                this.Items = Items;
            }
            // to ensure "Images" is required (not null)
            if (Images == null)
            {
                throw new InvalidDataException("Images is a required property for PreconfiguredProductInsert and cannot be null");
            }
            else
            {
                this.Images = Images;
            }
            
        }
        
    
        /// <summary>
        /// A sku that uniquely identifies the preconfigured product.
        /// </summary>
        /// <value>A sku that uniquely identifies the preconfigured product.</value>
        [DataMember(Name="Sku", EmitDefaultValue=false)]
        public string Sku { get; set; }
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }
    
        /// <summary>
        /// Optional price.
        /// </summary>
        /// <value>Optional price.</value>
        [DataMember(Name="Price", EmitDefaultValue=false)]
        public long? Price { get; set; }
    
        /// <summary>
        /// The item[s] that constitue the product.
        /// </summary>
        /// <value>The item[s] that constitue the product.</value>
        [DataMember(Name="Items", EmitDefaultValue=false)]
        public List<PreconfiguredItem> Items { get; set; }
    
        /// <summary>
        /// Product images. Can contain large and small images for web, mobile, etc
        /// </summary>
        /// <value>Product images. Can contain large and small images for web, mobile, etc</value>
        [DataMember(Name="Images", EmitDefaultValue=false)]
        public List<PreconfiguredProductImage> Images { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PreconfiguredProductInsert {\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
            
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
            return this.Equals(obj as PreconfiguredProductInsert);
        }

        /// <summary>
        /// Returns true if PreconfiguredProductInsert instances are equal
        /// </summary>
        /// <param name="other">Instance of PreconfiguredProductInsert to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PreconfiguredProductInsert other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Price == other.Price ||
                    this.Price != null &&
                    this.Price.Equals(other.Price)
                ) && 
                (
                    this.Items == other.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(other.Items)
                ) && 
                (
                    this.Images == other.Images ||
                    this.Images != null &&
                    this.Images.SequenceEqual(other.Images)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.Price != null)
                    hash = hash * 59 + this.Price.GetHashCode();
                
                if (this.Items != null)
                    hash = hash * 59 + this.Items.GetHashCode();
                
                if (this.Images != null)
                    hash = hash * 59 + this.Images.GetHashCode();
                
                return hash;
            }
        }

    }


}
