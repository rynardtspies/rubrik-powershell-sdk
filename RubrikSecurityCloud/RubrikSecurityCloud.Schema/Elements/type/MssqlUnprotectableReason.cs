// MssqlUnprotectableReason.cs
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
    #region MssqlUnprotectableReason
    public class MssqlUnprotectableReason: IFragment
    {
        #region members
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }

        //      C# -> MssqlUnprotectableType? UnprotectableType
        // GraphQL -> unprotectableType: MssqlUnprotectableType! (enum)
        [JsonProperty("unprotectableType")]
        public MssqlUnprotectableType? UnprotectableType { get; set; }

        #endregion

    #region methods

    public MssqlUnprotectableReason Set(
        System.String? Message = null,
        MssqlUnprotectableType? UnprotectableType = null
    ) 
    {
        if ( Message != null ) {
            this.Message = Message;
        }
        if ( UnprotectableType != null ) {
            this.UnprotectableType = UnprotectableType;
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
            // GraphQL -> message: String! (scalar)
            if (this.Message != null)
            {
                 s += ind + "message\n";

            }
            //      C# -> MssqlUnprotectableType? UnprotectableType
            // GraphQL -> unprotectableType: MssqlUnprotectableType! (enum)
            if (this.UnprotectableType != null)
            {
                 s += ind + "unprotectableType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Message
            // GraphQL -> message: String! (scalar)
            if (this.Message == null && Exploration.Includes(parent + ".message$"))
            {
                this.Message = new System.String("FETCH");
            }
            //      C# -> MssqlUnprotectableType? UnprotectableType
            // GraphQL -> unprotectableType: MssqlUnprotectableType! (enum)
            if (this.UnprotectableType == null && Exploration.Includes(parent + ".unprotectableType$"))
            {
                this.UnprotectableType = new MssqlUnprotectableType();
            }
        }


    #endregion

    } // class MssqlUnprotectableReason
    #endregion

    public static class ListMssqlUnprotectableReasonExtensions
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
            this List<MssqlUnprotectableReason> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<MssqlUnprotectableReason> list, 
            String parent = "")
        {
            var item = new MssqlUnprotectableReason();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types