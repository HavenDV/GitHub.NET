
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The image of runner. To list all available images, use `GET /actions/hosted-runners/images/github-owned` or `GET /actions/hosted-runners/images/partner`.
    /// </summary>
    public sealed partial class ActionsCreateHostedRunnerForOrgRequestImage
    {
        /// <summary>
        /// The unique identifier of the runner image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The source of the runner image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.ActionsCreateHostedRunnerForOrgRequestImageSourceJsonConverter))]
        public global::GitHub.ActionsCreateHostedRunnerForOrgRequestImageSource? Source { get; set; }

        /// <summary>
        /// The version of the runner image to deploy. This is relevant only for runners using custom images.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsCreateHostedRunnerForOrgRequestImage" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the runner image.
        /// </param>
        /// <param name="source">
        /// The source of the runner image.
        /// </param>
        /// <param name="version">
        /// The version of the runner image to deploy. This is relevant only for runners using custom images.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionsCreateHostedRunnerForOrgRequestImage(
            string? id,
            global::GitHub.ActionsCreateHostedRunnerForOrgRequestImageSource? source,
            string? version)
        {
            this.Id = id;
            this.Source = source;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsCreateHostedRunnerForOrgRequestImage" /> class.
        /// </summary>
        public ActionsCreateHostedRunnerForOrgRequestImage()
        {
        }
    }
}