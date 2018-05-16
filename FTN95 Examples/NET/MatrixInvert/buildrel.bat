@echo off
if not exist bin mkdir bin
if not exist bin\Release mkdir bin\Release
ftn95 "dinver.for" /clr /clr_ver 2 /binary "bin\Release\FortranMatrixInvert.dbk"
dbk_link2 "bin\Release\FortranMatrixInvert.dll" "bin\Release\FortranMatrixInvert.dbk" /ver:"1.0.3.1"
start csc > NUL
if errorlevel 2 goto error
csc /out:bin\Release\MatrixInvert.exe /unsafe /debug /reference:bin\Release\FortranMatrixInvert.dll /target:winexe Form1.cs AssemblyInfo.cs


goto end

:error
echo ***
echo *** Error: C# must be installed and be available on the path
echo ***

:end
