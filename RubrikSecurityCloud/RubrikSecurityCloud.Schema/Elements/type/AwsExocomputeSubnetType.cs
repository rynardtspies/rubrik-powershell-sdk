// AwsExocomputeSubnetType.cs
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
    #region AwsExocomputeSubnetType
    public class AwsExocomputeSubnetType: IFragment
    {
        #region members
        //      C# -> System.String? AvailabilityZone
        // GraphQL -> availabilityZone: String! (scalar)
        [JsonProperty("availabilityZone")]
        public System.String? AvailabilityZone { get; set; }

        //      C# -> System.String? SubnetId
        // GraphQL -> subnetId: String! (scalar)
        [JsonProperty("subnetId")]
        public System.String? SubnetId { get; set; }

        #endregion

    #region methods

    public AwsExocomputeSubnetType Set(
        System.String? AvailabilityZone = null,
        System.String? SubnetId = null
    ) 
    {
        if ( AvailabilityZone != null ) {
            this.AvailabilityZone = AvailabilityZone;
        }
        if ( SubnetId != null ) {
            this.SubnetId = SubnetId;
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
            //      C# -> System.String? AvailabilityZone
            // GraphQL -> availabilityZone: String! (scalar)
            if (this.AvailabilityZone != null)
            {
                 s += ind + "availabilityZone\n";

            }
            //      C# -> System.String? SubnetId
            // GraphQL -> subnetId: String! (scalar)
            if (this.SubnetId != null)
            {
                 s += ind + "subnetId\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? AvailabilityZone
            // GraphQL -> availabilityZone: String! (scalar)
            if (this.AvailabilityZone == null && Exploration.Includes(parent + ".availabilityZone$"))
            {
                this.AvailabilityZone = new System.String("FETCH");
            }
            //      C# -> System.String? SubnetId
            // GraphQL -> subnetId: String! (scalar)
            if (this.SubnetId == null && Exploration.Includes(parent + ".subnetId$"))
            {
                this.SubnetId = new System.String("FETCH");
            }
        }


    #endregion

    } // class AwsExocomputeSubnetType
    #endregion

    public static class ListAwsExocomputeSubnetTypeExtensions
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
            this List<AwsExocomputeSubnetType> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AwsExocomputeSubnetType> list, 
            String parent = "")
        {
            var item = new AwsExocomputeSubnetType();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types