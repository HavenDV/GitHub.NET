#nullable enable

namespace GitHub
{
    public partial interface ICopilotClient
    {
        /// <summary>
        /// Get Copilot metrics for an enterprise team<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is only applicable to dedicated enterprise accounts for Copilot Business. See "[About enterprise accounts for Copilot Business](https://docs.github.com/admin/copilot-business-only/about-enterprise-accounts-for-copilot-business)."<br/>
        /// Use this endpoint to see a breakdown of aggregated metrics for various GitHub Copilot features. See the response schema tab for detailed metrics definitions.<br/>
        /// The response contains metrics for up to 28 days prior. Metrics are processed once per day for the previous day,<br/>
        /// and the response will only include data up until yesterday. In order for an end user to be counted towards these metrics,<br/>
        /// they must have telemetry enabled in their IDE.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint will only return results for a given day if the enterprise team had **five or more members with active Copilot licenses** on that day, as evaluated at the end of that day.<br/>
        /// To access this endpoint, the Copilot Metrics API access policy must be enabled or set to "no policy" for the enterprise within GitHub settings.<br/>
        /// Only owners and billing managers for the enterprise that contains the enterprise team can view Copilot metrics for the enterprise team.<br/>
        /// OAuth app tokens and personal access tokens (classic) need either the `manage_billing:copilot` or `read:enterprise` scopes to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="teamSlug"></param>
        /// <param name="since"></param>
        /// <param name="until"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 28
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.CopilotUsageMetricsDay>> CopilotCopilotMetricsForEnterpriseTeamAsync(
            string enterprise,
            string teamSlug,
            string? since = default,
            string? until = default,
            int? page = default,
            int? perPage = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}