// SeedInitialPoliciesReply.cs
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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region SeedInitialPoliciesReply
    public class SeedInitialPoliciesReply: BaseType
    {
        #region members

        //      C# -> List<ClassificationPolicyDetail>? Policies
        // GraphQL -> policies: [ClassificationPolicyDetail!]! (type)
        [JsonProperty("policies")]
        public List<ClassificationPolicyDetail>? Policies { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SeedInitialPoliciesReply";
    }

    public SeedInitialPoliciesReply Set(
        List<ClassificationPolicyDetail>? Policies = null
    ) 
    {
        if ( Policies != null ) {
            this.Policies = Policies;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<ClassificationPolicyDetail>? Policies
        // GraphQL -> policies: [ClassificationPolicyDetail!]! (type)
        if (this.Policies != null) {
            var fspec = this.Policies.AsFieldSpec(conf.Child("policies"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "policies {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<ClassificationPolicyDetail>? Policies
        // GraphQL -> policies: [ClassificationPolicyDetail!]! (type)
        if (ec.Includes("policies",false))
        {
            if(this.Policies == null) {

                this.Policies = new List<ClassificationPolicyDetail>();
                this.Policies.ApplyExploratoryFieldSpec(ec.NewChild("policies"));

            } else {

                this.Policies.ApplyExploratoryFieldSpec(ec.NewChild("policies"));

            }
        }
        else if (this.Policies != null && ec.Excludes("policies",false))
        {
            this.Policies = null;
        }
    }


    #endregion

    } // class SeedInitialPoliciesReply
    
    #endregion

    public static class ListSeedInitialPoliciesReplyExtensions
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
            this List<SeedInitialPoliciesReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<SeedInitialPoliciesReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SeedInitialPoliciesReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SeedInitialPoliciesReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SeedInitialPoliciesReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types