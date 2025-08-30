
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Provides details of a hosted runner image
    /// </summary>
    public sealed partial class ActionsHostedRunnerCuratedImage
    {
        /// <summary>
        /// The ID of the image. Use this ID for the `image` parameter when creating a new larger runner.<br/>
        /// Example: ubuntu-20.04
        /// </summary>
        /// <example>ubuntu-20.04</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The operating system of the image.<br/>
        /// Example: linux-x64
        /// </summary>
        /// <example>linux-x64</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Platform { get; set; }

        /// <summary>
        /// Image size in GB.<br/>
        /// Example: 86
        /// </summary>
        /// <example>86</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_gb")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SizeGb { get; set; }

        /// <summary>
        /// Display name for this image.<br/>
        /// Example: 20.04
        /// </summary>
        /// <example>20.04</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// The image provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.ActionsHostedRunnerCuratedImageSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.ActionsHostedRunnerCuratedImageSource Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsHostedRunnerCuratedImage" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the image. Use this ID for the `image` parameter when creating a new larger runner.<br/>
        /// Example: ubuntu-20.04
        /// </param>
        /// <param name="platform">
        /// The operating system of the image.<br/>
        /// Example: linux-x64
        /// </param>
        /// <param name="sizeGb">
        /// Image size in GB.<br/>
        /// Example: 86
        /// </param>
        /// <param name="displayName">
        /// Display name for this image.<br/>
        /// Example: 20.04
        /// </param>
        /// <param name="source">
        /// The image provider.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionsHostedRunnerCuratedImage(
            string id,
            string platform,
            int sizeGb,
            string displayName,
            global::GitHub.ActionsHostedRunnerCuratedImageSource source)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Platform = platform ?? throw new global::System.ArgumentNullException(nameof(platform));
            this.SizeGb = sizeGb;
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsHostedRunnerCuratedImage" /> class.
        /// </summary>
        public ActionsHostedRunnerCuratedImage()
        {
        }
    }
}