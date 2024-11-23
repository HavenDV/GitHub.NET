
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BillingUsageReport
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usageItems")]
        public global::System.Collections.Generic.IList<global::GitHub.BillingUsageReportUsageItem>? UsageItems { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingUsageReport" /> class.
        /// </summary>
        /// <param name="usageItems"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BillingUsageReport(
            global::System.Collections.Generic.IList<global::GitHub.BillingUsageReportUsageItem>? usageItems)
        {
            this.UsageItems = usageItems;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingUsageReport" /> class.
        /// </summary>
        public BillingUsageReport()
        {
        }
    }
}