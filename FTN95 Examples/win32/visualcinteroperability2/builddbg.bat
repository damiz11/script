@echo off

if not exist vcproject1\Debug mkdir vcproject1\Debug
cl /Od /D "WIN32" /D "_DEBUG" /D "_WINDOWS" /D "_USRDLL" /D "VCPROJECT1_EXPORTS" /D "_WINDLL" /D "_MBCS" /Gm /EHsc /RTC1 /MTd /Fp"vcproject1/Debug/VCProject1.pch" /Fo"vcproject1/Debug/" /Fd"vcproject1/Debug/vc70.pdb" /W3 /c /Wp64 /ZI /TP vcproject1\stdafx.cpp
cl /Od /D "WIN32" /D "_DEBUG" /D "_WINDOWS" /D "_USRDLL" /D "VCPROJECT1_EXPORTS" /D "_WINDLL" /D "_MBCS" /Gm /EHsc /RTC1 /MTd /Fp"vcproject1/Debug/VCProject1.pch" /Fo"vcproject1/Debug/" /Fd"vcproject1/Debug/vc70.pdb" /W3 /c /Wp64 /ZI /TP vcproject1\vcproject1.cpp
link /OUT:"vcproject1/Debug/VCProject1.dll" /INCREMENTAL /NOLOGO /DLL /DEBUG /PDB:"vcproject1/Debug/VCProject1.pdb" /SUBSYSTEM:WINDOWS /IMPLIB:"vcproject1/Debug/VCProject1.lib" /MACHINE:X86  kernel32.lib user32.lib gdi32.lib winspool.lib comdlg32.lib advapi32.lib shell32.lib ole32.lib oleaut32.lib uuid.lib odbc32.lib odbccp32.lib vcproject1\debug\stdafx.obj vcproject1\debug\VCProject1.obj

if not exist FortranApplication1\Debug mkdir FortranApplication1\Debug
if not exist FortranApplication1\Debug\Win32 mkdir FortranApplication1\Debug\Win32
copy vcproject1\Debug\VCProject1.dll FortranApplication1\Debug\Win32
ftn95 FortranApplication1\FreeFormat1.f95 /debug /ref "FortranApplication1\Debug\Win32\VCProject1.dll" /BINARY "FortranApplication1\Debug\Win32\FreeFormat1.obj"
slink -out:"FortranApplication1\Debug\Win32\FortranApplication1.exe" "FortranApplication1\Debug\Win32\FreeFormat1.obj" "FortranApplication1\Debug\Win32\VCProject1.dll"


