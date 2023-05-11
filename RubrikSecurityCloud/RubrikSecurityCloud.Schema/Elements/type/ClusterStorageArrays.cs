// ClusterStorageArrays.cs
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
    #region ClusterStorageArrays
    public class ClusterStorageArrays: IFragment
    {
        #region members
        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String (scalar)
        [JsonProperty("errorMessage")]
        public System.String? ErrorMessage { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> List<StorageArrayDetail>? StorageArrays
        // GraphQL -> storageArrays: [StorageArrayDetail!]! (type)
        [JsonProperty("storageArrays")]
        public List<StorageArrayDetail>? StorageArrays { get; set; }

        #endregion

    #region methods

    public ClusterStorageArrays Set(
        System.String? ErrorMessage = null,
        Cluster? Cluster = null,
        List<StorageArrayDetail>? StorageArrays = null
    ) 
    {
        if ( ErrorMessage != null ) {
            this.ErrorMessage = ErrorMessage;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( StorageArrays != null ) {
            this.StorageArrays = StorageArrays;
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
            //      C# -> System.String? ErrorMessage
            // GraphQL -> errorMessage: String (scalar)
            if (this.ErrorMessage != null)
            {
                 s += ind + "errorMessage\n";

            }
            //      C# -> Cluster? Cluster
            // GraphQL -> cluster: Cluster! (type)
            if (this.Cluster != null)
            {
                 s += ind + "cluster\n";

                 s += ind + "{\n" + 
                 this.Cluster.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<StorageArrayDetail>? StorageArrays
            // GraphQL -> storageArrays: [StorageArrayDetail!]! (type)
            if (this.StorageArrays != null)
            {
                 s += ind + "storageArrays\n";

                 s += ind + "{\n" + 
                 this.StorageArrays.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ErrorMessage
            // GraphQL -> errorMessage: String (scalar)
            if (this.ErrorMessage == null && Exploration.Includes(parent + ".errorMessage$"))
            {
                this.ErrorMessage = new System.String("FETCH");
            }
            //      C# -> Cluster? Cluster
            // GraphQL -> cluster: Cluster! (type)
            if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
            {
                this.Cluster = new Cluster();
                this.Cluster.ApplyExploratoryFragment(parent + ".cluster");
            }
            //      C# -> List<StorageArrayDetail>? StorageArrays
            // GraphQL -> storageArrays: [StorageArrayDetail!]! (type)
            if (this.StorageArrays == null && Exploration.Includes(parent + ".storageArrays"))
            {
                this.StorageArrays = new List<StorageArrayDetail>();
                this.StorageArrays.ApplyExploratoryFragment(parent + ".storageArrays");
            }
        }


    #endregion

    } // class ClusterStorageArrays
    #endregion

    public static class ListClusterStorageArraysExtensions
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
            this List<ClusterStorageArrays> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ClusterStorageArrays> list, 
            String parent = "")
        {
            var item = new ClusterStorageArrays();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types