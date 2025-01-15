#nullable enable

namespace GitHub
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Check if Dependabot security updates are enabled for a repository<br/>
        /// Shows whether Dependabot security updates are enabled, disabled or paused for a repository. The authenticated user must have admin read access to the repository. For more information, see "[Configuring Dependabot security updates](https://docs.github.com/articles/configuring-automated-security-fixes)".
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.CheckAutomatedSecurityFixes> ReposCheckAutomatedSecurityFixesAsync(
            string owner,
            string repo,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}