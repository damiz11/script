*                  
*  double.c
*  This program demonstrates double buffering for 
*  flicker-free animation.  The left and middle mouse
*  buttons start and stop the spinning motion of the square.
*

      subroutine display()
      include <opengl.ins>,nolist
      real spin
      logical do_draw
      common /DOUBLE_COM/do_draw,spin
      
      call glClear (GL_COLOR_BUFFER_BIT)

      call glPushMatrix ()
      call glRotatef (spin, 0.0, 0.0, 1.0)
      call glRectf (-25.0, -25.0, 25.0, 25.0)
      call glPopMatrix ()

      call glFlush()
      call swap_opengl_buffers()
      end

      subroutine spinDisplay ()
      include <clearwin.ins>,nolist
      real spin
      logical do_draw
      common /DOUBLE_COM/do_draw,spin

      if(do_draw)then
        spin = spin + 2.0
        if (spin .gt. 360.0)then
           spin = spin - 360.0
        endif
        call display()
      endif
        call temporary_yield@()
      end

      subroutine startIdleFunc ()
      real spin
      logical do_draw
      common /DOUBLE_COM/do_draw,spin
      do_draw=.TRUE.
      end

      subroutine stopIdleFunc ()
      real spin
      logical do_draw
      common /DOUBLE_COM/do_draw,spin
      do_draw=.FALSE.
      end

      subroutine myinit ()
      include <opengl.ins>,nolist
      call glClearColor (0.0, 0.0, 0.0, 1.0)
      call glColor3f (1.0, 1.0, 1.0)
      call glShadeModel (GL_FLAT)
      end

      subroutine myReshape(w, h)
      include <opengl.ins>,nolist
      integer w,h
      double precision aspect_ratio
      if (h.NE.0) then
         aspect_ratio=real(w)/h

         call glViewport(0, 0, w, h)
         call glMatrixMode(GL_PROJECTION)
         call glLoadIdentity()
         if (w .LE. h) then 
             call glOrtho (-50d0, 50d0, -50d0/aspect_ratio, 
     &                      50d0/aspect_ratio, -1d0, 1d0)
         else 
             call glOrtho (-50d0*aspect_ratio, 
     &                      50d0*aspect_ratio, -50d0, 50d0, -1d0, 1d0)
         endif
         call glMatrixMode(GL_MODELVIEW)
         call glLoadIdentity ()
      endif
      end


      integer function opengl_proc()
      include <clearwin.ins>,nolist
      character*256 reason
      integer w,h
      reason=clearwin_string@('CALL_BACK_REASON')
      if(reason.eq.'SETUP')then
        call myinit()
      else if(reason.eq.'RESIZE')then
        w=clearwin_info@('OPENGL_WIDTH')
        h=clearwin_info@('OPENGL_DEPTH')
        call myReshape(w,h)
      else if(reason.eq.'DIRTY')then
        call display()
      else if(reason.eq.'MOUSE_LEFT_CLICK')then
        call startIdleFunc()
      else if(reason.eq.'MOUSE_RIGHT_CLICK')then
        call stopIdleFunc()
      end if
 
      opengl_proc=2
      end

      program double
      include <clearwin.ins>,nolist
      integer i
      integer opengl_proc,window
      external opengl_proc
      real spin
      logical do_draw
      common /double_com/do_draw,spin
      data spin,do_draw/0.0,.TRUE./

      i=winio@('%es%ca[Double Buffering]&')
      i=winio@('%sp%ww[no_border]%pv%^og[double]%lw'
     &      ,0, 0, 500, 500,opengl_proc,window)

      while(window.LT.0)do
         call spinDisplay()
      endwhile

      end

