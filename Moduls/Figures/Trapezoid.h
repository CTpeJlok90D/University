#pragma once
#include "IFigure.h"
#include <math.h>
class Trapezoid : public IFigure2D
{
public:
	Trapezoid(float footing, float downFooting, float leftSide, float rightSide)
	{
		_upFooting = footing;
		_downFooting = downFooting;
		_leftSide = leftSide;
		_rightSide = rightSide;
	}

	float UpFooting() { return _upFooting; }
	float DownFooting() { return _downFooting; }
	float LeftSide() { return _leftSide; }
	float RightSide() { return _rightSide; }

	float Square() override
	{
		float halfSum = ((_upFooting + _downFooting) / 2);
		float numerator = pow(_downFooting - _upFooting, 2) + pow(_leftSide, 2) - pow(_rightSide, 2);
		float denominator = 2 * (_downFooting - _upFooting);
		float sqrtResult = sqrt(pow(_leftSide, 2) - numerator / denominator);
		return halfSum * sqrtResult;
	}
	float Perimetr() override
	{
		return _upFooting + _downFooting + _leftSide + _rightSide;
	}

private:
	float _upFooting;
	float _downFooting;
	float _leftSide;
	float _rightSide;
};

