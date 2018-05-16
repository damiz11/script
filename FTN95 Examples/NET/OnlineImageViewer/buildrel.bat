@echo off

echo ***
echo *** Please ensure you .NET assembly directory is on the system path
echo *** This is usually C:\WINDOWS\Microsoft.NET\Framework\v1.0.3705
echo ***

if not exist Release mkdir Release
if not exist Release\Net mkdir Release\NET
start csc > NUL
if errorlevel 2 goto error
ftn95 OnlineImageViewer.f95 /clr /clr_ver 2 /ref "System.dll" /optimise /binary Release\NET\OnlineImageViewer.dbk %1 %2 %3 %4 %5 %6 %7 %8 %9
dbk_link2 Release\NET\OnlineImageViewer.exe Release\NET\OnlineImageViewer.dbk /r:System.dll /windows

goto end

:error
echo ***
echo *** Error: The .NET framework directory must be on the path
echo ***
goto end

:end
