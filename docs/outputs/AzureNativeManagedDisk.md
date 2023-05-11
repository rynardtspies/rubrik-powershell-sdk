### AzureNativeManagedDisk
An Azure Native Managed Disk that refers to the block storage designed to be used with Azure Virtual Machines. Some examples are: ultra disks, premium solid-state drives (SSD), standard SSDs, and standard hard disk drives (HDD). For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/managed-disks-overview.

- allAttachedAzureNativeVirtualMachines: a list of AzureNativeVirtualMachines
  - All Virtual Machines (VMs) attached to the Managed Disk.
- allOrgs: a list of Orgs
  - The organizations to which this hierarchy object belongs.
- attachmentSpecs: a list of AttachmentSpecsForManagedDisks
  - Attachment Specifications are properties of the Managed Disk,  like the ID of the virtual machine (VM) that is associated with the Managed Disk.
- authorizedOperations: a list of PolarisSnappableAuthorizedOperationsEnums
  - The authorized operations on the object.
- availabilityZone: System.String
  - Availability Zone associated with the Managed Disk.
- cloudNativeId: System.String
  - Native ID of the Managed Disk.
- configuredSlaDomain: SlaDomain
  - The SLA Domain configured for the hierarchy object.
- diskIopsReadWrite: System.Int64
  - Number of Input/Output operations Per Second (IOPS) allowed for the Managed Disk.
- diskMbpsReadWrite: System.Int64
  - Bandwidth allowed for the Managed Disk, in millions of bytes per second (MBps).
- diskNativeId: System.String
  - Native ID of the Managed Disk.
- diskSizeGib: System.Int32
  - Size of the Managed Disk in gigabytes (GiB).
- diskStorageTier: AzureNativeManagedDiskType
  - Storage tier of the Managed Disk.
- effectiveRetentionSlaDomain: SlaDomain
  - The effective Retention SLA Domain of the hierarchy object.
- effectiveSlaDomain: SlaDomain
  - The effective retention of the SLA Domain of the hierarchy object.
- effectiveSlaSourceObject: PathNode
  - The path node of the effective SLA Domain source.
- id: System.String
  - The FID of the hierarchy object.
- isAdeEnabled: System.Boolean
  - Specifies whether Azure Disk Encryption (ADE) is enabled on the Managed Disk or not. When the value is true, ADE is enabled.
- isExocomputeConfigured: System.Boolean
  - Specifies whether exocompute is configured for the region in which the Managed Disk exists or not. When the value is true, exocompute can be used to perform tasks like file indexing.
- isFileIndexingEnabled: System.Boolean
  - Specifies whether file indexing is enabled for this Managed Disk or not. When file indexing is enabled, Rubrik can scan through the file structure inside the managed disk in a protected environment where only the meta data like folder structure, file names, and file sizes will be readable by Rubrik.
- isRelic: System.Boolean
  - Specifies whether the Managed Disk is a relic. When the value is true, the Managed Disk is a relic. A Managed Disk is a relic when it is unprotected or deleted, but the previously taken snapshots of the Managed Disk continue to exist within the Rubrik ecosystem.
- logicalPath: a list of PathNodes
  - A sequential list of this object's logical ancestors.
- name: System.String
  - The name of the hierarchy object.
- nativeName: System.String
  - Azure Native name of the object.
- newestIndexedSnapshot: PolarisSnapshot
  - The newest snapshot that is indexed and unexpired, and therefore restorable.
- newestSnapshot: PolarisSnapshot
  - The most recent snapshot of this workload.
- numWorkloadDescendants: System.Int32
  - The number of descendant workloads of this object.
- objectType: HierarchyObjectTypeEnum
  - The type of this object.
- oldestSnapshot: PolarisSnapshot
  - The oldest snapshot of this workload.
- onDemandSnapshotCount: System.Int32
  - The number of on-demand snapshots.
- osType: AzureNativeVmOsType
  - Type of the Operating System (OS) installed on the Managed Disk.
- physicalPath: a list of PathNodes
  - A sequential list of this object's physical ancestors.
- region: AzureNativeRegion
  - Azure region where the Managed Disk is located.
- resourceGroup: AzureNativeResourceGroup
  - Resource Group of the Azure Native Managed Disk.
- slaAssignment: SlaAssignmentTypeEnum
  - The SLA Domain assignment type for this object.
- slaPauseStatus: System.Boolean
  - The pause status of the effective SLA Domain of the hierarchy object.
- snapshotConnection: PolarisSnapshotConnection
  - The list of snapshots taken for this workload.
- snapshotDistribution: SnapshotDistribution
  - The distribution of the snapshots of the hierarchy object.
- snapshotGroupByConnection: PolarisSnapshotGroupByConnection
  - GroupBy connection for this workload's snapshots.
- snapshotGroupByNewConnection: PolarisSnapshotGroupByNewConnection
  - GroupBy connection for this workload's snapshots.
- tags: a list of AzureTags
  - List of tags associated with the Managed Disk.
- workloadSnapshotConnection: GenericSnapshotConnection
  - The list of snapshots taken for this workload.