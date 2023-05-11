// Invoke-RscQueryCluster.cs
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
        "RscQueryCluster",
        DefaultParameterSetName = "Cluster")
    ]
    public class Invoke_RscQueryCluster : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // Node parameter set
        //
        // GraphQL operation: clusterNodes(input: GetNodesInput!):NodeStatusListResponse!
        //
        [Parameter(
            ParameterSetName = "Node",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: clusterNodes(input: GetNodesInput!):NodeStatusListResponse!",
            Position = 0
        )]
        public SwitchParameter Node { get; set; }

        [Parameter(
            ParameterSetName = "Node",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument input: GetNodesInput!"
        )]
        public GetNodesInput? Input { get; set; }
        
        // -------------------------------------------------------------------
        // List parameter set
        //
        // GraphQL operation: clusterConnection(,   first: Int,   after: String,   last: Int,   before: String,   filter: ClusterFilterInput,   sortOrder: SortOrder = DESC,   sortBy: ClusterSortByEnum = ClusterType, ):ClusterConnection!
        //
        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: clusterConnection(,   first: Int,   after: String,   last: Int,   before: String,   filter: ClusterFilterInput,   sortOrder: SortOrder = DESC,   sortBy: ClusterSortByEnum = ClusterType, ):ClusterConnection!",
            Position = 0
        )]
        public SwitchParameter List { get; set; }

        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument first: Int"
        )]
        public System.Int32? First { get; set; }
        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument after: String"
        )]
        public System.String? After { get; set; }
        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument last: Int"
        )]
        public System.Int32? Last { get; set; }
        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument before: String"
        )]
        public System.String? Before { get; set; }
        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument filter: ClusterFilterInput"
        )]
        public ClusterFilterInput? Filter { get; set; }
        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument sortOrder: SortOrder"
        )]
        public SortOrder? SortOrder { get; set; }
        [Parameter(
            ParameterSetName = "List",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument sortBy: ClusterSortByEnum"
        )]
        public ClusterSortByEnum? SortBy { get; set; }
        
        // -------------------------------------------------------------------
        // Cluster parameter set
        //
        // GraphQL operation: cluster(clusterUuid: UUID!):Cluster!
        //
        [Parameter(
            ParameterSetName = "Cluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: cluster(clusterUuid: UUID!):Cluster!",
            Position = 0
        )]
        public SwitchParameter Cluster { get; set; }

        [Parameter(
            ParameterSetName = "Cluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument clusterUuid: UUID!"
        )]
        public System.String? ClusterUuid { get; set; }
        
        // -------------------------------------------------------------------
        // WithUpgradesInfo parameter set
        //
        // GraphQL operation: clusterWithUpgradesInfo(,   first: Int,   after: String,   last: Int,   before: String,   upgradeFilter: CdmUpgradeInfoFilterInput,   sortOrder: SortOrder = DESC,   sortBy: UpgradeInfoSortByEnum = ClusterType, ):ClusterConnection!
        //
        [Parameter(
            ParameterSetName = "WithUpgradesInfo",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: clusterWithUpgradesInfo(,   first: Int,   after: String,   last: Int,   before: String,   upgradeFilter: CdmUpgradeInfoFilterInput,   sortOrder: SortOrder = DESC,   sortBy: UpgradeInfoSortByEnum = ClusterType, ):ClusterConnection!",
            Position = 0
        )]
        public SwitchParameter WithUpgradesInfo { get; set; }

        [Parameter(
            ParameterSetName = "WithUpgradesInfo",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument upgradeFilter: CdmUpgradeInfoFilterInput"
        )]
        public CdmUpgradeInfoFilterInput? UpgradeFilter { get; set; }
        
        // -------------------------------------------------------------------
        // Dns parameter set
        //
        // GraphQL operation: clusterDns(clusterUuid: UUID!):ClusterDnsReply!
        //
        [Parameter(
            ParameterSetName = "Dns",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: clusterDns(clusterUuid: UUID!):ClusterDnsReply!",
            Position = 0
        )]
        public SwitchParameter Dns { get; set; }

        
        // -------------------------------------------------------------------
        // Proxy parameter set
        //
        // GraphQL operation: clusterProxy(clusterUuid: UUID!):ClusterProxyReply!
        //
        [Parameter(
            ParameterSetName = "Proxy",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: clusterProxy(clusterUuid: UUID!):ClusterProxyReply!",
            Position = 0
        )]
        public SwitchParameter Proxy { get; set; }

        
        // -------------------------------------------------------------------
        // NtpServer parameter set
        //
        // GraphQL operation: clusterNtpServers(input: GetClusterNtpServersInput!):NtpServerConfigurationListResponse!
        //
        [Parameter(
            ParameterSetName = "NtpServer",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: clusterNtpServers(input: GetClusterNtpServersInput!):NtpServerConfigurationListResponse!",
            Position = 0
        )]
        public SwitchParameter NtpServer { get; set; }

        
        // -------------------------------------------------------------------
        // NetworkInterface parameter set
        //
        // GraphQL operation: clusterNetworkInterfaces(input: GetNetworkInterfaceInput!):NetworkInterfaceListResponse!
        //
        [Parameter(
            ParameterSetName = "NetworkInterface",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: clusterNetworkInterfaces(input: GetNetworkInterfaceInput!):NetworkInterfaceListResponse!",
            Position = 0
        )]
        public SwitchParameter NetworkInterface { get; set; }

        
        // -------------------------------------------------------------------
        // FloatingIp parameter set
        //
        // GraphQL operation: clusterFloatingIps(input: GetClusterIpsInput!):InternalGetClusterIpsResponse!
        //
        [Parameter(
            ParameterSetName = "FloatingIp",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: clusterFloatingIps(input: GetClusterIpsInput!):InternalGetClusterIpsResponse!",
            Position = 0
        )]
        public SwitchParameter FloatingIp { get; set; }

        
        // -------------------------------------------------------------------
        // Vlan parameter set
        //
        // GraphQL operation: clusterVlans(input: GetVlanInput!):VlanConfigListResponse!
        //
        [Parameter(
            ParameterSetName = "Vlan",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: clusterVlans(input: GetVlanInput!):VlanConfigListResponse!",
            Position = 0
        )]
        public SwitchParameter Vlan { get; set; }

        
        // -------------------------------------------------------------------
        // DefaultGateway parameter set
        //
        // GraphQL operation: clusterDefaultGateway(input: GetDefaultGatewayInput!):InternalGetDefaultGatewayResponse!
        //
        [Parameter(
            ParameterSetName = "DefaultGateway",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: clusterDefaultGateway(input: GetDefaultGatewayInput!):InternalGetDefaultGatewayResponse!",
            Position = 0
        )]
        public SwitchParameter DefaultGateway { get; set; }

        
        // -------------------------------------------------------------------
        // WebSignedCertificate parameter set
        //
        // GraphQL operation: clusterWebSignedCertificate(input: ClusterWebSignedCertificateInput!):ClusterWebSignedCertificateReply!
        //
        [Parameter(
            ParameterSetName = "WebSignedCertificate",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: clusterWebSignedCertificate(input: ClusterWebSignedCertificateInput!):ClusterWebSignedCertificateReply!",
            Position = 0
        )]
        public SwitchParameter WebSignedCertificate { get; set; }

        
        // -------------------------------------------------------------------
        // Ipmi parameter set
        //
        // GraphQL operation: clusterIpmi(input: GetIpmiInput!):ModifyIpmiReply!
        //
        [Parameter(
            ParameterSetName = "Ipmi",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: clusterIpmi(input: GetIpmiInput!):ModifyIpmiReply!",
            Position = 0
        )]
        public SwitchParameter Ipmi { get; set; }

        
        // -------------------------------------------------------------------
        // Certificate parameter set
        //
        // GraphQL operation: clusterCertificates(input: QueryCertificatesInput!):CertificateSummaryListResponse!
        //
        [Parameter(
            ParameterSetName = "Certificate",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: clusterCertificates(input: QueryCertificatesInput!):CertificateSummaryListResponse!",
            Position = 0
        )]
        public SwitchParameter Certificate { get; set; }

        
        // -------------------------------------------------------------------
        // WebCertsAndIpmi parameter set
        //
        // GraphQL operation: allClusterWebCertsAndIpmis(input: BulkClusterWebCertAndIpmiInput!):[ClusterWebCertAndIpmi!]!
        //
        [Parameter(
            ParameterSetName = "WebCertsAndIpmi",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allClusterWebCertsAndIpmis(input: BulkClusterWebCertAndIpmiInput!):[ClusterWebCertAndIpmi!]!",
            Position = 0
        )]
        public SwitchParameter WebCertsAndIpmi { get; set; }

        
        // -------------------------------------------------------------------
        // OperationJobProgress parameter set
        //
        // GraphQL operation: clusterOperationJobProgress(input: ClusterOperationJobProgressInput!):ClusterOperationJobProgress!
        //
        [Parameter(
            ParameterSetName = "OperationJobProgress",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: clusterOperationJobProgress(input: ClusterOperationJobProgressInput!):ClusterOperationJobProgress!",
            Position = 0
        )]
        public SwitchParameter OperationJobProgress { get; set; }

        
        // -------------------------------------------------------------------
        // Csr parameter set
        //
        // GraphQL operation: clusterCsr(input: GetClusterCsrInput!):ClusterCsr!
        //
        [Parameter(
            ParameterSetName = "Csr",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: clusterCsr(input: GetClusterCsrInput!):ClusterCsr!",
            Position = 0
        )]
        public SwitchParameter Csr { get; set; }

        
        // -------------------------------------------------------------------
        // TypeList parameter set
        //
        // GraphQL operation: clusterTypeList:[GroupCount!]!
        //
        [Parameter(
            ParameterSetName = "TypeList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: clusterTypeList:[GroupCount!]!",
            Position = 0
        )]
        public SwitchParameter TypeList { get; set; }

        
        // -------------------------------------------------------------------
        // GroupByList parameter set
        //
        // GraphQL operation: clusterGroupByConnection(,   first: Int,   after: String,   last: Int,   before: String,   groupBy: ClusterGroupByEnum!,   filter: ClusterFilterInput,   timezoneOffset: Float = 0.0, ):ClusterGroupByConnection!
        //
        [Parameter(
            ParameterSetName = "GroupByList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: clusterGroupByConnection(,   first: Int,   after: String,   last: Int,   before: String,   groupBy: ClusterGroupByEnum!,   filter: ClusterFilterInput,   timezoneOffset: Float = 0.0, ):ClusterGroupByConnection!",
            Position = 0
        )]
        public SwitchParameter GroupByList { get; set; }

        [Parameter(
            ParameterSetName = "GroupByList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument groupBy: ClusterGroupByEnum!"
        )]
        public ClusterGroupByEnum? GroupBy { get; set; }
        [Parameter(
            ParameterSetName = "GroupByList",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument timezoneOffset: Float"
        )]
        public System.Single? TimezoneOffset { get; set; }
        
        // -------------------------------------------------------------------
        // Connected parameter set
        //
        // GraphQL operation: allConnectedClusters(clusterFilterArg: ClusterTypeEnum):[DataLocationSupportedCluster!]!
        //
        [Parameter(
            ParameterSetName = "Connected",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allConnectedClusters(clusterFilterArg: ClusterTypeEnum):[DataLocationSupportedCluster!]!",
            Position = 0
        )]
        public SwitchParameter Connected { get; set; }

        [Parameter(
            ParameterSetName = "Connected",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument clusterFilterArg: ClusterTypeEnum"
        )]
        public ClusterTypeEnum? ClusterFilterArg { get; set; }
        
        // -------------------------------------------------------------------
        // ReplicationTarget parameter set
        //
        // GraphQL operation: allClusterReplicationTargets(clusterUuid: UUID!):[ClusterReplicationTarget!]!
        //
        [Parameter(
            ParameterSetName = "ReplicationTarget",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allClusterReplicationTargets(clusterUuid: UUID!):[ClusterReplicationTarget!]!",
            Position = 0
        )]
        public SwitchParameter ReplicationTarget { get; set; }

        
        // -------------------------------------------------------------------
        // HostFailover parameter set
        //
        // GraphQL operation: hostFailoverCluster(fid: UUID!):HostFailoverCluster!
        //
        [Parameter(
            ParameterSetName = "HostFailover",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: hostFailoverCluster(fid: UUID!):HostFailoverCluster!",
            Position = 0
        )]
        public SwitchParameter HostFailover { get; set; }

        [Parameter(
            ParameterSetName = "HostFailover",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument fid: UUID!"
        )]
        public System.String? Fid { get; set; }
        
        // -------------------------------------------------------------------
        // K8s parameter set
        //
        // GraphQL operation: k8sClusters(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!], ):K8sClusterConnection!
        //
        [Parameter(
            ParameterSetName = "K8s",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: k8sClusters(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!], ):K8sClusterConnection!",
            Position = 0
        )]
        public SwitchParameter K8s { get; set; }

        
        // -------------------------------------------------------------------
        // Window parameter set
        //
        // GraphQL operation: windowsCluster(fid: UUID!):WindowsCluster!
        //
        [Parameter(
            ParameterSetName = "Window",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: windowsCluster(fid: UUID!):WindowsCluster!",
            Position = 0
        )]
        public SwitchParameter Window { get; set; }

        
        // -------------------------------------------------------------------
        // GlobalSla parameter set
        //
        // GraphQL operation: allClusterGlobalSlas(cdmClusterUUID: UUID!):[SlaInfo!]!
        //
        [Parameter(
            ParameterSetName = "GlobalSla",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allClusterGlobalSlas(cdmClusterUUID: UUID!):[SlaInfo!]!",
            Position = 0
        )]
        public SwitchParameter GlobalSla { get; set; }

        [Parameter(
            ParameterSetName = "GlobalSla",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument cdmClusterUUID: UUID!"
        )]
        public System.String? CdmClusterUuid { get; set; }
        
        // -------------------------------------------------------------------
        // RegistrationProductInfo parameter set
        //
        // GraphQL operation: clusterRegistrationProductInfo:ClusterRegistrationProductInfoType!
        //
        [Parameter(
            ParameterSetName = "RegistrationProductInfo",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: clusterRegistrationProductInfo:ClusterRegistrationProductInfoType!",
            Position = 0
        )]
        public SwitchParameter RegistrationProductInfo { get; set; }

        
        // -------------------------------------------------------------------
        // isTotpAckNecessary parameter set
        //
        // GraphQL operation: isTotpAckNecessaryForCluster(clusterUuid: UUID!):Boolean!
        //
        [Parameter(
            ParameterSetName = "isTotpAckNecessary",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: isTotpAckNecessaryForCluster(clusterUuid: UUID!):Boolean!",
            Position = 0
        )]
        public SwitchParameter isTotpAckNecessary { get; set; }

        
        // -------------------------------------------------------------------
        // TotpAckStatus parameter set
        //
        // GraphQL operation: allClustersTotpAckStatus(listClusterUuid: [UUID!]!):[Boolean!]!
        //
        [Parameter(
            ParameterSetName = "TotpAckStatus",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: allClustersTotpAckStatus(listClusterUuid: [UUID!]!):[Boolean!]!",
            Position = 0
        )]
        public SwitchParameter TotpAckStatus { get; set; }

        [Parameter(
            ParameterSetName = "TotpAckStatus",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument listClusterUuid: [UUID!]!"
        )]
        public List<System.String>? ListClusterUuid { get; set; }

        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "Node":
                        this.ProcessRecord_Node();
                        break;
                    case "List":
                        this.ProcessRecord_List();
                        break;
                    case "Cluster":
                        this.ProcessRecord_Cluster();
                        break;
                    case "WithUpgradesInfo":
                        this.ProcessRecord_WithUpgradesInfo();
                        break;
                    case "Dns":
                        this.ProcessRecord_Dns();
                        break;
                    case "Proxy":
                        this.ProcessRecord_Proxy();
                        break;
                    case "NtpServer":
                        this.ProcessRecord_NtpServer();
                        break;
                    case "NetworkInterface":
                        this.ProcessRecord_NetworkInterface();
                        break;
                    case "FloatingIp":
                        this.ProcessRecord_FloatingIp();
                        break;
                    case "Vlan":
                        this.ProcessRecord_Vlan();
                        break;
                    case "DefaultGateway":
                        this.ProcessRecord_DefaultGateway();
                        break;
                    case "WebSignedCertificate":
                        this.ProcessRecord_WebSignedCertificate();
                        break;
                    case "Ipmi":
                        this.ProcessRecord_Ipmi();
                        break;
                    case "Certificate":
                        this.ProcessRecord_Certificate();
                        break;
                    case "WebCertsAndIpmi":
                        this.ProcessRecord_WebCertsAndIpmi();
                        break;
                    case "OperationJobProgress":
                        this.ProcessRecord_OperationJobProgress();
                        break;
                    case "Csr":
                        this.ProcessRecord_Csr();
                        break;
                    case "TypeList":
                        this.ProcessRecord_TypeList();
                        break;
                    case "GroupByList":
                        this.ProcessRecord_GroupByList();
                        break;
                    case "Connected":
                        this.ProcessRecord_Connected();
                        break;
                    case "ReplicationTarget":
                        this.ProcessRecord_ReplicationTarget();
                        break;
                    case "HostFailover":
                        this.ProcessRecord_HostFailover();
                        break;
                    case "K8s":
                        this.ProcessRecord_K8s();
                        break;
                    case "Window":
                        this.ProcessRecord_Window();
                        break;
                    case "GlobalSla":
                        this.ProcessRecord_GlobalSla();
                        break;
                    case "RegistrationProductInfo":
                        this.ProcessRecord_RegistrationProductInfo();
                        break;
                    case "isTotpAckNecessary":
                        this.ProcessRecord_isTotpAckNecessary();
                        break;
                    case "TotpAckStatus":
                        this.ProcessRecord_TotpAckStatus();
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
                    "Invoke-RscQueryCluster",
                    ErrorCategory.InvalidOperation,
                    null);
                ThrowTerminatingError(error);
           }
        }

        // This parameter set invokes a single graphql operation:
        // clusterNodes.
        protected void ProcessRecord_Node()
        {
            this._logger.name += " -Node";
            // Invoke graphql operation clusterNodes
            InvokeQueryClusterNodes();
        }

        // This parameter set invokes a single graphql operation:
        // clusterConnection.
        protected void ProcessRecord_List()
        {
            this._logger.name += " -List";
            // Invoke graphql operation clusterConnection
            InvokeQueryClusterConnection();
        }

        // This parameter set invokes a single graphql operation:
        // cluster.
        protected void ProcessRecord_Cluster()
        {
            this._logger.name += " -Cluster";
            // Invoke graphql operation cluster
            InvokeQueryCluster();
        }

        // This parameter set invokes a single graphql operation:
        // clusterWithUpgradesInfo.
        protected void ProcessRecord_WithUpgradesInfo()
        {
            this._logger.name += " -WithUpgradesInfo";
            // Invoke graphql operation clusterWithUpgradesInfo
            InvokeQueryClusterWithUpgradesInfo();
        }

        // This parameter set invokes a single graphql operation:
        // clusterDns.
        protected void ProcessRecord_Dns()
        {
            this._logger.name += " -Dns";
            // Invoke graphql operation clusterDns
            InvokeQueryClusterDns();
        }

        // This parameter set invokes a single graphql operation:
        // clusterProxy.
        protected void ProcessRecord_Proxy()
        {
            this._logger.name += " -Proxy";
            // Invoke graphql operation clusterProxy
            InvokeQueryClusterProxy();
        }

        // This parameter set invokes a single graphql operation:
        // clusterNtpServers.
        protected void ProcessRecord_NtpServer()
        {
            this._logger.name += " -NtpServer";
            // Invoke graphql operation clusterNtpServers
            InvokeQueryClusterNtpServers();
        }

        // This parameter set invokes a single graphql operation:
        // clusterNetworkInterfaces.
        protected void ProcessRecord_NetworkInterface()
        {
            this._logger.name += " -NetworkInterface";
            // Invoke graphql operation clusterNetworkInterfaces
            InvokeQueryClusterNetworkInterfaces();
        }

        // This parameter set invokes a single graphql operation:
        // clusterFloatingIps.
        protected void ProcessRecord_FloatingIp()
        {
            this._logger.name += " -FloatingIp";
            // Invoke graphql operation clusterFloatingIps
            InvokeQueryClusterFloatingIps();
        }

        // This parameter set invokes a single graphql operation:
        // clusterVlans.
        protected void ProcessRecord_Vlan()
        {
            this._logger.name += " -Vlan";
            // Invoke graphql operation clusterVlans
            InvokeQueryClusterVlans();
        }

        // This parameter set invokes a single graphql operation:
        // clusterDefaultGateway.
        protected void ProcessRecord_DefaultGateway()
        {
            this._logger.name += " -DefaultGateway";
            // Invoke graphql operation clusterDefaultGateway
            InvokeQueryClusterDefaultGateway();
        }

        // This parameter set invokes a single graphql operation:
        // clusterWebSignedCertificate.
        protected void ProcessRecord_WebSignedCertificate()
        {
            this._logger.name += " -WebSignedCertificate";
            // Invoke graphql operation clusterWebSignedCertificate
            InvokeQueryClusterWebSignedCertificate();
        }

        // This parameter set invokes a single graphql operation:
        // clusterIpmi.
        protected void ProcessRecord_Ipmi()
        {
            this._logger.name += " -Ipmi";
            // Invoke graphql operation clusterIpmi
            InvokeQueryClusterIpmi();
        }

        // This parameter set invokes a single graphql operation:
        // clusterCertificates.
        protected void ProcessRecord_Certificate()
        {
            this._logger.name += " -Certificate";
            // Invoke graphql operation clusterCertificates
            InvokeQueryClusterCertificates();
        }

        // This parameter set invokes a single graphql operation:
        // allClusterWebCertsAndIpmis.
        protected void ProcessRecord_WebCertsAndIpmi()
        {
            this._logger.name += " -WebCertsAndIpmi";
            // Invoke graphql operation allClusterWebCertsAndIpmis
            InvokeQueryAllClusterWebCertsAndIpmis();
        }

        // This parameter set invokes a single graphql operation:
        // clusterOperationJobProgress.
        protected void ProcessRecord_OperationJobProgress()
        {
            this._logger.name += " -OperationJobProgress";
            // Invoke graphql operation clusterOperationJobProgress
            InvokeQueryClusterOperationJobProgress();
        }

        // This parameter set invokes a single graphql operation:
        // clusterCsr.
        protected void ProcessRecord_Csr()
        {
            this._logger.name += " -Csr";
            // Invoke graphql operation clusterCsr
            InvokeQueryClusterCsr();
        }

        // This parameter set invokes a single graphql operation:
        // clusterTypeList.
        protected void ProcessRecord_TypeList()
        {
            this._logger.name += " -TypeList";
            // Invoke graphql operation clusterTypeList
            InvokeQueryClusterTypeList();
        }

        // This parameter set invokes a single graphql operation:
        // clusterGroupByConnection.
        protected void ProcessRecord_GroupByList()
        {
            this._logger.name += " -GroupByList";
            // Invoke graphql operation clusterGroupByConnection
            InvokeQueryClusterGroupByConnection();
        }

        // This parameter set invokes a single graphql operation:
        // allConnectedClusters.
        protected void ProcessRecord_Connected()
        {
            this._logger.name += " -Connected";
            // Invoke graphql operation allConnectedClusters
            InvokeQueryAllConnectedClusters();
        }

        // This parameter set invokes a single graphql operation:
        // allClusterReplicationTargets.
        protected void ProcessRecord_ReplicationTarget()
        {
            this._logger.name += " -ReplicationTarget";
            // Invoke graphql operation allClusterReplicationTargets
            InvokeQueryAllClusterReplicationTargets();
        }

        // This parameter set invokes a single graphql operation:
        // hostFailoverCluster.
        protected void ProcessRecord_HostFailover()
        {
            this._logger.name += " -HostFailover";
            // Invoke graphql operation hostFailoverCluster
            InvokeQueryHostFailoverCluster();
        }

        // This parameter set invokes a single graphql operation:
        // k8sClusters.
        protected void ProcessRecord_K8s()
        {
            this._logger.name += " -K8s";
            // Invoke graphql operation k8sClusters
            InvokeQueryK8sClusters();
        }

        // This parameter set invokes a single graphql operation:
        // windowsCluster.
        protected void ProcessRecord_Window()
        {
            this._logger.name += " -Window";
            // Invoke graphql operation windowsCluster
            InvokeQueryWindowsCluster();
        }

        // This parameter set invokes a single graphql operation:
        // allClusterGlobalSlas.
        protected void ProcessRecord_GlobalSla()
        {
            this._logger.name += " -GlobalSla";
            // Invoke graphql operation allClusterGlobalSlas
            InvokeQueryAllClusterGlobalSlas();
        }

        // This parameter set invokes a single graphql operation:
        // clusterRegistrationProductInfo.
        protected void ProcessRecord_RegistrationProductInfo()
        {
            this._logger.name += " -RegistrationProductInfo";
            // Invoke graphql operation clusterRegistrationProductInfo
            InvokeQueryClusterRegistrationProductInfo();
        }

        // This parameter set invokes a single graphql operation:
        // isTotpAckNecessaryForCluster.
        protected void ProcessRecord_isTotpAckNecessary()
        {
            this._logger.name += " -isTotpAckNecessary";
            // Invoke graphql operation isTotpAckNecessaryForCluster
            InvokeQueryIsTotpAckNecessaryForCluster();
        }

        // This parameter set invokes a single graphql operation:
        // allClustersTotpAckStatus.
        protected void ProcessRecord_TotpAckStatus()
        {
            this._logger.name += " -TotpAckStatus";
            // Invoke graphql operation allClustersTotpAckStatus
            InvokeQueryAllClustersTotpAckStatus();
        }


        // Invoke GraphQL Query:
        // clusterNodes(input: GetNodesInput!): NodeStatusListResponse!
        protected void InvokeQueryClusterNodes()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetNodesInput!"),
            };
            NodeStatusListResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (NodeStatusListResponse)psObject.BaseObject;
                } else {
                    fields = (NodeStatusListResponse)this.Field;
                }
            }
            string document = Query.ClusterNodes(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ClusterNodes");
            string parameters = "($input: GetNodesInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryClusterNodes" + parameters + "{" + document + "}",
                OperationName = "QueryClusterNodes",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<NodeStatusListResponse> task = this._rbkClient.InvokeGenericCallAsync<NodeStatusListResponse>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // clusterConnection(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     filter: ClusterFilterInput
        //     sortOrder: SortOrder = DESC
        //     sortBy: ClusterSortByEnum = ClusterType
        //   ): ClusterConnection!
        protected void InvokeQueryClusterConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("filter", "ClusterFilterInput"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("sortBy", "ClusterSortByEnum"),
            };
            ClusterConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (ClusterConnection)psObject.BaseObject;
                } else {
                    fields = (ClusterConnection)this.Field;
                }
            }
            string document = Query.ClusterConnection(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ClusterConnection");
            string parameters = "($first: Int,$after: String,$last: Int,$before: String,$filter: ClusterFilterInput,$sortOrder: SortOrder,$sortBy: ClusterSortByEnum)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryClusterConnection" + parameters + "{" + document + "}",
                OperationName = "QueryClusterConnection",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<ClusterConnection> task = this._rbkClient.InvokeGenericCallAsync<ClusterConnection>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // cluster(clusterUuid: UUID!): Cluster!
        protected void InvokeQueryCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
            };
            Cluster? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (Cluster)psObject.BaseObject;
                } else {
                    fields = (Cluster)this.Field;
                }
            }
            string document = Query.Cluster(ref fields);
            this._input.Initialize(argDefs, fields, "Query.Cluster");
            string parameters = "($clusterUuid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryCluster" + parameters + "{" + document + "}",
                OperationName = "QueryCluster",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<Cluster> task = this._rbkClient.InvokeGenericCallAsync<Cluster>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // clusterWithUpgradesInfo(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     upgradeFilter: CdmUpgradeInfoFilterInput
        //     sortOrder: SortOrder = DESC
        //     sortBy: UpgradeInfoSortByEnum = ClusterType
        //   ): ClusterConnection!
        protected void InvokeQueryClusterWithUpgradesInfo()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("upgradeFilter", "CdmUpgradeInfoFilterInput"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("sortBy", "UpgradeInfoSortByEnum"),
            };
            ClusterConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (ClusterConnection)psObject.BaseObject;
                } else {
                    fields = (ClusterConnection)this.Field;
                }
            }
            string document = Query.ClusterWithUpgradesInfo(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ClusterWithUpgradesInfo");
            string parameters = "($first: Int,$after: String,$last: Int,$before: String,$upgradeFilter: CdmUpgradeInfoFilterInput,$sortOrder: SortOrder,$sortBy: UpgradeInfoSortByEnum)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryClusterWithUpgradesInfo" + parameters + "{" + document + "}",
                OperationName = "QueryClusterWithUpgradesInfo",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<ClusterConnection> task = this._rbkClient.InvokeGenericCallAsync<ClusterConnection>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // clusterDns(clusterUuid: UUID!): ClusterDnsReply!
        protected void InvokeQueryClusterDns()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
            };
            ClusterDnsReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (ClusterDnsReply)psObject.BaseObject;
                } else {
                    fields = (ClusterDnsReply)this.Field;
                }
            }
            string document = Query.ClusterDns(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ClusterDns");
            string parameters = "($clusterUuid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryClusterDns" + parameters + "{" + document + "}",
                OperationName = "QueryClusterDns",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<ClusterDnsReply> task = this._rbkClient.InvokeGenericCallAsync<ClusterDnsReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // clusterProxy(clusterUuid: UUID!): ClusterProxyReply!
        protected void InvokeQueryClusterProxy()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
            };
            ClusterProxyReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (ClusterProxyReply)psObject.BaseObject;
                } else {
                    fields = (ClusterProxyReply)this.Field;
                }
            }
            string document = Query.ClusterProxy(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ClusterProxy");
            string parameters = "($clusterUuid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryClusterProxy" + parameters + "{" + document + "}",
                OperationName = "QueryClusterProxy",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<ClusterProxyReply> task = this._rbkClient.InvokeGenericCallAsync<ClusterProxyReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // clusterNtpServers(input: GetClusterNtpServersInput!): NtpServerConfigurationListResponse!
        protected void InvokeQueryClusterNtpServers()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetClusterNtpServersInput!"),
            };
            NtpServerConfigurationListResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (NtpServerConfigurationListResponse)psObject.BaseObject;
                } else {
                    fields = (NtpServerConfigurationListResponse)this.Field;
                }
            }
            string document = Query.ClusterNtpServers(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ClusterNtpServers");
            string parameters = "($input: GetClusterNtpServersInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryClusterNtpServers" + parameters + "{" + document + "}",
                OperationName = "QueryClusterNtpServers",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<NtpServerConfigurationListResponse> task = this._rbkClient.InvokeGenericCallAsync<NtpServerConfigurationListResponse>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // clusterNetworkInterfaces(input: GetNetworkInterfaceInput!): NetworkInterfaceListResponse!
        protected void InvokeQueryClusterNetworkInterfaces()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetNetworkInterfaceInput!"),
            };
            NetworkInterfaceListResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (NetworkInterfaceListResponse)psObject.BaseObject;
                } else {
                    fields = (NetworkInterfaceListResponse)this.Field;
                }
            }
            string document = Query.ClusterNetworkInterfaces(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ClusterNetworkInterfaces");
            string parameters = "($input: GetNetworkInterfaceInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryClusterNetworkInterfaces" + parameters + "{" + document + "}",
                OperationName = "QueryClusterNetworkInterfaces",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<NetworkInterfaceListResponse> task = this._rbkClient.InvokeGenericCallAsync<NetworkInterfaceListResponse>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // clusterFloatingIps(input: GetClusterIpsInput!): InternalGetClusterIpsResponse!
        protected void InvokeQueryClusterFloatingIps()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetClusterIpsInput!"),
            };
            InternalGetClusterIpsResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (InternalGetClusterIpsResponse)psObject.BaseObject;
                } else {
                    fields = (InternalGetClusterIpsResponse)this.Field;
                }
            }
            string document = Query.ClusterFloatingIps(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ClusterFloatingIps");
            string parameters = "($input: GetClusterIpsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryClusterFloatingIps" + parameters + "{" + document + "}",
                OperationName = "QueryClusterFloatingIps",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<InternalGetClusterIpsResponse> task = this._rbkClient.InvokeGenericCallAsync<InternalGetClusterIpsResponse>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // clusterVlans(input: GetVlanInput!): VlanConfigListResponse!
        protected void InvokeQueryClusterVlans()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetVlanInput!"),
            };
            VlanConfigListResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (VlanConfigListResponse)psObject.BaseObject;
                } else {
                    fields = (VlanConfigListResponse)this.Field;
                }
            }
            string document = Query.ClusterVlans(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ClusterVlans");
            string parameters = "($input: GetVlanInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryClusterVlans" + parameters + "{" + document + "}",
                OperationName = "QueryClusterVlans",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<VlanConfigListResponse> task = this._rbkClient.InvokeGenericCallAsync<VlanConfigListResponse>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // clusterDefaultGateway(input: GetDefaultGatewayInput!): InternalGetDefaultGatewayResponse!
        protected void InvokeQueryClusterDefaultGateway()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetDefaultGatewayInput!"),
            };
            InternalGetDefaultGatewayResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (InternalGetDefaultGatewayResponse)psObject.BaseObject;
                } else {
                    fields = (InternalGetDefaultGatewayResponse)this.Field;
                }
            }
            string document = Query.ClusterDefaultGateway(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ClusterDefaultGateway");
            string parameters = "($input: GetDefaultGatewayInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryClusterDefaultGateway" + parameters + "{" + document + "}",
                OperationName = "QueryClusterDefaultGateway",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<InternalGetDefaultGatewayResponse> task = this._rbkClient.InvokeGenericCallAsync<InternalGetDefaultGatewayResponse>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // clusterWebSignedCertificate(input: ClusterWebSignedCertificateInput!): ClusterWebSignedCertificateReply!
        protected void InvokeQueryClusterWebSignedCertificate()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ClusterWebSignedCertificateInput!"),
            };
            ClusterWebSignedCertificateReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (ClusterWebSignedCertificateReply)psObject.BaseObject;
                } else {
                    fields = (ClusterWebSignedCertificateReply)this.Field;
                }
            }
            string document = Query.ClusterWebSignedCertificate(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ClusterWebSignedCertificate");
            string parameters = "($input: ClusterWebSignedCertificateInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryClusterWebSignedCertificate" + parameters + "{" + document + "}",
                OperationName = "QueryClusterWebSignedCertificate",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<ClusterWebSignedCertificateReply> task = this._rbkClient.InvokeGenericCallAsync<ClusterWebSignedCertificateReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // clusterIpmi(input: GetIpmiInput!): ModifyIpmiReply!
        protected void InvokeQueryClusterIpmi()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetIpmiInput!"),
            };
            ModifyIpmiReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (ModifyIpmiReply)psObject.BaseObject;
                } else {
                    fields = (ModifyIpmiReply)this.Field;
                }
            }
            string document = Query.ClusterIpmi(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ClusterIpmi");
            string parameters = "($input: GetIpmiInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryClusterIpmi" + parameters + "{" + document + "}",
                OperationName = "QueryClusterIpmi",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<ModifyIpmiReply> task = this._rbkClient.InvokeGenericCallAsync<ModifyIpmiReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // clusterCertificates(input: QueryCertificatesInput!): CertificateSummaryListResponse!
        protected void InvokeQueryClusterCertificates()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "QueryCertificatesInput!"),
            };
            CertificateSummaryListResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (CertificateSummaryListResponse)psObject.BaseObject;
                } else {
                    fields = (CertificateSummaryListResponse)this.Field;
                }
            }
            string document = Query.ClusterCertificates(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ClusterCertificates");
            string parameters = "($input: QueryCertificatesInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryClusterCertificates" + parameters + "{" + document + "}",
                OperationName = "QueryClusterCertificates",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<CertificateSummaryListResponse> task = this._rbkClient.InvokeGenericCallAsync<CertificateSummaryListResponse>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // allClusterWebCertsAndIpmis(input: BulkClusterWebCertAndIpmiInput!): [ClusterWebCertAndIpmi!]!
        protected void InvokeQueryAllClusterWebCertsAndIpmis()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "BulkClusterWebCertAndIpmiInput!"),
            };
            List<ClusterWebCertAndIpmi>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<ClusterWebCertAndIpmi>)psObject.BaseObject;
                } else {
                    fields = (List<ClusterWebCertAndIpmi>)this.Field;
                }
            }
            string document = Query.AllClusterWebCertsAndIpmis(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllClusterWebCertsAndIpmis");
            string parameters = "($input: BulkClusterWebCertAndIpmiInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllClusterWebCertsAndIpmis" + parameters + "{" + document + "}",
                OperationName = "QueryAllClusterWebCertsAndIpmis",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<ClusterWebCertAndIpmi>> task = this._rbkClient.InvokeGenericCallAsync<List<ClusterWebCertAndIpmi>>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // clusterOperationJobProgress(input: ClusterOperationJobProgressInput!): ClusterOperationJobProgress!
        protected void InvokeQueryClusterOperationJobProgress()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ClusterOperationJobProgressInput!"),
            };
            ClusterOperationJobProgress? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (ClusterOperationJobProgress)psObject.BaseObject;
                } else {
                    fields = (ClusterOperationJobProgress)this.Field;
                }
            }
            string document = Query.ClusterOperationJobProgress(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ClusterOperationJobProgress");
            string parameters = "($input: ClusterOperationJobProgressInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryClusterOperationJobProgress" + parameters + "{" + document + "}",
                OperationName = "QueryClusterOperationJobProgress",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<ClusterOperationJobProgress> task = this._rbkClient.InvokeGenericCallAsync<ClusterOperationJobProgress>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // clusterCsr(input: GetClusterCsrInput!): ClusterCsr!
        protected void InvokeQueryClusterCsr()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetClusterCsrInput!"),
            };
            ClusterCsr? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (ClusterCsr)psObject.BaseObject;
                } else {
                    fields = (ClusterCsr)this.Field;
                }
            }
            string document = Query.ClusterCsr(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ClusterCsr");
            string parameters = "($input: GetClusterCsrInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryClusterCsr" + parameters + "{" + document + "}",
                OperationName = "QueryClusterCsr",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<ClusterCsr> task = this._rbkClient.InvokeGenericCallAsync<ClusterCsr>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // clusterTypeList: [GroupCount!]!
        protected void InvokeQueryClusterTypeList()
        {
            Tuple<string, string>[] argDefs = {
            };
            List<GroupCount>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<GroupCount>)psObject.BaseObject;
                } else {
                    fields = (List<GroupCount>)this.Field;
                }
            }
            string document = Query.ClusterTypeList(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ClusterTypeList");
            string parameters = "";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryClusterTypeList" + parameters + "{" + document + "}",
                OperationName = "QueryClusterTypeList",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            Task<List<GroupCount>> task = this._rbkClient.InvokeGenericCallAsync<List<GroupCount>>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // clusterGroupByConnection(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     groupBy: ClusterGroupByEnum!
        //     filter: ClusterFilterInput
        //     timezoneOffset: Float = 0.0
        //   ): ClusterGroupByConnection!
        protected void InvokeQueryClusterGroupByConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("groupBy", "ClusterGroupByEnum!"),
                Tuple.Create("filter", "ClusterFilterInput"),
                Tuple.Create("timezoneOffset", "Float"),
            };
            ClusterGroupByConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (ClusterGroupByConnection)psObject.BaseObject;
                } else {
                    fields = (ClusterGroupByConnection)this.Field;
                }
            }
            string document = Query.ClusterGroupByConnection(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ClusterGroupByConnection");
            string parameters = "($first: Int,$after: String,$last: Int,$before: String,$groupBy: ClusterGroupByEnum!,$filter: ClusterFilterInput,$timezoneOffset: Float)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryClusterGroupByConnection" + parameters + "{" + document + "}",
                OperationName = "QueryClusterGroupByConnection",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<ClusterGroupByConnection> task = this._rbkClient.InvokeGenericCallAsync<ClusterGroupByConnection>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // allConnectedClusters(clusterFilterArg: ClusterTypeEnum): [DataLocationSupportedCluster!]!
        protected void InvokeQueryAllConnectedClusters()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterFilterArg", "ClusterTypeEnum"),
            };
            List<DataLocationSupportedCluster>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<DataLocationSupportedCluster>)psObject.BaseObject;
                } else {
                    fields = (List<DataLocationSupportedCluster>)this.Field;
                }
            }
            string document = Query.AllConnectedClusters(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllConnectedClusters");
            string parameters = "($clusterFilterArg: ClusterTypeEnum)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllConnectedClusters" + parameters + "{" + document + "}",
                OperationName = "QueryAllConnectedClusters",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<DataLocationSupportedCluster>> task = this._rbkClient.InvokeGenericCallAsync<List<DataLocationSupportedCluster>>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // allClusterReplicationTargets(clusterUuid: UUID!): [ClusterReplicationTarget!]!
        protected void InvokeQueryAllClusterReplicationTargets()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
            };
            List<ClusterReplicationTarget>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<ClusterReplicationTarget>)psObject.BaseObject;
                } else {
                    fields = (List<ClusterReplicationTarget>)this.Field;
                }
            }
            string document = Query.AllClusterReplicationTargets(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllClusterReplicationTargets");
            string parameters = "($clusterUuid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllClusterReplicationTargets" + parameters + "{" + document + "}",
                OperationName = "QueryAllClusterReplicationTargets",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<ClusterReplicationTarget>> task = this._rbkClient.InvokeGenericCallAsync<List<ClusterReplicationTarget>>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // hostFailoverCluster(fid: UUID!): HostFailoverCluster!
        protected void InvokeQueryHostFailoverCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            HostFailoverCluster? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (HostFailoverCluster)psObject.BaseObject;
                } else {
                    fields = (HostFailoverCluster)this.Field;
                }
            }
            string document = Query.HostFailoverCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Query.HostFailoverCluster");
            string parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryHostFailoverCluster" + parameters + "{" + document + "}",
                OperationName = "QueryHostFailoverCluster",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<HostFailoverCluster> task = this._rbkClient.InvokeGenericCallAsync<HostFailoverCluster>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // k8sClusters(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): K8sClusterConnection!
        protected void InvokeQueryK8sClusters()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            K8sClusterConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (K8sClusterConnection)psObject.BaseObject;
                } else {
                    fields = (K8sClusterConnection)this.Field;
                }
            }
            string document = Query.K8sClusters(ref fields);
            this._input.Initialize(argDefs, fields, "Query.K8sClusters");
            string parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryK8sClusters" + parameters + "{" + document + "}",
                OperationName = "QueryK8sClusters",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<K8sClusterConnection> task = this._rbkClient.InvokeGenericCallAsync<K8sClusterConnection>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // windowsCluster(fid: UUID!): WindowsCluster!
        protected void InvokeQueryWindowsCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            WindowsCluster? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (WindowsCluster)psObject.BaseObject;
                } else {
                    fields = (WindowsCluster)this.Field;
                }
            }
            string document = Query.WindowsCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Query.WindowsCluster");
            string parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryWindowsCluster" + parameters + "{" + document + "}",
                OperationName = "QueryWindowsCluster",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<WindowsCluster> task = this._rbkClient.InvokeGenericCallAsync<WindowsCluster>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // allClusterGlobalSlas(cdmClusterUUID: UUID!): [SlaInfo!]!
        protected void InvokeQueryAllClusterGlobalSlas()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cdmClusterUUID", "UUID!"),
            };
            List<SlaInfo>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<SlaInfo>)psObject.BaseObject;
                } else {
                    fields = (List<SlaInfo>)this.Field;
                }
            }
            string document = Query.AllClusterGlobalSlas(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllClusterGlobalSlas");
            string parameters = "($cdmClusterUUID: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllClusterGlobalSlas" + parameters + "{" + document + "}",
                OperationName = "QueryAllClusterGlobalSlas",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<SlaInfo>> task = this._rbkClient.InvokeGenericCallAsync<List<SlaInfo>>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // clusterRegistrationProductInfo: ClusterRegistrationProductInfoType!
        protected void InvokeQueryClusterRegistrationProductInfo()
        {
            Tuple<string, string>[] argDefs = {
            };
            ClusterRegistrationProductInfoType? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (ClusterRegistrationProductInfoType)psObject.BaseObject;
                } else {
                    fields = (ClusterRegistrationProductInfoType)this.Field;
                }
            }
            string document = Query.ClusterRegistrationProductInfo(ref fields);
            this._input.Initialize(argDefs, fields, "Query.ClusterRegistrationProductInfo");
            string parameters = "";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryClusterRegistrationProductInfo" + parameters + "{" + document + "}",
                OperationName = "QueryClusterRegistrationProductInfo",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            Task<ClusterRegistrationProductInfoType> task = this._rbkClient.InvokeGenericCallAsync<ClusterRegistrationProductInfoType>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // isTotpAckNecessaryForCluster(clusterUuid: UUID!): Boolean!
        protected void InvokeQueryIsTotpAckNecessaryForCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
            };
            System.Boolean? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (System.Boolean)psObject.BaseObject;
                } else {
                    fields = (System.Boolean)this.Field;
                }
            }
            string document = Query.IsTotpAckNecessaryForCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Query.IsTotpAckNecessaryForCluster");
            string parameters = "($clusterUuid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryIsTotpAckNecessaryForCluster" + parameters + "{" + document + "}",
                OperationName = "QueryIsTotpAckNecessaryForCluster",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<System.Boolean> task = this._rbkClient.InvokeGenericCallAsync<System.Boolean>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // allClustersTotpAckStatus(listClusterUuid: [UUID!]!): [Boolean!]!
        protected void InvokeQueryAllClustersTotpAckStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("listClusterUuid", "[UUID!]!"),
            };
            List<System.Boolean>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<System.Boolean>)psObject.BaseObject;
                } else {
                    fields = (List<System.Boolean>)this.Field;
                }
            }
            string document = Query.AllClustersTotpAckStatus(ref fields);
            this._input.Initialize(argDefs, fields, "Query.AllClustersTotpAckStatus");
            string parameters = "($listClusterUuid: [UUID!]!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryAllClustersTotpAckStatus" + parameters + "{" + document + "}",
                OperationName = "QueryAllClustersTotpAckStatus",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<System.Boolean>> task = this._rbkClient.InvokeGenericCallAsync<List<System.Boolean>>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }


    } // class Invoke_RscQueryCluster
}