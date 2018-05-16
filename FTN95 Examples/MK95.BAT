@echo off
if (%1)==() GOTO NOPARAM

ftn95 demo95.f90 /no_console >> %1

goto END

:NOPARAM
FTN95 DEMO95.f90 /silent /link

:end
