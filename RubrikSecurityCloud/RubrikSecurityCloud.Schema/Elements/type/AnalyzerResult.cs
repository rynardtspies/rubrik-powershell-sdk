// AnalyzerResult.cs
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
    #region AnalyzerResult
    public class AnalyzerResult: IFragment
    {
        #region members
        //      C# -> Analyzer? Analyzer
        // GraphQL -> analyzer: Analyzer! (type)
        [JsonProperty("analyzer")]
        public Analyzer? Analyzer { get; set; }

        //      C# -> Hits? Hits
        // GraphQL -> hits: Hits! (type)
        [JsonProperty("hits")]
        public Hits? Hits { get; set; }

        #endregion

    #region methods

    public AnalyzerResult Set(
        Analyzer? Analyzer = null,
        Hits? Hits = null
    ) 
    {
        if ( Analyzer != null ) {
            this.Analyzer = Analyzer;
        }
        if ( Hits != null ) {
            this.Hits = Hits;
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
            //      C# -> Hits? Hits
            // GraphQL -> hits: Hits! (type)
            if (this.Hits != null)
            {
                 s += ind + "hits\n";

                 s += ind + "{\n" + 
                 this.Hits.AsFragment(indent+1) + 
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
            //      C# -> Hits? Hits
            // GraphQL -> hits: Hits! (type)
            if (this.Hits == null && Exploration.Includes(parent + ".hits"))
            {
                this.Hits = new Hits();
                this.Hits.ApplyExploratoryFragment(parent + ".hits");
            }
        }


    #endregion

    } // class AnalyzerResult
    #endregion

    public static class ListAnalyzerResultExtensions
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
            this List<AnalyzerResult> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AnalyzerResult> list, 
            String parent = "")
        {
            var item = new AnalyzerResult();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types