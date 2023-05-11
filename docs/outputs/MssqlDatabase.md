### MssqlDatabase
SQL Server database.

- allOrgs: a list of Orgs
  - The organizations to which this hierarchy object belongs.
- authorizedOperations: a list of Operations
  - The authorized operations on the object.
- cdmGroupedSnapshots: CdmGroupedSnapshotConnection
  - List of snapshots taken for a Rubrik CDM workload grouped by attributes.
- cdmId: System.String
  - CDM ID of the SQL Server database.
- cdmLink: System.String
  - A link to view the workload on the CDM cluster. For dev use only.
- cdmNewestSnapshot: CdmWorkloadSnapshot
  - The newest snapshot taken for a CDM workload.
- cdmOldestSnapshot: CdmWorkloadSnapshot
  - The oldest snapshot taken for a CDM workload.
- cdmOnDemandSnapshotCount: System.Int32
  - The count of on demand snapshots for a SQL Server database.
- cdmSnapshots: CdmWorkloadSnapshotConnection
  - The list of snapshots taken for a SQL Server database.
- cluster: Cluster
  - Rubrik cluster where this object originated.
- configuredSlaDomain: SlaDomain
  - The SLA Domain configured for the hierarchy object.
- copyOnly: System.Boolean
  - Specifies if copy-only backups are enabled. When false, database backups are full backups.
- dagId: System.String
  - ID of the associated SQL Server distributed availability group object.
- effectiveRetentionSlaDomain: SlaDomain
  - The effective Retention SLA Domain of the hierarchy object.
- effectiveSlaDomain: SlaDomain
  - The effective retention of the SLA Domain of the hierarchy object.
- effectiveSlaSourceObject: PathNode
  - The path node of the effective SLA Domain source.
- hasLogConfigFromSla: System.Boolean
  - Boolean flag indicating if the database derives log backup configurations from SLA.
- hasPermissions: System.Boolean
  - Specifies whether the the Rubrik Backup Service has permission to back up a SQL Server database.
- id: System.String
  - The FID of the hierarchy object.
- isInAvailabilityGroup: System.Boolean
  - Specifies if the SQL Server database is in an availability group.
- isLogShippingSecondary: System.Boolean
  - Specifies if the SQL Server database is a log shipping secondary.
- isMount: System.Boolean
  - Specifies if the SQL Server database is a live mount.
- isOnline: System.Boolean
  - Specifies if the SQL Server database is online.
- isRelic: System.Boolean
  - Specifies if the SQL Server database is a relic.
- latestUserNote: LatestUserNote
  - Latest User note information.
- liveMounts: MssqlDatabaseLiveMountConnection
  - List of live mounts for a SQL Server database.
- logBackupFrequencyInSeconds: System.Single
  - Number of seconds between two log backups. When the value is set to 0, log backups are not enabled. When the value is set to -1, the default log backup frequency of the Rubrik cluster is used. When the value is set to -2, the log backup frequency is derived from the SLA Domain.
- logBackupRetentionInHours: System.Int32
  - Number of hours to retain a log backup. When the value is set to -1, the Rubrik cluster retains the log backup until the database snapshots that precede the log backup have expired. When the value is set to -2, the default log backup retention of the Rubrik cluster is used. When the value is set to -3, the log backup retention is derived from the SLA Domain.
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
- numWorkloadDescendants: System.Int32
  - The number of descendant workloads of this object.
- objectType: HierarchyObjectTypeEnum
  - The type of this object.
- oldestSnapshot: CdmSnapshot
  - The oldest snapshot of this workload.
- onDemandSnapshotCount: System.Int32
  - The number of on-demand snapshots.
- pendingObjectDeletionStatus: PendingSnapshotsOfObjectDeletion
  - Mapping from objectID to pending object deletion status.
- pendingSla: SlaDomain
  - SLA Domain assignment of the object during the process of being communicated over to Rubrik CDM.
- physicalPath: a list of PathNodes
  - A sequential list of this object's physical ancestors.
- postBackupScript: System.String
  - Information about the script run after a backup.
- preBackupScript: System.String
  - Information about the script run before a backup.
- primaryClusterLocation: DataLocation
  - The source cluster of this object. Returned as a data location because there is no guarantee that Rubrik has knowledge about the source cluster.
- recoveryModel: System.String
  - Specifies if the recovery model is simple, full, or bulk-logged.
- replicas: a list of CdmMssqlDbReplicas
  - List of the replicas available for the SQL Server database.
- replicatedObjectCount: System.Int32
  - The number of objects either replicated by this object or related to this object by replication.
- replicatedObjects: a list of CdmHierarchyObjects
  - Objects either replicated by this object or related to this object by replication.
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
- unprotectableReasons: a list of System.Strings
  - List of reasons that a SQL Server database cannot be protected.