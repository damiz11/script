MODULE Form1
  USE VC
  TYPE(VCdialog) dlgParent
CONTAINS

INTEGER FUNCTION OnOpenChild()
  TYPE(VCdialog) dlgChild
  dlgChild=vcGetActiveMDIChild@(dlgParent)
  CALL vcLoadText@(dlgChild,"textBox1")
  OnOpenChild=0
END FUNCTION OnOpenChild

INTEGER FUNCTION OnSaveChild()
  TYPE(VCdialog) dlgChild
  dlgChild=vcGetActiveMDIChild@(dlgParent)
  CALL vcSaveText@(dlgChild,"textBox1")
  OnSaveChild=0
END FUNCTION OnSaveChild

INTEGER FUNCTION OnChange()
  TYPE(VCdialog) dlgChild
  dlgChild=vcGetActiveMDIChild@(dlgParent)
  CALL vcSetIntegerData@(dlgChild,"#Modified",1)
  OnChange=0
END FUNCTION OnChange  

INTEGER FUNCTION OnCreateChild()
  TYPE(VCdialog) dlgChild
  CHARACTER(LEN=8) ftype
  ftype=vcGetStringData@(dlgParent,"#FileType")
  IF(ftype(1:3)=="rtf")THEN
    dlgChild=vcCreateMDIChild@(dlgParent,"Resources1.Form3")
    CALL vcOnEvent@(dlgChild,"Open_Child",OnOpenChild)
    CALL vcOnEvent@(dlgChild,"Save_Child",OnSaveChild)
    CALL vcOnEvent@(dlgChild,"textBox1","TextChanged",OnChange)
    CALL vcShow@(dlgChild)
  ELSE
    dlgChild=vcCreateMDIChild@(dlgParent,"Resources1.Form2")
    CALL vcOnEvent@(dlgChild,"Open_Child",OnOpenChild)
    CALL vcOnEvent@(dlgChild,"Save_Child",OnSaveChild)
    CALL vcOnEvent@(dlgChild,"textBox1","TextChanged",OnChange)
    CALL vcShow@(dlgChild)
  ENDIF
  OnCreateChild=0
END FUNCTION OnCreateChild

END MODULE Form1

PROGRAM Main
  USE Form1
  ATTRIBUTE(class="System.STAThreadAttribute",target="ROUTINE")
  dlgParent=vcCreateDialog@("Resources1.Form1")
  CALL vcOnEvent@(dlgParent,"Create_Child",OnCreateChild)
  CALL vcDisplayDialog@(dlgParent)
END
