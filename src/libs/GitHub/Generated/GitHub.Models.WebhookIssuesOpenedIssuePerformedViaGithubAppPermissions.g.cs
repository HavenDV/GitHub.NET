
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The set of permissions for the GitHub app
    /// </summary>
    public sealed partial class WebhookIssuesOpenedIssuePerformedViaGithubAppPermissions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsActionsJsonConverter))]
        public global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsActions? Actions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsAdministrationJsonConverter))]
        public global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsAdministration? Administration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsChecksJsonConverter))]
        public global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsChecks? Checks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_references")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsContentReferencesJsonConverter))]
        public global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsContentReferences? ContentReferences { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsContentsJsonConverter))]
        public global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsContents? Contents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsDeploymentsJsonConverter))]
        public global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsDeployments? Deployments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discussions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsDiscussionsJsonConverter))]
        public global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsDiscussions? Discussions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsEmailsJsonConverter))]
        public global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsEmails? Emails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsEnvironmentsJsonConverter))]
        public global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsEnvironments? Environments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsIssuesJsonConverter))]
        public global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsIssues? Issues { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsKeysJsonConverter))]
        public global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsKeys? Keys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsMembersJsonConverter))]
        public global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsMembers? Members { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsMetadataJsonConverter))]
        public global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsOrganizationAdministrationJsonConverter))]
        public global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsOrganizationAdministration? OrganizationAdministration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsOrganizationHooksJsonConverter))]
        public global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsOrganizationHooks? OrganizationHooks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsOrganizationPackagesJsonConverter))]
        public global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsOrganizationPackages? OrganizationPackages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsOrganizationPlanJsonConverter))]
        public global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsOrganizationPlan? OrganizationPlan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsOrganizationProjectsJsonConverter))]
        public global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsOrganizationProjects? OrganizationProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsOrganizationSecretsJsonConverter))]
        public global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsOrganizationSecrets? OrganizationSecrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_self_hosted_runners")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunnersJsonConverter))]
        public global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunners? OrganizationSelfHostedRunners { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_user_blocking")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsOrganizationUserBlockingJsonConverter))]
        public global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsOrganizationUserBlocking? OrganizationUserBlocking { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsPackagesJsonConverter))]
        public global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsPackages? Packages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsPagesJsonConverter))]
        public global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsPages? Pages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_requests")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsPullRequestsJsonConverter))]
        public global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsPullRequests? PullRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsRepositoryHooksJsonConverter))]
        public global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsRepositoryHooks? RepositoryHooks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsRepositoryProjectsJsonConverter))]
        public global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsRepositoryProjects? RepositoryProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsSecretScanningAlertsJsonConverter))]
        public global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsSecretScanningAlerts? SecretScanningAlerts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsSecretsJsonConverter))]
        public global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsSecrets? Secrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_events")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsSecurityEventsJsonConverter))]
        public global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsSecurityEvents? SecurityEvents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_scanning_alert")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsSecurityScanningAlertJsonConverter))]
        public global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsSecurityScanningAlert? SecurityScanningAlert { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("single_file")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsSingleFileJsonConverter))]
        public global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsSingleFile? SingleFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsStatusesJsonConverter))]
        public global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsStatuses? Statuses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_discussions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsTeamDiscussionsJsonConverter))]
        public global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsTeamDiscussions? TeamDiscussions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vulnerability_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsVulnerabilityAlertsJsonConverter))]
        public global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsVulnerabilityAlerts? VulnerabilityAlerts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflows")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsWorkflowsJsonConverter))]
        public global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsWorkflows? Workflows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookIssuesOpenedIssuePerformedViaGithubAppPermissions" /> class.
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
        public WebhookIssuesOpenedIssuePerformedViaGithubAppPermissions(
            global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsActions? actions,
            global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsAdministration? administration,
            global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsChecks? checks,
            global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsContentReferences? contentReferences,
            global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsContents? contents,
            global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsDeployments? deployments,
            global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsDiscussions? discussions,
            global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsEmails? emails,
            global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsEnvironments? environments,
            global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsIssues? issues,
            global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsKeys? keys,
            global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsMembers? members,
            global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsMetadata? metadata,
            global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsOrganizationAdministration? organizationAdministration,
            global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsOrganizationHooks? organizationHooks,
            global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsOrganizationPackages? organizationPackages,
            global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsOrganizationPlan? organizationPlan,
            global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsOrganizationProjects? organizationProjects,
            global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsOrganizationSecrets? organizationSecrets,
            global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunners? organizationSelfHostedRunners,
            global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsOrganizationUserBlocking? organizationUserBlocking,
            global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsPackages? packages,
            global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsPages? pages,
            global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsPullRequests? pullRequests,
            global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsRepositoryHooks? repositoryHooks,
            global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsRepositoryProjects? repositoryProjects,
            global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsSecretScanningAlerts? secretScanningAlerts,
            global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsSecrets? secrets,
            global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsSecurityEvents? securityEvents,
            global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsSecurityScanningAlert? securityScanningAlert,
            global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsSingleFile? singleFile,
            global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsStatuses? statuses,
            global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsTeamDiscussions? teamDiscussions,
            global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsVulnerabilityAlerts? vulnerabilityAlerts,
            global::GitHub.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsWorkflows? workflows)
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
        /// Initializes a new instance of the <see cref="WebhookIssuesOpenedIssuePerformedViaGithubAppPermissions" /> class.
        /// </summary>
        public WebhookIssuesOpenedIssuePerformedViaGithubAppPermissions()
        {
        }
    }
}