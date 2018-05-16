!****************************************************************************
!*                                                                          *
!* Salford ClearWin+ Example Code                                           *
!*                                                                          *
!* ENUM.F95                                                                 *
!*                                                                          *
!* Example of ClearWin+ get_font_name routine.                              *
!*                                                                          *
!* only compile using FTN95 version 1.6  or higher                          *
!*                                                                          *
!****************************************************************************
!*                                                                          *
!* Produces a list of fonts available on your system.                       *
!* by making use of the Clearwin+ function 'get_font_name@'                                                                         *
!*                                                                          *
!****************************************************************************

winapp 
program enum
   use mswin
   implicit none
   integer :: i,j,ctrl
   character(len =20):: string
   ctrl = -1   
   i=winio@('%ca[Enumarate fonts]&')
   i=winio@('%sy[thin_border]&')
   i=winio@('%bg[BTNFACE]&')    
   i=winio@('%mn[E&xit]&','EXIT')
   i=winio@('%ob[depressed]%40.20cw[vscroll]%cb&',0)
   i=winio@('%lw',ctrl)
   do j=1,1000
      call get_font_name@(string,j)
      if (string /=' ') then
         print *,j,'    [',string,']   '      
      else
         exit
      endif
   enddo
end program enum
