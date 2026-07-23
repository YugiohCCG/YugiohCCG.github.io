; Inno Setup script to fetch the latest CCG database, scripts, and assets from GitHub Pages
; and place them into a YGO Omega installation.
; Re-run this installer any time to update to the newest files on GitHub.

#define MyAppName "CCG Add-on for YGO Omega"
#define MyAppVersion "1.3.1"

[Setup]
AppName={#MyAppName}
AppVersion={#MyAppVersion}
DefaultDirName={commonpf32}\YGO Omega
UsePreviousAppDir=no
DisableDirPage=no
DisableProgramGroupPage=yes
PrivilegesRequired=admin
OutputDir=output
OutputBaseFilename=CCG_Omega_Addon_Setup
ArchitecturesAllowed=x86 x64compatible
WizardStyle=modern
Compression=lzma
SolidCompression=yes
Uninstallable=no

[Messages]
; Friendly reminder about locating Omega if it is not in the default path
SelectDirLabel3=Select the YGO Omega folder. If Omega is installed elsewhere, browse to its root folder before installing.

[Code]
const
  DB_ZIP_URL_PRIMARY = 'https://yugiohccg.github.io/CCG%20Downloads/CCG_Database/CCG_Database.zip';
  DB_ZIP_URL_FALLBACK = 'https://raw.githubusercontent.com/YugiohCCG/YugiohCCG.github.io/main/public/CCG%20Downloads/CCG_Database/CCG_Database.zip';
  SCRIPTS_URL_PRIMARY = 'https://yugiohccg.github.io/CCG%20Downloads/CCG_Scripts/CCG_Scripts.zip';
  SCRIPTS_URL_FALLBACK = 'https://raw.githubusercontent.com/YugiohCCG/YugiohCCG.github.io/main/public/CCG%20Downloads/CCG_Scripts/CCG_Scripts.zip';
  BANLIST_URL_PRIMARY = 'https://yugiohccg.github.io/CCG%20Downloads/CCG_Banlist/CCG_Banlist.lflist.conf';
  BANLIST_URL_FALLBACK = 'https://raw.githubusercontent.com/YugiohCCG/YugiohCCG.github.io/main/public/CCG%20Downloads/CCG_Banlist/CCG_Banlist.lflist.conf';
  IMAGES_URL_PRIMARY_FMT = 'https://yugiohccg.github.io/CCG%%20Downloads/YGO_Omega_Images_v%d.zip';
  IMAGES_URL_FALLBACK_FMT = 'https://raw.githubusercontent.com/YugiohCCG/YugiohCCG.github.io/main/public/CCG%%20Downloads/YGO_Omega_Images_v%d.zip';
  PICS_URL_PRIMARY_FMT = 'https://yugiohccg.github.io/CCG%%20Downloads/YGO_Omega_Images/YGO_Omega_Pics_v%d.zip';
  PICS_URL_FALLBACK_FMT = 'https://raw.githubusercontent.com/YugiohCCG/YugiohCCG.github.io/main/public/CCG%%20Downloads/YGO_Omega_Images/YGO_Omega_Pics_v%d.zip';
  HOLOGRAMS_URL_PRIMARY_FMT = 'https://yugiohccg.github.io/CCG%%20Downloads/YGO_Omega_Images/YGO_Omega_Holograms_v%d.zip';
  HOLOGRAMS_URL_FALLBACK_FMT = 'https://raw.githubusercontent.com/YugiohCCG/YugiohCCG.github.io/main/public/CCG%%20Downloads/YGO_Omega_Images/YGO_Omega_Holograms_v%d.zip';
  DB_ZIP_NAME = 'CCG_Database.zip';
  DB_NAME = 'CCG_v1.db';
  BANLIST_NAME = 'CCG_Banlist.lflist.conf';
  IMAGE_PART_COUNT = 1;
  PICS_PART_COUNT = 4;
  HOLOGRAM_PART_COUNT = 3;

function URLDownloadToFile(Caller: Integer; URL, FileName: string; Reserved: Integer; Bind: Integer): Integer;
  external 'URLDownloadToFileW@urlmon.dll stdcall';

function DownloadFile(const URL, DestFile: string): Boolean;
var
  HTTP, Stream: Variant;
begin
  Result := False;
  try
    HTTP := CreateOleObject('WinHttp.WinHttpRequest.5.1');
    // Force modern TLS (TLS1.1 | TLS1.2)
    HTTP.Option(9) := $00000A00;
    HTTP.Open('GET', URL, False);
    HTTP.SetRequestHeader('User-Agent', 'Mozilla/5.0 (InnoSetup)');
    HTTP.Send;
    if (HTTP.status <> 200) then
    begin
      Log(Format('HTTP %d while downloading %s', [HTTP.status, URL]));
      // fallback to URLMon if WinHTTP fails or returns non-200
      if URLDownloadToFile(0, URL, DestFile, 0, 0) = 0 then
      begin
        Result := True;
        Exit;
      end;
      Exit;
    end;

    Stream := CreateOleObject('ADODB.Stream');
    Stream.Type_ := 1; // binary (Type is reserved, use Type_)
    Stream.Open;
    Stream.Write(HTTP.responseBody);
    Stream.SaveToFile(DestFile, 2); // overwrite
    Stream.Close;
    Result := True;
  except
    Log(Format('Download failed via WinHTTP: %s', [URL]));
    if URLDownloadToFile(0, URL, DestFile, 0, 0) = 0 then
      Result := True
    else
      Log('URLDownloadToFile also failed.');
  end;
end;

function PowerShellLiteral(const Value: string): string;
begin
  Result := Value;
  StringChangeEx(Result, '''', '''''', True);
  Result := '''' + Result + '''';
end;

function UnzipFile(const ZipPath, DestDir: string): Boolean;
var
  PowerShellPath, PowerShellArgs: string;
  ResultCode: Integer;
begin
  Result := False;
  try
    ForceDirectories(DestDir);
    PowerShellPath := ExpandConstant('{sys}\WindowsPowerShell\v1.0\powershell.exe');
    PowerShellArgs := '-NoProfile -ExecutionPolicy Bypass -Command ' +
      AddQuotes('Expand-Archive -LiteralPath ' + PowerShellLiteral(ZipPath) +
        ' -DestinationPath ' + PowerShellLiteral(DestDir) + ' -Force');
    if Exec(PowerShellPath, PowerShellArgs, '', SW_HIDE, ewWaitUntilTerminated, ResultCode) and
      (ResultCode = 0) then
    begin
      Result := True;
    end
    else
    begin
      Log(Format('PowerShell extraction failed for %s with exit code %d.', [ZipPath, ResultCode]));
    end;
  except
    Log(Format('Unzip failed: %s', [ZipPath]));
  end;
end;

function IsOmegaRoot(const RootDir: string): Boolean;
begin
  Result := DirExists(AddBackslash(RootDir) + 'YGO Omega_Data\Files');
end;

function NextButtonClick(CurPageID: Integer): Boolean;
begin
  Result := True;
  if (CurPageID = wpSelectDir) and not IsOmegaRoot(WizardDirValue) then
  begin
    MsgBox('That folder does not appear to be the YGO Omega root. Select the folder that contains YGO Omega_Data.',
      mbError, MB_OK);
    Result := False;
  end;
end;

function InstallPayload: Boolean;
var
  TempDbZip, TempScriptsZip, TempImagesZip, TempPicsZip, TempHologramsZip, TempBanlist: string;
  DestDB, DestScriptsRoot, DestImages, DestPics, DestHolograms, DestBanlist: string;
  lastError: string;
  imageParts, picsParts, hologramParts: TStringList;
  i: Integer;
begin
  Result := False;
  if not IsOmegaRoot(ExpandConstant('{app}')) then
  begin
    MsgBox('The selected folder is not a YGO Omega root (YGO Omega_Data\Files was not found).',
      mbError, MB_OK);
    Exit;
  end;
  TempDbZip := GetTempDir + DB_ZIP_NAME;
  TempScriptsZip := GetTempDir + 'ccg_scripts.zip';
  TempImagesZip := GetTempDir + 'ccg_images.zip';
  TempPicsZip := GetTempDir + 'ccg_pics.zip';
  TempBanlist := GetTempDir + 'ccg_banlist.lflist';

  DestDB := ExpandConstant('{app}\YGO Omega_Data\Files\Databases\' + DB_NAME);
  DestScriptsRoot := ExpandConstant('{app}\YGO Omega_Data\Files\Scripts');
  DestBanlist := ExpandConstant('{app}\YGO Omega_Data\Files\Banlists\' + BANLIST_NAME);
  // Omega expects images directly under Files\Arts (no subfolder)
  DestImages := ExpandConstant('{app}\YGO Omega_Data\Files\Arts');
  // Omega expects full-card images directly under Files\Pics (no subfolder)
  DestPics := ExpandConstant('{app}\YGO Omega_Data\Files\Pics');
  // Omega expects holograms directly under Files\Holograms (no subfolder)
  DestHolograms := ExpandConstant('{app}\YGO Omega_Data\Files\Holograms');

  WizardForm.StatusLabel.Caption := 'Downloading database payload...';
  if not DownloadFile(DB_ZIP_URL_PRIMARY, TempDbZip) then
  begin
    Log('Primary DB download failed, trying fallback...');
    if not DownloadFile(DB_ZIP_URL_FALLBACK, TempDbZip) then
    begin
      lastError := 'Database download failed. Tried:' + #13#10 +
        DB_ZIP_URL_PRIMARY + #13#10 + DB_ZIP_URL_FALLBACK;
      MsgBox(lastError, mbError, MB_OK);
      Exit;
    end;
  end;

  WizardForm.StatusLabel.Caption := 'Downloading scripts...';
  if not DownloadFile(SCRIPTS_URL_PRIMARY, TempScriptsZip) then
  begin
    Log('Primary scripts download failed, trying fallback...');
    if not DownloadFile(SCRIPTS_URL_FALLBACK, TempScriptsZip) then
    begin
      lastError := 'Scripts download failed. Tried:' + #13#10 +
        SCRIPTS_URL_PRIMARY + #13#10 + SCRIPTS_URL_FALLBACK;
      MsgBox(lastError, mbError, MB_OK);
      Exit;
    end;
  end;

  WizardForm.StatusLabel.Caption := 'Downloading banlist...';
  if not DownloadFile(BANLIST_URL_PRIMARY, TempBanlist) then
  begin
    Log('Primary banlist download failed, trying fallback...');
    if not DownloadFile(BANLIST_URL_FALLBACK, TempBanlist) then
    begin
      lastError := 'Banlist download failed. Tried:' + #13#10 +
        BANLIST_URL_PRIMARY + #13#10 + BANLIST_URL_FALLBACK;
      MsgBox(lastError, mbError, MB_OK);
      Exit;
    end;
  end;

  WizardForm.StatusLabel.Caption := 'Downloading holograms... (large downloads)';
  hologramParts := TStringList.Create;
  for i := 1 to HOLOGRAM_PART_COUNT do
  begin
    TempHologramsZip := GetTempDir + Format('ccg_holograms_%d.zip', [i]);
    if not DownloadFile(Format(HOLOGRAMS_URL_PRIMARY_FMT, [i]), TempHologramsZip) then
    begin
      Log(Format('Primary hologram part %d failed, trying fallback...', [i]));
      if not DownloadFile(Format(HOLOGRAMS_URL_FALLBACK_FMT, [i]), TempHologramsZip) then
      begin
        lastError := Format('Holograms download failed (part %d). Tried:', [i]) + #13#10 +
          Format(HOLOGRAMS_URL_PRIMARY_FMT, [i]) + #13#10 +
          Format(HOLOGRAMS_URL_FALLBACK_FMT, [i]);
        MsgBox(lastError, mbError, MB_OK);
        hologramParts.Free;
        Exit;
      end;
    end;
    hologramParts.Add(TempHologramsZip);
  end;

  WizardForm.StatusLabel.Caption := 'Downloading images... (large downloads)';
  imageParts := TStringList.Create;
  for i := 1 to IMAGE_PART_COUNT do
  begin
    TempImagesZip := GetTempDir + Format('ccg_images_%d.zip', [i]);
    if not DownloadFile(Format(IMAGES_URL_PRIMARY_FMT, [i]), TempImagesZip) then
    begin
      Log(Format('Primary image part %d failed, trying fallback...', [i]));
      if not DownloadFile(Format(IMAGES_URL_FALLBACK_FMT, [i]), TempImagesZip) then
      begin
        lastError := Format('Images download failed (part %d). Tried:', [i]) + #13#10 +
          Format(IMAGES_URL_PRIMARY_FMT, [i]) + #13#10 +
          Format(IMAGES_URL_FALLBACK_FMT, [i]);
        MsgBox(lastError, mbError, MB_OK);
        hologramParts.Free;
        imageParts.Free;
        Exit;
      end;
    end;
    imageParts.Add(TempImagesZip);
  end;

  WizardForm.StatusLabel.Caption := 'Downloading full-card images... (large downloads)';
  picsParts := TStringList.Create;
  for i := 1 to PICS_PART_COUNT do
  begin
    TempPicsZip := GetTempDir + Format('ccg_pics_%d.zip', [i]);
    if not DownloadFile(Format(PICS_URL_PRIMARY_FMT, [i]), TempPicsZip) then
    begin
      Log(Format('Primary full-card image part %d failed, trying fallback...', [i]));
      if not DownloadFile(Format(PICS_URL_FALLBACK_FMT, [i]), TempPicsZip) then
      begin
        lastError := Format('Full-card images download failed (part %d). Tried:', [i]) + #13#10 +
          Format(PICS_URL_PRIMARY_FMT, [i]) + #13#10 +
          Format(PICS_URL_FALLBACK_FMT, [i]);
        MsgBox(lastError, mbError, MB_OK);
        hologramParts.Free;
        imageParts.Free;
        picsParts.Free;
        Exit;
      end;
    end;
    picsParts.Add(TempPicsZip);
  end;

  WizardForm.StatusLabel.Caption := 'Installing...';
  ForceDirectories(ExtractFileDir(DestDB));
  if not UnzipFile(TempDbZip, ExtractFileDir(DestDB)) then
  begin
    MsgBox('Failed to extract the database payload into YGO Omega.', mbError, MB_OK);
    hologramParts.Free;
    imageParts.Free;
    picsParts.Free;
    Exit;
  end;
  if not FileExists(DestDB) then
  begin
    MsgBox('Database payload is missing CCG_v1.db.', mbError, MB_OK);
    hologramParts.Free;
    imageParts.Free;
    picsParts.Free;
    Exit;
  end;

  // Omega resolves c<ID>.lua directly from Files\Scripts.
  ForceDirectories(DestScriptsRoot);
  if not UnzipFile(TempScriptsZip, DestScriptsRoot) then
  begin
    MsgBox('Failed to extract scripts into YGO Omega.', mbError, MB_OK);
    hologramParts.Free;
    imageParts.Free;
    picsParts.Free;
    Exit;
  end;

  ForceDirectories(ExtractFileDir(DestBanlist));
  if not CopyFile(TempBanlist, DestBanlist, False) then
  begin
    MsgBox('Failed to copy the banlist into YGO Omega.', mbError, MB_OK);
    hologramParts.Free;
    imageParts.Free;
    picsParts.Free;
    Exit;
  end;

  ForceDirectories(DestHolograms);
  for i := 0 to hologramParts.Count - 1 do
  begin
    if not UnzipFile(hologramParts[i], DestHolograms) then
    begin
      MsgBox(Format('Failed to extract holograms part %d into YGO Omega.', [i + 1]), mbError, MB_OK);
      hologramParts.Free;
      imageParts.Free;
      picsParts.Free;
      Exit;
    end;
  end;

  ForceDirectories(DestImages);
  for i := 0 to imageParts.Count - 1 do
  begin
    if not UnzipFile(imageParts[i], DestImages) then
    begin
      MsgBox(Format('Failed to extract images part %d into YGO Omega.', [i + 1]), mbError, MB_OK);
      hologramParts.Free;
      imageParts.Free;
      picsParts.Free;
      Exit;
    end;
  end;

  ForceDirectories(DestPics);
  for i := 0 to picsParts.Count - 1 do
  begin
    if not UnzipFile(picsParts[i], DestPics) then
    begin
      MsgBox(Format('Failed to extract full-card images part %d into YGO Omega.', [i + 1]), mbError, MB_OK);
      hologramParts.Free;
      imageParts.Free;
      picsParts.Free;
      Exit;
    end;
  end;
  hologramParts.Free;
  imageParts.Free;
  picsParts.Free;

  Log('Install completed.');
  Result := True;
end;

procedure CurStepChanged(CurStep: TSetupStep);
begin
  if CurStep = ssInstall then
  begin
    if not InstallPayload then
    begin
      MsgBox('Installation aborted due to download or copy failure.', mbError, MB_OK);
      Abort;
    end;
  end;
end;
