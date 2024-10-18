#nullable enable

namespace GitHub
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Get repository clones<br/>
        /// Get the total number of clones and breakdown per day or week for the last 14 days. Timestamps are aligned to UTC midnight of the beginning of the day or week. Week begins on Monday.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="per">
        /// Default Value: day
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.CloneTraffic> ReposGetClonesAsync(
            string owner,
            string repo,
            global::GitHub.ReposGetClonesPer? per = global::GitHub.ReposGetClonesPer.Day,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}