
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The set of permissions for the GitHub app
    /// </summary>
    public sealed partial class WebhookIssuesLabeledIssuePerformedViaGithubAppPermissions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsActionsJsonConverter))]
        public global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsActions? Actions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsAdministrationJsonConverter))]
        public global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsAdministration? Administration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsChecksJsonConverter))]
        public global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsChecks? Checks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_references")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsContentReferencesJsonConverter))]
        public global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsContentReferences? ContentReferences { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsContentsJsonConverter))]
        public global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsContents? Contents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsDeploymentsJsonConverter))]
        public global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsDeployments? Deployments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discussions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsDiscussionsJsonConverter))]
        public global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsDiscussions? Discussions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsEmailsJsonConverter))]
        public global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsEmails? Emails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsEnvironmentsJsonConverter))]
        public global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsEnvironments? Environments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsIssuesJsonConverter))]
        public global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsIssues? Issues { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsKeysJsonConverter))]
        public global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsKeys? Keys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsMembersJsonConverter))]
        public global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsMembers? Members { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsMetadataJsonConverter))]
        public global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationAdministrationJsonConverter))]
        public global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationAdministration? OrganizationAdministration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationHooksJsonConverter))]
        public global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationHooks? OrganizationHooks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationPackagesJsonConverter))]
        public global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationPackages? OrganizationPackages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationPlanJsonConverter))]
        public global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationPlan? OrganizationPlan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationProjectsJsonConverter))]
        public global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationProjects? OrganizationProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationSecretsJsonConverter))]
        public global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationSecrets? OrganizationSecrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_self_hosted_runners")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunnersJsonConverter))]
        public global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunners? OrganizationSelfHostedRunners { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_user_blocking")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationUserBlockingJsonConverter))]
        public global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationUserBlocking? OrganizationUserBlocking { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsPackagesJsonConverter))]
        public global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsPackages? Packages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsPagesJsonConverter))]
        public global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsPages? Pages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_requests")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsPullRequestsJsonConverter))]
        public global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsPullRequests? PullRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsRepositoryHooksJsonConverter))]
        public global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsRepositoryHooks? RepositoryHooks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsRepositoryProjectsJsonConverter))]
        public global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsRepositoryProjects? RepositoryProjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSecretScanningAlertsJsonConverter))]
        public global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSecretScanningAlerts? SecretScanningAlerts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSecretsJsonConverter))]
        public global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSecrets? Secrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_events")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSecurityEventsJsonConverter))]
        public global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSecurityEvents? SecurityEvents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_scanning_alert")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSecurityScanningAlertJsonConverter))]
        public global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSecurityScanningAlert? SecurityScanningAlert { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("single_file")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSingleFileJsonConverter))]
        public global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSingleFile? SingleFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsStatusesJsonConverter))]
        public global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsStatuses? Statuses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_discussions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsTeamDiscussionsJsonConverter))]
        public global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsTeamDiscussions? TeamDiscussions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vulnerability_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsVulnerabilityAlertsJsonConverter))]
        public global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsVulnerabilityAlerts? VulnerabilityAlerts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflows")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsWorkflowsJsonConverter))]
        public global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsWorkflows? Workflows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookIssuesLabeledIssuePerformedViaGithubAppPermissions" /> class.
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
        public WebhookIssuesLabeledIssuePerformedViaGithubAppPermissions(
            global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsActions? actions,
            global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsAdministration? administration,
            global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsChecks? checks,
            global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsContentReferences? contentReferences,
            global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsContents? contents,
            global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsDeployments? deployments,
            global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsDiscussions? discussions,
            global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsEmails? emails,
            global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsEnvironments? environments,
            global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsIssues? issues,
            global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsKeys? keys,
            global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsMembers? members,
            global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsMetadata? metadata,
            global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationAdministration? organizationAdministration,
            global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationHooks? organizationHooks,
            global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationPackages? organizationPackages,
            global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationPlan? organizationPlan,
            global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationProjects? organizationProjects,
            global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationSecrets? organizationSecrets,
            global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunners? organizationSelfHostedRunners,
            global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationUserBlocking? organizationUserBlocking,
            global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsPackages? packages,
            global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsPages? pages,
            global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsPullRequests? pullRequests,
            global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsRepositoryHooks? repositoryHooks,
            global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsRepositoryProjects? repositoryProjects,
            global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSecretScanningAlerts? secretScanningAlerts,
            global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSecrets? secrets,
            global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSecurityEvents? securityEvents,
            global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSecurityScanningAlert? securityScanningAlert,
            global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSingleFile? singleFile,
            global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsStatuses? statuses,
            global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsTeamDiscussions? teamDiscussions,
            global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsVulnerabilityAlerts? vulnerabilityAlerts,
            global::GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsWorkflows? workflows)
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
        /// Initializes a new instance of the <see cref="WebhookIssuesLabeledIssuePerformedViaGithubAppPermissions" /> class.
        /// </summary>
        public WebhookIssuesLabeledIssuePerformedViaGithubAppPermissions()
        {
        }
    }
}