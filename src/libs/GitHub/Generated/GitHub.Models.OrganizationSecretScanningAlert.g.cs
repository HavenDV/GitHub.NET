
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrganizationSecretScanningAlert
    {
        /// <summary>
        /// The security alert number.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        public int? Number { get; set; }

        /// <summary>
        /// The time that the alert was created in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The time that the alert was last updated in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The REST API URL of the alert resource.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The GitHub URL of the alert resource.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// The REST API URL of the code locations for this alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locations_url")]
        public string? LocationsUrl { get; set; }

        /// <summary>
        /// Sets the state of the secret scanning alert. You must provide `resolution` when you set the state to `resolved`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.SecretScanningAlertStateJsonConverter))]
        public global::GitHub.SecretScanningAlertState? State { get; set; }

        /// <summary>
        /// **Required when the `state` is `resolved`.** The reason for resolving the alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.SecretScanningAlertResolutionJsonConverter))]
        public global::GitHub.SecretScanningAlertResolution? Resolution { get; set; }

        /// <summary>
        /// The time that the alert was resolved in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolved_at")]
        public global::System.DateTime? ResolvedAt { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolved_by")]
        public global::GitHub.NullableSimpleUser? ResolvedBy { get; set; }

        /// <summary>
        /// The type of secret that secret scanning detected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_type")]
        public string? SecretType { get; set; }

        /// <summary>
        /// User-friendly name for the detected secret, matching the `secret_type`.<br/>
        /// For a list of built-in patterns, see "[Supported secret scanning patterns](https://docs.github.com/code-security/secret-scanning/introduction/supported-secret-scanning-patterns#supported-secrets)."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_type_display_name")]
        public string? SecretTypeDisplayName { get; set; }

        /// <summary>
        /// The secret that was detected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        public string? Secret { get; set; }

        /// <summary>
        /// A GitHub repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        public global::GitHub.SimpleRepository? Repository { get; set; }

        /// <summary>
        /// Whether push protection was bypassed for the detected secret.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("push_protection_bypassed")]
        public bool? PushProtectionBypassed { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("push_protection_bypassed_by")]
        public global::GitHub.NullableSimpleUser? PushProtectionBypassedBy { get; set; }

        /// <summary>
        /// The time that push protection was bypassed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("push_protection_bypassed_at")]
        public global::System.DateTime? PushProtectionBypassedAt { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("push_protection_bypass_request_reviewer")]
        public global::GitHub.NullableSimpleUser? PushProtectionBypassRequestReviewer { get; set; }

        /// <summary>
        /// An optional comment when reviewing a push protection bypass.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("push_protection_bypass_request_reviewer_comment")]
        public string? PushProtectionBypassRequestReviewerComment { get; set; }

        /// <summary>
        /// An optional comment when requesting a push protection bypass.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("push_protection_bypass_request_comment")]
        public string? PushProtectionBypassRequestComment { get; set; }

        /// <summary>
        /// The URL to a push protection bypass request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("push_protection_bypass_request_html_url")]
        public string? PushProtectionBypassRequestHtmlUrl { get; set; }

        /// <summary>
        /// The comment that was optionally added when this alert was closed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution_comment")]
        public string? ResolutionComment { get; set; }

        /// <summary>
        /// The token status as of the latest validity check.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.OrganizationSecretScanningAlertValidityJsonConverter))]
        public global::GitHub.OrganizationSecretScanningAlertValidity? Validity { get; set; }

        /// <summary>
        /// Whether the secret was publicly leaked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicly_leaked")]
        public bool? PubliclyLeaked { get; set; }

        /// <summary>
        /// Whether the detected secret was found in multiple repositories in the same organization or enterprise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multi_repo")]
        public bool? MultiRepo { get; set; }

        /// <summary>
        /// A boolean value representing whether or not alert is base64 encoded
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_base64_encoded")]
        public bool? IsBase64Encoded { get; set; }

        /// <summary>
        /// Details on the location where the token was initially detected. This can be a commit, wiki commit, issue, discussion, pull request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_location_detected")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.NullableSecretScanningFirstDetectedLocationJsonConverter))]
        public global::GitHub.NullableSecretScanningFirstDetectedLocation? FirstLocationDetected { get; set; }

        /// <summary>
        /// A boolean value representing whether or not the token in the alert was detected in more than one location.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more_locations")]
        public bool? HasMoreLocations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationSecretScanningAlert" /> class.
        /// </summary>
        /// <param name="number">
        /// The security alert number.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// The time that the alert was created in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updatedAt">
        /// The time that the alert was last updated in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="url">
        /// The REST API URL of the alert resource.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="htmlUrl">
        /// The GitHub URL of the alert resource.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="locationsUrl">
        /// The REST API URL of the code locations for this alert.
        /// </param>
        /// <param name="state">
        /// Sets the state of the secret scanning alert. You must provide `resolution` when you set the state to `resolved`.
        /// </param>
        /// <param name="resolution">
        /// **Required when the `state` is `resolved`.** The reason for resolving the alert.
        /// </param>
        /// <param name="resolvedAt">
        /// The time that the alert was resolved in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </param>
        /// <param name="resolvedBy">
        /// A GitHub user.
        /// </param>
        /// <param name="secretType">
        /// The type of secret that secret scanning detected.
        /// </param>
        /// <param name="secretTypeDisplayName">
        /// User-friendly name for the detected secret, matching the `secret_type`.<br/>
        /// For a list of built-in patterns, see "[Supported secret scanning patterns](https://docs.github.com/code-security/secret-scanning/introduction/supported-secret-scanning-patterns#supported-secrets)."
        /// </param>
        /// <param name="secret">
        /// The secret that was detected.
        /// </param>
        /// <param name="repository">
        /// A GitHub repository.
        /// </param>
        /// <param name="pushProtectionBypassed">
        /// Whether push protection was bypassed for the detected secret.
        /// </param>
        /// <param name="pushProtectionBypassedBy">
        /// A GitHub user.
        /// </param>
        /// <param name="pushProtectionBypassedAt">
        /// The time that push protection was bypassed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </param>
        /// <param name="pushProtectionBypassRequestReviewer">
        /// A GitHub user.
        /// </param>
        /// <param name="pushProtectionBypassRequestReviewerComment">
        /// An optional comment when reviewing a push protection bypass.
        /// </param>
        /// <param name="pushProtectionBypassRequestComment">
        /// An optional comment when requesting a push protection bypass.
        /// </param>
        /// <param name="pushProtectionBypassRequestHtmlUrl">
        /// The URL to a push protection bypass request.
        /// </param>
        /// <param name="resolutionComment">
        /// The comment that was optionally added when this alert was closed
        /// </param>
        /// <param name="validity">
        /// The token status as of the latest validity check.
        /// </param>
        /// <param name="publiclyLeaked">
        /// Whether the secret was publicly leaked.
        /// </param>
        /// <param name="multiRepo">
        /// Whether the detected secret was found in multiple repositories in the same organization or enterprise.
        /// </param>
        /// <param name="isBase64Encoded">
        /// A boolean value representing whether or not alert is base64 encoded
        /// </param>
        /// <param name="firstLocationDetected">
        /// Details on the location where the token was initially detected. This can be a commit, wiki commit, issue, discussion, pull request.
        /// </param>
        /// <param name="hasMoreLocations">
        /// A boolean value representing whether or not the token in the alert was detected in more than one location.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationSecretScanningAlert(
            int? number,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            string? url,
            string? htmlUrl,
            string? locationsUrl,
            global::GitHub.SecretScanningAlertState? state,
            global::GitHub.SecretScanningAlertResolution? resolution,
            global::System.DateTime? resolvedAt,
            global::GitHub.NullableSimpleUser? resolvedBy,
            string? secretType,
            string? secretTypeDisplayName,
            string? secret,
            global::GitHub.SimpleRepository? repository,
            bool? pushProtectionBypassed,
            global::GitHub.NullableSimpleUser? pushProtectionBypassedBy,
            global::System.DateTime? pushProtectionBypassedAt,
            global::GitHub.NullableSimpleUser? pushProtectionBypassRequestReviewer,
            string? pushProtectionBypassRequestReviewerComment,
            string? pushProtectionBypassRequestComment,
            string? pushProtectionBypassRequestHtmlUrl,
            string? resolutionComment,
            global::GitHub.OrganizationSecretScanningAlertValidity? validity,
            bool? publiclyLeaked,
            bool? multiRepo,
            bool? isBase64Encoded,
            global::GitHub.NullableSecretScanningFirstDetectedLocation? firstLocationDetected,
            bool? hasMoreLocations)
        {
            this.Number = number;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Url = url;
            this.HtmlUrl = htmlUrl;
            this.LocationsUrl = locationsUrl;
            this.State = state;
            this.Resolution = resolution;
            this.ResolvedAt = resolvedAt;
            this.ResolvedBy = resolvedBy;
            this.SecretType = secretType;
            this.SecretTypeDisplayName = secretTypeDisplayName;
            this.Secret = secret;
            this.Repository = repository;
            this.PushProtectionBypassed = pushProtectionBypassed;
            this.PushProtectionBypassedBy = pushProtectionBypassedBy;
            this.PushProtectionBypassedAt = pushProtectionBypassedAt;
            this.PushProtectionBypassRequestReviewer = pushProtectionBypassRequestReviewer;
            this.PushProtectionBypassRequestReviewerComment = pushProtectionBypassRequestReviewerComment;
            this.PushProtectionBypassRequestComment = pushProtectionBypassRequestComment;
            this.PushProtectionBypassRequestHtmlUrl = pushProtectionBypassRequestHtmlUrl;
            this.ResolutionComment = resolutionComment;
            this.Validity = validity;
            this.PubliclyLeaked = publiclyLeaked;
            this.MultiRepo = multiRepo;
            this.IsBase64Encoded = isBase64Encoded;
            this.FirstLocationDetected = firstLocationDetected;
            this.HasMoreLocations = hasMoreLocations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationSecretScanningAlert" /> class.
        /// </summary>
        public OrganizationSecretScanningAlert()
        {
        }
    }
}