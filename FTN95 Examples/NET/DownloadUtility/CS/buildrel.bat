@echo off
cd FortranFrontend
if not exist bin mkdir bin
if not exist bin\Release mkdir bin\Release
cd ..

start csc >NUL
if errorlevel 2 goto error

csc /target:library /out:CSBackend.dll CSBackend\CSBackend.cs CSBackend\AssemblyInfo.cs

if not exist CSBackend.dll goto error2

ftn95 FortranFrontend\FortranFrontend.f95 /clr /clr_ver 2 /reference "CSBackend.dll" /binary "FortranFrontend\bin\Release\FortranFrontend.dbk"

dbk_link2 FortranFrontend\bin\Release\FortranFrontend.exe FortranFrontend\bin\Release\FortranFrontend.dbk /r:CSBackend.dll /windows

move CSBackend.dll FortranFrontend\bin\Release\

goto end

:error
echo ***
echo *** Error: C# must be installed and be available on the path
echo ***

:error2
echo ***
echo *** Error: Unable to create CSBackend.dll
echo ***

:end
