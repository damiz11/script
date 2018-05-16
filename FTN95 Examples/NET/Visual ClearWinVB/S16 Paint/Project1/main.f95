MODULE Form1
USE VC
TYPE(VCdialog) dlg1
INTEGER drawState,colour,lineWidth,x0,y0
LOGICAL mouseDown,mouseMoved
CONTAINS

INTEGER FUNCTION OnMouseUp()
  TYPE(VCdrawing) g
  INTEGER x1,y1,x2,y2,r,x0,y0,wd,ht
  mouseDown=.FALSE.
  OnMouseUp=0
  r = vcGetIntegerData@(dlg1,"#MouseButton")
  IF(r/=PanelSelectionButton_Left) RETURN
  CALL EnableButtons(.FALSE.)
  g = vcGetDrawing@(dlg1,"drawingPanel1")
  x1 = vcGetDrawingData@(g,"MouseStartX")
  y1 = vcGetDrawingData@(g,"MouseStartY")
  x2 = vcGetDrawingData@(g,"MouseX")
  y2 = vcGetDrawingData@(g,"MouseY")
  IF(x1<0) RETURN
  IF(x1==x2 .AND. y1==y2) RETURN
  CALL vcFillARGB@(g,colour)
  CALL vcLineARGB@(g,colour)
  r = vcLineWidth@(g,FLOAT(lineWidth))
  x0 = min(x1,x2);  y0 = min(y1,y2)
  wd = abs(x2-x1);  ht = abs(y2-y1)
  SELECT CASE(drawState)
    CASE (0)
      IF(.NOT.mouseMoved)CALL vcFillRectangle@(g,x2-lineWidth/2,y2-lineWidth/2,lineWidth,lineWidth)
    CASE (1)
      CALL vcDrawLine@(g,x1,y1,x2,y2)
    CASE (2)
      CALL vcFillRectangle@(g,x0,y0,wd,ht)
    CASE (3)
      CALL vcFillEllipse@(g,x0,y0,wd,ht)
    CASE (4)
      CALL vcDrawRectangle@(g,x0,y0,wd,ht)
    CASE (5)
      CALL vcDrawEllipse@(g,x0,y0,wd,ht)
    CASE (6)
      CALL vcGraphicsSelection@(dlg1,"drawingPanel1","Show")
      CALL EnableButtons(.TRUE.)
  END SELECT
END FUNCTION OnMouseUp

INTEGER FUNCTION OnMouseMove()
  TYPE(VCdrawing) g
  INTEGER x,y,r
  CHARACTER(LEN=12) str
  g = vcGetDrawing@(dlg1,"drawingPanel1")
  x = vcGetDrawingData@(g,"MouseX")
  y = vcGetDrawingData@(g,"MouseY")
  WRITE(str,"(a,i4,a,i4,a)") '(',x,',',y,')'
  CALL vcSetText@(dlg1,"statusBarPanel2",str)
  IF(mouseDown)THEN
    IF(x/=x0 .OR. y/=y0)THEN
      r = vcLineWidth@(g,FLOAT(lineWidth))
      CALL vcLineARGB@(g,colour)
      CALL vcDrawLine@(g,x0,y0,x,y)
      x0=x; y0=y
      mouseMoved=.TRUE.
    ENDIF
  ENDIF
  OnMouseMove=0
END FUNCTION OnMouseMove

INTEGER FUNCTION OnMouseDown()
  TYPE(VCdrawing) g
  IF(drawState==0)THEN
    mouseDown=.TRUE.
    mouseMoved=.FALSE.
    g=vcGetDrawing@(dlg1,"drawingPanel1")
    x0=vcGetDrawingData@(g,"MouseX")
    y0=vcGetDrawingData@(g,"MouseY")
  ENDIF  
  OnMouseDown=0
END FUNCTION OnMouseDown

INTEGER FUNCTION OnClick()
  CHARACTER(LEN=14) sender
  CALL vcGraphicsSelection@(dlg1,"drawingPanel1","Hide")
  WRITE(sender,"(a,i1)") "toolBarButton", drawState
  CALL vcSetPushed@(dlg1,sender,.FALSE.)
  sender = vcGetStringData@(dlg1,"#Sender")
  CALL vcSetPushed@(dlg1,sender,.TRUE.)
  READ(sender,"(13x,i1)") drawState
  SELECT CASE (drawState)
    CASE (0)
      CALL vcSetProperty@(dlg1,"drawingPanel1","PanelSelection",0)
    CASE (1)
      CALL vcSetProperty@(dlg1,"drawingPanel1","PanelSelection",1)
    CASE (2,3)
      CALL vcSetProperty@(dlg1,"drawingPanel1","PanelSelection",4)
    CASE (4,5,6)
      CALL vcSetProperty@(dlg1,"drawingPanel1","PanelSelection",2)
   END SELECT   
  CALL EnableButtons(.FALSE.)
  OnClick=0
END FUNCTION OnClick

INTEGER FUNCTION OnWidth()
  CHARACTER(LEN=9) sender
  WRITE(sender,"(a,i1)") "menuItem", lineWidth
  CALL vcSetChecked@(dlg1,sender,.FALSE.)
  sender = vcGetStringData@(dlg1,"#Sender")
  CALL vcSetChecked@(dlg1,sender,.TRUE.)
  READ(sender,"(8x,i1)") lineWidth
  OnWidth=0
