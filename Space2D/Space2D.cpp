#include <iostream>
#include "Vector2.h"

#include <iostream>
#include "Object2D.h"

using namespace std;

int main()
{
	vector<Vector2> dots = {Vector2(0,0), Vector2(4,0), Vector2(4,4) };
	Object2D object(dots);

	cout << object.ToString() << endl;
	cout << object.GetSquare() << endl;
}