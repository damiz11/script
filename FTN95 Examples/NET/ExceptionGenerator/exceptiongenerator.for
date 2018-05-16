c     Salford Software FTN95 .NET for Visual Studio .NET
c     --------------------------------------------------
c     Fixed Format FTN95 Source File
c
c       Filename: ExceptionGenerator.f95
c       Author: Silverfrost
c       Notes: See the documentation for more details 
c
c     --------------------------------------------------

      options(check)
      winapp
      program ExceptionGenerator
         implicit none
         integer i
         integer runTest
         external runTest
         integer rb1, rb2, rb3, rb4, rb5, rb6, rb7
         common rb1, rb2, rb3, rb4, rb5, rb6, rb7

         rb1 = 1

         i=winio@ ('%sy[3d_thin]&')
         i=winio@ ('Select the exception test you would like to run.
     &%nl%nl&')
         i=winio@ ('%rb[Throw a System Exception]%nl&', rb1)
         i=winio@ ('%rb[Throw a custom Exception]%nl&', rb2)
         i=winio@ ('%rb[Call a missing routine]%nl&', rb3)
         i=winio@ ('%rb[Exceed the bounds of an array]%nl&', rb4)
         i=winio@ ('%rb[Attempt to read from an unopened file]%nl&',
     &rb5)
         i=winio@ ('%rb[Divide an integer by 0]%nl&', rb6)
         i=winio@ ('%rb[Call winio with too few arguments]%nl&', rb7)
         i=winio@ ('%`7ga&', rb1, rb2, rb3, rb4, rb5, rb6, rb7)
         i=winio@ ('%nl%`^bt[Run test]&', runTest)
         i=winio@ ('')
      end

      function runTest
         implicit none
         integer runTest
         integer rb1, rb2, rb3, rb4, rb5, rb6, rb7
         common rb1, rb2, rb3, rb4, rb5, rb6, rb7
         integer i, arraySize, array
         dimension array(10)
         character string(32)
         object ('System.Exception') systemException
         systemException = new@ ('System.Exception')

         if (rb1 .eq. 1) then
            throw systemException
         else if (rb2 .eq. 1) then
            throw 'A custom exception'
         else if (rb3 .eq. 1) then
            call nowt
         else if (rb4 .eq. 1) then
            arraySize = 100
            array(arraySize) = 0
         else if (rb5 .eq. 1) then
            read (10) i
         else if (rb6 .eq. 1) then
            i = i/0
         else if (rb7 .eq. 1) then
            i=winio@("%gr")
         end if
         runTest = 1
      end function
