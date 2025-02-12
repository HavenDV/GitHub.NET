
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The historical version of a ruleset
    /// </summary>
    public sealed partial class RulesetVersion
    {
        /// <summary>
        /// The ID of the previous version of the ruleset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VersionId { get; set; }

        /// <summary>
        /// The actor who updated the ruleset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.RulesetVersionActor Actor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RulesetVersion" /> class.
        /// </summary>
        /// <param name="versionId">
        /// The ID of the previous version of the ruleset
        /// </param>
        /// <param name="actor">
        /// The actor who updated the ruleset
        /// </param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RulesetVersion(
            int versionId,
            global::GitHub.RulesetVersionActor actor,
            global::System.DateTime updatedAt)
        {
            this.VersionId = versionId;
            this.Actor = actor ?? throw new global::System.ArgumentNullException(nameof(actor));
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RulesetVersion" /> class.
        /// </summary>
        public RulesetVersion()
        {
        }
    }
}