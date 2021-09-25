/* 
 * Selling Partner API for Pricing
 *
 * The Selling Partner API for Pricing helps you programmatically retrieve product pricing and offer information for Amazon Marketplace products.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.ProductPricing
{
    /// <summary>
    /// Indicates the condition of the item. Possible values: New, Used, Collectible, Refurbished, Club.
    /// </summary>
    /// <value>Indicates the condition of the item. Possible values: New, Used, Collectible, Refurbished, Club.</value>

    public enum ConditionType
    {

        /// <summary>
        /// Enum New for value: New
        /// </summary>

        New,

        /// <summary>
        /// Enum Used for value: Used
        /// </summary>

        Used,

        /// <summary>
        /// Enum Collectible for value: Collectible
        /// </summary>

        Collectible,

        /// <summary>
        /// Enum Refurbished for value: Refurbished
        /// </summary>

        Refurbished,

        /// <summary>
        /// Enum Club for value: Club
        /// </summary>

        Club
    }

}