### CassandraColumnFamily
Cassandra Column Family information.

- allOrgs: a list of Orgs
  - The organizations to which this hierarchy object belongs.
- authorizedOperations: a list of PolarisObjectAuthorizedOperationsEnums
  - The authorized operations on the object.
- backupCount: System.Int32
  - Number of backups for the column family.
- backupParams: CassandraBackupParams
  - Backup Params of the source.
- cluster: Cluster
  - Mosaic cluster information.
- clusterUuid: System.String
  - UUID of the Mosaic cluster.
- configuredSlaDomain: SlaDomain
  - The SLA Domain configured for the hierarchy object.
- effectiveRetentionSlaDomain: SlaDomain
  - The effective Retention SLA Domain of the hierarchy object.
- effectiveSlaDomain: SlaDomain
  - The effective retention of the SLA Domain of the hierarchy object.
- effectiveSlaSourceObject: PathNode
  - The path node of the effective SLA Domain source.
- id: System.String
  - The source object ID.
- isRelic: System.Boolean
  - Is the source object a relic.
- keyspace: CassandraKeyspace
  - Parent keyspace connection.
- logicalPath: a list of PathNodes
  - A sequential list of this object's logical ancestors.
- name: System.String
  - The name of the hierarchy object.
- newestSnapshot: MosaicSnapshot
  - The most recent snapshot of this workload.
- numWorkloadDescendants: System.Int32
  - The number of descendant workloads of this object.
- objectType: HierarchyObjectTypeEnum
  - The type of this object.
- oldestSnapshot: MosaicSnapshot
  - The oldest snapshot of this workload.
- physicalPath: a list of PathNodes
  - A sequential list of this object's physical ancestors.
- protectionDate: System.String
  - Date that effective SLA was assigned / inherited.
- slaAssignment: SlaAssignmentTypeEnum
  - The SLA Domain assignment type for this object.
- slaPauseStatus: System.Boolean
  - The pause status of the effective SLA Domain of the hierarchy object.
- snapshotDistribution: SnapshotDistribution
  - The distribution of the snapshots of the hierarchy object.
- snapshotGroupBys: MosaicSnapshotGroupByTypeConnection
  - GroupBy connection for this workload's snapshots.
- snapshots: MosaicSnapshotConnection
  - The list of snapshots taken for this workload.
- source: CassandraSource
  - Parent source connection.