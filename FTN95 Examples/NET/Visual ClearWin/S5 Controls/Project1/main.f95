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
CALL vcGetControlSize@(dlg1,"progressBar1",w,h)
v = v + 1
IF(v > w/inc) v = 0
CALL vcSetInteger@(dlg1,"progressBar1",inc*v)
CALL vcSetInteger@(dlg1,"int32_Box10",v)
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
dlg1=vcCreateDialog@("Resources3.Form1")
!Check boxes
CALL vcLinkInteger@(dlg1,"check_Box1",check(1))
CALL vcLinkInteger@(dlg1,"int32_Box1",check(1))
CALL vcLinkInteger@(dlg1,"check_Box2",check(2))
CALL vcLinkInteger@(dlg1,"int32_Box2",check(2))
CALL vcLinkInteger@(dlg1,"check_Box3",check(3))
CALL vcLinkInteger@(dlg1,"int32_Box3",check(3))
!Radio buttons in the same container are automatically connected.
CALL vcLinkInteger@(dlg1,"radio_Button1",radio(1))
CALL vcLinkInteger@(dlg1,"int32_Box4",radio(1))
CALL vcLinkInteger@(dlg1,"radio_Button2",radio(2))
CALL vcLinkInteger@(dlg1,"int32_Box5",radio(2))
CALL vcLinkInteger@(dlg1,"radio_Button3",radio(3))
CALL vcLinkInteger@(dlg1,"int32_Box6",radio(3))
!List box
CALL vcLinkInteger@(dlg1,"list_Box1",listItem)
CALL vcLinkInteger@(dlg1,"int32_Box7",listItem)
!Combo box
CALL vcLinkInteger@(dlg1,"combo_Box1",comboItem)
CALL vcLinkInteger@(dlg1,"int32_Box8",comboItem)
CALL vcLinkText@(dlg1,"combo_Box1",comboText,80)
CALL vcLinkText@(dlg1,"text_Box1",comboText,80)
!!Track bar
CALL vcLinkInteger@(dlg1,"track_Bar1",tracker)
CALL vcLinkInteger@(dlg1,"int32_Box9",tracker)
!Progress bar
CALL vcOnEvent@(dlg1,"timer1","Tick",Progress);
!List view
CALL vcLinkInteger@(dlg1,"list_View1",listviewItem)
CALL vcLinkInteger@(dlg1,"int32_Box11",listviewItem)
!Tree view
CALL vcLinkInteger@(dlg1,"tree_View1",treeviewItem)
CALL vcLinkInteger@(dlg1,"int32_Box12",treeviewItem)
CALL vcDisplayDialog@(dlg1) 
END
