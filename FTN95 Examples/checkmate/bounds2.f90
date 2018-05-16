!
!   This program illustrates how CHECKMATE can be used to trap
!   the violation of the bounds of an array within a called subroutine.
!   This is particularly difficult case to catch because the progam uses
!   assumed size array in the subroutine argument list.
!
!   Copyright (C) Salford Software Ltd 1998.
!
!   Compile this program using the command line:
!       FTN95 bounds2.f90 /check /link /undef
!
subroutine sub(a)
    integer :: a(*)
    integer :: counter

    do counter = 10, 30
        a(counter) = counter
    end do
end subroutine sub

!
!   Main program.
!
program complex_bounds
    integer :: array(20)

    call sub(array)
    print*, "Your compiler have failed to trap this error!"
end program complex_bounds
