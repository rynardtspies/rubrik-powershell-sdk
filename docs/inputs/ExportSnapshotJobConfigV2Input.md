### ExportSnapshotJobConfigV2Input
Supported in v5.1+

- clusterId: System.String
  - Supported in v5.2+
      ID of the cluster to export the new virtual machine to. virtual machine.
- datastoreId: System.String
  - Required. Supported in v5.1+
      ID of the datastore to assign to the exported virtual machine.
- hostId: System.String
  - Supported in v5.1+
      ID of the ESXi host to export the new virtual machine to.
- mountExportSnapshotJobCommonOptionsV2: MountExportSnapshotJobCommonOptionsV2Input
  - 
- requiredRecoveryParameters: RequiredRecoveryParametersInput
  - 
- resourcePoolId: System.String
  - Supported in v5.2+
      ID of the resource pool to export the new virtual machine to.
- shouldRecoverTags: System.Boolean
  - Supported in v5.1+
      The job recovers any tags that were assigned to the virtual machine.
- shouldUseHotAddProxy: System.Boolean
  - Supported in v7.0+
      Boolean value that determines whether Export uses a HotAdd mode to transport virtual disk data. When this value is `true`, Export uses HotAdd mode to transport virtual disk data. When this value is `false`, Export uses NBDSSL to transport virtual disk data. The default value is `false`.
- unregisterVm: System.Boolean
  - Supported in v5.1+
      A Boolean value that determines whether the new virtual machine created from a snapshot is registered with the vCenter Server. When this value is 'true', the registration is removed from the vCenter Server. When this value is 'false', the registration is kept on the vCenter Server. The default is 'false'.
- vNicBindings: a list of VmwareVnicBindingInfoV2Inputs
  - Supported in v6.0+
      The network binding for vNIC of the virtual machine.