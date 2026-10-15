
Add-Type -AssemblyName System.Drawing
$jobs = Get-Content -LiteralPath $args[0] -Raw | ConvertFrom-Json
foreach ($job in $jobs) {
  $frame = [System.Drawing.Bitmap]::new($job.target)
  $art = [System.Drawing.Image]::FromFile($job.source)
  $g = [System.Drawing.Graphics]::FromImage($frame)
  $g.InterpolationMode = [System.Drawing.Drawing2D.InterpolationMode]::HighQualityBicubic
  $path = [System.Drawing.Drawing2D.GraphicsPath]::new()
  if ($job.link) {
    $pts = [System.Drawing.Point[]]@([System.Drawing.Point]::new(114,219),[System.Drawing.Point]::new(700,219),[System.Drawing.Point]::new(714,233),[System.Drawing.Point]::new(714,818),[System.Drawing.Point]::new(700,832),[System.Drawing.Point]::new(114,832),[System.Drawing.Point]::new(100,818),[System.Drawing.Point]::new(100,233))
    $path.AddPolygon($pts)
  } else { $path.AddRectangle([System.Drawing.Rectangle]::new(100,219,614,613)) }
  $g.SetClip($path)
  $g.DrawImage($art,[System.Drawing.Rectangle]::new(100,219,614,613))
  $g.Dispose(); $art.Dispose(); $path.Dispose()
  $tmp = $job.target + '.new'
  if ([System.IO.Path]::GetExtension($job.target) -eq '.png') { $frame.Save($tmp,[System.Drawing.Imaging.ImageFormat]::Png) }
  else {
    $codec = [System.Drawing.Imaging.ImageCodecInfo]::GetImageEncoders() | Where-Object MimeType -eq 'image/jpeg'
    $params = [System.Drawing.Imaging.EncoderParameters]::new(1)
    $params.Param[0] = [System.Drawing.Imaging.EncoderParameter]::new([System.Drawing.Imaging.Encoder]::Quality,[long]100)
    $frame.Save($tmp,$codec,$params); $params.Dispose()
  }
  $frame.Dispose()
  Move-Item -LiteralPath $tmp -Destination $job.target -Force
}
