!****************************************************************************
!*                                                                          *
!* Salford ClearWin+ Example Code                                           *
!*                                                                          *
!* dragdrop.f95 - version 1.0 30/6/99                                                            *
!*                                                                          *
!* Dragging and Dropping Files Example                                      *
!*                                                                          *
!* only compile using FTN95 version 1.6  or higher                          *
!*                                                                          *
!****************************************************************************
!*                                                                          *
!* Lists the filenames of files 'dragged' and 'dropped' onto the window.    *
!*                                                                          *
!****************************************************************************


!****************************************************************************
!*                                                                          *
!*                    Main Program                                          *
!*                                                                          *
!****************************************************************************
winapp 
program dragdrop
   use mswin
   external drop
   integer :: i
   i=winio@('%bg[BTNFACE]&')
   i=winio@('%mn[E&xit]&','EXIT')
   i=winio@('%dr&',drop)
   i=winio@('%sy[3d,thin_border]&')
   i=winio@('%ca[Drag and Drop Example]%fn[Arial]&')
   i=winio@('%tc[blue]%ts&',1.5d0)
   i=winio@('Using the Explorer/File Manager drop single%ff&')
   i=winio@('or groups of icons onto this window.%ff&')
   i=winio@('%tc[red]%ts&',1.25d0)
   i=winio@('%ff&')
   i=winio@('[File Number]         [Number of files]         [Filename]&')
   i=winio@('%ff&')
   i=winio@('%sf%`bg[WINDOW]%50.8cw[vscroll,hscroll]',0L)  
end program dragdrop
                                
                               
!****************************************************************************
!*                                                                          *
!*  call back function to process a dropped file name                       *
!*                                                                          *
!****************************************************************************
integer function drop()
   use mswin
   integer :: curr, count
   character (len=128) :: dropfile  
   curr=clearwin_info@('DROPPED_CURRENT')
   count=clearwin_info@('DROPPED_COUNT')
   dropfile=clearwin_string@('DROPPED_FILE')
   print *,'[',curr,']','  [',count,']  ',dropfile
   drop=2
end function drop

