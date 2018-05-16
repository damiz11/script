!****************************************************************************
!*                                                                          *
!* Salford ClearWin+ Example Code                                           *
!*                                                                          *
!* TREEVIEW.F95 - version 1.0 29/6/99                                       *                     *
!*                                                                          *
!* Example of ClearWin+ Treeview Controls                                   *
!*                                                                          *
!* only compile using FTN95 version 1.6  or higher                          *
!*                                                                          *
!****************************************************************************
!*                                                                          *
!* Tree-View example using grave accent to attach icons to the 'branches'   *
!* and the Carat to force a callback call when and item is selected         *
!*                                                                          *
!****************************************************************************

module tree_com   
   implicit none
   character (len = 30),dimension(10):: contents

   integer ::item,n_item
   character (len=10) :: szItem   
   
contains 

   subroutine update_str(k)   
      integer,intent (in) :: k
      if(contents(k)(2:2) == 'E')then
         contents(k)(3:3)='B'
      else               
         contents(k)(3:3)='A'
      endif
   end subroutine update_str 
   
!****************************************************************
!  Call-back function sets the icon for each object according   *
!  to whether it is expanded or not                             *
!****************************************************************
   integer function test()
      character (len = 5 )::  s
      integer i
! n.b. If there are a lot of items the updating should more selective.
      do i=1,n_item
         call update_str(i)
      enddo
      call window_update@(contents)
      write(s,'(I2)') item
      szItem='item:'//s
      call window_update@(szItem)
      test=2
   end function test
  
end module tree_com


!      *******************************************
!      *            Main Program                 *
!      *******************************************
winapp
program treev   
   use mswin
   use tree_com 
   use salf_about
   implicit none
   external test 
   integer ans
   contents=(/'AEBBook       ',&
          &'BCAChapter 1  ','CCASection 1.1',&
          &'CCASection 1.2','BCAChapter 2  ','CCASection 2.1','CCASection 2.2',&
          &'BCAChapter 3  ','CCASection 3.1','CCASection 3.2'/)  
   n_item = 10; item = 3
   szitem = 'item:3'
   ans=winio@('%mi[icon_1]&')    
   ans=winio@('%ca[Tree View]&')
   ans=winio@('%mn[E&xit]&','EXIT')  
   ans=winio@('%mn[&Help[About]]&',about_box_cb) 
   ans=winio@('%ww%ob&') 
   ans=winio@('%^`20.15tv&',contents,10,item,'closed_book,open_book',test)
   ans=winio@('%cb&')
   ans=winio@('%nl%ob[status,panelled]&')
   ans=winio@('%cn%7st%cb&',szItem)
   ans=winio@('%pv')
end program treev           

resources 
closed_book ICON book1.ico
open_book   ICON book2.ico
icon_1 ICON salflogo.ico

