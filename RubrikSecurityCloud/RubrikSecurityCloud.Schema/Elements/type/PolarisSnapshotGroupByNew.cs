// PolarisSnapshotGroupByNew.cs
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
    #region PolarisSnapshotGroupByNew
    public class PolarisSnapshotGroupByNew: IFragment
    {
        #region members
        //      C# -> PolarisSnapshotConnection? PolarisSnapshotConnection
        // GraphQL -> polarisSnapshotConnection: PolarisSnapshotConnection! (type)
        [JsonProperty("polarisSnapshotConnection")]
        public PolarisSnapshotConnection? PolarisSnapshotConnection { get; set; }

        //      C# -> PolarisSnapshotGroupByInfo? GroupByInfo
        // GraphQL -> groupByInfo: PolarisSnapshotGroupByInfo! (union)
        [JsonProperty("groupByInfo")]
        public PolarisSnapshotGroupByInfo? GroupByInfo { get; set; }

        #endregion

    #region methods

    public PolarisSnapshotGroupByNew Set(
        PolarisSnapshotConnection? PolarisSnapshotConnection = null,
        PolarisSnapshotGroupByInfo? GroupByInfo = null
    ) 
    {
        if ( PolarisSnapshotConnection != null ) {
            this.PolarisSnapshotConnection = PolarisSnapshotConnection;
        }
        if ( GroupByInfo != null ) {
            this.GroupByInfo = GroupByInfo;
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
            //      C# -> PolarisSnapshotConnection? PolarisSnapshotConnection
            // GraphQL -> polarisSnapshotConnection: PolarisSnapshotConnection! (type)
            if (this.PolarisSnapshotConnection != null)
            {
                 s += ind + "polarisSnapshotConnection\n";

                 s += ind + "{\n" + 
                 this.PolarisSnapshotConnection.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> PolarisSnapshotGroupByInfo? GroupByInfo
            // GraphQL -> groupByInfo: PolarisSnapshotGroupByInfo! (union)
            if (this.GroupByInfo != null)
            {
                 s += ind + "groupByInfo\n";

                 s += ind + "{\n" + 
                 this.GroupByInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> PolarisSnapshotConnection? PolarisSnapshotConnection
            // GraphQL -> polarisSnapshotConnection: PolarisSnapshotConnection! (type)
            if (this.PolarisSnapshotConnection == null && Exploration.Includes(parent + ".polarisSnapshotConnection"))
            {
                this.PolarisSnapshotConnection = new PolarisSnapshotConnection();
                this.PolarisSnapshotConnection.ApplyExploratoryFragment(parent + ".polarisSnapshotConnection");
            }
            //      C# -> PolarisSnapshotGroupByInfo? GroupByInfo
            // GraphQL -> groupByInfo: PolarisSnapshotGroupByInfo! (union)
            if (this.GroupByInfo == null && Exploration.Includes(parent + ".groupByInfo"))
            {
                this.GroupByInfo = (PolarisSnapshotGroupByInfo)InterfaceHelper.CreateInstanceOfFirstType(typeof(PolarisSnapshotGroupByInfo));
                this.GroupByInfo.ApplyExploratoryFragment(parent + ".groupByInfo");
            }
        }


    #endregion

    } // class PolarisSnapshotGroupByNew
    #endregion

    public static class ListPolarisSnapshotGroupByNewExtensions
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
            this List<PolarisSnapshotGroupByNew> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<PolarisSnapshotGroupByNew> list, 
            String parent = "")
        {
            var item = new PolarisSnapshotGroupByNew();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types