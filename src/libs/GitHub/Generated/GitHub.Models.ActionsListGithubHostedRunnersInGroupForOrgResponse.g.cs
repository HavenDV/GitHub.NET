
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsListGithubHostedRunnersInGroupForOrgResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runners")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::GitHub.ActionsHostedRunner> Runners { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsListGithubHostedRunnersInGroupForOrgResponse" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="runners"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ActionsListGithubHostedRunnersInGroupForOrgResponse(
            double totalCount,
            global::System.Collections.Generic.IList<global::GitHub.ActionsHostedRunner> runners)
        {
            this.TotalCount = totalCount;
            this.Runners = runners ?? throw new global::System.ArgumentNullException(nameof(runners));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsListGithubHostedRunnersInGroupForOrgResponse" /> class.
        /// </summary>
        public ActionsListGithubHostedRunnersInGroupForOrgResponse()
        {
        }
    }
}