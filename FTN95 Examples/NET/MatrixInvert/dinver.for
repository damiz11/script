c     Salford Software FTN95 .NET for Visual Studio .NET
c     --------------------------------------------------
c     Fixed Format FTN95 Source File
c
c     Filename: dinver.for
c     Author: Silverfrost
c     Notes: See documentation for details
c
c     --------------------------------------------------

      SUBROUTINE DINVERSTUB(A,D,L,M)
        ASSEMBLY_INTERFACE (NAME="DinverStub")
        REAL*8 A(:,:),D,L(:),M(:)
        CALL DINVER(A,4,4,D,L,M)
      END	

      SUBROUTINE DINVER(A,N,NUS,D,L,M)
      REAL*8 A(*),L(*),M(*)
      REAL*8 BIGA,HOLD
      REAL*8 A,D
      IF(NUS.GT.1)GOTO 1
      A(1)=1.0/A(1)
      D=1.0D0
      RETURN
1     D=1.0D0
      NK=-N
      DO 11 K=1,NUS
         NK=NK+N
         L(K)=K
         M(K)=K
         KK=NK+K
         BIGA=A(KK)
         DO 2 J=K,NUS
            IZ=N*(J-1)
            DO 2 I=K,NUS
               IJ=IZ+I
               IF(ABS(BIGA).GE.ABS(A(IJ)))GOTO 2
               BIGA=A(IJ)
               L(K)=I
               M(K)=J
2              CONTINUE
         J=L(K)
         IF(J.LE.K)GOTO 4
         KI=K-N
         DO 3 I=1,NUS
            KI=KI+N
            HOLD=-A(KI)
            JI=KI-K+J
            A(KI)=A(JI)
3           A(JI)=HOLD
4        I=M(K)
         IF(I.LE.K)GOTO 6
         JP=N*(I-1)
         DO 5 J=1,NUS
            JK=NK+J
            JI=JP+J
            HOLD=-A(JK)
            A(JK)=A(JI)
5           A(JI)=HOLD
6        IF(BIGA.NE.0.0)GOTO 7
         D=0.0
         RETURN
7        DO 8 I=1,NUS
            IF(I.EQ.K)GOTO 8
            IK=NK+I
            A(IK)=A(IK)/(-BIGA)
8           CONTINUE
         DO 9 I=1,NUS
            IK=NK+I
            HOLD=A(IK)
            IJ=I-N
            DO 9 J=1,NUS
               IJ=IJ+N
               IF(I.EQ.K)GOTO 9
               IF(J.EQ.K)GOTO 9
               KJ=IJ-I+K
               A(IJ)=HOLD*A(KJ)+A(IJ)
9              CONTINUE
         KJ=K-N
         DO 10 J=1,NUS
            KJ=KJ+N
            IF(J.EQ.K)GOTO 10
            A(KJ)=A(KJ)/BIGA
10          CONTINUE
         D=D*BIGA
         A(KK)=1.0/BIGA
11       CONTINUE
      K=NUS
12    K=K-1
      IF(K.LE.0)RETURN
      I=L(K)
      IF(I.LE.K)GOTO 14
      JQ=N*(K-1)
      JR=N*(I-1)
      DO 13 J=1,NUS
         JK=JQ+J
         HOLD=A(JK)
         JI=JR+J
         A(JK)=-A(JI)
13       A(JI)=HOLD
14    J=M(K)
      IF(J.LE.K)GOTO 12
      KI=K-N
      DO 15 I=1,NUS
         KI=KI+N
         HOLD=A(KI)
         JI=KI-K+J
         A(KI)=-A(JI)
15       A(JI)=HOLD
      GOTO 12
      END
