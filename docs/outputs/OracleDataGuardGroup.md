### OracleDataGuardGroup
- allOrgs: a list of Orgs
  - The organizations to which this hierarchy object belongs.
- authorizedOperations: a list of Operations
  - The authorized operations on the object.
- cdmId: System.String
  - CDM ID of the Oracle Data Guard Group.
- cdmLink: System.String
  - A link to view the workload on the CDM cluster. For dev use only.
- cluster: Cluster
  - Rubrik cluster where this object originated.
- configuredSlaDomain: SlaDomain
  - The SLA Domain configured for the hierarchy object.
- dataGuardGroupId: System.String
  - The Data Guard group ID of the Oracle Data Guard Group.
- dataGuardType: DataGuardType
  - The Data Guard type of the Oracle Data Guard Group.
- dbRole: System.String
  - The role of the Oracle Data Guard Group.
- dbUniqueName: System.String
  - The DB unique name of the Oracle Data Guard Group.
- descendantConnection: OracleDataGuardGroupDescendantTypeConnection
  - List of descendants.
- effectiveRetentionSlaDomain: SlaDomain
  - The effective Retention SLA Domain of the hierarchy object.
- effectiveSlaDomain: SlaDomain
  - The effective retention of the SLA Domain of the hierarchy object.
- effectiveSlaSourceObject: PathNode
  - The path node of the effective SLA Domain source.
- hostLogRetentionHours: System.Int32
  - The host log retention, in hours, of the Oracle Data Guard Group.
- id: System.String
  - The FID of the hierarchy object.
- isRelic: System.Boolean
  - Whether the Oracle Data Guard Group is a relic in CDM.
- lastValidationResult: OracleDatabaseLastValidationStatus
  - The last validation result of the Oracle Data Guard Group.
- latestUserNote: LatestUserNote
  - Latest User note information.
- logBackupFrequency: System.Int32
  - The log backup frequency, in minutes, of the Oracle Data Guard Group.
- logRetentionHours: System.Int32
  - The log retention, in hours, of the Oracle Data Guard Group.
- logicalChildConnection: OracleDataGuardGroupLogicalChildTypeConnection
  - List of logical children.
- logicalPath: a list of PathNodes
  - A sequential list of this object's logical ancestors.
- missedSnapshotConnection: MissedSnapshotCommonConnection
  - The list of missed snapshots for this workload.
- missedSnapshotGroupByConnection: MissedSnapshotGroupByConnection
  - The list of missed snapshots for this workload.
- name: System.String
  - The name of the hierarchy object.
- newestArchivedSnapshot: CdmSnapshot
  - The newest snapshot archived to AWS.
- newestReplicatedSnapshot: CdmSnapshot
  - The newest snapshot replicated to a cluster.
- newestSnapshot: CdmSnapshot
  - The most recent snapshot of this workload.
- numChannels: System.Int64
  - The number of RMAN channels used for backup and  restore of the Oracle Data Guard Group.
- numInstances: System.Int32
  - The number of instances of the Oracle Data Guard Group.
- numLogSnapshots: System.Int32
  - The number of log snapshots taken of the Oracle Data Guard Group.
- numTablespaces: System.Int32
  - The number of tablespaces contained in the Oracle Data Guard Group.
- numWorkloadDescendants: System.Int32
  - The number of descendant workloads of this object.
- objectType: HierarchyObjectTypeEnum
  - The type of this object.
- oldestSnapshot: CdmSnapshot
  - The oldest snapshot of this workload.
- onDemandSnapshotCount: System.Int32
  - The number of on-demand snapshots.
- pdbs: a list of OraclePdbs
  - The Pluggable Databases of an Oracle Data Guard Group.
- pendingObjectDeletionStatus: PendingSnapshotsOfObjectDeletion
  - Mapping from objectID to pending object deletion status.
- pendingSla: SlaDomain
  - SLA Domain assignment of the object during the process of being communicated over to Rubrik CDM.
- physicalPath: a list of PathNodes
  - A sequential list of this object's physical ancestors.
- preferredDataGuardMemberUniqueNames: a list of System.Strings
  - An ordered sequence of Oracle Data Guard members' unique names to be chosen for backups. The list may be empty or contain a maximum of one name.
- primaryClusterLocation: DataLocation
  - The source cluster of this object. Returned as a data location because there is no guarantee that Rubrik has knowledge about the source cluster.
- replicatedObjectCount: System.Int32
  - The number of objects either replicated by this object or related to this object by replication.
- replicatedObjects: a list of CdmHierarchyObjects
  - Objects either replicated by this object or related to this object by replication.
- sectionSizeInGigabytes: System.Int32
  - Specifies the section size, in gigabytes, to be used during backups.
- shouldBackupFromPrimaryOnly: System.Boolean
  - Specifies whether backup jobs should run on the primary member of the Oracle Data Guard Group only.
- slaAssignment: SlaAssignmentTypeEnum
  - The SLA Domain assignment type for this object.
- slaPauseStatus: System.Boolean
  - The pause status of the effective SLA Domain of the hierarchy object.
- snapshotConnection: CdmSnapshotConnection
  - The list of snapshots taken for this workload.
- snapshotDistribution: SnapshotDistribution
  - The distribution of the snapshots of the hierarchy object.
- snapshotGroupByConnection: CdmSnapshotGroupByConnection
  - GroupBy connection for the snapshots of this workload.
- snapshotGroupBySummary: CdmSnapshotGroupBySummaryConnection
  - GroupBy connection for the snapshots of this workload.
- tablespaces: a list of System.Strings
  - The list of tablespaces in the Oracle Data Guard Group.