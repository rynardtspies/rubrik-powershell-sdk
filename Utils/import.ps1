<#
.SYNOPSIS
Sample to import the Rubrik SDK module.

.DESCRIPTION
Typically a `Import-Module RubrikSecurityCloud` is sufficient to import the Rubrik SDK module, because it'll import the one that's installed on the system.

In most cases when writing a script, you'll want to import the module that's installed on the system.

However, if you're developing the SDK, or if you want to work from source instead of a system-wide package, you'll want to import the one that's in the Output directory. This script will import the module from the Output directory if -Local is given or if the module isn't installed on the system.

.PARAMETER Local
If given, the module will be imported from the Output directory instead of the system-wide package.
If not given, the module will be imported from the system-wide package, if it's installed, or from the Output directory if it's not installed.
#>
[CmdletBinding()]
param(
    [switch]$Local,
    [string]$ModuleName = 'RubrikSecurityCloud',
    [ValidateScript({ Test-Path $_ -PathType Leaf })] $DllPath
)

# The path to the module is either given as a parameter, or it's in the Output directory.
if (-not $DllPath) {
    $DllPath = Join-Path $PSScriptRoot "../Output/${ModuleName}.psd1"
}

# If the module is installed on the system, remove it first.
# If it's not installed, this will fail silently.
Remove-Module -Name $ModuleName -ErrorAction 'SilentlyContinue'

if ($Local) {
    Write-Verbose "Importing ${ModuleName} module from local directory."
    Import-Module $DllPath -ErrorAction Stop
}
else {

    try {
        Import-Module $ModuleName -ErrorAction Stop
    }
    catch {
        Write-Verbose "${ModuleName} module not on path. Importing from local directory."
        Import-Module $DllPath -ErrorAction Stop
    }
}

$cmdletCount = (Get-Command -Module RubrikSecurityCloud | Measure-Object).Count
Write-Verbose "Imported ${cmdletCount} cmdlets from ${ModuleName} module."

# 
# For Alpha release:
#
# REMOVE AFTER ALPHA RELEASE
Get-ChildItem -Path ${PSScriptRoot}/../RubrikSecurityCloud/RubrikSecurityCloud.PowerShell/Public/*.psm1 | Import-Module
#
#
#