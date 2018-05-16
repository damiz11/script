!****************************************************************************
!*                                                                          *
!* Salford ClearWin+ Example Code                                           *
!*                                                                          *
!* mico.f95 - version 1.0 26/6/99                                           *
!*                                                                          *
!* only compile using FTN95 version 1.6 or higher                           *
!*                                                                          *
!* Example of Moving Icons with ClearWin+                                   *
!*                                                                          *
!****************************************************************************

 
module mico_com                 
   use mswin
   implicit none
   integer :: x_arrow_r,ICON_HOT_X,y_arrow_r,x_org,x_end,y_org
   
contains
!
!   ***************************************************************
!   *                                                             *
!   *  function start call sets up the arrow and scale positions  * 
!   *                                                             *
!   *************************************************************** 
   integer function start_call()
      integer :: i,id_arrow_r
      id_arrow_r = ADD_GRAPHICS_ICON@('arrow_r',x_arrow_r,y_arrow_r,9,26)                                          
      if (id_arrow_r == 0) stop
      call draw_line@(50,100,251,100,RGB@(0,128,0))
      do i=50,249,5
         call draw_line@(i,95,i,100,RGB@(255,128,0))
      enddo
      do i=50,259,50
         call draw_line@(i,90,i,100,RGB@(0,128,0))
      enddo
      start_call=2
   end function start_call
!
!   ***************************************************************
!   *                                                             *
!   *  function gr_callback controls the position of the icon     * 
!   *                                                             *
!   ***************************************************************    
   integer function gr_callback()
      implicit none
      y_arrow_r=y_org
      if(x_arrow_r.lt.x_org) x_arrow_r=x_org-ICON_HOT_X
      if(x_arrow_r.gt.x_end) x_arrow_r=x_end-ICON_HOT_X
      gr_callback = 2
   end function gr_callback     
end module mico_com


winapp 
program moving_icon   

   use mswin
   use mico_com
   use salf_about
   implicit none
   integer :: width,height,I
   external about_box_cb
   ICON_HOT_X=5
   width=300
   height=200
   x_arrow_r=50-ICON_HOT_X;y_arrow_r=100;x_org=50;x_end=250;y_org=100
   i=winio@('%sc%ca[Moving Icon Example]&',start_call)
   i=winio@('%mi[icon_1]&')
   i=winio@('%bg[inactiveborder]&')
   i=winio@('%ob[raised]&')
   i=winio@('%mn[&Exit]&','exit')
   i=winio@('%mn[&Help[About]]&',about_box_cb)    
   i=winio@('%`cu&',IDC_ARROW)
   i=winio@('%^`gr[rgb_colours]&',width,height,1,gr_callback)
   i=winio@('%cb')
end program moving_icon


resources

arrow_r   ICON  Arrow_r.ico
ICON_1 ICON     Salflogo.ico
