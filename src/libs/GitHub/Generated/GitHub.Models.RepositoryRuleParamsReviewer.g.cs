
#nullable enable

namespace GitHub
{
    /// <summary>
    /// A required reviewing team
    /// </summary>
    public sealed partial class RepositoryRuleParamsReviewer
    {
        /// <summary>
        /// ID of the reviewer which must review changes to matching files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// The type of the reviewer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.RepositoryRuleParamsReviewerTypeJsonConverter))]
        public global::GitHub.RepositoryRuleParamsReviewerType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleParamsReviewer" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the reviewer which must review changes to matching files.
        /// </param>
        /// <param name="type">
        /// The type of the reviewer
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepositoryRuleParamsReviewer(
            int id,
            global::GitHub.RepositoryRuleParamsReviewerType type)
        {
            this.Id = id;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleParamsReviewer" /> class.
        /// </summary>
        public RepositoryRuleParamsReviewer()
        {
        }
    }
}