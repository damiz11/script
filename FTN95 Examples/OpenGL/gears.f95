! $Id: gears.c,v 1.2 1999/10/21 16:39:06 brianp Exp $ 

!
! * 3-D gear wheels.  This program is in the public domain.
! *
! * Command line options:
! *    -info      print GL implementation information
! *
! *
! * Brian Paul
! 

! Conversion to GLUT by Mark J. Kilgard 

!
! * $Log: gears.c,v $
! * Revision 1.2  1999/10/21 16:39:06  brianp
! * added -info command line option
! *
! * Revision 1.1.1.1  1999/08/19 00:55:40  jtg
! * Imported sources
! *
! * Revision 3.2  1999/06/03 17:07:36  brianp
! * an extra quad was being drawn in front and back faces
! *
! * Revision 3.1  1998/11/03 02:49:10  brianp
! * added fps output
! *
! * Revision 3.0  1998/02/14 18:42:29  brianp
! * initial rev
! *
! 

module mymod
   integer, parameter :: rkind2 = selected_real_kind(15, 307)
   integer, parameter :: rkind1 = selected_real_kind(6, 37)
   real (kind = rkind2), parameter :: M_PI = 3.14159265
   real (kind = rkind1) :: view_rotx, view_roty, view_rotz, angle
   integer :: gear1, gear2, gear3, mx, my, w1, w2, ctrl
   real (kind = rkind2) :: camx, camy, camz
end module mymod

!*
!
!  Draw a gear wheel.  You'll probably want to call this function when
!  building a display list since we do a lot of trig here.
! 
!  Input:  inner_radius - radius of hole at center
!          outer_radius - radius at center of teeth
!          width - width of gear
!          teeth - number of teeth
!          tooth_depth - depth of tooth
!
! *

