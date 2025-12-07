; Inno Setup script to bundle CCG custom database + scripts into YGO Omega.
; Default target directory: C:\Program Files (x86)\YGO Omega

#define MyAppName "CCG Add-on for YGO Omega"
#define MyAppVersion "1.0.0"

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

[Files]
; Custom database -> Databases
Source: "..\public\CCG Downloads\CCG_v1.db"; \
    DestDir: "{app}\YGO Omega_Data\Files\Databases"; \
    Flags: ignoreversion

; Custom scripts -> Scripts\CCG_Scripts_v1 (includes subfolders)
Source: "..\public\CCG Downloads\CCG_Scripts_v1\*"; \
    DestDir: "{app}\YGO Omega_Data\Files\Scripts\CCG_Scripts_v1"; \
    Flags: recursesubdirs createallsubdirs ignoreversion

[Dirs]
; Ensure the scripts folder exists even if empty at build time
Name: "{app}\YGO Omega_Data\Files\Scripts\CCG_Scripts_v1"

[Messages]
; Friendly reminder about locating Omega if it is not in the default path
DirEditLabel=Select the YGO Omega folder (defaults to "C:\Program Files (x86)\YGO Omega"). If Omega is installed elsewhere, browse to its root folder before installing.
