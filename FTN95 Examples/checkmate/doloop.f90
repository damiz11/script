!
!   This program illustrates how CHECKMATE can be used to trap
!   the execution of a do loop with an increment value of zero.
!
!   Copyright (C) Salford Software Ltd 1998.
!
!   Compile this program using the command line:
!       FTN95 doloop.f90 /check /link /undef
!
program zero_trip_do_loop
    integer :: inc

    inc = 0
    call sub(inc)
    print*, "Your compiler have failed to trap this error!"

  contains
    subroutine sub(increment)
        integer :: s, increment

        s = 0
        do i = 1, 5, increment
          s = s + i
        end do
    end subroutine
end program zero_trip_do_loop
