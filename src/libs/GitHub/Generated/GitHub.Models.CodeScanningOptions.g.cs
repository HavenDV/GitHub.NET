
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Security Configuration feature options for code scanning
    /// </summary>
    public sealed partial class CodeScanningOptions
    {
        /// <summary>
        /// Whether to allow repos which use advanced setup
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_advanced")]
        public bool? AllowAdvanced { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningOptions" /> class.
        /// </summary>
        /// <param name="allowAdvanced">
        /// Whether to allow repos which use advanced setup
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeScanningOptions(
            bool? allowAdvanced)
        {
            this.AllowAdvanced = allowAdvanced;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningOptions" /> class.
        /// </summary>
        public CodeScanningOptions()
        {
        }
    }
}