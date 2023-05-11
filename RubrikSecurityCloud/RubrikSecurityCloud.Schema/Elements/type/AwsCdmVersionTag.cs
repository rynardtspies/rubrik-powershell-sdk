// AwsCdmVersionTag.cs
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
    #region AwsCdmVersionTag
    public class AwsCdmVersionTag: IFragment
    {
        #region members
        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        [JsonProperty("key")]
        public System.String? Key { get; set; }

        //      C# -> System.String? Value
        // GraphQL -> value: String! (scalar)
        [JsonProperty("value")]
        public System.String? Value { get; set; }

        #endregion

    #region methods

    public AwsCdmVersionTag Set(
        System.String? Key = null,
        System.String? Value = null
    ) 
    {
        if ( Key != null ) {
            this.Key = Key;
        }
        if ( Value != null ) {
            this.Value = Value;
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
            //      C# -> System.String? Key
            // GraphQL -> key: String! (scalar)
            if (this.Key != null)
            {
                 s += ind + "key\n";

            }
            //      C# -> System.String? Value
            // GraphQL -> value: String! (scalar)
            if (this.Value != null)
            {
                 s += ind + "value\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Key
            // GraphQL -> key: String! (scalar)
            if (this.Key == null && Exploration.Includes(parent + ".key$"))
            {
                this.Key = new System.String("FETCH");
            }
            //      C# -> System.String? Value
            // GraphQL -> value: String! (scalar)
            if (this.Value == null && Exploration.Includes(parent + ".value$"))
            {
                this.Value = new System.String("FETCH");
            }
        }


    #endregion

    } // class AwsCdmVersionTag
    #endregion

    public static class ListAwsCdmVersionTagExtensions
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
            this List<AwsCdmVersionTag> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AwsCdmVersionTag> list, 
            String parent = "")
        {
            var item = new AwsCdmVersionTag();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types