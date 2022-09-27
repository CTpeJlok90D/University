#pragma once
#include "IFigure.h"

class Ractangle : public IFigure2D
{
public:
	Ractangle(float height, float wight)
	{
		_height = height;
		_wight = wight;
	}

	float Height() { return _height; }
	float Wight() { return _wight; }

	float Square() override 
	{
		return _height * _wight;
	}
	float Perimetr() override
	{
		return (_height + _wight) * 2;
	}

private:
	float _height;
	float _wight;
};