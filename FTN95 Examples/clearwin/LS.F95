!****************************************************************************
!*                                                                          *
!* Salford ClearWin+ Example Code                                           *
!*                                                                          *
!* ls.f95                                                                   *
!*                                                                          *
!* Example of ClearWin+ List Boxes                                          *
!*                                                                          *
!* only compile using FTN95 version 1.6  or higher                          *
!*                                                                          *
!****************************************************************************
!* this program displays a number of list boxes in a number of styles:      *
!*                    'lb%     - Simple listbox                             *
!*                    'ls%     - Drop down listbox                          *
!*                    ^n.m%ls  - Scrolling listbox                          *
!*                    ^%ms     - Multiple selection box                     *
!****************************************************************************

module common_mod
   implicit none
   integer :: k
   integer, dimension(7):: ms_selects
   character (len=*),dimension(7), parameter ::string=(/'Apples    ',&
               &'Bananas   ','Cherries  ','Grapes    ','Oranges   ',&
               &'Pears     ','Rasberries'/) 
   
contains

!****************************************************************************
!*                                                                          *
!* Callback for List Boxes                                                  *
!*                                                                          *
!****************************************************************************
   integer function lbox_cb()
      implicit none
      integer :: l
      do l=1,6 
         print *,CHAR(13)
      end do
      print *,' fruit=',string(k)
      lbox_cb=2
   end function lbox_cb
   
!****************************************************************************
!*                                                                          *
!* Callback for Multiple selection box                                      *
!*                                                                          *
!****************************************************************************

   integer function mselbox_cb() 
      implicit none
      integer :: l
      do l=1, 6
          print *,CHAR(13)        
      end do
      do l=1, 7
         if (ms_selects(l) == 1) then
            print *,l,' [Selected] ',string(l)
         else
            print *,l,' [        ] ',string(l)
         endif
      end do
      mselbox_cb=2
   end function mselbox_cb
end module common_mod



winapp 

program listbox
   use mswin
   use common_mod 
   use salf_about
   implicit none
   external about_box_cb
   integer :: i      
   ms_selects = 0
   i=winio@('%ca[Selection using %lb , %ls and %ms]&')
   i=winio@('%fn[ms sans serif]%ts&',0.8D0)
   i=winio@('%sy[3d_raised]&')
   i=winio@('%mi[icon_1]&') 
   i=winio@('%4.1ob&')
   i=winio@('%mn[&Exit]&','exit')      
   i=winio@('%mn[&Help[About]]&',about_box_cb) 
   i=winio@('Simple%ff%`bg[window]%^lb%nd%cb&',string,7,k,lbox_cb)
   i=winio@('Drop-down%ff%`bg[window]%^`ls%cb&',string,7,k,lbox_cb)
   i=winio@('Scrolling%ff%`bg[window]%^10.3ls%cb&',string,7,k,lbox_cb)
   i=winio@('Multiple selection%ff%`bg[window]%^ms%cb&',string,7,ms_selects,mselbox_cb)
   i=winio@('%ff%nl%`bg[window]%40.7cw%ff&',0)
   i=winio@('%sfNote that the first three boxes are linked together because they share the result variable K')
end program listbox

      
resources

icon_1 ICON salflogo.ico


