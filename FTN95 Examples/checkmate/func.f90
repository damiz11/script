!
!   This program illustrates how CHECKMATE can be used to trap
!   inconsistent use of subprograms located in different files.
!
!   Copyright (C) Salford Software Ltd 1998.
!
!   Compile this program using the command line:
!       FTN95 func.f90 /check /link /undef
!
!   Link with the file args1.f90 using the command
!       SLINK func.lnk
!
program function_mismatch
    integer :: i

    i = 1
    call sub(i)
    print*, "Your compiler have failed to trap this error!"
end program function_mismatch
