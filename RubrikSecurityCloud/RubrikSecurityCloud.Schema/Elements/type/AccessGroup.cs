// AccessGroup.cs
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
    #region AccessGroup
    public class AccessGroup: IFragment
    {
        #region members
        //      C# -> System.String? GroupId
        // GraphQL -> groupId: String! (scalar)
        [JsonProperty("groupId")]
        public System.String? GroupId { get; set; }

        //      C# -> System.String? GroupName
        // GraphQL -> groupName: String! (scalar)
        [JsonProperty("groupName")]
        public System.String? GroupName { get; set; }

        #endregion

    #region methods

    public AccessGroup Set(
        System.String? GroupId = null,
        System.String? GroupName = null
    ) 
    {
        if ( GroupId != null ) {
            this.GroupId = GroupId;
        }
        if ( GroupName != null ) {
            this.GroupName = GroupName;
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
            //      C# -> System.String? GroupId
            // GraphQL -> groupId: String! (scalar)
            if (this.GroupId != null)
            {
                 s += ind + "groupId\n";

            }
            //      C# -> System.String? GroupName
            // GraphQL -> groupName: String! (scalar)
            if (this.GroupName != null)
            {
                 s += ind + "groupName\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? GroupId
            // GraphQL -> groupId: String! (scalar)
            if (this.GroupId == null && Exploration.Includes(parent + ".groupId$"))
            {
                this.GroupId = new System.String("FETCH");
            }
            //      C# -> System.String? GroupName
            // GraphQL -> groupName: String! (scalar)
            if (this.GroupName == null && Exploration.Includes(parent + ".groupName$"))
            {
                this.GroupName = new System.String("FETCH");
            }
        }


    #endregion

    } // class AccessGroup
    #endregion

    public static class ListAccessGroupExtensions
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
            this List<AccessGroup> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AccessGroup> list, 
            String parent = "")
        {
            var item = new AccessGroup();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types