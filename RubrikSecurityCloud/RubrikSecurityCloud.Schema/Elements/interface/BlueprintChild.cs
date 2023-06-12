// BlueprintChild.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region BlueprintChild

    public interface BlueprintChild: IFieldSpec
    {
        #region members

        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID! (scalar)
        [JsonProperty("fid")]
        System.String? Fid { get; set; }

        //      C# -> System.Int32? BootPriority
        // GraphQL -> bootPriority: Int! (scalar)
        [JsonProperty("bootPriority")]
        System.Int32? BootPriority { get; set; }


        #endregion

    } // interface BlueprintChild

    #endregion



    public static class ListBlueprintChildExtensions
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
            this List<BlueprintChild> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            string fieldspecs = "";
            foreach (BlueprintChild item in list) 
            {
                var fspec = item.AsFieldSpec(indent+1);
                if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                    fieldspecs += ind + " ... on " + item.GetType().Name + " {\n" + fspec + ind + "}\n";
                }
            }
            return fieldspecs;
        }

        public static void ApplyExploratoryFieldSpec(
            this List<BlueprintChild> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                InterfaceHelper
                    .AddInstancesOfImplementingTypes<BlueprintChild>(
                        ref list, 
                        instance => instance.ApplyExploratoryFieldSpec(parent));
            } else {
                foreach (BlueprintChild item in list) {
                    item.ApplyExploratoryFieldSpec(parent);
                }
            }

        }
    }


} // namespace Rubrik.SecurityCloud.Types