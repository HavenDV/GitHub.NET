
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CredentialsRevokeRequest
    {
        /// <summary>
        /// A list of credentials to be revoked, up to 1000 per request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Credentials { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialsRevokeRequest" /> class.
        /// </summary>
        /// <param name="credentials">
        /// A list of credentials to be revoked, up to 1000 per request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CredentialsRevokeRequest(
            global::System.Collections.Generic.IList<string> credentials)
        {
            this.Credentials = credentials ?? throw new global::System.ArgumentNullException(nameof(credentials));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialsRevokeRequest" /> class.
        /// </summary>
        public CredentialsRevokeRequest()
        {
        }
    }
}