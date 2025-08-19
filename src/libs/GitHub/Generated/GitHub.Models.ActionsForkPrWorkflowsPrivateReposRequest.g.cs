
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsForkPrWorkflowsPrivateReposRequest
    {
        /// <summary>
        /// Whether workflows triggered by pull requests from forks are allowed to run on private repositories.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_workflows_from_fork_pull_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RunWorkflowsFromForkPullRequests { get; set; }

        /// <summary>
        /// Whether GitHub Actions can create pull requests or submit approving pull request reviews from a workflow triggered by a fork pull request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("send_write_tokens_to_workflows")]
        public bool? SendWriteTokensToWorkflows { get; set; }

        /// <summary>
        /// Whether to make secrets and variables available to workflows triggered by pull requests from forks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("send_secrets_and_variables")]
        public bool? SendSecretsAndVariables { get; set; }

        /// <summary>
        /// Whether workflows triggered by pull requests from forks require approval from a repository administrator to run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_approval_for_fork_pr_workflows")]
        public bool? RequireApprovalForForkPrWorkflows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsForkPrWorkflowsPrivateReposRequest" /> class.
        /// </summary>
        /// <param name="runWorkflowsFromForkPullRequests">
        /// Whether workflows triggered by pull requests from forks are allowed to run on private repositories.
        /// </param>
        /// <param name="sendWriteTokensToWorkflows">
        /// Whether GitHub Actions can create pull requests or submit approving pull request reviews from a workflow triggered by a fork pull request.
        /// </param>
        /// <param name="sendSecretsAndVariables">
        /// Whether to make secrets and variables available to workflows triggered by pull requests from forks.
        /// </param>
        /// <param name="requireApprovalForForkPrWorkflows">
        /// Whether workflows triggered by pull requests from forks require approval from a repository administrator to run.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionsForkPrWorkflowsPrivateReposRequest(
            bool runWorkflowsFromForkPullRequests,
            bool? sendWriteTokensToWorkflows,
            bool? sendSecretsAndVariables,
            bool? requireApprovalForForkPrWorkflows)
        {
            this.RunWorkflowsFromForkPullRequests = runWorkflowsFromForkPullRequests;
            this.SendWriteTokensToWorkflows = sendWriteTokensToWorkflows;
            this.SendSecretsAndVariables = sendSecretsAndVariables;
            this.RequireApprovalForForkPrWorkflows = requireApprovalForForkPrWorkflows;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsForkPrWorkflowsPrivateReposRequest" /> class.
        /// </summary>
        public ActionsForkPrWorkflowsPrivateReposRequest()
        {
        }
    }
}