// CppDll.cpp : 定义 DLL 应用程序的导出函数。
//

#include "stdafx.h"
#include "CppDll.h"

int _stdcall add(int a, int b) {
	return a + b;
}

int _stdcall minus(int a, int b) {
	return a - b;
}

