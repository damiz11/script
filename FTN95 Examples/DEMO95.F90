!
!======================================================================
!  This program is a simple statistics calculator used to demonstrate
!  Salford FTN95, the Salford Software Ltd Fortan 95
!  compiler for Intel-based PCs.
!
!  Before compiling and executing this program, please review the
!  README file in this directory.
!
!  The program was converted automatically from Fortran 77 using the
!  Polyhedron Software plusFORT tools.
!
!         Copyright (C) Salford Software Ltd. 1995-1998
!======================================================================
!
MODULE IFC_CALC
   INTERFACE
      SUBROUTINE CALC(Values,Nvalues,Xmean,Xmed,Xsd,Xmax,Xmin)
      IMPLICIT NONE
      INTEGER :: Nvalues
      REAL :: Xmax , Xmean , Xmed , Xmin , Xsd
      REAL , DIMENSION(*) :: Values
      INTENT (OUT) Xsd
      END SUBROUTINE CALC
   END INTERFACE
END MODULE IFC_CALC
!
MODULE IFC_MEAN
   INTERFACE
      SUBROUTINE MEAN(Values,Nvalues,Xmean)
      IMPLICIT NONE
      INTEGER :: Nvalues
      REAL :: Xmean
      REAL , DIMENSION(*) :: Values
      INTENT (OUT) Xmean
      END SUBROUTINE MEAN
   END INTERFACE
END MODULE IFC_MEAN
!
MODULE IFC_MEDIAN
   INTERFACE
      SUBROUTINE MEDIAN(Values,Nvalues,Xmed)
      IMPLICIT NONE
      INTEGER :: Nvalues
      REAL :: Xmed
      REAL , DIMENSION(*) :: Values
      INTENT (OUT) Xmed
      INTENT (INOUT) Values
      END SUBROUTINE MEDIAN
   END INTERFACE
END MODULE IFC_MEDIAN
!
MODULE IFC_STDEV
   INTERFACE
      REAL FUNCTION STDEV(Values,Nvalues)
      IMPLICIT NONE
      INTEGER :: Nvalues
      REAL , DIMENSION(*) :: Values
      END FUNCTION STDEV
   END INTERFACE
END MODULE IFC_STDEV
!
MODULE IFC_MAXMIN
   INTERFACE
      SUBROUTINE MAXMIN(Values,Nvalues,Xmax,Xmin)
      IMPLICIT NONE
      INTEGER :: Nvalues
      REAL :: Xmax , Xmin
      REAL , DIMENSION(*) :: Values
      INTENT (INOUT) Xmax , Xmin
      END SUBROUTINE MAXMIN
   END INTERFACE
END MODULE IFC_MAXMIN
!
      PROGRAM Stats
      USE IFC_CALC
      IMPLICIT NONE
!
! Local variables
!
      INTEGER :: i , nmarks
      REAL , DIMENSION(100) :: marks
      REAL :: xmax , xmean , xmed , xmin , xsd
!
!   Compile this program with this line:
!
!      FTN95 STATS -LGO
!  The remainder of this file is a main program, followed by several
!  subroutines. It reads some sets of exam marks and computes a set
!  of descriptive statistics.
!
!----------------------------------------------------------------------
!   Read input data.  The data is read in list-directed (free) format.
!   The first value read is a count of the number of marks following.
!   The file containing the input data is MARKS.DAT.
!
      OPEN (UNIT=5,FILE='MARKS.DAT')
      READ (5,*) nmarks
      READ (5,*) (marks(i),i=1,nmarks)
      CLOSE (5)
!  List the data of the screen
      PRINT * , nmarks , ' values read as follows:'
      WRITE (*,99001) (marks(i),i=1,nmarks)
99001 FORMAT (8F8.0)
!   Now calculate statistics
      CALL CALC(marks,nmarks,xmean,xmed,xsd,xmax,xmin)
!   Print results
      PRINT *
      PRINT * , 'Maximum:            ' , xmax
      PRINT * , 'Minumum:            ' , xmin
      PRINT * , 'Mean:               ' , xmean
      PRINT * , 'Median:             ' , xmed
      PRINT * , 'Standard deviation: ' , xsd
      PRINT *
      PRINT * , 'Program complete'
      END PROGRAM Stats
!
      SUBROUTINE CALC(Values,Nvalues,Xmean,Xmed,Xsd,Xmax,Xmin)
      USE IFC_MAXMIN
      USE IFC_MEAN
      USE IFC_MEDIAN
      USE IFC_STDEV
      IMPLICIT NONE
