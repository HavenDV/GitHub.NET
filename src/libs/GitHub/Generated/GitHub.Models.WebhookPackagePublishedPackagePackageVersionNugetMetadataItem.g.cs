
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookPackagePublishedPackagePackageVersionNugetMetadataItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.OneOfJsonConverter<int?, string>))]
        public global::GitHub.OneOf<int?, string>? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.OneOfJsonConverter<bool?, string, int?, global::GitHub.WebhookPackagePublishedPackagePackageVersionNugetMetadataItemValue>))]
        public global::GitHub.OneOf<bool?, string, int?, global::GitHub.WebhookPackagePublishedPackagePackageVersionNugetMetadataItemValue>? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPackagePublishedPackagePackageVersionNugetMetadataItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookPackagePublishedPackagePackageVersionNugetMetadataItem(
            global::GitHub.OneOf<int?, string>? id,
            string? name,
            global::GitHub.OneOf<bool?, string, int?, global::GitHub.WebhookPackagePublishedPackagePackageVersionNugetMetadataItemValue>? value)
        {
            this.Id = id;
            this.Name = name;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPackagePublishedPackagePackageVersionNugetMetadataItem" /> class.
        /// </summary>
        public WebhookPackagePublishedPackagePackageVersionNugetMetadataItem()
        {
        }
    }
}