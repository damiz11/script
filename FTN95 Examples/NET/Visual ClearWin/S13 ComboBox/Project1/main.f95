MODULE Form1
  USE VC
  TYPE(VCdialog) dlg1
  INTEGER index
CONTAINS

INTEGER FUNCTION OnInsert()
STRING str
str=vcGetText@(dlg1,"combo_Box1")
CALL vcFocus@(dlg1,"combo_Box1")
OnInsert=0
IF(LEN(str)==0) RETURN
index=vcInsert@(dlg1,"combo_Box1",str,0,0)
CALL vcRemove@(dlg1,"combo_Box1",4)
END FUNCTION OnInsert

END MODULE Form1

PROGRAM Main
USE Form1
index = -1
dlg1=vcCreateDialog@("Resources.Form1")
CALL vcLinkInteger@(dlg1,"int32_Box1",index)
CALL vcLinkInteger@(dlg1,"combo_Box1",index)
CALL vcOnClick@(dlg1,"button1",OnInsert)
CALL vcDisplayDialog@(dlg1) 
END

!button1 is located below the bottom edge of the form.
!The AcceptButton property of the form is linked to button1.
!As a result pressing Enter calls OnInsert.