subroutine gear(inner_radius, outer_radius, width, teeth, tooth_depth)
  use mymod
  include <opengl.ins>, nolist
  real (kind = rkind1) :: inner_radius, outer_radius, width, tooth_depth
  integer :: teeth

  integer :: i
  real (kind = rkind1) :: r0, r1, r2
  real (kind = rkind1) :: angle1, da
  real (kind = rkind1) :: u, v, length

  r0 = inner_radius
  r1 = outer_radius - tooth_depth / 2.0
  r2 = outer_radius + tooth_depth / 2.0

  da = 2.0 * M_PI / teeth / 4.0

  call glShadeModel(GL_FLAT)

  call glNormal3f(0.0, 0.0, 1.0)

  ! draw front face 
  call glBegin(GL_QUAD_STRIP)
  do i = 0, teeth
    angle1 = i * 2.0 * M_PI / teeth
    call glVertex3f(r0 * cos(angle1), r0 * sin(angle1), width * 0.5)
    call glVertex3f(r1 * cos(angle1), r1 * sin(angle1), width * 0.5)
    if (i .LT. teeth) then
      call glVertex3f(r0 * cos(angle1), r0 * sin(angle1), width * 0.5)
      call glVertex3f(r1 * cos(angle1 + 3 * da), r1 * sin(angle1 + 3 * da), width * 0.5)
    end if
  end do
  call glEnd()

  ! draw front sides of teeth 
  call glBegin(GL_QUADS)
  da = 2.0 * M_PI / teeth / 4.0
  do i = 0, teeth - 1
    angle1 = i * 2.0 * M_PI / teeth

    call glVertex3f(r1 * cos(angle1), r1 * sin(angle1), width * 0.5)
    call glVertex3f(r2 * cos(angle1 + da), r2 * sin(angle1 + da), width * 0.5)
    call glVertex3f(r2 * cos(angle1 + 2 * da), r2 * sin(angle1 + 2 * da), width * 0.5)
    call glVertex3f(r1 * cos(angle1 + 3 * da), r1 * sin(angle1 + 3 * da), width * 0.5)
  end do
  call glEnd()

  call glNormal3f(0.0, 0.0, -1.0)

  ! draw back face 
  call glBegin(GL_QUAD_STRIP)
  do i = 0, teeth
    angle1 = i * 2.0 * M_PI / teeth
    call glVertex3f(r1 * cos(angle1), r1 * sin(angle1), -width * 0.5)
    call glVertex3f(r0 * cos(angle1), r0 * sin(angle1), -width * 0.5)
    if (i .LT. teeth) then
      call glVertex3f(r1 * cos(angle1 + 3 * da), r1 * sin(angle1 + 3 * da), -width * 0.5)
      call glVertex3f(r0 * cos(angle1), r0 * sin(angle1), -width * 0.5)
    end if
  end do
  call glEnd()

  ! draw back sides of teeth 
  call glBegin(GL_QUADS)
  da = 2.0 * M_PI / teeth / 4.0
  do i = 0, teeth - 1
    angle1 = i * 2.0 * M_PI / teeth

    call glVertex3f(r1 * cos(angle1 + 3 * da), r1 * sin(angle1 + 3 * da), -width * 0.5)
    call glVertex3f(r2 * cos(angle1 + 2 * da), r2 * sin(angle1 + 2 * da), -width * 0.5)
    call glVertex3f(r2 * cos(angle1 + da), r2 * sin(angle1 + da), -width * 0.5)
    call glVertex3f(r1 * cos(angle1), r1 * sin(angle1), -width * 0.5)
  end do
  call glEnd()

  ! draw outward faces of teeth 
  call glBegin(GL_QUAD_STRIP)
  do i = 0, teeth - 1
    angle1 = i * 2.0 * M_PI / teeth

    call glVertex3f(r1 * cos(angle1), r1 * sin(angle1), width * 0.5)
    call glVertex3f(r1 * cos(angle1), r1 * sin(angle1), -width * 0.5)
    u = r2 * cos(angle1 + da) - r1 * cos(angle1)
    v = r2 * sin(angle1 + da) - r1 * sin(angle1)
    length = sqrt(u * u + v * v)
    u = u / length
    v = v / length
    call glNormal3f(v, -u, 0.0)
    call glVertex3f(r2 * cos(angle1 + da), r2 * sin(angle1 + da), width * 0.5)
    call glVertex3f(r2 * cos(angle1 + da), r2 * sin(angle1 + da), -width * 0.5)
    call glNormal3f(cos(angle1), sin(angle1), 0.0)
    call glVertex3f(r2 * cos(angle1 + 2 * da), r2 * sin(angle1 + 2 * da), width * 0.5)
    call glVertex3f(r2 * cos(angle1 + 2 * da), r2 * sin(angle1 + 2 * da), -width * 0.5)
    u = r1 * cos(angle1 + 3 * da) - r2 * cos(angle1 + 2 * da)
    v = r1 * sin(angle1 + 3 * da) - r2 * sin(angle1 + 2 * da)
    call glNormal3f(v, -u, 0.0)
    call glVertex3f(r1 * cos(angle1 + 3 * da), r1 * sin(angle1 + 3 * da), width * 0.5)
    call glVertex3f(r1 * cos(angle1 + 3 * da), r1 * sin(angle1 + 3 * da), -width * 0.5)
    call glNormal3f(cos(angle1), sin(angle1), 0.0)
  end do

  call glVertex3f(r1 * cos(0.0), r1 * sin(0.0), width * 0.5)
  call glVertex3f(r1 * cos(0.0), r1 * sin(0.0), -width * 0.5)

  call glEnd()

  call glShadeModel(GL_SMOOTH)

  ! draw inside radius cylinder 
  call glBegin(GL_QUAD_STRIP)
  do i = 0, teeth
    angle1 = i * 2.0 * M_PI / teeth
    call glNormal3f(-cos(angle1), -sin(angle1), 0.0)
    call glVertex3f(r0 * cos(angle1), r0 * sin(angle1), -width * 0.5)
    call glVertex3f(r0 * cos(angle1), r0 * sin(angle1), width * 0.5)
  end do
  call glEnd()
  
end subroutine gear


