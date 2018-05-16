@echo off
if not exist bin mkdir bin
if not exist bin\Release mkdir bin\Release
ftn95 Calculator.f95 /clr /clr_ver 2 /optimise /link bin\Release\Calculator.dll
start csc > NUL
if errorlevel 2 goto error
csc /out:bin\Release\FortranCalculator.exe /unsafe /reference:bin\Release\Calculator.dll /target:winexe UserInterface.cs AssemblyInfo.cs


goto end

:error
echo ***
echo *** Error: C# must be installed and be available on the path
echo ***

:end
