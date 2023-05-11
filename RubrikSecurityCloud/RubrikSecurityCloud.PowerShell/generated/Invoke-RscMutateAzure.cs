// Invoke-RscMutateAzure.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using Rubrik.SecurityCloud.Types;
using Rubrik.SecurityCloud.NetSDK.Client;
using Rubrik.SecurityCloud.PowerShell.Private;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using Rubrik.SecurityCloud.NetSDK.Library.HelperClasses;
using GraphQL;

namespace Rubrik.SecurityCloud.PowerShell.Cmdlets
{
    [Cmdlet(
        "Invoke",
        "RscMutateAzure",
        DefaultParameterSetName = "createTarget")
    ]
    public class Invoke_RscMutateAzure : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // startRefreshNativeSubscriptionsJob parameter set
        //
        // GraphQL operation: startRefreshAzureNativeSubscriptionsJob(input: StartRefreshAzureNativeSubscriptionsJobInput!):BatchAsyncJobStatus!
        //
        [Parameter(
            ParameterSetName = "startRefreshNativeSubscriptionsJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: startRefreshAzureNativeSubscriptionsJob(input: StartRefreshAzureNativeSubscriptionsJobInput!):BatchAsyncJobStatus!",
            Position = 0
        )]
        public SwitchParameter startRefreshNativeSubscriptionsJob { get; set; }

        [Parameter(
            ParameterSetName = "startRefreshNativeSubscriptionsJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument input: StartRefreshAzureNativeSubscriptionsJobInput!"
        )]
        public StartRefreshAzureNativeSubscriptionsJobInput? Input { get; set; }
        
