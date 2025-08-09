
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsArtifactAndLogRetention
    {
        /// <summary>
        /// The number of days to retain artifacts and logs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("days")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Days { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsArtifactAndLogRetention" /> class.
        /// </summary>
        /// <param name="days">
        /// The number of days to retain artifacts and logs
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionsArtifactAndLogRetention(
            int days)
        {
            this.Days = days;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsArtifactAndLogRetention" /> class.
        /// </summary>
        public ActionsArtifactAndLogRetention()
        {
        }
    }
}