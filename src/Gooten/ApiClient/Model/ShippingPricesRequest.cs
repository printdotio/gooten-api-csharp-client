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
    public partial class ShippingPricesRequest :  IEquatable<ShippingPricesRequest>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingPricesRequest" /> class.
        /// Initializes a new instance of the <see cref="ShippingPricesRequest" />class.
        /// </summary>
        /// <param name="ShipToPostalCode">ShipToPostalCode (required).</param>
        /// <param name="ShipToCountry">ShipToCountry (required).</param>
        /// <param name="ShipToState">ShipToState (required).</param>
        /// <param name="CurrencyCode">CurrencyCode (required).</param>
        /// <param name="LanguageCode">LanguageCode (required).</param>
        /// <param name="Items">Items (required).</param>

        public ShippingPricesRequest(string ShipToPostalCode = null, string ShipToCountry = null, string ShipToState = null, string CurrencyCode = null, string LanguageCode = null, List<SkuQuantityPair> Items = null)
        {
            // to ensure "ShipToPostalCode" is required (not null)
            if (ShipToPostalCode == null)
            {
                throw new InvalidDataException("ShipToPostalCode is a required property for ShippingPricesRequest and cannot be null");
            }
            else
            {
                this.ShipToPostalCode = ShipToPostalCode;
            }
            // to ensure "ShipToCountry" is required (not null)
            if (ShipToCountry == null)
            {
                throw new InvalidDataException("ShipToCountry is a required property for ShippingPricesRequest and cannot be null");
            }
            else
            {
                this.ShipToCountry = ShipToCountry;
            }
            // to ensure "ShipToState" is required (not null)
            if (ShipToState == null)
            {
                throw new InvalidDataException("ShipToState is a required property for ShippingPricesRequest and cannot be null");
            }
            else
            {
                this.ShipToState = ShipToState;
            }
            // to ensure "CurrencyCode" is required (not null)
            if (CurrencyCode == null)
            {
                throw new InvalidDataException("CurrencyCode is a required property for ShippingPricesRequest and cannot be null");
            }
            else
            {
                this.CurrencyCode = CurrencyCode;
            }
            // to ensure "LanguageCode" is required (not null)
            if (LanguageCode == null)
            {
                throw new InvalidDataException("LanguageCode is a required property for ShippingPricesRequest and cannot be null");
            }
            else
            {
                this.LanguageCode = LanguageCode;
            }
            // to ensure "Items" is required (not null)
            if (Items == null)
            {
                throw new InvalidDataException("Items is a required property for ShippingPricesRequest and cannot be null");
            }
            else
            {
                this.Items = Items;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets ShipToPostalCode
        /// </summary>
        [DataMember(Name="ShipToPostalCode", EmitDefaultValue=false)]
        public string ShipToPostalCode { get; set; }
    
        /// <summary>
        /// Gets or Sets ShipToCountry
        /// </summary>
        [DataMember(Name="ShipToCountry", EmitDefaultValue=false)]
        public string ShipToCountry { get; set; }
    
        /// <summary>
        /// Gets or Sets ShipToState
        /// </summary>
        [DataMember(Name="ShipToState", EmitDefaultValue=false)]
        public string ShipToState { get; set; }
    
        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        [DataMember(Name="CurrencyCode", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }
    
        /// <summary>
        /// Gets or Sets LanguageCode
        /// </summary>
        [DataMember(Name="LanguageCode", EmitDefaultValue=false)]
        public string LanguageCode { get; set; }
    
        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="Items", EmitDefaultValue=false)]
        public List<SkuQuantityPair> Items { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShippingPricesRequest {\n");
            sb.Append("  ShipToPostalCode: ").Append(ShipToPostalCode).Append("\n");
            sb.Append("  ShipToCountry: ").Append(ShipToCountry).Append("\n");
            sb.Append("  ShipToState: ").Append(ShipToState).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  LanguageCode: ").Append(LanguageCode).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            
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
            return this.Equals(obj as ShippingPricesRequest);
        }

        /// <summary>
        /// Returns true if ShippingPricesRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ShippingPricesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShippingPricesRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ShipToPostalCode == other.ShipToPostalCode ||
                    this.ShipToPostalCode != null &&
                    this.ShipToPostalCode.Equals(other.ShipToPostalCode)
                ) && 
                (
                    this.ShipToCountry == other.ShipToCountry ||
                    this.ShipToCountry != null &&
                    this.ShipToCountry.Equals(other.ShipToCountry)
                ) && 
                (
                    this.ShipToState == other.ShipToState ||
                    this.ShipToState != null &&
                    this.ShipToState.Equals(other.ShipToState)
                ) && 
                (
                    this.CurrencyCode == other.CurrencyCode ||
                    this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(other.CurrencyCode)
                ) && 
                (
                    this.LanguageCode == other.LanguageCode ||
                    this.LanguageCode != null &&
                    this.LanguageCode.Equals(other.LanguageCode)
                ) && 
                (
                    this.Items == other.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(other.Items)
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
                
                if (this.ShipToPostalCode != null)
                    hash = hash * 59 + this.ShipToPostalCode.GetHashCode();
                
                if (this.ShipToCountry != null)
                    hash = hash * 59 + this.ShipToCountry.GetHashCode();
                
                if (this.ShipToState != null)
                    hash = hash * 59 + this.ShipToState.GetHashCode();
                
                if (this.CurrencyCode != null)
                    hash = hash * 59 + this.CurrencyCode.GetHashCode();
                
                if (this.LanguageCode != null)
                    hash = hash * 59 + this.LanguageCode.GetHashCode();
                
                if (this.Items != null)
                    hash = hash * 59 + this.Items.GetHashCode();
                
                return hash;
            }
        }

    }


}
