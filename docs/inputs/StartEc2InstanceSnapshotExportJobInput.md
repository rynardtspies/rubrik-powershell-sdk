### StartEc2InstanceSnapshotExportJobInput
Input to initiate an export job for an AWS native EC2 instance.

- amiId: System.String
  - ID of the Amazon Machine Image (AMI) to be used for launching the EC2 instance. This field should be specified only when snapshotType is specified as Archived and amiTypeForAwsNativeArchivedSnapshot returns AMI type as USER_SPECIFIED. In other cases, either a pre-existing AMI is picked, or a new AMI is created at runtime, and an AMI ID is not required. The AMI specified here should be present in the target account and region of export. The specified AMI will be used for launching the instance for export, and all its volumes will be replaced.
- destinationAwsAccountRubrikId: System.String
  - Rubrik UUID of the AWS account where the instance will be exported.
- destinationRegionId: AwsNativeRegion
  - Region of the exported instance.
- exportInstanceInPoweredOffState: System.Boolean
  - Power state of the exported instance.
- iamInstanceProfileArn: System.String
  - ARN of the IAM instance profile to be attached to the exported EC2 instance.
- instanceName: System.String
  - Name of the exported instance.
- instanceType: AwsNativeEc2InstanceType
  - AWS Native EC2 instance type to be used after export. Some examples are: t2.nano, m5.xlarge. For more information, see https://aws.amazon.com/ec2/instance-types.
- kmsKeyId: System.String
  - ID of the KMS key to be used for export.
- securityGroupIds: a list of System.Strings
  - List of security group IDs to be used for the exported instance.
- shouldCopyTags: System.Boolean
  - Specifies whether to copy tags to the exported instance.
- snapshotId: System.String
  - ID of the snapshot to be exported.
- snapshotType: SnapshotType
  - Type of snapshot used for export.
- sshKeyPairName: System.String
  - Name of the SSH key pair to be used for export.
- subnetId: System.String
  - ID of the subnet to use for the exported instance.