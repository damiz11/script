!***************************************************************************
!                                                                          *
! Salford ClearWin+ Example Code                                           *
!                                                                          *
! CLPBRD.F95 - version 1.0  29/6/99                                        *
!                                                                          *
!                                                                          *
! Example of ClearWin+ Clipboard Functions                                 *   
!                                                                          *
!  only compile using FTN95 version 1.6 or higher                          *     
!                                                                          *
!***************************************************************************
!                                                                          *
! Demonstrates copying graphics to the windows clipboard                   *
! and also pasting graphics from the windows clipboard.                    *  
! This is done using a number of windows API calls                         *
!                                                                          *
!***************************************************************************
    
!
!      *****************************************************
!      *                                                   *
!      * load file module to enable callback functions to  *
!      * pass FILENAME between them                        *
!      *                                                   *
!      *****************************************************

module load_file
   use mswin
   implicit none 
   character(len=50) :: filename
   
contains
   
   integer function load_file_cb()
      use mswin
      integer :: hDib,res
      call clear_screen@()
      hDib = import_bmp@(filename,res)
         if(res == 0) res = dib_paint@(0,0,hDib,0,0)
      call release_screen_block@(hDib)
      load_file_cb = 1 
   end function load_file_cb      
end module load_file
!
!      *******************************************
!      *                                         *
!      *     Main Program                        *
!      *                                         *
!      *******************************************
winapp

program clip
   use mswin
   use load_file 
   use salf_about
   implicit none
   integer :: i 
   external disp_bmp,clear_screen_func
   external copy_to_clpbrd,copy_from_clpbrd 
   i=winio@('%sy[thin_border]&')                        
   i=winio@('%mi[icon_1]&')    
   i=winio@('%mn[&File[&New]]&',clear_screen_func)   
   i=winio@('%`ft@@&','Bitmaps','*.bmp')
   filename='*.bmp'
   i=winio@('%mn[[&Open]]&','File_Openr',filename,load_file_cb)
   i=winio@('%mn[[E&xit]]&','exit')
   i=winio@('%mn[&Edit[&Copy to Clipboard]]&',copy_to_clpbrd)
   i=winio@('%mn[[&Copy from Clipboard]]&',copy_from_clpbrd)   
   i=winio@('%mn[&Help[About]]&',about_box_cb) 
   i=winio@('%bg[BTNFACE]&')
   i=winio@('%gr[BLACK]&',640,480) 
   i=winio@('%ca[Clipboard Example]%2nl&')
   i=winio@('%sc&',disp_bmp)
   i=winio@('%ww')
end program clip
!
!      *******************************************
!      *                                         *
!      *     Function to Display a Bitmap        *
!      *                                         *
!      *******************************************

integer function disp_bmp()  
   use mswin
   integer hDib,res   
   hDib = import_bmp@('smith.bmp',res)
   if(res == 0) then 
       res = dib_paint@(0,0,hDib,0,0)      
   endif
   call release_screen_block@(hDib)
   disp_bmp=1
end function disp_bmp                    
!
!      ***********************************************
!      *                                             *
!      *     Function to copy the contents of the    * 
!      *     Graphics region to the Clipboard        *                        *
!      *                                             *
!      ***********************************************
integer function copy_to_clpbrd()
   use mswin
   integer :: res
   res =  graphics_to_clipboard@(0,0,639,479)
   if (res == 0) stop   
   copy_to_clpbrd=1
end function copy_to_clpbrd
!
!      ***********************************************
!      *                                             *
!      *     Function to copy the contents of the    *
!      *     Clipboard to the Graphics Region        *
!      *                                             *
!      ***********************************************
integer function copy_from_clpbrd()
   use mswin
   integer :: hDib
   integer :: res
   res = clipboard_to_screen_block@(hDib)
      if(res /= 0) res=dib_paint@(0,0,hDib,0,0)
   copy_from_clpbrd = 1
end function copy_from_clpbrd
!
!      ***********************************************
!      *                                             *
!      *     Function to clear the graphics region   *
!      *                                             *
!      ***********************************************
integer function clear_screen_func()
   call clear_screen@()
   clear_screen_func = 1
end function clear_screen_func 


resources

ICON_1 ICON salflogo.ico

