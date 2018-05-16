!****************************************************************************
!                                                                           *
! Salford ClearWin+ Example Code                                            *
!*                                                                          *
!* RESIZE.F95 - version 1.0 26/6/99                                                *
!*                                                                          *
!* only compile using FTN95 version 1.6 or higher                           *
!*                                                                          *
!* Example of ClearWin+ Resizable %gr window                                *
!*                                                                          *
!****************************************************************************
!****************************************************************************
!*                                                                          *
!* Resizable window example using windows API calls including:-             *
!*                                        SetWindowPos                      *                 
!*                                        GetWindowRect                     *
!*                                        GetWindowLong                     *
!*                                        SetWindowPos                      *
!*                                        MoveWindow                                  *
!*                                                                          *
!****************************************************************************


module com_res
   use mswin    
   implicit none  
   integer ::hwnd
   integer , dimension(4) ::rect 
        
contains                        
   
   integer function draw_func()
      logical :: dummy      
      dummy = GetWindowRect(hwnd,rect)  
      if (.not.dummy) stop
      call draw_line@(0,0,200,200,rgb@(255,0,0))   
      call draw_line@(0,200,200,0,rgb@(255,0,0))      
      draw_func = 2
   end function draw_func  
 
   integer function resize_func() 
      integer :: s 
      logical :: x     
      integer :: wsm,swpz,swpm 
      integer :: res,i
! get the style of the window
      s = GetWindowLong(hwnd,GWL_STYLE)
      wsm  = WS_MAXIMIZE
      swpz = SWP_NOZORDER 
      swpm = SWP_NOMOVE
      res  = and(s,wsm)
      if(not(res) == 0) then
! the window is not maximized     
         x = SetWindowPos(hwnd,0,0,0,200,200,or(swpz,swpm))
      else
! don't call SetWindowPos because :
! the window is maximized 
         x = MoveWindow(hwnd,rect(1),rect(2),200,200,1)
         if (.not.x)stop
! set the window style as not maximized
         i = SetWindowLong(hwnd,GWL_STYLE,and(s,not(wsm)))
         if(i==0)stop
      endif                       
      resize_func = 1
   end function resize_func              
end module com_res

!      *******************************************
!      *            Main Program                 *
!      *******************************************
winapp 
program resize
   use mswin
   use salf_about
   use com_res
   implicit none
   integer :: ctrl,i
   ctrl = 0
   i = winio@('%ca[Resize me]&')               
   i = winio@('%ww Please select Resize %2nl&')
   i = winio@('%pv&')  
   i = winio@('%sc&',draw_func)        
   i = winio@('%mi[icon_1]&')    
   i = winio@('%gr[black,metafile_resize,rgb_colours]&',200,200)
   i = winio@('%mn[&File[E&xit]]&','EXIT')      
   i = winio@('%mn[&Resize]&',resize_func)
   i = winio@('%mn[&Help[About]]&',about_box_cb) 
   i = winio@('%lw%hw',ctrl,hwnd)
end program resize


resources

ICON_1 ICON salflogo.ico
