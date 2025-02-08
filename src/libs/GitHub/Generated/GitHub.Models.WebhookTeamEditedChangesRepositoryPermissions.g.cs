
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookTeamEditedChangesRepositoryPermissions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.WebhookTeamEditedChangesRepositoryPermissionsFrom From { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookTeamEditedChangesRepositoryPermissions" /> class.
        /// </summary>
        /// <param name="from"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookTeamEditedChangesRepositoryPermissions(
            global::GitHub.WebhookTeamEditedChangesRepositoryPermissionsFrom from)
        {
            this.From = from ?? throw new global::System.ArgumentNullException(nameof(from));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookTeamEditedChangesRepositoryPermissions" /> class.
        /// </summary>
        public WebhookTeamEditedChangesRepositoryPermissions()
        {
        }
    }
}