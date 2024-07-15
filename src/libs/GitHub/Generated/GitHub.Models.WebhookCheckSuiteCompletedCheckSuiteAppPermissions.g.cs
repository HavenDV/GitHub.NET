
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The set of permissions for the GitHub app
    /// </summary>
    public sealed partial class WebhookCheckSuiteCompletedCheckSuiteAppPermissions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsActionsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsActions? Actions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsAdministrationJsonConverter))]
        public global::GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsAdministration? Administration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsChecksJsonConverter))]
        public global::GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsChecks? Checks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_references")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsContentReferencesJsonConverter))]
        public global::GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsContentReferences? ContentReferences { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsContentsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsContents? Contents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsDeploymentsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsDeployments? Deployments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discussions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsDiscussionsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsDiscussions? Discussions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsEmailsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsEmails? Emails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsEnvironmentsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsEnvironments? Environments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsIssuesJsonConverter))]
        public global::GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsIssues? Issues { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsKeysJsonConverter))]
        public global::GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsKeys? Keys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsMembersJsonConverter))]
        public global::GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsMembers? Members { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsMetadataJsonConverter))]
        public global::GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationAdministrationJsonConverter))]
        public global::GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationAdministration? OrganizationAdministration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationHooksJsonConverter))]
        public global::GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationHooks? OrganizationHooks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationPackagesJsonConverter))]
        public global::GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationPackages? OrganizationPackages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationPlanJsonConverter))]
        public global::GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationPlan? OrganizationPlan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationProjectsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationProjects? OrganizationProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationSecretsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationSecrets? OrganizationSecrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_self_hosted_runners")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationSelfHostedRunnersJsonConverter))]
        public global::GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationSelfHostedRunners? OrganizationSelfHostedRunners { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_user_blocking")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationUserBlockingJsonConverter))]
        public global::GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationUserBlocking? OrganizationUserBlocking { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsPackagesJsonConverter))]
        public global::GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsPackages? Packages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsPagesJsonConverter))]
        public global::GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsPages? Pages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_requests")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsPullRequestsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsPullRequests? PullRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsRepositoryHooksJsonConverter))]
        public global::GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsRepositoryHooks? RepositoryHooks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsRepositoryProjectsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsRepositoryProjects? RepositoryProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecretScanningAlertsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecretScanningAlerts? SecretScanningAlerts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecretsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecrets? Secrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_events")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecurityEventsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecurityEvents? SecurityEvents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_scanning_alert")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecurityScanningAlertJsonConverter))]
        public global::GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecurityScanningAlert? SecurityScanningAlert { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("single_file")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSingleFileJsonConverter))]
        public global::GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSingleFile? SingleFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsStatusesJsonConverter))]
        public global::GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsStatuses? Statuses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_discussions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsTeamDiscussionsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsTeamDiscussions? TeamDiscussions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vulnerability_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsVulnerabilityAlertsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsVulnerabilityAlerts? VulnerabilityAlerts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflows")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsWorkflowsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsWorkflows? Workflows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}