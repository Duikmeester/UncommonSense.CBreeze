Properties {
    $Configuration = "Debug"
    $RootFolder = $psake.build_script_dir
    $SolutionFolder = Join-Path -Path $RootFolder -ChildPath CBreeze
}

function Invoke-MSBuild 
{
    param
    (
        [Parameter(Mandatory, Position = 1)][string]$ProjectName,
        [ValidateNotNullOrEmpty()][string]$Target = 'Build',
        [ValidateNotNullOrEmpty()][string]$Configuration = 'Debug',
        [Parameter(Mandatory, Position = 2)][ValidateSet('NAV2017', 'NAV2016', 'NAV2015', 'NAV2013R2', 'NAV2013')][string]$NAVVersion,
        [Parameter()][string]$PreBuildEvent = '',
        [Parameter()][string]$PostBuildEvent = '',
        [ValidateSet('quiet', 'minimal', 'normal', 'detailed', 'diagnostic')]$Verbosity = 'Normal'
    )   
    
    $ProjectFolderPath = Join-Path -Path $SolutionFolder -ChildPath $ProjectName
    $ProjectFilePath = Join-Path -Path $ProjectFolderPath -ChildPath "$ProjectName.csproj"
    $OutputFolderPath = Join-Path -Path $SolutionFolder -ChildPath "Output/$NAVVersion"
    $AssemblyFileName = "$ProjectName.$NAVVersion"

    $DefineConstants = switch ($NAVVersion)
    {
        'NAV2017' { 'NAV2017 NAV2016 NAV2015 NAV2013R2 NAV2013' }
        'NAV2016' { 'NAV2016 NAV2015 NAV2013R2 NAV2013' }
        'NAV2015' { 'NAV2015 NAV2013R2 NAV2013' }
        'NAV2013R2' { 'NAV2013R2 NAV2013'}
        'NAV2013' { 'NAV2013'}
    }

    Exec {         
        msbuild /target:$Target /property:Configuration=$Configuration /property:DefineConstants="$DefineConstants" /property:AssemblyName=$AssemblyFileName /property:OutputPath=$OutputFolderPath /property:PreBuildEvent=$PreBuildEvent /property:PostBuildEvent=$PostBuildEvent /verbosity:$Verbosity $ProjectFilePath
    }

    Copy-Item 
}

Task -Name Default -Depends Build2017, Build2016

Task -Name Build2017 {
    Invoke-MSBuild UncommonSense.CBreeze.Automation NAV2017
}

Task -Name Build2016 {
    Invoke-MSBuild UncommonSense.CBreeze.Automation NAV2016
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