integer function draw()
  use mymod
  include <opengl.ins>, nolist
  
  call glClear(ior(GL_COLOR_BUFFER_BIT, GL_DEPTH_BUFFER_BIT))

  call glPushMatrix()
  call glRotatef(view_rotx, 1.0, 0.0, 0.0)
  call glRotatef(view_roty, 0.0, 1.0, 0.0)
  call glRotatef(view_rotz, 0.0, 0.0, 1.0)

  call glPushMatrix()
  call glTranslatef(-3.0, -2.0, 0.0)
  call glRotatef(angle, 0.0, 0.0, 1.0)
  call glCallList(gear1)
  call glPopMatrix()

  call glPushMatrix()
  call glTranslatef(3.1, -2.0, 0.0)
  call glRotatef(-2.0 * angle - 9.0, 0.0, 0.0, 1.0)
  call glCallList(gear2)
  call glPopMatrix()

  call glPushMatrix()
  call glTranslatef(-3.1, 4.2, 0.0)
  call glRotatef(-2.0 * angle - 25.0, 0.0, 0.0, 1.0)
  call glCallList(gear3)
  call glPopMatrix()

  call glPopMatrix()

  call glutSwapBuffers()

  Frames = Frames + 1
  draw = 2
end function draw

integer function idle()
  use mymod
  include <opengl.ins>, nolist

  angle = angle + 0.5
  view_rotx = view_rotx - 1
  view_roty = view_roty + 0.3
  
  call glutPostRedisplay()
  
  idle = 2
end function idle

integer function idle2()
  use mymod
  include <opengl.ins>

  call glutPostRedisplay()
  
  idle2 = 2
end function idle2


integer function key(k, x, y)
  use mymod
  include <opengl.ins>, nolist
  
  character :: k
  integer :: x, y

  select case (k)
  case ('z')
    view_rotz = view_rotz + 5.0
  case ('Z')
    view_rotz = view_rotz - 5.0
  case default
    return
  end select
  call glutPostRedisplay()
  key = 2
end function key

! change view angle 
! ARGSUSED1 
integer function specialk(k, x, y)
  use mymod
  include <opengl.ins>, nolist
  
  integer :: k, x, y

  select case (k)
  case (GLUT_KEY_UP)
    view_rotx = view_rotx + 5.0
  case (GLUT_KEY_DOWN)
    view_rotx = view_rotx - 5.0
  case (GLUT_KEY_LEFT)
    view_roty = view_roty + 5.0
  case (GLUT_KEY_RIGHT)
    view_roty = view_roty - 5.0
  case default
    return
  end select
  call glutPostRedisplay()
  specialk = 2
end function specialk

integer function motion(x, y)
  use mymod
  include <opengl.ins>
  
  integer :: x, y

  view_rotx = view_rotx + (y - my)
  view_roty = view_roty + (x - mx)
  mx = x
  my = y
  
  call glutPostRedisplay()

  motion = 2
end function motion

integer function passivemotion(x, y)
  use mymod
  include <opengl.ins>
  
  integer :: x, y
  mx = x
  my = y
  
  passivemotion = 2
end function passivemotion

! new window size or exposure 
integer function myreshape(width, height)
  use mymod
  include <opengl.ins>, nolist

  integer :: width, height

  real :: h = 1!height / width

  call glViewport(0, 0, width, height)
  call glMatrixMode(GL_PROJECTION)
  call glLoadIdentity()
  call glFrustum(-1.0d0, 1.0d0, -h * 1d0, h * 1d0, 5.0d0, 80.0d0)
  call gluLookAt(camx, camy, camz - 40d0, 0d0, 0d0, -40d0, 0d0, 1d0, 0d0)
  call glMatrixMode(GL_MODELVIEW)
  call glLoadIdentity()
  call glTranslatef(0.0, 0.0, -40.0)
  myreshape = 2
end function myreshape

