### HypervScvmmSummary
Supported in v5.0+

- id: System.String
  - Required. Supported in v5.0+
  The ID of the Hyper-V SCVMM.
- primaryClusterId: System.String
  - Required. Supported in v5.0+
- runAsAccount: System.String
  - Required. Supported in v5.0+
  The RunAs account which will be used to install connector on hosts.
- scvmmVersion: System.String
  - Version of SCVMM.
- shouldDeployAgent: System.Boolean
  - Required. Supported in v5.0+
  Flag to specify if Rubrik can deploy connector to hosts. If true, Rubrik tries to deploy connector to the hyperv hosts. If false, Rubrik deployment of connector will be handled by the client.
- slaAssignable: SlaAssignable
  - 
- status: System.String
  - Required. Supported in v5.0+
  Connection status of the SCVMM server.