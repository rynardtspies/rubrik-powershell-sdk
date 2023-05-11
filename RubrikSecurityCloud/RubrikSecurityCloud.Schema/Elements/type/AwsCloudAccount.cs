// AwsCloudAccount.cs
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
    #region AwsCloudAccount
    public class AwsCloudAccount: IFragment
    {
        #region members
        //      C# -> System.String? AccountName
        // GraphQL -> accountName: String! (scalar)
        [JsonProperty("accountName")]
        public System.String? AccountName { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }

        //      C# -> System.String? NativeId
        // GraphQL -> nativeId: String! (scalar)
        [JsonProperty("nativeId")]
        public System.String? NativeId { get; set; }

        //      C# -> System.Boolean? SeamlessFlowEnabled
        // GraphQL -> seamlessFlowEnabled: Boolean! (scalar)
        [JsonProperty("seamlessFlowEnabled")]
        public System.Boolean? SeamlessFlowEnabled { get; set; }

        //      C# -> AwsCloudType? CloudType
        // GraphQL -> cloudType: AwsCloudType! (enum)
        [JsonProperty("cloudType")]
        public AwsCloudType? CloudType { get; set; }

        #endregion

    #region methods

    public AwsCloudAccount Set(
        System.String? AccountName = null,
        System.String? Id = null,
        System.String? Message = null,
        System.String? NativeId = null,
        System.Boolean? SeamlessFlowEnabled = null,
        AwsCloudType? CloudType = null
    ) 
    {
        if ( AccountName != null ) {
            this.AccountName = AccountName;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Message != null ) {
            this.Message = Message;
        }
        if ( NativeId != null ) {
            this.NativeId = NativeId;
        }
        if ( SeamlessFlowEnabled != null ) {
            this.SeamlessFlowEnabled = SeamlessFlowEnabled;
        }
        if ( CloudType != null ) {
            this.CloudType = CloudType;
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
            //      C# -> System.String? AccountName
            // GraphQL -> accountName: String! (scalar)
            if (this.AccountName != null)
            {
                 s += ind + "accountName\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.String? Message
            // GraphQL -> message: String! (scalar)
            if (this.Message != null)
            {
                 s += ind + "message\n";

            }
            //      C# -> System.String? NativeId
            // GraphQL -> nativeId: String! (scalar)
            if (this.NativeId != null)
            {
                 s += ind + "nativeId\n";

            }
            //      C# -> System.Boolean? SeamlessFlowEnabled
            // GraphQL -> seamlessFlowEnabled: Boolean! (scalar)
            if (this.SeamlessFlowEnabled != null)
            {
                 s += ind + "seamlessFlowEnabled\n";

            }
            //      C# -> AwsCloudType? CloudType
            // GraphQL -> cloudType: AwsCloudType! (enum)
            if (this.CloudType != null)
            {
                 s += ind + "cloudType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? AccountName
            // GraphQL -> accountName: String! (scalar)
            if (this.AccountName == null && Exploration.Includes(parent + ".accountName$"))
            {
                this.AccountName = new System.String("FETCH");
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.String? Message
            // GraphQL -> message: String! (scalar)
            if (this.Message == null && Exploration.Includes(parent + ".message$"))
            {
                this.Message = new System.String("FETCH");
            }
            //      C# -> System.String? NativeId
            // GraphQL -> nativeId: String! (scalar)
            if (this.NativeId == null && Exploration.Includes(parent + ".nativeId$"))
            {
                this.NativeId = new System.String("FETCH");
            }
            //      C# -> System.Boolean? SeamlessFlowEnabled
            // GraphQL -> seamlessFlowEnabled: Boolean! (scalar)
            if (this.SeamlessFlowEnabled == null && Exploration.Includes(parent + ".seamlessFlowEnabled$"))
            {
                this.SeamlessFlowEnabled = new System.Boolean();
            }
            //      C# -> AwsCloudType? CloudType
            // GraphQL -> cloudType: AwsCloudType! (enum)
            if (this.CloudType == null && Exploration.Includes(parent + ".cloudType$"))
            {
                this.CloudType = new AwsCloudType();
            }
        }


    #endregion

    } // class AwsCloudAccount
    #endregion

    public static class ListAwsCloudAccountExtensions
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
            this List<AwsCloudAccount> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AwsCloudAccount> list, 
            String parent = "")
        {
            var item = new AwsCloudAccount();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types