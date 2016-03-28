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
    public partial class ProductBuildInfoSpace :  IEquatable<ProductBuildInfoSpace>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductBuildInfoSpace" /> class.
        /// Initializes a new instance of the <see cref="ProductBuildInfoSpace" />class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="Description">Description (required).</param>
        /// <param name="Index">Index (required).</param>
        /// <param name="DefaultRotation">DefaultRotation (required).</param>
        /// <param name="Layers">Layers (required).</param>

        public ProductBuildInfoSpace(string Id = null, string Description = null, long? Index = null, long? DefaultRotation = null, List<ProductBuildInfo> Layers = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for ProductBuildInfoSpace and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Description" is required (not null)
            if (Description == null)
            {
                throw new InvalidDataException("Description is a required property for ProductBuildInfoSpace and cannot be null");
            }
            else
            {
                this.Description = Description;
            }
            // to ensure "Index" is required (not null)
            if (Index == null)
            {
                throw new InvalidDataException("Index is a required property for ProductBuildInfoSpace and cannot be null");
            }
            else
            {
                this.Index = Index;
            }
            // to ensure "DefaultRotation" is required (not null)
            if (DefaultRotation == null)
            {
                throw new InvalidDataException("DefaultRotation is a required property for ProductBuildInfoSpace and cannot be null");
            }
            else
            {
                this.DefaultRotation = DefaultRotation;
            }
            // to ensure "Layers" is required (not null)
            if (Layers == null)
            {
                throw new InvalidDataException("Layers is a required property for ProductBuildInfoSpace and cannot be null");
            }
            else
            {
                this.Layers = Layers;
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
        /// Gets or Sets Index
        /// </summary>
        [DataMember(Name="Index", EmitDefaultValue=false)]
        public long? Index { get; set; }
    
        /// <summary>
        /// Gets or Sets DefaultRotation
        /// </summary>
        [DataMember(Name="DefaultRotation", EmitDefaultValue=false)]
        public long? DefaultRotation { get; set; }
    
        /// <summary>
        /// Gets or Sets Layers
        /// </summary>
        [DataMember(Name="Layers", EmitDefaultValue=false)]
        public List<ProductBuildInfo> Layers { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductBuildInfoSpace {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  DefaultRotation: ").Append(DefaultRotation).Append("\n");
            sb.Append("  Layers: ").Append(Layers).Append("\n");
            
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
            return this.Equals(obj as ProductBuildInfoSpace);
        }

        /// <summary>
        /// Returns true if ProductBuildInfoSpace instances are equal
        /// </summary>
        /// <param name="other">Instance of ProductBuildInfoSpace to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductBuildInfoSpace other)
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
                    this.Index == other.Index ||
                    this.Index != null &&
                    this.Index.Equals(other.Index)
                ) && 
                (
                    this.DefaultRotation == other.DefaultRotation ||
                    this.DefaultRotation != null &&
                    this.DefaultRotation.Equals(other.DefaultRotation)
                ) && 
                (
                    this.Layers == other.Layers ||
                    this.Layers != null &&
                    this.Layers.SequenceEqual(other.Layers)
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
                
                if (this.Index != null)
                    hash = hash * 59 + this.Index.GetHashCode();
                
                if (this.DefaultRotation != null)
                    hash = hash * 59 + this.DefaultRotation.GetHashCode();
                
                if (this.Layers != null)
                    hash = hash * 59 + this.Layers.GetHashCode();
                
                return hash;
            }
        }

    }


}
