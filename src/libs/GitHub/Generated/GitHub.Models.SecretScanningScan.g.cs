
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Information on a single scan performed by secret scanning on the repository
    /// </summary>
    public sealed partial class SecretScanningScan
    {
        /// <summary>
        /// The type of scan
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The state of the scan. Either "completed" or "running"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// The time that the scan was completed. Empty if the scan is active
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// The time that the scan was started
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningScan" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of scan
        /// </param>
        /// <param name="status">
        /// The state of the scan. Either "completed" or "running"
        /// </param>
        /// <param name="completedAt">
        /// The time that the scan was completed. Empty if the scan is active
        /// </param>
        /// <param name="startedAt">
        /// The time that the scan was started
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SecretScanningScan(
            string? type,
            string? status,
            global::System.DateTime? completedAt,
            global::System.DateTime? startedAt)
        {
            this.Type = type;
            this.Status = status;
            this.CompletedAt = completedAt;
            this.StartedAt = startedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningScan" /> class.
        /// </summary>
        public SecretScanningScan()
        {
        }
    }
}