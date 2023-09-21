// New-RscGqlQueryNutanixClusterContainers.cs
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
    /// Create new GraphQL Query nutanixClusterContainers
    /// nutanixClusterContainers(input: GetContainersInput!): NutanixContainerListResponse!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryNutanixClusterContainers")
    ]
    public class New_RscGqlQueryNutanixClusterContainers : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("nutanixClusterContainers");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query nutanixClusterContainers
        /// nutanixClusterContainers(input: GetContainersInput!): NutanixContainerListResponse!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_nutanixClusterContainers();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_nutanixClusterContainers()
        {
            this._logger.name += " -nutanixClusterContainers";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetContainersInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryNutanixClusterContainers",
                "($input: GetContainersInput!)",
                "NutanixContainerListResponse",
                Query.NutanixClusterContainers_ObjectFieldSpec,
                Query.NutanixClusterContainersFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlQueryNutanixClusterContainers
}