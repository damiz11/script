SUBROUTINE mandel(d)
  USE VC
  IMPLICIT NONE
  ASSEMBLY_INTERFACE(name="mandel")
  TYPE(VCdrawing) d
  INTEGER i,j,k,m,n
  INTEGER::r(9)=(/0, 255,   0,   0, 255, 255, 128, 128, 0/)
  INTEGER::g(9)=(/0,   0,   0, 255, 255, 128,   0, 128, 0/)
  INTEGER::b(9)=(/0,   0, 255,   0,   0,   0, 128, 255, 0/)
  COMPLEX z,c
  CALL vcClearDrawing@(d)
  CALL vcUpdate@(d) 
  n = 255
  i = 1
  j = 1
  DO WHILE (i < n+1) 
    j = 1
	DO WHILE (j < n+1) 
	  c = CMPLX(i/100.-2.,j/100.-1.2)
      z = 0. 
      DO k=1,63
        z = z*z+c
        IF (abs(z)>2.) EXIT 
      ENDDO
      m = 1+k/8
      CALL vcSetPixel@(d,i-1,j-1,r(m),g(m),b(m))
	  j = j+1
	ENDDO
	i = i+1
    IF(i/4*4 == i) THEN
      CALL vcInvalidatePixels@(d)
      CALL vcUpdate@(d)
    ENDIF
  ENDDO
END
