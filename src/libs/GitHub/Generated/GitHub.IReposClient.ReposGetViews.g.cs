#nullable enable

namespace GitHub
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Get page views<br/>
        /// Get the total number of views and breakdown per day or week for the last 14 days. Timestamps are aligned to UTC midnight of the beginning of the day or week. Week begins on Monday.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="per">
        /// Default Value: day
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.ViewTraffic> ReposGetViewsAsync(
            string owner,
            string repo,
            global::GitHub.ReposGetViewsPer? per = global::GitHub.ReposGetViewsPer.Day,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}