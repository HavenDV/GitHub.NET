
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GitCommitVerification
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verified")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Verified { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Signature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Payload { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verified_at")]
        public string? VerifiedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GitCommitVerification" /> class.
        /// </summary>
        /// <param name="verified"></param>
        /// <param name="reason"></param>
        /// <param name="signature"></param>
        /// <param name="payload"></param>
        /// <param name="verifiedAt"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GitCommitVerification(
            bool verified,
            string reason,
            string? signature,
            string? payload,
            string? verifiedAt)
        {
            this.Verified = verified;
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
            this.Signature = signature ?? throw new global::System.ArgumentNullException(nameof(signature));
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
            this.VerifiedAt = verifiedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GitCommitVerification" /> class.
        /// </summary>
        public GitCommitVerification()
        {
        }
    }
}