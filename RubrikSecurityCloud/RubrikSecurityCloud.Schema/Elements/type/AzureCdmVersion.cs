// AzureCdmVersion.cs
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
    #region AzureCdmVersion
    public class AzureCdmVersion: BaseType
    {
        #region members

        //      C# -> List<AzureInstanceType>? SupportedInstanceTypes
        // GraphQL -> supportedInstanceTypes: [AzureInstanceType!]! (enum)
        [JsonProperty("supportedInstanceTypes")]
        public List<AzureInstanceType>? SupportedInstanceTypes { get; set; }

        //      C# -> System.String? CdmVersion
        // GraphQL -> cdmVersion: String! (scalar)
        [JsonProperty("cdmVersion")]
        public System.String? CdmVersion { get; set; }

        //      C# -> System.String? Sku
        // GraphQL -> sku: String! (scalar)
        [JsonProperty("sku")]
        public System.String? Sku { get; set; }

        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        [JsonProperty("version")]
        public System.String? Version { get; set; }

        //      C# -> List<AzureCdmVersionTag>? Tags
        // GraphQL -> tags: [AzureCdmVersionTag!]! (type)
        [JsonProperty("tags")]
        public List<AzureCdmVersionTag>? Tags { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureCdmVersion";
    }

    public AzureCdmVersion Set(
        List<AzureInstanceType>? SupportedInstanceTypes = null,
        System.String? CdmVersion = null,
        System.String? Sku = null,
        System.String? Version = null,
        List<AzureCdmVersionTag>? Tags = null
    ) 
    {
        if ( SupportedInstanceTypes != null ) {
            this.SupportedInstanceTypes = SupportedInstanceTypes;
        }
        if ( CdmVersion != null ) {
            this.CdmVersion = CdmVersion;
        }
        if ( Sku != null ) {
            this.Sku = Sku;
        }
        if ( Version != null ) {
            this.Version = Version;
        }
        if ( Tags != null ) {
            this.Tags = Tags;
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
        //      C# -> List<AzureInstanceType>? SupportedInstanceTypes
        // GraphQL -> supportedInstanceTypes: [AzureInstanceType!]! (enum)
        if (this.SupportedInstanceTypes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "supportedInstanceTypes\n" ;
            } else {
                s += ind + "supportedInstanceTypes\n" ;
            }
        }
        //      C# -> System.String? CdmVersion
        // GraphQL -> cdmVersion: String! (scalar)
        if (this.CdmVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cdmVersion\n" ;
            } else {
                s += ind + "cdmVersion\n" ;
            }
        }
        //      C# -> System.String? Sku
        // GraphQL -> sku: String! (scalar)
        if (this.Sku != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sku\n" ;
            } else {
                s += ind + "sku\n" ;
            }
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (this.Version != null) {
            if (conf.Flat) {
                s += conf.Prefix + "version\n" ;
            } else {
                s += ind + "version\n" ;
            }
        }
        //      C# -> List<AzureCdmVersionTag>? Tags
        // GraphQL -> tags: [AzureCdmVersionTag!]! (type)
        if (this.Tags != null) {
            var fspec = this.Tags.AsFieldSpec(conf.Child("tags"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "tags {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<AzureInstanceType>? SupportedInstanceTypes
        // GraphQL -> supportedInstanceTypes: [AzureInstanceType!]! (enum)
        if (ec.Includes("supportedInstanceTypes",true))
        {
            if(this.SupportedInstanceTypes == null) {

                this.SupportedInstanceTypes = new List<AzureInstanceType>();

            } else {


            }
        }
        else if (this.SupportedInstanceTypes != null && ec.Excludes("supportedInstanceTypes",true))
        {
            this.SupportedInstanceTypes = null;
        }
        //      C# -> System.String? CdmVersion
        // GraphQL -> cdmVersion: String! (scalar)
        if (ec.Includes("cdmVersion",true))
        {
            if(this.CdmVersion == null) {

                this.CdmVersion = "FETCH";

            } else {


            }
        }
        else if (this.CdmVersion != null && ec.Excludes("cdmVersion",true))
        {
            this.CdmVersion = null;
        }
        //      C# -> System.String? Sku
        // GraphQL -> sku: String! (scalar)
        if (ec.Includes("sku",true))
        {
            if(this.Sku == null) {

                this.Sku = "FETCH";

            } else {


            }
        }
        else if (this.Sku != null && ec.Excludes("sku",true))
        {
            this.Sku = null;
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (ec.Includes("version",true))
        {
            if(this.Version == null) {

                this.Version = "FETCH";

            } else {


            }
        }
        else if (this.Version != null && ec.Excludes("version",true))
        {
            this.Version = null;
        }
        //      C# -> List<AzureCdmVersionTag>? Tags
        // GraphQL -> tags: [AzureCdmVersionTag!]! (type)
        if (ec.Includes("tags",false))
        {
            if(this.Tags == null) {

                this.Tags = new List<AzureCdmVersionTag>();
                this.Tags.ApplyExploratoryFieldSpec(ec.NewChild("tags"));

            } else {

                this.Tags.ApplyExploratoryFieldSpec(ec.NewChild("tags"));

            }
        }
        else if (this.Tags != null && ec.Excludes("tags",false))
        {
            this.Tags = null;
        }
    }


    #endregion

    } // class AzureCdmVersion
    
    #endregion

    public static class ListAzureCdmVersionExtensions
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
            this List<AzureCdmVersion> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<AzureCdmVersion> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureCdmVersion> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureCdmVersion());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureCdmVersion> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types