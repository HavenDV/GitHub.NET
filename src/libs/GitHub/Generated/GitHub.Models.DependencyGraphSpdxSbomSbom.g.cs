
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DependencyGraphSpdxSbomSbom
    {
        /// <summary>
        /// The SPDX identifier for the SPDX document.<br/>
        /// Example: SPDXRef-DOCUMENT
        /// </summary>
        /// <example>SPDXRef-DOCUMENT</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("SPDXID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SPDXID { get; set; }

        /// <summary>
        /// The version of the SPDX specification that this document conforms to.<br/>
        /// Example: SPDX-2.3
        /// </summary>
        /// <example>SPDX-2.3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("spdxVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpdxVersion { get; set; }

        /// <summary>
        /// An optional comment about the SPDX document.<br/>
        /// Example: Exact versions could not be resolved for some packages. For more information: https://docs.github.com/en/code-security/supply-chain-security/understanding-your-software-supply-chain/
        /// </summary>
        /// <example>Exact versions could not be resolved for some packages. For more information: https://docs.github.com/en/code-security/supply-chain-security/understanding-your-software-supply-chain/</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creationInfo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.DependencyGraphSpdxSbomSbomCreationInfo CreationInfo { get; set; }

        /// <summary>
        /// The name of the SPDX document.<br/>
        /// Example: github/github
        /// </summary>
        /// <example>github/github</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The license under which the SPDX document is licensed.<br/>
        /// Example: CC0-1.0
        /// </summary>
        /// <example>CC0-1.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataLicense")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DataLicense { get; set; }

        /// <summary>
        /// The namespace for the SPDX document.<br/>
        /// Example: https://spdx.org/spdxdocs/protobom/15e41dd2-f961-4f4d-b8dc-f8f57ad70d57
        /// </summary>
        /// <example>https://spdx.org/spdxdocs/protobom/15e41dd2-f961-4f4d-b8dc-f8f57ad70d57</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentNamespace")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DocumentNamespace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::GitHub.DependencyGraphSpdxSbomSbomPackage> Packages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relationships")]
        public global::System.Collections.Generic.IList<global::GitHub.DependencyGraphSpdxSbomSbomRelationship>? Relationships { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependencyGraphSpdxSbomSbom" /> class.
        /// </summary>
        /// <param name="sPDXID">
        /// The SPDX identifier for the SPDX document.<br/>
        /// Example: SPDXRef-DOCUMENT
        /// </param>
        /// <param name="spdxVersion">
        /// The version of the SPDX specification that this document conforms to.<br/>
        /// Example: SPDX-2.3
        /// </param>
        /// <param name="comment">
        /// An optional comment about the SPDX document.<br/>
        /// Example: Exact versions could not be resolved for some packages. For more information: https://docs.github.com/en/code-security/supply-chain-security/understanding-your-software-supply-chain/
        /// </param>
        /// <param name="creationInfo"></param>
        /// <param name="name">
        /// The name of the SPDX document.<br/>
        /// Example: github/github
        /// </param>
        /// <param name="dataLicense">
        /// The license under which the SPDX document is licensed.<br/>
        /// Example: CC0-1.0
        /// </param>
        /// <param name="documentNamespace">
        /// The namespace for the SPDX document.<br/>
        /// Example: https://spdx.org/spdxdocs/protobom/15e41dd2-f961-4f4d-b8dc-f8f57ad70d57
        /// </param>
        /// <param name="packages"></param>
        /// <param name="relationships"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DependencyGraphSpdxSbomSbom(
            string sPDXID,
            string spdxVersion,
            global::GitHub.DependencyGraphSpdxSbomSbomCreationInfo creationInfo,
            string name,
            string dataLicense,
            string documentNamespace,
            global::System.Collections.Generic.IList<global::GitHub.DependencyGraphSpdxSbomSbomPackage> packages,
            string? comment,
            global::System.Collections.Generic.IList<global::GitHub.DependencyGraphSpdxSbomSbomRelationship>? relationships)
        {
            this.SPDXID = sPDXID ?? throw new global::System.ArgumentNullException(nameof(sPDXID));
            this.SpdxVersion = spdxVersion ?? throw new global::System.ArgumentNullException(nameof(spdxVersion));
            this.CreationInfo = creationInfo ?? throw new global::System.ArgumentNullException(nameof(creationInfo));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DataLicense = dataLicense ?? throw new global::System.ArgumentNullException(nameof(dataLicense));
            this.DocumentNamespace = documentNamespace ?? throw new global::System.ArgumentNullException(nameof(documentNamespace));
            this.Packages = packages ?? throw new global::System.ArgumentNullException(nameof(packages));
            this.Comment = comment;
            this.Relationships = relationships;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependencyGraphSpdxSbomSbom" /> class.
        /// </summary>
        public DependencyGraphSpdxSbomSbom()
        {
        }
    }
}