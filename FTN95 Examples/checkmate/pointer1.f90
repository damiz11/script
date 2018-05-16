!
!   This program illustrates how CHECKMATE can be used to trap
!   the illegal access of allocated objects after they have been
!   deallocated.
!
!   Copyright (C) Salford Software Ltd 1998.
!
!   Compile this program using the command line:
!       FTN95 pointer1.f90 /check /link /undef
!
!
program pointer_deallocation
    integer, allocatable :: p1(:)
    integer, pointer :: p2(:)

    allocate(p1(10))
    p2 => p1
    call destroy
    p2 = 10
    print*, "Your compiler have failed to trap this error!"

  contains
    subroutine destroy
        deallocate(p1)
    end subroutine destroy
end program pointer_deallocation


