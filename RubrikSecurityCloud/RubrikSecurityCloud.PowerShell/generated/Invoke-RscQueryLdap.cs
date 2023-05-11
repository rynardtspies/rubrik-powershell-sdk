// Invoke-RscQueryLdap.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using Rubrik.SecurityCloud.Types;
using Rubrik.SecurityCloud.NetSDK.Client;
using Rubrik.SecurityCloud.PowerShell.Private;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using Rubrik.SecurityCloud.NetSDK.Library.HelperClasses;
using GraphQL;

namespace Rubrik.SecurityCloud.PowerShell.Cmdlets
{
    [Cmdlet(
        "Invoke",
        "RscQueryLdap",
        DefaultParameterSetName = "PrincipalList")
    ]
    public class Invoke_RscQueryLdap : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // IntegrationList parameter set
        //
        // GraphQL operation: ldapIntegrationConnection(,   first: Int,   after: String,   last: Int,   before: String,   sortOrder: SortOrder,   sortBy: LdapIntegrationFieldEnum = Name, ):LdapIntegrationConnection!
        //
        [Parameter(
            ParameterSetName = "IntegrationList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: ldapIntegrationConnection(,   first: Int,   after: String,   last: Int,   before: String,   sortOrder: SortOrder,   sortBy: LdapIntegrationFieldEnum = Name, ):LdapIntegrationConnection!",
            Position = 0
        )]
        public SwitchParameter IntegrationList { get; set; }

        [Parameter(
            ParameterSetName = "IntegrationList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument first: Int"
        )]
        public System.Int32? First { get; set; }
        [Parameter(
            ParameterSetName = "IntegrationList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument after: String"
        )]
        public System.String? After { get; set; }
        [Parameter(
            ParameterSetName = "IntegrationList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument last: Int"
        )]
        public System.Int32? Last { get; set; }
        [Parameter(
            ParameterSetName = "IntegrationList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument before: String"
        )]
        public System.String? Before { get; set; }
        [Parameter(
            ParameterSetName = "IntegrationList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument sortOrder: SortOrder"
        )]
        public SortOrder? SortOrder { get; set; }
        [Parameter(
            ParameterSetName = "IntegrationList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument sortBy: LdapIntegrationFieldEnum"
        )]
        public LdapIntegrationFieldEnum? SortBy { get; set; }
        
        // -------------------------------------------------------------------
        // PrincipalList parameter set
        //
        // GraphQL operation: ldapPrincipalConnection(,   first: Int,   after: String,   last: Int,   before: String,   sortOrder: SortOrder,   sortBy: LdapPrincipalFieldEnum = Name,   id: UUID!,   searchText: String!, ):PrincipalConnection!
        //
        [Parameter(
            ParameterSetName = "PrincipalList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: ldapPrincipalConnection(,   first: Int,   after: String,   last: Int,   before: String,   sortOrder: SortOrder,   sortBy: LdapPrincipalFieldEnum = Name,   id: UUID!,   searchText: String!, ):PrincipalConnection!",
            Position = 0
        )]
        public SwitchParameter PrincipalList { get; set; }

        [Parameter(
            ParameterSetName = "PrincipalList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument id: UUID!"
        )]
        public System.String? Id { get; set; }
        [Parameter(
            ParameterSetName = "PrincipalList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument searchText: String!"
        )]
        public System.String? SearchText { get; set; }
        
        // -------------------------------------------------------------------
        // AuthorizedPrincipalList parameter set
        //
        // GraphQL operation: ldapAuthorizedPrincipalConnection(,   first: Int,   after: String,   last: Int,   before: String,   sortOrder: SortOrder,   sortBy: LdapAuthorizedPrincipalFieldEnum = Name,   searchText: String!,   roleIds: [UUID!], ):AuthorizedPrincipalConnection!
        //
        [Parameter(
            ParameterSetName = "AuthorizedPrincipalList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: ldapAuthorizedPrincipalConnection(,   first: Int,   after: String,   last: Int,   before: String,   sortOrder: SortOrder,   sortBy: LdapAuthorizedPrincipalFieldEnum = Name,   searchText: String!,   roleIds: [UUID!], ):AuthorizedPrincipalConnection!",
            Position = 0
        )]
        public SwitchParameter AuthorizedPrincipalList { get; set; }

