!****************************************************************************
!*                                                                          *
!* Salford ClearWin+ Example Code                                           *
!*                                                                          *
!* rb.f95 - version 1.0 1/7/99                                              *
!*                                                                          *
!* Example of ClearWin+ Radio Buttons                                       *
!*                                                                          *
!* only compile using FTN95 version 1.6  or higher                          *
!*                                                                          *
!****************************************************************************

module rb_common
   implicit none 
   integer :: grey_1, grey_2   
contains
!****************************************************************************
!*                                                                          *
!* call-back function to toggle grey states                                 *
!*                                                                          *
!****************************************************************************
   integer function toggle() 
      implicit none
      grey_1=iand( (grey_1+1),1)
      grey_2=iand( (grey_2+1),1)
      toggle=2
   end function toggle
end rb_common



winapp          
   program radio
   use mswin           
   use rb_common
   integer :: i
   integer :: rb1, rb2, rb3, rb4    
   rb1=1; rb2=1; rb3=0; rb4=0  
   grey_1=0;grey_2=1   
   i=winio@('%ca[Grey-Out Example]&')
   i=winio@('%bg[inactiveborder]&')
   i=winio@('%ob[raised]&')
   i=winio@('%~rb[Radio Button 1]%ff%nl&',rb1,grey_1)
   i=winio@('%~rb[Radio Button 2]%ff%nl&',rb2,grey_2)
   i=winio@('%~rb[Radio Button 3]%ff%nl&',rb3,grey_1)
   i=winio@('%~rb[Radio Button 4]%cb&',rb4,grey_2)
   i=winio@('%ob[depressed]%nl&')
   i=winio@('%10~bt[Alpha] %ff%nl&',grey_1)
   i=winio@('%10~bt[Omega] %nl%cb&',grey_2)
   i=winio@('%ff%nl%cn%^tt[Toggle Greying]%ff',toggle)
end program radio