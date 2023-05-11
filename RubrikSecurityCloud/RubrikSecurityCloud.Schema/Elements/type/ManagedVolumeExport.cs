// ManagedVolumeExport.cs
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
    #region ManagedVolumeExport
    public class ManagedVolumeExport: IFragment
    {
        #region members
        //      C# -> System.Boolean? IsActive
        // GraphQL -> isActive: Boolean! (scalar)
        [JsonProperty("isActive")]
        public System.Boolean? IsActive { get; set; }

        //      C# -> List<ManagedVolumeChannelConfig>? Channels
        // GraphQL -> channels: [ManagedVolumeChannelConfig!]! (type)
        [JsonProperty("channels")]
        public List<ManagedVolumeChannelConfig>? Channels { get; set; }

        //      C# -> ManagedVolumeExportConfig? Config
        // GraphQL -> config: ManagedVolumeExportConfig (type)
        [JsonProperty("config")]
        public ManagedVolumeExportConfig? Config { get; set; }

        #endregion

    #region methods

    public ManagedVolumeExport Set(
        System.Boolean? IsActive = null,
        List<ManagedVolumeChannelConfig>? Channels = null,
        ManagedVolumeExportConfig? Config = null
    ) 
    {
        if ( IsActive != null ) {
            this.IsActive = IsActive;
        }
        if ( Channels != null ) {
            this.Channels = Channels;
        }
        if ( Config != null ) {
            this.Config = Config;
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
            //      C# -> System.Boolean? IsActive
            // GraphQL -> isActive: Boolean! (scalar)
            if (this.IsActive != null)
            {
                 s += ind + "isActive\n";

            }
            //      C# -> List<ManagedVolumeChannelConfig>? Channels
            // GraphQL -> channels: [ManagedVolumeChannelConfig!]! (type)
            if (this.Channels != null)
            {
                 s += ind + "channels\n";

                 s += ind + "{\n" + 
                 this.Channels.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ManagedVolumeExportConfig? Config
            // GraphQL -> config: ManagedVolumeExportConfig (type)
            if (this.Config != null)
            {
                 s += ind + "config\n";

                 s += ind + "{\n" + 
                 this.Config.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? IsActive
            // GraphQL -> isActive: Boolean! (scalar)
            if (this.IsActive == null && Exploration.Includes(parent + ".isActive$"))
            {
                this.IsActive = new System.Boolean();
            }
            //      C# -> List<ManagedVolumeChannelConfig>? Channels
            // GraphQL -> channels: [ManagedVolumeChannelConfig!]! (type)
            if (this.Channels == null && Exploration.Includes(parent + ".channels"))
            {
                this.Channels = new List<ManagedVolumeChannelConfig>();
                this.Channels.ApplyExploratoryFragment(parent + ".channels");
            }
            //      C# -> ManagedVolumeExportConfig? Config
            // GraphQL -> config: ManagedVolumeExportConfig (type)
            if (this.Config == null && Exploration.Includes(parent + ".config"))
            {
                this.Config = new ManagedVolumeExportConfig();
                this.Config.ApplyExploratoryFragment(parent + ".config");
            }
        }


    #endregion

    } // class ManagedVolumeExport
    #endregion

    public static class ListManagedVolumeExportExtensions
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
            this List<ManagedVolumeExport> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ManagedVolumeExport> list, 
            String parent = "")
        {
            var item = new ManagedVolumeExport();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types