integer function myreshape2(width, height)
  include <opengl.ins>, nolist

  integer :: width, height

  real :: h = 1!height / width

  call glViewport(0, 0, width, height)
  call glMatrixMode(GL_PROJECTION)
  call glLoadIdentity()
  call glFrustum(-1.0d0, 1.0d0, -h * 1d0, h * 1d0, 5.0d0, 60.0d0)
  call gluLookAt(0d0, 0d0, -80d0, 0d0, 0d0, -40d0, 0d0, 1d0, 0d0)
  call glMatrixMode(GL_MODELVIEW)
  call glLoadIdentity()
  call glTranslatef(0.0, 0.0, -40.0)
  myreshape2 = 2
end function myreshape2

integer function init()
  use mymod
  include <opengl.ins>, nolist

  real (kind = rkind1) :: pos(4) = (/15.0, 15.0, 0.0, 0.0/)
  real (kind = rkind1) :: red(4) = (/0.8, 0.1, 0.0, 1.0/)
  real (kind = rkind1) :: green(4) = (/0.0, 0.8, 0.2, 1.0/)
  real (kind = rkind1) :: blue(4) = (/0.2, 0.2, 1.0, 1.0/)

  call glLightfv(GL_LIGHT0, GL_POSITION, pos)
  call glEnable(GL_CULL_FACE)
  call glEnable(GL_LIGHTING)
  call glEnable(GL_LIGHT0)
  call glEnable(GL_DEPTH_TEST)

  ! make the gears 
  gear1 = glGenLists(1)
  call glNewList(gear1, GL_COMPILE)
  call glMaterialfv(GL_FRONT, GL_AMBIENT_AND_DIFFUSE, red)
  call gear(1.0, 4.0, 1.0, 20, 0.7)
  call glEndList()

  gear2 = glGenLists(1)
  call glNewList(gear2, GL_COMPILE)
  call glMaterialfv(GL_FRONT, GL_AMBIENT_AND_DIFFUSE, green)
  call gear(0.5, 2.0, 2.0, 10, 0.7)
  call glEndList()

  gear3 = glGenLists(1)
  call glNewList(gear3, GL_COMPILE)
  call glMaterialfv(GL_FRONT, GL_AMBIENT_AND_DIFFUSE, blue)
  call gear(1.3, 2.0, 0.5, 10, 0.7)
  call glEndList()

  call glEnable(GL_NORMALIZE)

  init = 2
end function init

integer function updatex()
   use mymod
   include <opengl.ins>
   
   call glutSetWindow(w1)
   call glMatrixMode(GL_PROJECTION)
   call glLoadIdentity()
   call glFrustum(-1.0d0, 1.0d0, -1d0, 1d0, 5.0d0, 80.0d0)
   call gluLookAt(camx, camy, camz - 40d0, 0d0, 0d0, -40d0, 0d0, 1d0, 0d0)
   call glMatrixMode(GL_MODELVIEW)
   updatex = 2
end function updatex

integer function updatey()
   use mymod
   include <opengl.ins>
   
   call glutSetWindow(w1)
   call glMatrixMode(GL_PROJECTION)
   call glLoadIdentity()
   call glFrustum(-1.0d0, 1.0d0, -1d0, 1d0, 5.0d0, 80.0d0)
   call gluLookAt(camx, camy, camz - 40d0, 0d0, 0d0, -40d0, 0d0, 1d0, 0d0)
   call glMatrixMode(GL_MODELVIEW)
   updatey = 2
end function updatey

integer function updatez()
   use mymod
   include <opengl.ins>
   
   call glutSetWindow(w1)
   call glMatrixMode(GL_PROJECTION)
   call glLoadIdentity()
   call glFrustum(-1.0d0, 1.0d0, -1d0, 1d0, 5.0d0, 80.0d0)
   call gluLookAt(camx, camy, camz - 40d0, 0d0, 0d0, -40d0, 0d0, 1d0, 0d0)
   call glMatrixMode(GL_MODELVIEW)
   updatez = 2
end function updatez

integer function closectrl ()
   use mymod
   use mswin
  
   ctrl = 0
   closectrl = 2
   call window_update@(ctrl)
end function closectrl

