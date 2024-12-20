
#nullable enable

namespace GitHub
{
    public partial class PrivateRegistriesClient
    {
        partial void PreparePrivateRegistriesUpdateOrgPrivateRegistryArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref string secretName,
            global::GitHub.PrivateRegistriesUpdateOrgPrivateRegistryRequest request);
        partial void PreparePrivateRegistriesUpdateOrgPrivateRegistryRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            string secretName,
            global::GitHub.PrivateRegistriesUpdateOrgPrivateRegistryRequest request);
        partial void ProcessPrivateRegistriesUpdateOrgPrivateRegistryResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Update a private registry for an organization<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in public preview and is subject to change.<br/>
        /// Updates a private registry configuration with an encrypted value for an organization. Encrypt your secret using [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages). For more information, see "[Encrypting secrets for the REST API](https://docs.github.com/rest/guides/encrypting-secrets-for-the-rest-api)."<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="secretName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        public async global::System.Threading.Tasks.Task PrivateRegistriesUpdateOrgPrivateRegistryAsync(
            string org,
            string secretName,
            global::GitHub.PrivateRegistriesUpdateOrgPrivateRegistryRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePrivateRegistriesUpdateOrgPrivateRegistryArguments(
                httpClient: HttpClient,
                org: ref org,
                secretName: ref secretName,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/private-registries/{secretName}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PreparePrivateRegistriesUpdateOrgPrivateRegistryRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                secretName: secretName,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessPrivateRegistriesUpdateOrgPrivateRegistryResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::GitHub.ApiException(
                    message: __response.ReasonPhrase ?? string.Empty,
                    innerException: __ex,
                    statusCode: __response.StatusCode)
                {
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
        }

        /// <summary>
        /// Update a private registry for an organization<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in public preview and is subject to change.<br/>
        /// Updates a private registry configuration with an encrypted value for an organization. Encrypt your secret using [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages). For more information, see "[Encrypting secrets for the REST API](https://docs.github.com/rest/guides/encrypting-secrets-for-the-rest-api)."<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="secretName"></param>
        /// <param name="registryType">
        /// The registry type.
        /// </param>
        /// <param name="username">
        /// The username to use when authenticating with the private registry. This field should be omitted if the private registry does not require a username for authentication.
        /// </param>
        /// <param name="encryptedValue">
        /// The value for your secret, encrypted with [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages) using the public key retrieved from the [Get private registries public key for an organization](https://docs.github.com/rest/private-registries/organization-configurations#get-private-registries-public-key-for-an-organization) endpoint.
        /// </param>
        /// <param name="keyId">
        /// The ID of the key you used to encrypt the secret.
        /// </param>
        /// <param name="visibility">
        /// Which type of organization repositories have access to the private registry. `selected` means only the repositories specified by `selected_repository_ids` can access the private registry.
        /// </param>
        /// <param name="selectedRepositoryIds">
        /// An array of repository IDs that can access the organization private registry. You can only provide a list of repository IDs when `visibility` is set to `selected`. This field should be omitted if `visibility` is set to `all` or `private`.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task PrivateRegistriesUpdateOrgPrivateRegistryAsync(
            string org,
            string secretName,
            global::GitHub.PrivateRegistriesUpdateOrgPrivateRegistryRequestRegistryType? registryType = default,
            string? username = default,
            string? encryptedValue = default,
            string? keyId = default,
            global::GitHub.PrivateRegistriesUpdateOrgPrivateRegistryRequestVisibility? visibility = default,
            global::System.Collections.Generic.IList<int>? selectedRepositoryIds = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::GitHub.PrivateRegistriesUpdateOrgPrivateRegistryRequest
            {
                RegistryType = registryType,
                Username = username,
                EncryptedValue = encryptedValue,
                KeyId = keyId,
                Visibility = visibility,
                SelectedRepositoryIds = selectedRepositoryIds,
            };

            await PrivateRegistriesUpdateOrgPrivateRegistryAsync(
                org: org,
                secretName: secretName,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}