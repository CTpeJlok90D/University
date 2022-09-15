#pragma once
#include "IFigure.h"
#include <math.h>
class Sphere : public RoundedFigure, public IFigure3D
{
public:
	Sphere(float radius) : RoundedFigure(radius){}

	float Square() override
	{
		return 4 * PI * pow(Radius(), 2);
	}

	float Volume() override
	{
		return 1 / 3 * PI * pow(Radius(), 3);
	}
};

