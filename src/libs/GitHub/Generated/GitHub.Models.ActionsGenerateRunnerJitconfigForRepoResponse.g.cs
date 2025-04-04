
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsGenerateRunnerJitconfigForRepoResponse
    {
        /// <summary>
        /// A self hosted runner
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.Runner Runner { get; set; }

        /// <summary>
        /// The base64 encoded runner configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoded_jit_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EncodedJitConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsGenerateRunnerJitconfigForRepoResponse" /> class.
        /// </summary>
        /// <param name="runner">
        /// A self hosted runner
        /// </param>
        /// <param name="encodedJitConfig">
        /// The base64 encoded runner configuration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionsGenerateRunnerJitconfigForRepoResponse(
            global::GitHub.Runner runner,
            string encodedJitConfig)
        {
            this.Runner = runner ?? throw new global::System.ArgumentNullException(nameof(runner));
            this.EncodedJitConfig = encodedJitConfig ?? throw new global::System.ArgumentNullException(nameof(encodedJitConfig));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsGenerateRunnerJitconfigForRepoResponse" /> class.
        /// </summary>
        public ActionsGenerateRunnerJitconfigForRepoResponse()
        {
        }
    }
}