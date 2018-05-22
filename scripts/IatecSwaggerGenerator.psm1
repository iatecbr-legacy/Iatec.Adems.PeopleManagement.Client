# Created by Andre Soares
# Downloaded from https://gist.githubusercontent.com/mniak/03ffee603ef3d264dbd16eca2f3ee21d/raw/IatecSwaggerGenerator.ps1
#
# Usage:
#
#   Import-Module "./IatecSwaggerGenerator.psm1"
#   Invoke-IatecGenerate API         `
#     -Root       {repository root}  `
#     -SpecUrl    {swagger spec url} `
#     -OutputPath {output path}      `
#     -Namespace  {namespace}        `
#     -AdditionalArgs {(Hashtable) additional arguments}
#   
# or:
#   
#   Import-Module "./IatecSwaggerGenerator.psm1"
#   Invoke-IatecGenerate CLIENT           `
#     -Root "{repository root}"           `
#     -SpecUrl        {swagger spec url}" `
#     -OutputPath     {output path}"      `
#     -Namespace      {namespace}         `
#     -AdditionalArgs {(Hashtable) additional arguments}
#
# -------------------------------------------------------------------------
# LICENSE:
#
# Copyright 2018 Andre Soares
#
# Permission is hereby granted, free of charge, to any person obtaining
# a copy of this software and associated documentation files (the
# "Software"), to deal in the Software without restriction, including
# without limitation the rights to use, copy, modify, merge, publish,
# distribute, sublicense, and/or sell copies of the Software, and to
# permit persons to whom the Software is furnished to do so, subject to
# the following conditions:
# 
# The above copyright notice and this permission notice shall be
# included in all copies or substantial portions of the Software.
# 
# THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
# EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
# MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
# NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
# LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
# OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
# WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
# -------------------------------------------------------------------------
#
#

function Get-DownloadedPath($path) {
    Join-Path -Path "$root" -ChildPath ".dl/$path"
}
function Download-IfNotExists($name, $path, $url)
{
    Write-Host -NoNewline "Downloading $name... "
    if (Test-Path($path)) 
    {
        Write-Host "Skipped." -ForegroundColor Yellow
        return
    }

    Invoke-WebRequest -Uri $url -OutFile $path
    Write-Host "Downloaded!" -ForegroundColor Yellow
}
function Remove-IfExists($path) {
    if (Test-Path($path))
    {
        Remove-Item -Recurse $path
    }
}
function Download-Generators()
{
    $codegenVersion = "2.3.1";
    $codegenUrl     = "http://central.maven.org/maven2/io/swagger/swagger-codegen-cli/$codegenVersion/swagger-codegen-cli-$codegenVersion.jar";
    $codegenPath    = Get-DownloadedPath "swagger-codegen-cli.jar";
    Download-IfNotExists "Swagger Codegen" $codegenPath $codegenUrl;

    $pluginVersion = "0.1.6";
    $pluginUrl     = "https://www.myget.org/F/iatec/maven/com.iatec/swagger-generators/$pluginVersion/swagger-generators-$pluginVersion.jar";
    $pluginPath    = Get-DownloadedPath "swagger-generators.jar";
    Download-IfNotExists "Iatec Swagger Generators" $pluginPath $pluginUrl;
    
    $result = @{} 
    $result.codegen = $codegenPath
    $result.plugin = $pluginPath
    $result
}

function Format-JavaArgs([Hashtable]$arguments) {
    $arguments.Keys | % { "-D$_=$($arguments.Item($_)) " }
}

function Invoke-GenerateApi($namespace, [Hashtable]$additionalArgs=@{})
{
    # Prerequisites
    $genPaths = Download-Generators

    # Remove previously generate files
    Remove-IfExists(Join-Path -Path "$root" -ChildPath "src/$namespace")
    
    # Generate the files
    $argsStr = Format-JavaArgs $additionalArgs
    java -cp "$($genPaths.plugin);$($genPaths.codegen)" `
        "io.swagger.codegen.SwaggerCodegen" `
        generate -l iatec.server.aspnetcorelib `
        -i "$specUrl" `
        "-DpackageName=$namespace" `
        "-DsortParamsByRequiredFlag=true" `
        "-DsuppressSln=true" `
        "-DsourceFolder=" `
        "$argsStr" `
        -o "$outputPath"
    
    # Delete undesired generated files
    Remove-IfExists (Join-Path "$root" -ChildPath "src/.swagger-codegen")
    Remove-IfExists (Join-Path "$root" -ChildPath "src/.swagger-codegen-ignore")
}

function Invoke-GenerateClient($namespace, [Hashtable]$additionalArgs=@{})
{
    # Prerequisites
    $genPaths = Download-Generators

    # Remove previously generate files
    Remove-IfExists(Join-Path -Path "$root" -ChildPath "src/$namespace")
    
    # Generate the files
    $argsStr = Format-JavaArgs $additionalArgs
    java -cp "$($genPaths.plugin);$($genPaths.codegen)" "io.swagger.codegen.SwaggerCodegen" `
        generate -l iatec.client.csharp `
        -i "$specUrl" `
        --model-name-suffix=Model `
        "-DpackageName=$namespace" `
        "$argsStr" `
        -o "$root"
    
    # Delete undesired generated files
    Remove-IfExists (Join-Path "$root" -ChildPath ".swagger-codegen")
}

function Invoke-IatecGenerate(
    $type,
    $root,
    $specUrl,
    $outputPath,
    $namespace,
    [Hashtable]$additionalArgs=@{}
) {
    if ("$type".ToUpperInvariant() -eq "API") {
        Invoke-GenerateApi -Namespace $namespace $additionalArgs
    } elseif ("$type".ToUpperInvariant() -eq "CLIENT") {
        Invoke-GenerateClient -Namespace $namespace $additionalArgs
    } else {
        Write-Host "Invalid generation type '$type'."
        Write-Host "Valid ones are 'api' and 'client'."
    }
}
Export-ModuleMember -Function Invoke-IatecGenerate