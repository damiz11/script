WINAPP 'resource.rc'
PROGRAM dialog
IMPLICIT NONE
INCLUDE <windows.ins>
INCLUDE 'resource.inc'
INTEGER wr,n
INTEGER,PARAMETER::D=SELECTED_REAL_KIND(10)
REAL(D)::x
CHARACTER(LEN=500)::text
 n=0;x=0.0;
 text='Type something here...'
 wr=winio@('%di&',IDD_DIALOG1)
 wr=winio@('%dd&',1)
 wr=winio@('%il&',0,10)
 wr=winio@('%rd&',IDC_EDIT1,n)
 wr=winio@('%rf&',IDC_EDIT2,x)
 wr=winio@('%re', IDC_EDIT3,text)
END
