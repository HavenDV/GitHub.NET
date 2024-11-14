
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposUpdateInformationAboutPagesSiteRequest
    {
        /// <summary>
        /// Specify a custom domain for the repository. Sending a `null` value will remove the custom domain. For more about custom domains, see "[Using a custom domain with GitHub Pages](https://docs.github.com/pages/configuring-a-custom-domain-for-your-github-pages-site)."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cname")]
        public string? Cname { get; set; }

        /// <summary>
        /// Specify whether HTTPS should be enforced for the repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("https_enforced")]
        public bool? HttpsEnforced { get; set; }

        /// <summary>
        /// The process by which the GitHub Pages site will be built. `workflow` means that the site is built by a custom GitHub Actions workflow. `legacy` means that the site is built by GitHub when changes are pushed to a specific branch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("build_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.ReposUpdateInformationAboutPagesSiteRequestBuildTypeJsonConverter))]
        public global::GitHub.ReposUpdateInformationAboutPagesSiteRequestBuildType? BuildType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AnyOfJsonConverter<global::GitHub.ReposUpdateInformationAboutPagesSiteRequestSourceEnum?, global::GitHub.ReposUpdateInformationAboutPagesSiteRequestSourceEnum2>))]
        public global::GitHub.AnyOf<global::GitHub.ReposUpdateInformationAboutPagesSiteRequestSourceEnum?, global::GitHub.ReposUpdateInformationAboutPagesSiteRequestSourceEnum2>? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdateInformationAboutPagesSiteRequest" /> class.
        /// </summary>
        /// <param name="cname">
        /// Specify a custom domain for the repository. Sending a `null` value will remove the custom domain. For more about custom domains, see "[Using a custom domain with GitHub Pages](https://docs.github.com/pages/configuring-a-custom-domain-for-your-github-pages-site)."
        /// </param>
        /// <param name="httpsEnforced">
        /// Specify whether HTTPS should be enforced for the repository.
        /// </param>
        /// <param name="buildType">
        /// The process by which the GitHub Pages site will be built. `workflow` means that the site is built by a custom GitHub Actions workflow. `legacy` means that the site is built by GitHub when changes are pushed to a specific branch.
        /// </param>
        /// <param name="source"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ReposUpdateInformationAboutPagesSiteRequest(
            string? cname,
            bool? httpsEnforced,
            global::GitHub.ReposUpdateInformationAboutPagesSiteRequestBuildType? buildType,
            global::GitHub.AnyOf<global::GitHub.ReposUpdateInformationAboutPagesSiteRequestSourceEnum?, global::GitHub.ReposUpdateInformationAboutPagesSiteRequestSourceEnum2>? source)
        {
            this.Cname = cname;
            this.HttpsEnforced = httpsEnforced;
            this.BuildType = buildType;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdateInformationAboutPagesSiteRequest" /> class.
        /// </summary>
        public ReposUpdateInformationAboutPagesSiteRequest()
        {
        }
    }
}