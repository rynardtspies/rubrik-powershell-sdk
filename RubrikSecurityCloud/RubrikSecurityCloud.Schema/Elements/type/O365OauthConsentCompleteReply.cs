// O365OauthConsentCompleteReply.cs
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
    #region O365OauthConsentCompleteReply
    public class O365OauthConsentCompleteReply: BaseType
    {
        #region members

        //      C# -> System.String? AppId
        // GraphQL -> appId: String! (scalar)
        [JsonProperty("appId")]
        public System.String? AppId { get; set; }

        //      C# -> System.String? EncryptedRefreshToken
        // GraphQL -> encryptedRefreshToken: String! (scalar)
        [JsonProperty("encryptedRefreshToken")]
        public System.String? EncryptedRefreshToken { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "O365OauthConsentCompleteReply";
    }

    public O365OauthConsentCompleteReply Set(
        System.String? AppId = null,
        System.String? EncryptedRefreshToken = null
    ) 
    {
        if ( AppId != null ) {
            this.AppId = AppId;
        }
        if ( EncryptedRefreshToken != null ) {
            this.EncryptedRefreshToken = EncryptedRefreshToken;
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
        //      C# -> System.String? AppId
        // GraphQL -> appId: String! (scalar)
        if (this.AppId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "appId\n" ;
            } else {
                s += ind + "appId\n" ;
            }
        }
        //      C# -> System.String? EncryptedRefreshToken
        // GraphQL -> encryptedRefreshToken: String! (scalar)
        if (this.EncryptedRefreshToken != null) {
            if (conf.Flat) {
                s += conf.Prefix + "encryptedRefreshToken\n" ;
            } else {
                s += ind + "encryptedRefreshToken\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? AppId
        // GraphQL -> appId: String! (scalar)
        if (ec.Includes("appId",true))
        {
            if(this.AppId == null) {

                this.AppId = "FETCH";

            } else {


            }
        }
        else if (this.AppId != null && ec.Excludes("appId",true))
        {
            this.AppId = null;
        }
        //      C# -> System.String? EncryptedRefreshToken
        // GraphQL -> encryptedRefreshToken: String! (scalar)
        if (ec.Includes("encryptedRefreshToken",true))
        {
            if(this.EncryptedRefreshToken == null) {

                this.EncryptedRefreshToken = "FETCH";

            } else {


            }
        }
        else if (this.EncryptedRefreshToken != null && ec.Excludes("encryptedRefreshToken",true))
        {
            this.EncryptedRefreshToken = null;
        }
    }


    #endregion

    } // class O365OauthConsentCompleteReply
    
    #endregion

    public static class ListO365OauthConsentCompleteReplyExtensions
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
            this List<O365OauthConsentCompleteReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<O365OauthConsentCompleteReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<O365OauthConsentCompleteReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new O365OauthConsentCompleteReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<O365OauthConsentCompleteReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types