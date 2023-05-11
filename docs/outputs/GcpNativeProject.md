### GcpNativeProject
Represents a GCP project.

- allOrgs: a list of Orgs
  - The organizations to which this hierarchy object belongs.
- authorizedOperations: a list of PolarisObjectAuthorizedOperationsEnums
  - The authorized operations on the object.
- configuredSlaDomain: SlaDomain
  - The SLA Domain configured for the hierarchy object.
- diskCount: System.Int32
  - Number of disks in the GCP project.
- effectiveRetentionSlaDomain: SlaDomain
  - The effective Retention SLA Domain of the hierarchy object.
- effectiveSlaDomain: SlaDomain
  - The effective retention of the SLA Domain of the hierarchy object.
- effectiveSlaSourceObject: PathNode
  - The path node of the effective SLA Domain source.
- gcpNativeGceInstanceConnection: GcpNativeGceInstanceConnection
  - List of all GCE instances under this GCP project.
- id: System.String
  - The FID of the hierarchy object.
- lastRefreshedAt: DateTime
  - Last refreshed time of the GCP project.
- logicalChildConnection: GcpNativeProjectLogicalChildTypeConnection
  - List of logical children.
- logicalPath: a list of PathNodes
  - A sequential list of this object's logical ancestors.
- name: System.String
  - The name of the hierarchy object.
- nativeId: System.String
  - Native id of the GCP project.
- nativeName: System.String
  - Native name of the GCP project.
- numWorkloadDescendants: System.Int32
  - The number of descendant workloads of this object.
- objectType: HierarchyObjectTypeEnum
  - The type of this object.
- organizationName: System.String
  - Organization name of the GCP project.
- physicalPath: a list of PathNodes
  - A sequential list of this object's physical ancestors.
- projectNumber: System.String
  - Project number of the GCP project.
- slaAssignment: SlaAssignmentTypeEnum
  - The SLA Domain assignment type for this object.
- slaPauseStatus: System.Boolean
  - The pause status of the effective SLA Domain of the hierarchy object.
- snapshotDistribution: SnapshotDistribution
  - The distribution of the snapshots of the hierarchy object.
- status: GcpNativeProjectStatus
  - Status of the GCP project.
- vmCount: System.Int32
  - Number of virtual machines in the GCP project.