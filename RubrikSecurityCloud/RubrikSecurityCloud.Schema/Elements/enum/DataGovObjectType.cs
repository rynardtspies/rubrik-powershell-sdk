// DataGovObjectType.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Rubrik.SecurityCloud.Types
{
    public enum DataGovObjectType
    {
        [EnumMember(Value = "AZURE_NATIVE_MANAGED_DISK")]
        AZURE_NATIVE_MANAGED_DISK,

        [EnumMember(Value = "AZURE_NATIVE_ROOT")]
        AZURE_NATIVE_ROOT,

        [EnumMember(Value = "AZURE_NATIVE_VIRTUAL_MACHINE")]
        AZURE_NATIVE_VIRTUAL_MACHINE,

        [EnumMember(Value = "AZURE_RESOURCE_GROUP")]
        AZURE_RESOURCE_GROUP,

        [EnumMember(Value = "AZURE_SUBSCRIPTION")]
        AZURE_SUBSCRIPTION,

        [EnumMember(Value = "CDM")]
        CDM,

        [EnumMember(Value = "CDM_CLUSTER")]
        CDM_CLUSTER,

        [EnumMember(Value = "CLOUD_DIRECT_NAS_EXPORT")]
        CLOUD_DIRECT_NAS_EXPORT,

        [EnumMember(Value = "CLOUD_NATIVE_TAG_RULE")]
        CLOUD_NATIVE_TAG_RULE,

        [EnumMember(Value = "HYPERV_CLUSTER")]
        HYPERV_CLUSTER,

        [EnumMember(Value = "HYPERV_ROOT")]
        HYPERV_ROOT,

        [EnumMember(Value = "HYPERV_VIRTUAL_MACHINE")]
        HYPERV_VIRTUAL_MACHINE,

        [EnumMember(Value = "LINUX_FILESET")]
        LINUX_FILESET,

        [EnumMember(Value = "LINUX_HOST_ROOT")]
        LINUX_HOST_ROOT,

        [EnumMember(Value = "NAS_FILESET")]
        NAS_FILESET,

        [EnumMember(Value = "NUTANIX_CLUSTER")]
        NUTANIX_CLUSTER,

        [EnumMember(Value = "NUTANIX_ROOT")]
        NUTANIX_ROOT,

        [EnumMember(Value = "NUTANIX_VIRTUAL_MACHINE")]
        NUTANIX_VIRTUAL_MACHINE,

        [EnumMember(Value = "O365_GROUP")]
        O365_GROUP,

        [EnumMember(Value = "O365_ONEDRIVE")]
        O365_ONEDRIVE,

        [EnumMember(Value = "O365_ORGANIZATION")]
        O365_ORGANIZATION,

        [EnumMember(Value = "O365_ROOT")]
        O365_ROOT,

        [EnumMember(Value = "O365_SHAREPOINT_DRIVE")]
        O365_SHAREPOINT_DRIVE,

        [EnumMember(Value = "O365_SHAREPOINT_SITE")]
        O365_SHAREPOINT_SITE,

        [EnumMember(Value = "OBJECT_TYPE_UNSPECIFIED")]
        OBJECT_TYPE_UNSPECIFIED,

        [EnumMember(Value = "PHYSICAL_HOST")]
        PHYSICAL_HOST,

        [EnumMember(Value = "SHARE_FILESET")]
        SHARE_FILESET,

        [EnumMember(Value = "VOLUME_GROUP")]
        VOLUME_GROUP,

        [EnumMember(Value = "VSPHERE_COMPUTE_CLUSTER")]
        VSPHERE_COMPUTE_CLUSTER,

        [EnumMember(Value = "VSPHERE_FOLDER")]
        VSPHERE_FOLDER,

        [EnumMember(Value = "VSPHERE_ROOT")]
        VSPHERE_ROOT,

        [EnumMember(Value = "VSPHERE_TAG")]
        VSPHERE_TAG,

        [EnumMember(Value = "VSPHERE_VCENTER")]
        VSPHERE_VCENTER,

        [EnumMember(Value = "VSPHERE_VIRTUAL_MACHINE")]
        VSPHERE_VIRTUAL_MACHINE,

        [EnumMember(Value = "WINDOWS_FILESET")]
        WINDOWS_FILESET,

        [EnumMember(Value = "WINDOWS_HOST_ROOT")]
        WINDOWS_HOST_ROOT


    } // enum DataGovObjectType

} // namespace Rubrik.SecurityCloud.Types