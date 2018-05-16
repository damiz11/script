!-----------------------------------------------------
! Module NetDeclarations contains declarations of .NET
! methods called by this example 
!-----------------------------------------------------
MODULE NetDeclarations
  OBJECT("System.Drawing.Bitmap") :: bitmap
  OBJECT("System.Windows.Forms.PictureBox") :: picturebox
  ASSEMBLY_EXTERNAL(name="System.Drawing.Bitmap.SetPixel") :: bitmapSetPixel
  ASSEMBLY_EXTERNAL(name="System.Windows.Forms.PictureBox.Update") :: pictureboxUpdate
  ASSEMBLY_EXTERNAL(name="System.Windows.Forms.PictureBox.Invalidate") :: pictureboxInvalidate
  ASSEMBLY_EXTERNAL(name="System.Drawing.Color.FromArgb") :: colorFromArgb
  INTEGER :: r(256)
  INTEGER :: g(256)
  INTEGER :: b(256)
END MODULE

!-----------------------------------------------------
! Setup .NET objects
!-----------------------------------------------------
SUBROUTINE SetupMandelbrot_(bitmap_,picturebox_)
  USE NetDeclarations
  ASSEMBLY_INTERFACE(name="SetupMandelbrot")
  OBJECT("System.Drawing.Bitmap") :: bitmap_
  OBJECT("System.Windows.Forms.PictureBox") :: picturebox_
  INTEGER :: i
  bitmap = bitmap_
  picturebox = picturebox_

  DO i=1,192
    r(i) = MIN(255, (i*4/3) +192)
    g(i) = MIN(255, (i*4/3) +64)
    b(i) = MIN(255, (i*4/3))
  ENDDO
  
  DO i=1,64
    r(192+i) = MIN(255, (65-i)*4 + 192/3)
    g(192+i) = MIN(255, (65-i)*4 + 64/3)
    b(192+i) = MIN(255, (65-i)*4)
  ENDDO
END SUBROUTINE

!-----------------------------------------------------
! Draws the image on the Bitmap object we have been 
! passed in
!-----------------------------------------------------
SUBROUTINE DrawMandelbrot_(zoom,offset_x,offset_y,size)
  USE NetDeclarations
  ASSEMBLY_INTERFACE(name="DrawMandelbrot")
  INTEGER i,j,k,size,iter
  DOUBLE PRECISION :: zoom
  DOUBLE PRECISION :: offset_x,offset_y 
  DOUBLE PRECISION :: zr,cr,zi,ci,zis,zrs
  i = 1
  j = 1
  iter = size
  size = size/2
  offset_x = offset_x-200.0+size
  offset_y = offset_y-120.0+size
  DO WHILE (i < iter+1) 
    j = 1
    DO WHILE (j < iter+1)
      cr = ((i-size)/zoom + offset_x)/100.0
      ci = ((j-size)/zoom + offset_y)/100.0
      zr = 0.
      zi = 0. 
      DO k=1,255
        zis = zi*zi
        zrs = zr*zr
        zi = 2*zr*zi+ci
        zr = zrs-zis+cr
        IF ((zrs+zis)>4.) EXIT 
      ENDDO
      CALL bitmapSetPixel(bitmap,i-1,j-1,colorFromArgb(r(k),g(k),b(k)))  
      j = j+1
    ENDDO
    i = i+1
  ENDDO
  CALL pictureboxInvalidate(picturebox)
  CALL pictureboxUpdate(picturebox)  
END