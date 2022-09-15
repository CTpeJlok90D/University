#include "Vector3.h"

template<typename T>
inline Vector3<T>::Vector3(T parametr1, T parametr2, T parametr3)
{
	myArray[0] = parametr1;
	myArray[1] = parametr2;
	myArray[2] = parametr3;
}

template<typename T>
Vector3<T>::Vector3()
{
	for (int i = 0; i < 3; i++) 
	{
		myArray[i] = 0;
	}
}

template<typename T>
T Vector3<T>::x()
{
	return myArray[0];
}

template<typename T>
T Vector3<T>::y()
{
	return myArray[1];
}

template<typename T>
T Vector3<T>::z()
{
	return myArray[2];
}

template<typename T>
T Vector3<T>::operator[](int i)
{
	return myArray[i];
}