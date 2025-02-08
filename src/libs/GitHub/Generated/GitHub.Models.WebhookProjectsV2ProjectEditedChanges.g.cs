
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookProjectsV2ProjectEditedChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public global::GitHub.WebhookProjectsV2ProjectEditedChangesDescription? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public")]
        public global::GitHub.WebhookProjectsV2ProjectEditedChangesPublic? Public { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("short_description")]
        public global::GitHub.WebhookProjectsV2ProjectEditedChangesShortDescription? ShortDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public global::GitHub.WebhookProjectsV2ProjectEditedChangesTitle? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectsV2ProjectEditedChanges" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="public"></param>
        /// <param name="shortDescription"></param>
        /// <param name="title"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookProjectsV2ProjectEditedChanges(
            global::GitHub.WebhookProjectsV2ProjectEditedChangesDescription? description,
            global::GitHub.WebhookProjectsV2ProjectEditedChangesPublic? @public,
            global::GitHub.WebhookProjectsV2ProjectEditedChangesShortDescription? shortDescription,
            global::GitHub.WebhookProjectsV2ProjectEditedChangesTitle? title)
        {
            this.Description = description;
            this.Public = @public;
            this.ShortDescription = shortDescription;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectsV2ProjectEditedChanges" /> class.
        /// </summary>
        public WebhookProjectsV2ProjectEditedChanges()
        {
        }
    }
}