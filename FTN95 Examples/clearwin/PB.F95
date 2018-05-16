!***************************************************************************
!                                                                          *
! Salford ClearWin+ Example Code                                           *
!                                                                          *
! pb.f95 - version 1.0 30/6/99                                             *
!                                                                          *
! Example of ClearWin+ Parameter Boxes                                     *
!                                                                          *
! only compile using FTN95 version 1.6  or higher                          *
!                                                                          *
!***************************************************************************
!                                                                          *
! Program to illustrate how to use the %pb (Parameter Box) format code.    *
!                                                                          *
!                                                                          *
!***************************************************************************


winapp

program parabox
   use mswin
   use salf_about
   implicit none
   external action,no_action 
   integer, parameter :: rkind=selected_real_kind(15,307)
   integer :: ans,texture_type
   integer K1,K2,K5,K4
   real (kind=rkind) :: V,P,A   
   character (len=20):: name
   character (len=1):: st1
   character (len=20):: st
!******************************************************************************
!                                                                             *
! when using the array constructor all the elements must be of the same sizes *
!                                                                             *
!******************************************************************************
   character(len=*), dimension(6), parameter::textures=(/&
             &'Sticky       ','Messy        ',&
             &'Dirty        ','Greasy       ',&
             &'Slimy        ','Very slippery'/)    
   K1=1;K2=2;K4=4;K5=5;V=4.5
   texture_type=4;A=35.4;P=120.6
   name='Thick and Sticky'           
   ans=winio@('%mi[icon_1]&')                      
   ans=winio@('Double click on the parameter you wish to change:%2nl&')
   ans=winio@('%bg[inactiveborder]&')
   ans=winio@('%ca[Parameter setting]&')
   ans=winio@('%mn[&Exit]&','exit')
   ans=winio@('%mn[&Help[About]]&',about_box_cb)
   ans=winio@('%`bg[white]&')
   ans=winio@('%30.8pb[sorted]&')
   ans=winio@('%dp[test1]&',k1)
   ans=winio@('%dp[test2]&',k2)
   ans=winio@('%ep[Oil texture]&',textures,6,texture_type)
   ans=winio@('%dp[Temperature (Deg C)]&',k4)
   ans=winio@('%dp[Carbon monoxide (%)]&',k5)
   ans=winio@('%fp[Curent (Amps)test6]&',a)
   ans=winio@('%10.3fp[Voltage]&',v)
   ans=winio@('%fp[Oil pressure (PSI)]&',p)
   ans=winio@('%?tp[Oil name][What is the official name of this oil?]&',name)
   ans=winio@('%up[Special action]&',action)
   write(st1,'(I1)') 2
   st='default value='//st1
   ans=winio@('%up@&',st,no_action)
   ans=winio@(' ')
end program parabox


integer function action() 
   use mswin                                   
   implicit none 
   integer ans
   ans=winio@('No special action available yet&')
   ans=winio@('%2nl%cn%bt[Continue]')
   action=1
end function action

integer function no_action()
   no_action=2
end function no_action

resources

ICON_1 ICON salflogo.ico


