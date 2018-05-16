@echo off

if not exist FortranApplicationExtension1\Debug mkdir FortranApplicationExtension1\Debug
if not exist FortranApplicationExtension1\Debug\Win32 mkdir FortranApplicationExtension1\Debug\Win32
ftn95 FortranApplicationExtension1\FreeFormat1.f95 /debug /binary FortranApplicationExtension1\Debug\Win32\FreeFormat1.obj
slink -exportall -archive:FortranApplicationExtension1\Debug\Win32\FortranApplicationExtension1.lib FortranApplicationExtension1\Debug\Win32\FreeFormat1.obj -dll -out:FortranApplicationExtension1\Debug\Win32\FortranApplicationExtension1.lib

if not exist vcproject1\Debug mkdir vcproject1\Debug
copy FortranApplicationExtension1\Debug\Win32\FortranApplicationExtension1.dll vcproject1\Debug
cl /Od /D "WIN32" /D "_DEBUG" /D "_CONSOLE" /D "_MBCS" /Gm /EHsc /RTC1 /Fp"vcproject1/Debug/VCProject1.pch" /Fo"vcproject1/Debug/" /Fd"vcproject1/Debug/vc70.pdb" /W3 /c /Wp64 /ZI /TP vcproject1\stdafx.cpp
cl /Od /D "WIN32" /D "_DEBUG" /D "_CONSOLE" /D "_MBCS" /Gm /EHsc /RTC1 /Fp"vcproject1/Debug/VCProject1.pch" /Fo"vcproject1/Debug/" /Fd"vcproject1/Debug/vc70.pdb" /W3 /c /Wp64 /ZI /TP vcproject1\vcproject1.cpp
link /OUT:"vcproject1/Debug/VCProject1.exe" /INCREMENTAL /NODEFAULTLIB:LIBCMT /NOLOGO /DEBUG /PDB:"vcproject1/Debug/VCProject1.pdb" /SUBSYSTEM:CONSOLE /MACHINE:X86 kernel32.lib user32.lib gdi32.lib winspool.lib comdlg32.lib advapi32.lib shell32.lib ole32.lib oleaut32.lib uuid.lib odbc32.lib odbccp32.lib msvcrtd.lib  FortranApplicationExtension1\Debug\Win32\FortranApplicationExtension1.lib vcproject1\debug\stdafx.obj vcproject1\debug\VCProject1.obj



