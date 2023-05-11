// SapHanaLogSnapshotAppMetadata.cs
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
    #region SapHanaLogSnapshotAppMetadata
    public class SapHanaLogSnapshotAppMetadata: IFragment
    {
        #region members
        //      C# -> List<SapHanaLogBackup>? Backups
        // GraphQL -> backups: [SapHanaLogBackup!] (type)
        [JsonProperty("backups")]
        public List<SapHanaLogBackup>? Backups { get; set; }

        #endregion

    #region methods

    public SapHanaLogSnapshotAppMetadata Set(
        List<SapHanaLogBackup>? Backups = null
    ) 
    {
        if ( Backups != null ) {
            this.Backups = Backups;
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
            //      C# -> List<SapHanaLogBackup>? Backups
            // GraphQL -> backups: [SapHanaLogBackup!] (type)
            if (this.Backups != null)
            {
                 s += ind + "backups\n";

                 s += ind + "{\n" + 
                 this.Backups.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<SapHanaLogBackup>? Backups
            // GraphQL -> backups: [SapHanaLogBackup!] (type)
            if (this.Backups == null && Exploration.Includes(parent + ".backups"))
            {
                this.Backups = new List<SapHanaLogBackup>();
                this.Backups.ApplyExploratoryFragment(parent + ".backups");
            }
        }


    #endregion

    } // class SapHanaLogSnapshotAppMetadata
    #endregion

    public static class ListSapHanaLogSnapshotAppMetadataExtensions
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
            this List<SapHanaLogSnapshotAppMetadata> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SapHanaLogSnapshotAppMetadata> list, 
            String parent = "")
        {
            var item = new SapHanaLogSnapshotAppMetadata();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types