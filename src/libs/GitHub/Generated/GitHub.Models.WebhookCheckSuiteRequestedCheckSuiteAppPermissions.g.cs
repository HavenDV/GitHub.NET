
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The set of permissions for the GitHub app
    /// </summary>
    public sealed partial class WebhookCheckSuiteRequestedCheckSuiteAppPermissions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsActionsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsActions? Actions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsAdministrationJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsAdministration? Administration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsChecksJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsChecks? Checks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_references")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsContentReferencesJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsContentReferences? ContentReferences { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsContentsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsContents? Contents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsDeploymentsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsDeployments? Deployments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discussions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsDiscussionsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsDiscussions? Discussions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsEmailsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsEmails? Emails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsEnvironmentsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsEnvironments? Environments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsIssuesJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsIssues? Issues { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsKeysJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsKeys? Keys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsMembersJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsMembers? Members { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsMetadataJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationAdministrationJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationAdministration? OrganizationAdministration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationHooksJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationHooks? OrganizationHooks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationPackagesJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationPackages? OrganizationPackages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationPlanJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationPlan? OrganizationPlan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationProjectsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationProjects? OrganizationProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationSecretsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationSecrets? OrganizationSecrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_self_hosted_runners")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationSelfHostedRunnersJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationSelfHostedRunners? OrganizationSelfHostedRunners { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_user_blocking")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationUserBlockingJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationUserBlocking? OrganizationUserBlocking { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsPackagesJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsPackages? Packages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsPagesJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsPages? Pages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_requests")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsPullRequestsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsPullRequests? PullRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsRepositoryHooksJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsRepositoryHooks? RepositoryHooks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsRepositoryProjectsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsRepositoryProjects? RepositoryProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecretScanningAlertsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecretScanningAlerts? SecretScanningAlerts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecretsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecrets? Secrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_events")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecurityEventsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecurityEvents? SecurityEvents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_scanning_alert")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecurityScanningAlertJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecurityScanningAlert? SecurityScanningAlert { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("single_file")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSingleFileJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSingleFile? SingleFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsStatusesJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsStatuses? Statuses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_discussions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsTeamDiscussionsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsTeamDiscussions? TeamDiscussions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vulnerability_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsVulnerabilityAlertsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsVulnerabilityAlerts? VulnerabilityAlerts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflows")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsWorkflowsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsWorkflows? Workflows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCheckSuiteRequestedCheckSuiteAppPermissions" /> class.
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
        public WebhookCheckSuiteRequestedCheckSuiteAppPermissions(
            global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsActions? actions,
            global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsAdministration? administration,
            global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsChecks? checks,
            global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsContentReferences? contentReferences,
            global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsContents? contents,
            global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsDeployments? deployments,
            global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsDiscussions? discussions,
            global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsEmails? emails,
            global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsEnvironments? environments,
            global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsIssues? issues,
            global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsKeys? keys,
            global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsMembers? members,
            global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsMetadata? metadata,
            global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationAdministration? organizationAdministration,
            global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationHooks? organizationHooks,
            global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationPackages? organizationPackages,
            global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationPlan? organizationPlan,
            global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationProjects? organizationProjects,
            global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationSecrets? organizationSecrets,
            global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationSelfHostedRunners? organizationSelfHostedRunners,
            global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationUserBlocking? organizationUserBlocking,
            global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsPackages? packages,
            global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsPages? pages,
            global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsPullRequests? pullRequests,
            global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsRepositoryHooks? repositoryHooks,
            global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsRepositoryProjects? repositoryProjects,
            global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecretScanningAlerts? secretScanningAlerts,
            global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecrets? secrets,
            global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecurityEvents? securityEvents,
            global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecurityScanningAlert? securityScanningAlert,
            global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSingleFile? singleFile,
            global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsStatuses? statuses,
            global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsTeamDiscussions? teamDiscussions,
            global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsVulnerabilityAlerts? vulnerabilityAlerts,
            global::GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsWorkflows? workflows)
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
        /// Initializes a new instance of the <see cref="WebhookCheckSuiteRequestedCheckSuiteAppPermissions" /> class.
        /// </summary>
        public WebhookCheckSuiteRequestedCheckSuiteAppPermissions()
        {
        }
    }
}