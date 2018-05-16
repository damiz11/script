@echo off
if not exist Release mkdir Release
if not exist Release\Net mkdir Release\NET
ftn95 Threads.f95 /clr /clr_ver 2 /optimise /multi_threaded /binary Release\NET\Threads.dbk %1 %2 %3 %4 %5 %6 %7 %8 %9
dbk_link2 Release\NET\Threads.exe Release\NET\Threads.dbk /windows /multi_threaded
