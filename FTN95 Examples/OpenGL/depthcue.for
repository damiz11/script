C
C     *****************************************************
C     *                                                   *
C     *    Modified from depthcue.c                       *
C     *    (c) Copyright 1993, Silicon Graphics, Inc.     *
C     *    (c) Copyright 1998, Salford Software Ltd.      *
C     *                                                   *
C     *****************************************************
C
C
C     ************************************************************
C     *                                                          *
C     *    depthcue.for                                          *
C     *    This program draws a wireframe model, which uses      *
C     *    intensity (brightness) to give clues to distance.     *
C     *    Fog is used to achieve this effect.                   *
C     *                                                          *
C     ************************************************************
C
      subroutine myinit()
      include <opengl.ins>
      real fogColor(4)
      data fogColor /0.0, 0.0, 0.0, 1.0/

C  Initialize linear fog for depth cueing.
        call glMatrixMode (GL_MODELVIEW)
        call glEnable(GL_FOG)
        call glFogi (GL_FOG_MODE, GL_LINEAR)
        call glHint (GL_FOG_HINT, GL_NICEST) !  /*  per pixel   */
        call glFogf (GL_FOG_START, 3.0)
        call glFogf (GL_FOG_END, 5.0)
        call glFogfv (GL_FOG_COLOR, fogColor)
        call glClearColor(0.0, 0.0, 0.0, 1.0)
        call glDepthFunc(GL_LESS)
        call glEnable(GL_DEPTH_TEST)
        call glShadeModel(GL_FLAT)
      end

      subroutine display()
      include <opengl.ins>

      call glClear(OR(GL_COLOR_BUFFER_BIT, GL_DEPTH_BUFFER_BIT))
      call glColor3f (1.0, 1.0, 1.0)
      call auxWireIcosahedron(1d0)
      call glFlush()

      end

      subroutine myReshape(w,h)
      include <opengl.ins>
      integer w,h
      double precision aspect_ratio
      if (h.ne.0) then

          aspect_ratio=dble(w)/h
          call glViewport(0, 0, w, h)
          call glMatrixMode(GL_PROJECTION)
          call glLoadIdentity()
          call gluPerspective (45d0, aspect_ratio, 3d0, 5d0)
          call glMatrixMode(GL_MODELVIEW)
          call glLoadIdentity ()
          call glTranslatef (0.0, 0.0, -4.0)  ! move object into view
          call glViewport(0,0,w,h)

      end if             
      end

      integer function opengl_proc()
      include <clearwin.ins>
      integer w,h
      character*256 reason
      reason=clearwin_string@('CALL_BACK_REASON')
      if(reason.eq.'SETUP')then
        call myinit()
      else if(reason.eq.'RESIZE')then
        w=clearwin_info@('OPENGL_WIDTH')
        h=clearwin_info@('OPENGL_DEPTH')
        call myReshape(w,h)
      else if(reason.eq.'DIRTY')then
        call display()
      end if
      opengl_proc=2
      end

      program depthcue
      include <clearwin.ins>
      integer i
      integer opengl_proc
      external opengl_proc
      i=winio@('%es%ca[Distance Using Fog]&')
      i=winio@('%sp%ww[no_border]%pv%^og[depth16]',
     +      0,0,400,400,opengl_proc)
      end
