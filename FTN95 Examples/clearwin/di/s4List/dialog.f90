WINAPP 'resource.rc'
PROGRAM dialog
IMPLICIT NONE
INCLUDE <windows.ins>
INCLUDE 'resource.inc'
INTEGER wr,s
INTEGER,PARAMETER::N=4
CHARACTER(LEN=16)::items(N)
 s=0
 wr=winio@('%di&',IDD_DIALOG1)
 wr=winio@('%ls&',IDC_LIST1, items,N,s)
 wr=winio@('%`ls',IDC_COMBO1,items,N,s)
 IF(s>0)THEN
   wr=winio@('%di&',IDD_DIALOG2)
   wr=winio@('%bf%tc%ts&',RGB@(0,190,0),1.4D0)
   wr=winio@('%ws&',IDC_STATIC1,items(s))
   wr=winio@('%`ts%`bf')
 ENDIF  
END
