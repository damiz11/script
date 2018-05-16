!***************************************************************************
!                                                                          *
! Salford ClearWin+ Example Code                                           *
!                                                                          *
! cu.f95 - version 1.0  30/6/99                                            *
!                                                                          *
! Example using Cursors in ClearWin+ Graphics Regions                      *
!                                                                          *
! only compile using FTN95 version 1.6  or higher                          *
!                                                                          *
!***************************************************************************

module cur_com
   use mswin
   implicit none
   integer :: toggle
   
contains
!***************************************************************************
!                                                                          *
! Callback function to toggle the waiting cursor on/off                    *
!                                                                          *
!***************************************************************************
   integer function cb_waiting()   
      call set_cursor_waiting@(toggle)
      toggle = iand(toggle+1,1)
      cb_waiting=2
   end function cb_waiting
end cur_com

winapp 
!*************************************************************
!            MAIN  PROGRAM                                   *
!*************************************************************

program cursor
   use mswin
   use cur_com
   implicit none
   integer :: i 
   toggle=1
   i=winio@('%`ca[Cursors]&')
   i=winio@('%bg[BTNFACE]&')
!*************************************************************
!      CURSOR_SIZENS or IDC_SIZENS can be used               *
!      i = winio@('%`cu&',CURSOR_SIZENS)                     *
!*************************************************************

!*************************************************************
! Use a Windows cursor                                       *
!*************************************************************
   i = winio@('%`cu&',IDC_SIZENS)
   i = winio@('%`gr[blue]   &',150,100,1)
!*************************************************************
! Use our own cursor                                         *
!*************************************************************
   i = winio@('%cu[my_cursor]&')
   i = winio@('%`gr[red]%ff%nl&',150,100,2)
   i = winio@('%rj%`^tt[Waiting <HIT RETURN>]&',cb_waiting)
   i = winio@('%^tt[Close]','EXIT')
end program cursor

resources
my_cursor CURSOR cursor.cur