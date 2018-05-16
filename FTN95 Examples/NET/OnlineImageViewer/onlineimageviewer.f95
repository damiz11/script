!  Salford Software FTN95 .NET for Visual Studio .NET
!  --------------------------------------------------
!  Free Format FTN95 Source File
!
!    Filename: onlineimageviewer.f95
!    Author: Silverfrost
!    Date Modified: 22/02/2008
!    Notes: See documentation for details
!
!  --------------------------------------------------

winapp
program OnlineImageViewer
   implicit none
   include <clearwin.ins>
   include <globals.ins>
   integer width, height
   integer i
   integer downloadAndDisplayImage
   external downloadAndDisplayImage

   width = 416
   height = 226
   information = "Enter the URL and press the View button."
   url = "http://www.silverfrost.com/images/silverfrost_ftn95.jpg"
   file = "temp.jpg"
   buttonEnabled = 1

   call erase@ (file, i)

   i=winio@ ("%sy[3d_thin]%ca[Example Online Image Viewer]&")
   i=winio@ ("URL: %~35rs %`~^bt[View]%ff%nl&", url, buttonEnabled, buttonEnabled, downloadAndDisplayImage)
   i=winio@ ("%gr[black,rgb_colours]%ff%nl&", width, height)
   i=winio@ ("Status: %40st&", information)
   i=winio@ ("")
end

integer function downloadAndDisplayImage ()
   implicit none
   include <clearwin.ins>
   include <globals.ins>
   logical downloadImage
   integer showImage, imageDisplay

   buttonEnabled = 0

   information = "Downloading image..."
   call window_update@(information)

   imageDownloaded = downloadImage ()
   imageDisplay = showImage()

   downloadAndDisplayImage = 1
end

integer function showImage ()
   implicit none
   include <globals.ins>
   character*1024 filename

   if (imageDownloaded) then
      filename = "{"
      call append_string@(filename, file)
      call append_string@(filename, "}")
      call displayImage(filename)
   endif

   showImage = 1
end

logical function downloadImage ()
   implicit none
   include <globals.ins>

   assembly_external (name="System.Net.WebClient.DownloadFile") webClientDownloadFile
   object ("System.Net.WebClient") webClient
   object ("System.Net.WebException") webException

   webClient = new@("System.Net.WebClient")

   try
     call webClientDownloadFile (webClient, url, file)
   catch (webException)
      information = "Download failed."
      call window_update@ (information)
      downloadImage = .false.
      return
   endtry
   downloadImage = .true.
end

subroutine displayImage (filename)
   implicit none
   include <clearwin.ins>
   include <globals.ins>
   character*1024 filename
   integer didDisplay

   didDisplay = import_image@(filename, 0, 0)
   if(didDisplay == 0) then
      information = "Failed to display image."
      call window_update@(information)
   else
      information = "Image downloaded."
      call window_update@(information)
   endif
end