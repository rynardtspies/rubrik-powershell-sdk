// VcdVappLogicalChildTypeConnection.cs
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
    #region VcdVappLogicalChildTypeConnection
    public class VcdVappLogicalChildTypeConnection: BaseType
    {
        #region members

        //      C# -> List<VcdVappLogicalChildType>? Nodes
        // GraphQL -> nodes: [VcdVappLogicalChildType!]! (interface)
        [JsonProperty("nodes")]
        public List<VcdVappLogicalChildType>? Nodes { get; set; }

        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        [JsonProperty("count")]
        public System.Int32? Count { get; set; }

        //      C# -> List<VcdVappLogicalChildTypeEdge>? Edges
        // GraphQL -> edges: [VcdVappLogicalChildTypeEdge!]! (type)
        [JsonProperty("edges")]
        public List<VcdVappLogicalChildTypeEdge>? Edges { get; set; }

        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        [JsonProperty("pageInfo")]
        public PageInfo? PageInfo { get; set; }


        #endregion

    #region methods

    public VcdVappLogicalChildTypeConnection Set(
        List<VcdVappLogicalChildType>? Nodes = null,
        System.Int32? Count = null,
        List<VcdVappLogicalChildTypeEdge>? Edges = null,
        PageInfo? PageInfo = null
    ) 
    {
        if ( Nodes != null ) {
            this.Nodes = Nodes;
        }
        if ( Count != null ) {
            this.Count = Count;
        }
        if ( Edges != null ) {
            this.Edges = Edges;
        }
        if ( PageInfo != null ) {
            this.PageInfo = PageInfo;
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
        //      C# -> List<VcdVappLogicalChildType>? Nodes
        // GraphQL -> nodes: [VcdVappLogicalChildType!]! (interface)
        if (this.Nodes != null) {
                var fspec = this.Nodes.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "nodes {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count != null) {
            s += ind + "count\n" ;
        }
        //      C# -> List<VcdVappLogicalChildTypeEdge>? Edges
        // GraphQL -> edges: [VcdVappLogicalChildTypeEdge!]! (type)
        if (this.Edges != null) {
            var fspec = this.Edges.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "edges {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        if (this.PageInfo != null) {
            var fspec = this.PageInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "pageInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<VcdVappLogicalChildType>? Nodes
        // GraphQL -> nodes: [VcdVappLogicalChildType!]! (interface)
        if (this.Nodes == null && Exploration.Includes(parent + ".nodes"))
        {
            this.Nodes = new List<VcdVappLogicalChildType>();
            this.Nodes.ApplyExploratoryFieldSpec(parent + ".nodes");
        }
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count == null && Exploration.Includes(parent + ".count", true))
        {
            this.Count = Int32.MinValue;
        }
        //      C# -> List<VcdVappLogicalChildTypeEdge>? Edges
        // GraphQL -> edges: [VcdVappLogicalChildTypeEdge!]! (type)
        if (this.Edges == null && Exploration.Includes(parent + ".edges"))
        {
            this.Edges = new List<VcdVappLogicalChildTypeEdge>();
            this.Edges.ApplyExploratoryFieldSpec(parent + ".edges");
        }
        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        if (this.PageInfo == null && Exploration.Includes(parent + ".pageInfo"))
        {
            this.PageInfo = new PageInfo();
            this.PageInfo.ApplyExploratoryFieldSpec(parent + ".pageInfo");
        }
    }


    #endregion

    } // class VcdVappLogicalChildTypeConnection
    
    #endregion

    public static class ListVcdVappLogicalChildTypeConnectionExtensions
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
            this List<VcdVappLogicalChildTypeConnection> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VcdVappLogicalChildTypeConnection> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VcdVappLogicalChildTypeConnection());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types