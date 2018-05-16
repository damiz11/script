!
!   This program illustrates how CHECKMATE can be used to trap
!   inconsistent use of arguments between two subprograms located
!   in different files.  This module contains the subroutine for
!   the program located in args.f90
!
!   Copyright (C) Salford Software Ltd 1998.
!
!   Compile this program using the command line:
!       FTN95 args1.f90 /check /link /undef
!
!   Link with the file args1.f90 using the command
!       SLINK args.lnk
!
subroutine sub(r)
    real :: r

    r = r * 6
end subroutine sub
