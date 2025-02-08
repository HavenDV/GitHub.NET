
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookProjectCardMovedChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.WebhookProjectCardMovedChangesColumnId ColumnId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectCardMovedChanges" /> class.
        /// </summary>
        /// <param name="columnId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookProjectCardMovedChanges(
            global::GitHub.WebhookProjectCardMovedChangesColumnId columnId)
        {
            this.ColumnId = columnId ?? throw new global::System.ArgumentNullException(nameof(columnId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectCardMovedChanges" /> class.
        /// </summary>
        public WebhookProjectCardMovedChanges()
        {
        }
    }
}