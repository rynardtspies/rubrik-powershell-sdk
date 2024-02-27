<#
.SYNOPSIS
Build the Rubrik Security Cloud SDK.

.DESCRIPTION
This script

- runs Clean-RscSdk.ps1 to remove any previous build artifacts.
- builds the Rubrik Security Cloud SDK and copies the output
  to the Output/ directory.
- runs Test-RscSdk.ps1 to run the tests.

By default, the script will run the tests.
You can skip the tests by passing -NoTests.

By default, the script will build the Debug version of the SDK.
You can build the Release version by passing -Release.
Note that the Release build is copied to the Output.Release/ directory
instead of Output/.
#>
param(
    [switch]$NoClean = $false,
    [switch]$Release = $false,
    [switch]$NoDocs = $false,
    [switch]$NoTests = $false
)

# Change to the root of the repository
Set-Location $PSScriptRoot\.. 

if (-Not $NoClean) {
    .\Utils\Clean-RscSdk.ps1
}

$OutputDir = ".\Output"
$ProjectDir = ".\RubrikSecurityCloud\RubrikSecurityCloud.PowerShell"
$ProjectOutputDir = "$ProjectDir\bin\Debug"

if ($Release) {
    $OutputDir = ".\Output.Release"
    $ProjectOutputDir = "$ProjectDir\bin\Release"
}

# Stop on error
$ErrorActionPreference = "Stop"

# Build the project
if ($Release) {
    dotnet build --configuration Release /p:GeneratePSDocs=true $ProjectDir
}
else {
    if ($NoDocs) {
        dotnet build $ProjectDir
    }
    else {
        dotnet build /p:GeneratePSDocs=true $ProjectDir
    }
}

# Copy the output to the output directory
Copy-Item -Recurse -Force $ProjectOutputDir $OutputDir
Copy-Item $OutputDir\net6.0\RubrikSecurityCloud.PowerShell.dll-Help.xml $OutputDir\net472\RubrikSecurityCloud.PowerShell.dll-Help.xml

if (-not $NoTests) {
    # Run the tests
    .\Utils\Test-RscSdk.ps1
}