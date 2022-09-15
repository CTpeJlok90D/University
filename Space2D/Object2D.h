#pragma once
#include "Vector2.h"
#include "string"
#include <vector>
#include <math.h>

using namespace std;

class Object2D
{
private:
	vector<Vector2> _dots;

public:
	Object2D(vector<Vector2> dots)
	{
		_dots = dots;
	}

	string ToString() 
	{
		string result = "";
		for (int i = 0; i < _dots.size(); i++) 
		{
			result += "(Dot N" + to_string(i) + " " + _dots[i].ToString() + ") ";
		}
		return result;
	}

	double GetSquare()
	{
		double result = 0;
		for (int i = 1; i < _dots.size(); i++) 
		{
			result += _dots[i-1].X*_dots[i].Y + _dots[_dots.size() - 1].X * _dots[0].Y;
		}
		for (int i = 1; i < _dots.size(); i++) 
		{
			result -= _dots[i].X*_dots[i-1].Y - _dots[0].X * _dots[_dots.size() - 1].Y;
		}
		return abs(result)/2;
	}
};