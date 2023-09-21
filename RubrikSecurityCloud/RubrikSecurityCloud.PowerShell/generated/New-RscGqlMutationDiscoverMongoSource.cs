// New-RscGqlMutationDiscoverMongoSource.cs
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
    /// Create new GraphQL Mutation discoverMongoSource
    /// discoverMongoSource(input: DiscoverMongoSourceInput!): AsyncRequestStatus!
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlMutationDiscoverMongoSource")
    ]
    public class New_RscGqlMutationDiscoverMongoSource : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("discoverMongoSource");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Mutation discoverMongoSource
        /// discoverMongoSource(input: DiscoverMongoSourceInput!): AsyncRequestStatus!
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_discoverMongoSource();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_discoverMongoSource()
        {
            this._logger.name += " -discoverMongoSource";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DiscoverMongoSourceInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDiscoverMongoSource",
                "($input: DiscoverMongoSourceInput!)",
                "AsyncRequestStatus",
                Mutation.DiscoverMongoSource_ObjectFieldSpec,
                Mutation.DiscoverMongoSourceFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

    } // class New-RscGqlMutationDiscoverMongoSource
}