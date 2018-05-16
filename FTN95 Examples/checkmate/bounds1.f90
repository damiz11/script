!
!   This program illustrates how CHECKMATE can be used to trap
!   simple array bounds violations.
!
!   Copyright (C) Salford Software Ltd 1998.
!
!   Compile this program using the command line:
!       FTN95 bounds1.f90 /check /link /undef
!
program simple_bounds
    integer :: array(20), counter

    do counter = 1, 21
        array(counter) = counter
    end do
    print*, "Your compiler have failed to trap this error!"
end program simple_bounds
