#nullable enable

namespace GitHub
{
    public partial interface ICodespacesClient
    {
        /// <summary>
        /// Create or update a repository secret<br/>
        /// Creates or updates a repository development environment secret with an encrypted value. Encrypt your secret using<br/>
        /// [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages). For more information, see "[Encrypting secrets for the REST API](https://docs.github.com/rest/guides/encrypting-secrets-for-the-rest-api)."<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint. The associated user must be a repository admin.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="secretName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.EmptyObject> CodespacesCreateOrUpdateRepoSecretAsync(
            string owner,
            string repo,
            string secretName,
            global::GitHub.CodespacesCreateOrUpdateRepoSecretRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create or update a repository secret<br/>
        /// Creates or updates a repository development environment secret with an encrypted value. Encrypt your secret using<br/>
        /// [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages). For more information, see "[Encrypting secrets for the REST API](https://docs.github.com/rest/guides/encrypting-secrets-for-the-rest-api)."<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint. The associated user must be a repository admin.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="secretName"></param>
        /// <param name="encryptedValue">
        /// Value for your secret, encrypted with [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages) using the public key retrieved from the [Get a repository public key](https://docs.github.com/rest/codespaces/repository-secrets#get-a-repository-public-key) endpoint.
        /// </param>
        /// <param name="keyId">
        /// ID of the key you used to encrypt the secret.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.EmptyObject> CodespacesCreateOrUpdateRepoSecretAsync(
            string owner,
            string repo,
            string secretName,
            string? encryptedValue = default,
            string? keyId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}