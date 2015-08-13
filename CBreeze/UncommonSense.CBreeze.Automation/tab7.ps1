﻿$PSDefaultParameterValues['*CBreeze*:AutoCaption'] = $true
$CompareToolFileName = 'c:\Program Files\Araxis\Araxis Merge\compare.exe'
$OutputFileName = 'c:\users\jhoek\desktop\tab7.generated.txt'
$ReferenceFileName = 'c:\users\jhoek\desktop\tab7.txt'

# Create reference file
Import-CBreezeApplication -ServerName '.\NAVDEMO' -Database 'Demo Database NAV (7-0)' -Filter 'Type=Table;ID=7|8' | Export-CBreezeApplication -Path $ReferenceFileName

# Create generated file
$Application = New-CBreezeApplication
$DateTime = Get-Date -Year 2012 -Month 9 -Day 7 -Hour 12 -Minute 0 -Second 0
$VersionList = 'NAVW17.00'

$Table = $Application | Add-CBreezeTable 7 'Standard Text' -DateTime $DateTime -VersionList $VersionList -LookupPageID 8 
$Table | Add-CBreezeMLValue CaptionML NLD Standaardtekst
$Table | Add-CBreezeVariable -ID 1000 -Record ExtTextHeader -SubType 279 -Verbose
$Table | Add-CBreezeCodeTableField -Name Code -DataLength 20 -NotBlank $true -PassThru | Add-CBreezeMLValue CaptionML NLD Code
$Table | Add-CBreezeTextTableField -Name Description -DataLength 50 -AutoCaption -PassThru | Add-CBreezeMLValue CaptionML NLD Omschrijving
$Table | Add-CBreezeTableKey -Fields Code -Clustered $true
$Table.Properties.OnDelete | Add-CBreezeCodeLine 'ExtTextHeader.SETRANGE("Table Name",ExtTextHeader."Table Name"::"Standard Text");'
$Table.Properties.OnDelete | Add-CBreezeCodeLine 'ExtTextHeader.SETRANGE("No.",Code);'
$Table.Properties.OnDelete | Add-CBreezeCodeLine 'ExtTextHeader.DELETEALL(TRUE);'

$Table = $Application | Add-CBreezeTable 8 Language -DateTime $DateTime -VersionList $VersionList -LookupPageID 9 
$Table | Add-CBreezeMLValue CaptionML NLD Taal
$Table | Add-CBreezeCodeTableField -Name Code -NotBlank $true -PassThru | Add-CBreezeMLValue CaptionML NLD Code
$Table | Add-CBreezeTextTableField -Name Name -DataLength 50 -PassThru | Add-CBreezeMLValue CaptionML NLD Naam

$Application | Export-CBreezeApplication -Path $OutputFileName

# Compare reference and generated file
& $CompareToolFileName $ReferenceFileName $OutputFileName