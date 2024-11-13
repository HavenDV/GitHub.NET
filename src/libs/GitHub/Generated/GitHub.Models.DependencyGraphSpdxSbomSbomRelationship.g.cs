
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DependencyGraphSpdxSbomSbomRelationship
    {
        /// <summary>
        /// The type of relationship between the two SPDX elements.<br/>
        /// Example: DEPENDS_ON
        /// </summary>
        /// <example>DEPENDS_ON</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("relationshipType")]
        public string? RelationshipType { get; set; }

        /// <summary>
        /// The SPDX identifier of the package that is the source of the relationship.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spdxElementId")]
        public string? SpdxElementId { get; set; }

        /// <summary>
        /// The SPDX identifier of the package that is the target of the relationship.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relatedSpdxElement")]
        public string? RelatedSpdxElement { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependencyGraphSpdxSbomSbomRelationship" /> class.
        /// </summary>
        /// <param name="relationshipType">
        /// The type of relationship between the two SPDX elements.<br/>
        /// Example: DEPENDS_ON
        /// </param>
        /// <param name="spdxElementId">
        /// The SPDX identifier of the package that is the source of the relationship.
        /// </param>
        /// <param name="relatedSpdxElement">
        /// The SPDX identifier of the package that is the target of the relationship.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DependencyGraphSpdxSbomSbomRelationship(
            string? relationshipType,
            string? spdxElementId,
            string? relatedSpdxElement)
        {
            this.RelationshipType = relationshipType;
            this.SpdxElementId = spdxElementId;
            this.RelatedSpdxElement = relatedSpdxElement;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependencyGraphSpdxSbomSbomRelationship" /> class.
        /// </summary>
        public DependencyGraphSpdxSbomSbomRelationship()
        {
        }
    }
}