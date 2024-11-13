
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Sigstore Bundle v0.1
    /// </summary>
    public sealed partial class SigstoreBundle0
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mediaType")]
        public string? MediaType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verificationMaterial")]
        public global::GitHub.SigstoreBundle0VerificationMaterial? VerificationMaterial { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dsseEnvelope")]
        public global::GitHub.SigstoreBundle0DsseEnvelope? DsseEnvelope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SigstoreBundle0" /> class.
        /// </summary>
        /// <param name="mediaType"></param>
        /// <param name="verificationMaterial"></param>
        /// <param name="dsseEnvelope"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SigstoreBundle0(
            string? mediaType,
            global::GitHub.SigstoreBundle0VerificationMaterial? verificationMaterial,
            global::GitHub.SigstoreBundle0DsseEnvelope? dsseEnvelope)
        {
            this.MediaType = mediaType;
            this.VerificationMaterial = verificationMaterial;
            this.DsseEnvelope = dsseEnvelope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SigstoreBundle0" /> class.
        /// </summary>
        public SigstoreBundle0()
        {
        }
    }
}