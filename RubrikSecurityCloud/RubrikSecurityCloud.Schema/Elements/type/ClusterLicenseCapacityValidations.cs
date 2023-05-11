// ClusterLicenseCapacityValidations.cs
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
    #region ClusterLicenseCapacityValidations
    public class ClusterLicenseCapacityValidations: IFragment
    {
        #region members
        //      C# -> List<ClusterLicenseInfo>? Errors
        // GraphQL -> errors: [ClusterLicenseInfo!]! (type)
        [JsonProperty("errors")]
        public List<ClusterLicenseInfo>? Errors { get; set; }

        //      C# -> List<ClusterLicenseInfo>? Warnings
        // GraphQL -> warnings: [ClusterLicenseInfo!]! (type)
        [JsonProperty("warnings")]
        public List<ClusterLicenseInfo>? Warnings { get; set; }

        #endregion

    #region methods

    public ClusterLicenseCapacityValidations Set(
        List<ClusterLicenseInfo>? Errors = null,
        List<ClusterLicenseInfo>? Warnings = null
    ) 
    {
        if ( Errors != null ) {
            this.Errors = Errors;
        }
        if ( Warnings != null ) {
            this.Warnings = Warnings;
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
            //      C# -> List<ClusterLicenseInfo>? Errors
            // GraphQL -> errors: [ClusterLicenseInfo!]! (type)
            if (this.Errors != null)
            {
                 s += ind + "errors\n";

                 s += ind + "{\n" + 
                 this.Errors.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<ClusterLicenseInfo>? Warnings
            // GraphQL -> warnings: [ClusterLicenseInfo!]! (type)
            if (this.Warnings != null)
            {
                 s += ind + "warnings\n";

                 s += ind + "{\n" + 
                 this.Warnings.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<ClusterLicenseInfo>? Errors
            // GraphQL -> errors: [ClusterLicenseInfo!]! (type)
            if (this.Errors == null && Exploration.Includes(parent + ".errors"))
            {
                this.Errors = new List<ClusterLicenseInfo>();
                this.Errors.ApplyExploratoryFragment(parent + ".errors");
            }
            //      C# -> List<ClusterLicenseInfo>? Warnings
            // GraphQL -> warnings: [ClusterLicenseInfo!]! (type)
            if (this.Warnings == null && Exploration.Includes(parent + ".warnings"))
            {
                this.Warnings = new List<ClusterLicenseInfo>();
                this.Warnings.ApplyExploratoryFragment(parent + ".warnings");
            }
        }


    #endregion

    } // class ClusterLicenseCapacityValidations
    #endregion

    public static class ListClusterLicenseCapacityValidationsExtensions
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
            this List<ClusterLicenseCapacityValidations> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ClusterLicenseCapacityValidations> list, 
            String parent = "")
        {
            var item = new ClusterLicenseCapacityValidations();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types