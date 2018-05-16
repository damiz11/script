@echo off

if not exist FortranApplicationExtension1\Release mkdir FortranApplicationExtension1\Release
if not exist FortranApplicationExtension1\Release\Win32 mkdir FortranApplicationExtension1\Release\Win32
ftn95 FortranApplicationExtension1\FreeFormat1.f95 /p6 /binary FortranApplicationExtension1\Release\Win32\FreeFormat1.obj
slink -exportall -archive:FortranApplicationExtension1\Release\Win32\FortranApplicationExtension1.lib FortranApplicationExtension1\Release\Win32\FreeFormat1.obj -dll -out:FortranApplicationExtension1\Release\Win32\FortranApplicationExtension1.lib

if not exist vcproject1\Release mkdir vcproject1\Release
copy FortranApplicationExtension1\Release\Win32\FortranApplicationExtension1.dll vcproject1\Release
cl /O2 /D "WIN32" /D "NDEBUG" /D "_CONSOLE" /D "_MBCS" /FD /EHsc /ML /GS /Fp"vcproject1/Release/VCProject1.pch" /Fo"vcproject1/Release/" /Fd"vcproject1/Release/vc70.pdb" /W3 /c /Wp64 /Zi /TP vcproject1\stdafx.cpp
cl /O2 /D "WIN32" /D "NDEBUG" /D "_CONSOLE" /D "_MBCS" /FD /EHsc /ML /GS /Fp"vcproject1/Release/VCProject1.pch" /Fo"vcproject1/Release/" /Fd"vcproject1/Release/vc70.pdb" /W3 /c /Wp64 /Zi /TP vcproject1\vcproject1.cpp
link /OUT:"vcproject1/Release/VCProject1.exe" /INCREMENTAL:NO /NOLOGO /DEBUG /PDB:"vcproject1/Release/VCProject1.pdb" /SUBSYSTEM:CONSOLE /OPT:REF /OPT:ICF /MACHINE:X86 kernel32.lib user32.lib gdi32.lib winspool.lib comdlg32.lib advapi32.lib shell32.lib ole32.lib oleaut32.lib uuid.lib odbc32.lib odbccp32.lib FortranApplicationExtension1\Release\Win32\FortranApplicationExtension1.lib vcproject1\Release\stdafx.obj vcproject1\Release\VCProject1.obj



