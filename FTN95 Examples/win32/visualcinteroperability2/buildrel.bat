@echo off

if not exist vcproject1\Release mkdir vcproject1\Release
cl /O2 /D "WIN32" /D "NDEBUG" /D "_WINDOWS" /D "_USRDLL" /D "VCPROJECT1_EXPORTS" /D "_WINDLL" /D "_MBCS" /FD /EHsc /MT /GS /Fp"vcproject1/Release/VCProject1.pch" /Fo"vcproject1/Release/" /Fd"vcproject1/Release/vc70.pdb" /W3 /c /Wp64 /Zi /TP vcproject1\stdafx.cpp
cl /O2 /D "WIN32" /D "NDEBUG" /D "_WINDOWS" /D "_USRDLL" /D "VCPROJECT1_EXPORTS" /D "_WINDLL" /D "_MBCS" /FD /EHsc /MT /GS /Fp"vcproject1/Release/VCProject1.pch" /Fo"vcproject1/Release/" /Fd"vcproject1/Release/vc70.pdb" /W3 /c /Wp64 /Zi /TP vcproject1\vcproject1.cpp
link /OUT:"vcproject1/Release/VCProject1.dll" /INCREMENTAL:NO /NOLOGO /DLL /DEBUG /PDB:"vcproject1/Release/VCProject1.pdb" /SUBSYSTEM:WINDOWS /OPT:REF /OPT:ICF /IMPLIB:"vcproject1/Release/VCProject1.lib" /MACHINE:X86  kernel32.lib user32.lib gdi32.lib winspool.lib comdlg32.lib advapi32.lib shell32.lib ole32.lib oleaut32.lib uuid.lib odbc32.lib odbccp32.lib vcproject1\Release\stdafx.obj vcproject1\Release\VCProject1.obj

if not exist FortranApplication1\Release mkdir FortranApplication1\Release
if not exist FortranApplication1\Release\Win32 mkdir FortranApplication1\Release\Win32
copy vcproject1\Release\VCProject1.dll FortranApplication1\Release\Win32
ftn95 FortranApplication1\FreeFormat1.f95 /p6 /ref "FortranApplication1\Release\Win32\VCProject1.dll" /BINARY "FortranApplication1\Release\Win32\FreeFormat1.obj"
slink -out:"FortranApplication1\Release\Win32\FortranApplication1.exe" "FortranApplication1\Release\Win32\FreeFormat1.obj" "FortranApplication1\Release\Win32\VCProject1.dll"


