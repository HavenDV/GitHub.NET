
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeScanningAutofix
    {
        /// <summary>
        /// The status of an autofix.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeScanningAutofixStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.CodeScanningAutofixStatus Status { get; set; }

        /// <summary>
        /// The description of an autofix.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Description { get; set; }

        /// <summary>
        /// The start time of an autofix in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime StartedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningAutofix" /> class.
        /// </summary>
        /// <param name="status">
        /// The status of an autofix.
        /// </param>
        /// <param name="description">
        /// The description of an autofix.
        /// </param>
        /// <param name="startedAt">
        /// The start time of an autofix in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CodeScanningAutofix(
            global::GitHub.CodeScanningAutofixStatus status,
            string? description,
            global::System.DateTime startedAt = default!)
        {
            this.Status = status;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.StartedAt = startedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningAutofix" /> class.
        /// </summary>
        public CodeScanningAutofix()
        {
        }
    }
}