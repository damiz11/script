!  --------------------------------------------------
!  Salford Software FTN95 .NET for Visual Studio .NET
!  Free Format FTN95 Source File
!  --------------------------------------------------

PROGRAM DownloadFile
!declare variables 
   IMPLICIT NONE
   INCLUDE <clearwin.ins>
   CHARACTER*256 output
   COMMON output, greyed
   INTEGER i, greyed
   INTEGER callbackfunc
   EXTERNAL callbackfunc

!initialise variables
   output = "Click the button the retrieve the string"
   greyed = 1  
!display window using clearwin+
   i=winio@("%sy[3d_thin]%ca[Example: Download A File with VB .NET]&")
   i=winio@("%40.5st%ff%nl&",output) 
   i=winio@("%`~^bt[View String]",greyed, callbackfunc)
END PROGRAM

INTEGER FUNCTION callbackfunc ()
  IMPLICIT NONE
!Declare variables  
  INCLUDE <clearwin.ins>
  ASSEMBLY_EXTERNAL (name="VBBackend.DownloadUtil.DownloadFile") downloadfile
  OBJECT ("VBBackend.DownloadUtil") client
  CHARACTER*256 output
  integer greyed
  COMMON output, greyed
  STRING webaddr
  STRING filename
  STRING strObj
!initialise variables
  greyed = 0
  client = new@("VBBackend.DownloadUtil")   
  filename  = "CallVB.dat"
  webaddr = "http://www2.salfordsoftware.co.uk/compilers/" 
!calling the VB
  strObj = downloadfile(client, webaddr, filename)
!display string returned from VB 
  output = strObj
  CALL window_update@(output)
  callbackfunc = 1
END FUNCTION