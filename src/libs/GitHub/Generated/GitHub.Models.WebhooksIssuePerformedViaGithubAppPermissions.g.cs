
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The set of permissions for the GitHub app
    /// </summary>
    public sealed partial class WebhooksIssuePerformedViaGithubAppPermissions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsActionsJsonConverter))]
        public global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsActions? Actions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsAdministrationJsonConverter))]
        public global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsAdministration? Administration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsChecksJsonConverter))]
        public global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsChecks? Checks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_references")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsContentReferencesJsonConverter))]
        public global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsContentReferences? ContentReferences { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsContentsJsonConverter))]
        public global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsContents? Contents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsDeploymentsJsonConverter))]
        public global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsDeployments? Deployments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discussions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsDiscussionsJsonConverter))]
        public global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsDiscussions? Discussions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsEmailsJsonConverter))]
        public global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsEmails? Emails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsEnvironmentsJsonConverter))]
        public global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsEnvironments? Environments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsIssuesJsonConverter))]
        public global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsIssues? Issues { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsKeysJsonConverter))]
        public global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsKeys? Keys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsMembersJsonConverter))]
        public global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsMembers? Members { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsMetadataJsonConverter))]
        public global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationAdministrationJsonConverter))]
        public global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationAdministration? OrganizationAdministration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationHooksJsonConverter))]
        public global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationHooks? OrganizationHooks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationPackagesJsonConverter))]
        public global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationPackages? OrganizationPackages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationPlanJsonConverter))]
        public global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationPlan? OrganizationPlan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationProjectsJsonConverter))]
        public global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationProjects? OrganizationProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationSecretsJsonConverter))]
        public global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationSecrets? OrganizationSecrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_self_hosted_runners")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunnersJsonConverter))]
        public global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunners? OrganizationSelfHostedRunners { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_user_blocking")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationUserBlockingJsonConverter))]
        public global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationUserBlocking? OrganizationUserBlocking { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsPackagesJsonConverter))]
        public global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsPackages? Packages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsPagesJsonConverter))]
        public global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsPages? Pages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_requests")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsPullRequestsJsonConverter))]
        public global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsPullRequests? PullRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsRepositoryHooksJsonConverter))]
        public global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsRepositoryHooks? RepositoryHooks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsRepositoryProjectsJsonConverter))]
        public global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsRepositoryProjects? RepositoryProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsSecretScanningAlertsJsonConverter))]
        public global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsSecretScanningAlerts? SecretScanningAlerts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsSecretsJsonConverter))]
        public global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsSecrets? Secrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_events")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsSecurityEventsJsonConverter))]
        public global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsSecurityEvents? SecurityEvents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_scanning_alert")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsSecurityScanningAlertJsonConverter))]
        public global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsSecurityScanningAlert? SecurityScanningAlert { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("single_file")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsSingleFileJsonConverter))]
        public global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsSingleFile? SingleFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsStatusesJsonConverter))]
        public global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsStatuses? Statuses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_discussions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsTeamDiscussionsJsonConverter))]
        public global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsTeamDiscussions? TeamDiscussions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vulnerability_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsVulnerabilityAlertsJsonConverter))]
        public global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsVulnerabilityAlerts? VulnerabilityAlerts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflows")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsWorkflowsJsonConverter))]
        public global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsWorkflows? Workflows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksIssuePerformedViaGithubAppPermissions" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhooksIssuePerformedViaGithubAppPermissions(
            global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsActions? actions,
            global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsAdministration? administration,
            global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsChecks? checks,
            global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsContentReferences? contentReferences,
            global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsContents? contents,
            global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsDeployments? deployments,
            global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsDiscussions? discussions,
            global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsEmails? emails,
            global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsEnvironments? environments,
            global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsIssues? issues,
            global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsKeys? keys,
            global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsMembers? members,
            global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsMetadata? metadata,
            global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationAdministration? organizationAdministration,
            global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationHooks? organizationHooks,
            global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationPackages? organizationPackages,
            global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationPlan? organizationPlan,
            global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationProjects? organizationProjects,
            global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationSecrets? organizationSecrets,
            global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunners? organizationSelfHostedRunners,
            global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsOrganizationUserBlocking? organizationUserBlocking,
            global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsPackages? packages,
            global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsPages? pages,
            global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsPullRequests? pullRequests,
            global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsRepositoryHooks? repositoryHooks,
            global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsRepositoryProjects? repositoryProjects,
            global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsSecretScanningAlerts? secretScanningAlerts,
            global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsSecrets? secrets,
            global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsSecurityEvents? securityEvents,
            global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsSecurityScanningAlert? securityScanningAlert,
            global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsSingleFile? singleFile,
            global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsStatuses? statuses,
            global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsTeamDiscussions? teamDiscussions,
            global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsVulnerabilityAlerts? vulnerabilityAlerts,
            global::GitHub.WebhooksIssuePerformedViaGithubAppPermissionsWorkflows? workflows)
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
        /// Initializes a new instance of the <see cref="WebhooksIssuePerformedViaGithubAppPermissions" /> class.
        /// </summary>
        public WebhooksIssuePerformedViaGithubAppPermissions()
        {
        }
    }
}