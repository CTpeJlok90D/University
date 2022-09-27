#include <iostream>
#include "Vector3.h"

using namespace std;

Vector3 ReadDotFromConsole();

int main()
{
    cout << "Input 3 coords for first dot >>" << endl;
    Vector3 Dot = ReadDotFromConsole();
    cout << "Input 3 coords for second dot >>" << endl;
    Vector3 Dot2 = ReadDotFromConsole();

    cout << Dot.DistanceTo(Dot2);

    cin.get();
}

Vector3 ReadDotFromConsole() 
{
    float x, y, z;
    cin >> x >> y >> z;
    Vector3 dot(x, y, z);
    return dot;
}