
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IssuesCreateRequest
    {
        /// <summary>
        /// The title of the issue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.OneOfJsonConverter<string, int?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.OneOf<string, int?> Title { get; set; }

        /// <summary>
        /// The contents of the issue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public string? Body { get; set; }

        /// <summary>
        /// Login for the user that this issue should be assigned to. _NOTE: Only users with push access can set the assignee for new issues. The assignee is silently dropped otherwise. **This field is closing down.**_
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignee")]
        public string? Assignee { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("milestone")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.OneOfJsonConverter<string, int?>))]
        public global::GitHub.OneOf<string, int?>? Milestone { get; set; }

        /// <summary>
        /// Labels to associate with this issue. _NOTE: Only users with push access can set labels for new issues. Labels are silently dropped otherwise._
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.IList<global::GitHub.OneOf<string, global::GitHub.IssuesCreateRequestLabel>>? Labels { get; set; }

        /// <summary>
        /// Logins for Users to assign to this issue. _NOTE: Only users with push access can set assignees for new issues. Assignees are silently dropped otherwise._
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignees")]
        public global::System.Collections.Generic.IList<string>? Assignees { get; set; }

        /// <summary>
        /// The name of the issue type to associate with this issue. _NOTE: Only users with push access can set the type for new issues. The type is silently dropped otherwise._<br/>
        /// Example: Epic
        /// </summary>
        /// <example>Epic</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesCreateRequest" /> class.
        /// </summary>
        /// <param name="title">
        /// The title of the issue.
        /// </param>
        /// <param name="body">
        /// The contents of the issue.
        /// </param>
        /// <param name="assignee">
        /// Login for the user that this issue should be assigned to. _NOTE: Only users with push access can set the assignee for new issues. The assignee is silently dropped otherwise. **This field is closing down.**_
        /// </param>
        /// <param name="milestone"></param>
        /// <param name="labels">
        /// Labels to associate with this issue. _NOTE: Only users with push access can set labels for new issues. Labels are silently dropped otherwise._
        /// </param>
        /// <param name="assignees">
        /// Logins for Users to assign to this issue. _NOTE: Only users with push access can set assignees for new issues. Assignees are silently dropped otherwise._
        /// </param>
        /// <param name="type">
        /// The name of the issue type to associate with this issue. _NOTE: Only users with push access can set the type for new issues. The type is silently dropped otherwise._<br/>
        /// Example: Epic
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssuesCreateRequest(
            global::GitHub.OneOf<string, int?> title,
            string? body,
            string? assignee,
            global::GitHub.OneOf<string, int?>? milestone,
            global::System.Collections.Generic.IList<global::GitHub.OneOf<string, global::GitHub.IssuesCreateRequestLabel>>? labels,
            global::System.Collections.Generic.IList<string>? assignees,
            string? type)
        {
            this.Title = title;
            this.Body = body;
            this.Assignee = assignee;
            this.Milestone = milestone;
            this.Labels = labels;
            this.Assignees = assignees;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesCreateRequest" /> class.
        /// </summary>
        public IssuesCreateRequest()
        {
        }
    }
}