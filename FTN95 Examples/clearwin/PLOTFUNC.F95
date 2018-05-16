!****************************************************************************
!* Salford ClearWin+ Example Code                                           *
!*                                                                          *
!* plotfunc.f95 - version 1.0  29/6/99                                      *
!*                                                                          *
!* only compile using FTN95 version 1.6 or higher                           *
!*                                                                          *
!* Example of ClearWin+ graphics using the %pl format code                  *
!*                                                                          *
!****************************************************************************


winapp     
!
!      *******************************************
!      *                                         *
!      *     Module of shared data for plot      *
!      *                                         *
!      *******************************************

module data_to_plot
   use mswin                
   parameter(narr=1000)
   integer, parameter :: rkind=selected_real_kind(15,307)
   integer :: param_window 
   real (kind=rkind):: p1,p2,p3
   real (kind=rkind):: yarr1(narr)
   
   contains
   
!
!      ***********************************************
!      *                                             *
!      *     Routine to prepare plot data            *
!      *                                             *
!      ***********************************************
!

   subroutine prepare_data
   integer :: i,xx
   xx=0
     do i=1,narr
        yarr1(i)=p1*sin(xx/p3)*exp(-xx/p2)
        xx=xx+1
     enddo
   end subroutine prepare_data 
!
!      ***********************************************
!      *                                             *
!      *     Function to respond to PLOT button      *
!      *                                             *
!      ***********************************************
!        
   integer function re_plot()
      call prepare_data       
      call simpleplot_redraw@
      re_plot=2
   end function re_plot 
!
!      **********************************************
!      *                                            *
!      *     Function to display parameter box      *
!      *                                            *
!      **********************************************
!
   integer function set_params()
      implicit none
      integer :: i
!      Make sure we do not display the parameters window more than once      
      if(param_window < 0)return;
      i=winio@('%ca[Plot parameters]&')
      i=winio@('%ww[topmost]&')
      i=winio@('%sy[3d]%sf&')
      i=winio@('%eq[Y=P{sub 1}Sin(X/P{sub 3}) e{sup -X/P{sub 2}}]%ff%nl&',300,50)
      i=winio@('%ob[scored]&')
         i=winio@('P%sd1%`sd%fl%10rf%2nl&',0.01d0,1.0d10,p1)
         i=winio@('P%sd2%`sd%fl%10rf%2nl&',0.01d0,1.0d10,p2)
         i=winio@('P%sd3%`sd%fl%10rf&',0.01d0,1.0d10,p3)
      i=winio@('%cb&')
      i=winio@('%rj%^5bt[Plot]%2nl%rj%5bt[Close]&',re_plot)
      i=winio@('%lw',param_window)
      set_params=2
   end function set_params
end module data_to_plot

!
!      **********************************************************
!      *                                                        *
!      *     Main program - display window containing plot      *
!      *                                                        *
!      **********************************************************
!                          
program simpleplot_example 
use salf_about
   use data_to_plot
   use mswin
   implicit none
   integer :: i
   p1=1.5;p2=150.0;p3=15
   param_window=0
   call prepare_data
   i=winio@('%ca[SimplePlot example program]&')
   i=winio@('%mi[icon_1]&')    
   i=winio@('%ww[no_border]&')
   i=winio@('%mn[&File[E&xit],&Options[Set &Parameters]]&','EXIT',set_params)
   i=winio@('%mn[&Help[About]]&',about_box_cb) 
   i=winio@('%pl[x_axis="Time(Miliseconds)",y_axis=Amplitude,'&      
        //'title="Sample plot",colour=red]&',&
         400,300,narr,0.0d0,1.0d0,yarr1)
   i=winio@('%pv')
end      
      
      
resources

icon_1 icon salflogo.ico
