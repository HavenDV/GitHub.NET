
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PrivateRegistriesGetOrgPublicKeyResponse
    {
        /// <summary>
        /// The identifier for the key.<br/>
        /// Example: 012345678912345678
        /// </summary>
        /// <example>012345678912345678</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeyId { get; set; }

        /// <summary>
        /// The Base64 encoded public key.<br/>
        /// Example: 2Sg8iYjAxxmI2LvUXpJjkYrMxURPc8r+dB7TJyvv1234
        /// </summary>
        /// <example>2Sg8iYjAxxmI2LvUXpJjkYrMxURPc8r+dB7TJyvv1234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateRegistriesGetOrgPublicKeyResponse" /> class.
        /// </summary>
        /// <param name="keyId">
        /// The identifier for the key.<br/>
        /// Example: 012345678912345678
        /// </param>
        /// <param name="key">
        /// The Base64 encoded public key.<br/>
        /// Example: 2Sg8iYjAxxmI2LvUXpJjkYrMxURPc8r+dB7TJyvv1234
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateRegistriesGetOrgPublicKeyResponse(
            string keyId,
            string key)
        {
            this.KeyId = keyId ?? throw new global::System.ArgumentNullException(nameof(keyId));
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateRegistriesGetOrgPublicKeyResponse" /> class.
        /// </summary>
        public PrivateRegistriesGetOrgPublicKeyResponse()
        {
        }
    }
}