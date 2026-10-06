param(
    [Parameter(Mandatory = $true, Position = 0)]
    [string[]] $Path
)

$ErrorActionPreference = 'Stop'

function Get-PngTextChunk {
    param(
        [Parameter(Mandatory = $true)]
        [string] $ImagePath,

        [Parameter(Mandatory = $true)]
        [string] $Keyword
    )

    $bytes = [System.IO.File]::ReadAllBytes($ImagePath)
    if ($bytes.Length -lt 12) {
        return $null
    }

    $position = 8
    while ($position + 12 -le $bytes.Length) {
        $lengthBytes = [byte[]] $bytes[$position..($position + 3)]
        [array]::Reverse($lengthBytes)
        $length = [BitConverter]::ToUInt32($lengthBytes, 0)
        $type = [Text.Encoding]::ASCII.GetString($bytes, $position + 4, 4)

        if ($position + 12 + $length -gt $bytes.Length) {
            break
        }

        if ($type -eq 'tEXt') {
            $data = [Text.Encoding]::UTF8.GetString($bytes, $position + 8, [int] $length)
            $separator = $data.IndexOf([char] 0)
            if ($separator -ge 0 -and $data.Substring(0, $separator) -eq $Keyword) {
                return $data.Substring($separator + 1)
            }
        }

        $position += 12 + [int64] $length
    }

    return $null
}

function Get-Node {
    param(
        [Parameter(Mandatory = $true)]
        [object] $Prompt,

        [Parameter(Mandatory = $true)]
        [string] $Id
    )

    $property = $Prompt.PSObject.Properties[$Id]
    if ($null -eq $property) {
        return $null
    }
    return $property.Value
}

$files = foreach ($entry in $Path) {
    if (Test-Path -LiteralPath $entry -PathType Container) {
        Get-ChildItem -LiteralPath $entry -Filter '*.png' -File
    }
    elseif (Test-Path -LiteralPath $entry -PathType Leaf) {
        Get-Item -LiteralPath $entry
    }
    else {
        Write-Warning "Path not found: $entry"
    }
}

$results = foreach ($file in $files | Sort-Object FullName -Unique) {
    $promptText = Get-PngTextChunk -ImagePath $file.FullName -Keyword 'prompt'
    if ([string]::IsNullOrWhiteSpace($promptText)) {
        [pscustomobject] @{
            File           = $file.Name
            Seed           = $null
            JsonGenerator  = $null
            InputFormat    = 'no metadata'
            Model          = $null
            LoRA           = $null
            LoRAStrength   = $null
            Preset         = $null
            Sampler        = $null
            CFG            = $null
            LateCFG        = $null
            AspectRatio    = $null
            Megapixels     = $null
        }
        continue
    }

    try {
        $prompt = $promptText | ConvertFrom-Json
    }
    catch {
        Write-Warning "Invalid prompt metadata in $($file.FullName): $($_.Exception.Message)"
        continue
    }

    $seedNode = Get-Node -Prompt $prompt -Id '160'
    $switchNode = Get-Node -Prompt $prompt -Id '191'
    $inputNode = Get-Node -Prompt $prompt -Id '192'
    $modelNode = Get-Node -Prompt $prompt -Id '165'
    $loraNode = Get-Node -Prompt $prompt -Id '196'
    $presetNode = Get-Node -Prompt $prompt -Id '98:156'
    $samplerNode = Get-Node -Prompt $prompt -Id '98:16'
    $guideNode = Get-Node -Prompt $prompt -Id '98:155'
    $lateCfgNode = Get-Node -Prompt $prompt -Id '98:157'
    $resolutionNode = Get-Node -Prompt $prompt -Id '37'

    $inputText = [string] $inputNode.inputs.value
    $inputFormat = if ($inputText.TrimStart().StartsWith('{')) { 'JSON' } else { 'natural language' }

    [pscustomobject] @{
        File           = $file.Name
        Seed           = $seedNode.inputs.seed
        JsonGenerator  = $switchNode.inputs.switch
        InputFormat    = $inputFormat
        Model          = $modelNode.inputs.unet_name
        LoRA           = $loraNode.inputs.lora_name
        LoRAStrength   = $loraNode.inputs.strength_model
        Preset         = $presetNode.inputs.choice
        Sampler        = $samplerNode.inputs.sampler_name
        CFG            = $guideNode.inputs.cfg
        LateCFG        = $lateCfgNode.inputs.cfg
        AspectRatio    = $resolutionNode.inputs.aspect_ratio
        Megapixels     = $resolutionNode.inputs.megapixels
    }
}

$results
