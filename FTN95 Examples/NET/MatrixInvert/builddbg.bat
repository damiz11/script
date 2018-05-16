@echo off
if not exist bin mkdir bin
if not exist bin\Debug mkdir bin\Debug
ftn95 "dinver.for" /clr /clr_ver 2 /debug /binary "bin\Debug\FortranMatrixInvert.dbk"
dbk_link2 "bin\Debug\FortranMatrixInvert.dll" "bin\Debug\FortranMatrixInvert.dbk" /ver:"1.0.3.1"
start csc > NUL
if errorlevel 2 goto error
csc /out:bin\Debug\MatrixInvert.exe /unsafe /debug /reference:bin\Debug\FortranMatrixInvert.dll /target:winexe Form1.cs AssemblyInfo.cs


goto end

:error
echo ***
echo *** Error: C# must be installed and be available on the path
echo ***

:end
