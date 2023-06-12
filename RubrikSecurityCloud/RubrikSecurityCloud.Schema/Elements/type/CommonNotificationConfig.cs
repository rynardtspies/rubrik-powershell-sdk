// CommonNotificationConfig.cs
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
    #region CommonNotificationConfig
    public class CommonNotificationConfig: BaseType
    {
        #region members

        //      C# -> NetworkProtocolTypeEnum? NetworkType
        // GraphQL -> networkType: NetworkProtocolTypeEnum! (enum)
        [JsonProperty("networkType")]
        public NetworkProtocolTypeEnum? NetworkType { get; set; }

        //      C# -> SmtpSecurityTypeEnum? SecurityType
        // GraphQL -> securityType: SMTPSecurityTypeEnum! (enum)
        [JsonProperty("securityType")]
        public SmtpSecurityTypeEnum? SecurityType { get; set; }

        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        [JsonProperty("hostname")]
        public System.String? Hostname { get; set; }

        //      C# -> System.Int32? Port
        // GraphQL -> port: Int! (scalar)
        [JsonProperty("port")]
        public System.Int32? Port { get; set; }

        //      C# -> System.String? TrustedCerts
        // GraphQL -> trustedCerts: String! (scalar)
        [JsonProperty("trustedCerts")]
        public System.String? TrustedCerts { get; set; }


        #endregion

    #region methods

    public CommonNotificationConfig Set(
        NetworkProtocolTypeEnum? NetworkType = null,
        SmtpSecurityTypeEnum? SecurityType = null,
        System.String? Hostname = null,
        System.Int32? Port = null,
        System.String? TrustedCerts = null
    ) 
    {
        if ( NetworkType != null ) {
            this.NetworkType = NetworkType;
        }
        if ( SecurityType != null ) {
            this.SecurityType = SecurityType;
        }
        if ( Hostname != null ) {
            this.Hostname = Hostname;
        }
        if ( Port != null ) {
            this.Port = Port;
        }
        if ( TrustedCerts != null ) {
            this.TrustedCerts = TrustedCerts;
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
        //      C# -> NetworkProtocolTypeEnum? NetworkType
        // GraphQL -> networkType: NetworkProtocolTypeEnum! (enum)
        if (this.NetworkType != null) {
            s += ind + "networkType\n" ;
        }
        //      C# -> SmtpSecurityTypeEnum? SecurityType
        // GraphQL -> securityType: SMTPSecurityTypeEnum! (enum)
        if (this.SecurityType != null) {
            s += ind + "securityType\n" ;
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        if (this.Hostname != null) {
            s += ind + "hostname\n" ;
        }
        //      C# -> System.Int32? Port
        // GraphQL -> port: Int! (scalar)
        if (this.Port != null) {
            s += ind + "port\n" ;
        }
        //      C# -> System.String? TrustedCerts
        // GraphQL -> trustedCerts: String! (scalar)
        if (this.TrustedCerts != null) {
            s += ind + "trustedCerts\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> NetworkProtocolTypeEnum? NetworkType
        // GraphQL -> networkType: NetworkProtocolTypeEnum! (enum)
        if (this.NetworkType == null && Exploration.Includes(parent + ".networkType", true))
        {
            this.NetworkType = new NetworkProtocolTypeEnum();
        }
        //      C# -> SmtpSecurityTypeEnum? SecurityType
        // GraphQL -> securityType: SMTPSecurityTypeEnum! (enum)
        if (this.SecurityType == null && Exploration.Includes(parent + ".securityType", true))
        {
            this.SecurityType = new SmtpSecurityTypeEnum();
        }
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        if (this.Hostname == null && Exploration.Includes(parent + ".hostname", true))
        {
            this.Hostname = "FETCH";
        }
        //      C# -> System.Int32? Port
        // GraphQL -> port: Int! (scalar)
        if (this.Port == null && Exploration.Includes(parent + ".port", true))
        {
            this.Port = Int32.MinValue;
        }
        //      C# -> System.String? TrustedCerts
        // GraphQL -> trustedCerts: String! (scalar)
        if (this.TrustedCerts == null && Exploration.Includes(parent + ".trustedCerts", true))
        {
            this.TrustedCerts = "FETCH";
        }
    }


    #endregion

    } // class CommonNotificationConfig
    
    #endregion

    public static class ListCommonNotificationConfigExtensions
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
            this List<CommonNotificationConfig> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CommonNotificationConfig> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CommonNotificationConfig());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types