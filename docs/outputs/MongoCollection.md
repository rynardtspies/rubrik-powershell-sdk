### MongoCollection
Information about MongoDB Collection.

- allOrgs: a list of Orgs
  - The organizations to which this hierarchy object belongs.
- authorizedOperations: a list of Operations
  - The authorized operations on the object.
- cdmId: System.String
  - CDM ID of the MongoDB collection.
- cluster: Cluster
  - Rubrik cluster where this object originated.
- clusterUuid: System.String
  - Identifier of the host cluster.
- collectionSet: MongoCollectionSet
  - Parent collection set connection.
- configuredSlaDomain: SlaDomain
  - The SLA Domain configured for the hierarchy object.
- database: MongoDatabase
  - Parent database connection.
- effectiveRetentionSlaDomain: SlaDomain
  - The effective Retention SLA Domain of the hierarchy object.
- effectiveSlaDomain: SlaDomain
  - The effective retention of the SLA Domain of the hierarchy object.
- effectiveSlaSourceObject: PathNode
  - The path node of the effective SLA Domain source.
- id: System.String
  - The FID of the hierarchy object.
- isRelic: System.Boolean
  - Specifies whether the MongoDB collection is a relic in CDM.
- latestUserNote: LatestUserNote
  - Latest User note information.
- logicalPath: a list of PathNodes
  - A sequential list of this object's logical ancestors.
- mongoSnapshotConnection: CdmSnapshotConnection
  - The list of MongoDB Collection Snapshots.
- mongoSnapshotGroupByConnection: MongoSnapshotGroupByConnection
  - GroupBy connection for MongoDB Collection Snapshots.
- name: System.String
  - The name of the hierarchy object.
- newestSnapshot: CdmSnapshot
  - The most recent snapshot of this workload.
- numWorkloadDescendants: System.Int32
  - The number of descendant workloads of this object.
- objectType: HierarchyObjectTypeEnum
  - The type of this object.
- oldestSnapshot: CdmSnapshot
  - The oldest snapshot of this workload.
- pendingObjectDeletionStatus: PendingSnapshotsOfObjectDeletion
  - Mapping from objectID to pending object deletion status.
- pendingSla: SlaDomain
  - SLA Domain assignment of the object during the process of being communicated over to Rubrik CDM.
- physicalPath: a list of PathNodes
  - A sequential list of this object's physical ancestors.
- primaryClusterLocation: DataLocation
  - The source cluster of this object. Returned as a data location because there is no guarantee that Rubrik has knowledge about the source cluster.
- primaryClusterUuid: System.String
  - Identifier of the primary host cluster.
- replicatedObjectCount: System.Int32
  - The number of objects either replicated by this object or related to this object by replication.
- replicatedObjects: a list of CdmHierarchyObjects
  - Objects either replicated by this object or related to this object by replication.
- slaAssignment: SlaAssignmentTypeEnum
  - The SLA Domain assignment type for this object.
- slaPauseStatus: System.Boolean
  - The pause status of the effective SLA Domain of the hierarchy object.
- snapshotDistribution: SnapshotDistribution
  - The distribution of the snapshots of the hierarchy object.
- source: MongoSource
  - Parent source connection.