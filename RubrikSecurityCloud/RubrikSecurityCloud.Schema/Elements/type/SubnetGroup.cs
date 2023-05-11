// SubnetGroup.cs
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
    #region SubnetGroup
    public class SubnetGroup: IFragment
    {
        #region members
        //      C# -> System.String? Arn
        // GraphQL -> arn: String! (scalar)
        [JsonProperty("arn")]
        public System.String? Arn { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? VpcId
        // GraphQL -> vpcId: String! (scalar)
        [JsonProperty("vpcId")]
        public System.String? VpcId { get; set; }

        //      C# -> List<AwsNativeSubnet>? Subnets
        // GraphQL -> subnets: [AwsNativeSubnet!]! (type)
        [JsonProperty("subnets")]
        public List<AwsNativeSubnet>? Subnets { get; set; }

        #endregion

    #region methods

    public SubnetGroup Set(
        System.String? Arn = null,
        System.String? Name = null,
        System.String? VpcId = null,
        List<AwsNativeSubnet>? Subnets = null
    ) 
    {
        if ( Arn != null ) {
            this.Arn = Arn;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( VpcId != null ) {
            this.VpcId = VpcId;
        }
        if ( Subnets != null ) {
            this.Subnets = Subnets;
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
            //      C# -> System.String? Arn
            // GraphQL -> arn: String! (scalar)
            if (this.Arn != null)
            {
                 s += ind + "arn\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.String? VpcId
            // GraphQL -> vpcId: String! (scalar)
            if (this.VpcId != null)
            {
                 s += ind + "vpcId\n";

            }
            //      C# -> List<AwsNativeSubnet>? Subnets
            // GraphQL -> subnets: [AwsNativeSubnet!]! (type)
            if (this.Subnets != null)
            {
                 s += ind + "subnets\n";

                 s += ind + "{\n" + 
                 this.Subnets.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Arn
            // GraphQL -> arn: String! (scalar)
            if (this.Arn == null && Exploration.Includes(parent + ".arn$"))
            {
                this.Arn = new System.String("FETCH");
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.String? VpcId
            // GraphQL -> vpcId: String! (scalar)
            if (this.VpcId == null && Exploration.Includes(parent + ".vpcId$"))
            {
                this.VpcId = new System.String("FETCH");
            }
            //      C# -> List<AwsNativeSubnet>? Subnets
            // GraphQL -> subnets: [AwsNativeSubnet!]! (type)
            if (this.Subnets == null && Exploration.Includes(parent + ".subnets"))
            {
                this.Subnets = new List<AwsNativeSubnet>();
                this.Subnets.ApplyExploratoryFragment(parent + ".subnets");
            }
        }


    #endregion

    } // class SubnetGroup
    #endregion

    public static class ListSubnetGroupExtensions
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
            this List<SubnetGroup> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SubnetGroup> list, 
            String parent = "")
        {
            var item = new SubnetGroup();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types