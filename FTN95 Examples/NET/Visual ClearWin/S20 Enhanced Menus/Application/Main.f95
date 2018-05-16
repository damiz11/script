!  --------------------------------------------------
!  Salford Software FTN95 .NET for Visual Studio .NET
!  Free Format FTN95 Source File
!  --------------------------------------------------

MODULE Form1
  USE VC
  TYPE(VCdialog) dlg1
CONTAINS

INTEGER FUNCTION DoBrowse()
  LOGICAL L
  CHARACTER(LEN=256) path
  L=vcBrowseForFolder@("Input data",path,256)
  DoBrowse=0
END FUNCTION DoBrowse

INTEGER FUNCTION About()
  CALL vcShowMessageBox@("Resources.Form2")
  About=0
END FUNCTION About

END MODULE Form1

PROGRAM Main
  USE Form1
  ATTRIBUTE(class="System.STAThreadAttribute",target="ROUTINE")
  dlg1=vcCreateDialog@("Resources.Form1")
  CALL vcOnClick@(dlg1,"menuItem7",About)
  CALL vcInsertMenuItem@(dlg1,"newItem","menuItem3","Browse",DoBrowse,.TRUE.)
  CALL vcSetMenuAccelerator@(dlg1,"newItem","CtrlB")
  CALL vcMenuTip@(dlg1,"newItem","Browses for a folder.")
  CALL vcMenuImage@(dlg1,"newItem",3)
  CALL vcDisplayDialog@(dlg1)
END
