@echo off
if not exist bin mkdir bin
if not exist bin\Debug mkdir bin\Debug
ftn95 Calculator.f95 /link bin\Debug\Calculator.dll /clr /clr_ver 2 /debug
start csc >NUL
if errorlevel 2 goto error
csc /out:bin\Debug\FortranCalculator.exe /unsafe /debug /reference:bin\Debug\Calculator.dll /target:winexe UserInterface.cs AssemblyInfo.cs


goto end

:error
echo ***
echo *** Error: C# must be installed and be available on the path
echo ***

:end
