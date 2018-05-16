@echo off
if not exist bin mkdir bin
if not exist bin\Debug mkdir bin\Debug

ftn95 calculator.f95 /clr /clr_ver 2 /debug /binary bin\Debug\calculator.dbk
dbk_link bin\Debug\Calculator.dll bin\Debug\calculator.dbk /cc:ftncalc /windows

start vbc >NUL
if errorlevel 2 goto error
start resgen >NUL
if errorlevel 2 goto error3

resgen /compile FortranCalculatorFrontend.resx,FortranCalculatorFrontend.VB_Calculator.resources

if not exist FortranCalculatorFrontend.VB_Calculator.resources goto error2

vbc /out:bin\Debug\FortranCalculator.exe /rootnamespace:"FortranCalculatorFrontend" /main:"FortranCalculatorFrontend.VB_Calculator" /debug /reference:System.dll,System.Data.dll,System.Drawing.dll,System.Windows.Forms.dll,System.XML.dll,bin\Debug\Calculator.dll /imports:"Microsoft.VisualBasic","System","System.Collections","System.Data","System.Drawing","System.Diagnostics","System.Windows.Forms","ftncalc" /resource:"FortranCalculatorFrontend.VB_Calculator.resources" /target:winexe *.vb

del FortranCalculatorFrontend.VB_Calculator.resources

goto end

:error
echo ***
echo *** Error: VB.NET must be installed and be available on the path
echo ***

:error2
echo ***
echo *** Error: Unable to create FortranCalculator.exe
echo ***

:error3
echo ***
echo *** Error: ResGen.exe not detected, Unable to create FortranCalculator.exe
echo ***

:end