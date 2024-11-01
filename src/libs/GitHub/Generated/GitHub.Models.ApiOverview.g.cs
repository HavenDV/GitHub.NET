
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Api Overview
    /// </summary>
    public sealed partial class ApiOverview
    {
        /// <summary>
        /// Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verifiable_password_authentication")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool VerifiablePasswordAuthentication { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ssh_key_fingerprints")]
        public global::GitHub.ApiOverviewSshKeyFingerprints? SshKeyFingerprints { get; set; }

        /// <summary>
        /// Example: [ssh-ed25519 ABCDEFGHIJKLMNOPQRSTUVWXYZ]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ssh_keys")]
        public global::System.Collections.Generic.IList<string>? SshKeys { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hooks")]
        public global::System.Collections.Generic.IList<string>? Hooks { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("github_enterprise_importer")]
        public global::System.Collections.Generic.IList<string>? GithubEnterpriseImporter { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web")]
        public global::System.Collections.Generic.IList<string>? Web { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api")]
        public global::System.Collections.Generic.IList<string>? Api { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git")]
        public global::System.Collections.Generic.IList<string>? Git { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packages")]
        public global::System.Collections.Generic.IList<string>? Packages { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        public global::System.Collections.Generic.IList<string>? Pages { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("importer")]
        public global::System.Collections.Generic.IList<string>? Importer { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        public global::System.Collections.Generic.IList<string>? Actions { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions_macos")]
        public global::System.Collections.Generic.IList<string>? ActionsMacos { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codespaces")]
        public global::System.Collections.Generic.IList<string>? Codespaces { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependabot")]
        public global::System.Collections.Generic.IList<string>? Dependabot { get; set; }

        /// <summary>
        /// Example: [192.0.2.1]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("copilot")]
        public global::System.Collections.Generic.IList<string>? Copilot { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domains")]
        public global::GitHub.ApiOverviewDomains? Domains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::GitHub.ApiOverview? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::GitHub.ApiOverview),
                jsonSerializerContext) as global::GitHub.ApiOverview;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::GitHub.ApiOverview? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::GitHub.ApiOverview>(
                json,
                jsonSerializerOptions);
        }

    }
}