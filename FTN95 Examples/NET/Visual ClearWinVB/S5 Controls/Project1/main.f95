MODULE Form1
USE VC
TYPE(VCdialog) dlg1
INTEGER check(3),radio(3),listItem,comboItem,tracker,listviewItem
INTEGER treeviewItem
CHARACTER(LEN=80) comboText
CONTAINS

INTEGER FUNCTION Progress()
INTEGER::v = 0
SAVE v
INTEGER w,h,inc
!Each blob is 15 pixels wide. 
!In the design view, set the Maximum to the control width in pixels.
inc=15
CALL vcGetControlSize@(dlg1,"ProgressBar1",w,h)
v = v + 1
IF(v > w/inc) v = 0
CALL vcSetInteger@(dlg1,"ProgressBar1",inc*v)
CALL vcSetInteger@(dlg1,"Int32_Box9",v)
Progress=0
END FUNCTION Progress

END MODULE Form1

PROGRAM Main
USE Form1
check = 0
radio = 0
radio(1) = 1
listItem = -1
comboItem = -1
comboText = " "
tracker = 0
listviewItem = -1
treeviewItem = -1
dlg1=vcCreateDialog@("Resources.Form1")
!Check boxes
CALL vcLinkInteger@(dlg1,"check_Box1",check(1))
CALL vcLinkInteger@(dlg1,"Int32_Box1",check(1))
CALL vcLinkInteger@(dlg1,"check_Box2",check(2))
CALL vcLinkInteger@(dlg1,"Int32_Box2",check(2))
CALL vcLinkInteger@(dlg1,"check_Box3",check(3))
CALL vcLinkInteger@(dlg1,"Int32_Box3",check(3))
!Radio buttons in the same container are automatically connected.
CALL vcLinkInteger@(dlg1,"Radio_Button1",radio(1))
CALL vcLinkInteger@(dlg1,"Int32_Box10",radio(1))
CALL vcLinkInteger@(dlg1,"Radio_Button2",radio(2))
CALL vcLinkInteger@(dlg1,"Int32_Box11",radio(2))
CALL vcLinkInteger@(dlg1,"Radio_Button3",radio(3))
CALL vcLinkInteger@(dlg1,"Int32_Box12",radio(3))
!List box
CALL vcLinkInteger@(dlg1,"List_Box1",listItem)
CALL vcLinkInteger@(dlg1,"Int32_Box6",listItem)
!Combo box
CALL vcLinkInteger@(dlg1,"Combo_Box1",comboItem)
CALL vcLinkInteger@(dlg1,"Int32_Box4",comboItem)
CALL vcLinkText@(dlg1,"Combo_Box1",comboText,80)
CALL vcLinkText@(dlg1,"Text_Box1",comboText,80)
!Track bar
CALL vcLinkInteger@(dlg1,"Track_Bar1",tracker)
CALL vcLinkInteger@(dlg1,"Int32_Box8",tracker)
!Progress bar
CALL vcOnEvent@(dlg1,"Timer1","Tick",Progress);
!List view
CALL vcLinkInteger@(dlg1,"List_View1",listviewItem)
CALL vcLinkInteger@(dlg1,"Int32_Box5",listviewItem)
!Tree view
CALL vcLinkInteger@(dlg1,"Tree_View1",treeviewItem)
CALL vcLinkInteger@(dlg1,"Int32_Box7",treeviewItem)
CALL vcDisplayDialog@(dlg1) 
END
