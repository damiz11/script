MODULE Form1
  USE VC
  TYPE(VCdialog) dlg1
  INTEGER number,bool,color
  REAL(2) x
  CHARACTER(LEN=80) text,font
  LOGICAL colourFromBox
CONTAINS

INTEGER FUNCTION OnPropertyChange()
  CHARACTER(LEN=16) label,value
  label=CHAR(vcGetStringData@(dlg1,"#PropertyValueChangedLabel"))
  IF(label=="Colour")THEN
    colourFromBox = .FALSE.
    CALL vcSetInteger@(dlg1,"int32_Box2",vcRedValue@(color))
    CALL vcSetInteger@(dlg1,"int32_Box3",vcGreenValue@(color))
    CALL vcSetInteger@(dlg1,"int32_Box4",vcBlueValue@(color))
    colourFromBox = .TRUE.
  ELSEIF(label=="Point".OR.label=="X".OR.label=="Y")THEN
    value=CHAR(vcGetStringData@(dlg1,"#PropertyValueChangedValue"))
    CALL vcSetText@(dlg1,"textBox1",value)
  ENDIF
  OnPropertyChange=0
END FUNCTION OnPropertyChange  

INTEGER FUNCTION OnColorChange()
  INTEGER r,g,b
  IF(colourFromBox)THEN
    r = vcGetInteger@(dlg1,"int32_Box2")
    g = vcGetInteger@(dlg1,"int32_Box3")
    b = vcGetInteger@(dlg1,"int32_Box4")
  color = vcARGB@(255,r,g,b)
  ENDIF
  OnColorChange=0
END FUNCTION OnColorChange  

END MODULE Form1

PROGRAM Main
  USE Form1
  number = 10
  x = 2.0
  text = "Sample text..."
  bool = 0
  color = vcARGB@(255,0,255,0)
  font = "Arial, 10"
  colourFromBox = .TRUE.
  dlg1=vcCreateDialog@("Resources1.Form1")
  CALL vcLinkInteger@(dlg1,"int32_Box1",number)
  CALL vcLinkGridInteger@(dlg1,"property_Grid1","Integer",number)
  CALL vcLinkDouble@(dlg1,"double_Box1",x)
  CALL vcLinkGridDouble@(dlg1,"property_Grid1","Double",x)
  CALL vcLinkText@(dlg1,"text_Box1",text,80)
  CALL vcLinkGridText@(dlg1,"property_Grid1","String",text,80)
  CALL vcLinkInteger@(dlg1,"check_Box1",bool)
  CALL vcLinkGridBoolean@(dlg1,"property_Grid1","Logical",bool)
  CALL vcLinkGridColour@(dlg1,"property_Grid1","Colour",color)
  CALL vcLinkText@(dlg1,"text_Box2",font,80)
  CALL vcLinkGridFont@(dlg1,"property_Grid1","Font",font,80)
  CALL vcOnEvent@(dlg1,"property_Grid1","PropertyValueChanged",OnPropertyChange)
  CALL vcOnEvent@(dlg1,"int32_Box2","TextChanged",OnColorChange)
  CALL vcOnEvent@(dlg1,"int32_Box3","TextChanged",OnColorChange)
  CALL vcOnEvent@(dlg1,"int32_Box4","TextChanged",OnColorChange)
  CALL vcDisplayDialog@(dlg1)
END