END FUNCTION OnWidth

SUBROUTINE EnableButtons(enable)
  LOGICAL enable
  CALL vcSetEnabled@(dlg1, "toolBarButton16_DrawingCut", enable)
  CALL vcSetEnabled@(dlg1, "toolBarButton17_DrawingCopy", enable)
  CALL vcSetEnabled@(dlg1, "toolBarButton19_DrawingDelete", enable)
  CALL vcSetEnabled@(dlg1, "menuItem5_DrawingCut", enable)
  CALL vcSetEnabled@(dlg1, "menuItem6_DrawingCopy", enable)
  CALL vcSetEnabled@(dlg1, "menuItem8_DrawingDelete", enable)
  CALL vcSetEnabled@(dlg1, "menuItem11_DrawingCopyTo", enable)
END SUBROUTINE EnableButtons

INTEGER FUNCTION EnablePaste()
  LOGICAL enable
  enable=vcClipboardGetDataPresent@("Bitmap")
  CALL vcSetEnabled@(dlg1, "toolBarButton18_DrawingPaste", enable)
  EnablePaste=0
END FUNCTION EnablePaste

INTEGER FUNCTION EnableDelete()
  CALL vcSetEnabled@(dlg1, "toolBarButton19_DrawingDelete", .TRUE.)
  CALL vcSetEnabled@(dlg1, "menuItem8_DrawingDelete", .TRUE.)
  EnableDelete=0
END FUNCTION EnableDelete

INTEGER FUNCTION Cut()
  CALL EnableButtons(.FALSE.)
  Cut=EnablePaste()
END FUNCTION Cut

INTEGER FUNCTION Copy()
  Copy=EnablePaste()
END FUNCTION Copy

INTEGER FUNCTION SelectAll()
  SelectAll=EnableDelete()
END FUNCTION SelectAll

INTEGER FUNCTION Paste()
  Paste=EnableDelete()
END FUNCTION Paste

INTEGER FUNCTION OnCreate()
  TYPE(VCdrawing) g
  g = vcGetDrawing@(dlg1,"drawingPanel1")
  CALL vcClearDrawing@(g)
  OnCreate=0
END FUNCTION OnCreate

INTEGER FUNCTION OnOpen()
  CALL vcLoadImage@(dlg1,"drawingPanel1")
  OnOpen=0
END FUNCTION OnOpen

INTEGER FUNCTION OnSave()
  CALL vcSaveImage@(dlg1,"drawingPanel1")
  OnSave=0
END FUNCTION OnSave

INTEGER FUNCTION OnPrint()
  CALL vcPrintDrawing@(dlg1,"drawingPanel1")
  OnPrint=0
END FUNCTION OnPrint  

END MODULE Form1

PROGRAM Main
USE Form1
ATTRIBUTE(class="System.STAThreadAttribute",target="ROUTINE")
drawState = 0
lineWidth = 1
mouseDown = .FALSE.
colour = vcARGB@(255,255,0,0)
dlg1=vcCreateDialog@("Resources1.Form1")
CALL vcLinkInteger@(dlg1,"color_Picker1",colour)
CALL vcOnClick@(dlg1,"toolBarButton0",OnClick)
CALL vcOnClick@(dlg1,"toolBarButton1",OnClick)
CALL vcOnClick@(dlg1,"toolBarButton2",OnClick)
CALL vcOnClick@(dlg1,"toolBarButton3",OnClick)
CALL vcOnClick@(dlg1,"toolBarButton4",OnClick)
CALL vcOnClick@(dlg1,"toolBarButton5",OnClick)
CALL vcOnClick@(dlg1,"toolBarButton6",OnClick)
CALL vcOnClick@(dlg1,"menuItem1",OnWidth)
CALL vcOnClick@(dlg1,"menuItem2",OnWidth)
CALL vcOnClick@(dlg1,"menuItem3",OnWidth)
CALL vcOnClick@(dlg1,"menuItem4",OnWidth)
CALL vcOnClick@(dlg1,"toolBarButton16_DrawingCut",Cut)
CALL vcOnClick@(dlg1,"toolBarButton17_DrawingCopy",Copy)
CALL vcOnClick@(dlg1,"toolBarButton18_DrawingPaste",Paste)
CALL vcOnClick@(dlg1,"menuItem5_DrawingCut",Cut)
CALL vcOnClick@(dlg1,"menuItem6_DrawingCopy",Copy)
CALL vcOnClick@(dlg1,"menuItem7_DrawingPaste",Paste)
CALL vcOnClick@(dlg1,"menuItem9_DrawingSelectAll",SelectAll)
CALL vcOnEvent@(dlg1,"drawingPanel1","MouseUp",OnMouseUp)
CALL vcOnEvent@(dlg1,"drawingPanel1","MouseMove",OnMouseMove)
CALL vcOnEvent@(dlg1,"drawingPanel1","MouseDown",OnMouseDown)
CALL vcOnEvent@(dlg1,"Activated",EnablePaste)
CALL vcOnEvent@(dlg1,"Create_Child",OnCreate)
CALL vcOnEvent@(dlg1,"Open_Child",OnOpen)
CALL vcOnEvent@(dlg1,"Save_Child",OnSave)
CALL vcOnEvent@(dlg1,"Print_Child",OnPrint)
CALL EnableButtons(.FALSE.)
CALL vcDisplayDialog@(dlg1)
END
