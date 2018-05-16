@echo off
echo OpenGL Examples
echo.
echo Note:  If this build fails you may need to edit the file
echo BUILD.BAT to specify where echo OpenGL Dynamic Link Libraries
echo reside on your system.
echo.

if (%1)==() goto ERROR
if exist %windir%\system32\opengl32.dll goto NT
GOTO DLLERROR

:NT
ftn95 %1.for /no_warn73 %2 /implicit_none
slink %1.obj %windir%\system32\opengl32.dll %windir%\system32\glu32.dll
goto END

:ERROR
echo ERROR: No file specified!
goto END

:DLLERROR
echo ERROR: You do not appear to have the required OpenGL DLL's on your system
echo        edit the file BUILD.BAT to specify the location of these files.
goto END

:END

