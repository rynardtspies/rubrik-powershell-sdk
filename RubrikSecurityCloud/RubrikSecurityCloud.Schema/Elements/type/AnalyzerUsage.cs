// AnalyzerUsage.cs
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
    #region AnalyzerUsage
    public class AnalyzerUsage: IFragment
    {
        #region members
        //      C# -> Analyzer? Analyzer
        // GraphQL -> analyzer: Analyzer! (type)
        [JsonProperty("analyzer")]
        public Analyzer? Analyzer { get; set; }

        //      C# -> List<ClassificationPolicySummary>? Policies
        // GraphQL -> policies: [ClassificationPolicySummary!]! (type)
        [JsonProperty("policies")]
        public List<ClassificationPolicySummary>? Policies { get; set; }

        #endregion

    #region methods

    public AnalyzerUsage Set(
        Analyzer? Analyzer = null,
        List<ClassificationPolicySummary>? Policies = null
    ) 
    {
        if ( Analyzer != null ) {
            this.Analyzer = Analyzer;
        }
        if ( Policies != null ) {
            this.Policies = Policies;
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
            //      C# -> Analyzer? Analyzer
            // GraphQL -> analyzer: Analyzer! (type)
            if (this.Analyzer != null)
            {
                 s += ind + "analyzer\n";

                 s += ind + "{\n" + 
                 this.Analyzer.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<ClassificationPolicySummary>? Policies
            // GraphQL -> policies: [ClassificationPolicySummary!]! (type)
            if (this.Policies != null)
            {
                 s += ind + "policies\n";

                 s += ind + "{\n" + 
                 this.Policies.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> Analyzer? Analyzer
            // GraphQL -> analyzer: Analyzer! (type)
            if (this.Analyzer == null && Exploration.Includes(parent + ".analyzer"))
            {
                this.Analyzer = new Analyzer();
                this.Analyzer.ApplyExploratoryFragment(parent + ".analyzer");
            }
            //      C# -> List<ClassificationPolicySummary>? Policies
            // GraphQL -> policies: [ClassificationPolicySummary!]! (type)
            if (this.Policies == null && Exploration.Includes(parent + ".policies"))
            {
                this.Policies = new List<ClassificationPolicySummary>();
                this.Policies.ApplyExploratoryFragment(parent + ".policies");
            }
        }


    #endregion

    } // class AnalyzerUsage
    #endregion

    public static class ListAnalyzerUsageExtensions
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
            this List<AnalyzerUsage> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AnalyzerUsage> list, 
            String parent = "")
        {
            var item = new AnalyzerUsage();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types