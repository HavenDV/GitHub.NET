#nullable enable

namespace GitHub
{
    public partial interface IReposClient
    {
        /// <summary>
        /// List branches
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="protected"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.ShortBranch>> ReposListBranchesAsync(
            string owner,
            string repo,
            bool? @protected = default,
            int? perPage = 30,
            int? page = 1,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}