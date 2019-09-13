// stdafx.h : include file for standard system include files,
// or project specific include files that are used frequently,
// but are changed infrequently

#pragma once

#ifndef STRICT
#define STRICT
#endif

#include "targetver.h"

#define _ATL_APARTMENT_THREADED
#define _ATL_NO_AUTOMATIC_NAMESPACE

#define _ATL_CSTRING_EXPLICIT_CONSTRUCTORS	// some CString constructors will be explicit

#include "resource.h"

// ATL
#include <atlbase.h>
#include <atlcom.h>
#include <atlctl.h>

using namespace ATL;

// Shell
#include <comdef.h>
#include <shlobj.h>

// STL
#include <string>
#include <list>
typedef std::list<std::basic_string<TCHAR>> string_list;