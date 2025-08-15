
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsArtifactAndLogRetentionResponse
    {
        /// <summary>
        /// The number of days artifacts and logs are retained
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("days")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Days { get; set; }

        /// <summary>
        /// The maximum number of days that can be configured
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maximum_allowed_days")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaximumAllowedDays { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsArtifactAndLogRetentionResponse" /> class.
        /// </summary>
        /// <param name="days">
        /// The number of days artifacts and logs are retained
        /// </param>
        /// <param name="maximumAllowedDays">
        /// The maximum number of days that can be configured
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionsArtifactAndLogRetentionResponse(
            int days,
            int maximumAllowedDays)
        {
            this.Days = days;
            this.MaximumAllowedDays = maximumAllowedDays;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsArtifactAndLogRetentionResponse" /> class.
        /// </summary>
        public ActionsArtifactAndLogRetentionResponse()
        {
        }
    }
}