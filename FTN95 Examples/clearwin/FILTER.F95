!****************************************************************************
!*                                                                          *
!* Salford ClearWin+ Example Code                                           *
!*                                                                          *
!* filter.f95 - version 1.0 29/6/99                                         *
!*                                                                          *
!* Example of ClearWin+ get_filtered_file routine                           *
!*                                                                          *
!* only compile using FTN95 version 1.6  or higher                          *
!*                                                                          *
!****************************************************************************
!*                                                                          *
!* Illustrates the use of the function GET_FILTERED_FILE@ to obtain a       *
!* filename from the user.                                                  *
!*                                                                          *
!****************************************************************************

winapp
 
program filter
   use mswin
   integer :: res, select_file
   external select_file
   res = winio@('%ca[Filtered File Example]&')
   res = winio@('%sy[thin_border]&')
   res = winio@('%bg[BTNFACE]&')
   res = winio@('%ob[raised]&')
   res = winio@('This program illustrates the use of%ff&')
   res = winio@('the function GET_FILTERED_FILE@.%ff&')
   res = winio@('Use the buttons to make your choice%ff%nl&')
   res = winio@('Note: that under WIN32 you will get the%ff&')
   res = winio@('enhanced dialog box.%cb%ff%nl&')
   res = winio@('%cn%`^tt[&select file]     %tt[&Exit]', &
         & select_file)
end program filter


!****************************************************************************
!*                                                                          *
!* Callback function that calls get_filtered_file@ to display the standard  *
!* 'open file' window                                                          *
!*                                                                          *
!****************************************************************************

integer function select_file()
   use mswin
   integer :: res, number_of_filters
   logical :: must_exist  
   character(len=128),dimension (10) :: filter_names, filters
   character(len=128) :: file_name,path
   character (len=20) :: title
   title = 'select_file File';path = 'c:\';file_name = 'fred.f95'
   filter_names(1) = 'Text files';filters(1) = '*.txt';filter_names(2) = 'Batch files'
   filters(2) = '*.bat';filter_names(3) = 'All files';filters(3) = '*.*'
   number_of_filters = 3;must_exist = .true.
   call get_filtered_file@(title, file_name, path, &
        & filter_names, filters, number_of_filters,must_exist)
   res = winio@('%ca[Result]&')
   res = winio@('%bg[BTNFACE]&')
   res = winio@('You selected file "%ws"%2nl&', file_name)
   res = winio@('%cn%bt[OK]')
   select_file = 1
end function select_file