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
    public partial class SubmittedOrderList :  IEquatable<SubmittedOrderList>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SubmittedOrderList" /> class.
        /// Initializes a new instance of the <see cref="SubmittedOrderList" />class.
        /// </summary>
        /// <param name="Orders">Orders (required).</param>
        /// <param name="TotalPages">TotalPages (required).</param>
        /// <param name="Page">Page (required).</param>
        /// <param name="HadError">HadError (required).</param>

        public SubmittedOrderList(List<SearchSubmittedOrder> Orders = null, long? TotalPages = null, long? Page = null, bool? HadError = null)
        {
            // to ensure "Orders" is required (not null)
            if (Orders == null)
            {
                throw new InvalidDataException("Orders is a required property for SubmittedOrderList and cannot be null");
            }
            else
            {
                this.Orders = Orders;
            }
            // to ensure "TotalPages" is required (not null)
            if (TotalPages == null)
            {
                throw new InvalidDataException("TotalPages is a required property for SubmittedOrderList and cannot be null");
            }
            else
            {
                this.TotalPages = TotalPages;
            }
            // to ensure "Page" is required (not null)
            if (Page == null)
            {
                throw new InvalidDataException("Page is a required property for SubmittedOrderList and cannot be null");
            }
            else
            {
                this.Page = Page;
            }
            // to ensure "HadError" is required (not null)
            if (HadError == null)
            {
                throw new InvalidDataException("HadError is a required property for SubmittedOrderList and cannot be null");
            }
            else
            {
                this.HadError = HadError;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets Orders
        /// </summary>
        [DataMember(Name="Orders", EmitDefaultValue=false)]
        public List<SearchSubmittedOrder> Orders { get; set; }
    
        /// <summary>
        /// Gets or Sets TotalPages
        /// </summary>
        [DataMember(Name="TotalPages", EmitDefaultValue=false)]
        public long? TotalPages { get; set; }
    
        /// <summary>
        /// Gets or Sets Page
        /// </summary>
        [DataMember(Name="Page", EmitDefaultValue=false)]
        public long? Page { get; set; }
    
        /// <summary>
        /// Gets or Sets HadError
        /// </summary>
        [DataMember(Name="HadError", EmitDefaultValue=false)]
        public bool? HadError { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubmittedOrderList {\n");
            sb.Append("  Orders: ").Append(Orders).Append("\n");
            sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  HadError: ").Append(HadError).Append("\n");
            
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
            return this.Equals(obj as SubmittedOrderList);
        }

        /// <summary>
        /// Returns true if SubmittedOrderList instances are equal
        /// </summary>
        /// <param name="other">Instance of SubmittedOrderList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubmittedOrderList other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Orders == other.Orders ||
                    this.Orders != null &&
                    this.Orders.SequenceEqual(other.Orders)
                ) && 
                (
                    this.TotalPages == other.TotalPages ||
                    this.TotalPages != null &&
                    this.TotalPages.Equals(other.TotalPages)
                ) && 
                (
                    this.Page == other.Page ||
                    this.Page != null &&
                    this.Page.Equals(other.Page)
                ) && 
                (
                    this.HadError == other.HadError ||
                    this.HadError != null &&
                    this.HadError.Equals(other.HadError)
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
                
                if (this.Orders != null)
                    hash = hash * 59 + this.Orders.GetHashCode();
                
                if (this.TotalPages != null)
                    hash = hash * 59 + this.TotalPages.GetHashCode();
                
                if (this.Page != null)
                    hash = hash * 59 + this.Page.GetHashCode();
                
                if (this.HadError != null)
                    hash = hash * 59 + this.HadError.GetHashCode();
                
                return hash;
            }
        }

    }


}
