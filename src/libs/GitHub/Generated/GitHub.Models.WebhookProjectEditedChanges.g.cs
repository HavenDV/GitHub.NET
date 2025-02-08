
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The changes to the project if the action was `edited`.
    /// </summary>
    public sealed partial class WebhookProjectEditedChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public global::GitHub.WebhookProjectEditedChangesBody? Body { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public global::GitHub.WebhookProjectEditedChangesName? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectEditedChanges" /> class.
        /// </summary>
        /// <param name="body"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookProjectEditedChanges(
            global::GitHub.WebhookProjectEditedChangesBody? body,
            global::GitHub.WebhookProjectEditedChangesName? name)
        {
            this.Body = body;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectEditedChanges" /> class.
        /// </summary>
        public WebhookProjectEditedChanges()
        {
        }
    }
}