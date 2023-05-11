// ExistingUser.cs
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
    #region ExistingUser
    public class ExistingUser: IFragment
    {
        #region members
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsOrgAdmin
        // GraphQL -> isOrgAdmin: Boolean! (scalar)
        [JsonProperty("isOrgAdmin")]
        public System.Boolean? IsOrgAdmin { get; set; }

        //      C# -> User? User
        // GraphQL -> user: User! (type)
        [JsonProperty("user")]
        public User? User { get; set; }

        #endregion

    #region methods

    public ExistingUser Set(
        System.String? Id = null,
        System.Boolean? IsOrgAdmin = null,
        User? User = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsOrgAdmin != null ) {
            this.IsOrgAdmin = IsOrgAdmin;
        }
        if ( User != null ) {
            this.User = User;
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
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Boolean? IsOrgAdmin
            // GraphQL -> isOrgAdmin: Boolean! (scalar)
            if (this.IsOrgAdmin != null)
            {
                 s += ind + "isOrgAdmin\n";

            }
            //      C# -> User? User
            // GraphQL -> user: User! (type)
            if (this.User != null)
            {
                 s += ind + "user\n";

                 s += ind + "{\n" + 
                 this.User.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsOrgAdmin
            // GraphQL -> isOrgAdmin: Boolean! (scalar)
            if (this.IsOrgAdmin == null && Exploration.Includes(parent + ".isOrgAdmin$"))
            {
                this.IsOrgAdmin = new System.Boolean();
            }
            //      C# -> User? User
            // GraphQL -> user: User! (type)
            if (this.User == null && Exploration.Includes(parent + ".user"))
            {
                this.User = new User();
                this.User.ApplyExploratoryFragment(parent + ".user");
            }
        }


    #endregion

    } // class ExistingUser
    #endregion

    public static class ListExistingUserExtensions
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
            this List<ExistingUser> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ExistingUser> list, 
            String parent = "")
        {
            var item = new ExistingUser();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types