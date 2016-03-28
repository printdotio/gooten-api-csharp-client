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
    public partial class ProductBuildInfo :  IEquatable<ProductBuildInfo>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductBuildInfo" /> class.
        /// Initializes a new instance of the <see cref="ProductBuildInfo" />class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="Description">Description (required).</param>
        /// <param name="Type">Type (required).</param>
        /// <param name="ZIndex">ZIndex (required).</param>
        /// <param name="X1">X1 (required).</param>
        /// <param name="X2">X2 (required).</param>
        /// <param name="Y1">Y1 (required).</param>
        /// <param name="Y2">Y2 (required).</param>
        /// <param name="Color">Color (required).</param>
        /// <param name="BackgroundImageUrl">BackgroundImageUrl (required).</param>
        /// <param name="OverlayImageUrl">OverlayImageUrl (required).</param>
        /// <param name="FontName">FontName (required).</param>
        /// <param name="FontSize">FontSize (required).</param>
        /// <param name="FontHAlignment">FontHAlignment (required).</param>
        /// <param name="FontVAlighment">FontVAlighment (required).</param>
        /// <param name="DefaultText">DefaultText (required).</param>

        public ProductBuildInfo(string Id = null, string Description = null, string Type = null, long? ZIndex = null, long? X1 = null, long? X2 = null, long? Y1 = null, long? Y2 = null, string Color = null, string BackgroundImageUrl = null, string OverlayImageUrl = null, string FontName = null, string FontSize = null, string FontHAlignment = null, string FontVAlighment = null, string DefaultText = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for ProductBuildInfo and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Description" is required (not null)
            if (Description == null)
            {
                throw new InvalidDataException("Description is a required property for ProductBuildInfo and cannot be null");
            }
            else
            {
                this.Description = Description;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for ProductBuildInfo and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            // to ensure "ZIndex" is required (not null)
            if (ZIndex == null)
            {
                throw new InvalidDataException("ZIndex is a required property for ProductBuildInfo and cannot be null");
            }
            else
            {
                this.ZIndex = ZIndex;
            }
            // to ensure "X1" is required (not null)
            if (X1 == null)
            {
                throw new InvalidDataException("X1 is a required property for ProductBuildInfo and cannot be null");
            }
            else
            {
                this.X1 = X1;
            }
            // to ensure "X2" is required (not null)
            if (X2 == null)
            {
                throw new InvalidDataException("X2 is a required property for ProductBuildInfo and cannot be null");
            }
            else
            {
                this.X2 = X2;
            }
            // to ensure "Y1" is required (not null)
            if (Y1 == null)
            {
                throw new InvalidDataException("Y1 is a required property for ProductBuildInfo and cannot be null");
            }
            else
            {
                this.Y1 = Y1;
            }
            // to ensure "Y2" is required (not null)
            if (Y2 == null)
            {
                throw new InvalidDataException("Y2 is a required property for ProductBuildInfo and cannot be null");
            }
            else
            {
                this.Y2 = Y2;
            }
            // to ensure "Color" is required (not null)
            if (Color == null)
            {
                throw new InvalidDataException("Color is a required property for ProductBuildInfo and cannot be null");
            }
            else
            {
                this.Color = Color;
            }
            // to ensure "BackgroundImageUrl" is required (not null)
            if (BackgroundImageUrl == null)
            {
                throw new InvalidDataException("BackgroundImageUrl is a required property for ProductBuildInfo and cannot be null");
            }
            else
            {
                this.BackgroundImageUrl = BackgroundImageUrl;
            }
            // to ensure "OverlayImageUrl" is required (not null)
            if (OverlayImageUrl == null)
            {
                throw new InvalidDataException("OverlayImageUrl is a required property for ProductBuildInfo and cannot be null");
            }
            else
            {
                this.OverlayImageUrl = OverlayImageUrl;
            }
            // to ensure "FontName" is required (not null)
            if (FontName == null)
            {
                throw new InvalidDataException("FontName is a required property for ProductBuildInfo and cannot be null");
            }
            else
            {
                this.FontName = FontName;
            }
            // to ensure "FontSize" is required (not null)
            if (FontSize == null)
            {
                throw new InvalidDataException("FontSize is a required property for ProductBuildInfo and cannot be null");
            }
            else
            {
                this.FontSize = FontSize;
            }
            // to ensure "FontHAlignment" is required (not null)
            if (FontHAlignment == null)
            {
                throw new InvalidDataException("FontHAlignment is a required property for ProductBuildInfo and cannot be null");
            }
            else
            {
                this.FontHAlignment = FontHAlignment;
            }
            // to ensure "FontVAlighment" is required (not null)
            if (FontVAlighment == null)
            {
                throw new InvalidDataException("FontVAlighment is a required property for ProductBuildInfo and cannot be null");
            }
            else
            {
                this.FontVAlighment = FontVAlighment;
            }
            // to ensure "DefaultText" is required (not null)
            if (DefaultText == null)
            {
                throw new InvalidDataException("DefaultText is a required property for ProductBuildInfo and cannot be null");
            }
            else
            {
                this.DefaultText = DefaultText;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public string Type { get; set; }
    
        /// <summary>
        /// Gets or Sets ZIndex
        /// </summary>
        [DataMember(Name="ZIndex", EmitDefaultValue=false)]
        public long? ZIndex { get; set; }
    
        /// <summary>
        /// Gets or Sets X1
        /// </summary>
        [DataMember(Name="X1", EmitDefaultValue=false)]
        public long? X1 { get; set; }
    
        /// <summary>
        /// Gets or Sets X2
        /// </summary>
        [DataMember(Name="X2", EmitDefaultValue=false)]
        public long? X2 { get; set; }
    
        /// <summary>
        /// Gets or Sets Y1
        /// </summary>
        [DataMember(Name="Y1", EmitDefaultValue=false)]
        public long? Y1 { get; set; }
    
        /// <summary>
        /// Gets or Sets Y2
        /// </summary>
        [DataMember(Name="Y2", EmitDefaultValue=false)]
        public long? Y2 { get; set; }
    
        /// <summary>
        /// Gets or Sets Color
        /// </summary>
        [DataMember(Name="Color", EmitDefaultValue=false)]
        public string Color { get; set; }
    
        /// <summary>
        /// Gets or Sets BackgroundImageUrl
        /// </summary>
        [DataMember(Name="BackgroundImageUrl", EmitDefaultValue=false)]
        public string BackgroundImageUrl { get; set; }
    
        /// <summary>
        /// Gets or Sets OverlayImageUrl
        /// </summary>
        [DataMember(Name="OverlayImageUrl", EmitDefaultValue=false)]
        public string OverlayImageUrl { get; set; }
    
        /// <summary>
        /// Gets or Sets FontName
        /// </summary>
        [DataMember(Name="FontName", EmitDefaultValue=false)]
        public string FontName { get; set; }
    
        /// <summary>
        /// Gets or Sets FontSize
        /// </summary>
        [DataMember(Name="FontSize", EmitDefaultValue=false)]
        public string FontSize { get; set; }
    
        /// <summary>
        /// Gets or Sets FontHAlignment
        /// </summary>
        [DataMember(Name="FontHAlignment", EmitDefaultValue=false)]
        public string FontHAlignment { get; set; }
    
        /// <summary>
        /// Gets or Sets FontVAlighment
        /// </summary>
        [DataMember(Name="FontVAlighment", EmitDefaultValue=false)]
        public string FontVAlighment { get; set; }
    
        /// <summary>
        /// Gets or Sets DefaultText
        /// </summary>
        [DataMember(Name="DefaultText", EmitDefaultValue=false)]
        public string DefaultText { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductBuildInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ZIndex: ").Append(ZIndex).Append("\n");
            sb.Append("  X1: ").Append(X1).Append("\n");
            sb.Append("  X2: ").Append(X2).Append("\n");
            sb.Append("  Y1: ").Append(Y1).Append("\n");
            sb.Append("  Y2: ").Append(Y2).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  BackgroundImageUrl: ").Append(BackgroundImageUrl).Append("\n");
            sb.Append("  OverlayImageUrl: ").Append(OverlayImageUrl).Append("\n");
            sb.Append("  FontName: ").Append(FontName).Append("\n");
            sb.Append("  FontSize: ").Append(FontSize).Append("\n");
            sb.Append("  FontHAlignment: ").Append(FontHAlignment).Append("\n");
            sb.Append("  FontVAlighment: ").Append(FontVAlighment).Append("\n");
            sb.Append("  DefaultText: ").Append(DefaultText).Append("\n");
            
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
            return this.Equals(obj as ProductBuildInfo);
        }

        /// <summary>
        /// Returns true if ProductBuildInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of ProductBuildInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductBuildInfo other)
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
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.ZIndex == other.ZIndex ||
                    this.ZIndex != null &&
                    this.ZIndex.Equals(other.ZIndex)
                ) && 
                (
                    this.X1 == other.X1 ||
                    this.X1 != null &&
                    this.X1.Equals(other.X1)
                ) && 
                (
                    this.X2 == other.X2 ||
                    this.X2 != null &&
                    this.X2.Equals(other.X2)
                ) && 
                (
                    this.Y1 == other.Y1 ||
                    this.Y1 != null &&
                    this.Y1.Equals(other.Y1)
                ) && 
                (
                    this.Y2 == other.Y2 ||
                    this.Y2 != null &&
                    this.Y2.Equals(other.Y2)
                ) && 
                (
                    this.Color == other.Color ||
                    this.Color != null &&
                    this.Color.Equals(other.Color)
                ) && 
                (
                    this.BackgroundImageUrl == other.BackgroundImageUrl ||
                    this.BackgroundImageUrl != null &&
                    this.BackgroundImageUrl.Equals(other.BackgroundImageUrl)
                ) && 
                (
                    this.OverlayImageUrl == other.OverlayImageUrl ||
                    this.OverlayImageUrl != null &&
                    this.OverlayImageUrl.Equals(other.OverlayImageUrl)
                ) && 
                (
                    this.FontName == other.FontName ||
                    this.FontName != null &&
                    this.FontName.Equals(other.FontName)
                ) && 
                (
                    this.FontSize == other.FontSize ||
                    this.FontSize != null &&
                    this.FontSize.Equals(other.FontSize)
                ) && 
                (
                    this.FontHAlignment == other.FontHAlignment ||
                    this.FontHAlignment != null &&
                    this.FontHAlignment.Equals(other.FontHAlignment)
                ) && 
                (
                    this.FontVAlighment == other.FontVAlighment ||
                    this.FontVAlighment != null &&
                    this.FontVAlighment.Equals(other.FontVAlighment)
                ) && 
                (
                    this.DefaultText == other.DefaultText ||
                    this.DefaultText != null &&
                    this.DefaultText.Equals(other.DefaultText)
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
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.ZIndex != null)
                    hash = hash * 59 + this.ZIndex.GetHashCode();
                
                if (this.X1 != null)
                    hash = hash * 59 + this.X1.GetHashCode();
                
                if (this.X2 != null)
                    hash = hash * 59 + this.X2.GetHashCode();
                
                if (this.Y1 != null)
                    hash = hash * 59 + this.Y1.GetHashCode();
                
                if (this.Y2 != null)
                    hash = hash * 59 + this.Y2.GetHashCode();
                
                if (this.Color != null)
                    hash = hash * 59 + this.Color.GetHashCode();
                
                if (this.BackgroundImageUrl != null)
                    hash = hash * 59 + this.BackgroundImageUrl.GetHashCode();
                
                if (this.OverlayImageUrl != null)
                    hash = hash * 59 + this.OverlayImageUrl.GetHashCode();
                
                if (this.FontName != null)
                    hash = hash * 59 + this.FontName.GetHashCode();
                
                if (this.FontSize != null)
                    hash = hash * 59 + this.FontSize.GetHashCode();
                
                if (this.FontHAlignment != null)
                    hash = hash * 59 + this.FontHAlignment.GetHashCode();
                
                if (this.FontVAlighment != null)
                    hash = hash * 59 + this.FontVAlighment.GetHashCode();
                
                if (this.DefaultText != null)
                    hash = hash * 59 + this.DefaultText.GetHashCode();
                
                return hash;
            }
        }

    }


}
