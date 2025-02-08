
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The changes to the comment if the action was `edited`.
    /// </summary>
    public sealed partial class WebhookPullRequestEditedChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base")]
        public global::GitHub.WebhookPullRequestEditedChangesBase? Base { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public global::GitHub.WebhookPullRequestEditedChangesBody? Body { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public global::GitHub.WebhookPullRequestEditedChangesTitle? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestEditedChanges" /> class.
        /// </summary>
        /// <param name="base"></param>
        /// <param name="body"></param>
        /// <param name="title"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookPullRequestEditedChanges(
            global::GitHub.WebhookPullRequestEditedChangesBase? @base,
            global::GitHub.WebhookPullRequestEditedChangesBody? body,
            global::GitHub.WebhookPullRequestEditedChangesTitle? title)
        {
            this.Base = @base;
            this.Body = body;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestEditedChanges" /> class.
        /// </summary>
        public WebhookPullRequestEditedChanges()
        {
        }
    }
}