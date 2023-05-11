// CreateServiceAccountReply.cs
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
    #region CreateServiceAccountReply
    public class CreateServiceAccountReply: IFragment
    {
        #region members
        //      C# -> System.String? AccessTokenUri
        // GraphQL -> accessTokenUri: String! (scalar)
        [JsonProperty("accessTokenUri")]
        public System.String? AccessTokenUri { get; set; }

        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        [JsonProperty("clientId")]
        public System.String? ClientId { get; set; }

        //      C# -> System.String? ClientSecret
        // GraphQL -> clientSecret: String! (scalar)
        [JsonProperty("clientSecret")]
        public System.String? ClientSecret { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        #endregion

    #region methods

    public CreateServiceAccountReply Set(
        System.String? AccessTokenUri = null,
        System.String? ClientId = null,
        System.String? ClientSecret = null,
        System.String? Name = null
    ) 
    {
        if ( AccessTokenUri != null ) {
            this.AccessTokenUri = AccessTokenUri;
        }
        if ( ClientId != null ) {
            this.ClientId = ClientId;
        }
        if ( ClientSecret != null ) {
            this.ClientSecret = ClientSecret;
        }
        if ( Name != null ) {
            this.Name = Name;
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
            //      C# -> System.String? AccessTokenUri
            // GraphQL -> accessTokenUri: String! (scalar)
            if (this.AccessTokenUri != null)
            {
                 s += ind + "accessTokenUri\n";

            }
            //      C# -> System.String? ClientId
            // GraphQL -> clientId: String! (scalar)
            if (this.ClientId != null)
            {
                 s += ind + "clientId\n";

            }
            //      C# -> System.String? ClientSecret
            // GraphQL -> clientSecret: String! (scalar)
            if (this.ClientSecret != null)
            {
                 s += ind + "clientSecret\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? AccessTokenUri
            // GraphQL -> accessTokenUri: String! (scalar)
            if (this.AccessTokenUri == null && Exploration.Includes(parent + ".accessTokenUri$"))
            {
                this.AccessTokenUri = new System.String("FETCH");
            }
            //      C# -> System.String? ClientId
            // GraphQL -> clientId: String! (scalar)
            if (this.ClientId == null && Exploration.Includes(parent + ".clientId$"))
            {
                this.ClientId = new System.String("FETCH");
            }
            //      C# -> System.String? ClientSecret
            // GraphQL -> clientSecret: String! (scalar)
            if (this.ClientSecret == null && Exploration.Includes(parent + ".clientSecret$"))
            {
                this.ClientSecret = new System.String("FETCH");
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
        }


    #endregion

    } // class CreateServiceAccountReply
    #endregion

    public static class ListCreateServiceAccountReplyExtensions
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
            this List<CreateServiceAccountReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<CreateServiceAccountReply> list, 
            String parent = "")
        {
            var item = new CreateServiceAccountReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types