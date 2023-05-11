### RubrikManagedGcpTarget
Specific information for Google Cloud Platform (GCP) target created on Rubrik.

- archivalProxySettings: ProxySettings
  - Proxy setting of this GCP target.
- bucket: System.String
  - Bucket of the GCP target.
- bypassProxy: System.Boolean
  - Specifies whether the proxy settings should be bypassed for creating this target location.
- cluster: Cluster
  - The cluster to which this target belongs.
- clusterName: System.String
  - Name of the Rubrik cluster that archives to this archival location.
- connectionStatus: ConnectionStatusType
  - Connection status of the GCP target.
- consumedBytes: System.Int64
  - Number of bytes stored on the target.
- failedTasks: System.Int32
  - Number of archiving tasks failed on this target.
- id: System.String
  - The ID of this target.
- isActive: System.Boolean
  - Specifies whether this target is active. When false, the target is either paused or not enabled.
- isArchived: System.Boolean
  - Specifies whether this target is archived.
- locationConnectionStatus: ConnectionStatusType
  - Connected or Disconnected status of the target.
- locationScope: LocationScope
  - The scope of location of this target. Possible values are Global or Local.
- name: System.String
  - The name of this target.
- readerRetrievalMethod: ReaderRetrievalMethod
  - The retrieval method of the reader target.
- region: GcpRegion
  - Region of GCP target.
- runningTasks: System.Int32
  - Number of archiving tasks running on this target.
- status: ArchivalLocationStatus
  - Status of the target.
- storageClass: GcpStorageClass
  - Storage class of the GCP target.
- syncFailureReason: System.String
  - Reason why sync of this target with CDM failed.
- syncStatus: TargetSyncStatus
  - Sync status of GCP target.
- targetMapping: TargetMappingBasic
  - Archival location to which the mapping target belongs.
- targetMappingBasic: a list of TargetMappingBasics
  - List of archival groups the archival target belongs to. In case target has no valid mappings we return null array.
- targetType: TargetType
  - The type of this target.
- upgradeStatus: UpgradeStatus
  - Upgrade status of the target.