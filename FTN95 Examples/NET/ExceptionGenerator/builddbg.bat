@echo off
if not exist Debug mkdir Debug
if not exist Debug\Net mkdir Debug\NET
ftn95 ExceptionGenerator.for /clr /clr_ver 2 /debug /binary Debug\NET\ExceptionGenerator.dbk %1 %2 %3 %4 %5 %6 %7 %8 %9
dbk_link2 Debug\NET\ExceptionGenerator.exe Debug\NET\ExceptionGenerator.dbk
