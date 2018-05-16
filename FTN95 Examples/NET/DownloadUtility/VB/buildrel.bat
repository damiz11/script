@echo off
if not exist FortranFrontend\bin mkdir FortranFrontend\bin
if not exist FortranFrontend\bin\Release mkdir FortranFrontend\bin\Release

start vbc > NUL
if errorlevel 2 goto error

vbc /t:library /r:System.dll,System.Data.dll /rootnamespace:"VBBackend" /out:VBBackend.dll VBBackend\*.vb

if not exist VBBackend.dll goto error2

ftn95 FortranFrontend\FortranFrontend.f95 /clr /clr_ver 2 /ref VBBackend.dll /binary "FortranFrontend\bin\Release\FortranFrontend.dbk"

dbk_link2 FortranFrontend\bin\Release\FortranFrontend.exe FortranFrontend\bin\Release\FortranFrontend.dbk /r:VBBackend.dll /windows

move VBBackend.dll FortranFrontend\bin\Release\

goto end

:error
echo ***
echo *** Error: VB .NET must be installed and be available on the path
echo ***

:error2
echo ***
echo *** Error: Unable to create VBBackend.dll
echo ***

:end