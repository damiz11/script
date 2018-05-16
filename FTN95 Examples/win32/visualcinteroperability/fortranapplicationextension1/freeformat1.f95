!---------------------------------------------------------------
!  Salford Software FTN95 .NET for Visual Studio .NET
!  Free Format FTN95 Source File
!---------------------------------------------------------------

!---------------------------------------------------------------
! No arguments
!---------------------------------------------------------------
SUBROUTINE SubSimple
PRINT *,"Simple subroutine called"
END SUBROUTINE

!---------------------------------------------------------------
! Simple Integer and Real arguments
!---------------------------------------------------------------
SUBROUTINE SubArguments(i,x)
INTEGER(KIND=3) :: i
REAL(KIND=1) :: x
PRINT *,"SubArguments called with values:"
PRINT *,"i = ",i
PRINT *,"x = ",x
END SUBROUTINE

!---------------------------------------------------------------
! String arguments
!---------------------------------------------------------------
SUBROUTINE SubString(s1,s2)
CHARACTER(LEN=*) :: s1
CHARACTER(LEN=*) :: s2
PRINT *,"SubString called with two strings"
PRINT *,s1,s2
END SUBROUTINE

!---------------------------------------------------------------
! Array arguments
!---------------------------------------------------------------
SUBROUTINE SubArray(arr)
INTEGER(KIND=3) :: arr(:)
PRINT *,"SubArray called with array"
PRINT *,ARR
END SUBROUTINE

!---------------------------------------------------------------
! Call a routine with a function pointer from C
!---------------------------------------------------------------
SUBROUTINE SubFunc(func)
EXTERNAL :: func
CALL func(34)
END SUBROUTINE

!---------------------------------------------------------------
! An Integer returning Function
!---------------------------------------------------------------
INTEGER(KIND=3) FUNCTION FuncInteger()
FuncInteger = 347
END FUNCTION

!---------------------------------------------------------------
! A Real returning Function
!---------------------------------------------------------------
REAL(KIND=1) FUNCTION FuncReal()
FuncReal = 2.46677
END FUNCTION

