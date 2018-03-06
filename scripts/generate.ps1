param($generationType)

$scriptPath = Split-Path -parent $PSCommandPath
$root       = (Get-Item $scriptPath).Parent.FullName
$url        = "https://app.swaggerhub.com/apiproxy/schema/file/iatec/People/0.1.0/swagger.yaml"
$outPath    = $root

Import-Module (Join-Path -Path "$scriptPath" -ChildPath "./IatecSwaggerGenerator.psm1")
Invoke-IatecGenerate -Type "client" -Root "$root" -SpecUrl "$url" -OutputPath "$outPath"