
#nullable enable

namespace GitHub
{
    public partial class CodespacesClient
    {
        partial void PrepareCodespacesCheckPermissionsForDevcontainerArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref string @ref,
            ref string devcontainerPath);
        partial void PrepareCodespacesCheckPermissionsForDevcontainerRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            string @ref,
            string devcontainerPath);
        partial void ProcessCodespacesCheckPermissionsForDevcontainerResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCodespacesCheckPermissionsForDevcontainerResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Check if permissions defined by a devcontainer have been accepted by the authenticated user<br/>
        /// Checks whether the permissions defined by a given devcontainer configuration have been accepted by the authenticated user.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="ref">
        /// Example: master
        /// </param>
        /// <param name="devcontainerPath">
        /// Example: .devcontainer/example/devcontainer.json
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.CodespacesPermissionsCheckForDevcontainer> CodespacesCheckPermissionsForDevcontainerAsync(
            string owner,
            string repo,
            string @ref,
            string devcontainerPath,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareCodespacesCheckPermissionsForDevcontainerArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                @ref: ref @ref,
                devcontainerPath: ref devcontainerPath);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/codespaces/permissions_check?ref={@ref}&devcontainer_path={devcontainerPath}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCodespacesCheckPermissionsForDevcontainerRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                @ref: @ref,
                devcontainerPath: devcontainerPath);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCodespacesCheckPermissionsForDevcontainerResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCodespacesCheckPermissionsForDevcontainerResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::GitHub.SourceGenerationContext.Default.CodespacesPermissionsCheckForDevcontainer) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}