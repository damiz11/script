!
!   This program illustrates how CHECKMATE can be used to trap
!   the use of uninitialised data.  This is a simple case.
!
!   Copyright (C) Salford Software Ltd 1998.
!
!   Compile this program using the command line:
!       FTN95 uninit.f90 /check /link /undef
!
program uninitialised_data
    integer :: i, j

    i = j
    print*, "Your compiler have failed to trap this error!"
end program uninitialised_data
