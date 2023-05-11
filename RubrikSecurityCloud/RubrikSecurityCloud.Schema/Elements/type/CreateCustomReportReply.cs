// CreateCustomReportReply.cs
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
    #region CreateCustomReportReply
    public class CreateCustomReportReply: IFragment
    {
        #region members
        //      C# -> DateTime? CreatedAt
        // GraphQL -> createdAt: DateTime! (scalar)
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; set; }

        //      C# -> System.Int32? Id
        // GraphQL -> id: Int! (scalar)
        [JsonProperty("id")]
        public System.Int32? Id { get; set; }

        //      C# -> System.Boolean? IsHidden
        // GraphQL -> isHidden: Boolean! (scalar)
        [JsonProperty("isHidden")]
        public System.Boolean? IsHidden { get; set; }

        //      C# -> System.Boolean? IsReadOnly
        // GraphQL -> isReadOnly: Boolean! (scalar)
        [JsonProperty("isReadOnly")]
        public System.Boolean? IsReadOnly { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> DateTime? NewestSyncDate
        // GraphQL -> newestSyncDate: DateTime (scalar)
        [JsonProperty("newestSyncDate")]
        public DateTime? NewestSyncDate { get; set; }

        //      C# -> DateTime? OldestSyncDate
        // GraphQL -> oldestSyncDate: DateTime (scalar)
        [JsonProperty("oldestSyncDate")]
        public DateTime? OldestSyncDate { get; set; }

        //      C# -> DateTime? UpdatedAt
        // GraphQL -> updatedAt: DateTime! (scalar)
        [JsonProperty("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        //      C# -> DateTime? ViewedAt
        // GraphQL -> viewedAt: DateTime! (scalar)
        [JsonProperty("viewedAt")]
        public DateTime? ViewedAt { get; set; }

        //      C# -> CustomReportFilters? Filters
        // GraphQL -> filters: CustomReportFilters! (type)
        [JsonProperty("filters")]
        public CustomReportFilters? Filters { get; set; }

        //      C# -> User? Owner
        // GraphQL -> owner: User! (type)
        [JsonProperty("owner")]
        public User? Owner { get; set; }

        //      C# -> ScheduledReportConnection? ScheduledReportConnection
        // GraphQL -> scheduledReportConnection: ScheduledReportConnection! (type)
        [JsonProperty("scheduledReportConnection")]
        public ScheduledReportConnection? ScheduledReportConnection { get; set; }

        //      C# -> ReportFocusEnum? Focus
        // GraphQL -> focus: ReportFocusEnum! (enum)
        [JsonProperty("focus")]
        public ReportFocusEnum? Focus { get; set; }

        //      C# -> List<ReportChartType>? Charts
        // GraphQL -> charts: [ReportChartType!]! (union)
        [JsonProperty("charts")]
        public List<ReportChartType>? Charts { get; set; }

        //      C# -> List<ReportTableType>? Tables
        // GraphQL -> tables: [ReportTableType!]! (union)
        [JsonProperty("tables")]
        public List<ReportTableType>? Tables { get; set; }

        #endregion

    #region methods

    public CreateCustomReportReply Set(
        DateTime? CreatedAt = null,
        System.Int32? Id = null,
        System.Boolean? IsHidden = null,
        System.Boolean? IsReadOnly = null,
        System.String? Name = null,
        DateTime? NewestSyncDate = null,
        DateTime? OldestSyncDate = null,
        DateTime? UpdatedAt = null,
        DateTime? ViewedAt = null,
        CustomReportFilters? Filters = null,
        User? Owner = null,
        ScheduledReportConnection? ScheduledReportConnection = null,
        ReportFocusEnum? Focus = null,
        List<ReportChartType>? Charts = null,
        List<ReportTableType>? Tables = null
    ) 
    {
        if ( CreatedAt != null ) {
            this.CreatedAt = CreatedAt;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsHidden != null ) {
            this.IsHidden = IsHidden;
        }
        if ( IsReadOnly != null ) {
            this.IsReadOnly = IsReadOnly;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NewestSyncDate != null ) {
            this.NewestSyncDate = NewestSyncDate;
        }
        if ( OldestSyncDate != null ) {
            this.OldestSyncDate = OldestSyncDate;
        }
        if ( UpdatedAt != null ) {
            this.UpdatedAt = UpdatedAt;
        }
        if ( ViewedAt != null ) {
            this.ViewedAt = ViewedAt;
        }
        if ( Filters != null ) {
            this.Filters = Filters;
        }
        if ( Owner != null ) {
            this.Owner = Owner;
        }
        if ( ScheduledReportConnection != null ) {
            this.ScheduledReportConnection = ScheduledReportConnection;
        }
        if ( Focus != null ) {
            this.Focus = Focus;
        }
        if ( Charts != null ) {
            this.Charts = Charts;
        }
        if ( Tables != null ) {
            this.Tables = Tables;
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
            //      C# -> DateTime? CreatedAt
            // GraphQL -> createdAt: DateTime! (scalar)
            if (this.CreatedAt != null)
            {
                 s += ind + "createdAt\n";

            }
            //      C# -> System.Int32? Id
            // GraphQL -> id: Int! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Boolean? IsHidden
            // GraphQL -> isHidden: Boolean! (scalar)
            if (this.IsHidden != null)
            {
                 s += ind + "isHidden\n";

            }
            //      C# -> System.Boolean? IsReadOnly
            // GraphQL -> isReadOnly: Boolean! (scalar)
            if (this.IsReadOnly != null)
            {
                 s += ind + "isReadOnly\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> DateTime? NewestSyncDate
            // GraphQL -> newestSyncDate: DateTime (scalar)
            if (this.NewestSyncDate != null)
            {
                 s += ind + "newestSyncDate\n";

            }
            //      C# -> DateTime? OldestSyncDate
            // GraphQL -> oldestSyncDate: DateTime (scalar)
            if (this.OldestSyncDate != null)
            {
                 s += ind + "oldestSyncDate\n";

            }
            //      C# -> DateTime? UpdatedAt
            // GraphQL -> updatedAt: DateTime! (scalar)
            if (this.UpdatedAt != null)
            {
                 s += ind + "updatedAt\n";

            }
            //      C# -> DateTime? ViewedAt
            // GraphQL -> viewedAt: DateTime! (scalar)
            if (this.ViewedAt != null)
            {
                 s += ind + "viewedAt\n";

            }
            //      C# -> CustomReportFilters? Filters
            // GraphQL -> filters: CustomReportFilters! (type)
            if (this.Filters != null)
            {
                 s += ind + "filters\n";

                 s += ind + "{\n" + 
                 this.Filters.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> User? Owner
            // GraphQL -> owner: User! (type)
            if (this.Owner != null)
            {
                 s += ind + "owner\n";

                 s += ind + "{\n" + 
                 this.Owner.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ScheduledReportConnection? ScheduledReportConnection
            // GraphQL -> scheduledReportConnection: ScheduledReportConnection! (type)
            if (this.ScheduledReportConnection != null)
            {
                 s += ind + "scheduledReportConnection\n";

                 s += ind + "{\n" + 
                 this.ScheduledReportConnection.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ReportFocusEnum? Focus
            // GraphQL -> focus: ReportFocusEnum! (enum)
            if (this.Focus != null)
            {
                 s += ind + "focus\n";

            }
            //      C# -> List<ReportChartType>? Charts
            // GraphQL -> charts: [ReportChartType!]! (union)
            if (this.Charts != null)
            {
                 s += ind + "charts\n";

                 s += ind + "{\n" + 
                 this.Charts.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<ReportTableType>? Tables
            // GraphQL -> tables: [ReportTableType!]! (union)
            if (this.Tables != null)
            {
                 s += ind + "tables\n";

                 s += ind + "{\n" + 
                 this.Tables.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> DateTime? CreatedAt
            // GraphQL -> createdAt: DateTime! (scalar)
            if (this.CreatedAt == null && Exploration.Includes(parent + ".createdAt$"))
            {
                this.CreatedAt = new DateTime();
            }
            //      C# -> System.Int32? Id
            // GraphQL -> id: Int! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.Int32();
            }
            //      C# -> System.Boolean? IsHidden
            // GraphQL -> isHidden: Boolean! (scalar)
            if (this.IsHidden == null && Exploration.Includes(parent + ".isHidden$"))
            {
                this.IsHidden = new System.Boolean();
            }
            //      C# -> System.Boolean? IsReadOnly
            // GraphQL -> isReadOnly: Boolean! (scalar)
            if (this.IsReadOnly == null && Exploration.Includes(parent + ".isReadOnly$"))
            {
                this.IsReadOnly = new System.Boolean();
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> DateTime? NewestSyncDate
            // GraphQL -> newestSyncDate: DateTime (scalar)
            if (this.NewestSyncDate == null && Exploration.Includes(parent + ".newestSyncDate$"))
            {
                this.NewestSyncDate = new DateTime();
            }
            //      C# -> DateTime? OldestSyncDate
            // GraphQL -> oldestSyncDate: DateTime (scalar)
            if (this.OldestSyncDate == null && Exploration.Includes(parent + ".oldestSyncDate$"))
            {
                this.OldestSyncDate = new DateTime();
            }
            //      C# -> DateTime? UpdatedAt
            // GraphQL -> updatedAt: DateTime! (scalar)
            if (this.UpdatedAt == null && Exploration.Includes(parent + ".updatedAt$"))
            {
                this.UpdatedAt = new DateTime();
            }
            //      C# -> DateTime? ViewedAt
            // GraphQL -> viewedAt: DateTime! (scalar)
            if (this.ViewedAt == null && Exploration.Includes(parent + ".viewedAt$"))
            {
                this.ViewedAt = new DateTime();
            }
            //      C# -> CustomReportFilters? Filters
            // GraphQL -> filters: CustomReportFilters! (type)
            if (this.Filters == null && Exploration.Includes(parent + ".filters"))
            {
                this.Filters = new CustomReportFilters();
                this.Filters.ApplyExploratoryFragment(parent + ".filters");
            }
            //      C# -> User? Owner
            // GraphQL -> owner: User! (type)
            if (this.Owner == null && Exploration.Includes(parent + ".owner"))
            {
                this.Owner = new User();
                this.Owner.ApplyExploratoryFragment(parent + ".owner");
            }
            //      C# -> ScheduledReportConnection? ScheduledReportConnection
            // GraphQL -> scheduledReportConnection: ScheduledReportConnection! (type)
            if (this.ScheduledReportConnection == null && Exploration.Includes(parent + ".scheduledReportConnection"))
            {
                this.ScheduledReportConnection = new ScheduledReportConnection();
                this.ScheduledReportConnection.ApplyExploratoryFragment(parent + ".scheduledReportConnection");
            }
            //      C# -> ReportFocusEnum? Focus
            // GraphQL -> focus: ReportFocusEnum! (enum)
            if (this.Focus == null && Exploration.Includes(parent + ".focus$"))
            {
                this.Focus = new ReportFocusEnum();
            }
            //      C# -> List<ReportChartType>? Charts
            // GraphQL -> charts: [ReportChartType!]! (union)
            if (this.Charts == null && Exploration.Includes(parent + ".charts"))
            {
                var obj = (ReportChartType)InterfaceHelper.CreateInstanceOfFirstType(typeof(ReportChartType));
                this.Charts = new List<ReportChartType>() { obj };
                this.Charts.ApplyExploratoryFragment(parent + ".charts");
            }
            //      C# -> List<ReportTableType>? Tables
            // GraphQL -> tables: [ReportTableType!]! (union)
            if (this.Tables == null && Exploration.Includes(parent + ".tables"))
            {
                var obj = (ReportTableType)InterfaceHelper.CreateInstanceOfFirstType(typeof(ReportTableType));
                this.Tables = new List<ReportTableType>() { obj };
                this.Tables.ApplyExploratoryFragment(parent + ".tables");
            }
        }


    #endregion

    } // class CreateCustomReportReply
    #endregion

    public static class ListCreateCustomReportReplyExtensions
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
            this List<CreateCustomReportReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<CreateCustomReportReply> list, 
            String parent = "")
        {
            var item = new CreateCustomReportReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types