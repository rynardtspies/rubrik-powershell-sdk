// UserDownload.cs
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
    #region UserDownload
    public class UserDownload: IFragment
    {
        #region members
        //      C# -> System.String? CompleteTime
        // GraphQL -> completeTime: String! (scalar)
        [JsonProperty("completeTime")]
        public System.String? CompleteTime { get; set; }

        //      C# -> System.String? CreateTime
        // GraphQL -> createTime: String! (scalar)
        [JsonProperty("createTime")]
        public System.String? CreateTime { get; set; }

        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        [JsonProperty("id")]
        public System.Int64? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? Progress
        // GraphQL -> progress: Int! (scalar)
        [JsonProperty("progress")]
        public System.Int32? Progress { get; set; }

        //      C# -> DownloadIdentifierEnum? Identifier
        // GraphQL -> identifier: DownloadIdentifierEnum! (enum)
        [JsonProperty("identifier")]
        public DownloadIdentifierEnum? Identifier { get; set; }

        //      C# -> DownloadStatusEnum? Status
        // GraphQL -> status: DownloadStatusEnum! (enum)
        [JsonProperty("status")]
        public DownloadStatusEnum? Status { get; set; }

        #endregion

    #region methods

    public UserDownload Set(
        System.String? CompleteTime = null,
        System.String? CreateTime = null,
        System.Int64? Id = null,
        System.String? Name = null,
        System.Int32? Progress = null,
        DownloadIdentifierEnum? Identifier = null,
        DownloadStatusEnum? Status = null
    ) 
    {
        if ( CompleteTime != null ) {
            this.CompleteTime = CompleteTime;
        }
        if ( CreateTime != null ) {
            this.CreateTime = CreateTime;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Progress != null ) {
            this.Progress = Progress;
        }
        if ( Identifier != null ) {
            this.Identifier = Identifier;
        }
        if ( Status != null ) {
            this.Status = Status;
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
            //      C# -> System.String? CompleteTime
            // GraphQL -> completeTime: String! (scalar)
            if (this.CompleteTime != null)
            {
                 s += ind + "completeTime\n";

            }
            //      C# -> System.String? CreateTime
            // GraphQL -> createTime: String! (scalar)
            if (this.CreateTime != null)
            {
                 s += ind + "createTime\n";

            }
            //      C# -> System.Int64? Id
            // GraphQL -> id: Long! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.Int32? Progress
            // GraphQL -> progress: Int! (scalar)
            if (this.Progress != null)
            {
                 s += ind + "progress\n";

            }
            //      C# -> DownloadIdentifierEnum? Identifier
            // GraphQL -> identifier: DownloadIdentifierEnum! (enum)
            if (this.Identifier != null)
            {
                 s += ind + "identifier\n";

            }
            //      C# -> DownloadStatusEnum? Status
            // GraphQL -> status: DownloadStatusEnum! (enum)
            if (this.Status != null)
            {
                 s += ind + "status\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? CompleteTime
            // GraphQL -> completeTime: String! (scalar)
            if (this.CompleteTime == null && Exploration.Includes(parent + ".completeTime$"))
            {
                this.CompleteTime = new System.String("FETCH");
            }
            //      C# -> System.String? CreateTime
            // GraphQL -> createTime: String! (scalar)
            if (this.CreateTime == null && Exploration.Includes(parent + ".createTime$"))
            {
                this.CreateTime = new System.String("FETCH");
            }
            //      C# -> System.Int64? Id
            // GraphQL -> id: Long! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.Int64();
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.Int32? Progress
            // GraphQL -> progress: Int! (scalar)
            if (this.Progress == null && Exploration.Includes(parent + ".progress$"))
            {
                this.Progress = new System.Int32();
            }
            //      C# -> DownloadIdentifierEnum? Identifier
            // GraphQL -> identifier: DownloadIdentifierEnum! (enum)
            if (this.Identifier == null && Exploration.Includes(parent + ".identifier$"))
            {
                this.Identifier = new DownloadIdentifierEnum();
            }
            //      C# -> DownloadStatusEnum? Status
            // GraphQL -> status: DownloadStatusEnum! (enum)
            if (this.Status == null && Exploration.Includes(parent + ".status$"))
            {
                this.Status = new DownloadStatusEnum();
            }
        }


    #endregion

    } // class UserDownload
    #endregion

    public static class ListUserDownloadExtensions
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
            this List<UserDownload> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<UserDownload> list, 
            String parent = "")
        {
            var item = new UserDownload();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types