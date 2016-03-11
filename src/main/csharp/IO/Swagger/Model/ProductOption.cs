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
    public partial class ProductOption :  IEquatable<ProductOption>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductOption" /> class.
        /// Initializes a new instance of the <see cref="ProductOption" />class.
        /// </summary>
        /// <param name="OptionId">OptionId (required).</param>
        /// <param name="ValueId">ValueId (required).</param>
        /// <param name="Name">Name (required).</param>
        /// <param name="Value">Value (required).</param>
        /// <param name="ImageUrl">ImageUrl (required).</param>
        /// <param name="ImageType">ImageType (required).</param>
        /// <param name="RgbaColor">RgbaColor (required).</param>
        /// <param name="CmValue">CmValue (required).</param>
        /// <param name="SortValue">SortValue (required).</param>

        public ProductOption(string OptionId = null, string ValueId = null, string Name = null, string Value = null, string ImageUrl = null, string ImageType = null, string RgbaColor = null, string CmValue = null, string SortValue = null)
        {
            // to ensure "OptionId" is required (not null)
            if (OptionId == null)
            {
                throw new InvalidDataException("OptionId is a required property for ProductOption and cannot be null");
            }
            else
            {
                this.OptionId = OptionId;
            }
            // to ensure "ValueId" is required (not null)
            if (ValueId == null)
            {
                throw new InvalidDataException("ValueId is a required property for ProductOption and cannot be null");
            }
            else
            {
                this.ValueId = ValueId;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for ProductOption and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Value" is required (not null)
            if (Value == null)
            {
                throw new InvalidDataException("Value is a required property for ProductOption and cannot be null");
            }
            else
            {
                this.Value = Value;
            }
            // to ensure "ImageUrl" is required (not null)
            if (ImageUrl == null)
            {
                throw new InvalidDataException("ImageUrl is a required property for ProductOption and cannot be null");
            }
            else
            {
                this.ImageUrl = ImageUrl;
            }
            // to ensure "ImageType" is required (not null)
            if (ImageType == null)
            {
                throw new InvalidDataException("ImageType is a required property for ProductOption and cannot be null");
            }
            else
            {
                this.ImageType = ImageType;
            }
            // to ensure "RgbaColor" is required (not null)
            if (RgbaColor == null)
            {
                throw new InvalidDataException("RgbaColor is a required property for ProductOption and cannot be null");
            }
            else
            {
                this.RgbaColor = RgbaColor;
            }
            // to ensure "CmValue" is required (not null)
            if (CmValue == null)
            {
                throw new InvalidDataException("CmValue is a required property for ProductOption and cannot be null");
            }
            else
            {
                this.CmValue = CmValue;
            }
            // to ensure "SortValue" is required (not null)
            if (SortValue == null)
            {
                throw new InvalidDataException("SortValue is a required property for ProductOption and cannot be null");
            }
            else
            {
                this.SortValue = SortValue;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets OptionId
        /// </summary>
        [DataMember(Name="OptionId", EmitDefaultValue=false)]
        public string OptionId { get; set; }
    
        /// <summary>
        /// Gets or Sets ValueId
        /// </summary>
        [DataMember(Name="ValueId", EmitDefaultValue=false)]
        public string ValueId { get; set; }
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="Value", EmitDefaultValue=false)]
        public string Value { get; set; }
    
        /// <summary>
        /// Gets or Sets ImageUrl
        /// </summary>
        [DataMember(Name="ImageUrl", EmitDefaultValue=false)]
        public string ImageUrl { get; set; }
    
        /// <summary>
        /// Gets or Sets ImageType
        /// </summary>
        [DataMember(Name="ImageType", EmitDefaultValue=false)]
        public string ImageType { get; set; }
    
        /// <summary>
        /// Gets or Sets RgbaColor
        /// </summary>
        [DataMember(Name="RgbaColor", EmitDefaultValue=false)]
        public string RgbaColor { get; set; }
    
        /// <summary>
        /// Gets or Sets CmValue
        /// </summary>
        [DataMember(Name="CmValue", EmitDefaultValue=false)]
        public string CmValue { get; set; }
    
        /// <summary>
        /// Gets or Sets SortValue
        /// </summary>
        [DataMember(Name="SortValue", EmitDefaultValue=false)]
        public string SortValue { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductOption {\n");
            sb.Append("  OptionId: ").Append(OptionId).Append("\n");
            sb.Append("  ValueId: ").Append(ValueId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  ImageType: ").Append(ImageType).Append("\n");
            sb.Append("  RgbaColor: ").Append(RgbaColor).Append("\n");
            sb.Append("  CmValue: ").Append(CmValue).Append("\n");
            sb.Append("  SortValue: ").Append(SortValue).Append("\n");
            
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
            return this.Equals(obj as ProductOption);
        }

        /// <summary>
        /// Returns true if ProductOption instances are equal
        /// </summary>
        /// <param name="other">Instance of ProductOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductOption other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.OptionId == other.OptionId ||
                    this.OptionId != null &&
                    this.OptionId.Equals(other.OptionId)
                ) && 
                (
                    this.ValueId == other.ValueId ||
                    this.ValueId != null &&
                    this.ValueId.Equals(other.ValueId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) && 
                (
                    this.ImageUrl == other.ImageUrl ||
                    this.ImageUrl != null &&
                    this.ImageUrl.Equals(other.ImageUrl)
                ) && 
                (
                    this.ImageType == other.ImageType ||
                    this.ImageType != null &&
                    this.ImageType.Equals(other.ImageType)
                ) && 
                (
                    this.RgbaColor == other.RgbaColor ||
                    this.RgbaColor != null &&
                    this.RgbaColor.Equals(other.RgbaColor)
                ) && 
                (
                    this.CmValue == other.CmValue ||
                    this.CmValue != null &&
                    this.CmValue.Equals(other.CmValue)
                ) && 
                (
                    this.SortValue == other.SortValue ||
                    this.SortValue != null &&
                    this.SortValue.Equals(other.SortValue)
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
                
                if (this.OptionId != null)
                    hash = hash * 59 + this.OptionId.GetHashCode();
                
                if (this.ValueId != null)
                    hash = hash * 59 + this.ValueId.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                
                if (this.ImageUrl != null)
                    hash = hash * 59 + this.ImageUrl.GetHashCode();
                
                if (this.ImageType != null)
                    hash = hash * 59 + this.ImageType.GetHashCode();
                
                if (this.RgbaColor != null)
                    hash = hash * 59 + this.RgbaColor.GetHashCode();
                
                if (this.CmValue != null)
                    hash = hash * 59 + this.CmValue.GetHashCode();
                
                if (this.SortValue != null)
                    hash = hash * 59 + this.SortValue.GetHashCode();
                
                return hash;
            }
        }

    }
}
