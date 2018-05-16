WINAPP 'resource.rc'
PROGRAM dialog
IMPLICIT NONE
INCLUDE <windows.ins>
INCLUDE 'resource.inc'
 INTEGER,PARAMETER::N=4,M=4
 INTEGER  wr,s1(N-1),s2,start_cb,save_cb
 EXTERNAL start_cb,save_cb
 CHARACTER*16 items1(N),items2(M)
 s1=0
 wr=winio@('%di&',IDD_DIALOG1)
 wr=winio@('%?ib[flat][Toolbar item]&',IDC_STATIC1,'explore',4,save_cb)
 wr=winio@('%?lv[][List view]&',IDC_LIST1,items1,N,s1,1)
 wr=winio@('%?bv[][Tree view]&',IDC_TREE1,items2,M,s2)
 wr=winio@('%?gr[green,rgb_colours][Graphics region]&',IDC_STATIC2)
 wr=winio@('%?bt[OK button]&',IDOK)
 wr=winio@('%sc',start_cb)
END

INTEGER FUNCTION start_cb()
INCLUDE <windows.ins>
INTEGER w,h
 w=clearwin_info@('GRAPHICS_WIDTH')
 h=clearwin_info@('GRAPHICS_DEPTH')
 CALL draw_filled_ellipse@(w/2,h/2,w/3,h/4,255)
 start_cb=1
END

INTEGER FUNCTION save_cb()
INTEGER wr,winio@
 wr=winio@('%ca[Message]%bg[grey]Toolbar item.')
 save_cb=1
END