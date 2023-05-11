### MongoSource
Information about MongoDB Source.

- allOrgs: a list of Orgs
  - The organizations to which this hierarchy object belongs.
- authorizedOperations: a list of Operations
  - The authorized operations on the object.
- cdmId: System.String
  - CDM ID of the MongoDB source.
- cluster: Cluster
  - Information about CDM cluster for this MongoDB cluster.
- clusterUuid: System.String
  - UUID of the CDM cluster.
- configuredSlaDomain: SlaDomain
  - The SLA Domain configured for the hierarchy object.
- descendantConnection: MongoSourceDescendantTypeConnection
  - List of descendants.
- discoveryStatus: MongoDiscoveryStatus
  - Discovery status of the MongoDB source.
- effectiveRetentionSlaDomain: SlaDomain
  - The effective Retention SLA Domain of the hierarchy object.
- effectiveSlaDomain: SlaDomain
  - The effective retention of the SLA Domain of the hierarchy object.
- effectiveSlaSourceObject: PathNode
  - The path node of the effective SLA Domain source.
- id: System.String
  - The FID of the hierarchy object.
- ignoreSecondaryNodes: a list of CdmMongoNodes
  - List of ignored secondary MongoDB source nodes.
- isRelic: System.Boolean
  - Specifies whether the MongoDB source is a relic in CDM.
- lastRefreshTime: DateTime
  - Timestamp of the latest successful MongoDB source refresh.
- latestUserNote: LatestUserNote
  - Latest User note information.
- logicalPath: a list of PathNodes
  - A sequential list of this object's logical ancestors.
- name: System.String
  - The name of the hierarchy object.
- numWorkloadDescendants: System.Int32
  - The number of descendant workloads of this object.
- objectType: HierarchyObjectTypeEnum
  - The type of this object.
- pendingObjectDeletionStatus: PendingSnapshotsOfObjectDeletion
  - Mapping from objectID to pending object deletion status.
- pendingSla: SlaDomain
  - SLA Domain assignment of the object during the process of being communicated over to Rubrik CDM.
- physicalChildConnection: MongoSourcePhysicalChildTypeConnection
  - List of physical children.
- physicalPath: a list of PathNodes
  - A sequential list of this object's physical ancestors.
- primaryClusterLocation: DataLocation
  - The source cluster of this object. Returned as a data location because there is no guarantee that Rubrik has knowledge about the source cluster.
- primaryClusterUuid: System.String
  - IP of the MongoDB source.
- protectedCollectionCount: System.Int32
  - Count of protected collections for this MongoDB source.
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
- sourceNodes: a list of CdmMongoNodes
  - List of source nodes.
- sourceType: MongoSourceType
  - Type of the MongoDB source.
- sslParams: CdmMongoSslParams
  - SSL Options.
- status: MongoSourceStatus
  - Status of the MongoDB source.
- username: System.String
  - MongoDB username.