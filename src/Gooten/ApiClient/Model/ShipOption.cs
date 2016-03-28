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
    public partial class ShipOption :  IEquatable<ShipOption>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipOption" /> class.
        /// Initializes a new instance of the <see cref="ShipOption" />class.
        /// </summary>
        /// <param name="Id">The ID that can be passed into the /orders POST endpoing as ShipCarrierMethodId to specify an item&#39;s shipping method. (required).</param>
        /// <param name="MethodType">MethodType (required).</param>
        /// <param name="MethodId">MethodId (required).</param>
        /// <param name="Name">Name (required).</param>
        /// <param name="CarrierName">CarrierName (required).</param>
        /// <param name="CarrierLogoUrl">CarrierLogoUrl (required).</param>
        /// <param name="Price">Price (required).</param>
        /// <param name="PartnerPrice">PartnerPrice.</param>
        /// <param name="EstBusinessDaysTilDelivery">EstBusinessDaysTilDelivery (required).</param>

        public ShipOption(long? Id = null, string MethodType = null, long? MethodId = null, string Name = null, string CarrierName = null, string CarrierLogoUrl = null, ShipPrice Price = null, ShipPrice PartnerPrice = null, long? EstBusinessDaysTilDelivery = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for ShipOption and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "MethodType" is required (not null)
            if (MethodType == null)
            {
                throw new InvalidDataException("MethodType is a required property for ShipOption and cannot be null");
            }
            else
            {
                this.MethodType = MethodType;
            }
            // to ensure "MethodId" is required (not null)
            if (MethodId == null)
            {
                throw new InvalidDataException("MethodId is a required property for ShipOption and cannot be null");
            }
            else
            {
                this.MethodId = MethodId;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for ShipOption and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "CarrierName" is required (not null)
            if (CarrierName == null)
            {
                throw new InvalidDataException("CarrierName is a required property for ShipOption and cannot be null");
            }
            else
            {
                this.CarrierName = CarrierName;
            }
            // to ensure "CarrierLogoUrl" is required (not null)
            if (CarrierLogoUrl == null)
            {
                throw new InvalidDataException("CarrierLogoUrl is a required property for ShipOption and cannot be null");
            }
            else
            {
                this.CarrierLogoUrl = CarrierLogoUrl;
            }
            // to ensure "Price" is required (not null)
            if (Price == null)
            {
                throw new InvalidDataException("Price is a required property for ShipOption and cannot be null");
            }
            else
            {
                this.Price = Price;
            }
            // to ensure "EstBusinessDaysTilDelivery" is required (not null)
            if (EstBusinessDaysTilDelivery == null)
            {
                throw new InvalidDataException("EstBusinessDaysTilDelivery is a required property for ShipOption and cannot be null");
            }
            else
            {
                this.EstBusinessDaysTilDelivery = EstBusinessDaysTilDelivery;
            }
            this.PartnerPrice = PartnerPrice;
            
        }
        
    
        /// <summary>
        /// The ID that can be passed into the /orders POST endpoing as ShipCarrierMethodId to specify an item&#39;s shipping method.
        /// </summary>
        /// <value>The ID that can be passed into the /orders POST endpoing as ShipCarrierMethodId to specify an item&#39;s shipping method.</value>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Gets or Sets MethodType
        /// </summary>
        [DataMember(Name="MethodType", EmitDefaultValue=false)]
        public string MethodType { get; set; }
    
        /// <summary>
        /// Gets or Sets MethodId
        /// </summary>
        [DataMember(Name="MethodId", EmitDefaultValue=false)]
        public long? MethodId { get; set; }
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets CarrierName
        /// </summary>
        [DataMember(Name="CarrierName", EmitDefaultValue=false)]
        public string CarrierName { get; set; }
    
        /// <summary>
        /// Gets or Sets CarrierLogoUrl
        /// </summary>
        [DataMember(Name="CarrierLogoUrl", EmitDefaultValue=false)]
        public string CarrierLogoUrl { get; set; }
    
        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name="Price", EmitDefaultValue=false)]
        public ShipPrice Price { get; set; }
    
        /// <summary>
        /// Gets or Sets PartnerPrice
        /// </summary>
        [DataMember(Name="PartnerPrice", EmitDefaultValue=false)]
        public ShipPrice PartnerPrice { get; set; }
    
        /// <summary>
        /// Gets or Sets EstBusinessDaysTilDelivery
        /// </summary>
        [DataMember(Name="EstBusinessDaysTilDelivery", EmitDefaultValue=false)]
        public long? EstBusinessDaysTilDelivery { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShipOption {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MethodType: ").Append(MethodType).Append("\n");
            sb.Append("  MethodId: ").Append(MethodId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CarrierName: ").Append(CarrierName).Append("\n");
            sb.Append("  CarrierLogoUrl: ").Append(CarrierLogoUrl).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  PartnerPrice: ").Append(PartnerPrice).Append("\n");
            sb.Append("  EstBusinessDaysTilDelivery: ").Append(EstBusinessDaysTilDelivery).Append("\n");
            
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
            return this.Equals(obj as ShipOption);
        }

        /// <summary>
        /// Returns true if ShipOption instances are equal
        /// </summary>
        /// <param name="other">Instance of ShipOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShipOption other)
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
                    this.MethodType == other.MethodType ||
                    this.MethodType != null &&
                    this.MethodType.Equals(other.MethodType)
                ) && 
                (
                    this.MethodId == other.MethodId ||
                    this.MethodId != null &&
                    this.MethodId.Equals(other.MethodId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.CarrierName == other.CarrierName ||
                    this.CarrierName != null &&
                    this.CarrierName.Equals(other.CarrierName)
                ) && 
                (
                    this.CarrierLogoUrl == other.CarrierLogoUrl ||
                    this.CarrierLogoUrl != null &&
                    this.CarrierLogoUrl.Equals(other.CarrierLogoUrl)
                ) && 
                (
                    this.Price == other.Price ||
                    this.Price != null &&
                    this.Price.Equals(other.Price)
                ) && 
                (
                    this.PartnerPrice == other.PartnerPrice ||
                    this.PartnerPrice != null &&
                    this.PartnerPrice.Equals(other.PartnerPrice)
                ) && 
                (
                    this.EstBusinessDaysTilDelivery == other.EstBusinessDaysTilDelivery ||
                    this.EstBusinessDaysTilDelivery != null &&
                    this.EstBusinessDaysTilDelivery.Equals(other.EstBusinessDaysTilDelivery)
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
                
                if (this.MethodType != null)
                    hash = hash * 59 + this.MethodType.GetHashCode();
                
                if (this.MethodId != null)
                    hash = hash * 59 + this.MethodId.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.CarrierName != null)
                    hash = hash * 59 + this.CarrierName.GetHashCode();
                
                if (this.CarrierLogoUrl != null)
                    hash = hash * 59 + this.CarrierLogoUrl.GetHashCode();
                
                if (this.Price != null)
                    hash = hash * 59 + this.Price.GetHashCode();
                
                if (this.PartnerPrice != null)
                    hash = hash * 59 + this.PartnerPrice.GetHashCode();
                
                if (this.EstBusinessDaysTilDelivery != null)
                    hash = hash * 59 + this.EstBusinessDaysTilDelivery.GetHashCode();
                
                return hash;
            }
        }

    }


}
