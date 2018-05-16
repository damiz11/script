!---------------------------------------------------------------
!  Salford Software FTN95 .NET for Visual Studio .NET
!  Free Format FTN95 Source File
!---------------------------------------------------------------

!---------------------------------------------------------------
! Main program
!---------------------------------------------------------------
PROGRAM MainProgram

!---------------------------------------------------------------
! Declare the C routines we wish to call
!---------------------------------------------------------------
C_EXTERNAL FunctionSimple "_FunctionSimple"
C_EXTERNAL FunctionArgumentsValue "_FunctionArgumentsValue" (VAL,VAL)
C_EXTERNAL FunctionArgumentsReference "_FunctionArgumentsReference" (REF,REF)
C_EXTERNAL FunctionSimpleInt "_FunctionSimpleInt" : INTEGER
C_EXTERNAL FunctionArray "_FunctionArray" (REF) : REAL

INTEGER i
INTEGER arr(10)
REAL x

i = 1
x = 3.142

!
! Call a simple function
!
CALL FunctionSimple()
!
! Call a function with simple arguments by value
!
CALL FunctionArgumentsValue(1,4.66D0)
!
! Call a function with simple arguments by reference
!
CALL FunctionArgumentsReference(i,x)
PRINT *,"Value of i after call: ",i
PRINT *,"Value of x after call: ",x
!
! Call a function returning an integer
!
i = FunctionSimpleInt()
PRINT *,"Value of i after call: ",i
!
! Call a function returning a float and accepting an integer array
!
DO j=1,10
  arr(j) = j
END DO
x = FunctionArray(arr)
PRINT *,"Value of x after call: ",x

END PROGRAM