
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The changes to the milestone if the action was `edited`.
    /// </summary>
    public sealed partial class WebhookMilestoneEditedChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public global::GitHub.WebhookMilestoneEditedChangesDescription? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("due_on")]
        public global::GitHub.WebhookMilestoneEditedChangesDueOn? DueOn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public global::GitHub.WebhookMilestoneEditedChangesTitle? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookMilestoneEditedChanges" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="dueOn"></param>
        /// <param name="title"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookMilestoneEditedChanges(
            global::GitHub.WebhookMilestoneEditedChangesDescription? description,
            global::GitHub.WebhookMilestoneEditedChangesDueOn? dueOn,
            global::GitHub.WebhookMilestoneEditedChangesTitle? title)
        {
            this.Description = description;
            this.DueOn = dueOn;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookMilestoneEditedChanges" /> class.
        /// </summary>
        public WebhookMilestoneEditedChanges()
        {
        }
    }
}