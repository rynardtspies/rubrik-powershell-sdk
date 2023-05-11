### GetAnomalyDetailsReply
Anomaly analysis report from lambda service.

- anomalyInfo: AnomalyInfo
  - Information about possible ransomware strains.
- anomalyProbability: System.Single
  - The probability of the snapshot being anomalous.
- bytesCreatedCount: System.Int64
  - Total new bytes created.
- bytesDeletedCount: System.Int64
  - Total bytes deleted.
- bytesModifiedCount: System.Int64
  - Total bytes modified.
- bytesNetChangedCount: System.Int64
  - Net change in the number of bytes. For example, if 5 bytes are added and 3 bytes deleted, this field returns 2 as the number of bytes that changed.
- bytesSuspiciousCount: System.Int64
  - Total suspicious bytes.
- cluster: Cluster
  - The Rubrik cluster of the object.
- encryption: EncryptionLevel
  - Level of encryption detected.
- filesCreatedCount: System.Int64
  - The count of new files created.
- filesDeletedCount: System.Int64
  - The count of files deleted.
- filesModifiedCount: System.Int64
  - The count of files modified.
- id: System.String
  - The id of the anomaly.
- isAnomaly: System.Boolean
  - Specifies whether the snapshot is anomalous.
- location: System.String
  - The location of the object.
- managedId: System.String
  - The internal managed ID of the object.
- objectType: ObjectTypeEnum
  - The type of the object.
- previousSnapshotDate: DateTime
  - The date of the previous snapshot.
- previousSnapshotId: System.String
  - The ID of the previous snapshot.
- ransomwareResult: RansomwareResult
  - The ransomware analysis result, including encryption.
- severity: ActivitySeverityEnum
  - Severity of the anomaly.
- snapshot: CdmSnapshot
  - The analyzed snapshot.
- snapshotDate: DateTime
  - The date of the snapshot.
- snapshotFid: System.String
  - The internal fid of the snapshot.
- snapshotId: System.String
  - The internal ID of the snapshot.
- suspiciousFilesCount: System.Int64
  - Total number of suspicious files.
- workloadFid: System.String
  - The internal fid of the object.
- workloadId: System.String
  - The internal ID of the object.
- workloadName: System.String
  - The name of the object.