        // -------------------------------------------------------------------
        // startRestoreNativeVirtualMachineJob parameter set
        //
        // GraphQL operation: startRestoreAzureNativeVirtualMachineJob(input: StartRestoreAzureNativeVirtualMachineJobInput!):AsyncJobStatus!
        //
        [Parameter(
            ParameterSetName = "startRestoreNativeVirtualMachineJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: startRestoreAzureNativeVirtualMachineJob(input: StartRestoreAzureNativeVirtualMachineJobInput!):AsyncJobStatus!",
            Position = 0
        )]
        public SwitchParameter startRestoreNativeVirtualMachineJob { get; set; }

        
        // -------------------------------------------------------------------
        // startExportNativeVirtualMachineJob parameter set
        //
        // GraphQL operation: startExportAzureNativeVirtualMachineJob(input: StartExportAzureNativeVirtualMachineJobInput!):AsyncJobStatus!
        //
        [Parameter(
            ParameterSetName = "startExportNativeVirtualMachineJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: startExportAzureNativeVirtualMachineJob(input: StartExportAzureNativeVirtualMachineJobInput!):AsyncJobStatus!",
            Position = 0
        )]
        public SwitchParameter startExportNativeVirtualMachineJob { get; set; }

        
        // -------------------------------------------------------------------
        // excludeNativeManagedDisksFromSnapshot parameter set
        //
        // GraphQL operation: excludeAzureNativeManagedDisksFromSnapshot(input: ExcludeAzureNativeManagedDisksFromSnapshotInput!):Void
        //
        [Parameter(
            ParameterSetName = "excludeNativeManagedDisksFromSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: excludeAzureNativeManagedDisksFromSnapshot(input: ExcludeAzureNativeManagedDisksFromSnapshotInput!):Void",
            Position = 0
        )]
        public SwitchParameter excludeNativeManagedDisksFromSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // startCreateNativeVirtualMachineSnapshotsJob parameter set
        //
        // GraphQL operation: startCreateAzureNativeVirtualMachineSnapshotsJob(input: StartCreateAzureNativeVirtualMachineSnapshotsJobInput!):BatchAsyncJobStatus!
        //
        [Parameter(
            ParameterSetName = "startCreateNativeVirtualMachineSnapshotsJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: startCreateAzureNativeVirtualMachineSnapshotsJob(input: StartCreateAzureNativeVirtualMachineSnapshotsJobInput!):BatchAsyncJobStatus!",
            Position = 0
        )]
        public SwitchParameter startCreateNativeVirtualMachineSnapshotsJob { get; set; }

        
        // -------------------------------------------------------------------
        // startDisableNativeSubscriptionProtectionJob parameter set
        //
        // GraphQL operation: startDisableAzureNativeSubscriptionProtectionJob(input: StartDisableAzureNativeSubscriptionProtectionJobInput!):AsyncJobStatus!
        //
        [Parameter(
            ParameterSetName = "startDisableNativeSubscriptionProtectionJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: startDisableAzureNativeSubscriptionProtectionJob(input: StartDisableAzureNativeSubscriptionProtectionJobInput!):AsyncJobStatus!",
            Position = 0
        )]
        public SwitchParameter startDisableNativeSubscriptionProtectionJob { get; set; }

        
        // -------------------------------------------------------------------
        // startCreateNativeManagedDiskSnapshotsJob parameter set
        //
        // GraphQL operation: startCreateAzureNativeManagedDiskSnapshotsJob(input: StartCreateAzureNativeManagedDiskSnapshotsJobInput!):BatchAsyncJobStatus!
        //
        [Parameter(
            ParameterSetName = "startCreateNativeManagedDiskSnapshotsJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: startCreateAzureNativeManagedDiskSnapshotsJob(input: StartCreateAzureNativeManagedDiskSnapshotsJobInput!):BatchAsyncJobStatus!",
            Position = 0
        )]
        public SwitchParameter startCreateNativeManagedDiskSnapshotsJob { get; set; }

        
        // -------------------------------------------------------------------
        // startExportNativeManagedDiskJob parameter set
        //
        // GraphQL operation: startExportAzureNativeManagedDiskJob(input: StartExportAzureNativeManagedDiskJobInput!):AsyncJobStatus!
        //
        [Parameter(
            ParameterSetName = "startExportNativeManagedDiskJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: startExportAzureNativeManagedDiskJob(input: StartExportAzureNativeManagedDiskJobInput!):AsyncJobStatus!",
            Position = 0
        )]
        public SwitchParameter startExportNativeManagedDiskJob { get; set; }

        
        // -------------------------------------------------------------------
        // startExportSqlDatabaseDbJob parameter set
        //
        // GraphQL operation: startExportAzureSqlDatabaseDbJob(input: StartExportAzureSqlDatabaseDbJobInput!):AsyncJobStatus!
        //
        [Parameter(
            ParameterSetName = "startExportSqlDatabaseDbJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: startExportAzureSqlDatabaseDbJob(input: StartExportAzureSqlDatabaseDbJobInput!):AsyncJobStatus!",
            Position = 0
        )]
        public SwitchParameter startExportSqlDatabaseDbJob { get; set; }

        
        // -------------------------------------------------------------------
        // startExportSqlManagedInstanceDbJob parameter set
        //
        // GraphQL operation: startExportAzureSqlManagedInstanceDbJob(input: StartExportAzureSqlManagedInstanceDbJobInput!):AsyncJobStatus!
        //
        [Parameter(
            ParameterSetName = "startExportSqlManagedInstanceDbJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: startExportAzureSqlManagedInstanceDbJob(input: StartExportAzureSqlManagedInstanceDbJobInput!):AsyncJobStatus!",
            Position = 0
        )]
        public SwitchParameter startExportSqlManagedInstanceDbJob { get; set; }

        
        // -------------------------------------------------------------------
        // createAccount parameter set
        //
        // GraphQL operation: createAzureAccount(input: CreateAzureAccountInput!):CloudAccount!
        //
        [Parameter(
            ParameterSetName = "createAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: createAzureAccount(input: CreateAzureAccountInput!):CloudAccount!",
            Position = 0
        )]
        public SwitchParameter createAccount { get; set; }

        
        // -------------------------------------------------------------------
        // updateAccount parameter set
        //
        // GraphQL operation: updateAzureAccount(input: UpdateAzureAccountInput!):CloudAccount!
        //
        [Parameter(
            ParameterSetName = "updateAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: updateAzureAccount(input: UpdateAzureAccountInput!):CloudAccount!",
            Position = 0
        )]
        public SwitchParameter updateAccount { get; set; }

        
        // -------------------------------------------------------------------
        // createAutomaticTargetMapping parameter set
        //
        // GraphQL operation: createAutomaticAzureTargetMapping(input: CreateAutomaticAzureTargetMappingInput!):TargetMapping!
        //
        [Parameter(
            ParameterSetName = "createAutomaticTargetMapping",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: createAutomaticAzureTargetMapping(input: CreateAutomaticAzureTargetMappingInput!):TargetMapping!",
            Position = 0
        )]
        public SwitchParameter createAutomaticTargetMapping { get; set; }

        
        // -------------------------------------------------------------------
        // createCloudNativeStorageSetting parameter set
        //
        // GraphQL operation: createCloudNativeAzureStorageSetting(input: CreateCloudNativeAzureStorageSettingInput!):CreateCloudNativeAzureStorageSettingReply!
        //
        [Parameter(
            ParameterSetName = "createCloudNativeStorageSetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: createCloudNativeAzureStorageSetting(input: CreateCloudNativeAzureStorageSettingInput!):CreateCloudNativeAzureStorageSettingReply!",
            Position = 0
        )]
        public SwitchParameter createCloudNativeStorageSetting { get; set; }

        
        // -------------------------------------------------------------------
        // createCloudNativeRcvStorageSetting parameter set
        //
        // GraphQL operation: createCloudNativeRcvAzureStorageSetting(input: CreateCloudNativeRcvAzureStorageSettingInput!):CreateCloudNativeRcvAzureStorageSettingReply!
        //
        [Parameter(
            ParameterSetName = "createCloudNativeRcvStorageSetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: createCloudNativeRcvAzureStorageSetting(input: CreateCloudNativeRcvAzureStorageSettingInput!):CreateCloudNativeRcvAzureStorageSettingReply!",
            Position = 0
        )]
        public SwitchParameter createCloudNativeRcvStorageSetting { get; set; }

        
        // -------------------------------------------------------------------
        // updateAutomaticTargetMapping parameter set
        //
        // GraphQL operation: updateAutomaticAzureTargetMapping(input: UpdateAutomaticAzureTargetMappingInput!):TargetMapping!
        //
        [Parameter(
            ParameterSetName = "updateAutomaticTargetMapping",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: updateAutomaticAzureTargetMapping(input: UpdateAutomaticAzureTargetMappingInput!):TargetMapping!",
            Position = 0
        )]
        public SwitchParameter updateAutomaticTargetMapping { get; set; }

        
        // -------------------------------------------------------------------
        // updateCloudNativeStorageSetting parameter set
        //
        // GraphQL operation: updateCloudNativeAzureStorageSetting(input: UpdateCloudNativeAzureStorageSettingInput!):UpdateCloudNativeAzureStorageSettingReply!
        //
        [Parameter(
            ParameterSetName = "updateCloudNativeStorageSetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: updateCloudNativeAzureStorageSetting(input: UpdateCloudNativeAzureStorageSettingInput!):UpdateCloudNativeAzureStorageSettingReply!",
            Position = 0
        )]
        public SwitchParameter updateCloudNativeStorageSetting { get; set; }

        
        // -------------------------------------------------------------------
        // updateCloudNativeRcvStorageSetting parameter set
        //
        // GraphQL operation: updateCloudNativeRcvAzureStorageSetting(input: UpdateCloudNativeRcvAzureStorageSettingInput!):UpdateCloudNativeRcvAzureStorageSettingReply!
        //
        [Parameter(
            ParameterSetName = "updateCloudNativeRcvStorageSetting",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: updateCloudNativeRcvAzureStorageSetting(input: UpdateCloudNativeRcvAzureStorageSettingInput!):UpdateCloudNativeRcvAzureStorageSettingReply!",
            Position = 0
        )]
        public SwitchParameter updateCloudNativeRcvStorageSetting { get; set; }

        
        // -------------------------------------------------------------------
        // createTarget parameter set
        //
        // GraphQL operation: createAzureTarget(input: CreateAzureTargetInput!):Target!
        //
        [Parameter(
            ParameterSetName = "createTarget",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: createAzureTarget(input: CreateAzureTargetInput!):Target!",
            Position = 0
        )]
        public SwitchParameter createTarget { get; set; }

        
        // -------------------------------------------------------------------
        // updateTarget parameter set
        //
        // GraphQL operation: updateAzureTarget(input: UpdateAzureTargetInput!):Target!
        //
        [Parameter(
            ParameterSetName = "updateTarget",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: updateAzureTarget(input: UpdateAzureTargetInput!):Target!",
            Position = 0
        )]
        public SwitchParameter updateTarget { get; set; }

        
        // -------------------------------------------------------------------
        // createReaderTarget parameter set
        //
        // GraphQL operation: createAzureReaderTarget(input: CreateAzureReaderTargetInput!):Target!
        //
        [Parameter(
            ParameterSetName = "createReaderTarget",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: createAzureReaderTarget(input: CreateAzureReaderTargetInput!):Target!",
            Position = 0
        )]
        public SwitchParameter createReaderTarget { get; set; }

        
        // -------------------------------------------------------------------
        // startCloudAccountOauth parameter set
        //
        // GraphQL operation: startAzureCloudAccountOauth(input: StartAzureCloudAccountOauthInput!):StartAzureCloudAccountOauthReply!
        //
        [Parameter(
            ParameterSetName = "startCloudAccountOauth",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: startAzureCloudAccountOauth(input: StartAzureCloudAccountOauthInput!):StartAzureCloudAccountOauthReply!",
            Position = 0
        )]
        public SwitchParameter startCloudAccountOauth { get; set; }

        
        // -------------------------------------------------------------------
        // completeCloudAccountOauth parameter set
        //
        // GraphQL operation: completeAzureCloudAccountOauth(input: CompleteAzureCloudAccountOauthInput!):CompleteAzureCloudAccountOauthReply!
        //
        [Parameter(
            ParameterSetName = "completeCloudAccountOauth",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: completeAzureCloudAccountOauth(input: CompleteAzureCloudAccountOauthInput!):CompleteAzureCloudAccountOauthReply!",
            Position = 0
        )]
        public SwitchParameter completeCloudAccountOauth { get; set; }

        
        // -------------------------------------------------------------------
        // setCloudAccountCustomerAppCredential parameter set
        //
        // GraphQL operation: setAzureCloudAccountCustomerAppCredentials(input: SetAzureCloudAccountCustomerAppCredentialsInput!):Boolean!
        //
        [Parameter(
            ParameterSetName = "setCloudAccountCustomerAppCredential",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: setAzureCloudAccountCustomerAppCredentials(input: SetAzureCloudAccountCustomerAppCredentialsInput!):Boolean!",
            Position = 0
        )]
        public SwitchParameter setCloudAccountCustomerAppCredential { get; set; }

        
        // -------------------------------------------------------------------
        // addCloudAccount parameter set
        //
        // GraphQL operation: addAzureCloudAccount(input: AddAzureCloudAccountInput!):AddAzureCloudAccountReply!
        //
        [Parameter(
            ParameterSetName = "addCloudAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: addAzureCloudAccount(input: AddAzureCloudAccountInput!):AddAzureCloudAccountReply!",
            Position = 0
        )]
        public SwitchParameter addCloudAccount { get; set; }

        
        // -------------------------------------------------------------------
        // addCloudAccountWithoutOauth parameter set
        //
        // GraphQL operation: addAzureCloudAccountWithoutOauth(input: AddAzureCloudAccountWithoutOauthInput!):AddAzureCloudAccountWithoutOauthReply!
        //
        [Parameter(
            ParameterSetName = "addCloudAccountWithoutOauth",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: addAzureCloudAccountWithoutOauth(input: AddAzureCloudAccountWithoutOauthInput!):AddAzureCloudAccountWithoutOauthReply!",
            Position = 0
        )]
        public SwitchParameter addCloudAccountWithoutOauth { get; set; }

        
        // -------------------------------------------------------------------
        // deleteCloudAccount parameter set
        //
        // GraphQL operation: deleteAzureCloudAccount(input: DeleteAzureCloudAccountInput!):DeleteAzureCloudAccountReply!
        //
        [Parameter(
            ParameterSetName = "deleteCloudAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: deleteAzureCloudAccount(input: DeleteAzureCloudAccountInput!):DeleteAzureCloudAccountReply!",
            Position = 0
        )]
        public SwitchParameter deleteCloudAccount { get; set; }

        
        // -------------------------------------------------------------------
        // deleteCloudAccountWithoutOauth parameter set
        //
        // GraphQL operation: deleteAzureCloudAccountWithoutOauth(input: DeleteAzureCloudAccountWithoutOauthInput!):DeleteAzureCloudAccountWithoutOauthReply!
        //
        [Parameter(
            ParameterSetName = "deleteCloudAccountWithoutOauth",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: deleteAzureCloudAccountWithoutOauth(input: DeleteAzureCloudAccountWithoutOauthInput!):DeleteAzureCloudAccountWithoutOauthReply!",
            Position = 0
        )]
        public SwitchParameter deleteCloudAccountWithoutOauth { get; set; }

        
        // -------------------------------------------------------------------
        // upgradeCloudAccount parameter set
        //
        // GraphQL operation: upgradeAzureCloudAccount(input: UpgradeAzureCloudAccountInput!):UpgradeAzureCloudAccountReply!
        //
        [Parameter(
            ParameterSetName = "upgradeCloudAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: upgradeAzureCloudAccount(input: UpgradeAzureCloudAccountInput!):UpgradeAzureCloudAccountReply!",
            Position = 0
        )]
        public SwitchParameter upgradeCloudAccount { get; set; }

        
        // -------------------------------------------------------------------
        // updateCustomerAppPermissionForSql parameter set
        //
        // GraphQL operation: updateCustomerAppPermissionForAzureSql:Void
        //
        [Parameter(
            ParameterSetName = "updateCustomerAppPermissionForSql",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: updateCustomerAppPermissionForAzureSql:Void",
            Position = 0
        )]
        public SwitchParameter updateCustomerAppPermissionForSql { get; set; }

        
        // -------------------------------------------------------------------
        // startDisableCloudAccountJob parameter set
        //
        // GraphQL operation: startDisableAzureCloudAccountJob(input: StartDisableAzureCloudAccountJobInput!):BatchAsyncJobStatus!
        //
        [Parameter(
            ParameterSetName = "startDisableCloudAccountJob",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: startDisableAzureCloudAccountJob(input: StartDisableAzureCloudAccountJobInput!):BatchAsyncJobStatus!",
            Position = 0
        )]
        public SwitchParameter startDisableCloudAccountJob { get; set; }

        
        // -------------------------------------------------------------------
        // updateCloudAccount parameter set
        //
        // GraphQL operation: updateAzureCloudAccount(input: UpdateAzureCloudAccountInput!):UpdateAzureCloudAccountReply!
        //
        [Parameter(
            ParameterSetName = "updateCloudAccount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: updateAzureCloudAccount(input: UpdateAzureCloudAccountInput!):UpdateAzureCloudAccountReply!",
            Position = 0
        )]
        public SwitchParameter updateCloudAccount { get; set; }

        
        // -------------------------------------------------------------------
        // mapCloudAccountToPersistentStorageLocation parameter set
        //
        // GraphQL operation: mapAzureCloudAccountToPersistentStorageLocation(input: MapAzureCloudAccountToPersistentStorageLocationInput!):MapAzureCloudAccountToPersistentStorageLocationReply!
        //
        [Parameter(
            ParameterSetName = "mapCloudAccountToPersistentStorageLocation",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: mapAzureCloudAccountToPersistentStorageLocation(input: MapAzureCloudAccountToPersistentStorageLocationInput!):MapAzureCloudAccountToPersistentStorageLocationReply!",
            Position = 0
        )]
        public SwitchParameter mapCloudAccountToPersistentStorageLocation { get; set; }

        
        // -------------------------------------------------------------------
        // addCloudAccountExocomputeConfiguration parameter set
        //
        // GraphQL operation: addAzureCloudAccountExocomputeConfigurations(input: AddAzureCloudAccountExocomputeConfigurationsInput!):AddAzureCloudAccountExocomputeConfigurationsReply!
        //
        [Parameter(
            ParameterSetName = "addCloudAccountExocomputeConfiguration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: addAzureCloudAccountExocomputeConfigurations(input: AddAzureCloudAccountExocomputeConfigurationsInput!):AddAzureCloudAccountExocomputeConfigurationsReply!",
            Position = 0
        )]
        public SwitchParameter addCloudAccountExocomputeConfiguration { get; set; }

        
        // -------------------------------------------------------------------
        // deleteCloudAccountExocomputeConfiguration parameter set
        //
        // GraphQL operation: deleteAzureCloudAccountExocomputeConfigurations(input: DeleteAzureCloudAccountExocomputeConfigurationsInput!):DeleteAzureCloudAccountExocomputeConfigurationsReply!
        //
        [Parameter(
            ParameterSetName = "deleteCloudAccountExocomputeConfiguration",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: deleteAzureCloudAccountExocomputeConfigurations(input: DeleteAzureCloudAccountExocomputeConfigurationsInput!):DeleteAzureCloudAccountExocomputeConfigurationsReply!",
            Position = 0
        )]
        public SwitchParameter deleteCloudAccountExocomputeConfiguration { get; set; }

        
        // -------------------------------------------------------------------
        // mapCloudAccountExocomputeSubscription parameter set
        //
        // GraphQL operation: mapAzureCloudAccountExocomputeSubscription(input: MapAzureCloudAccountExocomputeSubscriptionInput!):MapAzureCloudAccountExocomputeSubscriptionReply!
        //
        [Parameter(
            ParameterSetName = "mapCloudAccountExocomputeSubscription",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: mapAzureCloudAccountExocomputeSubscription(input: MapAzureCloudAccountExocomputeSubscriptionInput!):MapAzureCloudAccountExocomputeSubscriptionReply!",
            Position = 0
        )]
        public SwitchParameter mapCloudAccountExocomputeSubscription { get; set; }

        
        // -------------------------------------------------------------------
        // unmapCloudAccountExocomputeSubscription parameter set
        //
        // GraphQL operation: unmapAzureCloudAccountExocomputeSubscription(input: UnmapAzureCloudAccountExocomputeSubscriptionInput!):UnmapAzureCloudAccountExocomputeSubscriptionReply!
        //
        [Parameter(
            ParameterSetName = "unmapCloudAccountExocomputeSubscription",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: unmapAzureCloudAccountExocomputeSubscription(input: UnmapAzureCloudAccountExocomputeSubscriptionInput!):UnmapAzureCloudAccountExocomputeSubscriptionReply!",
            Position = 0
        )]
        public SwitchParameter unmapCloudAccountExocomputeSubscription { get; set; }

        
        // -------------------------------------------------------------------
        // upgradeCloudAccountPermissionsWithoutOauth parameter set
        //
        // GraphQL operation: upgradeAzureCloudAccountPermissionsWithoutOauth(input: UpgradeAzureCloudAccountPermissionsWithoutOauthInput!):UpgradeAzureCloudAccountPermissionsWithoutOauthReply!
        //
        [Parameter(
            ParameterSetName = "upgradeCloudAccountPermissionsWithoutOauth",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: upgradeAzureCloudAccountPermissionsWithoutOauth(input: UpgradeAzureCloudAccountPermissionsWithoutOauthInput!):UpgradeAzureCloudAccountPermissionsWithoutOauthReply!",
            Position = 0
        )]
        public SwitchParameter upgradeCloudAccountPermissionsWithoutOauth { get; set; }

        
        // -------------------------------------------------------------------
        // OauthConsentKickoff parameter set
        //
        // GraphQL operation: azureOauthConsentKickoff:AzureOauthConsentKickoffReply!
        //
        [Parameter(
            ParameterSetName = "OauthConsentKickoff",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: azureOauthConsentKickoff:AzureOauthConsentKickoffReply!",
            Position = 0
        )]
        public SwitchParameter OauthConsentKickoff { get; set; }

        
        // -------------------------------------------------------------------
        // OauthConsentComplete parameter set
        //
        // GraphQL operation: azureOauthConsentComplete(input: AzureOauthConsentCompleteInput!):RequestStatus!
        //
        [Parameter(
            ParameterSetName = "OauthConsentComplete",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: azureOauthConsentComplete(input: AzureOauthConsentCompleteInput!):RequestStatus!",
            Position = 0
        )]
        public SwitchParameter OauthConsentComplete { get; set; }

        
        // -------------------------------------------------------------------
        // createSaasAppAad parameter set
        //
        // GraphQL operation: createAzureSaasAppAad:CreateAzureSaasAppAadReply!
        //
        [Parameter(
            ParameterSetName = "createSaasAppAad",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: createAzureSaasAppAad:CreateAzureSaasAppAadReply!",
            Position = 0
        )]
        public SwitchParameter createSaasAppAad { get; set; }

        
        // -------------------------------------------------------------------
        // createCluster parameter set
        //
        // GraphQL operation: createAzureCluster(input: CreateAzureClusterInput!):CcProvisionJobReply!
        //
        [Parameter(
            ParameterSetName = "createCluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: createAzureCluster(input: CreateAzureClusterInput!):CcProvisionJobReply!",
            Position = 0
        )]
        public SwitchParameter createCluster { get; set; }

        
        // -------------------------------------------------------------------
        // deleteCluster parameter set
        //
        // GraphQL operation: deleteAzureCluster(input: DeleteAzureClusterInput!):CcProvisionJobReply!
        //
        [Parameter(
            ParameterSetName = "deleteCluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: deleteAzureCluster(input: DeleteAzureClusterInput!):CcProvisionJobReply!",
            Position = 0
        )]
        public SwitchParameter deleteCluster { get; set; }


        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "startRefreshNativeSubscriptionsJob":
                        this.ProcessRecord_startRefreshNativeSubscriptionsJob();
                        break;
                    case "startRestoreNativeVirtualMachineJob":
                        this.ProcessRecord_startRestoreNativeVirtualMachineJob();
                        break;
                    case "startExportNativeVirtualMachineJob":
                        this.ProcessRecord_startExportNativeVirtualMachineJob();
                        break;
                    case "excludeNativeManagedDisksFromSnapshot":
                        this.ProcessRecord_excludeNativeManagedDisksFromSnapshot();
                        break;
                    case "startCreateNativeVirtualMachineSnapshotsJob":
                        this.ProcessRecord_startCreateNativeVirtualMachineSnapshotsJob();
                        break;
                    case "startDisableNativeSubscriptionProtectionJob":
                        this.ProcessRecord_startDisableNativeSubscriptionProtectionJob();
                        break;
                    case "startCreateNativeManagedDiskSnapshotsJob":
                        this.ProcessRecord_startCreateNativeManagedDiskSnapshotsJob();
                        break;
                    case "startExportNativeManagedDiskJob":
                        this.ProcessRecord_startExportNativeManagedDiskJob();
                        break;
                    case "startExportSqlDatabaseDbJob":
                        this.ProcessRecord_startExportSqlDatabaseDbJob();
                        break;
                    case "startExportSqlManagedInstanceDbJob":
                        this.ProcessRecord_startExportSqlManagedInstanceDbJob();
                        break;
                    case "createAccount":
                        this.ProcessRecord_createAccount();
                        break;
                    case "updateAccount":
                        this.ProcessRecord_updateAccount();
                        break;
                    case "createAutomaticTargetMapping":
                        this.ProcessRecord_createAutomaticTargetMapping();
                        break;
                    case "createCloudNativeStorageSetting":
                        this.ProcessRecord_createCloudNativeStorageSetting();
                        break;
                    case "createCloudNativeRcvStorageSetting":
                        this.ProcessRecord_createCloudNativeRcvStorageSetting();
                        break;
                    case "updateAutomaticTargetMapping":
                        this.ProcessRecord_updateAutomaticTargetMapping();
                        break;
                    case "updateCloudNativeStorageSetting":
                        this.ProcessRecord_updateCloudNativeStorageSetting();
                        break;
                    case "updateCloudNativeRcvStorageSetting":
                        this.ProcessRecord_updateCloudNativeRcvStorageSetting();
                        break;
                    case "createTarget":
                        this.ProcessRecord_createTarget();
                        break;
                    case "updateTarget":
                        this.ProcessRecord_updateTarget();
                        break;
                    case "createReaderTarget":
                        this.ProcessRecord_createReaderTarget();
                        break;
                    case "startCloudAccountOauth":
                        this.ProcessRecord_startCloudAccountOauth();
                        break;
                    case "completeCloudAccountOauth":
                        this.ProcessRecord_completeCloudAccountOauth();
                        break;
                    case "setCloudAccountCustomerAppCredential":
                        this.ProcessRecord_setCloudAccountCustomerAppCredential();
                        break;
                    case "addCloudAccount":
                        this.ProcessRecord_addCloudAccount();
                        break;
                    case "addCloudAccountWithoutOauth":
                        this.ProcessRecord_addCloudAccountWithoutOauth();
                        break;
                    case "deleteCloudAccount":
                        this.ProcessRecord_deleteCloudAccount();
                        break;
                    case "deleteCloudAccountWithoutOauth":
                        this.ProcessRecord_deleteCloudAccountWithoutOauth();
                        break;
                    case "upgradeCloudAccount":
                        this.ProcessRecord_upgradeCloudAccount();
                        break;
                    case "updateCustomerAppPermissionForSql":
                        this.ProcessRecord_updateCustomerAppPermissionForSql();
                        break;
                    case "startDisableCloudAccountJob":
                        this.ProcessRecord_startDisableCloudAccountJob();
                        break;
                    case "updateCloudAccount":
                        this.ProcessRecord_updateCloudAccount();
                        break;
                    case "mapCloudAccountToPersistentStorageLocation":
                        this.ProcessRecord_mapCloudAccountToPersistentStorageLocation();
                        break;
                    case "addCloudAccountExocomputeConfiguration":
                        this.ProcessRecord_addCloudAccountExocomputeConfiguration();
                        break;
                    case "deleteCloudAccountExocomputeConfiguration":
                        this.ProcessRecord_deleteCloudAccountExocomputeConfiguration();
                        break;
                    case "mapCloudAccountExocomputeSubscription":
                        this.ProcessRecord_mapCloudAccountExocomputeSubscription();
                        break;
                    case "unmapCloudAccountExocomputeSubscription":
                        this.ProcessRecord_unmapCloudAccountExocomputeSubscription();
                        break;
                    case "upgradeCloudAccountPermissionsWithoutOauth":
                        this.ProcessRecord_upgradeCloudAccountPermissionsWithoutOauth();
                        break;
                    case "OauthConsentKickoff":
                        this.ProcessRecord_OauthConsentKickoff();
                        break;
                    case "OauthConsentComplete":
                        this.ProcessRecord_OauthConsentComplete();
                        break;
                    case "createSaasAppAad":
                        this.ProcessRecord_createSaasAppAad();
                        break;
                    case "createCluster":
                        this.ProcessRecord_createCluster();
                        break;
                    case "deleteCluster":
                        this.ProcessRecord_deleteCluster();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + Op);
                }
           }
           catch (Exception ex)
           {
                this._logger.Flush();
                var error = new ErrorRecord(
                    ex,
                    "Invoke-RscMutateAzure",
                    ErrorCategory.InvalidOperation,
                    null);
                ThrowTerminatingError(error);
           }
        }

        // This parameter set invokes a single graphql operation:
        // startRefreshAzureNativeSubscriptionsJob.
        protected void ProcessRecord_startRefreshNativeSubscriptionsJob()
        {
            this._logger.name += " -startRefreshNativeSubscriptionsJob";
            // Invoke graphql operation startRefreshAzureNativeSubscriptionsJob
            InvokeMutationStartRefreshAzureNativeSubscriptionsJob();
        }

        // This parameter set invokes a single graphql operation:
        // startRestoreAzureNativeVirtualMachineJob.
        protected void ProcessRecord_startRestoreNativeVirtualMachineJob()
        {
            this._logger.name += " -startRestoreNativeVirtualMachineJob";
            // Invoke graphql operation startRestoreAzureNativeVirtualMachineJob
            InvokeMutationStartRestoreAzureNativeVirtualMachineJob();
        }

        // This parameter set invokes a single graphql operation:
        // startExportAzureNativeVirtualMachineJob.
        protected void ProcessRecord_startExportNativeVirtualMachineJob()
        {
            this._logger.name += " -startExportNativeVirtualMachineJob";
            // Invoke graphql operation startExportAzureNativeVirtualMachineJob
            InvokeMutationStartExportAzureNativeVirtualMachineJob();
        }

        // This parameter set invokes a single graphql operation:
        // excludeAzureNativeManagedDisksFromSnapshot.
        protected void ProcessRecord_excludeNativeManagedDisksFromSnapshot()
        {
            this._logger.name += " -excludeNativeManagedDisksFromSnapshot";
            // Invoke graphql operation excludeAzureNativeManagedDisksFromSnapshot
            InvokeMutationExcludeAzureNativeManagedDisksFromSnapshot();
        }

        // This parameter set invokes a single graphql operation:
        // startCreateAzureNativeVirtualMachineSnapshotsJob.
        protected void ProcessRecord_startCreateNativeVirtualMachineSnapshotsJob()
        {
            this._logger.name += " -startCreateNativeVirtualMachineSnapshotsJob";
            // Invoke graphql operation startCreateAzureNativeVirtualMachineSnapshotsJob
            InvokeMutationStartCreateAzureNativeVirtualMachineSnapshotsJob();
        }

        // This parameter set invokes a single graphql operation:
        // startDisableAzureNativeSubscriptionProtectionJob.
        protected void ProcessRecord_startDisableNativeSubscriptionProtectionJob()
        {
            this._logger.name += " -startDisableNativeSubscriptionProtectionJob";
            // Invoke graphql operation startDisableAzureNativeSubscriptionProtectionJob
            InvokeMutationStartDisableAzureNativeSubscriptionProtectionJob();
        }

        // This parameter set invokes a single graphql operation:
        // startCreateAzureNativeManagedDiskSnapshotsJob.
        protected void ProcessRecord_startCreateNativeManagedDiskSnapshotsJob()
        {
            this._logger.name += " -startCreateNativeManagedDiskSnapshotsJob";
            // Invoke graphql operation startCreateAzureNativeManagedDiskSnapshotsJob
            InvokeMutationStartCreateAzureNativeManagedDiskSnapshotsJob();
        }

        // This parameter set invokes a single graphql operation:
        // startExportAzureNativeManagedDiskJob.
        protected void ProcessRecord_startExportNativeManagedDiskJob()
        {
            this._logger.name += " -startExportNativeManagedDiskJob";
            // Invoke graphql operation startExportAzureNativeManagedDiskJob
            InvokeMutationStartExportAzureNativeManagedDiskJob();
        }

        // This parameter set invokes a single graphql operation:
        // startExportAzureSqlDatabaseDbJob.
        protected void ProcessRecord_startExportSqlDatabaseDbJob()
        {
            this._logger.name += " -startExportSqlDatabaseDbJob";
            // Invoke graphql operation startExportAzureSqlDatabaseDbJob
            InvokeMutationStartExportAzureSqlDatabaseDbJob();
        }

        // This parameter set invokes a single graphql operation:
        // startExportAzureSqlManagedInstanceDbJob.
        protected void ProcessRecord_startExportSqlManagedInstanceDbJob()
        {
            this._logger.name += " -startExportSqlManagedInstanceDbJob";
            // Invoke graphql operation startExportAzureSqlManagedInstanceDbJob
            InvokeMutationStartExportAzureSqlManagedInstanceDbJob();
        }

        // This parameter set invokes a single graphql operation:
        // createAzureAccount.
        protected void ProcessRecord_createAccount()
        {
            this._logger.name += " -createAccount";
            // Invoke graphql operation createAzureAccount
            InvokeMutationCreateAzureAccount();
        }

        // This parameter set invokes a single graphql operation:
        // updateAzureAccount.
        protected void ProcessRecord_updateAccount()
        {
            this._logger.name += " -updateAccount";
            // Invoke graphql operation updateAzureAccount
            InvokeMutationUpdateAzureAccount();
        }

        // This parameter set invokes a single graphql operation:
        // createAutomaticAzureTargetMapping.
        protected void ProcessRecord_createAutomaticTargetMapping()
        {
            this._logger.name += " -createAutomaticTargetMapping";
            // Invoke graphql operation createAutomaticAzureTargetMapping
            InvokeMutationCreateAutomaticAzureTargetMapping();
        }

        // This parameter set invokes a single graphql operation:
        // createCloudNativeAzureStorageSetting.
        protected void ProcessRecord_createCloudNativeStorageSetting()
        {
            this._logger.name += " -createCloudNativeStorageSetting";
            // Invoke graphql operation createCloudNativeAzureStorageSetting
            InvokeMutationCreateCloudNativeAzureStorageSetting();
        }

        // This parameter set invokes a single graphql operation:
        // createCloudNativeRcvAzureStorageSetting.
        protected void ProcessRecord_createCloudNativeRcvStorageSetting()
        {
            this._logger.name += " -createCloudNativeRcvStorageSetting";
            // Invoke graphql operation createCloudNativeRcvAzureStorageSetting
            InvokeMutationCreateCloudNativeRcvAzureStorageSetting();
        }

        // This parameter set invokes a single graphql operation:
        // updateAutomaticAzureTargetMapping.
        protected void ProcessRecord_updateAutomaticTargetMapping()
        {
            this._logger.name += " -updateAutomaticTargetMapping";
            // Invoke graphql operation updateAutomaticAzureTargetMapping
            InvokeMutationUpdateAutomaticAzureTargetMapping();
        }

        // This parameter set invokes a single graphql operation:
        // updateCloudNativeAzureStorageSetting.
        protected void ProcessRecord_updateCloudNativeStorageSetting()
        {
            this._logger.name += " -updateCloudNativeStorageSetting";
            // Invoke graphql operation updateCloudNativeAzureStorageSetting
            InvokeMutationUpdateCloudNativeAzureStorageSetting();
        }

        // This parameter set invokes a single graphql operation:
        // updateCloudNativeRcvAzureStorageSetting.
        protected void ProcessRecord_updateCloudNativeRcvStorageSetting()
        {
            this._logger.name += " -updateCloudNativeRcvStorageSetting";
            // Invoke graphql operation updateCloudNativeRcvAzureStorageSetting
            InvokeMutationUpdateCloudNativeRcvAzureStorageSetting();
        }

        // This parameter set invokes a single graphql operation:
        // createAzureTarget.
        protected void ProcessRecord_createTarget()
        {
            this._logger.name += " -createTarget";
            // Invoke graphql operation createAzureTarget
            InvokeMutationCreateAzureTarget();
        }

        // This parameter set invokes a single graphql operation:
        // updateAzureTarget.
        protected void ProcessRecord_updateTarget()
        {
            this._logger.name += " -updateTarget";
            // Invoke graphql operation updateAzureTarget
            InvokeMutationUpdateAzureTarget();
        }

        // This parameter set invokes a single graphql operation:
        // createAzureReaderTarget.
        protected void ProcessRecord_createReaderTarget()
        {
            this._logger.name += " -createReaderTarget";
            // Invoke graphql operation createAzureReaderTarget
            InvokeMutationCreateAzureReaderTarget();
        }

        // This parameter set invokes a single graphql operation:
        // startAzureCloudAccountOauth.
        protected void ProcessRecord_startCloudAccountOauth()
        {
            this._logger.name += " -startCloudAccountOauth";
            // Invoke graphql operation startAzureCloudAccountOauth
            InvokeMutationStartAzureCloudAccountOauth();
        }

        // This parameter set invokes a single graphql operation:
        // completeAzureCloudAccountOauth.
        protected void ProcessRecord_completeCloudAccountOauth()
        {
            this._logger.name += " -completeCloudAccountOauth";
            // Invoke graphql operation completeAzureCloudAccountOauth
            InvokeMutationCompleteAzureCloudAccountOauth();
        }

        // This parameter set invokes a single graphql operation:
        // setAzureCloudAccountCustomerAppCredentials.
        protected void ProcessRecord_setCloudAccountCustomerAppCredential()
        {
            this._logger.name += " -setCloudAccountCustomerAppCredential";
            // Invoke graphql operation setAzureCloudAccountCustomerAppCredentials
            InvokeMutationSetAzureCloudAccountCustomerAppCredentials();
        }

        // This parameter set invokes a single graphql operation:
        // addAzureCloudAccount.
        protected void ProcessRecord_addCloudAccount()
        {
            this._logger.name += " -addCloudAccount";
            // Invoke graphql operation addAzureCloudAccount
            InvokeMutationAddAzureCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // addAzureCloudAccountWithoutOauth.
        protected void ProcessRecord_addCloudAccountWithoutOauth()
        {
            this._logger.name += " -addCloudAccountWithoutOauth";
            // Invoke graphql operation addAzureCloudAccountWithoutOauth
            InvokeMutationAddAzureCloudAccountWithoutOauth();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAzureCloudAccount.
        protected void ProcessRecord_deleteCloudAccount()
        {
            this._logger.name += " -deleteCloudAccount";
            // Invoke graphql operation deleteAzureCloudAccount
            InvokeMutationDeleteAzureCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAzureCloudAccountWithoutOauth.
        protected void ProcessRecord_deleteCloudAccountWithoutOauth()
        {
            this._logger.name += " -deleteCloudAccountWithoutOauth";
            // Invoke graphql operation deleteAzureCloudAccountWithoutOauth
            InvokeMutationDeleteAzureCloudAccountWithoutOauth();
        }

        // This parameter set invokes a single graphql operation:
        // upgradeAzureCloudAccount.
        protected void ProcessRecord_upgradeCloudAccount()
        {
            this._logger.name += " -upgradeCloudAccount";
            // Invoke graphql operation upgradeAzureCloudAccount
            InvokeMutationUpgradeAzureCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // updateCustomerAppPermissionForAzureSql.
        protected void ProcessRecord_updateCustomerAppPermissionForSql()
        {
            this._logger.name += " -updateCustomerAppPermissionForSql";
            // Invoke graphql operation updateCustomerAppPermissionForAzureSql
            InvokeMutationUpdateCustomerAppPermissionForAzureSql();
        }

        // This parameter set invokes a single graphql operation:
        // startDisableAzureCloudAccountJob.
        protected void ProcessRecord_startDisableCloudAccountJob()
        {
            this._logger.name += " -startDisableCloudAccountJob";
            // Invoke graphql operation startDisableAzureCloudAccountJob
            InvokeMutationStartDisableAzureCloudAccountJob();
        }

        // This parameter set invokes a single graphql operation:
        // updateAzureCloudAccount.
        protected void ProcessRecord_updateCloudAccount()
        {
            this._logger.name += " -updateCloudAccount";
            // Invoke graphql operation updateAzureCloudAccount
            InvokeMutationUpdateAzureCloudAccount();
        }

        // This parameter set invokes a single graphql operation:
        // mapAzureCloudAccountToPersistentStorageLocation.
        protected void ProcessRecord_mapCloudAccountToPersistentStorageLocation()
        {
            this._logger.name += " -mapCloudAccountToPersistentStorageLocation";
            // Invoke graphql operation mapAzureCloudAccountToPersistentStorageLocation
            InvokeMutationMapAzureCloudAccountToPersistentStorageLocation();
        }

        // This parameter set invokes a single graphql operation:
        // addAzureCloudAccountExocomputeConfigurations.
        protected void ProcessRecord_addCloudAccountExocomputeConfiguration()
        {
            this._logger.name += " -addCloudAccountExocomputeConfiguration";
            // Invoke graphql operation addAzureCloudAccountExocomputeConfigurations
            InvokeMutationAddAzureCloudAccountExocomputeConfigurations();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAzureCloudAccountExocomputeConfigurations.
        protected void ProcessRecord_deleteCloudAccountExocomputeConfiguration()
        {
            this._logger.name += " -deleteCloudAccountExocomputeConfiguration";
            // Invoke graphql operation deleteAzureCloudAccountExocomputeConfigurations
            InvokeMutationDeleteAzureCloudAccountExocomputeConfigurations();
        }

        // This parameter set invokes a single graphql operation:
        // mapAzureCloudAccountExocomputeSubscription.
        protected void ProcessRecord_mapCloudAccountExocomputeSubscription()
        {
            this._logger.name += " -mapCloudAccountExocomputeSubscription";
            // Invoke graphql operation mapAzureCloudAccountExocomputeSubscription
            InvokeMutationMapAzureCloudAccountExocomputeSubscription();
        }

        // This parameter set invokes a single graphql operation:
        // unmapAzureCloudAccountExocomputeSubscription.
        protected void ProcessRecord_unmapCloudAccountExocomputeSubscription()
        {
            this._logger.name += " -unmapCloudAccountExocomputeSubscription";
            // Invoke graphql operation unmapAzureCloudAccountExocomputeSubscription
            InvokeMutationUnmapAzureCloudAccountExocomputeSubscription();
        }

        // This parameter set invokes a single graphql operation:
        // upgradeAzureCloudAccountPermissionsWithoutOauth.
        protected void ProcessRecord_upgradeCloudAccountPermissionsWithoutOauth()
        {
            this._logger.name += " -upgradeCloudAccountPermissionsWithoutOauth";
            // Invoke graphql operation upgradeAzureCloudAccountPermissionsWithoutOauth
            InvokeMutationUpgradeAzureCloudAccountPermissionsWithoutOauth();
        }

        // This parameter set invokes a single graphql operation:
        // azureOauthConsentKickoff.
        protected void ProcessRecord_OauthConsentKickoff()
        {
            this._logger.name += " -OauthConsentKickoff";
            // Invoke graphql operation azureOauthConsentKickoff
            InvokeMutationAzureOauthConsentKickoff();
        }

        // This parameter set invokes a single graphql operation:
        // azureOauthConsentComplete.
        protected void ProcessRecord_OauthConsentComplete()
        {
            this._logger.name += " -OauthConsentComplete";
            // Invoke graphql operation azureOauthConsentComplete
            InvokeMutationAzureOauthConsentComplete();
        }

        // This parameter set invokes a single graphql operation:
        // createAzureSaasAppAad.
        protected void ProcessRecord_createSaasAppAad()
        {
            this._logger.name += " -createSaasAppAad";
            // Invoke graphql operation createAzureSaasAppAad
            InvokeMutationCreateAzureSaasAppAad();
        }

        // This parameter set invokes a single graphql operation:
        // createAzureCluster.
        protected void ProcessRecord_createCluster()
        {
            this._logger.name += " -createCluster";
            // Invoke graphql operation createAzureCluster
            InvokeMutationCreateAzureCluster();
        }

        // This parameter set invokes a single graphql operation:
        // deleteAzureCluster.
        protected void ProcessRecord_deleteCluster()
        {
            this._logger.name += " -deleteCluster";
            // Invoke graphql operation deleteAzureCluster
            InvokeMutationDeleteAzureCluster();
        }


        // Invoke GraphQL Mutation:
        // startRefreshAzureNativeSubscriptionsJob(input: StartRefreshAzureNativeSubscriptionsJobInput!): BatchAsyncJobStatus!
        protected void InvokeMutationStartRefreshAzureNativeSubscriptionsJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartRefreshAzureNativeSubscriptionsJobInput!"),
            };
            BatchAsyncJobStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (BatchAsyncJobStatus)psObject.BaseObject;
                } else {
                    fields = (BatchAsyncJobStatus)this.Field;
                }
            }
            string document = Mutation.StartRefreshAzureNativeSubscriptionsJob(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.StartRefreshAzureNativeSubscriptionsJob");
            string parameters = "($input: StartRefreshAzureNativeSubscriptionsJobInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationStartRefreshAzureNativeSubscriptionsJob" + parameters + "{" + document + "}",
                OperationName = "MutationStartRefreshAzureNativeSubscriptionsJob",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<BatchAsyncJobStatus> task = this._rbkClient.InvokeGenericCallAsync<BatchAsyncJobStatus>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // startRestoreAzureNativeVirtualMachineJob(input: StartRestoreAzureNativeVirtualMachineJobInput!): AsyncJobStatus!
        protected void InvokeMutationStartRestoreAzureNativeVirtualMachineJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartRestoreAzureNativeVirtualMachineJobInput!"),
            };
            AsyncJobStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncJobStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncJobStatus)this.Field;
                }
            }
            string document = Mutation.StartRestoreAzureNativeVirtualMachineJob(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.StartRestoreAzureNativeVirtualMachineJob");
            string parameters = "($input: StartRestoreAzureNativeVirtualMachineJobInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationStartRestoreAzureNativeVirtualMachineJob" + parameters + "{" + document + "}",
                OperationName = "MutationStartRestoreAzureNativeVirtualMachineJob",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncJobStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncJobStatus>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // startExportAzureNativeVirtualMachineJob(input: StartExportAzureNativeVirtualMachineJobInput!): AsyncJobStatus!
        protected void InvokeMutationStartExportAzureNativeVirtualMachineJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartExportAzureNativeVirtualMachineJobInput!"),
            };
            AsyncJobStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncJobStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncJobStatus)this.Field;
                }
            }
            string document = Mutation.StartExportAzureNativeVirtualMachineJob(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.StartExportAzureNativeVirtualMachineJob");
            string parameters = "($input: StartExportAzureNativeVirtualMachineJobInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationStartExportAzureNativeVirtualMachineJob" + parameters + "{" + document + "}",
                OperationName = "MutationStartExportAzureNativeVirtualMachineJob",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncJobStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncJobStatus>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // excludeAzureNativeManagedDisksFromSnapshot(input: ExcludeAzureNativeManagedDisksFromSnapshotInput!): Void
        protected void InvokeMutationExcludeAzureNativeManagedDisksFromSnapshot()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ExcludeAzureNativeManagedDisksFromSnapshotInput!"),
            };
            System.String? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (System.String)psObject.BaseObject;
                } else {
                    fields = (System.String)this.Field;
                }
            }
            string document = Mutation.ExcludeAzureNativeManagedDisksFromSnapshot(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.ExcludeAzureNativeManagedDisksFromSnapshot");
            string parameters = "($input: ExcludeAzureNativeManagedDisksFromSnapshotInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationExcludeAzureNativeManagedDisksFromSnapshot" + parameters + "{" + document + "}",
                OperationName = "MutationExcludeAzureNativeManagedDisksFromSnapshot",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<System.String> task = this._rbkClient.InvokeGenericCallAsync<System.String>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // startCreateAzureNativeVirtualMachineSnapshotsJob(input: StartCreateAzureNativeVirtualMachineSnapshotsJobInput!): BatchAsyncJobStatus!
        protected void InvokeMutationStartCreateAzureNativeVirtualMachineSnapshotsJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartCreateAzureNativeVirtualMachineSnapshotsJobInput!"),
            };
            BatchAsyncJobStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (BatchAsyncJobStatus)psObject.BaseObject;
                } else {
                    fields = (BatchAsyncJobStatus)this.Field;
                }
            }
            string document = Mutation.StartCreateAzureNativeVirtualMachineSnapshotsJob(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.StartCreateAzureNativeVirtualMachineSnapshotsJob");
            string parameters = "($input: StartCreateAzureNativeVirtualMachineSnapshotsJobInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationStartCreateAzureNativeVirtualMachineSnapshotsJob" + parameters + "{" + document + "}",
                OperationName = "MutationStartCreateAzureNativeVirtualMachineSnapshotsJob",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<BatchAsyncJobStatus> task = this._rbkClient.InvokeGenericCallAsync<BatchAsyncJobStatus>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // startDisableAzureNativeSubscriptionProtectionJob(input: StartDisableAzureNativeSubscriptionProtectionJobInput!): AsyncJobStatus!
        protected void InvokeMutationStartDisableAzureNativeSubscriptionProtectionJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartDisableAzureNativeSubscriptionProtectionJobInput!"),
            };
            AsyncJobStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncJobStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncJobStatus)this.Field;
                }
            }
            string document = Mutation.StartDisableAzureNativeSubscriptionProtectionJob(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.StartDisableAzureNativeSubscriptionProtectionJob");
            string parameters = "($input: StartDisableAzureNativeSubscriptionProtectionJobInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationStartDisableAzureNativeSubscriptionProtectionJob" + parameters + "{" + document + "}",
                OperationName = "MutationStartDisableAzureNativeSubscriptionProtectionJob",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncJobStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncJobStatus>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // startCreateAzureNativeManagedDiskSnapshotsJob(input: StartCreateAzureNativeManagedDiskSnapshotsJobInput!): BatchAsyncJobStatus!
        protected void InvokeMutationStartCreateAzureNativeManagedDiskSnapshotsJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartCreateAzureNativeManagedDiskSnapshotsJobInput!"),
            };
            BatchAsyncJobStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (BatchAsyncJobStatus)psObject.BaseObject;
                } else {
                    fields = (BatchAsyncJobStatus)this.Field;
                }
            }
            string document = Mutation.StartCreateAzureNativeManagedDiskSnapshotsJob(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.StartCreateAzureNativeManagedDiskSnapshotsJob");
            string parameters = "($input: StartCreateAzureNativeManagedDiskSnapshotsJobInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationStartCreateAzureNativeManagedDiskSnapshotsJob" + parameters + "{" + document + "}",
                OperationName = "MutationStartCreateAzureNativeManagedDiskSnapshotsJob",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<BatchAsyncJobStatus> task = this._rbkClient.InvokeGenericCallAsync<BatchAsyncJobStatus>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // startExportAzureNativeManagedDiskJob(input: StartExportAzureNativeManagedDiskJobInput!): AsyncJobStatus!
        protected void InvokeMutationStartExportAzureNativeManagedDiskJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartExportAzureNativeManagedDiskJobInput!"),
            };
            AsyncJobStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncJobStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncJobStatus)this.Field;
                }
            }
            string document = Mutation.StartExportAzureNativeManagedDiskJob(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.StartExportAzureNativeManagedDiskJob");
            string parameters = "($input: StartExportAzureNativeManagedDiskJobInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationStartExportAzureNativeManagedDiskJob" + parameters + "{" + document + "}",
                OperationName = "MutationStartExportAzureNativeManagedDiskJob",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncJobStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncJobStatus>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // startExportAzureSqlDatabaseDbJob(input: StartExportAzureSqlDatabaseDbJobInput!): AsyncJobStatus!
        protected void InvokeMutationStartExportAzureSqlDatabaseDbJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartExportAzureSqlDatabaseDbJobInput!"),
            };
            AsyncJobStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncJobStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncJobStatus)this.Field;
                }
            }
            string document = Mutation.StartExportAzureSqlDatabaseDbJob(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.StartExportAzureSqlDatabaseDbJob");
            string parameters = "($input: StartExportAzureSqlDatabaseDbJobInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationStartExportAzureSqlDatabaseDbJob" + parameters + "{" + document + "}",
                OperationName = "MutationStartExportAzureSqlDatabaseDbJob",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncJobStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncJobStatus>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // startExportAzureSqlManagedInstanceDbJob(input: StartExportAzureSqlManagedInstanceDbJobInput!): AsyncJobStatus!
        protected void InvokeMutationStartExportAzureSqlManagedInstanceDbJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartExportAzureSqlManagedInstanceDbJobInput!"),
            };
            AsyncJobStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncJobStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncJobStatus)this.Field;
                }
            }
            string document = Mutation.StartExportAzureSqlManagedInstanceDbJob(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.StartExportAzureSqlManagedInstanceDbJob");
            string parameters = "($input: StartExportAzureSqlManagedInstanceDbJobInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationStartExportAzureSqlManagedInstanceDbJob" + parameters + "{" + document + "}",
                OperationName = "MutationStartExportAzureSqlManagedInstanceDbJob",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncJobStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncJobStatus>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // createAzureAccount(input: CreateAzureAccountInput!): CloudAccount!
        protected void InvokeMutationCreateAzureAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAzureAccountInput!"),
            };
            CloudAccount? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (CloudAccount)psObject.BaseObject;
                } else {
                    fields = (CloudAccount)this.Field;
                }
            }
            string document = Mutation.CreateAzureAccount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateAzureAccount");
            string parameters = "($input: CreateAzureAccountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateAzureAccount" + parameters + "{" + document + "}",
                OperationName = "MutationCreateAzureAccount",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<CloudAccount> task = this._rbkClient.InvokeGenericCallAsync<CloudAccount>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // updateAzureAccount(input: UpdateAzureAccountInput!): CloudAccount!
        protected void InvokeMutationUpdateAzureAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAzureAccountInput!"),
            };
            CloudAccount? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (CloudAccount)psObject.BaseObject;
                } else {
                    fields = (CloudAccount)this.Field;
                }
            }
            string document = Mutation.UpdateAzureAccount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateAzureAccount");
            string parameters = "($input: UpdateAzureAccountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateAzureAccount" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateAzureAccount",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<CloudAccount> task = this._rbkClient.InvokeGenericCallAsync<CloudAccount>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // createAutomaticAzureTargetMapping(input: CreateAutomaticAzureTargetMappingInput!): TargetMapping!
        protected void InvokeMutationCreateAutomaticAzureTargetMapping()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAutomaticAzureTargetMappingInput!"),
            };
            TargetMapping? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (TargetMapping)psObject.BaseObject;
                } else {
                    fields = (TargetMapping)this.Field;
                }
            }
            string document = Mutation.CreateAutomaticAzureTargetMapping(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateAutomaticAzureTargetMapping");
            string parameters = "($input: CreateAutomaticAzureTargetMappingInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateAutomaticAzureTargetMapping" + parameters + "{" + document + "}",
                OperationName = "MutationCreateAutomaticAzureTargetMapping",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<TargetMapping> task = this._rbkClient.InvokeGenericCallAsync<TargetMapping>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // createCloudNativeAzureStorageSetting(input: CreateCloudNativeAzureStorageSettingInput!): CreateCloudNativeAzureStorageSettingReply!
        protected void InvokeMutationCreateCloudNativeAzureStorageSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateCloudNativeAzureStorageSettingInput!"),
            };
            CreateCloudNativeAzureStorageSettingReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (CreateCloudNativeAzureStorageSettingReply)psObject.BaseObject;
                } else {
                    fields = (CreateCloudNativeAzureStorageSettingReply)this.Field;
                }
            }
            string document = Mutation.CreateCloudNativeAzureStorageSetting(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateCloudNativeAzureStorageSetting");
            string parameters = "($input: CreateCloudNativeAzureStorageSettingInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateCloudNativeAzureStorageSetting" + parameters + "{" + document + "}",
                OperationName = "MutationCreateCloudNativeAzureStorageSetting",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<CreateCloudNativeAzureStorageSettingReply> task = this._rbkClient.InvokeGenericCallAsync<CreateCloudNativeAzureStorageSettingReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // createCloudNativeRcvAzureStorageSetting(input: CreateCloudNativeRcvAzureStorageSettingInput!): CreateCloudNativeRcvAzureStorageSettingReply!
        protected void InvokeMutationCreateCloudNativeRcvAzureStorageSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateCloudNativeRcvAzureStorageSettingInput!"),
            };
            CreateCloudNativeRcvAzureStorageSettingReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (CreateCloudNativeRcvAzureStorageSettingReply)psObject.BaseObject;
                } else {
                    fields = (CreateCloudNativeRcvAzureStorageSettingReply)this.Field;
                }
            }
            string document = Mutation.CreateCloudNativeRcvAzureStorageSetting(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateCloudNativeRcvAzureStorageSetting");
            string parameters = "($input: CreateCloudNativeRcvAzureStorageSettingInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateCloudNativeRcvAzureStorageSetting" + parameters + "{" + document + "}",
                OperationName = "MutationCreateCloudNativeRcvAzureStorageSetting",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<CreateCloudNativeRcvAzureStorageSettingReply> task = this._rbkClient.InvokeGenericCallAsync<CreateCloudNativeRcvAzureStorageSettingReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // updateAutomaticAzureTargetMapping(input: UpdateAutomaticAzureTargetMappingInput!): TargetMapping!
        protected void InvokeMutationUpdateAutomaticAzureTargetMapping()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAutomaticAzureTargetMappingInput!"),
            };
            TargetMapping? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (TargetMapping)psObject.BaseObject;
                } else {
                    fields = (TargetMapping)this.Field;
                }
            }
            string document = Mutation.UpdateAutomaticAzureTargetMapping(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateAutomaticAzureTargetMapping");
            string parameters = "($input: UpdateAutomaticAzureTargetMappingInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateAutomaticAzureTargetMapping" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateAutomaticAzureTargetMapping",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<TargetMapping> task = this._rbkClient.InvokeGenericCallAsync<TargetMapping>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // updateCloudNativeAzureStorageSetting(input: UpdateCloudNativeAzureStorageSettingInput!): UpdateCloudNativeAzureStorageSettingReply!
        protected void InvokeMutationUpdateCloudNativeAzureStorageSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateCloudNativeAzureStorageSettingInput!"),
            };
            UpdateCloudNativeAzureStorageSettingReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (UpdateCloudNativeAzureStorageSettingReply)psObject.BaseObject;
                } else {
                    fields = (UpdateCloudNativeAzureStorageSettingReply)this.Field;
                }
            }
            string document = Mutation.UpdateCloudNativeAzureStorageSetting(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateCloudNativeAzureStorageSetting");
            string parameters = "($input: UpdateCloudNativeAzureStorageSettingInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateCloudNativeAzureStorageSetting" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateCloudNativeAzureStorageSetting",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<UpdateCloudNativeAzureStorageSettingReply> task = this._rbkClient.InvokeGenericCallAsync<UpdateCloudNativeAzureStorageSettingReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // updateCloudNativeRcvAzureStorageSetting(input: UpdateCloudNativeRcvAzureStorageSettingInput!): UpdateCloudNativeRcvAzureStorageSettingReply!
        protected void InvokeMutationUpdateCloudNativeRcvAzureStorageSetting()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateCloudNativeRcvAzureStorageSettingInput!"),
            };
            UpdateCloudNativeRcvAzureStorageSettingReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (UpdateCloudNativeRcvAzureStorageSettingReply)psObject.BaseObject;
                } else {
                    fields = (UpdateCloudNativeRcvAzureStorageSettingReply)this.Field;
                }
            }
            string document = Mutation.UpdateCloudNativeRcvAzureStorageSetting(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateCloudNativeRcvAzureStorageSetting");
            string parameters = "($input: UpdateCloudNativeRcvAzureStorageSettingInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateCloudNativeRcvAzureStorageSetting" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateCloudNativeRcvAzureStorageSetting",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<UpdateCloudNativeRcvAzureStorageSettingReply> task = this._rbkClient.InvokeGenericCallAsync<UpdateCloudNativeRcvAzureStorageSettingReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // createAzureTarget(input: CreateAzureTargetInput!): Target!
        protected void InvokeMutationCreateAzureTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAzureTargetInput!"),
            };
            Target? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (Target)psObject.BaseObject;
                } else {
                    fields = (Target)this.Field;
                }
            }
            string document = Mutation.CreateAzureTarget(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateAzureTarget");
            string parameters = "($input: CreateAzureTargetInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateAzureTarget" + parameters + "{" + document + "}",
                OperationName = "MutationCreateAzureTarget",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<Target> task = this._rbkClient.InvokeGenericCallAsync<Target>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // updateAzureTarget(input: UpdateAzureTargetInput!): Target!
        protected void InvokeMutationUpdateAzureTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAzureTargetInput!"),
            };
            Target? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (Target)psObject.BaseObject;
                } else {
                    fields = (Target)this.Field;
                }
            }
            string document = Mutation.UpdateAzureTarget(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateAzureTarget");
            string parameters = "($input: UpdateAzureTargetInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateAzureTarget" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateAzureTarget",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<Target> task = this._rbkClient.InvokeGenericCallAsync<Target>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // createAzureReaderTarget(input: CreateAzureReaderTargetInput!): Target!
        protected void InvokeMutationCreateAzureReaderTarget()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAzureReaderTargetInput!"),
            };
            Target? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (Target)psObject.BaseObject;
                } else {
                    fields = (Target)this.Field;
                }
            }
            string document = Mutation.CreateAzureReaderTarget(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateAzureReaderTarget");
            string parameters = "($input: CreateAzureReaderTargetInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateAzureReaderTarget" + parameters + "{" + document + "}",
                OperationName = "MutationCreateAzureReaderTarget",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<Target> task = this._rbkClient.InvokeGenericCallAsync<Target>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // startAzureCloudAccountOauth(input: StartAzureCloudAccountOauthInput!): StartAzureCloudAccountOauthReply!
        protected void InvokeMutationStartAzureCloudAccountOauth()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartAzureCloudAccountOauthInput!"),
            };
            StartAzureCloudAccountOauthReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (StartAzureCloudAccountOauthReply)psObject.BaseObject;
                } else {
                    fields = (StartAzureCloudAccountOauthReply)this.Field;
                }
            }
            string document = Mutation.StartAzureCloudAccountOauth(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.StartAzureCloudAccountOauth");
            string parameters = "($input: StartAzureCloudAccountOauthInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationStartAzureCloudAccountOauth" + parameters + "{" + document + "}",
                OperationName = "MutationStartAzureCloudAccountOauth",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<StartAzureCloudAccountOauthReply> task = this._rbkClient.InvokeGenericCallAsync<StartAzureCloudAccountOauthReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // completeAzureCloudAccountOauth(input: CompleteAzureCloudAccountOauthInput!): CompleteAzureCloudAccountOauthReply!
        protected void InvokeMutationCompleteAzureCloudAccountOauth()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CompleteAzureCloudAccountOauthInput!"),
            };
            CompleteAzureCloudAccountOauthReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (CompleteAzureCloudAccountOauthReply)psObject.BaseObject;
                } else {
                    fields = (CompleteAzureCloudAccountOauthReply)this.Field;
                }
            }
            string document = Mutation.CompleteAzureCloudAccountOauth(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CompleteAzureCloudAccountOauth");
            string parameters = "($input: CompleteAzureCloudAccountOauthInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCompleteAzureCloudAccountOauth" + parameters + "{" + document + "}",
                OperationName = "MutationCompleteAzureCloudAccountOauth",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<CompleteAzureCloudAccountOauthReply> task = this._rbkClient.InvokeGenericCallAsync<CompleteAzureCloudAccountOauthReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // setAzureCloudAccountCustomerAppCredentials(input: SetAzureCloudAccountCustomerAppCredentialsInput!): Boolean!
        protected void InvokeMutationSetAzureCloudAccountCustomerAppCredentials()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SetAzureCloudAccountCustomerAppCredentialsInput!"),
            };
            System.Boolean? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (System.Boolean)psObject.BaseObject;
                } else {
                    fields = (System.Boolean)this.Field;
                }
            }
            string document = Mutation.SetAzureCloudAccountCustomerAppCredentials(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.SetAzureCloudAccountCustomerAppCredentials");
            string parameters = "($input: SetAzureCloudAccountCustomerAppCredentialsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationSetAzureCloudAccountCustomerAppCredentials" + parameters + "{" + document + "}",
                OperationName = "MutationSetAzureCloudAccountCustomerAppCredentials",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<System.Boolean> task = this._rbkClient.InvokeGenericCallAsync<System.Boolean>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // addAzureCloudAccount(input: AddAzureCloudAccountInput!): AddAzureCloudAccountReply!
        protected void InvokeMutationAddAzureCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddAzureCloudAccountInput!"),
            };
            AddAzureCloudAccountReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AddAzureCloudAccountReply)psObject.BaseObject;
                } else {
                    fields = (AddAzureCloudAccountReply)this.Field;
                }
            }
            string document = Mutation.AddAzureCloudAccount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.AddAzureCloudAccount");
            string parameters = "($input: AddAzureCloudAccountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationAddAzureCloudAccount" + parameters + "{" + document + "}",
                OperationName = "MutationAddAzureCloudAccount",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AddAzureCloudAccountReply> task = this._rbkClient.InvokeGenericCallAsync<AddAzureCloudAccountReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // addAzureCloudAccountWithoutOauth(input: AddAzureCloudAccountWithoutOauthInput!): AddAzureCloudAccountWithoutOauthReply!
        protected void InvokeMutationAddAzureCloudAccountWithoutOauth()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddAzureCloudAccountWithoutOauthInput!"),
            };
            AddAzureCloudAccountWithoutOauthReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AddAzureCloudAccountWithoutOauthReply)psObject.BaseObject;
                } else {
                    fields = (AddAzureCloudAccountWithoutOauthReply)this.Field;
                }
            }
            string document = Mutation.AddAzureCloudAccountWithoutOauth(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.AddAzureCloudAccountWithoutOauth");
            string parameters = "($input: AddAzureCloudAccountWithoutOauthInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationAddAzureCloudAccountWithoutOauth" + parameters + "{" + document + "}",
                OperationName = "MutationAddAzureCloudAccountWithoutOauth",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AddAzureCloudAccountWithoutOauthReply> task = this._rbkClient.InvokeGenericCallAsync<AddAzureCloudAccountWithoutOauthReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // deleteAzureCloudAccount(input: DeleteAzureCloudAccountInput!): DeleteAzureCloudAccountReply!
        protected void InvokeMutationDeleteAzureCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAzureCloudAccountInput!"),
            };
            DeleteAzureCloudAccountReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (DeleteAzureCloudAccountReply)psObject.BaseObject;
                } else {
                    fields = (DeleteAzureCloudAccountReply)this.Field;
                }
            }
            string document = Mutation.DeleteAzureCloudAccount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteAzureCloudAccount");
            string parameters = "($input: DeleteAzureCloudAccountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteAzureCloudAccount" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteAzureCloudAccount",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<DeleteAzureCloudAccountReply> task = this._rbkClient.InvokeGenericCallAsync<DeleteAzureCloudAccountReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // deleteAzureCloudAccountWithoutOauth(input: DeleteAzureCloudAccountWithoutOauthInput!): DeleteAzureCloudAccountWithoutOauthReply!
        protected void InvokeMutationDeleteAzureCloudAccountWithoutOauth()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAzureCloudAccountWithoutOauthInput!"),
            };
            DeleteAzureCloudAccountWithoutOauthReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (DeleteAzureCloudAccountWithoutOauthReply)psObject.BaseObject;
                } else {
                    fields = (DeleteAzureCloudAccountWithoutOauthReply)this.Field;
                }
            }
            string document = Mutation.DeleteAzureCloudAccountWithoutOauth(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteAzureCloudAccountWithoutOauth");
            string parameters = "($input: DeleteAzureCloudAccountWithoutOauthInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteAzureCloudAccountWithoutOauth" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteAzureCloudAccountWithoutOauth",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<DeleteAzureCloudAccountWithoutOauthReply> task = this._rbkClient.InvokeGenericCallAsync<DeleteAzureCloudAccountWithoutOauthReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // upgradeAzureCloudAccount(input: UpgradeAzureCloudAccountInput!): UpgradeAzureCloudAccountReply!
        protected void InvokeMutationUpgradeAzureCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpgradeAzureCloudAccountInput!"),
            };
            UpgradeAzureCloudAccountReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (UpgradeAzureCloudAccountReply)psObject.BaseObject;
                } else {
                    fields = (UpgradeAzureCloudAccountReply)this.Field;
                }
            }
            string document = Mutation.UpgradeAzureCloudAccount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpgradeAzureCloudAccount");
            string parameters = "($input: UpgradeAzureCloudAccountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpgradeAzureCloudAccount" + parameters + "{" + document + "}",
                OperationName = "MutationUpgradeAzureCloudAccount",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<UpgradeAzureCloudAccountReply> task = this._rbkClient.InvokeGenericCallAsync<UpgradeAzureCloudAccountReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // updateCustomerAppPermissionForAzureSql: Void
        protected void InvokeMutationUpdateCustomerAppPermissionForAzureSql()
        {
            Tuple<string, string>[] argDefs = {
            };
            System.String? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (System.String)psObject.BaseObject;
                } else {
                    fields = (System.String)this.Field;
                }
            }
            string document = Mutation.UpdateCustomerAppPermissionForAzureSql(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateCustomerAppPermissionForAzureSql");
            string parameters = "";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateCustomerAppPermissionForAzureSql" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateCustomerAppPermissionForAzureSql",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            Task<System.String> task = this._rbkClient.InvokeGenericCallAsync<System.String>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // startDisableAzureCloudAccountJob(input: StartDisableAzureCloudAccountJobInput!): BatchAsyncJobStatus!
        protected void InvokeMutationStartDisableAzureCloudAccountJob()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "StartDisableAzureCloudAccountJobInput!"),
            };
            BatchAsyncJobStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (BatchAsyncJobStatus)psObject.BaseObject;
                } else {
                    fields = (BatchAsyncJobStatus)this.Field;
                }
            }
            string document = Mutation.StartDisableAzureCloudAccountJob(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.StartDisableAzureCloudAccountJob");
            string parameters = "($input: StartDisableAzureCloudAccountJobInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationStartDisableAzureCloudAccountJob" + parameters + "{" + document + "}",
                OperationName = "MutationStartDisableAzureCloudAccountJob",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<BatchAsyncJobStatus> task = this._rbkClient.InvokeGenericCallAsync<BatchAsyncJobStatus>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // updateAzureCloudAccount(input: UpdateAzureCloudAccountInput!): UpdateAzureCloudAccountReply!
        protected void InvokeMutationUpdateAzureCloudAccount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpdateAzureCloudAccountInput!"),
            };
            UpdateAzureCloudAccountReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (UpdateAzureCloudAccountReply)psObject.BaseObject;
                } else {
                    fields = (UpdateAzureCloudAccountReply)this.Field;
                }
            }
            string document = Mutation.UpdateAzureCloudAccount(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpdateAzureCloudAccount");
            string parameters = "($input: UpdateAzureCloudAccountInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpdateAzureCloudAccount" + parameters + "{" + document + "}",
                OperationName = "MutationUpdateAzureCloudAccount",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<UpdateAzureCloudAccountReply> task = this._rbkClient.InvokeGenericCallAsync<UpdateAzureCloudAccountReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // mapAzureCloudAccountToPersistentStorageLocation(input: MapAzureCloudAccountToPersistentStorageLocationInput!): MapAzureCloudAccountToPersistentStorageLocationReply!
        protected void InvokeMutationMapAzureCloudAccountToPersistentStorageLocation()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MapAzureCloudAccountToPersistentStorageLocationInput!"),
            };
            MapAzureCloudAccountToPersistentStorageLocationReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (MapAzureCloudAccountToPersistentStorageLocationReply)psObject.BaseObject;
                } else {
                    fields = (MapAzureCloudAccountToPersistentStorageLocationReply)this.Field;
                }
            }
            string document = Mutation.MapAzureCloudAccountToPersistentStorageLocation(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.MapAzureCloudAccountToPersistentStorageLocation");
            string parameters = "($input: MapAzureCloudAccountToPersistentStorageLocationInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationMapAzureCloudAccountToPersistentStorageLocation" + parameters + "{" + document + "}",
                OperationName = "MutationMapAzureCloudAccountToPersistentStorageLocation",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<MapAzureCloudAccountToPersistentStorageLocationReply> task = this._rbkClient.InvokeGenericCallAsync<MapAzureCloudAccountToPersistentStorageLocationReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // addAzureCloudAccountExocomputeConfigurations(input: AddAzureCloudAccountExocomputeConfigurationsInput!): AddAzureCloudAccountExocomputeConfigurationsReply!
        protected void InvokeMutationAddAzureCloudAccountExocomputeConfigurations()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AddAzureCloudAccountExocomputeConfigurationsInput!"),
            };
            AddAzureCloudAccountExocomputeConfigurationsReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AddAzureCloudAccountExocomputeConfigurationsReply)psObject.BaseObject;
                } else {
                    fields = (AddAzureCloudAccountExocomputeConfigurationsReply)this.Field;
                }
            }
            string document = Mutation.AddAzureCloudAccountExocomputeConfigurations(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.AddAzureCloudAccountExocomputeConfigurations");
            string parameters = "($input: AddAzureCloudAccountExocomputeConfigurationsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationAddAzureCloudAccountExocomputeConfigurations" + parameters + "{" + document + "}",
                OperationName = "MutationAddAzureCloudAccountExocomputeConfigurations",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AddAzureCloudAccountExocomputeConfigurationsReply> task = this._rbkClient.InvokeGenericCallAsync<AddAzureCloudAccountExocomputeConfigurationsReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // deleteAzureCloudAccountExocomputeConfigurations(input: DeleteAzureCloudAccountExocomputeConfigurationsInput!): DeleteAzureCloudAccountExocomputeConfigurationsReply!
        protected void InvokeMutationDeleteAzureCloudAccountExocomputeConfigurations()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAzureCloudAccountExocomputeConfigurationsInput!"),
            };
            DeleteAzureCloudAccountExocomputeConfigurationsReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (DeleteAzureCloudAccountExocomputeConfigurationsReply)psObject.BaseObject;
                } else {
                    fields = (DeleteAzureCloudAccountExocomputeConfigurationsReply)this.Field;
                }
            }
            string document = Mutation.DeleteAzureCloudAccountExocomputeConfigurations(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteAzureCloudAccountExocomputeConfigurations");
            string parameters = "($input: DeleteAzureCloudAccountExocomputeConfigurationsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteAzureCloudAccountExocomputeConfigurations" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteAzureCloudAccountExocomputeConfigurations",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<DeleteAzureCloudAccountExocomputeConfigurationsReply> task = this._rbkClient.InvokeGenericCallAsync<DeleteAzureCloudAccountExocomputeConfigurationsReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // mapAzureCloudAccountExocomputeSubscription(input: MapAzureCloudAccountExocomputeSubscriptionInput!): MapAzureCloudAccountExocomputeSubscriptionReply!
        protected void InvokeMutationMapAzureCloudAccountExocomputeSubscription()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "MapAzureCloudAccountExocomputeSubscriptionInput!"),
            };
            MapAzureCloudAccountExocomputeSubscriptionReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (MapAzureCloudAccountExocomputeSubscriptionReply)psObject.BaseObject;
                } else {
                    fields = (MapAzureCloudAccountExocomputeSubscriptionReply)this.Field;
                }
            }
            string document = Mutation.MapAzureCloudAccountExocomputeSubscription(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.MapAzureCloudAccountExocomputeSubscription");
            string parameters = "($input: MapAzureCloudAccountExocomputeSubscriptionInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationMapAzureCloudAccountExocomputeSubscription" + parameters + "{" + document + "}",
                OperationName = "MutationMapAzureCloudAccountExocomputeSubscription",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<MapAzureCloudAccountExocomputeSubscriptionReply> task = this._rbkClient.InvokeGenericCallAsync<MapAzureCloudAccountExocomputeSubscriptionReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // unmapAzureCloudAccountExocomputeSubscription(input: UnmapAzureCloudAccountExocomputeSubscriptionInput!): UnmapAzureCloudAccountExocomputeSubscriptionReply!
        protected void InvokeMutationUnmapAzureCloudAccountExocomputeSubscription()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UnmapAzureCloudAccountExocomputeSubscriptionInput!"),
            };
            UnmapAzureCloudAccountExocomputeSubscriptionReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (UnmapAzureCloudAccountExocomputeSubscriptionReply)psObject.BaseObject;
                } else {
                    fields = (UnmapAzureCloudAccountExocomputeSubscriptionReply)this.Field;
                }
            }
            string document = Mutation.UnmapAzureCloudAccountExocomputeSubscription(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UnmapAzureCloudAccountExocomputeSubscription");
            string parameters = "($input: UnmapAzureCloudAccountExocomputeSubscriptionInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUnmapAzureCloudAccountExocomputeSubscription" + parameters + "{" + document + "}",
                OperationName = "MutationUnmapAzureCloudAccountExocomputeSubscription",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<UnmapAzureCloudAccountExocomputeSubscriptionReply> task = this._rbkClient.InvokeGenericCallAsync<UnmapAzureCloudAccountExocomputeSubscriptionReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // upgradeAzureCloudAccountPermissionsWithoutOauth(input: UpgradeAzureCloudAccountPermissionsWithoutOauthInput!): UpgradeAzureCloudAccountPermissionsWithoutOauthReply!
        protected void InvokeMutationUpgradeAzureCloudAccountPermissionsWithoutOauth()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "UpgradeAzureCloudAccountPermissionsWithoutOauthInput!"),
            };
            UpgradeAzureCloudAccountPermissionsWithoutOauthReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (UpgradeAzureCloudAccountPermissionsWithoutOauthReply)psObject.BaseObject;
                } else {
                    fields = (UpgradeAzureCloudAccountPermissionsWithoutOauthReply)this.Field;
                }
            }
            string document = Mutation.UpgradeAzureCloudAccountPermissionsWithoutOauth(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.UpgradeAzureCloudAccountPermissionsWithoutOauth");
            string parameters = "($input: UpgradeAzureCloudAccountPermissionsWithoutOauthInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationUpgradeAzureCloudAccountPermissionsWithoutOauth" + parameters + "{" + document + "}",
                OperationName = "MutationUpgradeAzureCloudAccountPermissionsWithoutOauth",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<UpgradeAzureCloudAccountPermissionsWithoutOauthReply> task = this._rbkClient.InvokeGenericCallAsync<UpgradeAzureCloudAccountPermissionsWithoutOauthReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // azureOauthConsentKickoff: AzureOauthConsentKickoffReply!
        protected void InvokeMutationAzureOauthConsentKickoff()
        {
            Tuple<string, string>[] argDefs = {
            };
            AzureOauthConsentKickoffReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AzureOauthConsentKickoffReply)psObject.BaseObject;
                } else {
                    fields = (AzureOauthConsentKickoffReply)this.Field;
                }
            }
            string document = Mutation.AzureOauthConsentKickoff(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.AzureOauthConsentKickoff");
            string parameters = "";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationAzureOauthConsentKickoff" + parameters + "{" + document + "}",
                OperationName = "MutationAzureOauthConsentKickoff",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            Task<AzureOauthConsentKickoffReply> task = this._rbkClient.InvokeGenericCallAsync<AzureOauthConsentKickoffReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // azureOauthConsentComplete(input: AzureOauthConsentCompleteInput!): RequestStatus!
        protected void InvokeMutationAzureOauthConsentComplete()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "AzureOauthConsentCompleteInput!"),
            };
            RequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (RequestStatus)psObject.BaseObject;
                } else {
                    fields = (RequestStatus)this.Field;
                }
            }
            string document = Mutation.AzureOauthConsentComplete(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.AzureOauthConsentComplete");
            string parameters = "($input: AzureOauthConsentCompleteInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationAzureOauthConsentComplete" + parameters + "{" + document + "}",
                OperationName = "MutationAzureOauthConsentComplete",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<RequestStatus> task = this._rbkClient.InvokeGenericCallAsync<RequestStatus>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // createAzureSaasAppAad: CreateAzureSaasAppAadReply!
        protected void InvokeMutationCreateAzureSaasAppAad()
        {
            Tuple<string, string>[] argDefs = {
            };
            CreateAzureSaasAppAadReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (CreateAzureSaasAppAadReply)psObject.BaseObject;
                } else {
                    fields = (CreateAzureSaasAppAadReply)this.Field;
                }
            }
            string document = Mutation.CreateAzureSaasAppAad(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateAzureSaasAppAad");
            string parameters = "";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateAzureSaasAppAad" + parameters + "{" + document + "}",
                OperationName = "MutationCreateAzureSaasAppAad",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            Task<CreateAzureSaasAppAadReply> task = this._rbkClient.InvokeGenericCallAsync<CreateAzureSaasAppAadReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // createAzureCluster(input: CreateAzureClusterInput!): CcProvisionJobReply!
        protected void InvokeMutationCreateAzureCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CreateAzureClusterInput!"),
            };
            CcProvisionJobReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (CcProvisionJobReply)psObject.BaseObject;
                } else {
                    fields = (CcProvisionJobReply)this.Field;
                }
            }
            string document = Mutation.CreateAzureCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.CreateAzureCluster");
            string parameters = "($input: CreateAzureClusterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationCreateAzureCluster" + parameters + "{" + document + "}",
                OperationName = "MutationCreateAzureCluster",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<CcProvisionJobReply> task = this._rbkClient.InvokeGenericCallAsync<CcProvisionJobReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Mutation:
        // deleteAzureCluster(input: DeleteAzureClusterInput!): CcProvisionJobReply!
        protected void InvokeMutationDeleteAzureCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "DeleteAzureClusterInput!"),
            };
            CcProvisionJobReply? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (CcProvisionJobReply)psObject.BaseObject;
                } else {
                    fields = (CcProvisionJobReply)this.Field;
                }
            }
            string document = Mutation.DeleteAzureCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Mutation.DeleteAzureCluster");
            string parameters = "($input: DeleteAzureClusterInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "mutation MutationDeleteAzureCluster" + parameters + "{" + document + "}",
                OperationName = "MutationDeleteAzureCluster",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<CcProvisionJobReply> task = this._rbkClient.InvokeGenericCallAsync<CcProvisionJobReply>(request, vars, this._logger, GetMetricTags());
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }


    } // class Invoke_RscMutateAzure
}