// New-RscMutationCertificate.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using RubrikSecurityCloud;
using RubrikSecurityCloud.Types;
using RubrikSecurityCloud.NetSDK.Client;
using RubrikSecurityCloud.PowerShell.Private;

// ignore warning 'Missing XML comment'
#pragma warning disable 1591

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    /// <summary>
    /// Create a new RscQuery object for any of the 10
    /// operations in the 'Certificates' API domain:
    /// AddClusterCertificate, AddGlobal, Delete, DeleteGlobal, MarkAgentSecondary, SetSso, SetWebSigned, Update, UpdateGlobal, or UpdateHost.
    /// </summary>
    /// <description>
    /// New-RscMutationCertificate creates a new
    /// mutation object for operations
    /// in the 'Certificates' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 10 operations
    /// in the 'Certificates' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: AddClusterCertificate, AddGlobal, Delete, DeleteGlobal, MarkAgentSecondary, SetSso, SetWebSigned, Update, UpdateGlobal, or UpdateHost.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationCertificate -AddClusterCertificate).Info().
    /// Each operation also has its own set of fields that can be
    /// selected for retrieval. If you do not specify any fields,
    /// a set of default fields will be selected. The selection is
    /// rule-based, and tries to select the most commonly used fields.
    /// For example if a field is named 'id' or 'name', 
    /// it will be selected. If you give -FieldProfile DETAIL, then
    /// another set of rules will be used to select more fields on top
    /// of the default fields. The set of rules for selecting fields
    /// is called a field profile. You can specify a field profile
    /// with the -FieldProfile parameter. You can add or remove fields
    /// from the field profile with the -AddField and -RemoveField
    /// parameters. If you end up with too many -AddField and -RemoveField
    /// parameters, you can list them in a text file, one per line,
    /// with a '+' or '-' prefix, and pass the file name to the
    /// -FilePatch parameter. Profiles and Patches are one way to
    /// customize the fields that are selected. Another way is to
    /// specify the fields by passing the -Field parameter an object
    /// that contains the fields you want to select as properties.
    /// Any property that is not null in that object is interpreted
    /// as a field to select
    /// (and the actual values they are set to do not matter).
    /// The [RubrikSecurityCloud.Types] namespace
    /// contains a set of classes that you can use to specify fields.
    /// To know what [RubrikSecurityCloud.Types] object to use
    /// for a specific operation,
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscMutationCertificate -AddClusterCertificate).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the AddClusterCertificate operation
    /// of the 'Certificates' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Certificate
    /// # API Operation: AddClusterCertificate
    /// 
    /// $query = New-RscMutationCertificate -AddClusterCertificate
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	certImportRequest = @{
    /// 		# OPTIONAL
    /// 		csrId = $someString
    /// 		# OPTIONAL
    /// 		description = $someString
    /// 		# OPTIONAL
    /// 		privateKey = $someString
    /// 		# OPTIONAL
    /// 		isTrusted = $someBoolean
    /// 		# REQUIRED
    /// 		name = $someString
    /// 		# REQUIRED
    /// 		pemFile = $someString
    /// 	}
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AddClusterCertificateReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AddGlobal operation
    /// of the 'Certificates' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Certificate
    /// # API Operation: AddGlobal
    /// 
    /// $query = New-RscMutationCertificate -AddGlobal
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	description = $someString
    /// 	# OPTIONAL
    /// 	privateKey = $someString
    /// 	# REQUIRED
    /// 	certificate = $someString
    /// 	# OPTIONAL
    /// 	clusters = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			clusterUuid = $someString
    /// 			# REQUIRED
    /// 			isTrusted = $someBoolean
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	csrFid = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AddGlobalCertificateReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Delete operation
    /// of the 'Certificates' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Certificate
    /// # API Operation: Delete
    /// 
    /// $query = New-RscMutationCertificate -Delete
    /// 
    /// # REQUIRED
    /// $query.Var.certificateId = $someInt64
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DeleteGlobal operation
    /// of the 'Certificates' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Certificate
    /// # API Operation: DeleteGlobal
    /// 
    /// $query = New-RscMutationCertificate -DeleteGlobal
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	certificateId = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: DeleteGlobalCertificateReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the MarkAgentSecondary operation
    /// of the 'Certificates' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Certificate
    /// # API Operation: MarkAgentSecondary
    /// 
    /// $query = New-RscMutationCertificate -MarkAgentSecondary
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	certId = $someString
    /// 	# REQUIRED
    /// 	clusterUuid = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: MarkAgentSecondaryCertificateReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SetSso operation
    /// of the 'Certificates' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Certificate
    /// # API Operation: SetSso
    /// 
    /// $query = New-RscMutationCertificate -SetSso
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	certificateId = $someInt
    /// 	# REQUIRED
    /// 	certificateType = $someSsoCertificateType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SsoCertificateType]) for enum values.
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.String
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SetWebSigned operation
    /// of the 'Certificates' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Certificate
    /// # API Operation: SetWebSigned
    /// 
    /// $query = New-RscMutationCertificate -SetWebSigned
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	certificatePayload = @{
    /// 		# REQUIRED
    /// 		certificateId = $someString
    /// 	}
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: AsyncRequestStatus
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Update operation
    /// of the 'Certificates' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Certificate
    /// # API Operation: Update
    /// 
    /// $query = New-RscMutationCertificate -Update
    /// 
    /// # REQUIRED
    /// $query.Var.certificateId = $someInt64
    /// # OPTIONAL
    /// $query.Var.name = $someString
    /// # OPTIONAL
    /// $query.Var.description = $someString
    /// # OPTIONAL
    /// $query.Var.certificate = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: System.Boolean
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateGlobal operation
    /// of the 'Certificates' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Certificate
    /// # API Operation: UpdateGlobal
    /// 
    /// $query = New-RscMutationCertificate -UpdateGlobal
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	certificateId = $someString
    /// 	# OPTIONAL
    /// 	name = $someString
    /// 	# OPTIONAL
    /// 	description = $someString
    /// 	# REQUIRED
    /// 	clusters = @(
    /// 		@{
    /// 			# REQUIRED
    /// 			clusterUuid = $someString
    /// 			# REQUIRED
    /// 			isTrusted = $someBoolean
    /// 		}
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateGlobalCertificateReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the UpdateHost operation
    /// of the 'Certificates' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Certificate
    /// # API Operation: UpdateHost
    /// 
    /// $query = New-RscMutationCertificate -UpdateHost
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# REQUIRED
    /// 	id = $someString
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: UpdateCertificateHostReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscMutationCertificate",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscMutationCertificate : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "AddClusterCertificate",
                "AddGlobal",
                "Delete",
                "DeleteGlobal",
                "MarkAgentSecondary",
                "SetSso",
                "SetWebSigned",
                "Update",
                "UpdateGlobal",
                "UpdateHost",
                IgnoreCase = true)]
        public string Operation { get; set; } = "";

        internal override string GetOperationParameter()
        {
            return this.Operation;
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(this.GetOp().OpName())
                {
                    case "AddClusterCertificate":
                        this.ProcessRecord_AddClusterCertificate();
                        break;
                    case "AddGlobal":
                        this.ProcessRecord_AddGlobal();
                        break;
                    case "Delete":
                        this.ProcessRecord_Delete();
                        break;
                    case "DeleteGlobal":
                        this.ProcessRecord_DeleteGlobal();
                        break;
                    case "MarkAgentSecondary":
                        this.ProcessRecord_MarkAgentSecondary();
                        break;
                    case "SetSso":
                        this.ProcessRecord_SetSso();
                        break;
                    case "SetWebSigned":
                        this.ProcessRecord_SetWebSigned();
                        break;
                    case "Update":
                        this.ProcessRecord_Update();
                        break;
                    case "UpdateGlobal":
                        this.ProcessRecord_UpdateGlobal();
                        break;
                    case "UpdateHost":
                        this.ProcessRecord_UpdateHost();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + this.GetOp().OpName());
                }
           }
           catch (Exception ex)
           {
                ThrowTerminatingException(ex);
           }
        }

        // This parameter set invokes a single graphql operation:
        // addClusterCertificate.
        internal void ProcessRecord_AddClusterCertificate()
        {
            this._logger.name += " -AddClusterCertificate";
            // Create new graphql operation addClusterCertificate
            InitMutationAddClusterCertificate();
        }

        // This parameter set invokes a single graphql operation:
        // addGlobalCertificate.
        internal void ProcessRecord_AddGlobal()
        {
            this._logger.name += " -AddGlobal";
            // Create new graphql operation addGlobalCertificate
            InitMutationAddGlobalCertificate();
        }

        // This parameter set invokes a single graphql operation:
        // deleteCertificate.
        internal void ProcessRecord_Delete()
        {
            this._logger.name += " -Delete";
            // Create new graphql operation deleteCertificate
            InitMutationDeleteCertificate();
        }

        // This parameter set invokes a single graphql operation:
        // deleteGlobalCertificate.
        internal void ProcessRecord_DeleteGlobal()
        {
            this._logger.name += " -DeleteGlobal";
            // Create new graphql operation deleteGlobalCertificate
            InitMutationDeleteGlobalCertificate();
        }

        // This parameter set invokes a single graphql operation:
        // markAgentSecondaryCertificate.
        internal void ProcessRecord_MarkAgentSecondary()
        {
            this._logger.name += " -MarkAgentSecondary";
            // Create new graphql operation markAgentSecondaryCertificate
            InitMutationMarkAgentSecondaryCertificate();
        }

        // This parameter set invokes a single graphql operation:
        // setSsoCertificate.
        internal void ProcessRecord_SetSso()
        {
            this._logger.name += " -SetSso";
            // Create new graphql operation setSsoCertificate
            InitMutationSetSsoCertificate();
        }

        // This parameter set invokes a single graphql operation:
        // setWebSignedCertificate.
        internal void ProcessRecord_SetWebSigned()
        {
            this._logger.name += " -SetWebSigned";
            // Create new graphql operation setWebSignedCertificate
            InitMutationSetWebSignedCertificate();
        }

        // This parameter set invokes a single graphql operation:
        // updateCertificate.
        internal void ProcessRecord_Update()
        {
            this._logger.name += " -Update";
            // Create new graphql operation updateCertificate
            InitMutationUpdateCertificate();
        }

        // This parameter set invokes a single graphql operation:
        // updateGlobalCertificate.
        internal void ProcessRecord_UpdateGlobal()
        {
            this._logger.name += " -UpdateGlobal";
            // Create new graphql operation updateGlobalCertificate
            InitMutationUpdateGlobalCertificate();
        }

        // This parameter set invokes a single graphql operation:
        // updateCertificateHost.
        internal void ProcessRecord_UpdateHost()
        {
            this._logger.name += " -UpdateHost";
            // Create new graphql operation updateCertificateHost
            InitMutationUpdateCertificateHost();
        }


        // Create new GraphQL Mutation:
        // addClusterCertificate(input: AddClusterCertificateInput!): AddClusterCertificateReply!
        internal void InitMutationAddClusterCertificate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddClusterCertificateInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddClusterCertificate",
                "($input: AddClusterCertificateInput!)",
                "AddClusterCertificateReply",
                Mutation.AddClusterCertificate_ObjectFieldSpec,
                Mutation.AddClusterCertificateFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	certImportRequest = @{
		# OPTIONAL
		csrId = $someString
		# OPTIONAL
		description = $someString
		# OPTIONAL
		privateKey = $someString
		# OPTIONAL
		isTrusted = $someBoolean
		# REQUIRED
		name = $someString
		# REQUIRED
		pemFile = $someString
	}
	# REQUIRED
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // addGlobalCertificate(input: AddGlobalCertificateInput!): AddGlobalCertificateReply!
        internal void InitMutationAddGlobalCertificate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddGlobalCertificateInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationAddGlobalCertificate",
                "($input: AddGlobalCertificateInput!)",
                "AddGlobalCertificateReply",
                Mutation.AddGlobalCertificate_ObjectFieldSpec,
                Mutation.AddGlobalCertificateFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	name = $someString
	# OPTIONAL
	description = $someString
	# OPTIONAL
	privateKey = $someString
	# REQUIRED
	certificate = $someString
	# OPTIONAL
	clusters = @(
		@{
			# REQUIRED
			clusterUuid = $someString
			# REQUIRED
			isTrusted = $someBoolean
		}
	)
	# OPTIONAL
	csrFid = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // deleteCertificate(certificateId: Long!): Boolean!
        internal void InitMutationDeleteCertificate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("certificateId", "Long!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteCertificate",
                "($certificateId: Long!)",
                "System.Boolean",
                Mutation.DeleteCertificate_ObjectFieldSpec,
                Mutation.DeleteCertificateFieldSpec,
                @"# REQUIRED
$query.Var.certificateId = $someInt64"
            );
        }

        // Create new GraphQL Mutation:
        // deleteGlobalCertificate(input: DeleteGlobalCertificateInput!): DeleteGlobalCertificateReply!
        internal void InitMutationDeleteGlobalCertificate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteGlobalCertificateInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationDeleteGlobalCertificate",
                "($input: DeleteGlobalCertificateInput!)",
                "DeleteGlobalCertificateReply",
                Mutation.DeleteGlobalCertificate_ObjectFieldSpec,
                Mutation.DeleteGlobalCertificateFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	certificateId = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // markAgentSecondaryCertificate(input: MarkAgentSecondaryCertificateInput!): MarkAgentSecondaryCertificateReply!
        internal void InitMutationMarkAgentSecondaryCertificate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MarkAgentSecondaryCertificateInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationMarkAgentSecondaryCertificate",
                "($input: MarkAgentSecondaryCertificateInput!)",
                "MarkAgentSecondaryCertificateReply",
                Mutation.MarkAgentSecondaryCertificate_ObjectFieldSpec,
                Mutation.MarkAgentSecondaryCertificateFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	certId = $someString
	# REQUIRED
	clusterUuid = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // setSsoCertificate(input: SetSsoCertificateInput!): Void
        internal void InitMutationSetSsoCertificate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SetSsoCertificateInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetSsoCertificate",
                "($input: SetSsoCertificateInput!)",
                "System.String",
                Mutation.SetSsoCertificate_ObjectFieldSpec,
                Mutation.SetSsoCertificateFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	certificateId = $someInt
	# REQUIRED
	certificateType = $someSsoCertificateType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SsoCertificateType]) for enum values.
}"
            );
        }

        // Create new GraphQL Mutation:
        // setWebSignedCertificate(input: SetWebSignedCertificateInput!): AsyncRequestStatus!
        internal void InitMutationSetWebSignedCertificate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SetWebSignedCertificateInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationSetWebSignedCertificate",
                "($input: SetWebSignedCertificateInput!)",
                "AsyncRequestStatus",
                Mutation.SetWebSignedCertificate_ObjectFieldSpec,
                Mutation.SetWebSignedCertificateFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	certificatePayload = @{
		# REQUIRED
		certificateId = $someString
	}
	# REQUIRED
	id = $someString
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateCertificate(
        //     certificateId: Long!
        //     name: String
        //     description: String
        //     certificate: String
        //   ): Boolean!
        internal void InitMutationUpdateCertificate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("certificateId", "Long!"),
                Tuple.Create("name", "String"),
                Tuple.Create("description", "String"),
                Tuple.Create("certificate", "String"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateCertificate",
                "($certificateId: Long!,$name: String,$description: String,$certificate: String)",
                "System.Boolean",
                Mutation.UpdateCertificate_ObjectFieldSpec,
                Mutation.UpdateCertificateFieldSpec,
                @"# REQUIRED
$query.Var.certificateId = $someInt64
# OPTIONAL
$query.Var.name = $someString
# OPTIONAL
$query.Var.description = $someString
# OPTIONAL
$query.Var.certificate = $someString"
            );
        }

        // Create new GraphQL Mutation:
        // updateGlobalCertificate(input: UpdateGlobalCertificateInput!): UpdateGlobalCertificateReply!
        internal void InitMutationUpdateGlobalCertificate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateGlobalCertificateInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateGlobalCertificate",
                "($input: UpdateGlobalCertificateInput!)",
                "UpdateGlobalCertificateReply",
                Mutation.UpdateGlobalCertificate_ObjectFieldSpec,
                Mutation.UpdateGlobalCertificateFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	certificateId = $someString
	# OPTIONAL
	name = $someString
	# OPTIONAL
	description = $someString
	# REQUIRED
	clusters = @(
		@{
			# REQUIRED
			clusterUuid = $someString
			# REQUIRED
			isTrusted = $someBoolean
		}
	)
}"
            );
        }

        // Create new GraphQL Mutation:
        // updateCertificateHost(input: UpdateCertificateHostInput!): UpdateCertificateHostReply!
        internal void InitMutationUpdateCertificateHost()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateCertificateHostInput!"),
            };
            Initialize(
                argDefs,
                "mutation",
                "MutationUpdateCertificateHost",
                "($input: UpdateCertificateHostInput!)",
                "UpdateCertificateHostReply",
                Mutation.UpdateCertificateHost_ObjectFieldSpec,
                Mutation.UpdateCertificateHostFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# REQUIRED
	id = $someString
}"
            );
        }


    } // class New_RscMutationCertificate
}