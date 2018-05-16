//----------------------------------------------------------------------
// VCProject1.cpp : Defines the entry point for the console application.
// VCProject1.cpp - Salford Software 2003
//
// This file is part of the VisualCInteroperabilty Solution provided
// with Salford FTN95.  This Solution demonstrates the use of FTN95 
// in conjunction with Microsoft Visual C++ in Win32 configuration.
//----------------------------------------------------------------------

#include "stdafx.h"

//----------------------------------------------------------------------
// Declare the external Fortran routines
//----------------------------------------------------------------------
extern "C" void SUBSIMPLE();
extern "C" void SUBARGUMENTS(int* i, float* x);
extern "C" void SUBSTRING(char* s1, char* s2, int i, int j);
extern "C" void SUBARRAY(int* arr, int size);
extern "C" void SUBFUNC(void* p);
extern "C" int FUNCINTEGER();
extern "C" float FUNCREAL();

//----------------------------------------------------------------------
// Constants
//----------------------------------------------------------------------
#define ARRAY_SIZE 10

//----------------------------------------------------------------------
// Calls an FTN95 subroutine with no arguments
//----------------------------------------------------------------------
void CallSubroutineSimple()
{
	SUBSIMPLE();
}

//----------------------------------------------------------------------
// Calls an FTN95 subroutine with simple (int and float) arguments
//----------------------------------------------------------------------
void CallSubroutineArguments()
{
	int i = 3;
	float x = 4.6;
	SUBARGUMENTS(&i,&x);
}

//----------------------------------------------------------------------
// Calls an FTN95 subroutine with string arguments.  The lengths of the
// two string arguments are passed by value as extra arguments.
//----------------------------------------------------------------------
void CallSubroutineString()
{
	char* chStr1 = "Hello ";
	char* chStr2 = "World...";
	SUBSTRING(chStr1,chStr2,strlen(chStr1),strlen(chStr2));
}

//----------------------------------------------------------------------
// Calls an FTN95 subroutine with an int array - note the size is passed
// as an extra argument in order to facilitate assumed size within the
// Fortran code.  Extra arguments may be passed by value as shown, actual
// arguments must be passed by reference.
//----------------------------------------------------------------------
void CallSubroutineArray()
{
	int arr[ARRAY_SIZE] = {1,2,3,4,5,6,7,8,9,0};
	SUBARRAY(arr,ARRAY_SIZE);
}

//----------------------------------------------------------------------
// Calls an FTN95 function returning an int
//----------------------------------------------------------------------
void CallFuncInteger()
{
	int ret = FUNCINTEGER();
	printf("Return from FUNCINTEGER: %d\n",ret);
}

//----------------------------------------------------------------------
// Calls an FTN95 function returning a float
//----------------------------------------------------------------------
void CallFuncReal()
{
	float ret = FUNCREAL();
	printf("Return from FUNCREAL: %f\n",ret);
}

//----------------------------------------------------------------------
// Utility function used by CallSubroutineFunc
//----------------------------------------------------------------------
void FunctionPointer(int* i)
{
	printf("FunctionPointer called with i=%d\n",*i);
}

//----------------------------------------------------------------------
// Calls an FTN95 function with a function pointer argument
//----------------------------------------------------------------------
void CallSubroutineFunc()
{
	void (*pFunc) (int*);
	pFunc = FunctionPointer;
	SUBFUNC(pFunc);
}

//----------------------------------------------------------------------
// Entry point for the application
//----------------------------------------------------------------------
int _tmain(int argc, _TCHAR* argv[])
{
	CallSubroutineSimple();
	CallSubroutineArguments();
	CallSubroutineString();
	CallSubroutineArray();
	CallSubroutineFunc();
	CallFuncInteger();
	CallFuncReal();
	return 0;
}