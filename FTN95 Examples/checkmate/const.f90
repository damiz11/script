!
!   This program illustrates how CHECKMATE can be used to trap
!   the programmers attempt to modify constant data.
!
!   Copyright (C) Salford Software Ltd 1998.
!
!   Compile this program using the command line:
!       FTN95 const.f90 /check /link /undef
!
subroutine sub(c)
    integer :: c

    c = 1
end subroutine sub

!
!   Main program.
!
program constant_data
    integer, parameter :: c = 5

    call sub(c)
    print*, "Your compiler have failed to trap this error!"
end program constant_data
