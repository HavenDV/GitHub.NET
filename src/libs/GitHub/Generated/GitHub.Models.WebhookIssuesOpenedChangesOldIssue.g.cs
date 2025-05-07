
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The [issue](https://docs.github.com/rest/issues/issues#get-an-issue) itself.
    /// </summary>
    public sealed partial class WebhookIssuesOpenedChangesOldIssue
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_lock_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesOpenedChangesOldIssueActiveLockReasonJsonConverter))]
        public global::GitHub.WebhookIssuesOpenedChangesOldIssueActiveLockReason? ActiveLockReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignee")]
        public global::GitHub.WebhookIssuesOpenedChangesOldIssueAssignee? Assignee { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignees")]
        public global::System.Collections.Generic.IList<global::GitHub.WebhookIssuesOpenedChangesOldIssueAssignee2>? Assignees { get; set; }

        /// <summary>
        /// How the author is associated with the repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author_association")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesOpenedChangesOldIssueAuthorAssociationJsonConverter))]
        public global::GitHub.WebhookIssuesOpenedChangesOldIssueAuthorAssociation? AuthorAssociation { get; set; }

        /// <summary>
        /// Contents of the issue
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public string? Body { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("closed_at")]
        public global::System.DateTime? ClosedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comments")]
        public int? Comments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comments_url")]
        public string? CommentsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("draft")]
        public bool? Draft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events_url")]
        public string? EventsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.IList<global::GitHub.WebhookIssuesOpenedChangesOldIssueLabel>? Labels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels_url")]
        public string? LabelsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locked")]
        public bool? Locked { get; set; }

        /// <summary>
        /// A collection of related issues and pull requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("milestone")]
        public global::GitHub.WebhookIssuesOpenedChangesOldIssueMilestone? Milestone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Number { get; set; }

        /// <summary>
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("performed_via_github_app")]
        public global::GitHub.WebhookIssuesOpenedChangesOldIssuePerformedViaGithubApp? PerformedViaGithubApp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_request")]
        public global::GitHub.WebhookIssuesOpenedChangesOldIssuePullRequest? PullRequest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reactions")]
        public global::GitHub.WebhookIssuesOpenedChangesOldIssueReactions? Reactions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_url")]
        public string? RepositoryUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sub_issues_summary")]
        public global::GitHub.WebhookIssuesOpenedChangesOldIssueSubIssuesSummary? SubIssuesSummary { get; set; }

        /// <summary>
        /// State of the issue; either 'open' or 'closed'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesOpenedChangesOldIssueStateJsonConverter))]
        public global::GitHub.WebhookIssuesOpenedChangesOldIssueState? State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state_reason")]
        public string? StateReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeline_url")]
        public string? TimelineUrl { get; set; }

        /// <summary>
        /// Title of the issue
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// URL for the issue
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::GitHub.WebhookIssuesOpenedChangesOldIssueUser? User { get; set; }

        /// <summary>
        /// The type of issue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public global::GitHub.IssueType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookIssuesOpenedChangesOldIssue" /> class.
        /// </summary>
        /// <param name="activeLockReason"></param>
        /// <param name="assignee"></param>
        /// <param name="assignees"></param>
        /// <param name="authorAssociation">
        /// How the author is associated with the repository.
        /// </param>
        /// <param name="body">
        /// Contents of the issue
        /// </param>
        /// <param name="closedAt"></param>
        /// <param name="comments"></param>
        /// <param name="commentsUrl"></param>
        /// <param name="createdAt"></param>
        /// <param name="draft"></param>
        /// <param name="eventsUrl"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="id"></param>
        /// <param name="labels"></param>
        /// <param name="labelsUrl"></param>
        /// <param name="locked"></param>
        /// <param name="milestone">
        /// A collection of related issues and pull requests.
        /// </param>
        /// <param name="nodeId"></param>
        /// <param name="number"></param>
        /// <param name="performedViaGithubApp">
        /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
        /// </param>
        /// <param name="pullRequest"></param>
        /// <param name="reactions"></param>
        /// <param name="repositoryUrl"></param>
        /// <param name="subIssuesSummary"></param>
        /// <param name="state">
        /// State of the issue; either 'open' or 'closed'
        /// </param>
        /// <param name="stateReason"></param>
        /// <param name="timelineUrl"></param>
        /// <param name="title">
        /// Title of the issue
        /// </param>
        /// <param name="updatedAt"></param>
        /// <param name="url">
        /// URL for the issue
        /// </param>
        /// <param name="user"></param>
        /// <param name="type">
        /// The type of issue.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookIssuesOpenedChangesOldIssue(
            long id,
            int number,
            global::GitHub.WebhookIssuesOpenedChangesOldIssueActiveLockReason? activeLockReason,
            global::GitHub.WebhookIssuesOpenedChangesOldIssueAssignee? assignee,
            global::System.Collections.Generic.IList<global::GitHub.WebhookIssuesOpenedChangesOldIssueAssignee2>? assignees,
            global::GitHub.WebhookIssuesOpenedChangesOldIssueAuthorAssociation? authorAssociation,
            string? body,
            global::System.DateTime? closedAt,
            int? comments,
            string? commentsUrl,
            global::System.DateTime? createdAt,
            bool? draft,
            string? eventsUrl,
            string? htmlUrl,
            global::System.Collections.Generic.IList<global::GitHub.WebhookIssuesOpenedChangesOldIssueLabel>? labels,
            string? labelsUrl,
            bool? locked,
            global::GitHub.WebhookIssuesOpenedChangesOldIssueMilestone? milestone,
            string? nodeId,
            global::GitHub.WebhookIssuesOpenedChangesOldIssuePerformedViaGithubApp? performedViaGithubApp,
            global::GitHub.WebhookIssuesOpenedChangesOldIssuePullRequest? pullRequest,
            global::GitHub.WebhookIssuesOpenedChangesOldIssueReactions? reactions,
            string? repositoryUrl,
            global::GitHub.WebhookIssuesOpenedChangesOldIssueSubIssuesSummary? subIssuesSummary,
            global::GitHub.WebhookIssuesOpenedChangesOldIssueState? state,
            string? stateReason,
            string? timelineUrl,
            string? title,
            global::System.DateTime? updatedAt,
            string? url,
            global::GitHub.WebhookIssuesOpenedChangesOldIssueUser? user,
            global::GitHub.IssueType? type)
        {
            this.Id = id;
            this.Number = number;
            this.ActiveLockReason = activeLockReason;
            this.Assignee = assignee;
            this.Assignees = assignees;
            this.AuthorAssociation = authorAssociation;
            this.Body = body;
            this.ClosedAt = closedAt;
            this.Comments = comments;
            this.CommentsUrl = commentsUrl;
            this.CreatedAt = createdAt;
            this.Draft = draft;
            this.EventsUrl = eventsUrl;
            this.HtmlUrl = htmlUrl;
            this.Labels = labels;
            this.LabelsUrl = labelsUrl;
            this.Locked = locked;
            this.Milestone = milestone;
            this.NodeId = nodeId;
            this.PerformedViaGithubApp = performedViaGithubApp;
            this.PullRequest = pullRequest;
            this.Reactions = reactions;
            this.RepositoryUrl = repositoryUrl;
            this.SubIssuesSummary = subIssuesSummary;
            this.State = state;
            this.StateReason = stateReason;
            this.TimelineUrl = timelineUrl;
            this.Title = title;
            this.UpdatedAt = updatedAt;
            this.Url = url;
            this.User = user;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookIssuesOpenedChangesOldIssue" /> class.
        /// </summary>
        public WebhookIssuesOpenedChangesOldIssue()
        {
        }
    }
}