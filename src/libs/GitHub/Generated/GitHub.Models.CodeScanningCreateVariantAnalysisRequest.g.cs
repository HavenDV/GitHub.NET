
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeScanningCreateVariantAnalysisRequest
    {
        /// <summary>
        /// The language targeted by the CodeQL query
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeScanningVariantAnalysisLanguageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.CodeScanningVariantAnalysisLanguage Language { get; set; }

        /// <summary>
        /// A Base64-encoded tarball containing a CodeQL query and all its dependencies
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query_pack")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string QueryPack { get; set; }

        /// <summary>
        /// List of repository names (in the form `owner/repo-name`) to run the query against. Precisely one property from `repositories`, `repository_lists` and `repository_owners` is required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories")]
        public global::System.Collections.Generic.IList<string>? Repositories { get; set; }

        /// <summary>
        /// List of repository lists to run the query against. Precisely one property from `repositories`, `repository_lists` and `repository_owners` is required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_lists")]
        public global::System.Collections.Generic.IList<string>? RepositoryLists { get; set; }

        /// <summary>
        /// List of organization or user names whose repositories the query should be run against. Precisely one property from `repositories`, `repository_lists` and `repository_owners` is required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_owners")]
        public global::System.Collections.Generic.IList<string>? RepositoryOwners { get; set; }

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
        public static global::GitHub.CodeScanningCreateVariantAnalysisRequest? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::GitHub.CodeScanningCreateVariantAnalysisRequest),
                jsonSerializerContext) as global::GitHub.CodeScanningCreateVariantAnalysisRequest;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::GitHub.CodeScanningCreateVariantAnalysisRequest? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::GitHub.CodeScanningCreateVariantAnalysisRequest>(
                json,
                jsonSerializerOptions);
        }

    }
}