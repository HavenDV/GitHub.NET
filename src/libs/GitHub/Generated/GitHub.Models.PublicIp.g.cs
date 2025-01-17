
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Provides details of Public IP for a GitHub-hosted larger runners
    /// </summary>
    public sealed partial class PublicIp
    {
        /// <summary>
        /// Whether public IP is enabled.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The prefix for the public IP.<br/>
        /// Example: 20.80.208.150
        /// </summary>
        /// <example>20.80.208.150</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix")]
        public string? Prefix { get; set; }

        /// <summary>
        /// The length of the IP prefix.<br/>
        /// Example: 28
        /// </summary>
        /// <example>28</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("length")]
        public int? Length { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicIp" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether public IP is enabled.<br/>
        /// Example: true
        /// </param>
        /// <param name="prefix">
        /// The prefix for the public IP.<br/>
        /// Example: 20.80.208.150
        /// </param>
        /// <param name="length">
        /// The length of the IP prefix.<br/>
        /// Example: 28
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PublicIp(
            bool? enabled,
            string? prefix,
            int? length)
        {
            this.Enabled = enabled;
            this.Prefix = prefix;
            this.Length = length;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicIp" /> class.
        /// </summary>
        public PublicIp()
        {
        }
    }
}