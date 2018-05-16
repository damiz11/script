MODULE Form1
  USE VC
  TYPE(VCdialog) dlg1
  INTEGER number
CONTAINS

INTEGER FUNCTION Factorise()
  CHARACTER(LEN=50) str,val
  INTEGER n,k
  WRITE(val,'(i11)') number
  CALL trim@(val)
  str="The factors of "//val(1:LEN_TRIM(val))//" are: 1"
  n=number
  DO WHILE(n > 1)
    DO k=2,n
      IF((n/k)*k == n)THEN
        WRITE(val,'(i11)')k
        CALL trim@(val)
        CALL append_string@(str,', '//val)
        n=n/k
        IF(n > 1) EXIT
      ENDIF
    END DO
  END DO
  CALL vcSetText@(dlg1,"textBox1",str)
  Factorise=0
END FUNCTION Factorise

INTEGER FUNCTION About()
  CALL vcShowMessageBox@("Resources2.Form2")
  About=0
END FUNCTION About

END MODULE Form1

PROGRAM Main
USE Form1
number=1
dlg1=vcCreateDialog@("Resources2.Form1")
CALL vcLinkInteger@(dlg1,"int32_Box1",number)
CALL vcOnClick@(dlg1,"button1",Factorise)
CALL vcOnClick@(dlg1,"menuItem4",About)
CALL vcDisplayDialog@(dlg1) 
END
