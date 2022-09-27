#include <iostream>
#include "Matrix.h"

using namespace std;

int main()
{
    srand(time(0));
    Matrix matrix = Matrix::CreateRandom(5);
    cout << matrix.ToString() << endl;

    Matrix matrix2 = Matrix::CreateRandom(5);
    cout << matrix2.ToString() << endl;

    cout << (matrix + matrix2).ToString() << endl;
    cout << (matrix - matrix2).ToString() << endl;

    Matrix symMatrix(3,3);

	for(int x = 0; x < symMatrix.RowCount()/2 + 2; x++)
	{
		for(int y = 0; y < symMatrix.ColumnCount()/2 + 2; y++)
		{
			double randDouble = rand()&100 - 50;
			symMatrix.Value[x][y] = randDouble;
			symMatrix.Value[y][x] = randDouble;
		}
	}
	cout << symMatrix.ToString() << endl;
	cout << symMatrix.IsSymmetry() << endl;
}