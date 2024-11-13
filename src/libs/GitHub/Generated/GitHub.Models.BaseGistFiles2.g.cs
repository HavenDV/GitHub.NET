
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseGistFiles2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw_url")]
        public string? RawUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public int? Size { get; set; }

        /// <summary>
        /// The encoding used for `content`. Currently, `"utf-8"` and `"base64"` are supported.<br/>
        /// Default Value: utf-8
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding")]
        public string? Encoding { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseGistFiles2" /> class.
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="type"></param>
        /// <param name="language"></param>
        /// <param name="rawUrl"></param>
        /// <param name="size"></param>
        /// <param name="encoding">
        /// The encoding used for `content`. Currently, `"utf-8"` and `"base64"` are supported.<br/>
        /// Default Value: utf-8
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BaseGistFiles2(
            string? filename,
            string? type,
            string? language,
            string? rawUrl,
            int? size,
            string? encoding)
        {
            this.Filename = filename;
            this.Type = type;
            this.Language = language;
            this.RawUrl = rawUrl;
            this.Size = size;
            this.Encoding = encoding;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseGistFiles2" /> class.
        /// </summary>
        public BaseGistFiles2()
        {
        }
    }
}