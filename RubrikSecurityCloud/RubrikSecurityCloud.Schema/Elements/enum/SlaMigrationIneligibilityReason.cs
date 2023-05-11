// SlaMigrationIneligibilityReason.cs
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
    public enum SlaMigrationIneligibilityReason
    {
        [EnumMember(Value = "CASCADED_ARCHIVAL_CONFIGURED")]
        CASCADED_ARCHIVAL_CONFIGURED,

        [EnumMember(Value = "CLUSTER_DISCONNECTED")]
        CLUSTER_DISCONNECTED,

        [EnumMember(Value = "INVALID_CASCADING_ARCHIVAL_VERSION")]
        INVALID_CASCADING_ARCHIVAL_VERSION,

        [EnumMember(Value = "INVALID_CLUSTER_VERSION")]
        INVALID_CLUSTER_VERSION,

        [EnumMember(Value = "INVALID_LOCAL_SLA")]
        INVALID_LOCAL_SLA,

        [EnumMember(Value = "INVALID_REPLICATION_TARGET")]
        INVALID_REPLICATION_TARGET,

        [EnumMember(Value = "INVALID_REPLICATION_TARGET_VERSION")]
        INVALID_REPLICATION_TARGET_VERSION,

        [EnumMember(Value = "MINUTE_FREQUENCY_CONFIGURED")]
        MINUTE_FREQUENCY_CONFIGURED,

        [EnumMember(Value = "NOT_APPLICABLE")]
        NOT_APPLICABLE,

        [EnumMember(Value = "REPLICATION_TARGET_DISCONNECTED")]
        REPLICATION_TARGET_DISCONNECTED,

        [EnumMember(Value = "RETENTION_LOCK_CONFIGURED")]
        RETENTION_LOCK_CONFIGURED,

        [EnumMember(Value = "TPR_ENABLED_ON_CLUSTER")]
        TPR_ENABLED_ON_CLUSTER,

        [EnumMember(Value = "UNSUPPORTED_PROTECTED_OBJECTS")]
        UNSUPPORTED_PROTECTED_OBJECTS,

        [EnumMember(Value = "UNSUPPORTED_PROTECTED_OBJECTS_MINUTE_FREQUENCY_CONFIGURED")]
        UNSUPPORTED_PROTECTED_OBJECTS_MINUTE_FREQUENCY_CONFIGURED


    } // enum SlaMigrationIneligibilityReason

} // namespace Rubrik.SecurityCloud.Types