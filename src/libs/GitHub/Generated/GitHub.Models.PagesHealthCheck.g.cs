
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Pages Health Check Status
    /// </summary>
    public sealed partial class PagesHealthCheck
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        public global::GitHub.PagesHealthCheckDomain? Domain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alt_domain")]
        public global::GitHub.PagesHealthCheckAltDomain? AltDomain { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}