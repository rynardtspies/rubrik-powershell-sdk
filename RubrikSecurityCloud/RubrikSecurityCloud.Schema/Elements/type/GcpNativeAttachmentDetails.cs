// GcpNativeAttachmentDetails.cs
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
    #region GcpNativeAttachmentDetails
    public class GcpNativeAttachmentDetails: BaseType
    {
        #region members

        //      C# -> System.String? DeviceName
        // GraphQL -> deviceName: String! (scalar)
        [JsonProperty("deviceName")]
        public System.String? DeviceName { get; set; }

        //      C# -> System.String? DiskId
        // GraphQL -> diskId: String! (scalar)
        [JsonProperty("diskId")]
        public System.String? DiskId { get; set; }

        //      C# -> System.String? DiskName
        // GraphQL -> diskName: String! (scalar)
        [JsonProperty("diskName")]
        public System.String? DiskName { get; set; }

        //      C# -> System.String? InstanceId
        // GraphQL -> instanceId: String! (scalar)
        [JsonProperty("instanceId")]
        public System.String? InstanceId { get; set; }

        //      C# -> System.String? InstanceName
        // GraphQL -> instanceName: String! (scalar)
        [JsonProperty("instanceName")]
        public System.String? InstanceName { get; set; }

        //      C# -> System.String? InstanceZone
        // GraphQL -> instanceZone: String! (scalar)
        [JsonProperty("instanceZone")]
        public System.String? InstanceZone { get; set; }

        //      C# -> System.Boolean? IsBootDisk
        // GraphQL -> isBootDisk: Boolean! (scalar)
        [JsonProperty("isBootDisk")]
        public System.Boolean? IsBootDisk { get; set; }

        //      C# -> System.Boolean? IsExcluded
        // GraphQL -> isExcluded: Boolean! (scalar)
        [JsonProperty("isExcluded")]
        public System.Boolean? IsExcluded { get; set; }

        //      C# -> System.Int32? SizeInGiBs
        // GraphQL -> sizeInGiBs: Int! (scalar)
        [JsonProperty("sizeInGiBs")]
        public System.Int32? SizeInGiBs { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GcpNativeAttachmentDetails";
    }

    public GcpNativeAttachmentDetails Set(
        System.String? DeviceName = null,
        System.String? DiskId = null,
        System.String? DiskName = null,
        System.String? InstanceId = null,
        System.String? InstanceName = null,
        System.String? InstanceZone = null,
        System.Boolean? IsBootDisk = null,
        System.Boolean? IsExcluded = null,
        System.Int32? SizeInGiBs = null
    ) 
    {
        if ( DeviceName != null ) {
            this.DeviceName = DeviceName;
        }
        if ( DiskId != null ) {
            this.DiskId = DiskId;
        }
        if ( DiskName != null ) {
            this.DiskName = DiskName;
        }
        if ( InstanceId != null ) {
            this.InstanceId = InstanceId;
        }
        if ( InstanceName != null ) {
            this.InstanceName = InstanceName;
        }
        if ( InstanceZone != null ) {
            this.InstanceZone = InstanceZone;
        }
        if ( IsBootDisk != null ) {
            this.IsBootDisk = IsBootDisk;
        }
        if ( IsExcluded != null ) {
            this.IsExcluded = IsExcluded;
        }
        if ( SizeInGiBs != null ) {
            this.SizeInGiBs = SizeInGiBs;
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
        //      C# -> System.String? DeviceName
        // GraphQL -> deviceName: String! (scalar)
        if (this.DeviceName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "deviceName\n" ;
            } else {
                s += ind + "deviceName\n" ;
            }
        }
        //      C# -> System.String? DiskId
        // GraphQL -> diskId: String! (scalar)
        if (this.DiskId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "diskId\n" ;
            } else {
                s += ind + "diskId\n" ;
            }
        }
        //      C# -> System.String? DiskName
        // GraphQL -> diskName: String! (scalar)
        if (this.DiskName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "diskName\n" ;
            } else {
                s += ind + "diskName\n" ;
            }
        }
        //      C# -> System.String? InstanceId
        // GraphQL -> instanceId: String! (scalar)
        if (this.InstanceId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "instanceId\n" ;
            } else {
                s += ind + "instanceId\n" ;
            }
        }
        //      C# -> System.String? InstanceName
        // GraphQL -> instanceName: String! (scalar)
        if (this.InstanceName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "instanceName\n" ;
            } else {
                s += ind + "instanceName\n" ;
            }
        }
        //      C# -> System.String? InstanceZone
        // GraphQL -> instanceZone: String! (scalar)
        if (this.InstanceZone != null) {
            if (conf.Flat) {
                s += conf.Prefix + "instanceZone\n" ;
            } else {
                s += ind + "instanceZone\n" ;
            }
        }
        //      C# -> System.Boolean? IsBootDisk
        // GraphQL -> isBootDisk: Boolean! (scalar)
        if (this.IsBootDisk != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isBootDisk\n" ;
            } else {
                s += ind + "isBootDisk\n" ;
            }
        }
        //      C# -> System.Boolean? IsExcluded
        // GraphQL -> isExcluded: Boolean! (scalar)
        if (this.IsExcluded != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isExcluded\n" ;
            } else {
                s += ind + "isExcluded\n" ;
            }
        }
        //      C# -> System.Int32? SizeInGiBs
        // GraphQL -> sizeInGiBs: Int! (scalar)
        if (this.SizeInGiBs != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sizeInGiBs\n" ;
            } else {
                s += ind + "sizeInGiBs\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? DeviceName
        // GraphQL -> deviceName: String! (scalar)
        if (ec.Includes("deviceName",true))
        {
            if(this.DeviceName == null) {

                this.DeviceName = "FETCH";

            } else {


            }
        }
        else if (this.DeviceName != null && ec.Excludes("deviceName",true))
        {
            this.DeviceName = null;
        }
        //      C# -> System.String? DiskId
        // GraphQL -> diskId: String! (scalar)
        if (ec.Includes("diskId",true))
        {
            if(this.DiskId == null) {

                this.DiskId = "FETCH";

            } else {


            }
        }
        else if (this.DiskId != null && ec.Excludes("diskId",true))
        {
            this.DiskId = null;
        }
        //      C# -> System.String? DiskName
        // GraphQL -> diskName: String! (scalar)
        if (ec.Includes("diskName",true))
        {
            if(this.DiskName == null) {

                this.DiskName = "FETCH";

            } else {


            }
        }
        else if (this.DiskName != null && ec.Excludes("diskName",true))
        {
            this.DiskName = null;
        }
        //      C# -> System.String? InstanceId
        // GraphQL -> instanceId: String! (scalar)
        if (ec.Includes("instanceId",true))
        {
            if(this.InstanceId == null) {

                this.InstanceId = "FETCH";

            } else {


            }
        }
        else if (this.InstanceId != null && ec.Excludes("instanceId",true))
        {
            this.InstanceId = null;
        }
        //      C# -> System.String? InstanceName
        // GraphQL -> instanceName: String! (scalar)
        if (ec.Includes("instanceName",true))
        {
            if(this.InstanceName == null) {

                this.InstanceName = "FETCH";

            } else {


            }
        }
        else if (this.InstanceName != null && ec.Excludes("instanceName",true))
        {
            this.InstanceName = null;
        }
        //      C# -> System.String? InstanceZone
        // GraphQL -> instanceZone: String! (scalar)
        if (ec.Includes("instanceZone",true))
        {
            if(this.InstanceZone == null) {

                this.InstanceZone = "FETCH";

            } else {


            }
        }
        else if (this.InstanceZone != null && ec.Excludes("instanceZone",true))
        {
            this.InstanceZone = null;
        }
        //      C# -> System.Boolean? IsBootDisk
        // GraphQL -> isBootDisk: Boolean! (scalar)
        if (ec.Includes("isBootDisk",true))
        {
            if(this.IsBootDisk == null) {

                this.IsBootDisk = true;

            } else {


            }
        }
        else if (this.IsBootDisk != null && ec.Excludes("isBootDisk",true))
        {
            this.IsBootDisk = null;
        }
        //      C# -> System.Boolean? IsExcluded
        // GraphQL -> isExcluded: Boolean! (scalar)
        if (ec.Includes("isExcluded",true))
        {
            if(this.IsExcluded == null) {

                this.IsExcluded = true;

            } else {


            }
        }
        else if (this.IsExcluded != null && ec.Excludes("isExcluded",true))
        {
            this.IsExcluded = null;
        }
        //      C# -> System.Int32? SizeInGiBs
        // GraphQL -> sizeInGiBs: Int! (scalar)
        if (ec.Includes("sizeInGiBs",true))
        {
            if(this.SizeInGiBs == null) {

                this.SizeInGiBs = Int32.MinValue;

            } else {


            }
        }
        else if (this.SizeInGiBs != null && ec.Excludes("sizeInGiBs",true))
        {
            this.SizeInGiBs = null;
        }
    }


    #endregion

    } // class GcpNativeAttachmentDetails
    
    #endregion

    public static class ListGcpNativeAttachmentDetailsExtensions
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
            this List<GcpNativeAttachmentDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<GcpNativeAttachmentDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GcpNativeAttachmentDetails> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GcpNativeAttachmentDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GcpNativeAttachmentDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types