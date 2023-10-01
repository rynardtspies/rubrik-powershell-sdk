// MosaicAsyncResponse.cs
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
    #region MosaicAsyncResponse
    public class MosaicAsyncResponse: BaseType
    {
        #region members

        //      C# -> System.String? Data
        // GraphQL -> data: String (scalar)
        [JsonProperty("data")]
        public System.String? Data { get; set; }

        //      C# -> System.String? Message
        // GraphQL -> message: String (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }

        //      C# -> System.Int64? ReturnCode
        // GraphQL -> returnCode: Long (scalar)
        [JsonProperty("returnCode")]
        public System.Int64? ReturnCode { get; set; }

        //      C# -> System.Boolean? Status
        // GraphQL -> status: Boolean (scalar)
        [JsonProperty("status")]
        public System.Boolean? Status { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MosaicAsyncResponse";
    }

    public MosaicAsyncResponse Set(
        System.String? Data = null,
        System.String? Message = null,
        System.Int64? ReturnCode = null,
        System.Boolean? Status = null
    ) 
    {
        if ( Data != null ) {
            this.Data = Data;
        }
        if ( Message != null ) {
            this.Message = Message;
        }
        if ( ReturnCode != null ) {
            this.ReturnCode = ReturnCode;
        }
        if ( Status != null ) {
            this.Status = Status;
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
        //      C# -> System.String? Data
        // GraphQL -> data: String (scalar)
        if (this.Data != null) {
            if (conf.Flat) {
                s += conf.Prefix + "data\n" ;
            } else {
                s += ind + "data\n" ;
            }
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String (scalar)
        if (this.Message != null) {
            if (conf.Flat) {
                s += conf.Prefix + "message\n" ;
            } else {
                s += ind + "message\n" ;
            }
        }
        //      C# -> System.Int64? ReturnCode
        // GraphQL -> returnCode: Long (scalar)
        if (this.ReturnCode != null) {
            if (conf.Flat) {
                s += conf.Prefix + "returnCode\n" ;
            } else {
                s += ind + "returnCode\n" ;
            }
        }
        //      C# -> System.Boolean? Status
        // GraphQL -> status: Boolean (scalar)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Data
        // GraphQL -> data: String (scalar)
        if (ec.Includes("data",true))
        {
            if(this.Data == null) {

                this.Data = "FETCH";

            } else {


            }
        }
        else if (this.Data != null && ec.Excludes("data",true))
        {
            this.Data = null;
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String (scalar)
        if (ec.Includes("message",true))
        {
            if(this.Message == null) {

                this.Message = "FETCH";

            } else {


            }
        }
        else if (this.Message != null && ec.Excludes("message",true))
        {
            this.Message = null;
        }
        //      C# -> System.Int64? ReturnCode
        // GraphQL -> returnCode: Long (scalar)
        if (ec.Includes("returnCode",true))
        {
            if(this.ReturnCode == null) {

                this.ReturnCode = new System.Int64();

            } else {


            }
        }
        else if (this.ReturnCode != null && ec.Excludes("returnCode",true))
        {
            this.ReturnCode = null;
        }
        //      C# -> System.Boolean? Status
        // GraphQL -> status: Boolean (scalar)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = true;

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
    }


    #endregion

    } // class MosaicAsyncResponse
    
    #endregion

    public static class ListMosaicAsyncResponseExtensions
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
            this List<MosaicAsyncResponse> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<MosaicAsyncResponse> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MosaicAsyncResponse> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MosaicAsyncResponse());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MosaicAsyncResponse> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types