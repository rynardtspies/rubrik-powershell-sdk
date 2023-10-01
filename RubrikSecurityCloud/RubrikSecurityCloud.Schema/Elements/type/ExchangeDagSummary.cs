// ExchangeDagSummary.cs
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
    #region ExchangeDagSummary
    public class ExchangeDagSummary: BaseType
    {
        #region members

        //      C# -> ExchangeBackupPreference? BackupPreference
        // GraphQL -> backupPreference: ExchangeBackupPreference! (enum)
        [JsonProperty("backupPreference")]
        public ExchangeBackupPreference? BackupPreference { get; set; }

        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String! (scalar)
        [JsonProperty("configuredSlaDomainId")]
        public System.String? ConfiguredSlaDomainId { get; set; }

        //      C# -> System.String? ConfiguredSlaType
        // GraphQL -> configuredSlaType: String! (scalar)
        [JsonProperty("configuredSlaType")]
        public System.String? ConfiguredSlaType { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ExchangeDagSummary";
    }

    public ExchangeDagSummary Set(
        ExchangeBackupPreference? BackupPreference = null,
        System.String? ConfiguredSlaDomainId = null,
        System.String? ConfiguredSlaType = null,
        System.String? Id = null,
        System.String? Name = null
    ) 
    {
        if ( BackupPreference != null ) {
            this.BackupPreference = BackupPreference;
        }
        if ( ConfiguredSlaDomainId != null ) {
            this.ConfiguredSlaDomainId = ConfiguredSlaDomainId;
        }
        if ( ConfiguredSlaType != null ) {
            this.ConfiguredSlaType = ConfiguredSlaType;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
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
        //      C# -> ExchangeBackupPreference? BackupPreference
        // GraphQL -> backupPreference: ExchangeBackupPreference! (enum)
        if (this.BackupPreference != null) {
            if (conf.Flat) {
                s += conf.Prefix + "backupPreference\n" ;
            } else {
                s += ind + "backupPreference\n" ;
            }
        }
        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String! (scalar)
        if (this.ConfiguredSlaDomainId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "configuredSlaDomainId\n" ;
            } else {
                s += ind + "configuredSlaDomainId\n" ;
            }
        }
        //      C# -> System.String? ConfiguredSlaType
        // GraphQL -> configuredSlaType: String! (scalar)
        if (this.ConfiguredSlaType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "configuredSlaType\n" ;
            } else {
                s += ind + "configuredSlaType\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ExchangeBackupPreference? BackupPreference
        // GraphQL -> backupPreference: ExchangeBackupPreference! (enum)
        if (ec.Includes("backupPreference",true))
        {
            if(this.BackupPreference == null) {

                this.BackupPreference = new ExchangeBackupPreference();

            } else {


            }
        }
        else if (this.BackupPreference != null && ec.Excludes("backupPreference",true))
        {
            this.BackupPreference = null;
        }
        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String! (scalar)
        if (ec.Includes("configuredSlaDomainId",true))
        {
            if(this.ConfiguredSlaDomainId == null) {

                this.ConfiguredSlaDomainId = "FETCH";

            } else {


            }
        }
        else if (this.ConfiguredSlaDomainId != null && ec.Excludes("configuredSlaDomainId",true))
        {
            this.ConfiguredSlaDomainId = null;
        }
        //      C# -> System.String? ConfiguredSlaType
        // GraphQL -> configuredSlaType: String! (scalar)
        if (ec.Includes("configuredSlaType",true))
        {
            if(this.ConfiguredSlaType == null) {

                this.ConfiguredSlaType = "FETCH";

            } else {


            }
        }
        else if (this.ConfiguredSlaType != null && ec.Excludes("configuredSlaType",true))
        {
            this.ConfiguredSlaType = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
    }


    #endregion

    } // class ExchangeDagSummary
    
    #endregion

    public static class ListExchangeDagSummaryExtensions
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
            this List<ExchangeDagSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<ExchangeDagSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ExchangeDagSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ExchangeDagSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ExchangeDagSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types