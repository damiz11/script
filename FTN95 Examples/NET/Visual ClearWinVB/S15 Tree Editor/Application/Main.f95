MODULE Form1
  USE VC
  TYPE(VCdialog) dlg1
  INTEGER next
CONTAINS

INTEGER FUNCTION Changed()
CALL vcSetIntegerData@(dlg1,"#Modified",1)
Changed=0
END FUNCTION Changed

INTEGER FUNCTION AddNode()
CHARACTER(LEN=16) c
STRING s
c=vcGetStringData@(dlg1,"#Sender")
IF(TRIM(c) == "toolBarButton1") CALL vcSelectParentNode@(dlg1,"tree_View1")
next=next+1
WRITE(c,"(a,i2)") "Node",next
s=TRIM(c)
CALL vcAppendNode@(dlg1,"tree_View1",s)
AddNode=Changed()
END FUNCTION AddNode

INTEGER FUNCTION InsertNode()
CHARACTER(LEN=16) c
STRING s
next=next+1
WRITE(c,"(a,i2)") "Node",next
s=TRIM(c)
CALL vcInsertNode@(dlg1,"tree_View1",s)
InsertNode=Changed()
END FUNCTION InsertNode

INTEGER FUNCTION DeleteNode()
CALL vcRemoveNode@(dlg1,"tree_View1")
IF(LEN(vcGetNodeFullPath@(dlg1,"tree_View1")) == 0)THEN
  CALL vcSetText@(dlg1,"text_Box1","")
  CALL vcSetInteger@(dlg1,"decimal_UpDown1",0)
  CALL vcSetInteger@(dlg1,"decimal_UpDown2",0)
  CALL vcSetEnabled@(dlg1,"text_Box1",.FALSE.)
  CALL vcSetEnabled@(dlg1,"decimal_UpDown1",.FALSE.)
  CALL vcSetEnabled@(dlg1,"decimal_UpDown2",.FALSE.)
ENDIF
DeleteNode=Changed()
END FUNCTION DeleteNode

INTEGER FUNCTION AfterEdit()
IF(LEN(vcGetStringData@(dlg1,"#Label")) == 0)THEN
  AfterEdit=1
ELSE
  AfterEdit=Changed()
ENDIF
END FUNCTION AfterEdit

INTEGER FUNCTION BeforeSelect()
STRING s
s=vcGetText@(dlg1,"text_Box1")
CALL vcSetNodeData@(dlg1,"tree_View1",s)
BeforeSelect=0
END FUNCTION BeforeSelect

INTEGER FUNCTION AfterSelect()
STRING s
INTEGER image,selectedImage
s=vcGetNodeData@(dlg1,"tree_View1")
CALL vcSetText@(dlg1,"text_Box1",s)
CALL vcGetNodeImageIndex@(dlg1,"tree_View1",image,selectedImage)
CALL vcSetInteger@(dlg1,"decimal_UpDown1",image)
CALL vcSetInteger@(dlg1,"decimal_UpDown2",selectedImage)
CALL vcSetEnabled@(dlg1,"text_Box1",.TRUE.)
CALL vcSetEnabled@(dlg1,"decimal_UpDown1",.TRUE.)
CALL vcSetEnabled@(dlg1,"decimal_UpDown2",.TRUE.)
AfterSelect=Changed()
END FUNCTION AfterSelect

INTEGER FUNCTION OnCreate()
CALL vcClear@(dlg1,"tree_View1")
CALL vcSetText@(dlg1,"text_Box1","")
OnCreate=0
END FUNCTION OnCreate

INTEGER FUNCTION OnOpen()
CALL vcLoadTree@(dlg1,"tree_View1")
OnOpen=AfterSelect()
CALL vcSetIntegerData@(dlg1,"#Modified",0)
END FUNCTION OnOpen

INTEGER FUNCTION OnSave()
CALL vcSaveTree@(dlg1,"tree_View1")
OnSave=0
END FUNCTION OnSave

INTEGER FUNCTION ValueChanged()
INTEGER image,selectedImage
image=vcGetInteger@(dlg1,"decimal_UpDown1")
selectedImage=vcGetInteger@(dlg1,"decimal_UpDown2")
CALL vcSetNodeImageIndex@(dlg1,"tree_View1",image,selectedImage)
ValueChanged=0
END FUNCTION ValueChanged

INTEGER FUNCTION BeforeCollapse()
BeforeCollapse=1-vcGetIntegerData@(dlg1,"#NodeIsSelected")
END FUNCTION BeforeCollapse

END MODULE Form1

PROGRAM Main
USE Form1
next = 0
dlg1=vcCreateDialog@("Resources1.Form1")
CALL vcOnClick@(dlg1,"toolBarButton1",AddNode)
CALL vcOnClick@(dlg1,"toolBarButton2",AddNode)
CALL vcOnClick@(dlg1,"toolBarButton3",DeleteNode)
CALL vcOnClick@(dlg1,"toolBarButton5",InsertNode)
CALL vcOnEvent@(dlg1,"tree_View1","AfterLabelEdit",AfterEdit)
CALL vcOnEvent@(dlg1,"tree_View1","BeforeSelect",BeforeSelect)
CALL vcOnEvent@(dlg1,"tree_View1","AfterSelect",AfterSelect)
CALL vcOnEvent@(dlg1,"tree_View1","AfterExpand",Changed)
CALL vcOnEvent@(dlg1,"tree_View1","AfterCollapse",Changed)
CALL vcOnEvent@(dlg1,"tree_View1","BeforeCollapse",BeforeCollapse)
CALL vcOnEvent@(dlg1,"text_Box1","TextChanged",Changed)
CALL vcOnEvent@(dlg1,"decimal_UpDown1","ValueChanged",ValueChanged)
CALL vcOnEvent@(dlg1,"decimal_UpDown2","ValueChanged",ValueChanged)
CALL vcOnEvent@(dlg1,"Create_Child",OnCreate)
CALL vcOnEvent@(dlg1,"Open_Child",OnOpen)
CALL vcOnEvent@(dlg1,"Save_Child",OnSave)
CALL vcImageIndex@(dlg1,0)
CALL vcSetStringData@(dlg1,"#Caption"," - TreeNode Editor")
CALL vcDisplayDialog@(dlg1) 
END

