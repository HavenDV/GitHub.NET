#nullable enable

namespace GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Create or update custom properties for an organization<br/>
        /// Creates new or updates existing custom properties defined for an organization in a batch.<br/>
        /// If the property already exists, the existing property will be replaced with the new values.<br/>
        /// Missing optional values will fall back to default values, previous values will be overwritten.<br/>
        /// E.g. if a property exists with `values_editable_by: org_and_repo_actors` and it's updated without specifying `values_editable_by`, it will be updated to default value `org_actors`.<br/>
        /// To use this endpoint, the authenticated user must be one of:<br/>
        ///   - An administrator for the organization.<br/>
        ///   - A user, or a user on a team, with the fine-grained permission of `custom_properties_org_definitions_manager` in the organization.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.CustomProperty>> OrgsCustomPropertiesForReposCreateOrUpdateOrganizationDefinitionsAsync(
            string org,
            global::GitHub.OrgsCustomPropertiesForReposCreateOrUpdateOrganizationDefinitionsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create or update custom properties for an organization<br/>
        /// Creates new or updates existing custom properties defined for an organization in a batch.<br/>
        /// If the property already exists, the existing property will be replaced with the new values.<br/>
        /// Missing optional values will fall back to default values, previous values will be overwritten.<br/>
        /// E.g. if a property exists with `values_editable_by: org_and_repo_actors` and it's updated without specifying `values_editable_by`, it will be updated to default value `org_actors`.<br/>
        /// To use this endpoint, the authenticated user must be one of:<br/>
        ///   - An administrator for the organization.<br/>
        ///   - A user, or a user on a team, with the fine-grained permission of `custom_properties_org_definitions_manager` in the organization.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="properties">
        /// The array of custom properties to create or update.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.CustomProperty>> OrgsCustomPropertiesForReposCreateOrUpdateOrganizationDefinitionsAsync(
            string org,
            global::System.Collections.Generic.IList<global::GitHub.CustomProperty> properties,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}