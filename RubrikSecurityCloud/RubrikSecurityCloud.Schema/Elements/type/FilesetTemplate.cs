// FilesetTemplate.cs
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
    #region FilesetTemplate
 
    public class FilesetTemplate: IFragment, CdmHierarchyObject, HierarchyObject
    {
        #region members
        //      C# -> System.Boolean? AllowBackupHiddenFoldersInNetworkMounts
        // GraphQL -> allowBackupHiddenFoldersInNetworkMounts: Boolean! (scalar)
        [JsonProperty("allowBackupHiddenFoldersInNetworkMounts")]
        public System.Boolean? AllowBackupHiddenFoldersInNetworkMounts { get; set; }

        //      C# -> System.Boolean? AllowBackupNetworkMounts
        // GraphQL -> allowBackupNetworkMounts: Boolean! (scalar)
        [JsonProperty("allowBackupNetworkMounts")]
        public System.Boolean? AllowBackupNetworkMounts { get; set; }

        //      C# -> System.String? BackupScriptErrorHandling
        // GraphQL -> backupScriptErrorHandling: String! (scalar)
        [JsonProperty("backupScriptErrorHandling")]
        public System.String? BackupScriptErrorHandling { get; set; }

        //      C# -> List<System.String>? Exceptions
        // GraphQL -> exceptions: [String!]! (scalar)
        [JsonProperty("exceptions")]
        public List<System.String>? Exceptions { get; set; }

        //      C# -> List<System.String>? Excludes
        // GraphQL -> excludes: [String!]! (scalar)
        [JsonProperty("excludes")]
        public List<System.String>? Excludes { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> List<System.String>? Includes
        // GraphQL -> includes: [String!]! (scalar)
        [JsonProperty("includes")]
        public List<System.String>? Includes { get; set; }

        //      C# -> System.Boolean? IsArrayEnabled
        // GraphQL -> isArrayEnabled: Boolean! (scalar)
        [JsonProperty("isArrayEnabled")]
        public System.Boolean? IsArrayEnabled { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        [JsonProperty("numWorkloadDescendants")]
        public System.Int32? NumWorkloadDescendants { get; set; }

        //      C# -> System.String? PostBackupScript
        // GraphQL -> postBackupScript: String! (scalar)
        [JsonProperty("postBackupScript")]
        public System.String? PostBackupScript { get; set; }

        //      C# -> System.String? PreBackupScript
        // GraphQL -> preBackupScript: String! (scalar)
        [JsonProperty("preBackupScript")]
        public System.String? PreBackupScript { get; set; }

        //      C# -> System.Int32? ReplicatedObjectCount
        // GraphQL -> replicatedObjectCount: Int! (scalar)
        [JsonProperty("replicatedObjectCount")]
        public System.Int32? ReplicatedObjectCount { get; set; }

        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        [JsonProperty("slaPauseStatus")]
        public System.Boolean? SlaPauseStatus { get; set; }

        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        [JsonProperty("allOrgs")]
        public List<Org>? AllOrgs { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> FilesetTemplateDescendantTypeConnection? DescendantConnection
        // GraphQL -> descendantConnection: FilesetTemplateDescendantTypeConnection! (type)
        [JsonProperty("descendantConnection")]
        public FilesetTemplateDescendantTypeConnection? DescendantConnection { get; set; }

        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        [JsonProperty("effectiveSlaSourceObject")]
        public PathNode? EffectiveSlaSourceObject { get; set; }

        //      C# -> LatestUserNote? LatestUserNote
        // GraphQL -> latestUserNote: LatestUserNote (type)
        [JsonProperty("latestUserNote")]
        public LatestUserNote? LatestUserNote { get; set; }

        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        [JsonProperty("logicalPath")]
        public List<PathNode>? LogicalPath { get; set; }

        //      C# -> PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus
        // GraphQL -> pendingObjectDeletionStatus: PendingSnapshotsOfObjectDeletion (type)
        [JsonProperty("pendingObjectDeletionStatus")]
        public PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus { get; set; }

        //      C# -> FilesetTemplatePhysicalChildTypeConnection? PhysicalChildConnection
        // GraphQL -> physicalChildConnection: FilesetTemplatePhysicalChildTypeConnection! (type)
        [JsonProperty("physicalChildConnection")]
        public FilesetTemplatePhysicalChildTypeConnection? PhysicalChildConnection { get; set; }

        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        [JsonProperty("physicalPath")]
        public List<PathNode>? PhysicalPath { get; set; }

        //      C# -> DataLocation? PrimaryClusterLocation
        // GraphQL -> primaryClusterLocation: DataLocation! (type)
        [JsonProperty("primaryClusterLocation")]
        public DataLocation? PrimaryClusterLocation { get; set; }

        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        [JsonProperty("snapshotDistribution")]
        public SnapshotDistribution? SnapshotDistribution { get; set; }

        //      C# -> List<Operation>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [Operation!]! (enum)
        [JsonProperty("authorizedOperations")]
        public List<Operation>? AuthorizedOperations { get; set; }

        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        [JsonProperty("objectType")]
        public HierarchyObjectTypeEnum? ObjectType { get; set; }

        //      C# -> FilesetOsType? OsType
        // GraphQL -> osType: FilesetOsType! (enum)
        [JsonProperty("osType")]
        public FilesetOsType? OsType { get; set; }

        //      C# -> ShareTypeEnum? ShareType
        // GraphQL -> shareType: ShareTypeEnum! (enum)
        [JsonProperty("shareType")]
        public ShareTypeEnum? ShareType { get; set; }

        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        [JsonProperty("slaAssignment")]
        public SlaAssignmentTypeEnum? SlaAssignment { get; set; }

        //      C# -> SlaDomain? ConfiguredSlaDomain
        // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
        [JsonProperty("configuredSlaDomain")]
        public SlaDomain? ConfiguredSlaDomain { get; set; }

        //      C# -> SlaDomain? EffectiveRetentionSlaDomain
        // GraphQL -> effectiveRetentionSlaDomain: SlaDomain (interface)
        [JsonProperty("effectiveRetentionSlaDomain")]
        public SlaDomain? EffectiveRetentionSlaDomain { get; set; }

        //      C# -> SlaDomain? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
        [JsonProperty("effectiveSlaDomain")]
        public SlaDomain? EffectiveSlaDomain { get; set; }

        //      C# -> SlaDomain? PendingSla
        // GraphQL -> pendingSla: SlaDomain (interface)
        [JsonProperty("pendingSla")]
        public SlaDomain? PendingSla { get; set; }

        //      C# -> List<CdmHierarchyObject>? ReplicatedObjects
        // GraphQL -> replicatedObjects: [CdmHierarchyObject!]! (interface)
        [JsonProperty("replicatedObjects")]
        public List<CdmHierarchyObject>? ReplicatedObjects { get; set; }

        #endregion

    #region methods

    public FilesetTemplate Set(
        System.Boolean? AllowBackupHiddenFoldersInNetworkMounts = null,
        System.Boolean? AllowBackupNetworkMounts = null,
        System.String? BackupScriptErrorHandling = null,
        List<System.String>? Exceptions = null,
        List<System.String>? Excludes = null,
        System.String? Id = null,
        List<System.String>? Includes = null,
        System.Boolean? IsArrayEnabled = null,
        System.String? Name = null,
        System.Int32? NumWorkloadDescendants = null,
        System.String? PostBackupScript = null,
        System.String? PreBackupScript = null,
        System.Int32? ReplicatedObjectCount = null,
        System.Boolean? SlaPauseStatus = null,
        List<Org>? AllOrgs = null,
        Cluster? Cluster = null,
        FilesetTemplateDescendantTypeConnection? DescendantConnection = null,
        PathNode? EffectiveSlaSourceObject = null,
        LatestUserNote? LatestUserNote = null,
        List<PathNode>? LogicalPath = null,
        PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus = null,
        FilesetTemplatePhysicalChildTypeConnection? PhysicalChildConnection = null,
        List<PathNode>? PhysicalPath = null,
        DataLocation? PrimaryClusterLocation = null,
        SnapshotDistribution? SnapshotDistribution = null,
        List<Operation>? AuthorizedOperations = null,
        HierarchyObjectTypeEnum? ObjectType = null,
        FilesetOsType? OsType = null,
        ShareTypeEnum? ShareType = null,
        SlaAssignmentTypeEnum? SlaAssignment = null,
        SlaDomain? ConfiguredSlaDomain = null,
        SlaDomain? EffectiveRetentionSlaDomain = null,
        SlaDomain? EffectiveSlaDomain = null,
        SlaDomain? PendingSla = null,
        List<CdmHierarchyObject>? ReplicatedObjects = null
    ) 
    {
        if ( AllowBackupHiddenFoldersInNetworkMounts != null ) {
            this.AllowBackupHiddenFoldersInNetworkMounts = AllowBackupHiddenFoldersInNetworkMounts;
        }
        if ( AllowBackupNetworkMounts != null ) {
            this.AllowBackupNetworkMounts = AllowBackupNetworkMounts;
        }
        if ( BackupScriptErrorHandling != null ) {
            this.BackupScriptErrorHandling = BackupScriptErrorHandling;
        }
        if ( Exceptions != null ) {
            this.Exceptions = Exceptions;
        }
        if ( Excludes != null ) {
            this.Excludes = Excludes;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Includes != null ) {
            this.Includes = Includes;
        }
        if ( IsArrayEnabled != null ) {
            this.IsArrayEnabled = IsArrayEnabled;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NumWorkloadDescendants != null ) {
            this.NumWorkloadDescendants = NumWorkloadDescendants;
        }
        if ( PostBackupScript != null ) {
            this.PostBackupScript = PostBackupScript;
        }
        if ( PreBackupScript != null ) {
            this.PreBackupScript = PreBackupScript;
        }
        if ( ReplicatedObjectCount != null ) {
            this.ReplicatedObjectCount = ReplicatedObjectCount;
        }
        if ( SlaPauseStatus != null ) {
            this.SlaPauseStatus = SlaPauseStatus;
        }
        if ( AllOrgs != null ) {
            this.AllOrgs = AllOrgs;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( DescendantConnection != null ) {
            this.DescendantConnection = DescendantConnection;
        }
        if ( EffectiveSlaSourceObject != null ) {
            this.EffectiveSlaSourceObject = EffectiveSlaSourceObject;
        }
        if ( LatestUserNote != null ) {
            this.LatestUserNote = LatestUserNote;
        }
        if ( LogicalPath != null ) {
            this.LogicalPath = LogicalPath;
        }
        if ( PendingObjectDeletionStatus != null ) {
            this.PendingObjectDeletionStatus = PendingObjectDeletionStatus;
        }
        if ( PhysicalChildConnection != null ) {
            this.PhysicalChildConnection = PhysicalChildConnection;
        }
        if ( PhysicalPath != null ) {
            this.PhysicalPath = PhysicalPath;
        }
        if ( PrimaryClusterLocation != null ) {
            this.PrimaryClusterLocation = PrimaryClusterLocation;
        }
        if ( SnapshotDistribution != null ) {
            this.SnapshotDistribution = SnapshotDistribution;
        }
        if ( AuthorizedOperations != null ) {
            this.AuthorizedOperations = AuthorizedOperations;
        }
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( OsType != null ) {
            this.OsType = OsType;
        }
        if ( ShareType != null ) {
            this.ShareType = ShareType;
        }
        if ( SlaAssignment != null ) {
            this.SlaAssignment = SlaAssignment;
        }
        if ( ConfiguredSlaDomain != null ) {
            this.ConfiguredSlaDomain = ConfiguredSlaDomain;
        }
        if ( EffectiveRetentionSlaDomain != null ) {
            this.EffectiveRetentionSlaDomain = EffectiveRetentionSlaDomain;
        }
        if ( EffectiveSlaDomain != null ) {
            this.EffectiveSlaDomain = EffectiveSlaDomain;
        }
        if ( PendingSla != null ) {
            this.PendingSla = PendingSla;
        }
        if ( ReplicatedObjects != null ) {
            this.ReplicatedObjects = ReplicatedObjects;
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
            //      C# -> System.Boolean? AllowBackupHiddenFoldersInNetworkMounts
            // GraphQL -> allowBackupHiddenFoldersInNetworkMounts: Boolean! (scalar)
            if (this.AllowBackupHiddenFoldersInNetworkMounts != null)
            {
                 s += ind + "allowBackupHiddenFoldersInNetworkMounts\n";

            }
            //      C# -> System.Boolean? AllowBackupNetworkMounts
            // GraphQL -> allowBackupNetworkMounts: Boolean! (scalar)
            if (this.AllowBackupNetworkMounts != null)
            {
                 s += ind + "allowBackupNetworkMounts\n";

            }
            //      C# -> System.String? BackupScriptErrorHandling
            // GraphQL -> backupScriptErrorHandling: String! (scalar)
            if (this.BackupScriptErrorHandling != null)
            {
                 s += ind + "backupScriptErrorHandling\n";

            }
            //      C# -> List<System.String>? Exceptions
            // GraphQL -> exceptions: [String!]! (scalar)
            if (this.Exceptions != null)
            {
                 s += ind + "exceptions\n";

            }
            //      C# -> List<System.String>? Excludes
            // GraphQL -> excludes: [String!]! (scalar)
            if (this.Excludes != null)
            {
                 s += ind + "excludes\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: UUID! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> List<System.String>? Includes
            // GraphQL -> includes: [String!]! (scalar)
            if (this.Includes != null)
            {
                 s += ind + "includes\n";

            }
            //      C# -> System.Boolean? IsArrayEnabled
            // GraphQL -> isArrayEnabled: Boolean! (scalar)
            if (this.IsArrayEnabled != null)
            {
                 s += ind + "isArrayEnabled\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.Int32? NumWorkloadDescendants
            // GraphQL -> numWorkloadDescendants: Int! (scalar)
            if (this.NumWorkloadDescendants != null)
            {
                 s += ind + "numWorkloadDescendants\n";

            }
            //      C# -> System.String? PostBackupScript
            // GraphQL -> postBackupScript: String! (scalar)
            if (this.PostBackupScript != null)
            {
                 s += ind + "postBackupScript\n";

            }
            //      C# -> System.String? PreBackupScript
            // GraphQL -> preBackupScript: String! (scalar)
            if (this.PreBackupScript != null)
            {
                 s += ind + "preBackupScript\n";

            }
            //      C# -> System.Int32? ReplicatedObjectCount
            // GraphQL -> replicatedObjectCount: Int! (scalar)
            if (this.ReplicatedObjectCount != null)
            {
                 s += ind + "replicatedObjectCount\n";

            }
            //      C# -> System.Boolean? SlaPauseStatus
            // GraphQL -> slaPauseStatus: Boolean! (scalar)
            if (this.SlaPauseStatus != null)
            {
                 s += ind + "slaPauseStatus\n";

            }
            //      C# -> List<Org>? AllOrgs
            // GraphQL -> allOrgs: [Org!]! (type)
            if (this.AllOrgs != null)
            {
                 s += ind + "allOrgs\n";

                 s += ind + "{\n" + 
                 this.AllOrgs.AsFragment(indent+1) + 
                 ind + "}\n";
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
            //      C# -> FilesetTemplateDescendantTypeConnection? DescendantConnection
            // GraphQL -> descendantConnection: FilesetTemplateDescendantTypeConnection! (type)
            if (this.DescendantConnection != null)
            {
                 s += ind + "descendantConnection\n";

                 s += ind + "{\n" + 
                 this.DescendantConnection.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> PathNode? EffectiveSlaSourceObject
            // GraphQL -> effectiveSlaSourceObject: PathNode (type)
            if (this.EffectiveSlaSourceObject != null)
            {
                 s += ind + "effectiveSlaSourceObject\n";

                 s += ind + "{\n" + 
                 this.EffectiveSlaSourceObject.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> LatestUserNote? LatestUserNote
            // GraphQL -> latestUserNote: LatestUserNote (type)
            if (this.LatestUserNote != null)
            {
                 s += ind + "latestUserNote\n";

                 s += ind + "{\n" + 
                 this.LatestUserNote.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<PathNode>? LogicalPath
            // GraphQL -> logicalPath: [PathNode!]! (type)
            if (this.LogicalPath != null)
            {
                 s += ind + "logicalPath\n";

                 s += ind + "{\n" + 
                 this.LogicalPath.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus
            // GraphQL -> pendingObjectDeletionStatus: PendingSnapshotsOfObjectDeletion (type)
            if (this.PendingObjectDeletionStatus != null)
            {
                 s += ind + "pendingObjectDeletionStatus\n";

                 s += ind + "{\n" + 
                 this.PendingObjectDeletionStatus.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> FilesetTemplatePhysicalChildTypeConnection? PhysicalChildConnection
            // GraphQL -> physicalChildConnection: FilesetTemplatePhysicalChildTypeConnection! (type)
            if (this.PhysicalChildConnection != null)
            {
                 s += ind + "physicalChildConnection\n";

                 s += ind + "{\n" + 
                 this.PhysicalChildConnection.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<PathNode>? PhysicalPath
            // GraphQL -> physicalPath: [PathNode!]! (type)
            if (this.PhysicalPath != null)
            {
                 s += ind + "physicalPath\n";

                 s += ind + "{\n" + 
                 this.PhysicalPath.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> DataLocation? PrimaryClusterLocation
            // GraphQL -> primaryClusterLocation: DataLocation! (type)
            if (this.PrimaryClusterLocation != null)
            {
                 s += ind + "primaryClusterLocation\n";

                 s += ind + "{\n" + 
                 this.PrimaryClusterLocation.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> SnapshotDistribution? SnapshotDistribution
            // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
            if (this.SnapshotDistribution != null)
            {
                 s += ind + "snapshotDistribution\n";

                 s += ind + "{\n" + 
                 this.SnapshotDistribution.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<Operation>? AuthorizedOperations
            // GraphQL -> authorizedOperations: [Operation!]! (enum)
            if (this.AuthorizedOperations != null)
            {
                 s += ind + "authorizedOperations\n";

            }
            //      C# -> HierarchyObjectTypeEnum? ObjectType
            // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
            if (this.ObjectType != null)
            {
                 s += ind + "objectType\n";

            }
            //      C# -> FilesetOsType? OsType
            // GraphQL -> osType: FilesetOsType! (enum)
            if (this.OsType != null)
            {
                 s += ind + "osType\n";

            }
            //      C# -> ShareTypeEnum? ShareType
            // GraphQL -> shareType: ShareTypeEnum! (enum)
            if (this.ShareType != null)
            {
                 s += ind + "shareType\n";

            }
            //      C# -> SlaAssignmentTypeEnum? SlaAssignment
            // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
            if (this.SlaAssignment != null)
            {
                 s += ind + "slaAssignment\n";

            }
                        //      C# -> SlaDomain? ConfiguredSlaDomain
            // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
            if (this.ConfiguredSlaDomain != null)
            {
                s += ind + "configuredSlaDomain\n";
                s += ind + "{\n";

                string typename = this.ConfiguredSlaDomain.GetType().ToString();
                int typenameIdx = typename.LastIndexOf('.');
                typename = typename.Substring(typenameIdx + 1);
                s += ind + String.Format("... on {0}\n", typename);
                s += ind + "{\n" +

                this.ConfiguredSlaDomain.AsFragment(indent+1) +

                ind + "}\n" +

                ind + "}\n";
            }
                        //      C# -> SlaDomain? EffectiveRetentionSlaDomain
            // GraphQL -> effectiveRetentionSlaDomain: SlaDomain (interface)
            if (this.EffectiveRetentionSlaDomain != null)
            {
                s += ind + "effectiveRetentionSlaDomain\n";
                s += ind + "{\n";

                string typename = this.EffectiveRetentionSlaDomain.GetType().ToString();
                int typenameIdx = typename.LastIndexOf('.');
                typename = typename.Substring(typenameIdx + 1);
                s += ind + String.Format("... on {0}\n", typename);
                s += ind + "{\n" +

                this.EffectiveRetentionSlaDomain.AsFragment(indent+1) +

                ind + "}\n" +

                ind + "}\n";
            }
                        //      C# -> SlaDomain? EffectiveSlaDomain
            // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
            if (this.EffectiveSlaDomain != null)
            {
                s += ind + "effectiveSlaDomain\n";
                s += ind + "{\n";

                string typename = this.EffectiveSlaDomain.GetType().ToString();
                int typenameIdx = typename.LastIndexOf('.');
                typename = typename.Substring(typenameIdx + 1);
                s += ind + String.Format("... on {0}\n", typename);
                s += ind + "{\n" +

                this.EffectiveSlaDomain.AsFragment(indent+1) +

                ind + "}\n" +

                ind + "}\n";
            }
                        //      C# -> SlaDomain? PendingSla
            // GraphQL -> pendingSla: SlaDomain (interface)
            if (this.PendingSla != null)
            {
                s += ind + "pendingSla\n";
                s += ind + "{\n";

                string typename = this.PendingSla.GetType().ToString();
                int typenameIdx = typename.LastIndexOf('.');
                typename = typename.Substring(typenameIdx + 1);
                s += ind + String.Format("... on {0}\n", typename);
                s += ind + "{\n" +

                this.PendingSla.AsFragment(indent+1) +

                ind + "}\n" +

                ind + "}\n";
            }
                        //      C# -> List<CdmHierarchyObject>? ReplicatedObjects
            // GraphQL -> replicatedObjects: [CdmHierarchyObject!]! (interface)
            if (this.ReplicatedObjects != null)
            {
                s += ind + "replicatedObjects\n";
                s += ind + "{\n";

                s += this.ReplicatedObjects.AsFragment(indent+1) +

                ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? AllowBackupHiddenFoldersInNetworkMounts
            // GraphQL -> allowBackupHiddenFoldersInNetworkMounts: Boolean! (scalar)
            if (this.AllowBackupHiddenFoldersInNetworkMounts == null && Exploration.Includes(parent + ".allowBackupHiddenFoldersInNetworkMounts$"))
            {
                this.AllowBackupHiddenFoldersInNetworkMounts = new System.Boolean();
            }
            //      C# -> System.Boolean? AllowBackupNetworkMounts
            // GraphQL -> allowBackupNetworkMounts: Boolean! (scalar)
            if (this.AllowBackupNetworkMounts == null && Exploration.Includes(parent + ".allowBackupNetworkMounts$"))
            {
                this.AllowBackupNetworkMounts = new System.Boolean();
            }
            //      C# -> System.String? BackupScriptErrorHandling
            // GraphQL -> backupScriptErrorHandling: String! (scalar)
            if (this.BackupScriptErrorHandling == null && Exploration.Includes(parent + ".backupScriptErrorHandling$"))
            {
                this.BackupScriptErrorHandling = new System.String("FETCH");
            }
            //      C# -> List<System.String>? Exceptions
            // GraphQL -> exceptions: [String!]! (scalar)
            if (this.Exceptions == null && Exploration.Includes(parent + ".exceptions$"))
            {
                this.Exceptions = new List<System.String>();
            }
            //      C# -> List<System.String>? Excludes
            // GraphQL -> excludes: [String!]! (scalar)
            if (this.Excludes == null && Exploration.Includes(parent + ".excludes$"))
            {
                this.Excludes = new List<System.String>();
            }
            //      C# -> System.String? Id
            // GraphQL -> id: UUID! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> List<System.String>? Includes
            // GraphQL -> includes: [String!]! (scalar)
            if (this.Includes == null && Exploration.Includes(parent + ".includes$"))
            {
                this.Includes = new List<System.String>();
            }
            //      C# -> System.Boolean? IsArrayEnabled
            // GraphQL -> isArrayEnabled: Boolean! (scalar)
            if (this.IsArrayEnabled == null && Exploration.Includes(parent + ".isArrayEnabled$"))
            {
                this.IsArrayEnabled = new System.Boolean();
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.Int32? NumWorkloadDescendants
            // GraphQL -> numWorkloadDescendants: Int! (scalar)
            if (this.NumWorkloadDescendants == null && Exploration.Includes(parent + ".numWorkloadDescendants$"))
            {
                this.NumWorkloadDescendants = new System.Int32();
            }
            //      C# -> System.String? PostBackupScript
            // GraphQL -> postBackupScript: String! (scalar)
            if (this.PostBackupScript == null && Exploration.Includes(parent + ".postBackupScript$"))
            {
                this.PostBackupScript = new System.String("FETCH");
            }
            //      C# -> System.String? PreBackupScript
            // GraphQL -> preBackupScript: String! (scalar)
            if (this.PreBackupScript == null && Exploration.Includes(parent + ".preBackupScript$"))
            {
                this.PreBackupScript = new System.String("FETCH");
            }
            //      C# -> System.Int32? ReplicatedObjectCount
            // GraphQL -> replicatedObjectCount: Int! (scalar)
            if (this.ReplicatedObjectCount == null && Exploration.Includes(parent + ".replicatedObjectCount$"))
            {
                this.ReplicatedObjectCount = new System.Int32();
            }
            //      C# -> System.Boolean? SlaPauseStatus
            // GraphQL -> slaPauseStatus: Boolean! (scalar)
            if (this.SlaPauseStatus == null && Exploration.Includes(parent + ".slaPauseStatus$"))
            {
                this.SlaPauseStatus = new System.Boolean();
            }
            //      C# -> List<Org>? AllOrgs
            // GraphQL -> allOrgs: [Org!]! (type)
            if (this.AllOrgs == null && Exploration.Includes(parent + ".allOrgs"))
            {
                this.AllOrgs = new List<Org>();
                this.AllOrgs.ApplyExploratoryFragment(parent + ".allOrgs");
            }
            //      C# -> Cluster? Cluster
            // GraphQL -> cluster: Cluster! (type)
            if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
            {
                this.Cluster = new Cluster();
                this.Cluster.ApplyExploratoryFragment(parent + ".cluster");
            }
            //      C# -> FilesetTemplateDescendantTypeConnection? DescendantConnection
            // GraphQL -> descendantConnection: FilesetTemplateDescendantTypeConnection! (type)
            if (this.DescendantConnection == null && Exploration.Includes(parent + ".descendantConnection"))
            {
                this.DescendantConnection = new FilesetTemplateDescendantTypeConnection();
                this.DescendantConnection.ApplyExploratoryFragment(parent + ".descendantConnection");
            }
            //      C# -> PathNode? EffectiveSlaSourceObject
            // GraphQL -> effectiveSlaSourceObject: PathNode (type)
            if (this.EffectiveSlaSourceObject == null && Exploration.Includes(parent + ".effectiveSlaSourceObject"))
            {
                this.EffectiveSlaSourceObject = new PathNode();
                this.EffectiveSlaSourceObject.ApplyExploratoryFragment(parent + ".effectiveSlaSourceObject");
            }
            //      C# -> LatestUserNote? LatestUserNote
            // GraphQL -> latestUserNote: LatestUserNote (type)
            if (this.LatestUserNote == null && Exploration.Includes(parent + ".latestUserNote"))
            {
                this.LatestUserNote = new LatestUserNote();
                this.LatestUserNote.ApplyExploratoryFragment(parent + ".latestUserNote");
            }
            //      C# -> List<PathNode>? LogicalPath
            // GraphQL -> logicalPath: [PathNode!]! (type)
            if (this.LogicalPath == null && Exploration.Includes(parent + ".logicalPath"))
            {
                this.LogicalPath = new List<PathNode>();
                this.LogicalPath.ApplyExploratoryFragment(parent + ".logicalPath");
            }
            //      C# -> PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus
            // GraphQL -> pendingObjectDeletionStatus: PendingSnapshotsOfObjectDeletion (type)
            if (this.PendingObjectDeletionStatus == null && Exploration.Includes(parent + ".pendingObjectDeletionStatus"))
            {
                this.PendingObjectDeletionStatus = new PendingSnapshotsOfObjectDeletion();
                this.PendingObjectDeletionStatus.ApplyExploratoryFragment(parent + ".pendingObjectDeletionStatus");
            }
            //      C# -> FilesetTemplatePhysicalChildTypeConnection? PhysicalChildConnection
            // GraphQL -> physicalChildConnection: FilesetTemplatePhysicalChildTypeConnection! (type)
            if (this.PhysicalChildConnection == null && Exploration.Includes(parent + ".physicalChildConnection"))
            {
                this.PhysicalChildConnection = new FilesetTemplatePhysicalChildTypeConnection();
                this.PhysicalChildConnection.ApplyExploratoryFragment(parent + ".physicalChildConnection");
            }
            //      C# -> List<PathNode>? PhysicalPath
            // GraphQL -> physicalPath: [PathNode!]! (type)
            if (this.PhysicalPath == null && Exploration.Includes(parent + ".physicalPath"))
            {
                this.PhysicalPath = new List<PathNode>();
                this.PhysicalPath.ApplyExploratoryFragment(parent + ".physicalPath");
            }
            //      C# -> DataLocation? PrimaryClusterLocation
            // GraphQL -> primaryClusterLocation: DataLocation! (type)
            if (this.PrimaryClusterLocation == null && Exploration.Includes(parent + ".primaryClusterLocation"))
            {
                this.PrimaryClusterLocation = new DataLocation();
                this.PrimaryClusterLocation.ApplyExploratoryFragment(parent + ".primaryClusterLocation");
            }
            //      C# -> SnapshotDistribution? SnapshotDistribution
            // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
            if (this.SnapshotDistribution == null && Exploration.Includes(parent + ".snapshotDistribution"))
            {
                this.SnapshotDistribution = new SnapshotDistribution();
                this.SnapshotDistribution.ApplyExploratoryFragment(parent + ".snapshotDistribution");
            }
            //      C# -> List<Operation>? AuthorizedOperations
            // GraphQL -> authorizedOperations: [Operation!]! (enum)
            if (this.AuthorizedOperations == null && Exploration.Includes(parent + ".authorizedOperations$"))
            {
                this.AuthorizedOperations = new List<Operation>();
            }
            //      C# -> HierarchyObjectTypeEnum? ObjectType
            // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
            if (this.ObjectType == null && Exploration.Includes(parent + ".objectType$"))
            {
                this.ObjectType = new HierarchyObjectTypeEnum();
            }
            //      C# -> FilesetOsType? OsType
            // GraphQL -> osType: FilesetOsType! (enum)
            if (this.OsType == null && Exploration.Includes(parent + ".osType$"))
            {
                this.OsType = new FilesetOsType();
            }
            //      C# -> ShareTypeEnum? ShareType
            // GraphQL -> shareType: ShareTypeEnum! (enum)
            if (this.ShareType == null && Exploration.Includes(parent + ".shareType$"))
            {
                this.ShareType = new ShareTypeEnum();
            }
            //      C# -> SlaAssignmentTypeEnum? SlaAssignment
            // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
            if (this.SlaAssignment == null && Exploration.Includes(parent + ".slaAssignment$"))
            {
                this.SlaAssignment = new SlaAssignmentTypeEnum();
            }
            //      C# -> SlaDomain? ConfiguredSlaDomain
            // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
            if (this.ConfiguredSlaDomain == null && Exploration.Includes(parent + ".configuredSlaDomain"))
            {
                this.ConfiguredSlaDomain = (SlaDomain)InterfaceHelper.CreateInstanceOfFirstType(typeof(SlaDomain));
                this.ConfiguredSlaDomain.ApplyExploratoryFragment(parent + ".configuredSlaDomain");
            }
            //      C# -> SlaDomain? EffectiveRetentionSlaDomain
            // GraphQL -> effectiveRetentionSlaDomain: SlaDomain (interface)
            if (this.EffectiveRetentionSlaDomain == null && Exploration.Includes(parent + ".effectiveRetentionSlaDomain"))
            {
                this.EffectiveRetentionSlaDomain = (SlaDomain)InterfaceHelper.CreateInstanceOfFirstType(typeof(SlaDomain));
                this.EffectiveRetentionSlaDomain.ApplyExploratoryFragment(parent + ".effectiveRetentionSlaDomain");
            }
            //      C# -> SlaDomain? EffectiveSlaDomain
            // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
            if (this.EffectiveSlaDomain == null && Exploration.Includes(parent + ".effectiveSlaDomain"))
            {
                this.EffectiveSlaDomain = (SlaDomain)InterfaceHelper.CreateInstanceOfFirstType(typeof(SlaDomain));
                this.EffectiveSlaDomain.ApplyExploratoryFragment(parent + ".effectiveSlaDomain");
            }
            //      C# -> SlaDomain? PendingSla
            // GraphQL -> pendingSla: SlaDomain (interface)
            if (this.PendingSla == null && Exploration.Includes(parent + ".pendingSla"))
            {
                this.PendingSla = (SlaDomain)InterfaceHelper.CreateInstanceOfFirstType(typeof(SlaDomain));
                this.PendingSla.ApplyExploratoryFragment(parent + ".pendingSla");
            }
            //      C# -> List<CdmHierarchyObject>? ReplicatedObjects
            // GraphQL -> replicatedObjects: [CdmHierarchyObject!]! (interface)
            if (this.ReplicatedObjects == null && Exploration.Includes(parent + ".replicatedObjects"))
            {
                this.ReplicatedObjects = new List<CdmHierarchyObject>();
                this.ReplicatedObjects.ApplyExploratoryFragment(parent + ".replicatedObjects");
            }
        }


    #endregion

    } // class FilesetTemplate
    #endregion

    public static class ListFilesetTemplateExtensions
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
            this List<FilesetTemplate> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<FilesetTemplate> list, 
            String parent = "")
        {
            var item = new FilesetTemplate();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types