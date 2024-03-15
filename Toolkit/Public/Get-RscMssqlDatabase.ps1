#Requires -Version 3
function Get-RscMssqlDatabase {
    <#
    .SYNOPSIS
    Returns information about a MSSQL Database

    .DESCRIPTION
    Returns information about a MSSQL Database

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER List
    Used to create a list of Databases
    
    .PARAMETER Name
    Used to return a specific Database based on the name

    .PARAMETER RscMssqlInstance
    SQL Server Instance Object returned from Get-RscMssqlInstance


    .PARAMETER Detail
    Changes the data profile. This can affect the fields returned

    .EXAMPLE
    Return a list of MSSQL Databases
    Get-RscMssqlDatabase -List

    .EXAMPLE
    Return a list of MSSQL Databases named AdventureWorks2019
    Get-RscMssqlDatabase -Name AdventureWorks2019

    .EXAMPLE
    Return a list of MSSQL Databases named AdventureWorks2019 on the SQL 2019 Instance
    $RscMssqlInstance = Get-RscMssqlInstance -HostName sql19.demo.com -clusterID hja87-ajb43-v4avna-hnjag
    Get-RscMssqlDatabase -Name AdventureWorks2019 -RscMssqlInstance $RscMssqlInstance
    #>

    [CmdletBinding(
        # ___ Example ___
        DefaultParameterSetName = "List"
    )]
    Param(
        [Parameter(
            ParameterSetName = "List",
            Mandatory = $false
        )]
        [Switch]$List,

        [Parameter(
            ParameterSetName = "Name",
            Mandatory = $false
        )][String]$Name,

        [Parameter(
            ParameterSetName = "Name",
            Mandatory = $false
        )][RubrikSecurityCloud.Types.MssqlInstance]$RscMssqlInstance, 

        [Parameter(
            ParameterSetName = "Id",
            Mandatory = $false, 
            ValueFromPipeline = $false
        )][String]$Id,
       

        #  Common parameter to all parameter sets:
        [Parameter(
            Mandatory = $false
        )][Switch]$Detail
    )
    
    Process {
        # Determine field profile:
        $fieldProfile = "DEFAULT"
        if ( $Detail -eq $true ) {
            $fieldProfile = "DETAIL"
        }
        Write-Debug "- Running Get-RscMssqlDatabase"

        #region Create Query
        if ($PSBoundParameters.ContainsKey('List')) {
            $query = New-RscQueryMssql -Operation Databases -FieldProfile $fieldProfile
            $query.Field.Nodes[0].PhysicalPath = New-Object RubrikSecurityCloud.Types.PathNode
            $query.Field.Nodes[0].PhysicalPath.SelectForRetrieval()
        }

        if ($PSBoundParameters.ContainsKey('Name')) {
            $query = New-RscQueryMssql -Operation Databases -FieldProfile $fieldProfile 
            $query.Field.Nodes[0].PhysicalPath = New-Object RubrikSecurityCloud.Types.PathNode
            $query.Field.Nodes[0].PhysicalPath.SelectForRetrieval() 
            $query.Field.Nodes[0].CopyOnly = 1
            $query.Field.Nodes[0].HostLogRetention = 1
            $query.Field.Nodes[0].LogBackupFrequencyInSeconds
            $query.Field.Nodes[0].LogBackupRetentionInHours
            $query.Field.Nodes[0].PostBackupScript = "FETCH"
            $query.Field.Nodes[0].PreBackupScript = "FETCH"
            
            $query.Var.filter = @()
            $nameFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
            $nameFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::NAME_EXACT_MATCH
            $nameFilter.texts = $Name
            $query.Var.filter += $nameFilter
        }
        if ($PSBoundParameters.ContainsKey('Id')) {
            $query = New-RscQueryMssql -Operation Database -FieldProfile $fieldProfile
            $query.Field.PhysicalPath = New-Object RubrikSecurityCloud.Types.PathNode
            $query.Field.PhysicalPath.SelectForRetrieval() 
            $query.Var.fid = $Id
        }

   
        #endregion

        $results = $query.Invoke()   
        
        if ($PSBoundParameters.ContainsKey('List')) {
            $results = $results.Nodes
        }
        if ($PSBoundParameters.ContainsKey('Name')) {
            if ($PSBoundParameters.ContainsKey('RscMssqlInstance')) {
                $results = $results.Nodes | Where-Object {$_.PhysicalPath.Fid -eq $RscMssqlInstance.id}    
            }else{
                $results = $results.Nodes
            }
        }
        $results
    } 
}
