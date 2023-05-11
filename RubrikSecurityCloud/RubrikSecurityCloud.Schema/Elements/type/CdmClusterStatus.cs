// CdmClusterStatus.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region CdmClusterStatus
    public class CdmClusterStatus: IFragment
    {
        #region members
        //      C# -> System.String? Message
        // GraphQL -> message: String (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }

        //      C# -> CdmClusterStatusInfo? StatusInfo
        // GraphQL -> statusInfo: CdmClusterStatusInfo (type)
        [JsonProperty("statusInfo")]
        public CdmClusterStatusInfo? StatusInfo { get; set; }

        //      C# -> CdmClusterStatusTypeEnum? Status
        // GraphQL -> status: CdmClusterStatusTypeEnum! (enum)
        [JsonProperty("status")]
        public CdmClusterStatusTypeEnum? Status { get; set; }

        #endregion

    #region methods

    public CdmClusterStatus Set(
        System.String? Message = null,
        CdmClusterStatusInfo? StatusInfo = null,
        CdmClusterStatusTypeEnum? Status = null
    ) 
    {
        if ( Message != null ) {
            this.Message = Message;
        }
        if ( StatusInfo != null ) {
            this.StatusInfo = StatusInfo;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? Message
            // GraphQL -> message: String (scalar)
            if (this.Message != null)
            {
                 s += ind + "message\n";

            }
            //      C# -> CdmClusterStatusInfo? StatusInfo
            // GraphQL -> statusInfo: CdmClusterStatusInfo (type)
            if (this.StatusInfo != null)
            {
                 s += ind + "statusInfo\n";

                 s += ind + "{\n" + 
                 this.StatusInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> CdmClusterStatusTypeEnum? Status
            // GraphQL -> status: CdmClusterStatusTypeEnum! (enum)
            if (this.Status != null)
            {
                 s += ind + "status\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Message
            // GraphQL -> message: String (scalar)
            if (this.Message == null && Exploration.Includes(parent + ".message$"))
            {
                this.Message = new System.String("FETCH");
            }
            //      C# -> CdmClusterStatusInfo? StatusInfo
            // GraphQL -> statusInfo: CdmClusterStatusInfo (type)
            if (this.StatusInfo == null && Exploration.Includes(parent + ".statusInfo"))
            {
                this.StatusInfo = new CdmClusterStatusInfo();
                this.StatusInfo.ApplyExploratoryFragment(parent + ".statusInfo");
            }
            //      C# -> CdmClusterStatusTypeEnum? Status
            // GraphQL -> status: CdmClusterStatusTypeEnum! (enum)
            if (this.Status == null && Exploration.Includes(parent + ".status$"))
            {
                this.Status = new CdmClusterStatusTypeEnum();
            }
        }


    #endregion

    } // class CdmClusterStatus
    #endregion

    public static class ListCdmClusterStatusExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<CdmClusterStatus> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<CdmClusterStatus> list, 
            String parent = "")
        {
            var item = new CdmClusterStatus();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types