integer function closewin ()
   use mymod
   include <opengl.ins>
   
   call glutDestroyWindow(w2)
   closewin = 2
end function closewin

integer function myexit ()
   use mymod
   include <opengl.ins>
   
   call glutDestroyWindow(w2)
   ctrl = 0
   call window_update@(ctrl)
   
   myexit = 0
end function myexit

integer function myabout ()
   use mswin
   
   i = winio@('%ca[The Gears demo program]%ff&')
   i = winio@('%`bfThis program illustrates the use of OpenGL with the GLUT library.%ff&')
   i = winio@('This program illustrates that GLUT-style OpenGL windows can be mixed with%ff&')
   i = winio@('OpenGL windows created using WINIO@.%ff%nl&')
   i = winio@('The main window is created using%ff&')
   i = winio@('WINIO@ so that a conventional menu can be attached to the window.%ff&')
   i = winio@('GLUT can also used to attach mouse-click menus to the window.%ff%nl&')
   i = winio@('The second window is created using the GLUT library.%ff%nl&')
   i = winio@('In general many of the GLUT functions supply a functionality that is%ff&')
   i = winio@('already supplied in a more general form by ClearWin+ - these%ff&')
   i = winio@('functions are merely supplied for compatibility reasons.%ff')
   
   myabout = 2
end function myabout

program gears
   use mymod
   include <clearwin.ins>, nolist
   include <opengl.ins>, nolist
   integer :: i, draw, myreshape, key, specialk, idle, motion, passivemotion
   integer :: myreshape2, idle2, updatex, updatey, updatez, handle
   integer :: closectrl, closewin, ctrl2, myexit, myabout
   external :: draw, myreshape, key, specialk, idle, motion, passivemotion
   external :: myreshape2, idle2, updatex, updatey, updatez
   external :: closectrl, closewin, myexit, myabout

   view_rotx = 20.0
   view_roty = 30.0
   view_rotz = 0.0
   angle = 0.0
   mx = 0
   my = 0
   camx = 0
   camy = 0
   camz = 40
   
   call glutInitWindowPosition(50, 10)
   call glutInitWindowSize(300, 300)
   call glutInitDisplayMode(ior(GLUT_DOUBLE, GLUT_STEREO))
   i = winio@('%ww[no_border]%`og%mn[Options[Close control]]&',0, 0, w1, closectrl)
   i = winio@('%ca[User controlled window]&')
   i = winio@('%mn[[Close window 2]]&', closewin)
   i = winio@('%mn[[Exit program]]&', myexit)
   i = winio@('%mn[Help[About]]%lw%cc', myabout, ctrl2, myexit)

   call glutSetWindow(w1)
   call glutInitWindowPosition(400, 10)
   call glutInitWindowSize(300, 300)
   call glutInitDisplayMode(ior(GLUT_DOUBLE, GLUT_STEREO))
   w2 = glutCreateWindow('Standard view (window 2)')
         
   i = winio@('%ww%ca[Camera position]%ff&')
   i = winio@('X %^20sl%ff&', camx, -40d0, 40d0, updatex)
   i = winio@('Y %^20sl%ff&', camy, -40d0, 40d0, updatey)
   i = winio@('Z %^20sl%lw%hw', camz, -40d0, 40d0, updatez, ctrl, handle)
   call move_window@(handle, 50, 400)

   call glutSetWindow(w1)
   call glutDisplayFunc(draw)
   call glutReshapeFunc(myreshape)
   call glutIdleFunc(idle)
   call glutKeyboardFunc(key)
   call glutSpecialFunc(specialk)
   call glutMotionFunc(motion)
   call glutPassiveMotionFunc(passivemotion)
   i = init()
   
   call glutSetWindow(w2)
   call glutDisplayFunc(draw)
   call glutReshapeFunc(myreshape2)
   call glutIdleFunc(idle2)
   call glutKeyboardFunc(key)
   call glutSpecialFunc(specialk)
   call glutMotionFunc(motion)
   call glutPassiveMotionFunc(passivemotion)
   i = init();
   
   call glutMainLoop()
end program gears