
#nullable enable

namespace GitHub
{
    public partial class CodeSecurityClient
    {
        partial void PrepareCodeSecurityUpdateConfigurationArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref int configurationId,
            global::GitHub.CodeSecurityUpdateConfigurationRequest request);
        partial void PrepareCodeSecurityUpdateConfigurationRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            int configurationId,
            global::GitHub.CodeSecurityUpdateConfigurationRequest request);
        partial void ProcessCodeSecurityUpdateConfigurationResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCodeSecurityUpdateConfigurationResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update a code security configuration<br/>
        /// Updates a code security configuration in an organization.<br/>
        /// The authenticated user must be an administrator or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="configurationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.CodeSecurityConfiguration> CodeSecurityUpdateConfigurationAsync(
            string org,
            int configurationId,
            global::GitHub.CodeSecurityUpdateConfigurationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCodeSecurityUpdateConfigurationArguments(
                httpClient: _httpClient,
                org: ref org,
                configurationId: ref configurationId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/orgs/{org}/code-security/configurations/{configurationId}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request, global::GitHub.SourceGenerationContext.Default.CodeSecurityUpdateConfigurationRequest),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCodeSecurityUpdateConfigurationRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                org: org,
                configurationId: configurationId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCodeSecurityUpdateConfigurationResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCodeSecurityUpdateConfigurationResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::GitHub.SourceGenerationContext.Default.CodeSecurityConfiguration) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update a code security configuration<br/>
        /// Updates a code security configuration in an organization.<br/>
        /// The authenticated user must be an administrator or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="configurationId"></param>
        /// <param name="name">
        /// The name of the code security configuration. Must be unique within the organization.
        /// </param>
        /// <param name="description">
        /// A description of the code security configuration
        /// </param>
        /// <param name="advancedSecurity">
        /// The enablement status of GitHub Advanced Security
        /// </param>
        /// <param name="dependencyGraph">
        /// The enablement status of Dependency Graph
        /// </param>
        /// <param name="dependabotAlerts">
        /// The enablement status of Dependabot alerts
        /// </param>
        /// <param name="dependabotSecurityUpdates">
        /// The enablement status of Dependabot security updates
        /// </param>
        /// <param name="codeScanningDefaultSetup">
        /// The enablement status of code scanning default setup
        /// </param>
        /// <param name="secretScanning">
        /// The enablement status of secret scanning
        /// </param>
        /// <param name="secretScanningPushProtection">
        /// The enablement status of secret scanning push protection
        /// </param>
        /// <param name="secretScanningValidityChecks">
        /// The enablement status of secret scanning validity checks
        /// </param>
        /// <param name="privateVulnerabilityReporting">
        /// The enablement status of private vulnerability reporting
        /// </param>
        /// <param name="enforcement">
        /// The enforcement status for a security configuration
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.CodeSecurityConfiguration> CodeSecurityUpdateConfigurationAsync(
            string org,
            int configurationId,
            string? name = default,
            string? description = default,
            global::GitHub.CodeSecurityUpdateConfigurationRequestAdvancedSecurity? advancedSecurity = default,
            global::GitHub.CodeSecurityUpdateConfigurationRequestDependencyGraph? dependencyGraph = default,
            global::GitHub.CodeSecurityUpdateConfigurationRequestDependabotAlerts? dependabotAlerts = default,
            global::GitHub.CodeSecurityUpdateConfigurationRequestDependabotSecurityUpdates? dependabotSecurityUpdates = default,
            global::GitHub.CodeSecurityUpdateConfigurationRequestCodeScanningDefaultSetup? codeScanningDefaultSetup = default,
            global::GitHub.CodeSecurityUpdateConfigurationRequestSecretScanning? secretScanning = default,
            global::GitHub.CodeSecurityUpdateConfigurationRequestSecretScanningPushProtection? secretScanningPushProtection = default,
            global::GitHub.CodeSecurityUpdateConfigurationRequestSecretScanningValidityChecks? secretScanningValidityChecks = default,
            global::GitHub.CodeSecurityUpdateConfigurationRequestPrivateVulnerabilityReporting? privateVulnerabilityReporting = default,
            global::GitHub.CodeSecurityUpdateConfigurationRequestEnforcement? enforcement = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::GitHub.CodeSecurityUpdateConfigurationRequest
            {
                Name = name,
                Description = description,
                AdvancedSecurity = advancedSecurity,
                DependencyGraph = dependencyGraph,
                DependabotAlerts = dependabotAlerts,
                DependabotSecurityUpdates = dependabotSecurityUpdates,
                CodeScanningDefaultSetup = codeScanningDefaultSetup,
                SecretScanning = secretScanning,
                SecretScanningPushProtection = secretScanningPushProtection,
                SecretScanningValidityChecks = secretScanningValidityChecks,
                PrivateVulnerabilityReporting = privateVulnerabilityReporting,
                Enforcement = enforcement,
            };

            return await CodeSecurityUpdateConfigurationAsync(
                org: org,
                configurationId: configurationId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}