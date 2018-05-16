WINAPP 'resource.rc'
PROGRAM dialog
IMPLICIT NONE
INCLUDE <windows.ins>
INCLUDE 'resource.inc'
 INTEGER sheet(2),wr
 CHARACTER notes*120,name*20,telephone*20
 notes=' '; name=' '; telephone=' '
! Sheet 1..... 
 wr=winio@('%sh&',sheet(1))
 wr=winio@('%ca[Telephone]&')
 wr=winio@('%di&',IDD_DIALOG3)
 wr=winio@('%rs&',IDC_EDIT1,name)
 wr=winio@('%rs', IDC_EDIT2,telephone)
! Sheet 2..... 
 wr=winio@('%sh&',sheet(2))
 wr=winio@('%ca[Notes]&')
 wr=winio@('%di&',IDD_DIALOG2)
 wr=winio@('%re', IDC_EDIT1,notes)
! The dialog...... 
 wr=winio@('%di&',IDD_DIALOG1)
 wr=winio@('%2ps',IDC_TAB1,sheet(1),sheet(2))
END

