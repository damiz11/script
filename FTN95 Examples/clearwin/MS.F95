!****************************************************************************
!*                                                                          *
!* Salford ClearWin+ Example Code                                           *
!*                                                                          *
!* ms.f95 - version 1.0 30/6/99                                             *
!*                                                                          *
!* Example of ClearWin+ Multiple Selection Box                              *
!*                                                                          *
!* only compile using FTN95 version 1.6  or higher                          *
!*                                                                          *
!****************************************************************************
!*                                                                          *
!* A simple "drinks machine"                                                *
!*                                                                          *
!* This program illustrates the use of the %m.nms list box                  *
!* format code, bubble help attached to buttons and array assignment        *
!*                                                                          *
!****************************************************************************

winapp 

program multi
   use mswin
   implicit none
   integer ::  res, counter, drink, switch
   integer ,dimension (10) :: selected
   character (len=30) :: hlp
   character(len=*), dimension(10), parameter::drinks=(/&   
       &'Assam Tea             ','Jamaican Blue Mountain',&
       &'Lemonade              ','Hot chocolate         ',&
       &'Earl Grey Tea         ','Fresh orange juice    ',&
       &'Pink grapefruit juice ','Mocca                 ',&
       &'Chilled milk          ','Water                 '/)
!****************************************************************************
!* some of options are set to 1 to indicate that they have                  *
!* already been selected by default.                                        *
!****************************************************************************
   selected=0
   selected(1:5:2) = 1
   hlp = 'Finished selecting drinks'
   switch = 1
   res = winio@('%ca[Select your poison]&')
   res = winio@('%bg[inactiveborder]&')
   res = winio@('%`bg[white]%30.5ms&', drinks, intl(10), selected)
   res = winio@('%ff%2nl%cn&')
   res=winio@('%8?bt[&Done]@%`bh', hlp, switch)
!****************************************************************************
!* Count the number of drinks selected.                                     *
!****************************************************************************
   drink = 0
   do counter = 1, 10
      if (selected(counter) /= 0) then
         drink = drink + 1
      end if
   end do
!****************************************************************************
!* Display the window and terminate when OK is pressed.                     *
!****************************************************************************
   res = winio@('%ca[Your selection]&')
   res = winio@('%bg[inactiveborder]&')
   if (drink == 0) then
      res = winio@('No drinks were selected%2nl&')
   else
   do counter = 1, 10
      if (selected(counter) /= 0) then
         res = winio@('%ws%ff&', drinks(counter))
      end if
   end do
   endif
   res = winio@('%2nl%cn%8bt[&Ok]')
end program multi
