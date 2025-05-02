
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BillingUsageReportUserUsageItem
    {
        /// <summary>
        /// Date of the usage line item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Date { get; set; }

        /// <summary>
        /// Product name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Product { get; set; }

        /// <summary>
        /// SKU name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sku")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sku { get; set; }

        /// <summary>
        /// Quantity of the usage line item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Quantity { get; set; }

        /// <summary>
        /// Unit type of the usage line item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unitType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UnitType { get; set; }

        /// <summary>
        /// Price per unit of the usage line item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricePerUnit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PricePerUnit { get; set; }

        /// <summary>
        /// Gross amount of the usage line item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grossAmount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double GrossAmount { get; set; }

        /// <summary>
        /// Discount amount of the usage line item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discountAmount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DiscountAmount { get; set; }

        /// <summary>
        /// Net amount of the usage line item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("netAmount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double NetAmount { get; set; }

        /// <summary>
        /// Name of the repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositoryName")]
        public string? RepositoryName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingUsageReportUserUsageItem" /> class.
        /// </summary>
        /// <param name="date">
        /// Date of the usage line item.
        /// </param>
        /// <param name="product">
        /// Product name.
        /// </param>
        /// <param name="sku">
        /// SKU name.
        /// </param>
        /// <param name="quantity">
        /// Quantity of the usage line item.
        /// </param>
        /// <param name="unitType">
        /// Unit type of the usage line item.
        /// </param>
        /// <param name="pricePerUnit">
        /// Price per unit of the usage line item.
        /// </param>
        /// <param name="grossAmount">
        /// Gross amount of the usage line item.
        /// </param>
        /// <param name="discountAmount">
        /// Discount amount of the usage line item.
        /// </param>
        /// <param name="netAmount">
        /// Net amount of the usage line item.
        /// </param>
        /// <param name="repositoryName">
        /// Name of the repository.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingUsageReportUserUsageItem(
            string date,
            string product,
            string sku,
            int quantity,
            string unitType,
            double pricePerUnit,
            double grossAmount,
            double discountAmount,
            double netAmount,
            string? repositoryName)
        {
            this.Date = date ?? throw new global::System.ArgumentNullException(nameof(date));
            this.Product = product ?? throw new global::System.ArgumentNullException(nameof(product));
            this.Sku = sku ?? throw new global::System.ArgumentNullException(nameof(sku));
            this.Quantity = quantity;
            this.UnitType = unitType ?? throw new global::System.ArgumentNullException(nameof(unitType));
            this.PricePerUnit = pricePerUnit;
            this.GrossAmount = grossAmount;
            this.DiscountAmount = discountAmount;
            this.NetAmount = netAmount;
            this.RepositoryName = repositoryName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingUsageReportUserUsageItem" /> class.
        /// </summary>
        public BillingUsageReportUserUsageItem()
        {
        }
    }
}