
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The set of permissions for the GitHub app
    /// </summary>
    public sealed partial class WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsActionsJsonConverter))]
        public global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsActions? Actions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsAdministrationJsonConverter))]
        public global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsAdministration? Administration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsChecksJsonConverter))]
        public global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsChecks? Checks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_references")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsContentReferencesJsonConverter))]
        public global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsContentReferences? ContentReferences { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsContentsJsonConverter))]
        public global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsContents? Contents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsDeploymentsJsonConverter))]
        public global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsDeployments? Deployments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discussions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsDiscussionsJsonConverter))]
        public global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsDiscussions? Discussions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsEmailsJsonConverter))]
        public global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsEmails? Emails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsEnvironmentsJsonConverter))]
        public global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsEnvironments? Environments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsIssuesJsonConverter))]
        public global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsIssues? Issues { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsKeysJsonConverter))]
        public global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsKeys? Keys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsMembersJsonConverter))]
        public global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsMembers? Members { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsMetadataJsonConverter))]
        public global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsOrganizationAdministrationJsonConverter))]
        public global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsOrganizationAdministration? OrganizationAdministration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsOrganizationHooksJsonConverter))]
        public global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsOrganizationHooks? OrganizationHooks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsOrganizationPackagesJsonConverter))]
        public global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsOrganizationPackages? OrganizationPackages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsOrganizationPlanJsonConverter))]
        public global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsOrganizationPlan? OrganizationPlan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsOrganizationProjectsJsonConverter))]
        public global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsOrganizationProjects? OrganizationProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsOrganizationSecretsJsonConverter))]
        public global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsOrganizationSecrets? OrganizationSecrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_self_hosted_runners")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsOrganizationSelfHostedRunnersJsonConverter))]
        public global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsOrganizationSelfHostedRunners? OrganizationSelfHostedRunners { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_user_blocking")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsOrganizationUserBlockingJsonConverter))]
        public global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsOrganizationUserBlocking? OrganizationUserBlocking { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsPackagesJsonConverter))]
        public global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsPackages? Packages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsPagesJsonConverter))]
        public global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsPages? Pages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_requests")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsPullRequestsJsonConverter))]
        public global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsPullRequests? PullRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsRepositoryHooksJsonConverter))]
        public global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsRepositoryHooks? RepositoryHooks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsRepositoryProjectsJsonConverter))]
        public global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsRepositoryProjects? RepositoryProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsSecretScanningAlertsJsonConverter))]
        public global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsSecretScanningAlerts? SecretScanningAlerts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsSecretsJsonConverter))]
        public global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsSecrets? Secrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_events")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsSecurityEventsJsonConverter))]
        public global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsSecurityEvents? SecurityEvents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_scanning_alert")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsSecurityScanningAlertJsonConverter))]
        public global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsSecurityScanningAlert? SecurityScanningAlert { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("single_file")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsSingleFileJsonConverter))]
        public global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsSingleFile? SingleFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsStatusesJsonConverter))]
        public global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsStatuses? Statuses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_discussions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsTeamDiscussionsJsonConverter))]
        public global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsTeamDiscussions? TeamDiscussions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vulnerability_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsVulnerabilityAlertsJsonConverter))]
        public global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsVulnerabilityAlerts? VulnerabilityAlerts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflows")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsWorkflowsJsonConverter))]
        public global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsWorkflows? Workflows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissions" /> class.
        /// </summary>
        /// <param name="actions"></param>
        /// <param name="administration"></param>
        /// <param name="checks"></param>
        /// <param name="contentReferences"></param>
        /// <param name="contents"></param>
        /// <param name="deployments"></param>
        /// <param name="discussions"></param>
        /// <param name="emails"></param>
        /// <param name="environments"></param>
        /// <param name="issues"></param>
        /// <param name="keys"></param>
        /// <param name="members"></param>
        /// <param name="metadata"></param>
        /// <param name="organizationAdministration"></param>
        /// <param name="organizationHooks"></param>
        /// <param name="organizationPackages"></param>
        /// <param name="organizationPlan"></param>
        /// <param name="organizationProjects"></param>
        /// <param name="organizationSecrets"></param>
        /// <param name="organizationSelfHostedRunners"></param>
        /// <param name="organizationUserBlocking"></param>
        /// <param name="packages"></param>
        /// <param name="pages"></param>
        /// <param name="pullRequests"></param>
        /// <param name="repositoryHooks"></param>
        /// <param name="repositoryProjects"></param>
        /// <param name="secretScanningAlerts"></param>
        /// <param name="secrets"></param>
        /// <param name="securityEvents"></param>
        /// <param name="securityScanningAlert"></param>
        /// <param name="singleFile"></param>
        /// <param name="statuses"></param>
        /// <param name="teamDiscussions"></param>
        /// <param name="vulnerabilityAlerts"></param>
        /// <param name="workflows"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissions(
            global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsActions? actions,
            global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsAdministration? administration,
            global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsChecks? checks,
            global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsContentReferences? contentReferences,
            global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsContents? contents,
            global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsDeployments? deployments,
            global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsDiscussions? discussions,
            global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsEmails? emails,
            global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsEnvironments? environments,
            global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsIssues? issues,
            global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsKeys? keys,
            global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsMembers? members,
            global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsMetadata? metadata,
            global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsOrganizationAdministration? organizationAdministration,
            global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsOrganizationHooks? organizationHooks,
            global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsOrganizationPackages? organizationPackages,
            global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsOrganizationPlan? organizationPlan,
            global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsOrganizationProjects? organizationProjects,
            global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsOrganizationSecrets? organizationSecrets,
            global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsOrganizationSelfHostedRunners? organizationSelfHostedRunners,
            global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsOrganizationUserBlocking? organizationUserBlocking,
            global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsPackages? packages,
            global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsPages? pages,
            global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsPullRequests? pullRequests,
            global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsRepositoryHooks? repositoryHooks,
            global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsRepositoryProjects? repositoryProjects,
            global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsSecretScanningAlerts? secretScanningAlerts,
            global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsSecrets? secrets,
            global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsSecurityEvents? securityEvents,
            global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsSecurityScanningAlert? securityScanningAlert,
            global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsSingleFile? singleFile,
            global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsStatuses? statuses,
            global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsTeamDiscussions? teamDiscussions,
            global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsVulnerabilityAlerts? vulnerabilityAlerts,
            global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsWorkflows? workflows)
        {
            this.Actions = actions;
            this.Administration = administration;
            this.Checks = checks;
            this.ContentReferences = contentReferences;
            this.Contents = contents;
            this.Deployments = deployments;
            this.Discussions = discussions;
            this.Emails = emails;
            this.Environments = environments;
            this.Issues = issues;
            this.Keys = keys;
            this.Members = members;
            this.Metadata = metadata;
            this.OrganizationAdministration = organizationAdministration;
            this.OrganizationHooks = organizationHooks;
            this.OrganizationPackages = organizationPackages;
            this.OrganizationPlan = organizationPlan;
            this.OrganizationProjects = organizationProjects;
            this.OrganizationSecrets = organizationSecrets;
            this.OrganizationSelfHostedRunners = organizationSelfHostedRunners;
            this.OrganizationUserBlocking = organizationUserBlocking;
            this.Packages = packages;
            this.Pages = pages;
            this.PullRequests = pullRequests;
            this.RepositoryHooks = repositoryHooks;
            this.RepositoryProjects = repositoryProjects;
            this.SecretScanningAlerts = secretScanningAlerts;
            this.Secrets = secrets;
            this.SecurityEvents = securityEvents;
            this.SecurityScanningAlert = securityScanningAlert;
            this.SingleFile = singleFile;
            this.Statuses = statuses;
            this.TeamDiscussions = teamDiscussions;
            this.VulnerabilityAlerts = vulnerabilityAlerts;
            this.Workflows = workflows;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissions" /> class.
        /// </summary>
        public WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissions()
        {
        }
    }
}