// New-RscGqlQueryOracleTopLevelDescendants.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using GraphQL;
using RubrikSecurityCloud;
using RubrikSecurityCloud.Types;
using RubrikSecurityCloud.NetSDK.Client;
using RubrikSecurityCloud.PowerShell.Private;

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    /// <summary>
    /// Create new GraphQL Query oracleTopLevelDescendants
    /// oracleTopLevelDescendants(
    ///     first: Int
    ///     after: String
    ///     sortBy: HierarchySortByField
    ///     sortOrder: SortOrder
    ///     typeFilter: [HierarchyObjectTypeEnum!]
    ///     filter: [Filter!]
    ///   ): OracleTopLevelDescendantTypeConnection!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryOracleTopLevelDescendants")
    ]
    public class New_RscGqlQueryOracleTopLevelDescendants : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("oracleTopLevelDescendants");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query oracleTopLevelDescendants
        /// oracleTopLevelDescendants(
        ///     first: Int
        ///     after: String
        ///     sortBy: HierarchySortByField
        ///     sortOrder: SortOrder
        ///     typeFilter: [HierarchyObjectTypeEnum!]
        ///     filter: [Filter!]
        ///   ): OracleTopLevelDescendantTypeConnection!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_oracleTopLevelDescendants();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_oracleTopLevelDescendants()
        {
            this._logger.name += " -oracleTopLevelDescendants";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("typeFilter", "[HierarchyObjectTypeEnum!]"),
                Tuple.Create("filter", "[Filter!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOracleTopLevelDescendants",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$typeFilter: [HierarchyObjectTypeEnum!],$filter: [Filter!])",
                "OracleTopLevelDescendantTypeConnection",
                Query.OracleTopLevelDescendants_ObjectFieldSpec,
                Query.OracleTopLevelDescendantsFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.typeFilter = @(
	<HierarchyObjectTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
)
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)"
            );
        }

    } // class New-RscGqlQueryOracleTopLevelDescendants
}