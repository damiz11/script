MODULE Form1
  USE VC
  TYPE(VCdialog) dlg1
CONTAINS

INTEGER FUNCTION OnLoad()
  CALL vcLoadTree@(dlg1,"tree_View1","TOC.tre")
  OnLoad=0
END FUNCTION OnLoad

INTEGER FUNCTION OnSelect()
  STRING str
  str=vcGetStringData@(dlg1,"#NodeData")
  CALL vcWebNavigate@(dlg1,"explorer_Box1",str)
  OnSelect=0
END FUNCTION OnSelect

INTEGER FUNCTION OnEvent()
STRING s
s=vcGetStringData@(dlg1,"#HTMLtype")
IF(CHAR(s)=="click")THEN
  s=vcGetStringData@(dlg1,"#HTMLtagName")
  IF(CHAR(s)=="BUTTON")THEN
    s=vcGetStringData@(dlg1,"#HTMLid")
    CALL vcStartProcess@(s)
  ENDIF
ENDIF
OnEvent=0
END FUNCTION OnEvent

END MODULE Form1

PROGRAM Main
  USE Form1
  ATTRIBUTE(class="System.STAThreadAttribute",target="ROUTINE")
  dlg1=vcCreateDialog@("Resources1.Form1")
  CALL vcOnEvent@(dlg1,"Load",OnLoad)
  CALL vcOnEvent@(dlg1,"tree_View1","AfterSelect",OnSelect)
  CALL vcOnEvent@(dlg1,"explorer_Box1","HtmlEvent",OnEvent)
  CALL vcDisplayDialog@(dlg1)
END
