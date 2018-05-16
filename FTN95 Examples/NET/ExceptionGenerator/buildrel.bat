@echo off
if not exist Release mkdir Release
if not exist Release\Net mkdir Release\NET
ftn95 ExceptionGenerator.for /clr /clr_ver 2 /optimise /binary Release\NET\ExceptionGenerator.dbk %1 %2 %3 %4 %5 %6 %7 %8 %9
dbk_link2 Release\NET\ExceptionGenerator.exe Release\NET\ExceptionGenerator.dbk
