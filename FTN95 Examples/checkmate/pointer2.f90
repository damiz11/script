!
!   This program illustrates how CHECKMATE can be used to trap
!   the illegal access of elements in local storage after they
!   have been deallocated.
!
!   Copyright (C) Salford Software Ltd 1998.
!
!   Compile this program using the command line:
!       FTN95 pointer2.f90 /check /link /undef
!
!
program pointer_deallocation
    integer, pointer :: p2(:)

    call local_allocation
    p2 = 10
    print*, "Your compiler have failed to trap this error!"

  contains
    subroutine local_allocation
        integer, target :: p1(10)

        p2 => p1
        p1 = 0
    end subroutine local_allocation
end program pointer_deallocation


