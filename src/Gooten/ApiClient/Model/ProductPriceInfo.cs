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
    public partial class ProductPriceInfo :  IEquatable<ProductPriceInfo>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductPriceInfo" /> class.
        /// Initializes a new instance of the <see cref="ProductPriceInfo" />class.
        /// </summary>
        /// <param name="Price">Price (required).</param>
        /// <param name="CurrencyCode">CurrencyCode (required).</param>
        /// <param name="FormattedPrice">FormattedPrice (required).</param>
        /// <param name="CurrencyFormat">CurrencyFormat (required).</param>
        /// <param name="CurrencyDigits">CurrencyDigits (required).</param>

        public ProductPriceInfo(long? Price = null, string CurrencyCode = null, string FormattedPrice = null, string CurrencyFormat = null, long? CurrencyDigits = null)
        {
            // to ensure "Price" is required (not null)
            if (Price == null)
            {
                throw new InvalidDataException("Price is a required property for ProductPriceInfo and cannot be null");
            }
            else
            {
                this.Price = Price;
            }
            // to ensure "CurrencyCode" is required (not null)
            if (CurrencyCode == null)
            {
                throw new InvalidDataException("CurrencyCode is a required property for ProductPriceInfo and cannot be null");
            }
            else
            {
                this.CurrencyCode = CurrencyCode;
            }
            // to ensure "FormattedPrice" is required (not null)
            if (FormattedPrice == null)
            {
                throw new InvalidDataException("FormattedPrice is a required property for ProductPriceInfo and cannot be null");
            }
            else
            {
                this.FormattedPrice = FormattedPrice;
            }
            // to ensure "CurrencyFormat" is required (not null)
            if (CurrencyFormat == null)
            {
                throw new InvalidDataException("CurrencyFormat is a required property for ProductPriceInfo and cannot be null");
            }
            else
            {
                this.CurrencyFormat = CurrencyFormat;
            }
            // to ensure "CurrencyDigits" is required (not null)
            if (CurrencyDigits == null)
            {
                throw new InvalidDataException("CurrencyDigits is a required property for ProductPriceInfo and cannot be null");
            }
            else
            {
                this.CurrencyDigits = CurrencyDigits;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name="Price", EmitDefaultValue=false)]
        public long? Price { get; set; }
    
        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        [DataMember(Name="CurrencyCode", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }
    
        /// <summary>
        /// Gets or Sets FormattedPrice
        /// </summary>
        [DataMember(Name="FormattedPrice", EmitDefaultValue=false)]
        public string FormattedPrice { get; set; }
    
        /// <summary>
        /// Gets or Sets CurrencyFormat
        /// </summary>
        [DataMember(Name="CurrencyFormat", EmitDefaultValue=false)]
        public string CurrencyFormat { get; set; }
    
        /// <summary>
        /// Gets or Sets CurrencyDigits
        /// </summary>
        [DataMember(Name="CurrencyDigits", EmitDefaultValue=false)]
        public long? CurrencyDigits { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductPriceInfo {\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  FormattedPrice: ").Append(FormattedPrice).Append("\n");
            sb.Append("  CurrencyFormat: ").Append(CurrencyFormat).Append("\n");
            sb.Append("  CurrencyDigits: ").Append(CurrencyDigits).Append("\n");
            
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
            return this.Equals(obj as ProductPriceInfo);
        }

        /// <summary>
        /// Returns true if ProductPriceInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of ProductPriceInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductPriceInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Price == other.Price ||
                    this.Price != null &&
                    this.Price.Equals(other.Price)
                ) && 
                (
                    this.CurrencyCode == other.CurrencyCode ||
                    this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(other.CurrencyCode)
                ) && 
                (
                    this.FormattedPrice == other.FormattedPrice ||
                    this.FormattedPrice != null &&
                    this.FormattedPrice.Equals(other.FormattedPrice)
                ) && 
                (
                    this.CurrencyFormat == other.CurrencyFormat ||
                    this.CurrencyFormat != null &&
                    this.CurrencyFormat.Equals(other.CurrencyFormat)
                ) && 
                (
                    this.CurrencyDigits == other.CurrencyDigits ||
                    this.CurrencyDigits != null &&
                    this.CurrencyDigits.Equals(other.CurrencyDigits)
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
                
                if (this.Price != null)
                    hash = hash * 59 + this.Price.GetHashCode();
                
                if (this.CurrencyCode != null)
                    hash = hash * 59 + this.CurrencyCode.GetHashCode();
                
                if (this.FormattedPrice != null)
                    hash = hash * 59 + this.FormattedPrice.GetHashCode();
                
                if (this.CurrencyFormat != null)
                    hash = hash * 59 + this.CurrencyFormat.GetHashCode();
                
                if (this.CurrencyDigits != null)
                    hash = hash * 59 + this.CurrencyDigits.GetHashCode();
                
                return hash;
            }
        }

    }


}
