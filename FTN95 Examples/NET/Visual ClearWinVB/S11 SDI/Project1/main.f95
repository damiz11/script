MODULE Form1
USE VC
TYPE(VCdialog) dlg,FindDlg
CONTAINS

INTEGER FUNCTION OnCreate()
CALL vcSetText@(dlg,"text_Box1","")
OnCreate=0
END FUNCTION OnCreate

INTEGER FUNCTION OnOpen()
CALL vcLoadText@(dlg,"text_Box1")
CALL vcFocus@(dlg,"text_Box1")
OnOpen=0
END FUNCTION OnOpen

INTEGER FUNCTION OnSave()
CALL vcSaveText@(dlg,"text_Box1")
OnSave=0
END FUNCTION OnSave

INTEGER FUNCTION OnPrint()
  CALL vcPrintText@(dlg,"text_Box1")
  OnPrint=0
END FUNCTION OnPrint  

INTEGER FUNCTION OnChanged()
CALL vcSetIntegerData@(dlg,"#Modified",1)
OnChanged=0
END FUNCTION OnChanged

INTEGER FUNCTION OnComboChange()
STRING font
font=vcGetText@(dlg,"comboBox1")
CALL vcSetFontName@(dlg,"text_Box1",font)
CALL vcSetFontName@(dlg,"fontDialog1",font)
CALL vcFocus@(dlg,"text_Box1")
OnComboChange=0
END FUNCTION OnComboChange

INTEGER FUNCTION OnSelectFont()
STRING font
CALL vcStandardCallback@(dlg,"Font")
font=vcGetFontName@(dlg,"text_Box1")
CALL vcSetText@(dlg,"comboBox1",font)
OnSelectFont=0
END FUNCTION OnSelectFont

INTEGER FUNCTION OnClosing()
CALL vcNullify@(FindDlg)
OnClosing=0
END FUNCTION OnClosing

INTEGER FUNCTION OnClose()
CALL vcCloseDialog@(FindDlg)
OnClose=0
END FUNCTION OnClose

INTEGER FUNCTION OnEnter()
STRING str
INTEGER r
str=vcGetText@(FindDlg,"combo_Box1")
CALL vcFocus@(FindDlg,"combo_Box1")
OnEnter=0
IF(LEN(str)==0) RETURN
r=vcInsert@(FindDlg,"combo_Box1",str,0,0)
CALL vcRemove@(FindDlg,"combo_Box1",10)
r=FindText_None
IF(vcIsChecked@(FindDlg,"check_Box1")) r=FindText_MatchCase
IF(vcIsChecked@(FindDlg,"check_Box2")) r=r+FindText_WholeWord
IF(vcIsChecked@(FindDlg,"check_Box3")) r=r+FindText_Reverse
r=vcFindText@(dlg,"text_Box1",str,r)
END FUNCTION OnEnter

END MODULE Form1

INTEGER FUNCTION ShowFindDlg()
USE Form1
IF(vcIsNull@(FindDlg))THEN
  FindDlg=vcCreateDialog@(dlg,"Resources1.Form2")
  CALL vcOnClick@(FindDlg,"button1",OnEnter)
  CALL vcOnClick@(FindDlg,"button2",OnClose)
  CALL vcOnClick@(FindDlg,"button3",OnEnter)
  CALL vcOnEvent@(FindDlg,"combo_Box1","SelectionChangeCommitted",OnEnter)
  CALL vcOnEvent@(FindDlg,"Closing",OnClosing)
  CALL vcShow@(FindDlg)
ELSE
  CALL vcBringToFront@(FindDlg)
ENDIF
ShowFindDlg=0
END FUNCTION ShowFindDlg

PROGRAM Main
USE Form1
ATTRIBUTE(class="System.STAThreadAttribute",target="ROUTINE")
INTEGER ShowFindDlg
EXTERNAL ShowFindDlg
CALL vcNullify@(FindDlg)
dlg=vcCreateDialog@("Resources1.Form1")
CALL vcPopulateFontCombo@(dlg,"comboBox1")
CALL vcOnClick@(dlg,"menuItem21",OnSelectFont)
CALL vcOnClick@(dlg,"toolBarButton20",ShowFindDlg)
CALL vcOnEvent@(dlg,"Create_Child",OnCreate)
CALL vcOnEvent@(dlg,"Open_Child",OnOpen)
CALL vcOnEvent@(dlg,"Save_Child",OnSave)
CALL vcOnEvent@(dlg,"Print_Child",OnPrint)
CALL vcOnEvent@(dlg,"text_Box1","TextChanged",OnChanged)
CALL vcOnEvent@(dlg,"comboBox1","SelectionChangeCommitted",OnComboChange)
CALL vcSetStringData@(dlg,"#Caption"," - MyNotes")
CALL vcStandardCallback@(dlg,"New")
CALL vcSetText@(dlg,"comboBox1","Arial")
CALL vcDisplayDialog@(dlg)                            
END

