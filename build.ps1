Framework 4.7

Properties {
    $Configuration = "Debug"
    $RootFolder = $psake.build_script_dir
    $SolutionFolder = Join-Path -Path $RootFolder -ChildPath CBreeze
}

function Invoke-MSBuild 
{
    param
    (
        [ValidateNotNullOrEmpty()][string]$Target = 'Rebuild',
        [ValidateNotNullOrEmpty()][string]$Configuration = 'Debug',
        [Parameter(Mandatory, Position = 1)][ValidateSet('NAV2017', 'NAV2016', 'NAV2015', 'NAV2013R2', 'NAV2013')][string]$NAVVersion,
        [Parameter()][string]$PreBuildEvent = '',
        [Parameter()][string]$PostBuildEvent = '',
        [ValidateSet('quiet', 'minimal', 'normal', 'detailed', 'diagnostic')]$Verbosity = 'Normal'
    )   
    
    $SolutionFileName = Join-Path -Path $SolutionFolder -ChildPath 'UncommonSense.CBreeze.sln'
    $OutputFolderPath = Join-Path -Path $SolutionFolder -ChildPath "Output/$NAVVersion/$Configuration"

    if (Test-Path -Path $OutputFolderPath) 
    {
        Write-Information "Removing output folder $OutputFolderPath"
        Remove-Item -Path $OutputFolderPath -Force -Recurse
    }

    Write-Information "Creating output folder $OutputFolderPath"
    New-Item -Path $OutputFolderPath -ItemType Directory | Out-Null

    $DefineConstants = switch ($NAVVersion)
    {
        'NAV2017' { 'NAV2017 NAV2016 NAV2015 NAV2013R2 NAV2013' }
        'NAV2016' { 'NAV2016 NAV2015 NAV2013R2 NAV2013' }
        'NAV2015' { 'NAV2015 NAV2013R2 NAV2013' }
        'NAV2013R2' { 'NAV2013R2 NAV2013'}
        'NAV2013' { 'NAV2013'}
    }

    Exec {         
        # /property:OutputPath=$OutputFolderPath
        msbuild /target:$Target /property:Configuration=$Configuration /property:DefineConstants="$DefineConstants" /property:PreBuildEvent=$PreBuildEvent /property:PostBuildEvent=$PostBuildEvent /verbosity:$Verbosity $SolutionFileName
        Copy-Item -Path (Join-Path -Path $SolutionFolder -ChildPath "UncommonSense.CBreeze.Automation/bin/$Configuration/UncommonSense.CBreeze.Automation/*") -Destination $OutputFolderPath -Container
    }
}

Task -Name Default -Depends Build2017, Build2016

Task -Name Build2017 {
    Invoke-MSBuild NAV2017 -Verbosity minimal
}

Task -Name Build2016 {
    Invoke-MSBuild NAV2016 -Verbosity minimal
}

<#

Task -Name Build2016 {
    Exec { msbuild $SolutionFileName /t:Build /p:"Configuration=$Configuration; DefineConstants=`"NAV2016; NAV2015; NAV2013R2; NAV2013`"; PreBuildEvent=; PostBuildEvent=" /v:minimal }
}

Task -Name Build2015 {
    Exec { msbuild $SolutionFileName /t:Build /p:'Configuration = $Configuration; DefineConstants = "NAV2015; NAV2013R2; NAV2013"; PreBuildEvent = ; PostBuildEvent = " /v:minimal }
}

Task -Name Build2013R2 {
    Exec { msbuild $SolutionFileName /t:Build /p:"Configuration = $Configuration; DefineConstants = "NAV2013R2; NAV2013"; PreBuildEvent = ; PostBuildEvent = " /v:minimal }
}

Task -Name Build2013 {
    Exec { msbuild $SolutionFileName /t:Build /p:"Configuration = $Configuration; DefineConstants = "NAV2013"; PreBuildEvent = ; PostBuildEvent = " /v:minimal }
}
#>