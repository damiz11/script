FUNCTION Process(x)
ASSEMBLY_INTERFACE (name="Process")
INTEGER,PARAMETER::d=selected_real_kind(10);
REAL(d)::Process
REAL(d),INTENT(IN)::x 
Process=x*x
END
