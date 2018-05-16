
!***************************************************************************
!*                                                                         *
!*    callback for about box                                               *
!*                                                                         *
!***************************************************************************                        
                            
module salf_about   
contains 
integer function about_box_cb()   
   integer i
   i=winio@('%ca[About ClearWin+]&')
   i=winio@('%fn[MS Sans Serif]&')      
   i=winio@('%es&')
   i=winio@('%ts&',0.8D0)
   i=winio@('%bg[BTNFACE]&')
   i=winio@('%ic[icon_1] Salford ClearWin+ &')
   i=winio@('%nlSalford ClearWin+ is a concise &')
   i=winio@('programming technique for Windows GUI &')
   i=winio@('development. %nl&')
   i=winio@('Create menus, buttons, list boxes, bitmap &')
   i=winio@('images, edit boxes, draw boxes etc. %nl&')
   i=winio@('each in no more than a &')
   i=winio@('couple of lines of program code.&')
   i=winio@('%ff%nl&')
   i=winio@('For more information contact:%2nl&')
   i=winio@('%taSalford Software Ltd.%nl&')
   i=winio@('%taTel: +44 (0) 161 834 2454%nl&')
   i=winio@('%taFax: +44 (0) 161 834 2148%nl&')
   i=winio@('%taEmail: sales@salford-software.com%nl&')
   i=winio@('%taWWW: http://www.salford.co.uk/%nl&')
   i=winio@('%ff%2nl&')
   i=winio@('%cn%10tt[OK]')
   about_box_cb = 1   
end function about_box_cb         

end module salf_about


