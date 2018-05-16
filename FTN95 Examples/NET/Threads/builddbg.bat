@echo off
if not exist Debug mkdir Debug
if not exist Debug\Net mkdir Debug\NET
ftn95 Threads.f95 /clr /clr_ver 2 /debug /multi_threaded /binary Debug\NET\Threads.dbk %1 %2 %3 %4 %5 %6 %7 %8 %9
dbk_link2 Debug\NET\Threads.exe Debug\NET\Threads.dbk /windows /multi_threaded
