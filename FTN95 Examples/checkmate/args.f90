!
!   This program illustrates how CHECKMATE can be used to trap
!   inconsistent use of arguments between two subprograms located
!   in different files.
!
!   Copyright (C) Salford Software Ltd 1998.
!
!   Compile this program using the command line:
!       FTN95 args.f90 /check /link /undef
!
!   Link with the file args1.f90 using the command
!       SLINK args.lnk
!
program argument_mismatch
    integer :: i

    i = 1
    call sub(i)
    print*, "Your compiler have failed to trap this error!"
end program argument_mismatch
