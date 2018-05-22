param($generationType)

$scriptPath = Split-Path -parent $PSCommandPath
$root       = (Get-Item $scriptPath).Parent.FullName
$url        = "https://raw.githubusercontent.com/iatecbr/PeopleMgmtApi.Doc/master/spec/swagger.yaml"
$outPath    = $root

[Hashtable]$arguments = @{} 
$arguments.packageGuid = "a8925d35-8bca-4027-a27f-e7eb9a452e35"
$arguments.packageVersion = "0.1.5"
$arguments.packageTitle = "ADEMS PoepleManagement API Client"

Import-Module (Join-Path -Path "$scriptPath" -ChildPath "./IatecSwaggerGenerator.psm1")
#Invoke-IatecGenerate -Type "client" -Root "$root" -SpecUrl "$url" -OutputPath "$outPath" -AdditionalArgs $arguments -Namespace Iatec.Adems.PeopleManagement.Client

Invoke-IatecGenerate CLIENT `
    -Root       "$root"     `
    -SpecUrl    "$url"  `
    -OutputPath "$outPath"  `
    -Namespace  "Iatec.Adems.PeopleManagement.Client" `
    -AdditionalArgs $arguments