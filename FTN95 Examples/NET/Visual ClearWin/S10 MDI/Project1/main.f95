MODULE Form1
USE VC
TYPE(VCdialog) dlgParent
CONTAINS

INTEGER FUNCTION OnNewText()
  CALL vcStandardCallback@(dlgParent,"New")
  OnNewText=0
END FUNCTION OnNewText

INTEGER FUNCTION OnNewRichText()
  CALL vcSetStringData@(dlgParent,"#FileType","rtf")
  CALL vcStandardCallback@(dlgParent,"New")
  OnNewRichText=0
END FUNCTION OnNewRichText

END MODULE Form1

MODULE Form2
USE Form1
TYPE(VCdialog) dlgChild
CONTAINS

INTEGER FUNCTION OnOpenText()
  dlgChild=vcGetActiveMDIChild@(dlgParent)
  CALL vcLoadText@(dlgChild,"text_Box1")
  OnOpenText=0
END FUNCTION OnOpenText

INTEGER FUNCTION OnOpenRichText()
  dlgChild=vcGetActiveMDIChild@(dlgParent)
  CALL vcLoadText@(dlgChild,"text_Box1")
  OnOpenRichText=OnPosChange()
END FUNCTION OnOpenRichText

INTEGER FUNCTION OnOpenGraphic()
  dlgChild=vcGetActiveMDIChild@(dlgParent)
  CALL vcLoadImage@(dlgChild,"drawing_Panel1")
  OnOpenGraphic=0
END FUNCTION OnOpenGraphic

INTEGER FUNCTION OnSave()
  dlgChild=vcGetActiveMDIChild@(dlgParent)
  CALL vcSaveText@(dlgChild,"text_Box1")
  OnSave=0
END FUNCTION OnSave

INTEGER FUNCTION OnPrint()
  dlgChild=vcGetActiveMDIChild@(dlgParent)
  CALL vcPrintText@(dlgChild,"text_Box1")
  OnPrint=0
END FUNCTION OnPrint  

INTEGER FUNCTION OnPrintImage()
  dlgChild=vcGetActiveMDIChild@(dlgParent)
  CALL vcPrintDrawing@(dlgChild,"drawing_Panel1")
  OnPrintImage=0
END FUNCTION OnPrintImage  

INTEGER FUNCTION OnChange()
  dlgChild=vcGetActiveMDIChild@(dlgParent)
  CALL vcSetIntegerData@(dlgChild,"#Modified",1)
  OnChange=0
END FUNCTION OnChange  

INTEGER FUNCTION OnPosChange()
  dlgChild=vcGetActiveMDIChild@(dlgParent)
  CALL vcSetPushed@(dlgChild,"toolBarButton3_Bold",     "text_Box1","Bold")
  CALL vcSetPushed@(dlgChild,"toolBarButton4_Italic",   "text_Box1","Italic")
  CALL vcSetPushed@(dlgChild,"toolBarButton5_Underline","text_Box1","Underline")
  OnPosChange=0
END FUNCTION OnPosChange
END MODULE Form2

INTEGER FUNCTION OnCreateChild()
USE Form1
USE Form2
CHARACTER(LEN=8) ftype
ftype=vcGetStringData@(dlgParent,"#FileType")
IF(ftype(1:3)=="bmp" .OR. ftype(1:3)=="jpg" .OR. ftype(1:3)=="gif" .OR. ftype(1:3)=="ico" &
                     .OR. ftype(1:3)=="tif" .OR. ftype(1:3)=="png" )THEN
  dlgChild=vcCreateMDIChild@(dlgParent,"Resources.Form4")
  CALL vcOnEvent@(dlgChild,"Open_Child",OnOpenGraphic)      
  CALL vcOnEvent@(dlgChild,"Print_Child",OnPrintImage)
  CALL vcOnClick@(dlgChild,"menuItem30",OnNewText)      
  CALL vcOnClick@(dlgChild,"menuItem31",OnNewRichText)
  CALL vcOnClick@(dlgChild,"menuItem4",OnNewText)      
  CALL vcOnClick@(dlgChild,"menuItem3",OnNewRichText)      
  CALL vcShow@(dlgChild)
