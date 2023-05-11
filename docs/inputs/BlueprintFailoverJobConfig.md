### BlueprintFailoverJobConfig
- blueprintId: System.String
  - The ID of the Blueprint to be failed over.
- childSnappableFailoverInfos: a list of SnappableFailoverInfoTypes
  - None
- dataTransferType: DataTransferType
  - The type of the data transfer, EXPORT, INPLACE, and HYDRATION.
- enableRecoveryWithRba: System.Boolean
  - Flag to enable recovery using Rubrik backup agent.
- failoverFailureAction: System.String
  - The failure action of failover, PAUSE or CLEANUP.
- failoverIgnorableErrors: a list of BlueprintFailoverIgnorableErrors
  - Errors that should be ignored during failover.
- failoverOperation: System.String
  - The operation of the failover, Start or Resume.
- failoverType: System.String
  - The type of the failover job, LOCALRECOVERY, FAILOVER or TEST_FAILOVER.
- isZeroRpo: System.Boolean
  - Flag to enable zero RPO.
- recoveryPlanId: System.String
  - The ID of recovery plan if it belongs to a recovery plan.
- targetLocationType: LocationType
  - The type of the target location, CDM, AZURE, AWS or GCP.
- targetLocationUuid: System.String
  - The UUID of the target location.
- timeoutInMinutes: System.Int32
  - Timeout in minutes for failover job, if it is not given, then there will be no timeout.
- updateRecoverySpecPostFailover: System.Boolean
  - Specifies whether the recovery spec is updated as part of failover (after production failover) or not.