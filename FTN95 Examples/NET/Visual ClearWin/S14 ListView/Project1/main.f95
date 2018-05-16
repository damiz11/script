MODULE Form1
  USE VC
  TYPE(VCdialog) dlg1
  INTEGER index,count
  STRING sender,label
CONTAINS

INTEGER FUNCTION GetColor(column)
  INTEGER column
  GetColor=vcToInteger@(vcGetText@(dlg1,"list_View1",index,column))
END FUNCTION GetColor

INTEGER FUNCTION OnSelect()
  TYPE(VCdrawing) d
  OnSelect=0
  IF(index == -1) RETURN
  d=vcGetDrawing@(dlg1,"drawing_Panel1")
  CALL vcFillRGB@(d,GetColor(1),GetColor(2),GetColor(3))
  CALL vcFillDrawing@(d)
END FUNCTION OnSelect

INTEGER FUNCTION OnNew()
INTEGER i
CALL vcImageIndex@(dlg1,0)
i=vcInsert@(dlg1,"list_View1","Black|0|0|0",-1)
index=i
count=count+1
OnNew=0
END FUNCTION OnNew

INTEGER FUNCTION OnDelete()
OnDelete=0
IF(index == -1) RETURN
IF(index < 3)   RETURN
CALL vcRemove@(dlg1,"list_View1",index)
count=count-1
END FUNCTION OnDelete

INTEGER FUNCTION OnEdit()
TYPE(VCdialog) dlg
INTEGER r,red,green,blue
OnEdit=0
IF(index == -1) RETURN
red=GetColor(1)
green=GetColor(2)
blue=GetColor(3)
dlg=vcCreateDialog@("Resources4.Form2")
CALL vcLinkInteger@(dlg,"decimal_UpDown1",red)
CALL vcLinkInteger@(dlg,"decimal_UpDown2",green)
CALL vcLinkInteger@(dlg,"decimal_UpDown3",blue)
CALL vcSetCaption@(dlg,vcGetText@(dlg1,"list_View1",index))
IF(vcShowDialog@(dlg)==DialogResult_OK)THEN
  CALL vcSetText@(dlg1,"list_View1",STRING@(red),  index,1)
  CALL vcSetText@(dlg1,"list_View1",STRING@(green),index,2)
  CALL vcSetText@(dlg1,"list_View1",STRING@(blue), index,3)
  r=OnSelect()
ENDIF
END FUNCTION OnEdit

INTEGER FUNCTION BeforeEdit()
INTEGER item
item=vcGetIntegerData@(dlg1,"#Item")
IF(item < 3)THEN
  BeforeEdit=1
ELSE
  label=vcGetText@(dlg1,"list_View1",item)
  BeforeEdit=0
ENDIF 
END FUNCTION BeforeEdit

INTEGER FUNCTION AfterEdit()
INTEGER item
IF(LEN(vcGetStringData@(dlg1,"#Label")) == 0)THEN
  item=vcGetIntegerData@(dlg1,"#Item")
  CALL vcSetText@(dlg1,"list_View1",label,item)
  AfterEdit=1
ELSE
  AfterEdit=0
ENDIF  
END FUNCTION AfterEdit

INTEGER FUNCTION OnClick()
CALL vcSetChecked@(dlg1,sender,.FALSE.)
sender=vcGetStringData@(dlg1,"#Sender")
CALL vcSetChecked@(dlg1,sender,.TRUE.)
OnClick=0
END FUNCTION OnClick

INTEGER FUNCTION OnChange()
INTEGER colour,r
!The alpha value is not used....
colour=vcARGB@(0,GetColor(1),GetColor(2),GetColor(3))
IF(vcShowColourDialog@(dlg1,colour) == DialogResult_OK) THEN
  CALL vcSetText@(dlg1,"list_View1",STRING@(vcRedValue@(colour)),  index,1)
  CALL vcSetText@(dlg1,"list_View1",STRING@(vcGreenValue@(colour)),index,2)
  CALL vcSetText@(dlg1,"list_View1",STRING@(vcBlueValue@(colour)), index,3)
  r=OnSelect()
ENDIF
OnChange=0
END FUNCTION OnChange

END MODULE Form1

PROGRAM Main
USE Form1
index = -1
count = 3
sender = "menuItem5_Details"
dlg1=vcCreateDialog@("Resources4.Form1")
CALL vcLinkInteger@(dlg1,"list_View1",index)
CALL vcOnEvent@(dlg1,"list_View1","SelectedIndexChanged",OnSelect)
CALL vcOnClick@(dlg1,"menuItem1",OnNew)
CALL vcOnClick@(dlg1,"menuItem2",OnDelete)
CALL vcOnClick@(dlg1,"menuItem3",OnEdit)
CALL vcOnClick@(dlg1,"menuItem5_Details",  OnClick)
CALL vcOnClick@(dlg1,"menuItem6_LargeIcon",OnClick)
CALL vcOnClick@(dlg1,"menuItem7_List",     OnClick)
CALL vcOnClick@(dlg1,"menuItem8_SmallIcon",OnClick)
CALL vcOnClick@(dlg1,"menuItem9",OnChange)
CALL vcOnEvent@(dlg1,"list_View1","BeforeLabelEdit",BeforeEdit)
CALL vcOnEvent@(dlg1,"list_View1","AfterLabelEdit",AfterEdit)
CALL vcDisplayDialog@(dlg1) 
END

