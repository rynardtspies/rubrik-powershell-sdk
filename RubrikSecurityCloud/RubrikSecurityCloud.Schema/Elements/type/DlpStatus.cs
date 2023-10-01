// DlpStatus.cs
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
    #region DlpStatus
    public class DlpStatus: BaseType
    {
        #region members

        //      C# -> DlpStatusCode? Code
        // GraphQL -> code: DlpStatusCode! (enum)
        [JsonProperty("code")]
        public DlpStatusCode? Code { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DlpStatus";
    }

    public DlpStatus Set(
        DlpStatusCode? Code = null
    ) 
    {
        if ( Code != null ) {
            this.Code = Code;
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
        //      C# -> DlpStatusCode? Code
        // GraphQL -> code: DlpStatusCode! (enum)
        if (this.Code != null) {
            if (conf.Flat) {
                s += conf.Prefix + "code\n" ;
            } else {
                s += ind + "code\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DlpStatusCode? Code
        // GraphQL -> code: DlpStatusCode! (enum)
        if (ec.Includes("code",true))
        {
            if(this.Code == null) {

                this.Code = new DlpStatusCode();

            } else {


            }
        }
        else if (this.Code != null && ec.Excludes("code",true))
        {
            this.Code = null;
        }
    }


    #endregion

    } // class DlpStatus
    
    #endregion

    public static class ListDlpStatusExtensions
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
            this List<DlpStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<DlpStatus> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DlpStatus> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DlpStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DlpStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types