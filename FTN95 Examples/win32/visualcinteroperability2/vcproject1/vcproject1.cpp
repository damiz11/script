//----------------------------------------------------------------------
// VCProject1.cpp : Defines the entry point for the DLL application.
// VCProject1.cpp - Salford Software 2003
//
// This file is part of the VisualCInteroperabilty2 Solution provided
// with Salford FTN95.  This Solution demonstrates the use of FTN95
// in conjunction with Microsoft Visual C++ in Win32 configuration.
// A Visual C++ Win32 DLL is called from a Win32 FTN95 application.
//----------------------------------------------------------------------

#include "stdafx.h"
#include <stdio.h>

//----------------------------------------------------------------------
// This is here for convienience, a .def file could also be used or
// /EXPORT on the linker command line
//----------------------------------------------------------------------
#define DllExport __declspec(dllexport)

//----------------------------------------------------------------------
// Defines the main entry point
//----------------------------------------------------------------------
BOOL APIENTRY DllMain( HANDLE hModule,
                       DWORD  ul_reason_for_call,
                       LPVOID lpReserved
					 )
{
    return TRUE;
}

//----------------------------------------------------------------------
// Defines and exports a simple function, that accepts no arguments and
// returns void.
//----------------------------------------------------------------------
extern "C" DllExport void _FunctionSimple()
{
	printf("%s\n",
		"_FunctionSimple called");
}

//----------------------------------------------------------------------
// Defines and exports a function that accepts two arguments,
// both of these arguments are passed by value,  Returns void.
//----------------------------------------------------------------------
extern "C" DllExport void _FunctionArgumentsValue(int i, double x)
{
	printf("%s%d%s%f\n",
		"_FunctionArgumentsValue called with arguments: ",
		i,", ",x);
}

//----------------------------------------------------------------------
// Defines and exports a function that accepts two arguments,
// both of these arguments are passed by reference.  They are modified in
// the C routine and then printed out in the calling Fortran routine.
// Returns void.
//----------------------------------------------------------------------
extern "C" DllExport void _FunctionArgumentsReference(int* i, float* x)
{
	printf("%s%d%s%f\n",
		"_FunctionArgumentsReference called with arguments: ",
		*i,", ",*x);
	*i = 6;
	*x = 4.776;
}

//----------------------------------------------------------------------
// Defines and exports a function that accepts no arguments and
// returns an int.  This function would be implemented in the just the
// same way for float/long etc,
//----------------------------------------------------------------------
extern "C" DllExport int _FunctionSimpleInt()
{
	printf("%s\n",
		"_FunctionSimpleInt called");
	return 9;
}

//----------------------------------------------------------------------
// Defines and exports a function that accepts an array and returns a
// float.
//----------------------------------------------------------------------
extern "C" DllExport float _FunctionArray(int arr[])
{
	printf("%s\n",
		"_FunctionArray called with array contents:");
	for (int i=0;i<10;++i)
	{
		printf("%d ",arr[i]);
	}
	printf("\n");
	return 0.7;
}