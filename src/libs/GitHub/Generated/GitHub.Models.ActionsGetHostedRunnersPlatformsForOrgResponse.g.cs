
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsGetHostedRunnersPlatformsForOrgResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platforms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Platforms { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsGetHostedRunnersPlatformsForOrgResponse" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="platforms"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionsGetHostedRunnersPlatformsForOrgResponse(
            int totalCount,
            global::System.Collections.Generic.IList<string> platforms)
        {
            this.TotalCount = totalCount;
            this.Platforms = platforms ?? throw new global::System.ArgumentNullException(nameof(platforms));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsGetHostedRunnersPlatformsForOrgResponse" /> class.
        /// </summary>
        public ActionsGetHostedRunnersPlatformsForOrgResponse()
        {
        }
    }
}