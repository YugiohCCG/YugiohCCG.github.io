# Recompress JPEGs inside an images ZIP and rebuild the archive.
# Usage:
#   pwsh -File scripts/compress-images.ps1 `
#     -SourceZip "public/CCG Downloads/YGO_Omega_Images.zip" `
#     -OutputZip "public/CCG Downloads/YGO_Omega_Images.zip" `
#     -Quality 92

param(
  [string]$SourceZip = "public/CCG Downloads/YGO_Omega_Images.zip",
  [string]$OutputZip = "public/CCG Downloads/YGO_Omega_Images.zip",
  [int]$Quality = 92
)

# Ensure System.Drawing is available (Windows-only). Try GAC first, then known dotnet shared path.
$drawingLoaded = $false
try {
  Add-Type -AssemblyName System.Drawing -ErrorAction Stop
  $drawingLoaded = $true
} catch {
  $dll = Get-ChildItem -Path "C:\Program Files\dotnet\shared" -Recurse -Filter "System.Drawing.Common.dll" -ErrorAction SilentlyContinue |
    Sort-Object FullName -Descending |
    Select-Object -First 1
  if ($dll) {
    try {
      Add-Type -Path $dll.FullName -ErrorAction Stop
      $drawingLoaded = $true
    } catch {}
  }
}

if (-not $drawingLoaded) {
  Write-Error "System.Drawing could not be loaded. Install .NET Desktop Runtime or run on Windows PowerShell with System.Drawing available."
  exit 1
}

function Reencode-Jpeg {
  param(
    [string]$Path,
    [int]$Quality
  )
  $img = [System.Drawing.Image]::FromFile($Path)
  try {
    $codec = [System.Drawing.Imaging.ImageCodecInfo]::GetImageEncoders() |
      Where-Object { $_.MimeType -eq "image/jpeg" }
    $params = New-Object System.Drawing.Imaging.EncoderParameters(1)
    $encoder = [System.Drawing.Imaging.Encoder]::Quality
    $param = New-Object System.Drawing.Imaging.EncoderParameter($encoder, [int]$Quality)
    $params.Param[0] = $param
    $tmp = Join-Path ([System.IO.Path]::GetDirectoryName($Path)) ([System.IO.Path]::GetRandomFileName() + ".jpg")
    $img.Save($tmp, $codec, $params)
  } finally {
    $img.Dispose()
  }

  try {
    # Overwrite original atomically
    [System.IO.File]::Delete($Path)
    Move-Item -Path $tmp -Destination $Path -Force -ErrorAction Stop
  } catch {
    Write-Warning ("Failed to replace {0}: {1}" -f $Path, $_.Exception.Message)
    if (Test-Path $tmp) { Remove-Item $tmp -Force }
  }
}

$src = Resolve-Path $SourceZip
$dest = Resolve-Path (Split-Path $OutputZip -Parent)
$destZip = Join-Path $dest (Split-Path $OutputZip -Leaf)

$workDir = Join-Path $env:TEMP "ccg_images_work"
if (Test-Path $workDir) { Remove-Item $workDir -Recurse -Force }
New-Item -ItemType Directory -Path $workDir | Out-Null

Write-Host "Extracting $src to $workDir..."
Expand-Archive -Path $src -DestinationPath $workDir -Force

$jpgs = Get-ChildItem -Path $workDir -Recurse -Include *.jpg, *.jpeg
foreach ($file in $jpgs) {
  Write-Host ("Re-encoding {0}" -f $file.FullName)
  Reencode-Jpeg -Path $file.FullName -Quality $Quality
}

if (Test-Path $destZip) { Remove-Item $destZip -Force }
Write-Host "Creating $destZip ..."
Compress-Archive -Path (Join-Path $workDir "*") -DestinationPath $destZip -CompressionLevel Optimal -Force

Write-Host "Done. Rebuilt zip at $destZip"
