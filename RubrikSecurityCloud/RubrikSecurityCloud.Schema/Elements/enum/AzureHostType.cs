// AzureHostType.cs
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
    public enum AzureHostType
    {
        [EnumMember(Value = "BOTH_HOSTS")]
        BOTH_HOSTS,

        [EnumMember(Value = "CUSTOMER_HOST")]
        CUSTOMER_HOST,

        [EnumMember(Value = "RUBRIK_HOST")]
        RUBRIK_HOST,

        [EnumMember(Value = "UNDEFINED")]
        UNDEFINED


    } // enum AzureHostType

} // namespace Rubrik.SecurityCloud.Types