!
!   This program illustrates how CHECKMATE can be used to trap
!   the use of uninitialised data within a subroutine.  This is
!   particularly difficult case to catch because the progam uses
!   assumed size array in the subroutine argument list.
!
!   Copyright (C) Salford Software Ltd 1998.
!
!   Compile this program using the command line:
!       FTN95 array.f90 /check /link /undef
!
subroutine sub(a)
    integer :: a(*)
    integer :: i

    i = a(2)            ! a(2) has not been set at this point.
end subroutine sub

!
!   Main program.
!
program uninitialised_array
    integer :: array(20)

    call sub(array)
    print*, "Your compiler have failed to trap this error!"
end program uninitialised_array
