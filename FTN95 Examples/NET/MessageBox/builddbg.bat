@echo off

echo ***
echo *** Please ensure your .NET framework directory is on the system path
echo *** This is usually C:\WINDOWS\Microsoft.NET\Framework\v1.1.4322
echo ***

if not exist Debug mkdir Debug
if not exist Debug\Net mkdir Debug\NET
start csc > NUL
if errorlevel 2 goto error
ftn95 MessageBox.f95 /clr /clr_ver 2 /ref "System.Windows.Forms.dll" /debug /binary Debug\NET\MessageBox.dbk %1 %2 %3 %4 %5 %6 %7 %8 %9
dbk_link2 Debug\NET\MessageBox.exe Debug\NET\MessageBox.dbk /r:System.Windows.Forms.dll /windows

goto end

:error
echo ***
echo *** Error: The .NET framework directory must be on the path
echo ***
goto end

:end
