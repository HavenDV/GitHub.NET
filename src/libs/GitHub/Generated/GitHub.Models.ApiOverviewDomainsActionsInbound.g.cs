
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiOverviewDomainsActionsInbound
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_domains")]
        public global::System.Collections.Generic.IList<string>? FullDomains { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wildcard_domains")]
        public global::System.Collections.Generic.IList<string>? WildcardDomains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiOverviewDomainsActionsInbound" /> class.
        /// </summary>
        /// <param name="fullDomains"></param>
        /// <param name="wildcardDomains"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiOverviewDomainsActionsInbound(
            global::System.Collections.Generic.IList<string>? fullDomains,
            global::System.Collections.Generic.IList<string>? wildcardDomains)
        {
            this.FullDomains = fullDomains;
            this.WildcardDomains = wildcardDomains;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiOverviewDomainsActionsInbound" /> class.
        /// </summary>
        public ApiOverviewDomainsActionsInbound()
        {
        }
    }
}