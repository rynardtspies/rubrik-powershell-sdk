// New-RscGqlQueryCdmMssqlLogShippingTarget.cs
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
    /// Create new GraphQL Query cdmMssqlLogShippingTarget
    /// cdmMssqlLogShippingTarget(fid: UUID!): MssqlLogShippingTarget
    /// </summary>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscGqlQueryCdmMssqlLogShippingTarget")
    ]
    public class New_RscGqlQueryCdmMssqlLogShippingTarget : RscGqlPSCmdlet
    {
        // ~~~~~~~~~~~~~~~~~~~~~
        // Under the covers,
        // we make the New-RscGqlQuery* cmdlets
        // fit in the New-RscQuery<ApiDomain> -<Op> cmdlet nomenclature.
        internal override RscOp GetRscOp()
        {
            return SchemaMeta.RscOpLookupByGqlRootField("cdmMssqlLogShippingTarget");
        }

        internal override string DetermineOp(bool unknownOk = false)
        {
            return GetRscOp().CmdletSwitchName;
        }
        // ~~~~~~~~~~~~~~~~~~~~~

        /// <summary>
        /// Create new GraphQL Query cdmMssqlLogShippingTarget
        /// cdmMssqlLogShippingTarget(fid: UUID!): MssqlLogShippingTarget
        /// </summary>
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                this.ProcessRecord_cdmMssqlLogShippingTarget();
            }
            catch (Exception ex)
            {
                ThrowTerminatingException(ex);
            }
        }

        internal void ProcessRecord_cdmMssqlLogShippingTarget()
        {
            this._logger.name += " -cdmMssqlLogShippingTarget";
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCdmMssqlLogShippingTarget",
                "($fid: UUID!)",
                "MssqlLogShippingTarget",
                Query.CdmMssqlLogShippingTarget_ObjectFieldSpec,
                Query.CdmMssqlLogShippingTargetFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }

    } // class New-RscGqlQueryCdmMssqlLogShippingTarget
}