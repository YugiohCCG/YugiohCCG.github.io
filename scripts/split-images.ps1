# Split a single images ZIP into numbered parts under a target size (bytes).
# Usage:
#   powershell -ExecutionPolicy Bypass -File scripts/split-images.ps1 `
#     -SourceZip "public/CCG Downloads/YGO_Omega_Images.zip" `
#     -OutputDir "public/CCG Downloads" `
#     -BaseName "YGO_Omega_Images_v" `
#     -MaxBytes 95000000

param(
  [string]$SourceZip = "public/CCG Downloads/YGO_Omega_Images.zip",
  [string]$OutputDir = "public/CCG Downloads",
  [string]$BaseName = "YGO_Omega_Images_v",
  [long]$MaxBytes = 95000000
)

$src = Resolve-Path $SourceZip
$outDir = Resolve-Path $OutputDir
$workDir = Join-Path $env:TEMP "ccg_images_split"
if (Test-Path $workDir) { Remove-Item $workDir -Recurse -Force }
New-Item -ItemType Directory -Path $workDir | Out-Null

Write-Host "Extracting $src to $workDir ..."
Expand-Archive -Path $src -DestinationPath $workDir -Force

$files = Get-ChildItem -Path $workDir -Recurse -File | Sort-Object FullName
$parts = @()
$current = @()
$currentSize = 0
$partIndex = 1

foreach ($f in $files) {
  if ($currentSize + $f.Length -gt $MaxBytes -and $current.Count -gt 0) {
    $parts += ,@($partIndex, $current)
    $partIndex++
    $current = @()
    $currentSize = 0
  }
  $current += $f
  $currentSize += $f.Length
}
if ($current.Count -gt 0) {
  $parts += ,@($partIndex, $current)
}

foreach ($p in $parts) {
  $idx = $p[0]
  $list = $p[1]
  $destZip = Join-Path $outDir ("{0}{1}.zip" -f $BaseName, $idx)
  if (Test-Path $destZip) { Remove-Item $destZip -Force }
  $paths = $list | ForEach-Object { $_.FullName }
  Write-Host ("Creating part {0} with {1} files -> {2}" -f $idx, $list.Count, $destZip)
  Compress-Archive -Path $paths -DestinationPath $destZip -CompressionLevel Optimal
}

Write-Host "Done. Parts created in $outDir"
