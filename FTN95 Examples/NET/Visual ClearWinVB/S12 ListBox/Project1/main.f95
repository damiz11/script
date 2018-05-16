MODULE Form1
  USE VC
  TYPE(VCdialog) dlg1
  INTEGER index,count
CONTAINS

INTEGER FUNCTION DoInsert()
STRING str
INTEGER i
str=vcGetText@(dlg1,"textBox1")
CALL vcFocus@(dlg1,"textBox1")
DoInsert=0
IF(LEN(str) == 0) RETURN
i=vcInsert@(dlg1,"list_Box1",str,index,0)
CALL vcSetInteger@(dlg1,"int32_Box1",i)
count=count+1
CALL vcSetRange@(dlg1,"decimal_UpDown1",-1,count-1)
CALL vcClear@(dlg1,"textBox1")
END FUNCTION DoInsert

INTEGER FUNCTION DoRemove()
CALL vcFocus@(dlg1,"textBox1")
DoRemove=0
IF(count==0 .OR. index==count .OR. index==-1) RETURN
CALL vcRemove@(dlg1,"list_Box1",index)
count=count-1
CALL vcSetRange@(dlg1,"decimal_UpDown1",-1,count-1)
CALL vcSetEnabled@(dlg1,"button1",.FALSE.)
END FUNCTION DoRemove

INTEGER FUNCTION OnSelect()
IF(index<0) THEN
  CALL vcSetEnabled@(dlg1,"button1",.FALSE.)
ELSE
  CALL vcSetEnabled@(dlg1,"button1",.TRUE.)
ENDIF
OnSelect=0
END FUNCTION OnSelect

END MODULE Form1

PROGRAM Main
USE Form1
count=0
index=-1
dlg1=vcCreateDialog@("Resources1.Form1")
CALL vcLinkInteger@(dlg1,"decimal_UpDown1",index)
CALL vcLinkInteger@(dlg1,"list_Box1",index)
CALL vcOnClick@(dlg1,"button2",DoInsert)
CALL vcOnClick@(dlg1,"button1",DoRemove)
CALL vcOnEvent@(dlg1,"list_Box1","SelectedIndexChanged",OnSelect)
CALL vcDisplayDialog@(dlg1) 
END
