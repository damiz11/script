MODULE Form1
  USE VC
  TYPE(VCdialog) dlg1
  INTEGER filled,color,x,y,w,h
  CHARACTER(LEN=80) title,font
CONTAINS

INTEGER FUNCTION OnPropertyChange()
  CHARACTER(LEN=80) fontName
  TYPE(VCdrawing) g
  g = vcResetDrawing@(dlg1,"drawing_Panel1")
  CALL vcInvalidateRectangle@(g,0,0,0,0)
  x = vcGetInteger@(dlg1,"decimal_UpDown1")
  y = vcGetInteger@(dlg1,"decimal_UpDown2")
  w = vcGetInteger@(dlg1,"decimal_UpDown3")
  h = vcGetInteger@(dlg1,"decimal_UpDown4")
  IF(filled == 0)THEN
    CALL vcLineARGB@(g,color)
    CALL vcDrawEllipse@(g,x,y,w,h)
  ELSE
    CALL vcFillARGB@(g,color)
    CALL vcFillEllipse@(g,x,y,w,h)
  ENDIF
  i = INDEX(font,",")
  CALL vcStringFontName@(g,font(1:i-1))
  READ(font(i+1:),*) sz
  sz = vcStringFontSize@(g, sz)
  CALL vcStringFontName@(g,font(1:i-1))
  CALL vcDrawString@(g,title,0.0,y+h+10.0)
  OnPropertyChange=0
END FUNCTION OnPropertyChange  

END MODULE Form1

PROGRAM Main
  USE Form1
  title = "The figure"
  filled = 0; x = 40; y = 80; w = 200; h = 100
  color = vcARGB@(255,0,255,0)
  font = "Arial, 12"
  dlg1=vcCreateDialog@("Resources.Form1")
  CALL vcLinkGridText@(dlg1,"property_Grid1","Title",title,80)
  CALL vcLinkGridBoolean@(dlg1,"property_Grid1","Filled",filled)
  CALL vcLinkGridColour@(dlg1,"property_Grid1","Colour",color)
  CALL vcLinkGridFont@(dlg1,"property_Grid1","Font",font,80)
  CALL vcOnEvent@(dlg1,"property_Grid1","PropertyValueChanged",OnPropertyChange)
  CALL vcOnEvent@(dlg1,"Load",OnPropertyChange)
  CALL vcOnEvent@(dlg1,"decimal_UpDown1","ValueChanged",OnPropertyChange)
  CALL vcOnEvent@(dlg1,"decimal_UpDown2","ValueChanged",OnPropertyChange)
  CALL vcOnEvent@(dlg1,"decimal_UpDown3","ValueChanged",OnPropertyChange)
  CALL vcOnEvent@(dlg1,"decimal_UpDown4","ValueChanged",OnPropertyChange)
  CALL vcDisplayDialog@(dlg1)
END
