### CdmUpgradeInfo
- authorizedOperations: AuthorizedOperations
  - You are authorized to perform operations on the Rubrik cluster.
- cdmClusterNodeDetails: a list of CdmNodeDetails
  - Rubrik CDM cluster node details.
- clusterJobStatus: ClusterJobStatusTypeEnum
  - Cluster job status.
- clusterStatus: CdmClusterStatus
  - Status of the Rubrik cluster.
- clusterUuid: System.String
  - The cluster UUID.
- currentStateProgress: System.Single
  - Current running state progress percentage.
- downloadedVersion: System.String
  - Downloaded version of tarball.
- fastUpgradePreferred: System.Boolean
  - Upgrade type in cdm cluster.
- finishedStates: System.String
  - Finished states of upgrade.
- lastUpgradeDuration: UpgradeDurationReply
  - Time taken by the last upgrade.
- overallProgress: System.Single
  - Overall upgrade progress.
- pendingStates: System.String
  - Pending states of upgrade.
- previousVersion: System.String
  - The version of the cluster before the upgrade.
- scheduleUpgradeAction: System.String
  - Scheduled-Upgrade action.
- scheduleUpgradeAt: DateTime
  - Scheduled-Upgrade timestamp.
- scheduleUpgradeMode: System.String
  - Scheduled-Upgrade mode.
- stateMachineStatus: System.String
  - Upgrade state machine status.
- stateMachineStatusAt: DateTime
  - The time at which the state machine was last updated..
- upgradeEndAt: DateTime
  - The time at which the upgrade ended.
- upgradeEventSeriesId: System.String
  - The upgrade event series ID.
- upgradeRecommendationInfo: UpgradeRecommendationInfo
  - Recommended upgrade version of the Rubrik cluster.
- upgradeStartAt: DateTime
  - The time at which the upgrade started.
- version: System.String
  - Version of the Rubrik cluster.
- versionStatus: VersionStatus
  - Version status of the Rubrik cluster.