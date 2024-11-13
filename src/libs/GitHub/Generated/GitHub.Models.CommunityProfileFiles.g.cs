
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CommunityProfileFiles
    {
        /// <summary>
        /// Code of Conduct Simple
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_of_conduct")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.NullableCodeOfConductSimple? CodeOfConduct { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_of_conduct_file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.NullableCommunityHealthFile? CodeOfConductFile { get; set; }

        /// <summary>
        /// License Simple
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("license")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.NullableLicenseSimple? License { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contributing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.NullableCommunityHealthFile? Contributing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readme")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.NullableCommunityHealthFile? Readme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_template")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.NullableCommunityHealthFile? IssueTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_request_template")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.NullableCommunityHealthFile? PullRequestTemplate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommunityProfileFiles" /> class.
        /// </summary>
        /// <param name="codeOfConduct">
        /// Code of Conduct Simple
        /// </param>
        /// <param name="codeOfConductFile"></param>
        /// <param name="license">
        /// License Simple
        /// </param>
        /// <param name="contributing"></param>
        /// <param name="readme"></param>
        /// <param name="issueTemplate"></param>
        /// <param name="pullRequestTemplate"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CommunityProfileFiles(
            global::GitHub.NullableCodeOfConductSimple? codeOfConduct,
            global::GitHub.NullableCommunityHealthFile? codeOfConductFile,
            global::GitHub.NullableLicenseSimple? license,
            global::GitHub.NullableCommunityHealthFile? contributing,
            global::GitHub.NullableCommunityHealthFile? readme,
            global::GitHub.NullableCommunityHealthFile? issueTemplate,
            global::GitHub.NullableCommunityHealthFile? pullRequestTemplate)
        {
            this.CodeOfConduct = codeOfConduct ?? throw new global::System.ArgumentNullException(nameof(codeOfConduct));
            this.CodeOfConductFile = codeOfConductFile ?? throw new global::System.ArgumentNullException(nameof(codeOfConductFile));
            this.License = license ?? throw new global::System.ArgumentNullException(nameof(license));
            this.Contributing = contributing ?? throw new global::System.ArgumentNullException(nameof(contributing));
            this.Readme = readme ?? throw new global::System.ArgumentNullException(nameof(readme));
            this.IssueTemplate = issueTemplate ?? throw new global::System.ArgumentNullException(nameof(issueTemplate));
            this.PullRequestTemplate = pullRequestTemplate ?? throw new global::System.ArgumentNullException(nameof(pullRequestTemplate));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommunityProfileFiles" /> class.
        /// </summary>
        public CommunityProfileFiles()
        {
        }
    }
}