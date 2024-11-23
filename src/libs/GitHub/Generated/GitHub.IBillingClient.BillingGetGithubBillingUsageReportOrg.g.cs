#nullable enable

namespace GitHub
{
    public partial interface IBillingClient
    {
        /// <summary>
        /// Get billing usage report for an organization<br/>
        /// Gets a report of the total usage for an organization. To use this endpoint, you must be an administrator of an organization within an enterprise or an organization account.<br/>
        /// **Note:** This endpoint is only available to organizations with access to the enhanced billing platform. For more information, see "[About the enhanced billing platform](https://docs.github.com/billing/using-the-new-billing-platform)."
        /// </summary>
        /// <param name="org"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <param name="hour"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.BillingUsageReport> BillingGetGithubBillingUsageReportOrgAsync(
            string org,
            int? year = default,
            int? month = default,
            int? day = default,
            int? hour = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}