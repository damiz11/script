!  Salford Software FTN95 .NET for Visual Studio .NET
!  --------------------------------------------------
!  Free Format FTN95 Source File
!
!    Filename: Calculator.f95
!    Author: Silverfrost
!    Notes: See documentation for details
!
!  --------------------------------------------------

real*8 function add_ (x, y)
   assembly_interface (name="Add")
   real*8 x, y 
   add_ = x + y
end

real*8 function subtract_ (x, y)
   assembly_interface (name="Subtract")
   real*8 x, y
   subtract_ = x - y
end

real*8 function multiply_ (x, y)
   assembly_interface (name="Multiply")
   real*8 x, y
   multiply_ = x * y
end

real*8 function divide_ (x, y)
   assembly_interface (name="Divide")
   real*8 x, y
   divide_ = x / y
end

real*8 function sqroot_ (x)
   assembly_interface (name="SqRoot")
   real*8 x
   object ("System.Exception") calculatorException
   calculatorException = new@ ("System.Exception")
   if (x < 0) throw calculatorException
   sqroot_ = sqrt(x)
end

real*8 function log_e_ (x)
   assembly_interface (name="Log")
   real*8 x
   object ("System.Exception") calculatorException
   calculatorException = new@ ("System.Exception")
   if (x < 0) throw calculatorException
    log_e_ = log(x)
end

real*8 function piValue_ ()
   assembly_interface (name="PiVal")
   piValue_ = 3.1415926535897932384626433832795
end