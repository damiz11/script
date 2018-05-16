WINAPP 'resource.rc'
PROGRAM dialog
IMPLICIT NONE
INCLUDE <windows.ins>
INCLUDE 'resource.inc'
INTEGER wr,c(6),cb
EXTERNAL cb
 c=0;c(4)=1
 wr=winio@('%di&', IDD_DIALOG1)
 wr=winio@('%`rb&',IDC_CHECK1,c(1))
 wr=winio@('%`rb&',IDC_CHECK2,c(2))
 wr=winio@('%`rb&',IDC_CHECK3,c(3))
 wr=winio@('%?rb[Select Radio 1]&', IDC_RADIO1,c(4))
 wr=winio@('%?rb[Select Radio 2]&', IDC_RADIO2,c(5))
 wr=winio@('%?rb[Select Radio 3]&', IDC_RADIO3,c(6))
 wr=winio@('%^bt',IDOK,cb)
END

INTEGER FUNCTION cb()
INCLUDE 'resource.inc'
INTEGER wr,winio@
 wr=winio@('%di',IDD_DIALOG2)
 cb=1
END
