#nullable enable

namespace GitHub
{
    public partial interface IBillingClient
    {
        /// <summary>
        /// Get billing usage report for a user<br/>
        /// Gets a report of the total usage for a user.<br/>
        /// **Note:** This endpoint is only available to users with access to the enhanced billing platform.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <param name="hour"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.BillingUsageReportUser> BillingGetGithubBillingUsageReportUserAsync(
            string username,
            int? year = default,
            int? month = default,
            int? day = default,
            int? hour = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}