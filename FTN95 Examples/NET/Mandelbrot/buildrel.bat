@echo off
if not exist mandelbrotfrontend\bin mkdir mandelbrotfrontend\bin
if not exist mandelbrotfrontend\bin\Release mkdir mandelbrotfrontend\bin\Release
ftn95 mandelbrotbackend\freeformat1.f95 /clr_ver 2 /clr /optimise /ref System.Drawing.dll /ref System.Windows.Forms.dll
dbk_link2 mandelbrotbackend\freeformat1.dbk /interface_only mandelbrotfrontend\bin\Release\MandelbrotBackend.dll /ref:"System.Drawing.dll;System.Windows.Forms.dll"
csc /out:mandelbrotfrontend\bin\Release\Mandelbrot.exe /reference:mandelbrotfrontend\bin\Release\MandelbrotBackend.dll /target:winexe mandelbrotfrontend\form1.cs mandelbrotfrontend\AssemblyInfo.cs

