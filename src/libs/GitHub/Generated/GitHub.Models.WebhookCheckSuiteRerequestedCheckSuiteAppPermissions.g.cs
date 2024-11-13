
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The set of permissions for the GitHub app
    /// </summary>
    public sealed partial class WebhookCheckSuiteRerequestedCheckSuiteAppPermissions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsActionsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsActions? Actions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsAdministrationJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsAdministration? Administration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsChecksJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsChecks? Checks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_references")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsContentReferencesJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsContentReferences? ContentReferences { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsContentsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsContents? Contents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsDeploymentsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsDeployments? Deployments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discussions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsDiscussionsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsDiscussions? Discussions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsEmailsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsEmails? Emails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsEnvironmentsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsEnvironments? Environments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsIssuesJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsIssues? Issues { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsKeysJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsKeys? Keys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsMembersJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsMembers? Members { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsMetadataJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationAdministrationJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationAdministration? OrganizationAdministration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationHooksJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationHooks? OrganizationHooks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationPackagesJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationPackages? OrganizationPackages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationPlanJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationPlan? OrganizationPlan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationProjectsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationProjects? OrganizationProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationSecretsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationSecrets? OrganizationSecrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_self_hosted_runners")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationSelfHostedRunnersJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationSelfHostedRunners? OrganizationSelfHostedRunners { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_user_blocking")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationUserBlockingJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationUserBlocking? OrganizationUserBlocking { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsPackagesJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsPackages? Packages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsPagesJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsPages? Pages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_requests")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsPullRequestsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsPullRequests? PullRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsRepositoryHooksJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsRepositoryHooks? RepositoryHooks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsRepositoryProjectsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsRepositoryProjects? RepositoryProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsSecretScanningAlertsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsSecretScanningAlerts? SecretScanningAlerts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsSecretsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsSecrets? Secrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_events")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsSecurityEventsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsSecurityEvents? SecurityEvents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_scanning_alert")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsSecurityScanningAlertJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsSecurityScanningAlert? SecurityScanningAlert { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("single_file")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsSingleFileJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsSingleFile? SingleFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsStatusesJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsStatuses? Statuses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_discussions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsTeamDiscussionsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsTeamDiscussions? TeamDiscussions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vulnerability_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsVulnerabilityAlertsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsVulnerabilityAlerts? VulnerabilityAlerts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflows")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsWorkflowsJsonConverter))]
        public global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsWorkflows? Workflows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCheckSuiteRerequestedCheckSuiteAppPermissions" /> class.
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
        public WebhookCheckSuiteRerequestedCheckSuiteAppPermissions(
            global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsActions? actions,
            global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsAdministration? administration,
            global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsChecks? checks,
            global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsContentReferences? contentReferences,
            global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsContents? contents,
            global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsDeployments? deployments,
            global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsDiscussions? discussions,
            global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsEmails? emails,
            global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsEnvironments? environments,
            global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsIssues? issues,
            global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsKeys? keys,
            global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsMembers? members,
            global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsMetadata? metadata,
            global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationAdministration? organizationAdministration,
            global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationHooks? organizationHooks,
            global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationPackages? organizationPackages,
            global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationPlan? organizationPlan,
            global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationProjects? organizationProjects,
            global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationSecrets? organizationSecrets,
            global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationSelfHostedRunners? organizationSelfHostedRunners,
            global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationUserBlocking? organizationUserBlocking,
            global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsPackages? packages,
            global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsPages? pages,
            global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsPullRequests? pullRequests,
            global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsRepositoryHooks? repositoryHooks,
            global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsRepositoryProjects? repositoryProjects,
            global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsSecretScanningAlerts? secretScanningAlerts,
            global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsSecrets? secrets,
            global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsSecurityEvents? securityEvents,
            global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsSecurityScanningAlert? securityScanningAlert,
            global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsSingleFile? singleFile,
            global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsStatuses? statuses,
            global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsTeamDiscussions? teamDiscussions,
            global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsVulnerabilityAlerts? vulnerabilityAlerts,
            global::GitHub.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsWorkflows? workflows)
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
        /// Initializes a new instance of the <see cref="WebhookCheckSuiteRerequestedCheckSuiteAppPermissions" /> class.
        /// </summary>
        public WebhookCheckSuiteRerequestedCheckSuiteAppPermissions()
        {
        }
    }
}