// AzureNetworkSubnetUnusedAddrResp.cs
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
    #region AzureNetworkSubnetUnusedAddrResp
    public class AzureNetworkSubnetUnusedAddrResp: IFragment
    {
        #region members
        //      C# -> System.Int64? UnusedAddr
        // GraphQL -> unusedAddr: Long! (scalar)
        [JsonProperty("unusedAddr")]
        public System.Int64? UnusedAddr { get; set; }

        #endregion

    #region methods

    public AzureNetworkSubnetUnusedAddrResp Set(
        System.Int64? UnusedAddr = null
    ) 
    {
        if ( UnusedAddr != null ) {
            this.UnusedAddr = UnusedAddr;
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
            //      C# -> System.Int64? UnusedAddr
            // GraphQL -> unusedAddr: Long! (scalar)
            if (this.UnusedAddr != null)
            {
                 s += ind + "unusedAddr\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? UnusedAddr
            // GraphQL -> unusedAddr: Long! (scalar)
            if (this.UnusedAddr == null && Exploration.Includes(parent + ".unusedAddr$"))
            {
                this.UnusedAddr = new System.Int64();
            }
        }


    #endregion

    } // class AzureNetworkSubnetUnusedAddrResp
    #endregion

    public static class ListAzureNetworkSubnetUnusedAddrRespExtensions
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
            this List<AzureNetworkSubnetUnusedAddrResp> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AzureNetworkSubnetUnusedAddrResp> list, 
            String parent = "")
        {
            var item = new AzureNetworkSubnetUnusedAddrResp();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types