
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DependabotUpdateRepositoryAccessForOrgRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_ids_to_add")]
        public global::System.Collections.Generic.IList<int>? RepositoryIdsToAdd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_ids_to_remove")]
        public global::System.Collections.Generic.IList<int>? RepositoryIdsToRemove { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotUpdateRepositoryAccessForOrgRequest" /> class.
        /// </summary>
        /// <param name="repositoryIdsToAdd"></param>
        /// <param name="repositoryIdsToRemove"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DependabotUpdateRepositoryAccessForOrgRequest(
            global::System.Collections.Generic.IList<int>? repositoryIdsToAdd,
            global::System.Collections.Generic.IList<int>? repositoryIdsToRemove)
        {
            this.RepositoryIdsToAdd = repositoryIdsToAdd;
            this.RepositoryIdsToRemove = repositoryIdsToRemove;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotUpdateRepositoryAccessForOrgRequest" /> class.
        /// </summary>
        public DependabotUpdateRepositoryAccessForOrgRequest()
        {
        }
    }
}