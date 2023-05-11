### CreateAwsExocomputeConfigsInput
Input to create AWS exocompute configurations.

- cloudAccountId: System.String
  - Rubrik ID for cloud account.
- configs: a list of AwsExocomputeConfigInputs
  - List of exocompute configurations for the cloud account.
- triggerHealthCheck: System.Boolean
  - Specifies whether to start Exocompute health check.