!****************************************************************************
!*                                                                          *
!* Salford ClearWin+ Example Code                                           *
!*                                                                          *
!* monitor.f95 - version 1.0 30/6/99                                        *
!*                                                                          *
!* Example of Detecting ClearWin+ Window Focus                              *
!*                                                                          *
!* only compile using FTN95 version 1.6  or higher                          *
!*                                                                          *
!****************************************************************************
!*                                                                          *
!* Focus monitor example showing how to detect window focus using           *
!* the clearwin+ function call :- clearwin_info@('FOCUSSED_WINDOW')         *
!*                                                                          *
!****************************************************************************

module findfocus_com    
   use mswin
   implicit none
   integer :: hwnd_focus           

contains
!************************************************************
!*                                                          *
!*      Focus monitor call back                             *
!*                                                          *
!************************************************************
   integer function focus_monitor_cb()
      hwnd_focus=clearwin_info@('FOCUSSED_WINDOW')
      call window_update@(hwnd_focus)
      focus_monitor_cb=2
   end function focus_monitor_cb
end module findfocus_com


winapp 
program focus
   use mswin      
   use findfocus_com
   implicit none  
   integer, parameter :: rkind=selected_real_kind(15,307)          
   integer :: i
   integer :: a,b,c,r1,r2
   real (kind=rkind):: f1
   character (len = 80) :: s1,s2,s3     
   s1='This is string 1';s2='This is string 2';s3='This is string 3'
   a=1;b=123;c=99999
   f1=53.2354;r1=1;r2=0
   call add_focus_monitor@(focus_monitor_cb)
   i=winio@('%ca[Focus Monitor Example]&')
   i=winio@('%sy[3d_thin,thin_border]&')
   i=winio@('%bg[btnface]&')
   i=winio@('%`bg[window]%rd%ta%rb[ Radio 1]%ff&',a,r1)
   i=winio@('%`bg[window]%rd%ta%rb[ Radio 2]%ff&',b,r2)
   i=winio@('%`bg[window]%rd%ff&',c)
   i=winio@('%`bg[window]%rf%ff%nl&',f1)
   i=winio@('%`bg[window]%30rs%ff&',s1)
   i=winio@('%`bg[window]%30rs%ff&',s2)
   i=winio@('%`bg[window]%30rs%ff&',s3)
   i=winio@('%nlthe object which has focus has a handle of&')
   i=winio@('%`bg[YELLOW]%`rd&',hwnd_focus)
   i=winio@('%ff%2nl%cn%`tt[&OK]')
end program focus



