; Inno Setup script to fetch the latest CCG database + scripts from GitHub Pages
; and place them into a YGO Omega installation.
; Re-run this installer any time to update to the newest files on GitHub.

#define MyAppName "CCG Add-on for YGO Omega"
#define MyAppVersion "1.1.0"

[Setup]
AppName={#MyAppName}
AppVersion={#MyAppVersion}
DefaultDirName={pf32}\YGO Omega
UsePreviousAppDir=no
DisableDirPage=no
DisableProgramGroupPage=yes
PrivilegesRequired=admin
OutputDir=output
OutputBaseFilename=CCG_Omega_Addon_Setup
ArchitecturesAllowed=x86 x64
WizardStyle=modern
Compression=lzma
SolidCompression=yes
Uninstallable=no

[Messages]
; Friendly reminder about locating Omega if it is not in the default path
DirEditLabel=Select the YGO Omega folder (defaults to "C:\Program Files (x86)\YGO Omega"). If Omega is installed elsewhere, browse to its root folder before installing.

[Code]
const
  DB_URL_PRIMARY = 'https://yugiohccg.github.io/CCG%20Downloads/CCG_v1.db';
  DB_URL_FALLBACK = 'https://raw.githubusercontent.com/YugiohCCG/YugiohCCG.github.io/main/public/CCG%20Downloads/CCG_v1.db';
  SCRIPTS_URL_PRIMARY = 'https://yugiohccg.github.io/CCG%20Downloads/CCG_Scripts_v1.zip';
  SCRIPTS_URL_FALLBACK = 'https://raw.githubusercontent.com/YugiohCCG/YugiohCCG.github.io/main/public/CCG%20Downloads/CCG_Scripts_v1.zip';
  IMAGES_URL_PRIMARY_FMT = 'https://yugiohccg.github.io/CCG%20Downloads/YGO_Omega_Images_v%d.zip';
  IMAGES_URL_FALLBACK_FMT = 'https://raw.githubusercontent.com/YugiohCCG/YugiohCCG.github.io/main/public/CCG%20Downloads/YGO_Omega_Images_v%d.zip';
  DB_NAME = 'CCG_v1.db';
  SCRIPTS_FOLDER = 'CCG_Scripts_v1';
  IMAGES_FOLDER = 'YGO_Omega_Images';

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

function UnzipFile(const ZipPath, DestDir: string): Boolean;
var
  ShellApp: Variant;
begin
  Result := False;
  try
    ForceDirectories(DestDir);
    ShellApp := CreateOleObject('Shell.Application');
    ShellApp.NameSpace(DestDir).CopyHere(ShellApp.NameSpace(ZipPath).Items, 4 + 16);
    Result := True;
  except
    Log(Format('Unzip failed: %s', [ZipPath]));
  end;
end;

procedure CleanDir(const Path: string);
begin
  if DirExists(Path) then
    DelTree(Path, True, True, True);
end;

function InstallPayload: Boolean;
var
  TempDB, TempScriptsZip, TempImagesZip: string;
  DestDB, DestScripts, DestImages: string;
  lastError: string;
  imageParts: TStringList;
  i: Integer;
begin
  Result := False;
  TempDB := GetTempDir + DB_NAME;
  TempScriptsZip := GetTempDir + 'ccg_scripts.zip';
  TempImagesZip := GetTempDir + 'ccg_images.zip';

  DestDB := ExpandConstant('{app}\YGO Omega_Data\Files\Databases\' + DB_NAME);
  DestScripts := ExpandConstant('{app}\YGO Omega_Data\Files\Scripts\' + SCRIPTS_FOLDER);
  DestImages := ExpandConstant('{app}\YGO Omega_Data\Files\Pics\' + IMAGES_FOLDER);

  WizardForm.StatusLabel.Caption := 'Downloading database...';
  if not DownloadFile(DB_URL_PRIMARY, TempDB) then
  begin
    Log('Primary DB download failed, trying fallback...');
    if not DownloadFile(DB_URL_FALLBACK, TempDB) then
    begin
      lastError := 'Database download failed. Tried:' + #13#10 +
        DB_URL_PRIMARY + #13#10 + DB_URL_FALLBACK;
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

  WizardForm.StatusLabel.Caption := 'Downloading images... (large downloads)';
  imageParts := TStringList.Create;
  try
    for i := 1 to 10 do
    begin
      TempImagesZip := GetTempDir + Format('ccg_images_%d.zip', [i]);
      if not DownloadFile(Format(IMAGES_URL_PRIMARY_FMT, [i]), TempImagesZip) then
      begin
        Log(Format('Primary image part %d failed, trying fallback...', [i]));
        if not DownloadFile(Format(IMAGES_URL_FALLBACK_FMT, [i]), TempImagesZip) then
        begin
          if i = 1 then
          begin
            lastError := 'Images download failed (part 1). Tried:' + #13#10 +
              Format(IMAGES_URL_PRIMARY_FMT, [i]) + #13#10 +
              Format(IMAGES_URL_FALLBACK_FMT, [i]);
            MsgBox(lastError, mbError, MB_OK);
            imageParts.Free;
            Exit;
          end
          else
          begin
            // No more parts available
            DeleteFile(TempImagesZip);
            Break;
          end;
        end;
      end;
      imageParts.Add(TempImagesZip);
    end;
  except
    imageParts.Free;
    MsgBox('Images download failed due to an unexpected error.', mbError, MB_OK);
    Exit;
  end;

  WizardForm.StatusLabel.Caption := 'Installing...';
  ForceDirectories(ExtractFileDir(DestDB));
  if FileExists(DestDB) then
    DeleteFile(DestDB);
  if not FileCopy(TempDB, DestDB, False) then
  begin
    MsgBox('Failed to copy the database into YGO Omega.', mbError, MB_OK);
    Exit;
  end;

  CleanDir(DestScripts);
  ForceDirectories(DestScripts);
  if not UnzipFile(TempScriptsZip, DestScripts) then
  begin
    MsgBox('Failed to extract scripts into YGO Omega.', mbError, MB_OK);
    Exit;
  end;

  CleanDir(DestImages);
  ForceDirectories(DestImages);
  for i := 0 to imageParts.Count - 1 do
  begin
    if not UnzipFile(imageParts[i], DestImages) then
    begin
      MsgBox(Format('Failed to extract images part %d into YGO Omega.', [i + 1]), mbError, MB_OK);
      imageParts.Free;
      Exit;
    end;
  end;
  imageParts.Free;

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
