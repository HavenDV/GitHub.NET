#nullable enable

namespace GitHub
{
    public partial interface IActivityClient
    {
        /// <summary>
        /// Get a thread<br/>
        /// Gets information about a notification thread.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.Thread> ActivityGetThreadAsync(
            int threadId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}