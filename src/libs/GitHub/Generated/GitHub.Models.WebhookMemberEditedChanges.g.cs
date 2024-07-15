
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The changes to the collaborator permissions
    /// </summary>
    public sealed partial class WebhookMemberEditedChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("old_permission")]
        public global::GitHub.WebhookMemberEditedChangesOldPermission? OldPermission { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission")]
        public global::GitHub.WebhookMemberEditedChangesPermission? Permission { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}