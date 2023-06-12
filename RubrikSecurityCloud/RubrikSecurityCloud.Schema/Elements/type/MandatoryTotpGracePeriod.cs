// MandatoryTotpGracePeriod.cs
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
    #region MandatoryTotpGracePeriod
    public class MandatoryTotpGracePeriod: BaseType
    {
        #region members

        //      C# -> DateTime? MandatoryTotpEnforcementDate
        // GraphQL -> mandatoryTotpEnforcementDate: DateTime (scalar)
        [JsonProperty("mandatoryTotpEnforcementDate")]
        public DateTime? MandatoryTotpEnforcementDate { get; set; }

        //      C# -> System.Boolean? ShouldHideMandatoryTotpGracePeriodWarning
        // GraphQL -> shouldHideMandatoryTotpGracePeriodWarning: Boolean! (scalar)
        [JsonProperty("shouldHideMandatoryTotpGracePeriodWarning")]
        public System.Boolean? ShouldHideMandatoryTotpGracePeriodWarning { get; set; }


        #endregion

    #region methods

    public MandatoryTotpGracePeriod Set(
        DateTime? MandatoryTotpEnforcementDate = null,
        System.Boolean? ShouldHideMandatoryTotpGracePeriodWarning = null
    ) 
    {
        if ( MandatoryTotpEnforcementDate != null ) {
            this.MandatoryTotpEnforcementDate = MandatoryTotpEnforcementDate;
        }
        if ( ShouldHideMandatoryTotpGracePeriodWarning != null ) {
            this.ShouldHideMandatoryTotpGracePeriodWarning = ShouldHideMandatoryTotpGracePeriodWarning;
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
        //      C# -> DateTime? MandatoryTotpEnforcementDate
        // GraphQL -> mandatoryTotpEnforcementDate: DateTime (scalar)
        if (this.MandatoryTotpEnforcementDate != null) {
            s += ind + "mandatoryTotpEnforcementDate\n" ;
        }
        //      C# -> System.Boolean? ShouldHideMandatoryTotpGracePeriodWarning
        // GraphQL -> shouldHideMandatoryTotpGracePeriodWarning: Boolean! (scalar)
        if (this.ShouldHideMandatoryTotpGracePeriodWarning != null) {
            s += ind + "shouldHideMandatoryTotpGracePeriodWarning\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> DateTime? MandatoryTotpEnforcementDate
        // GraphQL -> mandatoryTotpEnforcementDate: DateTime (scalar)
        if (this.MandatoryTotpEnforcementDate == null && Exploration.Includes(parent + ".mandatoryTotpEnforcementDate", true))
        {
            this.MandatoryTotpEnforcementDate = new DateTime();
        }
        //      C# -> System.Boolean? ShouldHideMandatoryTotpGracePeriodWarning
        // GraphQL -> shouldHideMandatoryTotpGracePeriodWarning: Boolean! (scalar)
        if (this.ShouldHideMandatoryTotpGracePeriodWarning == null && Exploration.Includes(parent + ".shouldHideMandatoryTotpGracePeriodWarning", true))
        {
            this.ShouldHideMandatoryTotpGracePeriodWarning = true;
        }
    }


    #endregion

    } // class MandatoryTotpGracePeriod
    
    #endregion

    public static class ListMandatoryTotpGracePeriodExtensions
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
            this List<MandatoryTotpGracePeriod> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MandatoryTotpGracePeriod> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new MandatoryTotpGracePeriod());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types