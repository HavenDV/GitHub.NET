#nullable enable

namespace GitHub
{
    public partial interface ICopilotClient
    {
        /// <summary>
        /// Get Copilot metrics for an enterprise<br/>
        /// Use this endpoint to see a breakdown of aggregated metrics for various GitHub Copilot features. See the response schema tab for detailed metrics definitions.<br/>
        /// The response contains metrics for up to 28 days prior. Metrics are processed once per day for the previous day,<br/>
        /// and the response will only include data up until yesterday. In order for an end user to be counted towards these metrics,<br/>
        /// they must have telemetry enabled in their IDE.<br/>
        /// To access this endpoint, the Copilot Metrics API access policy must be enabled or set to "no policy" for the enterprise within GitHub settings.<br/>
        /// Only enterprise owners and billing managers can view Copilot metrics for the enterprise.<br/>
        /// OAuth app tokens and personal access tokens (classic) need either the `manage_billing:copilot` or `read:enterprise` scopes to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
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
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.CopilotUsageMetricsDay>> CopilotCopilotMetricsForEnterpriseAsync(
            string enterprise,
            string? since = default,
            string? until = default,
            int? page = default,
            int? perPage = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}