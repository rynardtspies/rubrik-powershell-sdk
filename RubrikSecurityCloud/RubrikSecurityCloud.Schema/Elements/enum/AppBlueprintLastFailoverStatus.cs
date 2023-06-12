// AppBlueprintLastFailoverStatus.cs
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
    public enum AppBlueprintLastFailoverStatus
    {
        [EnumMember(Value = "Failed")]
        FAILED,

        [EnumMember(Value = "NotExist")]
        NOT_EXIST,

        [EnumMember(Value = "Succeeded")]
        SUCCEEDED


    } // enum AppBlueprintLastFailoverStatus

} // namespace Rubrik.SecurityCloud.Types