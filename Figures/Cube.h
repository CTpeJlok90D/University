#pragma once
#include "IFigure.h"
class Cube : public IFigure3D
{
public:
	Cube(float side) 
	{
		_side = side;
	}

	float Square() override
	{
		return pow(_side,2)*6;
	}

	float Volume() override
	{
		return pow(_side, 3);
	}
private:
	float _side;
};