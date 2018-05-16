MODULE Form1
  USE VC
  TYPE(VCdialog) dlg1
  INTEGER,PARAMETER::CSC_UPDATECOMMANDS=-1
  INTEGER,PARAMETER::CSC_NAVIGATEFORWARD=1
  INTEGER,PARAMETER::CSC_NAVIGATEBACK=2
  INTEGER,PARAMETER::OLECMDID_PRINT=6
  INTEGER,PARAMETER::OLECMDID_REFRESH=22
  INTEGER,PARAMETER::OLECMDID_STOP=23
CONTAINS

INTEGER FUNCTION OnNavigate()
INTEGER index
STRING str
str=vcGetText@(dlg1,"combo_Box1")
OnNavigate=0
IF(LEN(str)==0) RETURN
index=vcInsert@(dlg1,"combo_Box1",str,0,0)
CALL vcRemove@(dlg1,"combo_Box1",16)
CALL vcWebNavigate@(dlg1,"explorer_Box1",str)
END FUNCTION OnNavigate

INTEGER FUNCTION OnEvent()
STRING s
s=vcGetStringData@(dlg1,"#HTMLtype")
CALL vcSetText@(dlg1,"statusBar1",s)
IF(CHAR(s)=="click")THEN
  s=vcGetStringData@(dlg1,"#HTMLtagName")
  IF(CHAR(s)=="BUTTON")THEN
    s=vcGetStringData@(dlg1,"#HTMLid")
    CALL vcShowMessageBox@("You have clicked on the button with id="//s,MessageBox_Information)
  ENDIF
ENDIF
OnEvent=0
END FUNCTION OnEvent

SUBROUTINE SetEnabled(cmdID,button)
INTEGER cmdID,state
CHARACTER(LEN=*) button
state=vcWebQueryStatusWB@(dlg1,"explorer_Box1",cmdID)
CALL vcSetEnabled@(dlg1,button,BTEST(state,1))
END SUBROUTINE SetEnabled

INTEGER FUNCTION OnCommandStateChange()
INTEGER command
LOGICAL enable
command=vcGetIntegerData@(dlg1,"#CommandStateChangeCommand")
enable=vcGetIntegerData@(dlg1,"#CommandStateChangeEnable")/=0
SELECT CASE(command)
CASE (CSC_NAVIGATEBACK) 
  CALL vcSetEnabled@(dlg1,"toolBarButton1_GoBack",enable)
CASE (CSC_NAVIGATEFORWARD) 
  CALL vcSetEnabled@(dlg1,"toolBarButton2_GoForward",enable)
CASE (CSC_UPDATECOMMANDS)
  CALL SetEnabled(OLECMDID_STOP,"toolBarButton3_StopDownload")
  CALL SetEnabled(OLECMDID_REFRESH,"toolBarButton4_Refresh")
  CALL SetEnabled(OLECMDID_PRINT,"toolBarButton5_htm6")
END SELECT
OnCommandStateChange=0
END FUNCTION OnCommandStateChange

END MODULE Form1

PROGRAM Main
USE Form1
ATTRIBUTE(class="System.STAThreadAttribute",target="ROUTINE")
dlg1=vcCreateDialog@("Resources1.Form1")
CALL vcOnClick@(dlg1,"button1",OnNavigate)
CALL vcOnEvent@(dlg1,"explorer_Box1","HtmlEvent",OnEvent)
CALL vcOnEvent@(dlg1,"explorer_Box1","CommandStateChange",OnCommandStateChange)
CALL vcDisplayDialog@(dlg1) 
END

