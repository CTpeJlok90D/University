#pragma once
#include "IFigure.h"

class Circle : public RoundedFigure, public IFigure2D
{
public:
	Circle(float radius) : RoundedFigure(radius){}

	float Square() override
	{
		return PI * pow(Radius(), 2);
	}

	float Perimetr() override 
	{
		return 2 * PI * Radius();
	}
};