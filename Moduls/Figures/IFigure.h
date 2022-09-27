#pragma once
#define PI 3.14159265358979323846

class IFigure
{
public:
	virtual float Square() = 0;
};

class IFigure3D : public IFigure
{
	virtual float Volume() = 0;
};

class IFigure2D : public IFigure
{
	virtual float Perimetr() = 0;
};

class RoundedFigure : public IFigure
{
public:
	RoundedFigure(float radius) 
	{
		_radius = radius;
	}
	float Radius() { return _radius; }

private:
	float _radius;
};