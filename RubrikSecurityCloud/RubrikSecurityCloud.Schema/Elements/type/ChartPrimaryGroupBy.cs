// ChartPrimaryGroupBy.cs
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
    #region ChartPrimaryGroupBy
    public class ChartPrimaryGroupBy: BaseType
    {
        #region members

        //      C# -> DisplayableValue? Name
        // GraphQL -> name: DisplayableValue (interface)
        [JsonProperty("name")]
        public DisplayableValue? Name { get; set; }

        //      C# -> DisplayableValue? Value
        // GraphQL -> value: DisplayableValue (interface)
        [JsonProperty("value")]
        public DisplayableValue? Value { get; set; }

        //      C# -> List<Metadata>? Metadata
        // GraphQL -> metadata: [Metadata!]! (type)
        [JsonProperty("metadata")]
        public List<Metadata>? Metadata { get; set; }

        //      C# -> List<ChartSecondaryGroupBy>? SecondaryGroupBy
        // GraphQL -> secondaryGroupBy: [ChartSecondaryGroupBy!]! (type)
        [JsonProperty("secondaryGroupBy")]
        public List<ChartSecondaryGroupBy>? SecondaryGroupBy { get; set; }


        #endregion

    #region methods

    public ChartPrimaryGroupBy Set(
        DisplayableValue? Name = null,
        DisplayableValue? Value = null,
        List<Metadata>? Metadata = null,
        List<ChartSecondaryGroupBy>? SecondaryGroupBy = null
    ) 
    {
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Value != null ) {
            this.Value = Value;
        }
        if ( Metadata != null ) {
            this.Metadata = Metadata;
        }
        if ( SecondaryGroupBy != null ) {
            this.SecondaryGroupBy = SecondaryGroupBy;
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
        //      C# -> DisplayableValue? Name
        // GraphQL -> name: DisplayableValue (interface)
        if (this.Name != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.Name).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "name {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> DisplayableValue? Value
        // GraphQL -> value: DisplayableValue (interface)
        if (this.Value != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.Value).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "value {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> List<Metadata>? Metadata
        // GraphQL -> metadata: [Metadata!]! (type)
        if (this.Metadata != null) {
            var fspec = this.Metadata.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "metadata {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<ChartSecondaryGroupBy>? SecondaryGroupBy
        // GraphQL -> secondaryGroupBy: [ChartSecondaryGroupBy!]! (type)
        if (this.SecondaryGroupBy != null) {
            var fspec = this.SecondaryGroupBy.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "secondaryGroupBy {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> DisplayableValue? Name
        // GraphQL -> name: DisplayableValue (interface)
        if (this.Name == null && Exploration.Includes(parent + ".name"))
        {
            var impls = new List<DisplayableValue>();
            impls.ApplyExploratoryFieldSpec(parent + ".name");
            this.Name = (DisplayableValue)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> DisplayableValue? Value
        // GraphQL -> value: DisplayableValue (interface)
        if (this.Value == null && Exploration.Includes(parent + ".value"))
        {
            var impls = new List<DisplayableValue>();
            impls.ApplyExploratoryFieldSpec(parent + ".value");
            this.Value = (DisplayableValue)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> List<Metadata>? Metadata
        // GraphQL -> metadata: [Metadata!]! (type)
        if (this.Metadata == null && Exploration.Includes(parent + ".metadata"))
        {
            this.Metadata = new List<Metadata>();
            this.Metadata.ApplyExploratoryFieldSpec(parent + ".metadata");
        }
        //      C# -> List<ChartSecondaryGroupBy>? SecondaryGroupBy
        // GraphQL -> secondaryGroupBy: [ChartSecondaryGroupBy!]! (type)
        if (this.SecondaryGroupBy == null && Exploration.Includes(parent + ".secondaryGroupBy"))
        {
            this.SecondaryGroupBy = new List<ChartSecondaryGroupBy>();
            this.SecondaryGroupBy.ApplyExploratoryFieldSpec(parent + ".secondaryGroupBy");
        }
    }


    #endregion

    } // class ChartPrimaryGroupBy
    
    #endregion

    public static class ListChartPrimaryGroupByExtensions
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
            this List<ChartPrimaryGroupBy> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ChartPrimaryGroupBy> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ChartPrimaryGroupBy());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types