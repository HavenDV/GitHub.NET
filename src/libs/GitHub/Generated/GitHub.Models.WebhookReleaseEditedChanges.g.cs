
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookReleaseEditedChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public global::GitHub.WebhookReleaseEditedChangesBody? Body { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public global::GitHub.WebhookReleaseEditedChangesName? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("make_latest")]
        public global::GitHub.WebhookReleaseEditedChangesMakeLatest? MakeLatest { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookReleaseEditedChanges" /> class.
        /// </summary>
        /// <param name="body"></param>
        /// <param name="name"></param>
        /// <param name="makeLatest"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookReleaseEditedChanges(
            global::GitHub.WebhookReleaseEditedChangesBody? body,
            global::GitHub.WebhookReleaseEditedChangesName? name,
            global::GitHub.WebhookReleaseEditedChangesMakeLatest? makeLatest)
        {
            this.Body = body;
            this.Name = name;
            this.MakeLatest = makeLatest;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookReleaseEditedChanges" /> class.
        /// </summary>
        public WebhookReleaseEditedChanges()
        {
        }
    }
}