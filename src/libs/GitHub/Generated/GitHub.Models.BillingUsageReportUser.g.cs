
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BillingUsageReportUser
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usageItems")]
        public global::System.Collections.Generic.IList<global::GitHub.BillingUsageReportUserUsageItem>? UsageItems { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingUsageReportUser" /> class.
        /// </summary>
        /// <param name="usageItems"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingUsageReportUser(
            global::System.Collections.Generic.IList<global::GitHub.BillingUsageReportUserUsageItem>? usageItems)
        {
            this.UsageItems = usageItems;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingUsageReportUser" /> class.
        /// </summary>
        public BillingUsageReportUser()
        {
        }
    }
}