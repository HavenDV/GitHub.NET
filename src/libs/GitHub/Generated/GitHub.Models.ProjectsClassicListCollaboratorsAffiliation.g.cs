
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum ProjectsClassicListCollaboratorsAffiliation
    {
        /// <summary>
        /// 
        /// </summary>
        Outside,
        /// <summary>
        /// 
        /// </summary>
        Direct,
        /// <summary>
        /// 
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectsClassicListCollaboratorsAffiliationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsClassicListCollaboratorsAffiliation value)
        {
            return value switch
            {
                ProjectsClassicListCollaboratorsAffiliation.Outside => "outside",
                ProjectsClassicListCollaboratorsAffiliation.Direct => "direct",
                ProjectsClassicListCollaboratorsAffiliation.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsClassicListCollaboratorsAffiliation? ToEnum(string value)
        {
            return value switch
            {
                "outside" => ProjectsClassicListCollaboratorsAffiliation.Outside,
                "direct" => ProjectsClassicListCollaboratorsAffiliation.Direct,
                "all" => ProjectsClassicListCollaboratorsAffiliation.All,
                _ => null,
            };
        }
    }
}