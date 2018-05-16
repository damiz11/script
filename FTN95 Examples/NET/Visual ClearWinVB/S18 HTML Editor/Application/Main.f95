MODULE Form1
  USE VC
  TYPE(VCdialog) dlg1
  LOGICAL untitled,stateChange
  INTEGER textcolour, backcolour
  INTEGER,PARAMETER::IDM_FONTNAME = 18
  INTEGER,PARAMETER::IDM_FONTSIZE = 19
  INTEGER,PARAMETER::IDM_BACKCOLOR = 51
  INTEGER,PARAMETER::IDM_FORECOLOR = 55
  INTEGER,PARAMETER::IDM_SAVE = 70
  INTEGER,PARAMETER::IDM_SAVEAS = 71
  INTEGER,PARAMETER::IDM_REMOVEFORMAT = 2230
  INTEGER,PARAMETER::IDM_BLOCKFMT = 2234
  INTEGER,PARAMETER::IDM_SETDIRTY = 2342
CONTAINS

INTEGER FUNCTION SetColour(command, v)
INTEGER command,v,r,colour
colour=vcRedValue@(v)+256*(vcGreenValue@(v)+256*vcBlueValue@(v))
r=vcWebCommand@(dlg1,"explorer_Box1",command,colour)
SetColour=0
END FUNCTION SetColour

INTEGER FUNCTION OnNew()
CALL vcWebNavigate@(dlg1,"explorer_Box1","")
untitled=.TRUE.
OnNew=0
END FUNCTION OnNew

INTEGER FUNCTION OnOpen()
INTEGER size
CHARACTER(LEN=256) file
size=1
CALL vcShowFiles@(dlg1,"openFileDialog1",file,256,size)
IF(size==1)THEN
  CALL vcWebNavigate@(dlg1,"explorer_Box1",file)
  untitled=.FALSE.
ENDIF
OnOpen=0
END FUNCTION OnOpen

INTEGER FUNCTION OnSave()
INTEGER r
IF(untitled)THEN
  r=OnSaveAs()
ELSE
  r=vcWebCommand@(dlg1,"explorer_Box1",IDM_SAVE)
ENDIF  
OnSave=0
END FUNCTION OnSave

INTEGER FUNCTION OnSaveAs()
INTEGER r
STRING url
r=vcWebCommand@(dlg1,"explorer_Box1",IDM_SAVEAS)
url=vcGetDocumentURL@(dlg1,"explorer_Box1")
CALL vcSetCaption@(dlg1,url)
IF(CHAR(url)/="about:Blank") untitled=.FALSE. 
OnSaveAs=0
END FUNCTION OnSaveAs

INTEGER FUNCTION OnTextColour()
INTEGER color,r
color=textcolour
IF(vcShowColourDialog@(dlg1,color) == DialogResult_OK)THEN
  textcolour = color
  r=SetColour(IDM_FORECOLOR,color)
ENDIF
OnTextColour=0
END FUNCTION OnTextColour

INTEGER FUNCTION OnBackColour()
INTEGER color
color=backcolour
IF(vcShowColourDialog@(dlg1,color) == DialogResult_OK)THEN
  backcolour = color
  r=SetColour(IDM_BACKCOLOR,color)
ENDIF
OnBackColour=0
END FUNCTION OnBackColour

INTEGER FUNCTION OnCombo1()
INTEGER r
STRING str
OnCombo1=0
IF(stateChange) RETURN
str=vcGetText@(dlg1,"comboBox1")
r=vcWebCommand@(dlg1,"explorer_Box1",IDM_BLOCKFMT,str)
END FUNCTION OnCombo1

INTEGER FUNCTION OnCombo2()
INTEGER r
STRING str
OnCombo2=0
IF(stateChange) RETURN
str=vcGetText@(dlg1,"comboBox2")
IF(CHAR(str)=="(Default font)")THEN
  r=vcWebCommand@(dlg1,"explorer_Box1",IDM_REMOVEFORMAT)
ELSE
  r=vcWebCommand@(dlg1,"explorer_Box1",IDM_FONTNAME,str)
ENDIF
END FUNCTION OnCombo2

INTEGER FUNCTION OnCombo3()
INTEGER r
STRING str
OnCombo3=0
IF(stateChange) RETURN
str=vcGetText@(dlg1,"comboBox3")
r=vcWebCommand@(dlg1,"explorer_Box1",IDM_FONTSIZE,str)
END FUNCTION OnCombo3

INTEGER FUNCTION OnComplete()
STRING url
url=vcGetStringData@(dlg1,"#DocumentCompleteURL")
CALL vcSetCaption@(dlg1,url)
OnComplete=0
END FUNCTION OnComplete

SUBROUTINE SetPushed(cmdID,button)
INTEGER cmdID,state
CHARACTER(LEN=*) button
state=vcWebQueryStatus@(dlg1,"explorer_Box1",cmdID)
CALL vcSetPushed@(dlg1,button,BTEST(state,2))
END SUBROUTINE SetPushed

