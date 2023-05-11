// AttachmentSpecForEbsVolume.cs
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
    #region AttachmentSpecForEbsVolume
    public class AttachmentSpecForEbsVolume: IFragment
    {
        #region members
        //      C# -> System.String? AwsNativeEc2InstanceId
        // GraphQL -> awsNativeEc2InstanceId: String! (scalar)
        [JsonProperty("awsNativeEc2InstanceId")]
        public System.String? AwsNativeEc2InstanceId { get; set; }

        //      C# -> System.String? DevicePath
        // GraphQL -> devicePath: String! (scalar)
        [JsonProperty("devicePath")]
        public System.String? DevicePath { get; set; }

        //      C# -> System.Boolean? IsExcludedFromSnapshot
        // GraphQL -> isExcludedFromSnapshot: Boolean! (scalar)
        [JsonProperty("isExcludedFromSnapshot")]
        public System.Boolean? IsExcludedFromSnapshot { get; set; }

        //      C# -> System.Boolean? IsRootVolume
        // GraphQL -> isRootVolume: Boolean! (scalar)
        [JsonProperty("isRootVolume")]
        public System.Boolean? IsRootVolume { get; set; }

        #endregion

    #region methods

    public AttachmentSpecForEbsVolume Set(
        System.String? AwsNativeEc2InstanceId = null,
        System.String? DevicePath = null,
        System.Boolean? IsExcludedFromSnapshot = null,
        System.Boolean? IsRootVolume = null
    ) 
    {
        if ( AwsNativeEc2InstanceId != null ) {
            this.AwsNativeEc2InstanceId = AwsNativeEc2InstanceId;
        }
        if ( DevicePath != null ) {
            this.DevicePath = DevicePath;
        }
        if ( IsExcludedFromSnapshot != null ) {
            this.IsExcludedFromSnapshot = IsExcludedFromSnapshot;
        }
        if ( IsRootVolume != null ) {
            this.IsRootVolume = IsRootVolume;
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
            //      C# -> System.String? AwsNativeEc2InstanceId
            // GraphQL -> awsNativeEc2InstanceId: String! (scalar)
            if (this.AwsNativeEc2InstanceId != null)
            {
                 s += ind + "awsNativeEc2InstanceId\n";

            }
            //      C# -> System.String? DevicePath
            // GraphQL -> devicePath: String! (scalar)
            if (this.DevicePath != null)
            {
                 s += ind + "devicePath\n";

            }
            //      C# -> System.Boolean? IsExcludedFromSnapshot
            // GraphQL -> isExcludedFromSnapshot: Boolean! (scalar)
            if (this.IsExcludedFromSnapshot != null)
            {
                 s += ind + "isExcludedFromSnapshot\n";

            }
            //      C# -> System.Boolean? IsRootVolume
            // GraphQL -> isRootVolume: Boolean! (scalar)
            if (this.IsRootVolume != null)
            {
                 s += ind + "isRootVolume\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? AwsNativeEc2InstanceId
            // GraphQL -> awsNativeEc2InstanceId: String! (scalar)
            if (this.AwsNativeEc2InstanceId == null && Exploration.Includes(parent + ".awsNativeEc2InstanceId$"))
            {
                this.AwsNativeEc2InstanceId = new System.String("FETCH");
            }
            //      C# -> System.String? DevicePath
            // GraphQL -> devicePath: String! (scalar)
            if (this.DevicePath == null && Exploration.Includes(parent + ".devicePath$"))
            {
                this.DevicePath = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsExcludedFromSnapshot
            // GraphQL -> isExcludedFromSnapshot: Boolean! (scalar)
            if (this.IsExcludedFromSnapshot == null && Exploration.Includes(parent + ".isExcludedFromSnapshot$"))
            {
                this.IsExcludedFromSnapshot = new System.Boolean();
            }
            //      C# -> System.Boolean? IsRootVolume
            // GraphQL -> isRootVolume: Boolean! (scalar)
            if (this.IsRootVolume == null && Exploration.Includes(parent + ".isRootVolume$"))
            {
                this.IsRootVolume = new System.Boolean();
            }
        }


    #endregion

    } // class AttachmentSpecForEbsVolume
    #endregion

    public static class ListAttachmentSpecForEbsVolumeExtensions
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
            this List<AttachmentSpecForEbsVolume> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AttachmentSpecForEbsVolume> list, 
            String parent = "")
        {
            var item = new AttachmentSpecForEbsVolume();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types