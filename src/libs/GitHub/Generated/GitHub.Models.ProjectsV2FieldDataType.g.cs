
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The field's data type.
    /// </summary>
    public enum ProjectsV2FieldDataType
    {
        /// <summary>
        /// 
        /// </summary>
        Assignees,
        /// <summary>
        /// 
        /// </summary>
        LinkedPullRequests,
        /// <summary>
        /// 
        /// </summary>
        Reviewers,
        /// <summary>
        /// 
        /// </summary>
        Labels,
        /// <summary>
        /// 
        /// </summary>
        Milestone,
        /// <summary>
        /// 
        /// </summary>
        Repository,
        /// <summary>
        /// 
        /// </summary>
        Title,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        SingleSelect,
        /// <summary>
        /// 
        /// </summary>
        Number,
        /// <summary>
        /// 
        /// </summary>
        Date,
        /// <summary>
        /// 
        /// </summary>
        Iteration,
        /// <summary>
        /// 
        /// </summary>
        IssueType,
        /// <summary>
        /// 
        /// </summary>
        ParentIssue,
        /// <summary>
        /// 
        /// </summary>
        SubIssuesProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectsV2FieldDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsV2FieldDataType value)
        {
            return value switch
            {
                ProjectsV2FieldDataType.Assignees => "assignees",
                ProjectsV2FieldDataType.LinkedPullRequests => "linked_pull_requests",
                ProjectsV2FieldDataType.Reviewers => "reviewers",
                ProjectsV2FieldDataType.Labels => "labels",
                ProjectsV2FieldDataType.Milestone => "milestone",
                ProjectsV2FieldDataType.Repository => "repository",
                ProjectsV2FieldDataType.Title => "title",
                ProjectsV2FieldDataType.Text => "text",
                ProjectsV2FieldDataType.SingleSelect => "single_select",
                ProjectsV2FieldDataType.Number => "number",
                ProjectsV2FieldDataType.Date => "date",
                ProjectsV2FieldDataType.Iteration => "iteration",
                ProjectsV2FieldDataType.IssueType => "issue_type",
                ProjectsV2FieldDataType.ParentIssue => "parent_issue",
                ProjectsV2FieldDataType.SubIssuesProgress => "sub_issues_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsV2FieldDataType? ToEnum(string value)
        {
            return value switch
            {
                "assignees" => ProjectsV2FieldDataType.Assignees,
                "linked_pull_requests" => ProjectsV2FieldDataType.LinkedPullRequests,
                "reviewers" => ProjectsV2FieldDataType.Reviewers,
                "labels" => ProjectsV2FieldDataType.Labels,
                "milestone" => ProjectsV2FieldDataType.Milestone,
                "repository" => ProjectsV2FieldDataType.Repository,
                "title" => ProjectsV2FieldDataType.Title,
                "text" => ProjectsV2FieldDataType.Text,
                "single_select" => ProjectsV2FieldDataType.SingleSelect,
                "number" => ProjectsV2FieldDataType.Number,
                "date" => ProjectsV2FieldDataType.Date,
                "iteration" => ProjectsV2FieldDataType.Iteration,
                "issue_type" => ProjectsV2FieldDataType.IssueType,
                "parent_issue" => ProjectsV2FieldDataType.ParentIssue,
                "sub_issues_progress" => ProjectsV2FieldDataType.SubIssuesProgress,
                _ => null,
            };
        }
    }
}