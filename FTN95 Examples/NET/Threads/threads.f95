!  Salford Software FTN95 .NET for Visual Studio .NET
!  --------------------------------------------------
!  Free Format FTN95 Source File
!
!    Filename: threads.f95
!    Author: Silverfrost
!    Date Modified: 18/12/2003
!    Notes: See the documentation for details
!  --------------------------------------------------

module thread_control
   type thread_type
      double precision threadbar
      logical running
      logical stopping
      integer start_button_enabled
      integer stop_button_enabled
   end type thread_type
   type (thread_type) thread(3)
end module thread_control

winapp
   use thread_control
   include <clearwin.ins>
   external start_thread1, start_thread2, start_thread3
   integer start_thread1, start_thread2, start_thread3
   external stop_thread1, stop_thread2, stop_thread3
   integer stop_thread1, stop_thread2, stop_thread3
   external close_window
   integer close_window
   integer k

   do k = 1, 3
      thread(k)%threadbar = 0
      thread(k)%running = .false.
      thread(k)%stopping = .false.
      thread(k)%start_button_enabled = 1
      thread(k)%stop_button_enabled = 0
   end do

   k = winio@ ("%ca[Creating threads]%sy[3d_thin]&")
   k = winio@ ("%80.20cw%ff%nl&", 0)
   k = winio@ ("%cn%^~bt[Start thread 1] %50br %^~bt[Stop thread 1]%nl&", &
    & thread(1)%start_button_enabled, start_thread1, thread(1)%threadbar, RGB@(255,0,0), &
    & thread(1)%stop_button_enabled, stop_thread1)
   k = winio@ ("%cn%^~bt[Start thread 2] %50br %^~bt[Stop thread 2]%nl&", &
    & thread(2)%start_button_enabled, start_thread2, thread(2)%threadbar, RGB@(0,255,0), &
    & thread(2)%stop_button_enabled, stop_thread2)
   k = winio@ ("%cn%^~bt[Start thread 3] %50br %^~bt[Stop thread 3]%nl&", &
    & thread(3)%start_button_enabled, start_thread3, thread(3)%threadbar, RGB@(0,0,255), &
    & thread(3)%stop_button_enabled, stop_thread3)
   k = winio@ ("%cn%bt[OK]%cc", close_window)
end

subroutine thread_proc(k)
   use thread_control
   include <clearwin.ins>
   assembly_external (name="System.Threading.Thread.Sleep") thread_sleep
   data num_iterations/500/

   thread(k)%running = .true.
   thread(k)%stopping = .false.
   thread(k)%start_button_enabled = 0
   thread(k)%stop_button_enabled = 1
   lock
      call window_update@(thread(k)%start_button_enabled)
      call window_update@(thread(k)%stop_button_enabled)
   end lock
   do m = 1, num_iterations
      thread(k)%threadbar = real(m) / real(num_iterations)
      !  Because the print will operate to the same IO unit in several
      !  threads we must execute only one of these at once
      lock
         print *, "Thread ", k, "   ::   line ", m, " / ", num_iterations
         call window_update@(thread(k)%threadbar)
      end lock
      if (thread(k)%stopping) exit
      call thread_sleep(50)
   enddo
   thread(k)%start_button_enabled = 1
   thread(k)%stop_button_enabled = 0
   lock
      call window_update@(thread(k)%start_button_enabled)
      call window_update@(thread(k)%stop_button_enabled)
   endlock
   thread(k)%running = .false.
end

! callback functions for starting the threads
integer function start_thread1()
   use thread_control
   external thread_proc
   object ("System.Threading.Thread") threadObject
   call create_thread1@ (thread_proc, 1, threadObject)
   start_thread1 = 2
end
integer function start_thread2()
   use thread_control
   external thread_proc
   object ("System.Threading.Thread") threadObject
   call create_thread1@ (thread_proc, 2, threadObject)
   start_thread2 = 2
end
integer function start_thread3()
   use thread_control
   external thread_proc
   object ("System.Threading.Thread") threadObject
   call create_thread1@ (thread_proc, 3, threadObject)
   start_thread3 = 2
end

! callback functions for stopping the threads
integer function stop_thread1()
   use thread_control
   thread(1)%stopping = .true.
   stop_thread1 = 2
end
integer function stop_thread2()
   use thread_control
   thread(2)%stopping = .true.
   stop_thread2 = 2
end
integer function stop_thread3()
   use thread_control
   thread(3)%stopping = .true.
   stop_thread3 = 2
end

integer function close_window()
   use thread_control
   assembly_external (name="System.Threading.Thread.Sleep") thread_sleep
   integer k
   if (thread(1)%running .or. thread(2)%running .or. thread(3)%running) then
      ! tell all threads to stop
      do k = 1, 3
         thread(k)%stopping = .true.
      end do
      ! wait for the threads to stop
      while (thread(1)%running .or. thread(2)%running .or. thread(3)%running) do
         call thread_sleep(50)
      end while
   endif
   close_window = 0
end