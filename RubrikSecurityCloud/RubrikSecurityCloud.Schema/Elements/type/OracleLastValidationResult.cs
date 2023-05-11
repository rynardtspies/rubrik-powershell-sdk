// OracleLastValidationResult.cs
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

namespace Rubrik.SecurityCloud.Types
{
    #region OracleLastValidationResult
    public class OracleLastValidationResult: IFragment
    {
        #region members
        //      C# -> System.String? EventSeriesId
        // GraphQL -> eventSeriesId: String! (scalar)
        [JsonProperty("eventSeriesId")]
        public System.String? EventSeriesId { get; set; }

        //      C# -> System.Boolean? IsSuccess
        // GraphQL -> isSuccess: Boolean! (scalar)
        [JsonProperty("isSuccess")]
        public System.Boolean? IsSuccess { get; set; }

        //      C# -> DateTime? ValidationTime
        // GraphQL -> validationTime: DateTime (scalar)
        [JsonProperty("validationTime")]
        public DateTime? ValidationTime { get; set; }

        #endregion

    #region methods

    public OracleLastValidationResult Set(
        System.String? EventSeriesId = null,
        System.Boolean? IsSuccess = null,
        DateTime? ValidationTime = null
    ) 
    {
        if ( EventSeriesId != null ) {
            this.EventSeriesId = EventSeriesId;
        }
        if ( IsSuccess != null ) {
            this.IsSuccess = IsSuccess;
        }
        if ( ValidationTime != null ) {
            this.ValidationTime = ValidationTime;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? EventSeriesId
            // GraphQL -> eventSeriesId: String! (scalar)
            if (this.EventSeriesId != null)
            {
                 s += ind + "eventSeriesId\n";

            }
            //      C# -> System.Boolean? IsSuccess
            // GraphQL -> isSuccess: Boolean! (scalar)
            if (this.IsSuccess != null)
            {
                 s += ind + "isSuccess\n";

            }
            //      C# -> DateTime? ValidationTime
            // GraphQL -> validationTime: DateTime (scalar)
            if (this.ValidationTime != null)
            {
                 s += ind + "validationTime\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? EventSeriesId
            // GraphQL -> eventSeriesId: String! (scalar)
            if (this.EventSeriesId == null && Exploration.Includes(parent + ".eventSeriesId$"))
            {
                this.EventSeriesId = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsSuccess
            // GraphQL -> isSuccess: Boolean! (scalar)
            if (this.IsSuccess == null && Exploration.Includes(parent + ".isSuccess$"))
            {
                this.IsSuccess = new System.Boolean();
            }
            //      C# -> DateTime? ValidationTime
            // GraphQL -> validationTime: DateTime (scalar)
            if (this.ValidationTime == null && Exploration.Includes(parent + ".validationTime$"))
            {
                this.ValidationTime = new DateTime();
            }
        }


    #endregion

    } // class OracleLastValidationResult
    #endregion

    public static class ListOracleLastValidationResultExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<OracleLastValidationResult> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<OracleLastValidationResult> list, 
            String parent = "")
        {
            var item = new OracleLastValidationResult();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types