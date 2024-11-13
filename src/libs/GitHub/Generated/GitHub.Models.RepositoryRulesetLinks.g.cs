
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryRulesetLinks
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self")]
        public global::GitHub.RepositoryRulesetLinksSelf? Self { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        public global::GitHub.RepositoryRulesetLinksHtml? Html { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRulesetLinks" /> class.
        /// </summary>
        /// <param name="self"></param>
        /// <param name="html"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RepositoryRulesetLinks(
            global::GitHub.RepositoryRulesetLinksSelf? self,
            global::GitHub.RepositoryRulesetLinksHtml? html)
        {
            this.Self = self;
            this.Html = html;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRulesetLinks" /> class.
        /// </summary>
        public RepositoryRulesetLinks()
        {
        }
    }
}