#pragma once
#include <string>

using namespace std;

class Vector2
{
public:
	Vector2(double x = 0, double y = 0);
	~Vector2();
	double X;
	double Y;

	Vector2 operator+(Vector2 a);
	Vector2 operator-(Vector2 a);

	string ToString();
};

Vector2::Vector2(double x, double y)
{
	X = x;
	Y = y;
}

Vector2::~Vector2(){}

inline Vector2 Vector2::operator+(Vector2 a)
{
	return Vector2(a.X + X, a.Y + Y);
}

inline Vector2 Vector2::operator-(Vector2 a)
{
	return Vector2(a.X - X, a.Y - Y);
}

inline string Vector2::ToString()
{
	return to_string(X) + " " + to_string(Y);
}