        [Parameter(
            ParameterSetName = "AuthorizedPrincipalList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument roleIds: [UUID!]"
        )]
        public List<System.String>? RoleIds { get; set; }

        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "IntegrationList":
                        this.ProcessRecord_IntegrationList();
                        break;
                    case "PrincipalList":
                        this.ProcessRecord_PrincipalList();
                        break;
                    case "AuthorizedPrincipalList":
                        this.ProcessRecord_AuthorizedPrincipalList();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + Op);
                }
           }
           catch (Exception ex)
           {
                this._logger.Flush();
                var error = new ErrorRecord(
                    ex,
                    "Invoke-RscQueryLdap",
                    ErrorCategory.InvalidOperation,
                    null);
                ThrowTerminatingError(error);
           }
        }

        // This parameter set invokes a single graphql operation:
        // ldapIntegrationConnection.
        protected void ProcessRecord_IntegrationList()
        {
            this._logger.name += " -IntegrationList";
            // Invoke graphql operation ldapIntegrationConnection
            InvokeQueryLdapIntegrationConnection();
        }

        // This parameter set invokes a single graphql operation:
        // ldapPrincipalConnection.
        protected void ProcessRecord_PrincipalList()
        {
            this._logger.name += " -PrincipalList";
            // Invoke graphql operation ldapPrincipalConnection
            InvokeQueryLdapPrincipalConnection();
        }

        // This parameter set invokes a single graphql operation:
        // ldapAuthorizedPrincipalConnection.
        protected void ProcessRecord_AuthorizedPrincipalList()
        {
            this._logger.name += " -AuthorizedPrincipalList";
            // Invoke graphql operation ldapAuthorizedPrincipalConnection
            InvokeQueryLdapAuthorizedPrincipalConnection();
        }


        // Invoke GraphQL Query:
        // ldapIntegrationConnection(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortOrder: SortOrder
        //     sortBy: LdapIntegrationFieldEnum = Name
        //   ): LdapIntegrationConnection!
        protected void InvokeQueryLdapIntegrationConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("sortBy", "LdapIntegrationFieldEnum"),
            };
            LdapIntegrationConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (LdapIntegrationConnection)psObject.BaseObject;
                } else {
                    fields = (LdapIntegrationConnection)this.Field;
                }
            }
            string document = Query.LdapIntegrationConnection(ref fields);
            this._input.Initialize(argDefs, fields, "Query.LdapIntegrationConnection");
            string parameters = "($first: Int,$after: String,$last: Int,$before: String,$sortOrder: SortOrder,$sortBy: LdapIntegrationFieldEnum)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryLdapIntegrationConnection" + parameters + "{" + document + "}",
                OperationName = "QueryLdapIntegrationConnection",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<LdapIntegrationConnection> task = this._rbkClient.InvokeGenericCallAsync<LdapIntegrationConnection>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // ldapPrincipalConnection(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortOrder: SortOrder
        //     sortBy: LdapPrincipalFieldEnum = Name
        //     id: UUID!
        //     searchText: String!
        //   ): PrincipalConnection!
        protected void InvokeQueryLdapPrincipalConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("sortBy", "LdapPrincipalFieldEnum"),
                Tuple.Create("id", "UUID!"),
                Tuple.Create("searchText", "String!"),
            };
            PrincipalConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (PrincipalConnection)psObject.BaseObject;
                } else {
                    fields = (PrincipalConnection)this.Field;
                }
            }
            string document = Query.LdapPrincipalConnection(ref fields);
            this._input.Initialize(argDefs, fields, "Query.LdapPrincipalConnection");
            string parameters = "($first: Int,$after: String,$last: Int,$before: String,$sortOrder: SortOrder,$sortBy: LdapPrincipalFieldEnum,$id: UUID!,$searchText: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryLdapPrincipalConnection" + parameters + "{" + document + "}",
                OperationName = "QueryLdapPrincipalConnection",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<PrincipalConnection> task = this._rbkClient.InvokeGenericCallAsync<PrincipalConnection>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // ldapAuthorizedPrincipalConnection(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortOrder: SortOrder
        //     sortBy: LdapAuthorizedPrincipalFieldEnum = Name
        //     searchText: String!
        //     roleIds: [UUID!]
        //   ): AuthorizedPrincipalConnection!
        protected void InvokeQueryLdapAuthorizedPrincipalConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("sortBy", "LdapAuthorizedPrincipalFieldEnum"),
                Tuple.Create("searchText", "String!"),
                Tuple.Create("roleIds", "[UUID!]"),
            };
            AuthorizedPrincipalConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AuthorizedPrincipalConnection)psObject.BaseObject;
                } else {
                    fields = (AuthorizedPrincipalConnection)this.Field;
                }
            }
            string document = Query.LdapAuthorizedPrincipalConnection(ref fields);
            this._input.Initialize(argDefs, fields, "Query.LdapAuthorizedPrincipalConnection");
            string parameters = "($first: Int,$after: String,$last: Int,$before: String,$sortOrder: SortOrder,$sortBy: LdapAuthorizedPrincipalFieldEnum,$searchText: String!,$roleIds: [UUID!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryLdapAuthorizedPrincipalConnection" + parameters + "{" + document + "}",
                OperationName = "QueryLdapAuthorizedPrincipalConnection",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AuthorizedPrincipalConnection> task = this._rbkClient.InvokeGenericCallAsync<AuthorizedPrincipalConnection>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }


    } // class Invoke_RscQueryLdap
}