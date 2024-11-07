
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DependencyGraphSpdxSbomSbom
    {
        /// <summary>
        /// The SPDX identifier for the SPDX document.<br/>
        /// Example: SPDXRef-DOCUMENT
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("SPDXID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SPDXID { get; set; }

        /// <summary>
        /// The version of the SPDX specification that this document conforms to.<br/>
        /// Example: SPDX-2.3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spdxVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpdxVersion { get; set; }

        /// <summary>
        /// An optional comment about the SPDX document.<br/>
        /// Example: Exact versions could not be resolved for some packages. For more information: https://docs.github.com/en/code-security/supply-chain-security/understanding-your-software-supply-chain/
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creationInfo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.DependencyGraphSpdxSbomSbomCreationInfo CreationInfo { get; set; }

        /// <summary>
        /// The name of the SPDX document.<br/>
        /// Example: github/github
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The license under which the SPDX document is licensed.<br/>
        /// Example: CC0-1.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataLicense")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DataLicense { get; set; }

        /// <summary>
        /// The namespace for the SPDX document.<br/>
        /// Example: https://spdx.org/spdxdocs/protobom/15e41dd2-f961-4f4d-b8dc-f8f57ad70d57
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentNamespace")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DocumentNamespace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::GitHub.DependencyGraphSpdxSbomSbomPackage> Packages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relationships")]
        public global::System.Collections.Generic.IList<global::GitHub.DependencyGraphSpdxSbomSbomRelationship>? Relationships { get; set; }

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
        public static global::GitHub.DependencyGraphSpdxSbomSbom? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::GitHub.DependencyGraphSpdxSbomSbom),
                jsonSerializerContext) as global::GitHub.DependencyGraphSpdxSbomSbom;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::GitHub.DependencyGraphSpdxSbomSbom? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::GitHub.DependencyGraphSpdxSbomSbom>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::GitHub.DependencyGraphSpdxSbomSbom?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::GitHub.DependencyGraphSpdxSbomSbom),
                jsonSerializerContext).ConfigureAwait(false)) as global::GitHub.DependencyGraphSpdxSbomSbom;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::GitHub.DependencyGraphSpdxSbomSbom?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::GitHub.DependencyGraphSpdxSbomSbom?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}