﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.Orders
{
    /// <summary>
    /// List of item approvals gathered during the approval process.
    /// </summary>
    [DataContract]
    public partial class OrderItemApprovals : IEquatable<OrderItemApprovals>, IValidatableObject
    {
        /// <summary>
        /// The approval process type required for the order item.
        /// </summary>
        /// <value>The approval process type required for the order item.</value>
        [DataMember(Name = "ApprovalType", EmitDefaultValue = false)]
        public ItemApprovalType ApprovalType { get; set; }
        /// <summary>
        /// Current status of the order item approval.
        /// </summary>
        /// <value>Current status of the order item approval.</value>
        [DataMember(Name = "ApprovalStatus", EmitDefaultValue = false)]
        public ItemApprovalStatus ApprovalStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderItemApprovals" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public OrderItemApprovals() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderItemApprovals" /> class.
        /// </summary>
        /// <param name="orderItemId">The unique identifier of the order item. (required).</param>
        /// <param name="approvalType">The approval process type required for the order item. (required).</param>
        /// <param name="approvalStatus">Current status of the order item approval. (required).</param>
        /// <param name="itemApprovals">itemApprovals (required).</param>
        public OrderItemApprovals(string orderItemId = default(string), ItemApprovalType approvalType = default(ItemApprovalType), ItemApprovalStatus approvalStatus = default(ItemApprovalStatus), List<ItemApproval> itemApprovals = default(List<ItemApproval>))
        {
            // to ensure "orderItemId" is required (not null)
            if (orderItemId == null)
            {
                throw new InvalidDataException("orderItemId is a required property for OrderItemApprovals and cannot be null");
            }
            else
            {
                this.OrderItemId = orderItemId;
            }
            // to ensure "approvalType" is required (not null)
            if (approvalType == null)
            {
                throw new InvalidDataException("approvalType is a required property for OrderItemApprovals and cannot be null");
            }
            else
            {
                this.ApprovalType = approvalType;
            }
            // to ensure "approvalStatus" is required (not null)
            if (approvalStatus == null)
            {
                throw new InvalidDataException("approvalStatus is a required property for OrderItemApprovals and cannot be null");
            }
            else
            {
                this.ApprovalStatus = approvalStatus;
            }
            // to ensure "itemApprovals" is required (not null)
            if (itemApprovals == null)
            {
                throw new InvalidDataException("itemApprovals is a required property for OrderItemApprovals and cannot be null");
            }
            else
            {
                this.ItemApprovals = itemApprovals;
            }
        }

        /// <summary>
        /// The unique identifier of the order item.
        /// </summary>
        /// <value>The unique identifier of the order item.</value>
        [DataMember(Name = "OrderItemId", EmitDefaultValue = false)]
        public string OrderItemId { get; set; }



        /// <summary>
        /// Gets or Sets ItemApprovals
        /// </summary>
        [DataMember(Name = "ItemApprovals", EmitDefaultValue = false)]
        public List<ItemApproval> ItemApprovals { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderItemApprovals {\n");
            sb.Append("  OrderItemId: ").Append(OrderItemId).Append("\n");
            sb.Append("  ApprovalType: ").Append(ApprovalType).Append("\n");
            sb.Append("  ApprovalStatus: ").Append(ApprovalStatus).Append("\n");
            sb.Append("  ItemApprovals: ").Append(ItemApprovals).Append("\n");
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
            return this.Equals(input as OrderItemApprovals);
        }

        /// <summary>
        /// Returns true if OrderItemApprovals instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderItemApprovals to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderItemApprovals input)
        {
            if (input == null)
                return false;

            return
                (
                    this.OrderItemId == input.OrderItemId ||
                    (this.OrderItemId != null &&
                    this.OrderItemId.Equals(input.OrderItemId))
                ) &&
                (
                    this.ApprovalType == input.ApprovalType ||
                    (this.ApprovalType != null &&
                    this.ApprovalType.Equals(input.ApprovalType))
                ) &&
                (
                    this.ApprovalStatus == input.ApprovalStatus ||
                    (this.ApprovalStatus != null &&
                    this.ApprovalStatus.Equals(input.ApprovalStatus))
                ) &&
                (
                    this.ItemApprovals == input.ItemApprovals ||
                    this.ItemApprovals != null
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
                if (this.OrderItemId != null)
                    hashCode = hashCode * 59 + this.OrderItemId.GetHashCode();
                if (this.ApprovalType != null)
                    hashCode = hashCode * 59 + this.ApprovalType.GetHashCode();
                if (this.ApprovalStatus != null)
                    hashCode = hashCode * 59 + this.ApprovalStatus.GetHashCode();
                if (this.ItemApprovals != null)
                    hashCode = hashCode * 59 + this.ItemApprovals.GetHashCode();
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