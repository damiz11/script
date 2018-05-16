!****************************************************************************
!*                                                                          *
!* Salford ClearWin+ Example Code                                           *
!*                                                                          *
!* colprin.F95 - version 1.0 1/7/99                                         *
!*                                                                          *
!* Example of Windows API call with ClearWin+                               *
!*                                                                          *
!* only compile using FTN95 version 1.6  or higher                          *
!*                                                                          *
!****************************************************************************
!*                                                                          *
!*  A  example which shows the use of:-                                     *
!*                         windows API calls,                               *
!*                         user defined types,                              *
!*                         referencing objects,                             *
!*                         bit manipulation,                                *
!*                         attaching and icon to your program.              *
!*                                                                          *
!****************************************************************************
   

winapp 

program colourprint
   use mswin
   implicit none     
!*******************************************************************
!*                                                                 *
!*     type 'tagpoint' is defined here in order to give a data     *
!*     type which is compatible with the windows API calls to      *
!*     GetCursorPos                                                *
!*                                                                 *
!*******************************************************************  
   type tagpoint   
      sequence
      integer :: x
      integer :: y    
   end type tagpoint             

   type (tagpoint) :: pt
   integer :: win,desktop_dc,col,i,a,b,red,green,blue
   character (len=15)::buffer             
   character (len=3):: cnum@
   logical :: booldum                          
   desktop_dc=GetWindowDC(GetDesktopWindow())
   buffer='************'  
   i=winio@('%ww[minimize]%ca@%lw&',buffer,win)
   i=winio@('%mi[rgbicon]&')   
   i=winio@('%`sm[exit]&','exit')
   i=winio@('%`^bt[exit]','exit')
   do while (win < 0 )
      booldum = GetCursorPos(pt)
      if (.not.booldum) stop
      a=(pt % x)
      b=(pt % y)
      col=GetPixel(desktop_dc,a,b)
      
!*****************************************************************
!*                                                               *
!*  col is a 32 bit integer in which the lowest byte holds       *
!*  the red component, middle the blue and upper byte the        *                                *
!*  green component. This information is extracted by            *
!*  appliying a 'mask' (and-ing col with an appropriate number   *
!*  in order to get rid of the other 2 bytes) the resulting byte *
!*  is then rightshifted to give a value between 0 and 255       *
!*                                                               *
!*****************************************************************
      red=iand(col,255)
      green=rs((iand(col,65280)),8)
      blue=rs((iand(col,16711680)),16)
      buffer(1:1)='r' 
      buffer(5:5)='g'
      buffer(9:9)='b'       
      buffer(2:4)=cnum@(red)
      buffer(6:8)=cnum@(green)
      buffer(10:12)=cnum@(blue)
      call window_update@(buffer)
      call sleep@(0.25)
      call temporary_yield@()
   end while
end program colourprint

resources
rgbicon ICON colprn.ico


