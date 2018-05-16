!
!   This program illustrates how CHECKMATE can be used to trap
!   inconsistent use of subprograms.
!
!   Copyright (C) Salford Software Ltd 1998.
!
!   Compile this program using the command line:
!       FTN95 func2.f90 /check /link /undef
!
program function_test
    integer :: sub2
    external sub2
    
    call sub1(sub2)
    print*, "Your compiler have failed to trap this error!"
                         
  contains
    subroutine sub1(func)
        integer :: func
        integer :: x, y

        y = func(x)
    end

    subroutine sub2(x)
        integer :: x

        x = 1
    end
end program function_test
