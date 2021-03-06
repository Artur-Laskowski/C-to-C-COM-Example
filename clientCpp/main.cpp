#import "com_lab4.tlb" no_namespace
#include <iostream>
#include <Windows.h>

int main()
{
	CoInitializeEx(NULL, COINIT_APARTMENTTHREADED);
	//IStosPtr myPtr(__uuidof(IStos));
	IStos* myPtr = nullptr;
	CLSID clsid;
	CLSIDFromProgID(OLESTR("KSR.Stos.2"), &clsid);
	HRESULT rv = CoCreateInstance(clsid, NULL, CLSCTX_ALL, __uuidof(IStos), reinterpret_cast<LPVOID *>(&myPtr));
	long a = 0;
	std::cout << myPtr->Push(69) << std::endl;
	std::cout << myPtr->Push(69) << std::endl;
	myPtr->Pop(&a);
	std::cout << &a << ", val:" << a << std::endl;
	myPtr->Pop(&a);
	std::cout << &a << ", val:" << a << std::endl;
	std::cout << a << std::endl;
	CoUninitialize();
    return 0;
}

