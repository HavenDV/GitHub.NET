
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Merges must be performed via a merge queue.
    /// </summary>
    public sealed partial class RepositoryRuleMergeQueue
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.RepositoryRuleMergeQueueTypeJsonConverter))]
        public global::GitHub.RepositoryRuleMergeQueueType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::GitHub.RepositoryRuleMergeQueueParameters? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleMergeQueue" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="parameters"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RepositoryRuleMergeQueue(
            global::GitHub.RepositoryRuleMergeQueueType type,
            global::GitHub.RepositoryRuleMergeQueueParameters? parameters)
        {
            this.Type = type;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleMergeQueue" /> class.
        /// </summary>
        public RepositoryRuleMergeQueue()
        {
        }
    }
}