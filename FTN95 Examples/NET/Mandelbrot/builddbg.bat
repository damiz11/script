@echo off
if not exist mandelbrotfrontend\bin mkdir mandelbrotfrontend\bin
if not exist mandelbrotfrontend\bin\Debug mkdir mandelbrotfrontend\bin\Debug
ftn95 mandelbrotbackend\freeformat1.f95 /clr /clr_ver 2 /debug /ref System.Drawing.dll /ref System.Windows.Forms.dll
dbk_link2 mandelbrotbackend\freeformat1.dbk /interface_only mandelbrotfrontend\bin\Debug\MandelbrotBackend.dll /ref:"System.Drawing.dll;System.Windows.Forms.dll"
csc /out:mandelbrotfrontend\bin\Debug\Mandelbrot.exe /debug /reference:mandelbrotfrontend\bin\Debug\MandelbrotBackend.dll /target:winexe mandelbrotfrontend\form1.cs mandelbrotfrontend\AssemblyInfo.cs

