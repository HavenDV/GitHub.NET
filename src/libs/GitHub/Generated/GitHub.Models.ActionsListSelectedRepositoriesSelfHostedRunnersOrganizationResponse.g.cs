
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsListSelectedRepositoriesSelfHostedRunnersOrganizationResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories")]
        public global::System.Collections.Generic.IList<global::GitHub.Repository>? Repositories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsListSelectedRepositoriesSelfHostedRunnersOrganizationResponse" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="repositories"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionsListSelectedRepositoriesSelfHostedRunnersOrganizationResponse(
            int? totalCount,
            global::System.Collections.Generic.IList<global::GitHub.Repository>? repositories)
        {
            this.TotalCount = totalCount;
            this.Repositories = repositories;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsListSelectedRepositoriesSelfHostedRunnersOrganizationResponse" /> class.
        /// </summary>
        public ActionsListSelectedRepositoriesSelfHostedRunnersOrganizationResponse()
        {
        }
    }
}