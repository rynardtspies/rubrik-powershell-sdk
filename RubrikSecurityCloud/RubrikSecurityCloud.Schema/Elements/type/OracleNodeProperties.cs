// OracleNodeProperties.cs
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
    #region OracleNodeProperties
    public class OracleNodeProperties: IFragment
    {
        #region members
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String (scalar)
        [JsonProperty("hostId")]
        public System.String? HostId { get; set; }

        //      C# -> System.String? NodeName
        // GraphQL -> nodeName: String! (scalar)
        [JsonProperty("nodeName")]
        public System.String? NodeName { get; set; }

        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        [JsonProperty("status")]
        public System.String? Status { get; set; }

        #endregion

    #region methods

    public OracleNodeProperties Set(
        System.String? HostId = null,
        System.String? NodeName = null,
        System.String? Status = null
    ) 
    {
        if ( HostId != null ) {
            this.HostId = HostId;
        }
        if ( NodeName != null ) {
            this.NodeName = NodeName;
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
            //      C# -> System.String? HostId
            // GraphQL -> hostId: String (scalar)
            if (this.HostId != null)
            {
                 s += ind + "hostId\n";

            }
            //      C# -> System.String? NodeName
            // GraphQL -> nodeName: String! (scalar)
            if (this.NodeName != null)
            {
                 s += ind + "nodeName\n";

            }
            //      C# -> System.String? Status
            // GraphQL -> status: String! (scalar)
            if (this.Status != null)
            {
                 s += ind + "status\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? HostId
            // GraphQL -> hostId: String (scalar)
            if (this.HostId == null && Exploration.Includes(parent + ".hostId$"))
            {
                this.HostId = new System.String("FETCH");
            }
            //      C# -> System.String? NodeName
            // GraphQL -> nodeName: String! (scalar)
            if (this.NodeName == null && Exploration.Includes(parent + ".nodeName$"))
            {
                this.NodeName = new System.String("FETCH");
            }
            //      C# -> System.String? Status
            // GraphQL -> status: String! (scalar)
            if (this.Status == null && Exploration.Includes(parent + ".status$"))
            {
                this.Status = new System.String("FETCH");
            }
        }


    #endregion

    } // class OracleNodeProperties
    #endregion

    public static class ListOracleNodePropertiesExtensions
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
            this List<OracleNodeProperties> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<OracleNodeProperties> list, 
            String parent = "")
        {
            var item = new OracleNodeProperties();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types