WINAPP 'resource.rc'
PROGRAM dialog
IMPLICIT NONE
INCLUDE <windows.ins>
INCLUDE 'resource.inc'
INTEGER wr,cb,canquit,ctrl
EXTERNAL cb
 canquit=0
 wr=winio@('%di&', IDD_DIALOG1)
 wr=winio@('%mn&', ID_PROCESS_UNDO,cb)
 wr=winio@('%mn&', ID_PROCESS_FILE,cb)
 wr=winio@('%mn&', ID_PROCESS_FILE+1,cb)
 wr=winio@('%~mn&',ID_PROCESS_EXIT,canquit,'EXIT')
 wr=winio@('%mn&', ID_HELP_ABOUT,cb)
 wr=winio@('%pm&', IDR_MENU2)
 wr=winio@('%pm&', ID_POP1_UNDO,cb)
 wr=winio@('%pm&', ID_POP1_ABOUT,cb)
 wr=winio@('%lw',  ctrl)
 CALL insert_menu_item@('File 2',ID_PROCESS_FILE,ID_PROCESS_FILE)
 CALL insert_menu_item@('File 1',ID_PROCESS_FILE+1,ID_PROCESS_FILE)
 !CALL delete_menu_item@(ID_PROCESS_FILE+1,0)
 !CALL insert_menu_item@('Recent Files',ID_PROCESS_FILE,ID_PROCESS_FILE)
END

SUBROUTINE Message(msg)
CHARACTER(LEN=*) msg
INCLUDE <windows.ins>
INCLUDE 'resource.inc'
INTEGER wr
  wr=winio@('%di&',IDD_DIALOG2)
  wr=winio@('%ws',IDC_STATIC1,msg)
END

INTEGER FUNCTION cb()
INCLUDE <windows.ins>
CHARACTER*32 title
 title=clearwin_string@('CURRENT_MENU_ITEM')
 if(title==' ') title='Accelerator key used'
 CALL Message(title)
 cb=1
END

