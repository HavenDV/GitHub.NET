
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Permissions requested, categorized by type of permission.
    /// </summary>
    public sealed partial class OrganizationProgrammaticAccessGrantRequestPermissions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public global::GitHub.OrganizationProgrammaticAccessGrantRequestPermissionsOrganization? Organization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        public global::GitHub.OrganizationProgrammaticAccessGrantRequestPermissionsRepository? Repository { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("other")]
        public global::GitHub.OrganizationProgrammaticAccessGrantRequestPermissionsOther? Other { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}