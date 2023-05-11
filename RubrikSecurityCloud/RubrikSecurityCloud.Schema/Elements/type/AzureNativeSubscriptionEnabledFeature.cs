// AzureNativeSubscriptionEnabledFeature.cs
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
    #region AzureNativeSubscriptionEnabledFeature
    public class AzureNativeSubscriptionEnabledFeature: IFragment
    {
        #region members
        //      C# -> DateTime? LastRefreshedAt
        // GraphQL -> lastRefreshedAt: DateTime (scalar)
        [JsonProperty("lastRefreshedAt")]
        public DateTime? LastRefreshedAt { get; set; }

        //      C# -> AzureNativeProtectionFeature? FeatureName
        // GraphQL -> featureName: AzureNativeProtectionFeature! (enum)
        [JsonProperty("featureName")]
        public AzureNativeProtectionFeature? FeatureName { get; set; }

        //      C# -> AzureSubscriptionStatus? Status
        // GraphQL -> status: AzureSubscriptionStatus! (enum)
        [JsonProperty("status")]
        public AzureSubscriptionStatus? Status { get; set; }

        #endregion

    #region methods

    public AzureNativeSubscriptionEnabledFeature Set(
        DateTime? LastRefreshedAt = null,
        AzureNativeProtectionFeature? FeatureName = null,
        AzureSubscriptionStatus? Status = null
    ) 
    {
        if ( LastRefreshedAt != null ) {
            this.LastRefreshedAt = LastRefreshedAt;
        }
        if ( FeatureName != null ) {
            this.FeatureName = FeatureName;
        }
        if ( Status != null ) {
            this.Status = Status;
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
            //      C# -> DateTime? LastRefreshedAt
            // GraphQL -> lastRefreshedAt: DateTime (scalar)
            if (this.LastRefreshedAt != null)
            {
                 s += ind + "lastRefreshedAt\n";

            }
            //      C# -> AzureNativeProtectionFeature? FeatureName
            // GraphQL -> featureName: AzureNativeProtectionFeature! (enum)
            if (this.FeatureName != null)
            {
                 s += ind + "featureName\n";

            }
            //      C# -> AzureSubscriptionStatus? Status
            // GraphQL -> status: AzureSubscriptionStatus! (enum)
            if (this.Status != null)
            {
                 s += ind + "status\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> DateTime? LastRefreshedAt
            // GraphQL -> lastRefreshedAt: DateTime (scalar)
            if (this.LastRefreshedAt == null && Exploration.Includes(parent + ".lastRefreshedAt$"))
            {
                this.LastRefreshedAt = new DateTime();
            }
            //      C# -> AzureNativeProtectionFeature? FeatureName
            // GraphQL -> featureName: AzureNativeProtectionFeature! (enum)
            if (this.FeatureName == null && Exploration.Includes(parent + ".featureName$"))
            {
                this.FeatureName = new AzureNativeProtectionFeature();
            }
            //      C# -> AzureSubscriptionStatus? Status
            // GraphQL -> status: AzureSubscriptionStatus! (enum)
            if (this.Status == null && Exploration.Includes(parent + ".status$"))
            {
                this.Status = new AzureSubscriptionStatus();
            }
        }


    #endregion

    } // class AzureNativeSubscriptionEnabledFeature
    #endregion

    public static class ListAzureNativeSubscriptionEnabledFeatureExtensions
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
            this List<AzureNativeSubscriptionEnabledFeature> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AzureNativeSubscriptionEnabledFeature> list, 
            String parent = "")
        {
            var item = new AzureNativeSubscriptionEnabledFeature();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types