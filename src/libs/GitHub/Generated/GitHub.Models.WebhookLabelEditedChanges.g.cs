
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The changes to the label if the action was `edited`.
    /// </summary>
    public sealed partial class WebhookLabelEditedChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        public global::GitHub.WebhookLabelEditedChangesColor? Color { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public global::GitHub.WebhookLabelEditedChangesDescription? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public global::GitHub.WebhookLabelEditedChangesName? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookLabelEditedChanges" /> class.
        /// </summary>
        /// <param name="color"></param>
        /// <param name="description"></param>
        /// <param name="name"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookLabelEditedChanges(
            global::GitHub.WebhookLabelEditedChangesColor? color,
            global::GitHub.WebhookLabelEditedChangesDescription? description,
            global::GitHub.WebhookLabelEditedChangesName? name)
        {
            this.Color = color;
            this.Description = description;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookLabelEditedChanges" /> class.
        /// </summary>
        public WebhookLabelEditedChanges()
        {
        }
    }
}