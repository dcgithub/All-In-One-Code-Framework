========================================================================
    CONSOLE APPLICATION : CppCOMClient Project Overview
========================================================================

/////////////////////////////////////////////////////////////////////////////
Use:

There are three basic ways you can use Automation or consume a COM server in 
a native client: MFC, #import, and C/C++.

1. C/C++

The code in RawAPI.h/cpp demontrates the use of C/C++ and the COM APIs to 
consume the COM object ATLDllCOMServer.SimpleObject. The raw automation 
is much more difficult, but it is sometimes necessary to avoid the overhead
with MFC, or problems with #import. Basically, you work with such APIs as 
CoCreateInstance(), and COM interfaces such as IDispatch and IUnknown.

2. #import

The code in ImportDirective.h/cpp demonstrates the use of #import to automate
a COM server, more specifically, a COM server written in .NET: CSDllCOMServer.
#import (http://msdn.microsoft.com/en-us/library/8etzzkb6.aspx), a new  
directive that became available with Visual C++ 5.0, creates VC++ "smart 
pointers" from a specified type library. It is very powerful, but often not 
recommended because of reference-counting problems that typically occur when 
used with the Microsoft Office applications. Unlike the direct API approach 
in RawAPI.h/cpp, smart pointers enable us to benefit from the type info to 
early/late bind the object. #import takes care of adding the messy guids to 
the project and the COM APIs are encapsulated in custom classes that the 
#import directive generates.

The differences between early binding and late binding via smart pointers:

Smart pointers make creating an object that supports early binding easy, so
does it make creating a late bound object. The only difference between early 
binding and late binding via smart pointer is the .tlh and .tli files 
generated by the #import directive. If the target object supports early 
binding, the .tlh and .tli files will make use of the custom interface (not 
IDispatch) to call the target property/method directly. If the target COM 
object only support late binding, the smart pointer takes care of converting
your method calls into GetIDsOfNames()s and Invoke()s of the IDispatch 
interface.

3. MFC

With MFC, Visual C++ ClassWizard can generate "wrapper classes" from the type
libraries. These classes simplify the use of the COM servers. Please refer to
the sample MFCCOMClient.


/////////////////////////////////////////////////////////////////////////////
Project Relation:

CppCOMClient -> ATLDllCOMServer
CppCOMClient is the client application of the COM server ATLDllCOMServer.

CppCOMClient -> CSDllCOMServer
CppCOMClient is the client application of the COM server CSDllCOMServer.


/////////////////////////////////////////////////////////////////////////////
Build:

CppCOMClient depends on ATLDllCOMServer, CSDllCOMServer. To build and run 
CppCOMClient successfully, please make sure ATLDllCOMServer and CSDllCOMServer
are built and registered rightly.


/////////////////////////////////////////////////////////////////////////////
Creation:

A. Creating the ATLDllCOMServer.SimpleObject COM object using C++ and  
the COM APIs (RawAPI.h/cpp)

Step1. Add the automation helper function, AutoWrap.

Step2. Initialize COM by calling CoInitializeEx, or CoInitialize.

Step3. Get CLSID of the COM server using the API CLSIDFromProgID.

Step4. Start the server and get the IDispatch interface using the API 
CoCreateInstance.

Step5. Consume the COM object with the help of AutoWrap.

Step6. Release the COM object

Step7. Uninitialize COM for this thread by calling CoUninitialize.

B. Creating the CSDllCOMServer.CSExplicitInterfaceObject COM object using the 
#import directive and smart pointers (ImportDirecive.h/cpp)

Step1. Import the type library of the target COM server using the #import 
directive. If the COM object is a .NET component, mscorlib.tlb is also 
required to be imported.

Step2. Build the project. If the build is successful, the compiler generates 
the .tlh and .tli files that encapsulate the COM server based on the type 
library specified in the #import directive. It serves as a class wrapper we
can now use to create the COM class and access its properties, methods, etc.

Step3. Create a COM object using the smart pointer. The class name is the 
original interface name (i.e. ICSExplicitInterfaceObject) with a "Ptr" suffix. 
We can use either the constructor of the smart pointer class or its 
CreateInstance method to create the COM object.

Step4. Call the COM object's properties, methods through the smart pointer 
like this:

	spSimpleObj->FloatProperty = 1.2f;

To access the methods of the smart pointer class itself (e.g. QueryInterface),
use the dot syntax spSimpleObj.QueryInterface().

Step5. It is necessary to catch the COM errors if the type library was  
imported without raw_interfaces_only and when the raw interfaces 
(e.g. raw_HelloWorld) are not used. For example:

	#import "XXXX.tlb"
	try
	{
		_bstr_t result = spSimpleObj->HelloWorld();
	}
	catch (_com_error &err)
	{
	}

The above code snippet is equivalent to:

	#import "XXXX.tlb"
	_bstr_t result;
	HRESULT hr = spSimpleObj->raw_HelloWorld(result.GetAddress());
	if (FAILED(hr)
	{
	}

And it is also the same as:

	#import "XXXX.tlb" raw_interfaces_only
	_bstr_t result;
	HRESULT hr = spSimpleObj->HelloWorld(result.GetAddress());
	if (FAILED(hr)
	{
	}

Step6. It is said that the smart pointers are released automatically, so we
do not need to manually release the COM object.

Step7. Uninitialize COM for this thread by calling CoUninitialize.


/////////////////////////////////////////////////////////////////////////////
References:

COM Programming by Example: Using MFC, ActiveX, ATL, ADO, and COM+ 
By John E. Swanke
http://www.amazon.com/COM-Programming-Example-ActiveX-CD-ROM/dp/1929629036

COM Interop Sample: COM Client and .NET Server
http://msdn.microsoft.com/en-us/library/2w30w8zx.aspx


/////////////////////////////////////////////////////////////////////////////
