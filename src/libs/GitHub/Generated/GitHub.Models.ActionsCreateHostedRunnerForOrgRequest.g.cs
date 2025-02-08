
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsCreateHostedRunnerForOrgRequest
    {
        /// <summary>
        /// Name of the runner. Must be between 1 and 64 characters and may only contain upper and lowercase letters a-z, numbers 0-9, '.', '-', and '_'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The image of runner. To list all available images, use `GET /actions/hosted-runners/images/github-owned` or `GET /actions/hosted-runners/images/partner`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.ActionsCreateHostedRunnerForOrgRequestImage Image { get; set; }

        /// <summary>
        /// The machine size of the runner. To list available sizes, use `GET actions/hosted-runners/machine-sizes`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Size { get; set; }

        /// <summary>
        /// The existing runner group to add this runner to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runner_group_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RunnerGroupId { get; set; }

        /// <summary>
        /// The maximum amount of runners to scale up to. Runners will not auto-scale above this number. Use this setting to limit your cost.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maximum_runners")]
        public int? MaximumRunners { get; set; }

        /// <summary>
        /// Whether this runner should be created with a static public IP. Note limit on account. To list limits on account, use `GET actions/hosted-runners/limits`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_static_ip")]
        public bool? EnableStaticIp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsCreateHostedRunnerForOrgRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the runner. Must be between 1 and 64 characters and may only contain upper and lowercase letters a-z, numbers 0-9, '.', '-', and '_'.
        /// </param>
        /// <param name="image">
        /// The image of runner. To list all available images, use `GET /actions/hosted-runners/images/github-owned` or `GET /actions/hosted-runners/images/partner`.
        /// </param>
        /// <param name="size">
        /// The machine size of the runner. To list available sizes, use `GET actions/hosted-runners/machine-sizes`
        /// </param>
        /// <param name="runnerGroupId">
        /// The existing runner group to add this runner to.
        /// </param>
        /// <param name="maximumRunners">
        /// The maximum amount of runners to scale up to. Runners will not auto-scale above this number. Use this setting to limit your cost.
        /// </param>
        /// <param name="enableStaticIp">
        /// Whether this runner should be created with a static public IP. Note limit on account. To list limits on account, use `GET actions/hosted-runners/limits`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionsCreateHostedRunnerForOrgRequest(
            string name,
            global::GitHub.ActionsCreateHostedRunnerForOrgRequestImage image,
            string size,
            int runnerGroupId,
            int? maximumRunners,
            bool? enableStaticIp)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Size = size ?? throw new global::System.ArgumentNullException(nameof(size));
            this.RunnerGroupId = runnerGroupId;
            this.MaximumRunners = maximumRunners;
            this.EnableStaticIp = enableStaticIp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsCreateHostedRunnerForOrgRequest" /> class.
        /// </summary>
        public ActionsCreateHostedRunnerForOrgRequest()
        {
        }
    }
}