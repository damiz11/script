!****************************************************************************
!*                                                                          *
!* Salford ClearWin+ Example Code                                           *
!*                                                                          *
!* makeicon.F95 - version 1.0 30/6/99                                       *
!*                                                                          *
!* Example of ClearWin+ make_icon Routine                                   *
!*                                                                          *
!* only compile using FTN95 version 1.6  or higher                          *
!*                                                                          *
!****************************************************************************
!*                                                                          *
!*  A program to create an icon by passing a character array describing     *
!*  the position and colour of the constituent pixels to the clearwin+      *
!*  routine 'make_icon@                                                     *
!*  this function returns a HICON handle to the icon which may be used      *
!*  elsewhere in the program                                                *
!*  n.b. the icon is destroyed at program termination                       *
!*                                                                          *
!****************************************************************************


winapp
   program makeicon
   use mswin
   implicit none
   integer :: hicon,k 
   character(len=*), dimension(32), parameter::icon=(/&   
      &'RRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRR',&
      &'RYYBBYYBBYYBBYYBBYYBBYYBBYYBBYYR',&
      &'RYYBBYYBBYYBBYYBBYYBBYYBBYYBBYYR',&
      &'RYYBBYYBBYYBBYYBBYYBBYYBBYYBBYYR',&
      &'RYYBBYYBBYYBBYYBBYYBBYYBBYYBBYYR',&
      &'RYYBBYYBBYYBBYYBBYYBBYYBBYYBBYYR',&
      &'RYYBBYYBBYYBBYYBBYYBBYYBBYYBBYYR',&
      &'RYYBBYYBBYYBBYYBBYYBBYYBBYYBBYYR',&    
      &'RYYBBYYBBGGGGYYBBGGGGYYBBYYBBYYR',&
      &'RYYBBYYBBGGGGYYBBGGGGYYBBYYBBYYR',&
      &'RYYBBYYBBGGGGYYBBGGGGYYBBYYBBYYR',&
      &'RYYBBYYBBGGGGYYBBGGGGYYBBYYBBYYR',&
      &'RYYBBYYBBYYBBYYBBYYBBYYBBYYBBYYR',&
      &'RYYBBYYBBYYBBYYBBYYBBYYBBYYBBYYR',&
      &'RYYBBYYBBYYBBYYBBYYBBYYBBYYBBYYR',&
      &'RYYBBYYBBYYBBYYBBYYBBYYBBYYBBYYR',&
      &'RYYBBYYBBYYBBGGGBYYBBYYBBYYBBYYR',&
      &'RYYBBYYBBYYBBGGGBYYBBYYBBYYBBYYR',&
      &'RYYBBYYBBYYBBGGGBYYBBYYBBYYBBYYR',&
      &'RYYBBYYBBYYBBYYBBYYBBYYBBYYBBYYR',&
      &'RYYBBYYBBYYBBYYBBYYBBYYBBYYBBYYR',&
      &'RYGGGYYBBYYBBYYBBYYBBYYBBGGGBYYR',&
      &'RYGGGYYBBYYBBYYBBYYBBYYBBGGGBYYR',&
      &'RYYBGGYBBYYBBYYBBYYBBYYBGGYBBYYR',&
      &'RYYBBGGGGGGGGGGGGGGGGGGGGYYBBYYR',&
      &'RYYBBYGGGGGGGGGGGGGGGGGBBYYBBYYR',&
      &'RYYBBYYBBYYBBRRRBYYBBYYBBYYBBYYR',&
      &'RYYBBYYBBYYBBRRRBYYBBYYBBYYBBYYR',&
      &'RYYBBYYBBYYBRRRRRYYBBYYBBYYBBYYR',&
      &'RYYBBYYBBYYBBRRRBYYBBYYBBYYBBYYR',&
      &'RYYBBYYBBYYBBYYBBYYBBYYBBYYBBYYR',&
      &'RRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRR'/)
   hicon=make_icon@(icon)
   k=winio@('%bg[btnface]&')
   k=winio@('%ca[Make icon Example]%`ic&',hicon)
   k=winio@('%ff%cn%10bt[&OK]')
end program makeicon
