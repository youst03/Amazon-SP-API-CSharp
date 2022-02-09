/* 
 * Selling Partner API for Listings Items
 *
 * The Selling Partner API for Listings Items (Listings Items API) provides programmatic access to selling partner listings on Amazon. Use this API in collaboration with the Selling Partner API for Product Type Definitions, which you use to retrieve the information about Amazon product types needed to use the Listings Items API.  For more information, see the [Listings Items API Use Case Guide](doc:listings-items-api-v2021-08-01-use-case-guide).
 *
 * OpenAPI spec version: 2021-08-01
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.ListingsItems
{
    /// <summary>
    /// A listings item.
    /// </summary>
    [DataContract]
    public partial class Item :  IEquatable<Item>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Item" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Item() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Item" /> class.
        /// </summary>
        /// <param name="sku">A selling partner provided identifier for an Amazon listing. (required).</param>
        /// <param name="summaries">summaries.</param>
        /// <param name="attributes">attributes.</param>
        /// <param name="issues">issues.</param>
        /// <param name="offers">offers.</param>
        /// <param name="fulfillmentAvailability">Fulfillment availability for the listings item..</param>
        /// <param name="procurement">procurement.</param>
        public Item(string sku = default(string), ItemSummaries summaries = default(ItemSummaries), ItemAttributes attributes = default(ItemAttributes), ItemIssues issues = default(ItemIssues), ItemOffers offers = default(ItemOffers), List<FulfillmentAvailability> fulfillmentAvailability = default(List<FulfillmentAvailability>), ItemProcurement procurement = default(ItemProcurement))
        {
            // to ensure "sku" is required (not null)
            if (sku == null)
            {
                throw new InvalidDataException("sku is a required property for Item and cannot be null");
            }
            else
            {
                this.Sku = sku;
            }
            this.Summaries = summaries;
            this.Attributes = attributes;
            this.Issues = issues;
            this.Offers = offers;
            this.FulfillmentAvailability = fulfillmentAvailability;
            this.Procurement = procurement;
        }
        
        /// <summary>
        /// A selling partner provided identifier for an Amazon listing.
        /// </summary>
        /// <value>A selling partner provided identifier for an Amazon listing.</value>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }

        /// <summary>
        /// Gets or Sets Summaries
        /// </summary>
        [DataMember(Name="summaries", EmitDefaultValue=false)]
        public ItemSummaries Summaries { get; set; }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public ItemAttributes Attributes { get; set; }

        /// <summary>
        /// Gets or Sets Issues
        /// </summary>
        [DataMember(Name="issues", EmitDefaultValue=false)]
        public ItemIssues Issues { get; set; }

        /// <summary>
        /// Gets or Sets Offers
        /// </summary>
        [DataMember(Name="offers", EmitDefaultValue=false)]
        public ItemOffers Offers { get; set; }

        /// <summary>
        /// Fulfillment availability for the listings item.
        /// </summary>
        /// <value>Fulfillment availability for the listings item.</value>
        [DataMember(Name="fulfillmentAvailability", EmitDefaultValue=false)]
        public List<FulfillmentAvailability> FulfillmentAvailability { get; set; }

        /// <summary>
        /// Gets or Sets Procurement
        /// </summary>
        [DataMember(Name="procurement", EmitDefaultValue=false)]
        public ItemProcurement Procurement { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Item {\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  Summaries: ").Append(Summaries).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Issues: ").Append(Issues).Append("\n");
            sb.Append("  Offers: ").Append(Offers).Append("\n");
            sb.Append("  FulfillmentAvailability: ").Append(FulfillmentAvailability).Append("\n");
            sb.Append("  Procurement: ").Append(Procurement).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Item);
        }

        /// <summary>
        /// Returns true if Item instances are equal
        /// </summary>
        /// <param name="input">Instance of Item to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Item input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Sku == input.Sku ||
                    (this.Sku != null &&
                    this.Sku.Equals(input.Sku))
                ) && 
                (
                    this.Summaries == input.Summaries ||
                    (this.Summaries != null &&
                    this.Summaries.Equals(input.Summaries))
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    (this.Attributes != null &&
                    this.Attributes.Equals(input.Attributes))
                ) && 
                (
                    this.Issues == input.Issues ||
                    (this.Issues != null &&
                    this.Issues.Equals(input.Issues))
                ) && 
                (
                    this.Offers == input.Offers ||
                    (this.Offers != null &&
                    this.Offers.Equals(input.Offers))
                ) && 
                (
                    this.FulfillmentAvailability == input.FulfillmentAvailability ||
                    this.FulfillmentAvailability != null &&
                    this.FulfillmentAvailability.SequenceEqual(input.FulfillmentAvailability)
                ) && 
                (
                    this.Procurement == input.Procurement ||
                    (this.Procurement != null &&
                    this.Procurement.Equals(input.Procurement))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Sku != null)
                    hashCode = hashCode * 59 + this.Sku.GetHashCode();
                if (this.Summaries != null)
                    hashCode = hashCode * 59 + this.Summaries.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.Issues != null)
                    hashCode = hashCode * 59 + this.Issues.GetHashCode();
                if (this.Offers != null)
                    hashCode = hashCode * 59 + this.Offers.GetHashCode();
                if (this.FulfillmentAvailability != null)
                    hashCode = hashCode * 59 + this.FulfillmentAvailability.GetHashCode();
                if (this.Procurement != null)
                    hashCode = hashCode * 59 + this.Procurement.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}