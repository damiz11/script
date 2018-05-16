!****************************************************************************
!*                                                                          *
!* Salford ClearWin+ Example Code                                           *
!*                                                                          *
!* winiog.f95 - version 1.0 1/7/99                                          *
!*                                                                          *
!* Example of ClearWin+ Colour Palette                                      *
!*                                                                          *
!* only compile using FTN95 version 1.6  or higher                          *
!*                                                                          *
!****************************************************************************
!*                                                                          *
!* Colour palette example which lets the user select a colour and           *
!* displays the corresponding RGB values                                    *
!*                                                                          *
!****************************************************************************

winapp 
program colour
   use mswin
   integer :: i,v
   v=0
!****************************************************************************
!*                                                                          *
!* Colour Selection                                                         *
!*                                                                          *
!***************************************************************************
   i=winio@('%bg[BTNFACE]&')
   i=winio@('%sy[thin_border]&')
   i=winio@('%ob[depressed]&')
   i=winio@('%ca[Colour Palette Example]&')
   i=winio@('%cl[]%ff%nl&',v)
   i=winio@('%rj%15bt[OK]  &')
   i=winio@('%cb')
!****************************************************************************
!*                                                                          *
!* Result of Colour Selection                                               *
!*                                                                          *
!****************************************************************************
   i=winio@('%bg[BTNFACE]&')
   i=winio@('%fn[ms sans serif]%ts&',1.5d0)
   i=winio@('%tc[BLUE]&')
   i=winio@('%ca[colour result] %nlThe colour value was &')
   i=winio@('RGB(%wd,%wd,%wd)%2nl ', and(v,255), and(rs(v,8),255),rs(v,16))
end program colour