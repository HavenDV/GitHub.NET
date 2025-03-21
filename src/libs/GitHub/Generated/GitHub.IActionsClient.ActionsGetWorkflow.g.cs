#nullable enable

namespace GitHub
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Get a workflow<br/>
        /// Gets a specific workflow. You can replace `workflow_id` with the workflow<br/>
        /// file name. For example, you could use `main.yaml`.<br/>
        /// Anyone with read access to the repository can use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with a private repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="workflowId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.Workflow> ActionsGetWorkflowAsync(
            string owner,
            string repo,
            global::GitHub.OneOf<int?, string> workflowId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}