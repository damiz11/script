!
!   This program illustrates how CHECKMATE can be used to trap
!   the inconsistent use of subprograms between two files.
!
!   Copyright (C) Salford Software Ltd 1998.
!
!   Compile this program using the command line:
!       FTN95 func1.f90 /check /link /undef
!
!   Link with the file args1.f90 using the command
!       SLINK func.lnk
!
real function sub(int)
    integer :: int

    int = int * 6
    sub = int
end function sub
