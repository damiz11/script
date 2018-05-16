**********************************
*                                *
*      Trial OPENGL program      *
*                                *
**********************************

      subroutine spinDisplay(spin)
      include <opengl.ins>,nolist
      include <clearwin.ins>,nolist
      double precision spin
      logical do_draw
      common /animate_com/ do_draw

      if (do_draw)then
        call glClear (OR(GL_COLOR_BUFFER_BIT,GL_DEPTH_BUFFER_BIT))
        call glMatrixMode (GL_MODELVIEW)
        call glLoadIdentity()
        call glTranslated(0d0,0d0,-10d0)
        call glRotated(spin,1d0,0d0,0d0)
        call glCallList(101)
        call swap_opengl_buffers()
        spin=spin+2d0
      endif
      call temporary_yield@()
      end

      subroutine spinSlab()
      logical do_draw
      common /animate_com/ do_draw
      data do_draw/.TRUE./
      do_draw=.TRUE.
      end

      subroutine stopSlab()
      logical do_draw
      common /animate_com/ do_draw
      do_draw=.FALSE.
      end

      subroutine assemble_list
      include <clearwin.ins>,nolist
      include <opengl.ins>,nolist

      real*4 white_colour(4), grey_colour(4), dark_grey_colour(4)
      real*4 red_colour(4), yellow_colour(4), green_colour(4)
      real*4 blue_colour(4), purple_colour(4), cyan_colour(4)
      real*8 dimension,scale,d,fd,front,back
      integer flags,k
      integer hdc
      logical ok
      external opengl_proc
      data white_colour/1.0,1.0,1.0,1.0/
      data grey_colour/0.5,0.5,0.5,1.0/
      data dark_grey_colour/0.3,0.3,0.3,1.0/
      data red_colour/1.0,0.0,0.0,1.0/
      data yellow_colour/1.0,1.0,0.0,1.0/
      data green_colour/0.0,1.0,0.0,1.0/
      data blue_colour/0.0,0.0,1.0,1.0/
      data purple_colour/1.0,0.0,1.0,1.0/
      data cyan_colour/0.0,1.0,1.0,1.0/
      data front,back/-0.01d0,-0.5d0/

      call glEnable(GL_DEPTH_TEST)
      hDC=clearwin_info@('OPENGL_DEVICE_CONTEXT')
      call glColor3f(1.0,1.0,1.0)

      ok=wglUseFontOutlines(hDC, 0, 255, 1000, 0.0, 0.1,
     &                     WGL_FONT_POLYGONS,core4(0))
     
      call glMatrixMode (GL_MODELVIEW)
      call glLoadIdentity()
      call glTranslated(0d0,0d0,-10d0)
C
C  Clear the color and depth buffers.
C
      call glClear (OR(GL_COLOR_BUFFER_BIT,GL_DEPTH_BUFFER_BIT))
      dimension=2.2d0
      scale=dimension*0.9d0
      call glDisable(GL_LIGHTING)

      call glNewList(101,GL_COMPILE)
C Front face
      call glBegin(GL_POLYGON)
      call glColor3fv(blue_colour)
      call glVertex3d(-dimension,-dimension,front)
      call glVertex3d(-dimension, dimension,front)
      call glVertex3d( dimension, dimension,front)
      call glVertex3d( dimension,-dimension,front)
      call glEnd()
C Back face                         
      call glBegin(GL_POLYGON)
      call glColor3fv(yellow_colour)
      call glVertex3d(-dimension,-dimension,back)
      call glVertex3d( dimension,-dimension,back)
      call glVertex3d( dimension, dimension,back)
      call glVertex3d(-dimension, dimension,back)
      call glEnd()
C Top face
      call glBegin(GL_POLYGON)
      call glColor3fv(red_colour)
      call glVertex3d(-dimension, dimension,front)
      call glVertex3d(-dimension, dimension,back)
      call glVertex3d( dimension, dimension,back)
      call glVertex3d( dimension, dimension,front)
      call glEnd()
C Bottom face
      call glBegin(GL_POLYGON)
      call glColor3fv(green_colour)
      call glVertex3d( dimension,-dimension,front)
      call glVertex3d( dimension,-dimension,back)
      call glVertex3d(-dimension,-dimension,back)
      call glVertex3d(-dimension,-dimension,front)
      call glEnd()
C
C      Draw graph
C
      call glBegin(GL_LINES)
      call glColor3fv(white_colour)
      call glVertex2d(-scale,0d0)
      call glVertex2d(scale,0d0)
      call glVertex2d(0d0,-scale)
      call glVertex2d(0d0,scale)
      k=-10
      while(k .LE. 10) do
        call glVertex2d((scale/10)*k,0.0d0)
        call glVertex2d((scale/10)*k,0.1d0)
        call glVertex2d(0.0d0,(scale/10)*k)
        call glVertex2d(0.1d0,(scale/10)*k)
        k=k+1
      endwhile
      call glEnd()
      call glColor3fv(red_colour)
      call glBegin(GL_LINE_STRIP)
      d=-10d0
      while(d .LT. 10d0)do
        fd=5*(d/10)**3+3*(d/10)**2-d/10
        call glVertex2d(d*scale/10,fd*scale/10)
        d=d+0.05d0
      endwhile
      call glEnd()
      call glColor3fv(green_colour)
      call glBegin(GL_LINE_STRIP)
      d=-10d0
      while(d .LT. 10)do
        fd=5*(d/10)**3+6*(d/10)**2-d/10
        call glVertex2d(d*scale/10,fd*scale/10)
        d=d+0.05d0
      endwhile
      call glEnd()
      call glColor3fv(red_colour)
      call glListBase (1000)
      call glTranslated(0.15d0,scale*0.95,0d0)
      call glScaled(0.2d0,0.2d0,0.2d0)
      call glCallLists (5, GL_UNSIGNED_BYTE, '+10.0')
      call glEndList()
      end
    
      subroutine myinit()
      call assemble_list()
      end

      subroutine myreshape(w,h)
      include <opengl.ins>,nolist
      integer w
      integer h
      double precision aspect_ratio
                     
      if(h.NE.0)then
        aspect_ratio=dble(w)/h

        call glMatrixMode (GL_PROJECTION)
        call glLoadIdentity ()
        call gluPerspective (30.0d0,aspect_ratio,1d0,15d0)
        call glViewport(0,0,w,h)
      endif

      end

      integer function opengl_proc()
      include <clearwin.ins>,nolist
      include <opengl.ins>,nolist
      integer w,h
      character*256 reason
      reason=clearwin_string@('CALL_BACK_REASON')
      
      if(reason.EQ.'SETUP')then
        call myinit()
      else if(reason.EQ.'RESIZE')then
        w=clearwin_info@('OPENGL_WIDTH')
        h=clearwin_info@('OPENGL_DEPTH')
        call myreshape(w,h)
      else if(reason.EQ.'MOUSE_LEFT_CLICK')then
        call spinSlab()
      else if(reason.EQ.'MOUSE_RIGHT_CLICK')then
        call stopSlab()
      endif
      opengl_proc=2
      end

      program Animate
      include <clearwin.ins>,nolist
      double precision spin
      integer i,window
      integer opengl_proc
      external opengl_proc
      i=winio@('%es%ca[Rotating Slab]&')
      i=winio@('%fn[Times New Roman]%ts&',3.0d0)
      i=winio@('%sp%ww[no_border]%pv%^og[double,depth16]%lw'
     &         ,0,0,650,650,opengl_proc,window)

      spin=0d0
      while(window .LT. 0)do
        call spinDisplay(spin)
      endwhile
      end

