// InternalChangeVfdOnHostResponse.cs
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
    #region InternalChangeVfdOnHostResponse
    public class InternalChangeVfdOnHostResponse: BaseType
    {
        #region members

        //      C# -> List<HostVfdInstallResponse>? Items
        // GraphQL -> items: [HostVfdInstallResponse!]! (type)
        [JsonProperty("items")]
        public List<HostVfdInstallResponse>? Items { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "InternalChangeVfdOnHostResponse";
    }

    public InternalChangeVfdOnHostResponse Set(
        List<HostVfdInstallResponse>? Items = null
    ) 
    {
        if ( Items != null ) {
            this.Items = Items;
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
        //      C# -> List<HostVfdInstallResponse>? Items
        // GraphQL -> items: [HostVfdInstallResponse!]! (type)
        if (this.Items != null) {
            var fspec = this.Items.AsFieldSpec(conf.Child("items"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "items {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<HostVfdInstallResponse>? Items
        // GraphQL -> items: [HostVfdInstallResponse!]! (type)
        if (ec.Includes("items",false))
        {
            if(this.Items == null) {

                this.Items = new List<HostVfdInstallResponse>();
                this.Items.ApplyExploratoryFieldSpec(ec.NewChild("items"));

            } else {

                this.Items.ApplyExploratoryFieldSpec(ec.NewChild("items"));

            }
        }
        else if (this.Items != null && ec.Excludes("items",false))
        {
            this.Items = null;
        }
    }


    #endregion

    } // class InternalChangeVfdOnHostResponse
    
    #endregion

    public static class ListInternalChangeVfdOnHostResponseExtensions
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
            this List<InternalChangeVfdOnHostResponse> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<InternalChangeVfdOnHostResponse> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<InternalChangeVfdOnHostResponse> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new InternalChangeVfdOnHostResponse());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<InternalChangeVfdOnHostResponse> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types