*  stencil.c                        
*  This program draws two rotated tori in a window.
*  A diamond in the center of the window masks out part
*  of the scene.  Within this mask, a different model
*  (a sphere) is drawn in a different color.
*
      subroutine myinit()
      include <opengl.ins>,nolist
      real yellow_diffuse(4)
      real yellow_specular(4)

      real blue_diffuse(4)
      real blue_specular(4)

      real position_one(4)

      integer YELLOWMAT
      integer BLUEMAT
      parameter(YELLOWMAT = 1)
      parameter(BLUEMAT = 2)

      data yellow_diffuse  / 0.7, 0.7, 0.0, 1.0 /
      data yellow_specular / 1.0, 1.0, 1.0, 1.0 /

      data blue_diffuse    / 0.1, 0.1, 0.7, 1.0 /
      data blue_specular   / 0.1, 1.0, 1.0, 1.0 /

      data position_one    / 1.0, 1.0, 1.0, 0.0 /


      call glNewList(YELLOWMAT, GL_COMPILE)
      call glMaterialfv(GL_FRONT, GL_DIFFUSE, yellow_diffuse)
      call glMaterialfv(GL_FRONT, GL_SPECULAR, yellow_specular)
      call glMaterialf(GL_FRONT, GL_SHININESS, 64.0)
      call glEndList()

      call glNewList(BLUEMAT, GL_COMPILE)
      call glMaterialfv(GL_FRONT, GL_DIFFUSE, blue_diffuse)
      call glMaterialfv(GL_FRONT, GL_SPECULAR, blue_specular)
      call glMaterialf(GL_FRONT, GL_SHININESS, 45.0)
      call glEndList()

      call glLightfv(GL_LIGHT0, GL_POSITION, position_one)

      call glEnable(GL_LIGHT0)
      call glEnable(GL_LIGHTING)
      call glDepthFunc(GL_LESS)
      call glEnable(GL_DEPTH_TEST)

      call glClearStencil(z'0')
      call glEnable(GL_STENCIL_TEST)

      end

*  Draw a sphere in a diamond-shaped section in the
*  middle of a window with 2 tori.
*
      subroutine display()
      include <opengl.ins>,nolist

      integer YELLOWMAT
      integer BLUEMAT
      parameter(YELLOWMAT = 1)
      parameter(BLUEMAT = 2)

      call glClear(OR(GL_COLOR_BUFFER_BIT,GL_DEPTH_BUFFER_BIT))

* draw blue sphere where the stencil is 1 */
      call glStencilFunc (GL_EQUAL, z'1', z'1')
      call glCallList (BLUEMAT)
      call auxSolidSphere (0.5d0)

* draw the tori where the stencil is not 1 */
      call glStencilFunc (GL_NOTEQUAL, z'1', z'1')
      call glStencilOp (GL_KEEP, GL_KEEP, GL_KEEP)
      call glPushMatrix()
      call glRotatef (45.0, 0.0, 0.0, 1.0)
      call glRotatef (45.0, 0.0, 1.0, 0.0)
      call glCallList (YELLOWMAT)
      call auxSolidTorus (0.275d0, 0.85d0)
      call glPushMatrix()
      call glRotatef (90.0, 1.0, 0.0, 0.0)
      call auxSolidTorus (0.275d0, 0.85d0)
      call glPopMatrix()
      call glPopMatrix()
      call glFlush()
      end

*  Whenever the window is reshaped, redefine the
*  coordinate system and redraw the stencil area.
*
      subroutine myReshape(w,h)
      include <opengl.ins>,nolist

      integer w,h
      double precision aspect_ratio
      if (h.ne.0) then
          aspect_ratio=dble(w)/h
          call glViewport(0, 0, w, h)

          call glClear(GL_STENCIL_BUFFER_BIT)
* create a diamond shaped stencil area *
          call glMatrixMode(GL_PROJECTION)
          call glLoadIdentity()
          call glOrtho(-3d0, 3d0, -3d0, 3d0, -1d0, 1d0)
          call glMatrixMode(GL_MODELVIEW)
          call glLoadIdentity()

          call glStencilFunc (GL_ALWAYS, z'1', z'1')
          call glStencilOp (GL_REPLACE, GL_REPLACE, GL_REPLACE)
          call glBegin(GL_QUADS)
          call glVertex3f (-1.0, 0.0, 0.0)
          call glVertex3f (0.0, 1.0, 0.0)
          call glVertex3f (1.0, 0.0, 0.0)
          call glVertex3f (0.0, -1.0, 0.0)
          call glEnd()

          call glMatrixMode(GL_PROJECTION)
          call glLoadIdentity()
          call gluPerspective(45d0, aspect_ratio, 3d0, 7d0)
          call glMatrixMode(GL_MODELVIEW)
          call glLoadIdentity()
          call glTranslatef(0.0, 0.0, -5.0)
      endif
      end

      integer function opengl_proc()
      include <clearwin.ins>,nolist
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

      program Stencil
      include <clearwin.ins>,nolist
      integer i
      integer opengl_proc
      external opengl_proc
      i=winio@('%es%ca[Stencil Test]&')
      i=winio@('%sp%ww[no_border]%pv%^og[depth16,stencil]'
     +      ,0,0,400,400,opengl_proc)
      end

