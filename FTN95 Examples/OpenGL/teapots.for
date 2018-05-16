      winapp
*                  
*  teapots.c
*  This program demonstrates lots of material properties.
*  A single light source illuminates the objects.
*

*  Initialize depth buffer, projection matrix, light source,
*  and lighting model.  Do not specify a material property here.
*
      subroutine myinit()
      include <opengl.ins>,nolist
      real ambient(4)
      real diffuse(4)
      real specular(4)
      real position(4)

      real lmodel_ambient(4)
      real local_view

      data ambient  /0.0, 0.0, 0.0, 1.0 /
      data diffuse  /1.0, 1.0, 1.0, 1.0 /
      data specular /1.0, 1.0, 1.0, 1.0 /
      data position /0.0, 3.0, 3.0, 0.0 /

      data lmodel_ambient / 0.2, 0.2, 0.2, 1.0/
      data local_view / 0.0 /

      call glLightfv(GL_LIGHT0, GL_AMBIENT, ambient)
      call glLightfv(GL_LIGHT0, GL_DIFFUSE, diffuse)
      call glLightfv(GL_LIGHT0, GL_POSITION, position)
      call glLightModelfv(GL_LIGHT_MODEL_AMBIENT, lmodel_ambient)
      call glLightModelfv(GL_LIGHT_MODEL_LOCAL_VIEWER, local_view)

      call glFrontFace (GL_CW)
      call glEnable(GL_LIGHTING)
      call glEnable(GL_LIGHT0)
      call glEnable(GL_AUTO_NORMAL)
      call glEnable(GL_NORMALIZE)
      call glEnable(GL_DEPTH_TEST)
      call glDepthFunc(GL_LESS)
      end

*  Move object into position.  Use 3rd through 12th parameters
*  to specify the material property.  Draw a teapot.
*
      subroutine renderTeapot ( x,  y,
     +                         ambr,  ambg,  ambb,
     +                         difr,  difg,  difb,
     +                         specr,  specg,  specb,  shine)

      include <clearwin.ins>,nolist
      include <opengl.ins>,nolist
      real x,  y
      real ambr,  ambg,  ambb
      real difr,  difg,  difb
      real specr,  specg,  specb,  shine
      real mat(4)

      call glPushMatrix()
      call glTranslatef (x, y, 0.0)
      mat(1) = ambr
      mat(2) = ambg
      mat(3) = ambb
      mat(4) = 1.0
      call glMaterialfv (GL_FRONT, GL_AMBIENT, mat)
      mat(1) = difr
      mat(2) = difg
      mat(3) = difb
      call glMaterialfv (GL_FRONT, GL_DIFFUSE, mat)
      mat(1) = specr
      mat(2) = specg
      mat(3) = specb
      call glMaterialfv (GL_FRONT, GL_SPECULAR, mat)
      call glMaterialf (GL_FRONT, GL_SHININESS, shine*128.0)
      call auxSolidTeapot(1d0)
      call glPopMatrix()
      end

