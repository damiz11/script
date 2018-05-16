MODULE Form1
USE VC
TYPE(VCdialog) dlg1
CONTAINS

INTEGER FUNCTION FileOpen()
  CALL vcSetText@(dlg1,"statusBarPanel1","FileOpen called.....")
  FileOpen=0
END FUNCTION FileOpen

INTEGER FUNCTION Copy()
  CALL vcSetText@(dlg1,"statusBarPanel1","Copy called.....")
  Copy=0
END FUNCTION Copy

INTEGER FUNCTION Paste()
  CALL vcSetText@(dlg1,"statusBarPanel1","Paste called.....")
  Paste=0
END FUNCTION Paste

INTEGER FUNCTION About()
  CALL vcShowMessageBox@("Resources.Form2")
  About=0
END FUNCTION About

END MODULE Form1

PROGRAM Main
USE Form1
dlg1=vcCreateDialog@("Resources.Form1")
!Menu item callbacks....
CALL vcOnClick@(dlg1,"menuItem4",About)
CALL vcOnClick@(dlg1,"menuItem5",About)
CALL vcOnClick@(dlg1,"toolBarButton1",FileOpen)
!A dynamic menu item....
CALL vcInsertMenuItem@(dlg1,"newItem","menuItem1","Open",FileOpen,.TRUE.)
CALL vcSetMenuAccelerator@(dlg1,"newItem","CtrlO")
!An independent accelerator key....
CALL vcAddAccelerator@(dlg1,"accel1","CtrlA",About)
!Status bar prompt for the new menu item....
CALL vcMenuTip@(dlg1,"newItem","Opens a file.")
CALL vcDisplayDialog@(dlg1)
END