ELSEIF(ftype(1:3)=="rtf")THEN
  dlgChild=vcCreateMDIChild@(dlgParent,"Resources.Form3")
  CALL vcOnEvent@(dlgChild,"Open_Child",OnOpenRichText)      
  CALL vcOnEvent@(dlgChild,"Save_Child",OnSave)
  CALL vcOnEvent@(dlgChild,"MenuComplete",OnPosChange)
  CALL vcOnEvent@(dlgChild,"text_Box1","TextChanged",OnChange)
  CALL vcOnEvent@(dlgChild,"text_Box1","MouseDown",OnPosChange)
  CALL vcOnEvent@(dlgChild,"text_Box1","KeyUp",OnPosChange)
  CALL vcOnClick@(dlgChild,"menuItem30",OnNewText)      
  CALL vcOnClick@(dlgChild,"menuItem31",OnNewRichText)
  CALL vcOnClick@(dlgChild,"menuItem4",OnNewText)      
  CALL vcOnClick@(dlgChild,"menuItem3",OnNewRichText)      
  CALL vcOnClick@(dlgChild,"menuItem25_Bold",OnPosChange)      
  CALL vcOnClick@(dlgChild,"menuItem28_Italic",OnPosChange)      
  CALL vcOnClick@(dlgChild,"menuItem29_Underline",OnPosChange)      
  CALL vcShow@(dlgChild)
ELSE
  dlgChild=vcCreateMDIChild@(dlgParent,"Resources.Form2")
  CALL vcOnEvent@(dlgChild,"Open_Child",OnOpenText)      
  CALL vcOnEvent@(dlgChild,"Save_Child",OnSave)
  CALL vcOnEvent@(dlgChild,"Print_Child",OnPrint)
  CALL vcOnEvent@(dlgChild,"text_Box1","TextChanged",OnChange)
  CALL vcOnClick@(dlgChild,"menuItem30",OnNewText)      
  CALL vcOnClick@(dlgChild,"menuItem31",OnNewRichText)      
  CALL vcOnClick@(dlgChild,"menuItem4",OnNewText)      
  CALL vcOnClick@(dlgChild,"menuItem3",OnNewRichText)      
  CALL vcShow@(dlgChild)
ENDIF
OnCreateChild=0
END

PROGRAM Main
USE Form1
ATTRIBUTE(class="System.STAThreadAttribute",target="ROUTINE")
INTEGER OnCreateChild
EXTERNAL OnCreateChild
dlgParent=vcCreateDialog@("Resources.Form1")
CALL vcOnEvent@(dlgParent,"Create_Child",OnCreateChild)
CALL vcOnClick@(dlgParent,"menuItem2",OnNewText)      
CALL vcOnClick@(dlgParent,"menuItem5",OnNewRichText)      
CALL vcOnClick@(dlgParent,"menuItem4",OnNewText)      
CALL vcOnClick@(dlgParent,"menuItem6",OnNewRichText)      
CALL vcDisplayDialog@(dlgParent)                            
END

!INTEGER FUNCTION OnPrint()
!OBJECT("System.Windows.Forms.Control") ctrl
!OBJECT("Salford.Windows.Forms.Drawing") drawing
!STRING line
!REAL leftMargin,y,lineHeight
!INTEGER linesPerPage,n,i
!  dlgChild=GetActiveMDIChild(dlgParent)
!  ctrl=GetControl(dlgChild,"text_Box1")
!  drawing=GetPrinterDrawing()
!  CALL SetFont(drawing,ctrl)
!  leftMargin=GetPrinterInteger("LeftMargin")
!  y=GetPrinterInteger("TopMargin")
!  lineHeight=GetFontHeight(drawing)
!  linesPerPage=GetPrinterInteger("Height")/lineHeight
!  n=(GetPrinterInteger("PageNumber")-1)*linesPerPage + 1
!  i=0
!  DO WHILE(i<linesPerPage)
!    line=GetTextLine(dlgChild,"text_Box1",n)
!    IF(n==0)EXIT
! 	CALL DrawString(drawing,line,leftMargin,y)
!	y=y+lineHeight
!	n=n+1
!	i=i+1
!  END DO
!  IF(n>0)THEN
!    CALL MorePages(1)
!  ELSE
!    CALL MorePages(0)
!  ENDIF
!  OnPrint=0
!END FUNCTION OnPrint  
!
