
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The vulnerable dependency's relationship to your project.<br/>
    /// &gt; [!NOTE]<br/>
    /// &gt; We are rolling out support for dependency relationship across ecosystems. This value will be "unknown" for all dependencies in unsupported ecosystems.<br/>
    /// Included only in responses
    /// </summary>
    public enum DependabotAlertDependencyRelationship
    {
        /// <summary>
        /// 
        /// </summary>
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        Direct,
        /// <summary>
        /// 
        /// </summary>
        Transitive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DependabotAlertDependencyRelationshipExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependabotAlertDependencyRelationship value)
        {
            return value switch
            {
                DependabotAlertDependencyRelationship.Unknown => "unknown",
                DependabotAlertDependencyRelationship.Direct => "direct",
                DependabotAlertDependencyRelationship.Transitive => "transitive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependabotAlertDependencyRelationship? ToEnum(string value)
        {
            return value switch
            {
                "unknown" => DependabotAlertDependencyRelationship.Unknown,
                "direct" => DependabotAlertDependencyRelationship.Direct,
                "transitive" => DependabotAlertDependencyRelationship.Transitive,
                _ => null,
            };
        }
    }
}