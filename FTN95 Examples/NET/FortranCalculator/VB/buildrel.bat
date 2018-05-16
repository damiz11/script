@echo off
if not exist bin mkdir bin
if not exist bin\Release mkdir bin\Release

ftn95 calculator.f95 /clr /clr_ver 2 /binary bin\Release\calculator.dbk
dbk_link bin\Release\Calculator.dll bin\Release\calculator.dbk /cc:ftncalc /windows

start vbc >NUL
if errorlevel 2 goto error
start resgen >NUL
if errorlevel 2 goto error3

resgen /compile FortranCalculatorFrontend.resx,FortranCalculatorFrontend.VB_Calculator.resources

if not exist FortranCalculatorFrontend.VB_Calculator.resources goto error2
vbc /out:bin\Release\FortranCalculator.exe /rootnamespace:"FortranCalculatorFrontend" /main:"FortranCalculatorFrontend.VB_Calculator" /reference:System.dll,System.Data.dll,System.Drawing.dll,System.Windows.Forms.dll,System.XML.dll,bin\Release\Calculator.dll /imports:"Microsoft.VisualBasic","System","System.Collections","System.Data","System.Drawing","System.Diagnostics","System.Windows.Forms","ftncalc" /resource:"FortranCalculatorFrontend.VB_Calculator.resources" /target:winexe *.vb
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