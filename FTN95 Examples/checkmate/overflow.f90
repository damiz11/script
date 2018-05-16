!
!   This program illustrates how CHECKMATE can be used to trap
!   arithmetic overflows.
!
!   Copyright (C) Salford Software Ltd 1998.
!
!   Compile this program using the command line:
!       FTN95 overflow.f90 /check /link /undef
!
program overflow
    integer :: i

    i = 1
    while (i > 0) do
        i = i * 10
    end while
    print*, "Your compiler have failed to trap this error!"
end program overflow
