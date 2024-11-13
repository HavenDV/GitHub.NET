
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The set of permissions for the GitHub app
    /// </summary>
    public sealed partial class WebhookIssuesLockedIssuePerformedViaGithubAppPermissions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsActionsJsonConverter))]
        public global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsActions? Actions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsAdministrationJsonConverter))]
        public global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsAdministration? Administration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsChecksJsonConverter))]
        public global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsChecks? Checks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_references")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsContentReferencesJsonConverter))]
        public global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsContentReferences? ContentReferences { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsContentsJsonConverter))]
        public global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsContents? Contents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsDeploymentsJsonConverter))]
        public global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsDeployments? Deployments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discussions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsDiscussionsJsonConverter))]
        public global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsDiscussions? Discussions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsEmailsJsonConverter))]
        public global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsEmails? Emails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsEnvironmentsJsonConverter))]
        public global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsEnvironments? Environments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsIssuesJsonConverter))]
        public global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsIssues? Issues { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsKeysJsonConverter))]
        public global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsKeys? Keys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsMembersJsonConverter))]
        public global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsMembers? Members { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsMetadataJsonConverter))]
        public global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsOrganizationAdministrationJsonConverter))]
        public global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsOrganizationAdministration? OrganizationAdministration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsOrganizationHooksJsonConverter))]
        public global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsOrganizationHooks? OrganizationHooks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsOrganizationPackagesJsonConverter))]
        public global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsOrganizationPackages? OrganizationPackages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsOrganizationPlanJsonConverter))]
        public global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsOrganizationPlan? OrganizationPlan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsOrganizationProjectsJsonConverter))]
        public global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsOrganizationProjects? OrganizationProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsOrganizationSecretsJsonConverter))]
        public global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsOrganizationSecrets? OrganizationSecrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_self_hosted_runners")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunnersJsonConverter))]
        public global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunners? OrganizationSelfHostedRunners { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_user_blocking")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsOrganizationUserBlockingJsonConverter))]
        public global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsOrganizationUserBlocking? OrganizationUserBlocking { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsPackagesJsonConverter))]
        public global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsPackages? Packages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsPagesJsonConverter))]
        public global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsPages? Pages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_requests")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsPullRequestsJsonConverter))]
        public global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsPullRequests? PullRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsRepositoryHooksJsonConverter))]
        public global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsRepositoryHooks? RepositoryHooks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsRepositoryProjectsJsonConverter))]
        public global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsRepositoryProjects? RepositoryProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsSecretScanningAlertsJsonConverter))]
        public global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsSecretScanningAlerts? SecretScanningAlerts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsSecretsJsonConverter))]
        public global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsSecrets? Secrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_events")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsSecurityEventsJsonConverter))]
        public global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsSecurityEvents? SecurityEvents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_scanning_alert")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsSecurityScanningAlertJsonConverter))]
        public global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsSecurityScanningAlert? SecurityScanningAlert { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("single_file")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsSingleFileJsonConverter))]
        public global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsSingleFile? SingleFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsStatusesJsonConverter))]
        public global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsStatuses? Statuses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_discussions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsTeamDiscussionsJsonConverter))]
        public global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsTeamDiscussions? TeamDiscussions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vulnerability_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsVulnerabilityAlertsJsonConverter))]
        public global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsVulnerabilityAlerts? VulnerabilityAlerts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflows")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsWorkflowsJsonConverter))]
        public global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsWorkflows? Workflows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookIssuesLockedIssuePerformedViaGithubAppPermissions" /> class.
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
        public WebhookIssuesLockedIssuePerformedViaGithubAppPermissions(
            global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsActions? actions,
            global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsAdministration? administration,
            global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsChecks? checks,
            global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsContentReferences? contentReferences,
            global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsContents? contents,
            global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsDeployments? deployments,
            global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsDiscussions? discussions,
            global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsEmails? emails,
            global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsEnvironments? environments,
            global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsIssues? issues,
            global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsKeys? keys,
            global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsMembers? members,
            global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsMetadata? metadata,
            global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsOrganizationAdministration? organizationAdministration,
            global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsOrganizationHooks? organizationHooks,
            global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsOrganizationPackages? organizationPackages,
            global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsOrganizationPlan? organizationPlan,
            global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsOrganizationProjects? organizationProjects,
            global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsOrganizationSecrets? organizationSecrets,
            global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunners? organizationSelfHostedRunners,
            global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsOrganizationUserBlocking? organizationUserBlocking,
            global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsPackages? packages,
            global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsPages? pages,
            global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsPullRequests? pullRequests,
            global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsRepositoryHooks? repositoryHooks,
            global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsRepositoryProjects? repositoryProjects,
            global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsSecretScanningAlerts? secretScanningAlerts,
            global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsSecrets? secrets,
            global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsSecurityEvents? securityEvents,
            global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsSecurityScanningAlert? securityScanningAlert,
            global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsSingleFile? singleFile,
            global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsStatuses? statuses,
            global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsTeamDiscussions? teamDiscussions,
            global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsVulnerabilityAlerts? vulnerabilityAlerts,
            global::GitHub.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsWorkflows? workflows)
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
        /// Initializes a new instance of the <see cref="WebhookIssuesLockedIssuePerformedViaGithubAppPermissions" /> class.
        /// </summary>
        public WebhookIssuesLockedIssuePerformedViaGithubAppPermissions()
        {
        }
    }
}