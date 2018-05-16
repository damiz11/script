MODULE Form1
USE VC
TYPE(VCdialog) dlg1
CONTAINS

INTEGER FUNCTION Draw()
  TYPE(VCdrawing) g
  REAL width,height
  INTEGER w,h
  INTEGER,DIMENSION(0:4):: x,y
  CALL vcGetDrawingSize@(dlg1,"drawingPanel1",w,h)
  g=vcResetDrawing@(dlg1,"drawingPanel1")
  CALL vcDrawRectangle@(g,0,0,w,h)
  CALL vcFillRGB@(g,0,0,255)
  CALL vcFillEllipse@(g,0,0,w,h)
  CALL vcFillRGB@(g,0,255,0)
  x(0)=w/2; x(1)=w;   x(2)=x(0); x(3)=0;    x(4)=x(0);
  y(0)=0;   y(1)=h/2; y(2)=h;    y(3)=y(1); y(4)=0;
  CALL vcFillPolygon@(g,x,y,5)
  CALL vcStringFormat@(g,"Alignment",StringAlignment_Center)
  CALL vcMeasureString@(g,"A",0.0,0.0,width,height)
  CALL vcStringDimensions@(g,float(w),height)
  CALL vcDrawString@(g,"Filled ellipse",width/2.0,float(h/2)-height/2.0)
  CALL vcDrawResource@(g,"MyImage",w/2-8,h/2+7)
  Draw=0
END FUNCTION Draw

END MODULE Form1

PROGRAM Main
USE Form1
dlg1=vcCreateDialog@("Resources6.Form1")
CALL vcOnEvent@(dlg1,"Load",Draw)
CALL vcOnEvent@(dlg1,"SizeChanged",Draw)
CALL vcDisplayDialog@(dlg1)
END

RESOURCES
MyImage IMAGE image.jpg
