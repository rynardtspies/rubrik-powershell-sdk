// LdapTotpStatus.cs
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
    #region LdapTotpStatus
    public class LdapTotpStatus: IFragment
    {
        #region members
        //      C# -> System.Boolean? IsEnabled
        // GraphQL -> isEnabled: Boolean! (scalar)
        [JsonProperty("isEnabled")]
        public System.Boolean? IsEnabled { get; set; }

        //      C# -> System.Boolean? IsEnforced
        // GraphQL -> isEnforced: Boolean! (scalar)
        [JsonProperty("isEnforced")]
        public System.Boolean? IsEnforced { get; set; }

        //      C# -> System.Boolean? IsSupported
        // GraphQL -> isSupported: Boolean! (scalar)
        [JsonProperty("isSupported")]
        public System.Boolean? IsSupported { get; set; }

        #endregion

    #region methods

    public LdapTotpStatus Set(
        System.Boolean? IsEnabled = null,
        System.Boolean? IsEnforced = null,
        System.Boolean? IsSupported = null
    ) 
    {
        if ( IsEnabled != null ) {
            this.IsEnabled = IsEnabled;
        }
        if ( IsEnforced != null ) {
            this.IsEnforced = IsEnforced;
        }
        if ( IsSupported != null ) {
            this.IsSupported = IsSupported;
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
            //      C# -> System.Boolean? IsEnabled
            // GraphQL -> isEnabled: Boolean! (scalar)
            if (this.IsEnabled != null)
            {
                 s += ind + "isEnabled\n";

            }
            //      C# -> System.Boolean? IsEnforced
            // GraphQL -> isEnforced: Boolean! (scalar)
            if (this.IsEnforced != null)
            {
                 s += ind + "isEnforced\n";

            }
            //      C# -> System.Boolean? IsSupported
            // GraphQL -> isSupported: Boolean! (scalar)
            if (this.IsSupported != null)
            {
                 s += ind + "isSupported\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? IsEnabled
            // GraphQL -> isEnabled: Boolean! (scalar)
            if (this.IsEnabled == null && Exploration.Includes(parent + ".isEnabled$"))
            {
                this.IsEnabled = new System.Boolean();
            }
            //      C# -> System.Boolean? IsEnforced
            // GraphQL -> isEnforced: Boolean! (scalar)
            if (this.IsEnforced == null && Exploration.Includes(parent + ".isEnforced$"))
            {
                this.IsEnforced = new System.Boolean();
            }
            //      C# -> System.Boolean? IsSupported
            // GraphQL -> isSupported: Boolean! (scalar)
            if (this.IsSupported == null && Exploration.Includes(parent + ".isSupported$"))
            {
                this.IsSupported = new System.Boolean();
            }
        }


    #endregion

    } // class LdapTotpStatus
    #endregion

    public static class ListLdapTotpStatusExtensions
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
            this List<LdapTotpStatus> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<LdapTotpStatus> list, 
            String parent = "")
        {
            var item = new LdapTotpStatus();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types