// NutanixPrismCentralDescendantTypeEdge.cs
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
    #region NutanixPrismCentralDescendantTypeEdge
    public class NutanixPrismCentralDescendantTypeEdge: BaseType
    {
        #region members

        //      C# -> NutanixPrismCentralDescendantType? Node
        // GraphQL -> node: NutanixPrismCentralDescendantType! (interface)
        [JsonProperty("node")]
        public NutanixPrismCentralDescendantType? Node { get; set; }

        //      C# -> System.String? Cursor
        // GraphQL -> cursor: String! (scalar)
        [JsonProperty("cursor")]
        public System.String? Cursor { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NutanixPrismCentralDescendantTypeEdge";
    }

    public NutanixPrismCentralDescendantTypeEdge Set(
        NutanixPrismCentralDescendantType? Node = null,
        System.String? Cursor = null
    ) 
    {
        if ( Node != null ) {
            this.Node = Node;
        }
        if ( Cursor != null ) {
            this.Cursor = Cursor;
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
        //      C# -> NutanixPrismCentralDescendantType? Node
        // GraphQL -> node: NutanixPrismCentralDescendantType! (interface)
        if (this.Node != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.Node).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "node {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> System.String? Cursor
        // GraphQL -> cursor: String! (scalar)
        if (this.Cursor != null) {
            s += ind + "cursor\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> NutanixPrismCentralDescendantType? Node
        // GraphQL -> node: NutanixPrismCentralDescendantType! (interface)
        if (this.Node == null && ec.Includes("node",false))
        {
            var impls = new List<NutanixPrismCentralDescendantType>();
            impls.ApplyExploratoryFieldSpec(ec.NewChild("node"));
            this.Node = (NutanixPrismCentralDescendantType)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> System.String? Cursor
        // GraphQL -> cursor: String! (scalar)
        if (this.Cursor == null && ec.Includes("cursor",true))
        {
            this.Cursor = "FETCH";
        }
    }


    #endregion

    } // class NutanixPrismCentralDescendantTypeEdge
    
    #endregion

    public static class ListNutanixPrismCentralDescendantTypeEdgeExtensions
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
            this List<NutanixPrismCentralDescendantTypeEdge> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NutanixPrismCentralDescendantTypeEdge> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NutanixPrismCentralDescendantTypeEdge());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NutanixPrismCentralDescendantTypeEdge> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types