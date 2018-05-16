!****************************************************************************
!*                                                                          *
!* Salford ClearWin+ Example Code                                           *
!*                                                                          *
!* garb.f95                                                                 *
!*                                                                          *
!* Example of ClearWin+ Ganged Radio Buttons                                *
!*                                                                          *
!* only compile using FTN95 version 1.6  or higher                          *
!*                                                                          *
!****************************************************************************
!*                                                                          *
!* Shows how to gang %rb controls together using the modified gang %ga      *
!*                                                                          *
!* One variable must be used to connect all the ganged items together which *
!* is itself a variable connected to a radio button.                        *
!*                                                                          *
!****************************************************************************

winapp 
   use mswin
   implicit none
   integer :: i,j,rb1(10),rb2(10)
   character (len=4) :: st          
   i=winio@('%`ca[Ganged %RB]&')
   i=winio@('%sy[3d]&')
   i=winio@('%bg[BTNFACE]&')      
   
   rb1(1)=1
   do j=1,10
      if(j /= 1) rb1(j)=0
      rb2(j)=0        
      write(st,'(A,I2)') 'b',j
      i=winio@('%rb@&',st,rb1(j))
      write(st,'(A,I2)') 'b',j+10
!* the grave accent (`) is used with %rb to show the second 
!* series of radio buttons as checkboxes 
      i=winio@('%ta%`rb@&',st,rb2(j))          
      if(j == 1) then 
         i=winio@('%2`ga&',rb1(j),rb2(j))
      else
!* rb1(1) is used as the common variable                                   
         i=winio@('%3`ga&',rb1(1),rb1(j),rb2(j))
      endif 
      i=winio@('%ff&')
   enddo
   i=winio@('%nl%cn%tt[Close] ')
end