!
! Dummy arguments
!
      INTEGER :: Nvalues
      REAL :: Xmax , Xmean , Xmed , Xmin , Xsd
      REAL , DIMENSION(*) :: Values
      INTENT (OUT) Xsd
!
!======================================================================
!   Subroutine to calculate statistics
!
!   Input arguments:
!	  VALUES   Array holding values
!	  NVALUES  Number of values
!   Output arguments:
!	  XMEAN   Arithmetic mean
!	  XMED	  Median
!	  XSD	  Standard deviation
!	  XMAX	  Maximum value
!	  XMIN	  Minium value
!======================================================================
!
      CALL MEAN(Values,Nvalues,Xmean)
      CALL MEDIAN(Values,Nvalues,Xmed)
      Xsd = STDEV(Values,Nvalues)
      CALL MAXMIN(Values,Nvalues,Xmax,Xmin)
      END SUBROUTINE CALC
!
      SUBROUTINE MEAN(Values,Nvalues,Xmean)
      IMPLICIT NONE
!
! Dummy arguments
!
      INTEGER :: Nvalues
      REAL :: Xmean
      REAL , DIMENSION(*) :: Values
      INTENT (OUT) Xmean
!
! Local variables
!
      INTEGER :: i
      REAL :: x
!
!======================================================================
!   Subroutine to calculate mean of a series of values
!   Input arguments:
!	  VALUES   Array holding values
!	  NVALUES  Number of values
!   Output arguments:
!	  XMEAN   Arithmetic mean
!======================================================================
      x = 0.0
      DO i = 1 , Nvalues
	 x = x + Values(i)
      ENDDO
      Xmean = x/Nvalues
      END SUBROUTINE MEAN
!
      SUBROUTINE MEDIAN(Values,Nvalues,Xmed)
      IMPLICIT NONE
!
! Dummy arguments
!
      INTEGER :: Nvalues
      REAL :: Xmed
      REAL , DIMENSION(*) :: Values
      INTENT (OUT) Xmed
      INTENT (INOUT) Values
!
! Local variables
!
      INTEGER :: i , mid
      LOGICAL :: ok
      REAL :: t
!
!======================================================================
!   Subroutine to calculate median of a series of values
!   Input arguments:
!	  VALUES   Array holding values
!	  NVALUES  Number of values
!   Output arguments:
!	  XMED	 Median
!======================================================================
      DO WHILE ( .TRUE. )
!   Sort values (simple bubble sort)
	 ok = .TRUE.
	 DO i = 2 , Nvalues
	    IF ( Values(i-1)>Values(i) ) THEN
	       t = Values(i)
	       Values(i) = Values(i-1)
	       Values(i-1) = t
	       ok = .FALSE.
	    ENDIF
	 ENDDO
	 IF ( ok ) THEN
!   If NVALUES is odd, use middle value. If NVALUES is even, take average
!   of two middle values.
	    mid = Nvalues/2
	    IF ( mid*2/=Nvalues ) THEN
	       Xmed = Values(mid+1)
	    ELSE
	       Xmed = (Values(mid)+Values(mid+1))/2.0
	    ENDIF
	    EXIT
	 ENDIF
      ENDDO
      END SUBROUTINE MEDIAN
!
      REAL FUNCTION STDEV(Values,Nvalues)
      IMPLICIT NONE
!
! Dummy arguments
!
      INTEGER :: Nvalues
      REAL , DIMENSION(*) :: Values
!
! Local variables
!
      INTEGER :: i
      REAL :: v , x , x2
!
!======================================================================
!   Funtion to calculate standard deviation of a series of values
!   Input arguments:
!	  VALUES   Array holding values
!	  NVALUES  Number of values
!======================================================================
      x = 0.
      x2 = 0.
      DO i = 1 , Nvalues
	 x = x + Values(i)
	 x2 = x2 + Values(i)*Values(i)
      ENDDO
      v = Nvalues
      STDEV = SQRT((v*x2-x*x)/(v*(v-1)))
      END FUNCTION STDEV
!
      SUBROUTINE MAXMIN(Values,Nvalues,Xmax,Xmin)
      IMPLICIT NONE
!
! Dummy arguments
!
      INTEGER :: Nvalues
      REAL :: Xmax , Xmin
      REAL , DIMENSION(*) :: Values
      INTENT (INOUT) Xmax , Xmin
!
! Local variables
!
      INTEGER :: i
!
      Xmax = Values(1)
      Xmin = Values(1)
      DO i = 2 , Nvalues
	 Xmax = MAX(Xmax,Values(i))
	 Xmin = MIN(Xmin,Values(i))
      ENDDO
      END SUBROUTINE MAXMIN
