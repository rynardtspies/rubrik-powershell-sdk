// CreateO365AppKickoffResp.cs
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
    #region CreateO365AppKickoffResp
    public class CreateO365AppKickoffResp: BaseType
    {
        #region members

        //      C# -> System.String? AppClientId
        // GraphQL -> appClientId: String! (scalar)
        [JsonProperty("appClientId")]
        public System.String? AppClientId { get; set; }

        //      C# -> System.String? CsrfToken
        // GraphQL -> csrfToken: String! (scalar)
        [JsonProperty("csrfToken")]
        public System.String? CsrfToken { get; set; }

        //      C# -> System.String? O365TenantId
        // GraphQL -> o365TenantId: String! (scalar)
        [JsonProperty("o365TenantId")]
        public System.String? O365TenantId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CreateO365AppKickoffResp";
    }

    public CreateO365AppKickoffResp Set(
        System.String? AppClientId = null,
        System.String? CsrfToken = null,
        System.String? O365TenantId = null
    ) 
    {
        if ( AppClientId != null ) {
            this.AppClientId = AppClientId;
        }
        if ( CsrfToken != null ) {
            this.CsrfToken = CsrfToken;
        }
        if ( O365TenantId != null ) {
            this.O365TenantId = O365TenantId;
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
        //      C# -> System.String? AppClientId
        // GraphQL -> appClientId: String! (scalar)
        if (this.AppClientId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "appClientId\n" ;
            } else {
                s += ind + "appClientId\n" ;
            }
        }
        //      C# -> System.String? CsrfToken
        // GraphQL -> csrfToken: String! (scalar)
        if (this.CsrfToken != null) {
            if (conf.Flat) {
                s += conf.Prefix + "csrfToken\n" ;
            } else {
                s += ind + "csrfToken\n" ;
            }
        }
        //      C# -> System.String? O365TenantId
        // GraphQL -> o365TenantId: String! (scalar)
        if (this.O365TenantId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "o365TenantId\n" ;
            } else {
                s += ind + "o365TenantId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? AppClientId
        // GraphQL -> appClientId: String! (scalar)
        if (ec.Includes("appClientId",true))
        {
            if(this.AppClientId == null) {

                this.AppClientId = "FETCH";

            } else {


            }
        }
        else if (this.AppClientId != null && ec.Excludes("appClientId",true))
        {
            this.AppClientId = null;
        }
        //      C# -> System.String? CsrfToken
        // GraphQL -> csrfToken: String! (scalar)
        if (ec.Includes("csrfToken",true))
        {
            if(this.CsrfToken == null) {

                this.CsrfToken = "FETCH";

            } else {


            }
        }
        else if (this.CsrfToken != null && ec.Excludes("csrfToken",true))
        {
            this.CsrfToken = null;
        }
        //      C# -> System.String? O365TenantId
        // GraphQL -> o365TenantId: String! (scalar)
        if (ec.Includes("o365TenantId",true))
        {
            if(this.O365TenantId == null) {

                this.O365TenantId = "FETCH";

            } else {


            }
        }
        else if (this.O365TenantId != null && ec.Excludes("o365TenantId",true))
        {
            this.O365TenantId = null;
        }
    }


    #endregion

    } // class CreateO365AppKickoffResp
    
    #endregion

    public static class ListCreateO365AppKickoffRespExtensions
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
            this List<CreateO365AppKickoffResp> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<CreateO365AppKickoffResp> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CreateO365AppKickoffResp> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CreateO365AppKickoffResp());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CreateO365AppKickoffResp> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types