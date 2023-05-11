// SearchKeywordType.cs
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
    public enum SearchKeywordType
    {
        [EnumMember(Value = "ALL")]
        ALL,

        [EnumMember(Value = "FOLDER_NAME")]
        FOLDER_NAME,

        [EnumMember(Value = "SUBJECT")]
        SUBJECT


    } // enum SearchKeywordType

} // namespace Rubrik.SecurityCloud.Types