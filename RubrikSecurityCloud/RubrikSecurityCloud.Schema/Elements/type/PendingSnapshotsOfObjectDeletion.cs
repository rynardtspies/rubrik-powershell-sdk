// PendingSnapshotsOfObjectDeletion.cs
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
    #region PendingSnapshotsOfObjectDeletion
    public class PendingSnapshotsOfObjectDeletion: IFragment
    {
        #region members
        //      C# -> System.String? ObjectFid
        // GraphQL -> objectFid: UUID! (scalar)
        [JsonProperty("objectFid")]
        public System.String? ObjectFid { get; set; }

        //      C# -> PendingActionStatus? Status
        // GraphQL -> status: PendingActionStatus! (enum)
        [JsonProperty("status")]
        public PendingActionStatus? Status { get; set; }

        #endregion

    #region methods

    public PendingSnapshotsOfObjectDeletion Set(
        System.String? ObjectFid = null,
        PendingActionStatus? Status = null
    ) 
    {
        if ( ObjectFid != null ) {
            this.ObjectFid = ObjectFid;
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
            //      C# -> System.String? ObjectFid
            // GraphQL -> objectFid: UUID! (scalar)
            if (this.ObjectFid != null)
            {
                 s += ind + "objectFid\n";

            }
            //      C# -> PendingActionStatus? Status
            // GraphQL -> status: PendingActionStatus! (enum)
            if (this.Status != null)
            {
                 s += ind + "status\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ObjectFid
            // GraphQL -> objectFid: UUID! (scalar)
            if (this.ObjectFid == null && Exploration.Includes(parent + ".objectFid$"))
            {
                this.ObjectFid = new System.String("FETCH");
            }
            //      C# -> PendingActionStatus? Status
            // GraphQL -> status: PendingActionStatus! (enum)
            if (this.Status == null && Exploration.Includes(parent + ".status$"))
            {
                this.Status = new PendingActionStatus();
            }
        }


    #endregion

    } // class PendingSnapshotsOfObjectDeletion
    #endregion

    public static class ListPendingSnapshotsOfObjectDeletionExtensions
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
            this List<PendingSnapshotsOfObjectDeletion> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<PendingSnapshotsOfObjectDeletion> list, 
            String parent = "")
        {
            var item = new PendingSnapshotsOfObjectDeletion();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types