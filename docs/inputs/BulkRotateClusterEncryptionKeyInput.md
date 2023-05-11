### BulkRotateClusterEncryptionKeyInput
Input required to perform a data-at-rest encryption key rotation for multiple clusters in bulk.

- clusters: a list of System.Strings
  - IDs of the Rubrik clusters.
- targetKeyType: ClusterKeyProtection
  - Key protection type. The type must be either TPM or KMIP and must be supported on all of the specified clusters.