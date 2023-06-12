// RiskSummary.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region RiskSummary
    public class RiskSummary: BaseType
    {
        #region members

        //      C# -> PrincipalRiskCount? HighRiskPrincipals
        // GraphQL -> highRiskPrincipals: PrincipalRiskCount (type)
        [JsonProperty("highRiskPrincipals")]
        public PrincipalRiskCount? HighRiskPrincipals { get; set; }

        //      C# -> PrincipalRiskCount? LowRiskPrincipals
        // GraphQL -> lowRiskPrincipals: PrincipalRiskCount (type)
        [JsonProperty("lowRiskPrincipals")]
        public PrincipalRiskCount? LowRiskPrincipals { get; set; }

        //      C# -> PrincipalRiskCount? MediumRiskPrincipals
        // GraphQL -> mediumRiskPrincipals: PrincipalRiskCount (type)
        [JsonProperty("mediumRiskPrincipals")]
        public PrincipalRiskCount? MediumRiskPrincipals { get; set; }


        #endregion

    #region methods

    public RiskSummary Set(
        PrincipalRiskCount? HighRiskPrincipals = null,
        PrincipalRiskCount? LowRiskPrincipals = null,
        PrincipalRiskCount? MediumRiskPrincipals = null
    ) 
    {
        if ( HighRiskPrincipals != null ) {
            this.HighRiskPrincipals = HighRiskPrincipals;
        }
        if ( LowRiskPrincipals != null ) {
            this.LowRiskPrincipals = LowRiskPrincipals;
        }
        if ( MediumRiskPrincipals != null ) {
            this.MediumRiskPrincipals = MediumRiskPrincipals;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> PrincipalRiskCount? HighRiskPrincipals
        // GraphQL -> highRiskPrincipals: PrincipalRiskCount (type)
        if (this.HighRiskPrincipals != null) {
            var fspec = this.HighRiskPrincipals.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "highRiskPrincipals {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PrincipalRiskCount? LowRiskPrincipals
        // GraphQL -> lowRiskPrincipals: PrincipalRiskCount (type)
        if (this.LowRiskPrincipals != null) {
            var fspec = this.LowRiskPrincipals.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "lowRiskPrincipals {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PrincipalRiskCount? MediumRiskPrincipals
        // GraphQL -> mediumRiskPrincipals: PrincipalRiskCount (type)
        if (this.MediumRiskPrincipals != null) {
            var fspec = this.MediumRiskPrincipals.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "mediumRiskPrincipals {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> PrincipalRiskCount? HighRiskPrincipals
        // GraphQL -> highRiskPrincipals: PrincipalRiskCount (type)
        if (this.HighRiskPrincipals == null && Exploration.Includes(parent + ".highRiskPrincipals"))
        {
            this.HighRiskPrincipals = new PrincipalRiskCount();
            this.HighRiskPrincipals.ApplyExploratoryFieldSpec(parent + ".highRiskPrincipals");
        }
        //      C# -> PrincipalRiskCount? LowRiskPrincipals
        // GraphQL -> lowRiskPrincipals: PrincipalRiskCount (type)
        if (this.LowRiskPrincipals == null && Exploration.Includes(parent + ".lowRiskPrincipals"))
        {
            this.LowRiskPrincipals = new PrincipalRiskCount();
            this.LowRiskPrincipals.ApplyExploratoryFieldSpec(parent + ".lowRiskPrincipals");
        }
        //      C# -> PrincipalRiskCount? MediumRiskPrincipals
        // GraphQL -> mediumRiskPrincipals: PrincipalRiskCount (type)
        if (this.MediumRiskPrincipals == null && Exploration.Includes(parent + ".mediumRiskPrincipals"))
        {
            this.MediumRiskPrincipals = new PrincipalRiskCount();
            this.MediumRiskPrincipals.ApplyExploratoryFieldSpec(parent + ".mediumRiskPrincipals");
        }
    }


    #endregion

    } // class RiskSummary
    
    #endregion

    public static class ListRiskSummaryExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<RiskSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RiskSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new RiskSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types