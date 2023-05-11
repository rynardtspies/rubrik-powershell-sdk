// VcenterPatch.cs
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
    #region VcenterPatch
    public class VcenterPatch: IFragment
    {
        #region members
        //      C# -> System.String? CaCerts
        // GraphQL -> caCerts: String (scalar)
        [JsonProperty("caCerts")]
        public System.String? CaCerts { get; set; }

        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String (scalar)
        [JsonProperty("configuredSlaDomainId")]
        public System.String? ConfiguredSlaDomainId { get; set; }

        #endregion

    #region methods

    public VcenterPatch Set(
        System.String? CaCerts = null,
        System.String? ConfiguredSlaDomainId = null
    ) 
    {
        if ( CaCerts != null ) {
            this.CaCerts = CaCerts;
        }
        if ( ConfiguredSlaDomainId != null ) {
            this.ConfiguredSlaDomainId = ConfiguredSlaDomainId;
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
            //      C# -> System.String? CaCerts
            // GraphQL -> caCerts: String (scalar)
            if (this.CaCerts != null)
            {
                 s += ind + "caCerts\n";

            }
            //      C# -> System.String? ConfiguredSlaDomainId
            // GraphQL -> configuredSlaDomainId: String (scalar)
            if (this.ConfiguredSlaDomainId != null)
            {
                 s += ind + "configuredSlaDomainId\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? CaCerts
            // GraphQL -> caCerts: String (scalar)
            if (this.CaCerts == null && Exploration.Includes(parent + ".caCerts$"))
            {
                this.CaCerts = new System.String("FETCH");
            }
            //      C# -> System.String? ConfiguredSlaDomainId
            // GraphQL -> configuredSlaDomainId: String (scalar)
            if (this.ConfiguredSlaDomainId == null && Exploration.Includes(parent + ".configuredSlaDomainId$"))
            {
                this.ConfiguredSlaDomainId = new System.String("FETCH");
            }
        }


    #endregion

    } // class VcenterPatch
    #endregion

    public static class ListVcenterPatchExtensions
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
            this List<VcenterPatch> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<VcenterPatch> list, 
            String parent = "")
        {
            var item = new VcenterPatch();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types