*  First column:  emerald, jade, obsidian, pearl, ruby, turquoise
*  2nd column:  brass, bronze, chrome, copper, gold, silver
*  3rd column:  black, cyan, green, red, white, yellow plastic
*  4th column:  black, cyan, green, red, white, yellow rubber
*
      subroutine display()
      include <opengl.ins>,nolist
      call glClear(OR(GL_COLOR_BUFFER_BIT,GL_DEPTH_BUFFER_BIT))
      call renderTeapot (2.0, 17.0, 0.0215, 0.1745, 0.0215,
     &   0.07568, 0.61424, 0.07568, 0.633, 0.727811, 0.633, 0.6)
      call renderTeapot (2.0, 14.0, 0.135, 0.2225, 0.1575,
     &   0.54, 0.89, 0.63, 0.316228, 0.316228, 0.316228, 0.1)
      call renderTeapot (2.0, 11.0, 0.05375, 0.05, 0.06625,
     &   0.18275, 0.17, 0.22525, 0.332741, 0.328634, 0.346435, 0.3)
      call renderTeapot (2.0, 8.0, 0.25, 0.20725, 0.20725,
     &   1.0, 0.829, 0.829, 0.296648, 0.296648, 0.296648, 0.088)
      call renderTeapot (2.0, 5.0, 0.1745, 0.01175, 0.01175,
     &   0.61424, 0.04136, 0.04136, 0.727811, 0.626959, 0.626959, 0.6)
      call renderTeapot (2.0, 2.0, 0.1, 0.18725, 0.1745,
     &   0.396, 0.74151, 0.69102, 0.297254, 0.30829, 0.306678, 0.1)
      call renderTeapot (6.0, 17.0, 0.329412, 0.223529, 0.027451,
     &   0.780392, 0.568627, 0.113725, 0.992157, 0.941176, 0.807843,
     &   0.21794872)
      call renderTeapot (6.0, 14.0, 0.2125, 0.1275, 0.054,
     &   0.714, 0.4284, 0.18144, 0.393548, 0.271906, 0.166721, 0.2)
      call renderTeapot (6.0, 11.0, 0.25, 0.25, 0.25,
     &   0.4, 0.4, 0.4, 0.774597, 0.774597, 0.774597, 0.6)
      call renderTeapot (6.0, 8.0, 0.19125, 0.0735, 0.0225,
     &   0.7038, 0.27048, 0.0828, 0.256777, 0.137622, 0.086014, 0.1)
      call renderTeapot (6.0, 5.0, 0.24725, 0.1995, 0.0745,
     &   0.75164, 0.60648, 0.22648, 0.628281, 0.555802, 0.366065, 0.4)
      call renderTeapot (6.0, 2.0, 0.19225, 0.19225, 0.19225,
     &   0.50754, 0.50754, 0.50754, 0.508273, 0.508273, 0.508273, 0.4)
      call renderTeapot (10.0, 17.0, 0.0, 0.0, 0.0, 0.01, 0.01, 0.01,
     &   0.50, 0.50, 0.50, .25)          
      call renderTeapot (10.0, 14.0, 0.0, 0.1, 0.06, 0.0, 0.50980392,
     &    0.50980392, 0.50196078, 0.50196078, 0.50196078, .25)
      call renderTeapot (10.0, 11.0, 0.0, 0.0, 0.0,
     &   0.1, 0.35, 0.1, 0.45, 0.55, 0.45, .25)
      call renderTeapot (10.0, 8.0, 0.0, 0.0, 0.0, 0.5, 0.0, 0.0,
     &   0.7, 0.6, 0.6, .25)
      call renderTeapot (10.0, 5.0, 0.0, 0.0, 0.0, 0.55, 0.55, 0.55,
     &   0.70, 0.70, 0.70, .25)
      call renderTeapot (10.0, 2.0, 0.0, 0.0, 0.0, 0.5, 0.5, 0.0,
     &   0.60, 0.60, 0.50, .25)
      call renderTeapot (14.0, 17.0, 0.02, 0.02, 0.02, 0.01, 0.01, 0.01,
     &   0.4, 0.4, 0.4, .078125)
      call renderTeapot (14.0, 14.0, 0.0, 0.05, 0.05, 0.4, 0.5, 0.5,
     &   0.04, 0.7, 0.7, .078125)
      call renderTeapot (14.0, 11.0, 0.0, 0.05, 0.0, 0.4, 0.5, 0.4,
     &   0.04, 0.7, 0.04, .078125)
      call renderTeapot (14.0, 8.0, 0.05, 0.0, 0.0, 0.5, 0.4, 0.4,
     &   0.7, 0.04, 0.04, .078125)
      call renderTeapot (14.0, 5.0, 0.05, 0.05, 0.05, 0.5, 0.5, 0.5,
     &   0.7, 0.7, 0.7, .078125)
      call renderTeapot (14.0, 2.0, 0.05, 0.05, 0.0, 0.5, 0.5, 0.4,
     &   0.7, 0.7, 0.04, .078125)
      call glFlush()
      end

      subroutine myReshape(w, h)
      include <opengl.ins>,nolist
      integer w,h
      double precision aspect_ratio
      if (h.ne.0) then
        aspect_ratio=real(w)/h
        call glViewport(0, 0, w, h)
        call glMatrixMode(GL_PROJECTION)
        call glLoadIdentity()
        if (w .LE. h) then
          call glOrtho (0d0, 16d0, 0d0, 16d0/aspect_ratio,
     &       -10d0, 10d0)
        else
          call glOrtho (0d0, 16d0*aspect_ratio, 0d0, 16d0,
     &       -10d0, 10d0)
        endif
        call glMatrixMode(GL_MODELVIEW)
      endif
      end


      integer function opengl_proc()
      include <clearwin.ins>,nolist
      character*256 reason
      integer w,h
      logical redraw,resize
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

      program Teapots
      include <clearwin.ins>,nolist
      integer i
      integer opengl_proc
      external opengl_proc
      i=winio@('%es%ca[Material Properties]&')
      i=winio@('%sp%ww[no_border]%pv%^og[depth16]',
     +      0,0,500,600,opengl_proc)
      end

