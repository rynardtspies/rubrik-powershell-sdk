// VsphereAsyncRequestStatus.cs
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
    #region VsphereAsyncRequestStatus
    public class VsphereAsyncRequestStatus: IFragment
    {
        #region members
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime! (scalar)
        [JsonProperty("endTime")]
        public DateTime? EndTime { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        [JsonProperty("nodeId")]
        public System.String? NodeId { get; set; }

        //      C# -> System.Single? Progress
        // GraphQL -> progress: Float! (scalar)
        [JsonProperty("progress")]
        public System.Single? Progress { get; set; }

        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime! (scalar)
        [JsonProperty("startTime")]
        public DateTime? StartTime { get; set; }

        //      C# -> System.String? Status
        // GraphQL -> status: String! (scalar)
        [JsonProperty("status")]
        public System.String? Status { get; set; }

        //      C# -> VsphereRequestErrorInfo? Error
        // GraphQL -> error: VsphereRequestErrorInfo (type)
        [JsonProperty("error")]
        public VsphereRequestErrorInfo? Error { get; set; }

        //      C# -> List<VsphereLink>? Links
        // GraphQL -> links: [VsphereLink!]! (type)
        [JsonProperty("links")]
        public List<VsphereLink>? Links { get; set; }

        #endregion

    #region methods

    public VsphereAsyncRequestStatus Set(
        DateTime? EndTime = null,
        System.String? Id = null,
        System.String? NodeId = null,
        System.Single? Progress = null,
        DateTime? StartTime = null,
        System.String? Status = null,
        VsphereRequestErrorInfo? Error = null,
        List<VsphereLink>? Links = null
    ) 
    {
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( NodeId != null ) {
            this.NodeId = NodeId;
        }
        if ( Progress != null ) {
            this.Progress = Progress;
        }
        if ( StartTime != null ) {
            this.StartTime = StartTime;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( Error != null ) {
            this.Error = Error;
        }
        if ( Links != null ) {
            this.Links = Links;
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
            //      C# -> DateTime? EndTime
            // GraphQL -> endTime: DateTime! (scalar)
            if (this.EndTime != null)
            {
                 s += ind + "endTime\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.String? NodeId
            // GraphQL -> nodeId: String! (scalar)
            if (this.NodeId != null)
            {
                 s += ind + "nodeId\n";

            }
            //      C# -> System.Single? Progress
            // GraphQL -> progress: Float! (scalar)
            if (this.Progress != null)
            {
                 s += ind + "progress\n";

            }
            //      C# -> DateTime? StartTime
            // GraphQL -> startTime: DateTime! (scalar)
            if (this.StartTime != null)
            {
                 s += ind + "startTime\n";

            }
            //      C# -> System.String? Status
            // GraphQL -> status: String! (scalar)
            if (this.Status != null)
            {
                 s += ind + "status\n";

            }
            //      C# -> VsphereRequestErrorInfo? Error
            // GraphQL -> error: VsphereRequestErrorInfo (type)
            if (this.Error != null)
            {
                 s += ind + "error\n";

                 s += ind + "{\n" + 
                 this.Error.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<VsphereLink>? Links
            // GraphQL -> links: [VsphereLink!]! (type)
            if (this.Links != null)
            {
                 s += ind + "links\n";

                 s += ind + "{\n" + 
                 this.Links.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> DateTime? EndTime
            // GraphQL -> endTime: DateTime! (scalar)
            if (this.EndTime == null && Exploration.Includes(parent + ".endTime$"))
            {
                this.EndTime = new DateTime();
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.String? NodeId
            // GraphQL -> nodeId: String! (scalar)
            if (this.NodeId == null && Exploration.Includes(parent + ".nodeId$"))
            {
                this.NodeId = new System.String("FETCH");
            }
            //      C# -> System.Single? Progress
            // GraphQL -> progress: Float! (scalar)
            if (this.Progress == null && Exploration.Includes(parent + ".progress$"))
            {
                this.Progress = new System.Single();
            }
            //      C# -> DateTime? StartTime
            // GraphQL -> startTime: DateTime! (scalar)
            if (this.StartTime == null && Exploration.Includes(parent + ".startTime$"))
            {
                this.StartTime = new DateTime();
            }
            //      C# -> System.String? Status
            // GraphQL -> status: String! (scalar)
            if (this.Status == null && Exploration.Includes(parent + ".status$"))
            {
                this.Status = new System.String("FETCH");
            }
            //      C# -> VsphereRequestErrorInfo? Error
            // GraphQL -> error: VsphereRequestErrorInfo (type)
            if (this.Error == null && Exploration.Includes(parent + ".error"))
            {
                this.Error = new VsphereRequestErrorInfo();
                this.Error.ApplyExploratoryFragment(parent + ".error");
            }
            //      C# -> List<VsphereLink>? Links
            // GraphQL -> links: [VsphereLink!]! (type)
            if (this.Links == null && Exploration.Includes(parent + ".links"))
            {
                this.Links = new List<VsphereLink>();
                this.Links.ApplyExploratoryFragment(parent + ".links");
            }
        }


    #endregion

    } // class VsphereAsyncRequestStatus
    #endregion

    public static class ListVsphereAsyncRequestStatusExtensions
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
            this List<VsphereAsyncRequestStatus> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<VsphereAsyncRequestStatus> list, 
            String parent = "")
        {
            var item = new VsphereAsyncRequestStatus();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types