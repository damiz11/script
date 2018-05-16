MODULE Form1
USE VC
TYPE(VCdialog)::dlg1
DOUBLE PRECISION x,y
CONTAINS

INTEGER FUNCTION ButtonClick()
  y=x*x
  ButtonClick=0
END FUNCTION ButtonClick

END MODULE Form1

PROGRAM Main
USE Form1
dlg1=vcCreateDialog@("Resources1.Form1")
CALL vcLinkDouble@(dlg1,"double_Box1",x)
CALL vcLinkDouble@(dlg1,"double_Box2",y)
CALL vcOnClick@(dlg1,"button1",ButtonClick)
CALL vcDisplayDialog@(dlg1)
END
