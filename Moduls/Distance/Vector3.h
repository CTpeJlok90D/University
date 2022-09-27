#pragma once

#include <math.h>

class Vector3
{
public:
	Vector3(float x, float y, float z);
	Vector3();

	float x();
	float y();
	float z();

	static float DistanceTo(Vector3 vector1, Vector3 vector2);

	float operator[](int i);

private:
	float myArray[3] = {};
};

inline Vector3::Vector3(float x, float y, float z)
{
	myArray[0] = x;
	myArray[1] = y;
	myArray[2] = z;
}

Vector3::Vector3()
{
	for (int i = 0; i < 3; i++)
	{
		myArray[i] = 0;
	}
}

float Vector3::x()
{
	return myArray[0];
}

float Vector3::y()
{
	return myArray[1];
}

float Vector3::z()
{
	return myArray[2];
}

float Vector3::operator[](int i)
{
	return myArray[i];
}

float Vector3::DistanceTo(Vector3 vector)
{
	return sqrt
	( 
		pow(vector.x() - this->x(), 2) 
	  + pow(vector.y() - this->y(), 2)
	  + pow(vector.z() - this->z(), 2)
	);
}