### VmwareHostSummary
Supported in v5.0+

- computeClusterId: System.String
  - Supported in v5.0+
- datacenterId: System.String
  - Supported in v5.0+
- datastores: a list of DataStoreSummarys
  - Supported in v5.0+
- effectiveSlaDomainId: System.String
  - Supported in v5.0
- effectiveSlaDomainName: System.String
  - Supported in v5.0
- effectiveSlaDomainPolarisManagedId: System.String
  - Supported in v5.0
  Optional field containing Polaris managed id of the effective SLA domain if it is Polaris managed.
- effectiveSlaHolder: EffectiveSlaHolder
  - 
- effectiveSlaSourceObjectId: System.String
  - Supported in v5.0
  ID of the object from which the effective SLA domain is inherited
- effectiveSlaSourceObjectName: System.String
  - Supported in v5.0
  Name of the object from which the effective SLA domain is inherited
- esxiVersion: System.String
  - Supported in v5.1+
  API Version of the ESXi Host.
- ioFilterStatus: HostFilterStatus
  - 
- ioFilterUiStatus: HostUiFilterStatus
  - 
- isInVmc: System.Boolean
  - Supported in v5.3+
- slaAssignable: SlaAssignable
  - 