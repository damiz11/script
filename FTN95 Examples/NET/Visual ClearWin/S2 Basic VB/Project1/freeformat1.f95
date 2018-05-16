FUNCTION MyProcess(x)
ASSEMBLY_INTERFACE (name="Process")
INTEGER,PARAMETER::d=selected_real_kind(10);
REAL(d)::MyProcess
REAL(d),INTENT(IN)::x 
MyProcess=x*x
END

