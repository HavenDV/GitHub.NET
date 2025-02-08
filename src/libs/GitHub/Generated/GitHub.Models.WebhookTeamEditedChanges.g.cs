
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The changes to the team if the action was `edited`.
    /// </summary>
    public sealed partial class WebhookTeamEditedChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public global::GitHub.WebhookTeamEditedChangesDescription? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public global::GitHub.WebhookTeamEditedChangesName? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privacy")]
        public global::GitHub.WebhookTeamEditedChangesPrivacy? Privacy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notification_setting")]
        public global::GitHub.WebhookTeamEditedChangesNotificationSetting? NotificationSetting { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        public global::GitHub.WebhookTeamEditedChangesRepository? Repository { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookTeamEditedChanges" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="name"></param>
        /// <param name="privacy"></param>
        /// <param name="notificationSetting"></param>
        /// <param name="repository"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookTeamEditedChanges(
            global::GitHub.WebhookTeamEditedChangesDescription? description,
            global::GitHub.WebhookTeamEditedChangesName? name,
            global::GitHub.WebhookTeamEditedChangesPrivacy? privacy,
            global::GitHub.WebhookTeamEditedChangesNotificationSetting? notificationSetting,
            global::GitHub.WebhookTeamEditedChangesRepository? repository)
        {
            this.Description = description;
            this.Name = name;
            this.Privacy = privacy;
            this.NotificationSetting = notificationSetting;
            this.Repository = repository;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookTeamEditedChanges" /> class.
        /// </summary>
        public WebhookTeamEditedChanges()
        {
        }
    }
}