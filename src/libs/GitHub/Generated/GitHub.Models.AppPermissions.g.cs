
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The permissions granted to the user access token.
    /// </summary>
    public sealed partial class AppPermissions
    {
        /// <summary>
        /// The level of permission to grant the access token for GitHub Actions workflows, workflow runs, and artifacts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsActionsJsonConverter))]
        public global::GitHub.AppPermissionsActions? Actions { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for repository creation, deletion, settings, teams, and collaborators creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsAdministrationJsonConverter))]
        public global::GitHub.AppPermissionsAdministration? Administration { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for checks on code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsChecksJsonConverter))]
        public global::GitHub.AppPermissionsChecks? Checks { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to create, edit, delete, and list Codespaces.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codespaces")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsCodespacesJsonConverter))]
        public global::GitHub.AppPermissionsCodespaces? Codespaces { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for repository contents, commits, branches, downloads, releases, and merges.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsContentsJsonConverter))]
        public global::GitHub.AppPermissionsContents? Contents { get; set; }

        /// <summary>
        /// The leve of permission to grant the access token to manage Dependabot secrets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependabot_secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsDependabotSecretsJsonConverter))]
        public global::GitHub.AppPermissionsDependabotSecrets? DependabotSecrets { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for deployments and deployment statuses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsDeploymentsJsonConverter))]
        public global::GitHub.AppPermissionsDeployments? Deployments { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for managing repository environments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsEnvironmentsJsonConverter))]
        public global::GitHub.AppPermissionsEnvironments? Environments { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for issues and related comments, assignees, labels, and milestones.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsIssuesJsonConverter))]
        public global::GitHub.AppPermissionsIssues? Issues { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to search repositories, list collaborators, and access repository metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsMetadataJsonConverter))]
        public global::GitHub.AppPermissionsMetadata? Metadata { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for packages published to GitHub Packages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsPackagesJsonConverter))]
        public global::GitHub.AppPermissionsPackages? Packages { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to retrieve Pages statuses, configuration, and builds, as well as create new builds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsPagesJsonConverter))]
        public global::GitHub.AppPermissionsPages? Pages { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for pull requests and related comments, assignees, labels, milestones, and merges.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_requests")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsPullRequestsJsonConverter))]
        public global::GitHub.AppPermissionsPullRequests? PullRequests { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view and edit custom properties for a repository, when allowed by the property.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_custom_properties")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsRepositoryCustomPropertiesJsonConverter))]
        public global::GitHub.AppPermissionsRepositoryCustomProperties? RepositoryCustomProperties { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage the post-receive hooks for a repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsRepositoryHooksJsonConverter))]
        public global::GitHub.AppPermissionsRepositoryHooks? RepositoryHooks { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage repository projects, columns, and cards.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsRepositoryProjectsJsonConverter))]
        public global::GitHub.AppPermissionsRepositoryProjects? RepositoryProjects { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view and manage secret scanning alerts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsSecretScanningAlertsJsonConverter))]
        public global::GitHub.AppPermissionsSecretScanningAlerts? SecretScanningAlerts { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage repository secrets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsSecretsJsonConverter))]
        public global::GitHub.AppPermissionsSecrets? Secrets { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view and manage security events like code scanning alerts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_events")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsSecurityEventsJsonConverter))]
        public global::GitHub.AppPermissionsSecurityEvents? SecurityEvents { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage just a single file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("single_file")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsSingleFileJsonConverter))]
        public global::GitHub.AppPermissionsSingleFile? SingleFile { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for commit statuses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsStatusesJsonConverter))]
        public global::GitHub.AppPermissionsStatuses? Statuses { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage Dependabot alerts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vulnerability_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsVulnerabilityAlertsJsonConverter))]
        public global::GitHub.AppPermissionsVulnerabilityAlerts? VulnerabilityAlerts { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to update GitHub Actions workflow files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflows")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsWorkflowsJsonConverter))]
        public global::GitHub.AppPermissionsWorkflows? Workflows { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for organization teams and members.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsMembersJsonConverter))]
        public global::GitHub.AppPermissionsMembers? Members { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage access to an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsOrganizationAdministrationJsonConverter))]
        public global::GitHub.AppPermissionsOrganizationAdministration? OrganizationAdministration { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for custom repository roles management.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_custom_roles")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsOrganizationCustomRolesJsonConverter))]
        public global::GitHub.AppPermissionsOrganizationCustomRoles? OrganizationCustomRoles { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for custom organization roles management.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_custom_org_roles")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsOrganizationCustomOrgRolesJsonConverter))]
        public global::GitHub.AppPermissionsOrganizationCustomOrgRoles? OrganizationCustomOrgRoles { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for custom property management.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_custom_properties")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsOrganizationCustomPropertiesJsonConverter))]
        public global::GitHub.AppPermissionsOrganizationCustomProperties? OrganizationCustomProperties { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for managing access to GitHub Copilot for members of an organization with a Copilot Business subscription. This property is in public preview and is subject to change.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_copilot_seat_management")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsOrganizationCopilotSeatManagementJsonConverter))]
        public global::GitHub.AppPermissionsOrganizationCopilotSeatManagement? OrganizationCopilotSeatManagement { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view and manage announcement banners for an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_announcement_banners")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsOrganizationAnnouncementBannersJsonConverter))]
        public global::GitHub.AppPermissionsOrganizationAnnouncementBanners? OrganizationAnnouncementBanners { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view events triggered by an activity in an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_events")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsOrganizationEventsJsonConverter))]
        public global::GitHub.AppPermissionsOrganizationEvents? OrganizationEvents { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage the post-receive hooks for an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsOrganizationHooksJsonConverter))]
        public global::GitHub.AppPermissionsOrganizationHooks? OrganizationHooks { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for viewing and managing fine-grained personal access token requests to an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_personal_access_tokens")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsOrganizationPersonalAccessTokensJsonConverter))]
        public global::GitHub.AppPermissionsOrganizationPersonalAccessTokens? OrganizationPersonalAccessTokens { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for viewing and managing fine-grained personal access tokens that have been approved by an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_personal_access_token_requests")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsOrganizationPersonalAccessTokenRequestsJsonConverter))]
        public global::GitHub.AppPermissionsOrganizationPersonalAccessTokenRequests? OrganizationPersonalAccessTokenRequests { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for viewing an organization's plan.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsOrganizationPlanJsonConverter))]
        public global::GitHub.AppPermissionsOrganizationPlan? OrganizationPlan { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage organization projects and projects public preview (where available).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsOrganizationProjectsJsonConverter))]
        public global::GitHub.AppPermissionsOrganizationProjects? OrganizationProjects { get; set; }

        /// <summary>
        /// The level of permission to grant the access token for organization packages published to GitHub Packages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsOrganizationPackagesJsonConverter))]
        public global::GitHub.AppPermissionsOrganizationPackages? OrganizationPackages { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage organization secrets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsOrganizationSecretsJsonConverter))]
        public global::GitHub.AppPermissionsOrganizationSecrets? OrganizationSecrets { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view and manage GitHub Actions self-hosted runners available to an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_self_hosted_runners")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsOrganizationSelfHostedRunnersJsonConverter))]
        public global::GitHub.AppPermissionsOrganizationSelfHostedRunners? OrganizationSelfHostedRunners { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view and manage users blocked by the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_user_blocking")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsOrganizationUserBlockingJsonConverter))]
        public global::GitHub.AppPermissionsOrganizationUserBlocking? OrganizationUserBlocking { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage team discussions and related comments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_discussions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsTeamDiscussionsJsonConverter))]
        public global::GitHub.AppPermissionsTeamDiscussions? TeamDiscussions { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage the email addresses belonging to a user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_addresses")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsEmailAddressesJsonConverter))]
        public global::GitHub.AppPermissionsEmailAddresses? EmailAddresses { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage the followers belonging to a user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("followers")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsFollowersJsonConverter))]
        public global::GitHub.AppPermissionsFollowers? Followers { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage git SSH keys.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_ssh_keys")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsGitSshKeysJsonConverter))]
        public global::GitHub.AppPermissionsGitSshKeys? GitSshKeys { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view and manage GPG keys belonging to a user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpg_keys")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsGpgKeysJsonConverter))]
        public global::GitHub.AppPermissionsGpgKeys? GpgKeys { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to view and manage interaction limits on a repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interaction_limits")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsInteractionLimitsJsonConverter))]
        public global::GitHub.AppPermissionsInteractionLimits? InteractionLimits { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to manage the profile settings belonging to a user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsProfileJsonConverter))]
        public global::GitHub.AppPermissionsProfile? Profile { get; set; }

        /// <summary>
        /// The level of permission to grant the access token to list and manage repositories a user is starring.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("starring")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AppPermissionsStarringJsonConverter))]
        public global::GitHub.AppPermissionsStarring? Starring { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppPermissions" /> class.
        /// </summary>
        /// <param name="actions">
        /// The level of permission to grant the access token for GitHub Actions workflows, workflow runs, and artifacts.
        /// </param>
        /// <param name="administration">
        /// The level of permission to grant the access token for repository creation, deletion, settings, teams, and collaborators creation.
        /// </param>
        /// <param name="checks">
        /// The level of permission to grant the access token for checks on code.
        /// </param>
        /// <param name="codespaces">
        /// The level of permission to grant the access token to create, edit, delete, and list Codespaces.
        /// </param>
        /// <param name="contents">
        /// The level of permission to grant the access token for repository contents, commits, branches, downloads, releases, and merges.
        /// </param>
        /// <param name="dependabotSecrets">
        /// The leve of permission to grant the access token to manage Dependabot secrets.
        /// </param>
        /// <param name="deployments">
        /// The level of permission to grant the access token for deployments and deployment statuses.
        /// </param>
        /// <param name="environments">
        /// The level of permission to grant the access token for managing repository environments.
        /// </param>
        /// <param name="issues">
        /// The level of permission to grant the access token for issues and related comments, assignees, labels, and milestones.
        /// </param>
        /// <param name="metadata">
        /// The level of permission to grant the access token to search repositories, list collaborators, and access repository metadata.
        /// </param>
        /// <param name="packages">
        /// The level of permission to grant the access token for packages published to GitHub Packages.
        /// </param>
        /// <param name="pages">
        /// The level of permission to grant the access token to retrieve Pages statuses, configuration, and builds, as well as create new builds.
        /// </param>
        /// <param name="pullRequests">
        /// The level of permission to grant the access token for pull requests and related comments, assignees, labels, milestones, and merges.
        /// </param>
        /// <param name="repositoryCustomProperties">
        /// The level of permission to grant the access token to view and edit custom properties for a repository, when allowed by the property.
        /// </param>
        /// <param name="repositoryHooks">
        /// The level of permission to grant the access token to manage the post-receive hooks for a repository.
        /// </param>
        /// <param name="repositoryProjects">
        /// The level of permission to grant the access token to manage repository projects, columns, and cards.
        /// </param>
        /// <param name="secretScanningAlerts">
        /// The level of permission to grant the access token to view and manage secret scanning alerts.
        /// </param>
        /// <param name="secrets">
        /// The level of permission to grant the access token to manage repository secrets.
        /// </param>
        /// <param name="securityEvents">
        /// The level of permission to grant the access token to view and manage security events like code scanning alerts.
        /// </param>
        /// <param name="singleFile">
        /// The level of permission to grant the access token to manage just a single file.
        /// </param>
        /// <param name="statuses">
        /// The level of permission to grant the access token for commit statuses.
        /// </param>
        /// <param name="vulnerabilityAlerts">
        /// The level of permission to grant the access token to manage Dependabot alerts.
        /// </param>
        /// <param name="workflows">
        /// The level of permission to grant the access token to update GitHub Actions workflow files.
        /// </param>
        /// <param name="members">
        /// The level of permission to grant the access token for organization teams and members.
        /// </param>
        /// <param name="organizationAdministration">
        /// The level of permission to grant the access token to manage access to an organization.
        /// </param>
        /// <param name="organizationCustomRoles">
        /// The level of permission to grant the access token for custom repository roles management.
        /// </param>
        /// <param name="organizationCustomOrgRoles">
        /// The level of permission to grant the access token for custom organization roles management.
        /// </param>
        /// <param name="organizationCustomProperties">
        /// The level of permission to grant the access token for custom property management.
        /// </param>
        /// <param name="organizationCopilotSeatManagement">
        /// The level of permission to grant the access token for managing access to GitHub Copilot for members of an organization with a Copilot Business subscription. This property is in public preview and is subject to change.
        /// </param>
        /// <param name="organizationAnnouncementBanners">
        /// The level of permission to grant the access token to view and manage announcement banners for an organization.
        /// </param>
        /// <param name="organizationEvents">
        /// The level of permission to grant the access token to view events triggered by an activity in an organization.
        /// </param>
        /// <param name="organizationHooks">
        /// The level of permission to grant the access token to manage the post-receive hooks for an organization.
        /// </param>
        /// <param name="organizationPersonalAccessTokens">
        /// The level of permission to grant the access token for viewing and managing fine-grained personal access token requests to an organization.
        /// </param>
        /// <param name="organizationPersonalAccessTokenRequests">
        /// The level of permission to grant the access token for viewing and managing fine-grained personal access tokens that have been approved by an organization.
        /// </param>
        /// <param name="organizationPlan">
        /// The level of permission to grant the access token for viewing an organization's plan.
        /// </param>
        /// <param name="organizationProjects">
        /// The level of permission to grant the access token to manage organization projects and projects public preview (where available).
        /// </param>
        /// <param name="organizationPackages">
        /// The level of permission to grant the access token for organization packages published to GitHub Packages.
        /// </param>
        /// <param name="organizationSecrets">
        /// The level of permission to grant the access token to manage organization secrets.
        /// </param>
        /// <param name="organizationSelfHostedRunners">
        /// The level of permission to grant the access token to view and manage GitHub Actions self-hosted runners available to an organization.
        /// </param>
        /// <param name="organizationUserBlocking">
        /// The level of permission to grant the access token to view and manage users blocked by the organization.
        /// </param>
        /// <param name="teamDiscussions">
        /// The level of permission to grant the access token to manage team discussions and related comments.
        /// </param>
        /// <param name="emailAddresses">
        /// The level of permission to grant the access token to manage the email addresses belonging to a user.
        /// </param>
        /// <param name="followers">
        /// The level of permission to grant the access token to manage the followers belonging to a user.
        /// </param>
        /// <param name="gitSshKeys">
        /// The level of permission to grant the access token to manage git SSH keys.
        /// </param>
        /// <param name="gpgKeys">
        /// The level of permission to grant the access token to view and manage GPG keys belonging to a user.
        /// </param>
        /// <param name="interactionLimits">
        /// The level of permission to grant the access token to view and manage interaction limits on a repository.
        /// </param>
        /// <param name="profile">
        /// The level of permission to grant the access token to manage the profile settings belonging to a user.
        /// </param>
        /// <param name="starring">
        /// The level of permission to grant the access token to list and manage repositories a user is starring.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppPermissions(
            global::GitHub.AppPermissionsActions? actions,
            global::GitHub.AppPermissionsAdministration? administration,
            global::GitHub.AppPermissionsChecks? checks,
            global::GitHub.AppPermissionsCodespaces? codespaces,
            global::GitHub.AppPermissionsContents? contents,
            global::GitHub.AppPermissionsDependabotSecrets? dependabotSecrets,
            global::GitHub.AppPermissionsDeployments? deployments,
            global::GitHub.AppPermissionsEnvironments? environments,
            global::GitHub.AppPermissionsIssues? issues,
            global::GitHub.AppPermissionsMetadata? metadata,
            global::GitHub.AppPermissionsPackages? packages,
            global::GitHub.AppPermissionsPages? pages,
            global::GitHub.AppPermissionsPullRequests? pullRequests,
            global::GitHub.AppPermissionsRepositoryCustomProperties? repositoryCustomProperties,
            global::GitHub.AppPermissionsRepositoryHooks? repositoryHooks,
            global::GitHub.AppPermissionsRepositoryProjects? repositoryProjects,
            global::GitHub.AppPermissionsSecretScanningAlerts? secretScanningAlerts,
            global::GitHub.AppPermissionsSecrets? secrets,
            global::GitHub.AppPermissionsSecurityEvents? securityEvents,
            global::GitHub.AppPermissionsSingleFile? singleFile,
            global::GitHub.AppPermissionsStatuses? statuses,
            global::GitHub.AppPermissionsVulnerabilityAlerts? vulnerabilityAlerts,
            global::GitHub.AppPermissionsWorkflows? workflows,
            global::GitHub.AppPermissionsMembers? members,
            global::GitHub.AppPermissionsOrganizationAdministration? organizationAdministration,
            global::GitHub.AppPermissionsOrganizationCustomRoles? organizationCustomRoles,
            global::GitHub.AppPermissionsOrganizationCustomOrgRoles? organizationCustomOrgRoles,
            global::GitHub.AppPermissionsOrganizationCustomProperties? organizationCustomProperties,
            global::GitHub.AppPermissionsOrganizationCopilotSeatManagement? organizationCopilotSeatManagement,
            global::GitHub.AppPermissionsOrganizationAnnouncementBanners? organizationAnnouncementBanners,
            global::GitHub.AppPermissionsOrganizationEvents? organizationEvents,
            global::GitHub.AppPermissionsOrganizationHooks? organizationHooks,
            global::GitHub.AppPermissionsOrganizationPersonalAccessTokens? organizationPersonalAccessTokens,
            global::GitHub.AppPermissionsOrganizationPersonalAccessTokenRequests? organizationPersonalAccessTokenRequests,
            global::GitHub.AppPermissionsOrganizationPlan? organizationPlan,
            global::GitHub.AppPermissionsOrganizationProjects? organizationProjects,
            global::GitHub.AppPermissionsOrganizationPackages? organizationPackages,
            global::GitHub.AppPermissionsOrganizationSecrets? organizationSecrets,
            global::GitHub.AppPermissionsOrganizationSelfHostedRunners? organizationSelfHostedRunners,
            global::GitHub.AppPermissionsOrganizationUserBlocking? organizationUserBlocking,
            global::GitHub.AppPermissionsTeamDiscussions? teamDiscussions,
            global::GitHub.AppPermissionsEmailAddresses? emailAddresses,
            global::GitHub.AppPermissionsFollowers? followers,
            global::GitHub.AppPermissionsGitSshKeys? gitSshKeys,
            global::GitHub.AppPermissionsGpgKeys? gpgKeys,
            global::GitHub.AppPermissionsInteractionLimits? interactionLimits,
            global::GitHub.AppPermissionsProfile? profile,
            global::GitHub.AppPermissionsStarring? starring)
        {
            this.Actions = actions;
            this.Administration = administration;
            this.Checks = checks;
            this.Codespaces = codespaces;
            this.Contents = contents;
            this.DependabotSecrets = dependabotSecrets;
            this.Deployments = deployments;
            this.Environments = environments;
            this.Issues = issues;
            this.Metadata = metadata;
            this.Packages = packages;
            this.Pages = pages;
            this.PullRequests = pullRequests;
            this.RepositoryCustomProperties = repositoryCustomProperties;
            this.RepositoryHooks = repositoryHooks;
            this.RepositoryProjects = repositoryProjects;
            this.SecretScanningAlerts = secretScanningAlerts;
            this.Secrets = secrets;
            this.SecurityEvents = securityEvents;
            this.SingleFile = singleFile;
            this.Statuses = statuses;
            this.VulnerabilityAlerts = vulnerabilityAlerts;
            this.Workflows = workflows;
            this.Members = members;
            this.OrganizationAdministration = organizationAdministration;
            this.OrganizationCustomRoles = organizationCustomRoles;
            this.OrganizationCustomOrgRoles = organizationCustomOrgRoles;
            this.OrganizationCustomProperties = organizationCustomProperties;
            this.OrganizationCopilotSeatManagement = organizationCopilotSeatManagement;
            this.OrganizationAnnouncementBanners = organizationAnnouncementBanners;
            this.OrganizationEvents = organizationEvents;
            this.OrganizationHooks = organizationHooks;
            this.OrganizationPersonalAccessTokens = organizationPersonalAccessTokens;
            this.OrganizationPersonalAccessTokenRequests = organizationPersonalAccessTokenRequests;
            this.OrganizationPlan = organizationPlan;
            this.OrganizationProjects = organizationProjects;
            this.OrganizationPackages = organizationPackages;
            this.OrganizationSecrets = organizationSecrets;
            this.OrganizationSelfHostedRunners = organizationSelfHostedRunners;
            this.OrganizationUserBlocking = organizationUserBlocking;
            this.TeamDiscussions = teamDiscussions;
            this.EmailAddresses = emailAddresses;
            this.Followers = followers;
            this.GitSshKeys = gitSshKeys;
            this.GpgKeys = gpgKeys;
            this.InteractionLimits = interactionLimits;
            this.Profile = profile;
            this.Starring = starring;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppPermissions" /> class.
        /// </summary>
        public AppPermissions()
        {
        }
    }
}