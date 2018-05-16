MODULE Form1
USE VC
TYPE(VCdialog) dlg1
CONTAINS

INTEGER FUNCTION FileOpen()
  INTEGER size,i
  CHARACTER(LEN=256) Files(10)
  STRING s
  size=10
  CALL vcShowFiles@(dlg1,"openFileDialog1",Files,256,size)
  DO i=1,size
    s = TRIM(Files(i))
    CALL vcAppendLine@(dlg1,"text_Box1",s)
  ENDDO  
  FileOpen=0
END FUNCTION FileOpen

INTEGER FUNCTION FileSaveAs()
  INTEGER size
  CHARACTER(LEN=256) File
  size=1
  CALL vcShowFiles@(dlg1,"saveFileDialog1",File,256,size)
  IF(size==1) CALL vcSetText@(dlg1,"text_Box1",File)
  FileSaveAs=0
END FUNCTION FileSaveAs

INTEGER FUNCTION PrintPreview()
  INTEGER r
  CALL vcSetText@(dlg1,"text_Box1","")
  r=vcShowPrintDialog@(dlg1,"printPreviewDialog1")
  PrintPreview=0
END FUNCTION PrintPreview

INTEGER FUNCTION PageSetup()
  INTEGER r
  CALL vcSetText@(dlg1,"text_Box1","")
  r=vcShowPrintDialog@(dlg1,"pageSetupDialog1")
  PageSetup=0
END FUNCTION PageSetup

INTEGER FUNCTION PrintDlg()
  INTEGER r
  CALL vcSetText@(dlg1,"text_Box1","")
  r=vcShowPrintDialog@(dlg1,"printDialog1")
  PrintDlg=0
END FUNCTION PrintDlg

INTEGER FUNCTION ChooseAColor()
  INTEGER color,r
  CHARACTER(LEN=36) buffer
  TYPE(VCdrawing) g
  CALL vcSetText@(dlg1,"text_Box1","")
  color = 0
  r=vcShowColourDialog@(dlg1,"colorDialog1", color)
  WRITE(buffer,"(3(a,i3))") "R=",vcRedValue@(color),"; G=",vcGreenValue@(color),"; B=",vcBlueValue@(color)
  CALL vcSetText@(dlg1,"text_Box1",buffer)
  g=vcGetDrawing@(dlg1,"drawing_Panel1")
  CALL vcFillARGB@(g,color)
  CALL vcFillDrawing@(g)
  ChooseAColor=0
END FUNCTION ChooseAColor

INTEGER FUNCTION ChooseAFont()
  TYPE(VCdrawing) g
  CALL vcSetText@(dlg1,"text_Box1","")
  CALL vcChooseFont@(dlg1,"text_Box2")
  CALL vcSetControlFont@(dlg1,"drawing_Panel1")
  g=vcGetDrawing@(dlg1,"drawing_Panel1")
  CALL vcFillARGB@(g,-1)
  CALL vcFillDrawing@(g)
  CALL vcDrawString@(g,"Graphics",0.0,4.0)
  ChooseAFont=0
END FUNCTION ChooseAFont

END MODULE Form1

PROGRAM Main
USE Form1
dlg1=vcCreateDialog@("Resources1.Form1")
CALL vcOnClick@(dlg1,"menuItem3",FileOpen)
CALL vcOnClick@(dlg1,"menuItem4",FileSaveAs)
CALL vcOnClick@(dlg1,"menuItem6",PrintPreview)
CALL vcOnClick@(dlg1,"menuItem7",PageSetup)
CALL vcOnClick@(dlg1,"menuItem8",PrintDlg)
CALL vcOnClick@(dlg1,"menuItem9",ChooseAColor)
CALL vcOnClick@(dlg1,"menuItem10",ChooseAFont)
CALL vcDisplayDialog@(dlg1)
END

