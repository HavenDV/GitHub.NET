
#nullable enable

namespace GitHub
{
    public partial class GitClient
    {
        partial void PrepareGitCreateTagArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            global::GitHub.GitCreateTagRequest request);
        partial void PrepareGitCreateTagRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            global::GitHub.GitCreateTagRequest request);
        partial void ProcessGitCreateTagResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGitCreateTagResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a tag object<br/>
        /// Note that creating a tag object does not create the reference that makes a tag in Git. If you want to create an annotated tag in Git, you have to do this call to create the tag object, and then [create](https://docs.github.com/rest/git/refs#create-a-reference) the `refs/tags/[tag]` reference. If you want to create a lightweight tag, you only have to [create](https://docs.github.com/rest/git/refs#create-a-reference) the tag reference - this call would be unnecessary.<br/>
        /// **Signature verification object**<br/>
        /// The response will include a `verification` object that describes the result of verifying the commit's signature. The following fields are included in the `verification` object:<br/>
        /// | Name | Type | Description |<br/>
        /// | ---- | ---- | ----------- |<br/>
        /// | `verified` | `boolean` | Indicates whether GitHub considers the signature in this commit to be verified. |<br/>
        /// | `reason` | `string` | The reason for verified value. Possible values and their meanings are enumerated in table below. |<br/>
        /// | `signature` | `string` | The signature that was extracted from the commit. |<br/>
        /// | `payload` | `string` | The value that was signed. |<br/>
        /// | `verified_at` | `string` | The date the signature was verified by GitHub. |<br/>
        /// These are the possible values for `reason` in the `verification` object:<br/>
        /// | Value | Description |<br/>
        /// | ----- | ----------- |<br/>
        /// | `expired_key` | The key that made the signature is expired. |<br/>
        /// | `not_signing_key` | The "signing" flag is not among the usage flags in the GPG key that made the signature. |<br/>
        /// | `gpgverify_error` | There was an error communicating with the signature verification service. |<br/>
        /// | `gpgverify_unavailable` | The signature verification service is currently unavailable. |<br/>
        /// | `unsigned` | The object does not include a signature. |<br/>
        /// | `unknown_signature_type` | A non-PGP signature was found in the commit. |<br/>
        /// | `no_user` | No user was associated with the `committer` email address in the commit. |<br/>
        /// | `unverified_email` | The `committer` email address in the commit was associated with a user, but the email address is not verified on their account. |<br/>
        /// | `bad_email` | The `committer` email address in the commit is not included in the identities of the PGP key that made the signature. |<br/>
        /// | `unknown_key` | The key that made the signature has not been registered with any user's account. |<br/>
        /// | `malformed_signature` | There was an error parsing the signature. |<br/>
        /// | `invalid` | The signature could not be cryptographically verified using the key whose key-id was found in the signature. |<br/>
        /// | `valid` | None of the above errors applied, so the signature is considered to be verified. |
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.GitTag> GitCreateTagAsync(
            string owner,
            string repo,
            global::GitHub.GitCreateTagRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareGitCreateTagArguments(
                httpClient: HttpClient,
                owner: ref owner,
                repo: ref repo,
                request: request);

            var __pathBuilder = new global::GitHub.PathBuilder(
                path: $"/repos/{owner}/{repo}/git/tags",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            PrepareGitCreateTagRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                owner: owner,
                repo: repo,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGitCreateTagResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation failed, or the endpoint has been spammed.
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::GitHub.ValidationError? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::GitHub.ValidationError.FromJson(__content_422, JsonSerializerContext);
                    }
                    else
                    {
                        var __contentStream_422 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = await global::GitHub.ValidationError.FromJsonStreamAsync(__contentStream_422, JsonSerializerContext).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::GitHub.ApiException<global::GitHub.ValidationError>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_422,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Conflict
            if ((int)__response.StatusCode == 409)
            {
                string? __content_409 = null;
                global::System.Exception? __exception_409 = null;
                global::GitHub.BasicError? __value_409 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_409 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_409 = global::GitHub.BasicError.FromJson(__content_409, JsonSerializerContext);
                    }
                    else
                    {
                        var __contentStream_409 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        __value_409 = await global::GitHub.BasicError.FromJsonStreamAsync(__contentStream_409, JsonSerializerContext).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_409 = __ex;
                }

                throw new global::GitHub.ApiException<global::GitHub.BasicError>(
                    message: __content_409 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_409,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_409,
                    ResponseObject = __value_409,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessGitCreateTagResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::GitHub.GitTag.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::GitHub.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::GitHub.GitTag.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
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
        }

        /// <summary>
        /// Create a tag object<br/>
        /// Note that creating a tag object does not create the reference that makes a tag in Git. If you want to create an annotated tag in Git, you have to do this call to create the tag object, and then [create](https://docs.github.com/rest/git/refs#create-a-reference) the `refs/tags/[tag]` reference. If you want to create a lightweight tag, you only have to [create](https://docs.github.com/rest/git/refs#create-a-reference) the tag reference - this call would be unnecessary.<br/>
        /// **Signature verification object**<br/>
        /// The response will include a `verification` object that describes the result of verifying the commit's signature. The following fields are included in the `verification` object:<br/>
        /// | Name | Type | Description |<br/>
        /// | ---- | ---- | ----------- |<br/>
        /// | `verified` | `boolean` | Indicates whether GitHub considers the signature in this commit to be verified. |<br/>
        /// | `reason` | `string` | The reason for verified value. Possible values and their meanings are enumerated in table below. |<br/>
        /// | `signature` | `string` | The signature that was extracted from the commit. |<br/>
        /// | `payload` | `string` | The value that was signed. |<br/>
        /// | `verified_at` | `string` | The date the signature was verified by GitHub. |<br/>
        /// These are the possible values for `reason` in the `verification` object:<br/>
        /// | Value | Description |<br/>
        /// | ----- | ----------- |<br/>
        /// | `expired_key` | The key that made the signature is expired. |<br/>
        /// | `not_signing_key` | The "signing" flag is not among the usage flags in the GPG key that made the signature. |<br/>
        /// | `gpgverify_error` | There was an error communicating with the signature verification service. |<br/>
        /// | `gpgverify_unavailable` | The signature verification service is currently unavailable. |<br/>
        /// | `unsigned` | The object does not include a signature. |<br/>
        /// | `unknown_signature_type` | A non-PGP signature was found in the commit. |<br/>
        /// | `no_user` | No user was associated with the `committer` email address in the commit. |<br/>
        /// | `unverified_email` | The `committer` email address in the commit was associated with a user, but the email address is not verified on their account. |<br/>
        /// | `bad_email` | The `committer` email address in the commit is not included in the identities of the PGP key that made the signature. |<br/>
        /// | `unknown_key` | The key that made the signature has not been registered with any user's account. |<br/>
        /// | `malformed_signature` | There was an error parsing the signature. |<br/>
        /// | `invalid` | The signature could not be cryptographically verified using the key whose key-id was found in the signature. |<br/>
        /// | `valid` | None of the above errors applied, so the signature is considered to be verified. |
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="tag">
        /// The tag's name. This is typically a version (e.g., "v0.0.1").
        /// </param>
        /// <param name="message">
        /// The tag message.
        /// </param>
        /// <param name="object">
        /// The SHA of the git object this is tagging.
        /// </param>
        /// <param name="type">
        /// The type of the object we're tagging. Normally this is a `commit` but it can also be a `tree` or a `blob`.
        /// </param>
        /// <param name="tagger">
        /// An object with information about the individual creating the tag.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.GitTag> GitCreateTagAsync(
            string owner,
            string repo,
            string tag,
            string message,
            string @object,
            global::GitHub.GitCreateTagRequestType type,
            global::GitHub.GitCreateTagRequestTagger? tagger = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::GitHub.GitCreateTagRequest
            {
                Tag = tag,
                Message = message,
                Object = @object,
                Type = type,
                Tagger = tagger,
            };

            return await GitCreateTagAsync(
                owner: owner,
                repo: repo,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}