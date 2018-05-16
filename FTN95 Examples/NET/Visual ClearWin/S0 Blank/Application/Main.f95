!  --------------------------------------------------
!  Salford Software FTN95 .NET for Visual Studio .NET
!  Free Format FTN95 Source File
!  --------------------------------------------------

MODULE Form1
  USE VC
  TYPE(VCdialog) dlg1
CONTAINS

INTEGER FUNCTION DoProcess()
  !<Add your processing here.....>
  DoProcess=0
END FUNCTION DoProcess

END MODULE Form1

PROGRAM Main
  USE Form1
  dlg1=vcCreateDialog@("Resources.Form1")
  !CALL vcOnClick@(dlg1,"<Add your button or menu item name here....>",DoProcess)      
  CALL vcDisplayDialog@(dlg1)
END
