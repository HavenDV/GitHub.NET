
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedLinks
    {
        /// <summary>
        /// Hypermedia Link with Type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeline")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.LinkWithType Timeline { get; set; }

        /// <summary>
        /// Hypermedia Link with Type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.LinkWithType User { get; set; }

        /// <summary>
        /// Hypermedia Link with Type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_advisories")]
        public global::GitHub.LinkWithType? SecurityAdvisories { get; set; }

        /// <summary>
        /// Hypermedia Link with Type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_user")]
        public global::GitHub.LinkWithType? CurrentUser { get; set; }

        /// <summary>
        /// Hypermedia Link with Type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_user_public")]
        public global::GitHub.LinkWithType? CurrentUserPublic { get; set; }

        /// <summary>
        /// Hypermedia Link with Type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_user_actor")]
        public global::GitHub.LinkWithType? CurrentUserActor { get; set; }

        /// <summary>
        /// Hypermedia Link with Type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_user_organization")]
        public global::GitHub.LinkWithType? CurrentUserOrganization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_user_organizations")]
        public global::System.Collections.Generic.IList<global::GitHub.LinkWithType>? CurrentUserOrganizations { get; set; }

        /// <summary>
        /// Hypermedia Link with Type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_discussions")]
        public global::GitHub.LinkWithType? RepositoryDiscussions { get; set; }

        /// <summary>
        /// Hypermedia Link with Type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_discussions_category")]
        public global::GitHub.LinkWithType? RepositoryDiscussionsCategory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedLinks" /> class.
        /// </summary>
        /// <param name="timeline">
        /// Hypermedia Link with Type
        /// </param>
        /// <param name="user">
        /// Hypermedia Link with Type
        /// </param>
        /// <param name="securityAdvisories">
        /// Hypermedia Link with Type
        /// </param>
        /// <param name="currentUser">
        /// Hypermedia Link with Type
        /// </param>
        /// <param name="currentUserPublic">
        /// Hypermedia Link with Type
        /// </param>
        /// <param name="currentUserActor">
        /// Hypermedia Link with Type
        /// </param>
        /// <param name="currentUserOrganization">
        /// Hypermedia Link with Type
        /// </param>
        /// <param name="currentUserOrganizations"></param>
        /// <param name="repositoryDiscussions">
        /// Hypermedia Link with Type
        /// </param>
        /// <param name="repositoryDiscussionsCategory">
        /// Hypermedia Link with Type
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public FeedLinks(
            global::GitHub.LinkWithType timeline,
            global::GitHub.LinkWithType user,
            global::GitHub.LinkWithType? securityAdvisories,
            global::GitHub.LinkWithType? currentUser,
            global::GitHub.LinkWithType? currentUserPublic,
            global::GitHub.LinkWithType? currentUserActor,
            global::GitHub.LinkWithType? currentUserOrganization,
            global::System.Collections.Generic.IList<global::GitHub.LinkWithType>? currentUserOrganizations,
            global::GitHub.LinkWithType? repositoryDiscussions,
            global::GitHub.LinkWithType? repositoryDiscussionsCategory)
        {
            this.Timeline = timeline ?? throw new global::System.ArgumentNullException(nameof(timeline));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.SecurityAdvisories = securityAdvisories;
            this.CurrentUser = currentUser;
            this.CurrentUserPublic = currentUserPublic;
            this.CurrentUserActor = currentUserActor;
            this.CurrentUserOrganization = currentUserOrganization;
            this.CurrentUserOrganizations = currentUserOrganizations;
            this.RepositoryDiscussions = repositoryDiscussions;
            this.RepositoryDiscussionsCategory = repositoryDiscussionsCategory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedLinks" /> class.
        /// </summary>
        public FeedLinks()
        {
        }
    }
}