SUBROUTINE SetEnabled(cmdID,button)
INTEGER cmdID,state
CHARACTER(LEN=*) button
state=vcWebQueryStatus@(dlg1,"explorer_Box1",cmdID)
CALL vcSetEnabled@(dlg1,button,BTEST(state,1))
END SUBROUTINE SetEnabled

INTEGER FUNCTION OnCommandStateChange()
LOGICAL L
INTEGER r
STRING str
CHARACTER(LEN=40) s
CALL SetPushed(52,"toolBarButton20_htm52")     !Bold
CALL SetPushed(56,"toolBarButton21_htm56")     !Italic
CALL SetPushed(63,"toolBarButton22_htm63")     !Underline
CALL SetPushed(2185,"toolBarButton31_htm2185") !Bullet list
CALL SetPushed(2184,"toolBarButton32_htm2184") !Numbered list
CALL SetEnabled(43,"toolBarButton10_htm43")    !Undo
CALL SetEnabled(43,"menuItem13_htm43")
CALL SetEnabled(29,"toolBarButton11_htm29")    !Redo
CALL SetEnabled(29,"menuItem14_htm29")
CALL SetEnabled(16,"toolBarButton6_htm16")     !Cut
CALL SetEnabled(16,"menuItem16_htm16")
CALL SetEnabled(15,"toolBarButton7_htm15")     !Copy
CALL SetEnabled(15,"menuItem17_htm15")
L=vcClipboardGetDataPresent@("HTML Format")      !Paste
CALL vcSetEnabled@(dlg1,"toolBarButton8_htm26",L)
CALL vcSetEnabled@(dlg1,"menuItem18_htm26",L)
stateChange=.TRUE.
r=vcWebQueryString@(dlg1,"explorer_Box1",IDM_BLOCKFMT,str)
IF(r==0) CALL vcSetText@(dlg1,"comboBox1",str)
r=vcWebQueryString@(dlg1,"explorer_Box1",IDM_FONTNAME,str)
IF(r==0)THEN
  IF(CHAR(str)=="Times New Roman") str="(Default font)"
  CALL vcSetText@(dlg1,"comboBox2",str)
ENDIF
r=vcWebQueryString@(dlg1,"explorer_Box1",IDM_FONTSIZE,str)
IF(r==0) CALL vcSetText@(dlg1,"comboBox3",str)
stateChange=.FALSE.
OnCommandStateChange=0
END FUNCTION OnCommandStateChange

INTEGER FUNCTION OnClosing()
OnClosing=0
IF(vcIsDocumentDirty@(dlg1,"explorer_Box1"))THEN
  IF(vcMessageBoxShow@("Cancel Exit to save changes?",MessageBox_Question+MessageBox_YesNo)==DialogResult_Yes)THEN
    OnClosing=1
  ENDIF
ENDIF
END FUNCTION OnClosing

END MODULE Form1

PROGRAM Main
USE Form1
INTEGER r
ATTRIBUTE(class="System.STAThreadAttribute",target="ROUTINE")
untitled=.TRUE.
stateChange=.FALSE.
textcolour = 0
backcolour = vcARGB@(255,255,255,255)
dlg1=vcCreateDialog@("Resources1.Form1")
CALL vcSetText@(dlg1,"comboBox1","Normal")
CALL vcPopulateFontCombo@(dlg1,"comboBox2")
r=vcInsert@(dlg1,"comboBox2","(Default font)",0)
CALL vcSetText@(dlg1,"comboBox2","(Default font)")
CALL vcSetText@(dlg1,"comboBox3","3")
CALL vcOnClick@(dlg1,"menuItem4",OnNew)
CALL vcOnClick@(dlg1,"menuItem5",OnOpen)
CALL vcOnClick@(dlg1,"menuItem6",OnSave)
CALL vcOnClick@(dlg1,"menuItem7",OnSaveAs)
CALL vcOnClick@(dlg1,"toolBarButton2",OnNew)
CALL vcOnClick@(dlg1,"toolBarButton3",OnOpen)
CALL vcOnClick@(dlg1,"toolBarButton4",OnSave)
CALL vcOnClick@(dlg1,"toolBarButton24",OnTextColour)
CALL vcOnClick@(dlg1,"toolBarButton25",OnBackColour)
CALL vcOnEvent@(dlg1,"comboBox1","SelectedIndexChanged",OnCombo1)
CALL vcOnEvent@(dlg1,"comboBox2","SelectedIndexChanged",OnCombo2)
CALL vcOnEvent@(dlg1,"comboBox3","SelectedIndexChanged",OnCombo3)
CALL vcOnEvent@(dlg1,"explorer_Box1","DocumentComplete", OnComplete)
CALL vcOnEvent@(dlg1,"explorer_Box1","CommandStateChange",OnCommandStateChange)
CALL vcOnEvent@(dlg1,"Closing",OnClosing)
CALL vcDisplayDialog@(dlg1) 
END

