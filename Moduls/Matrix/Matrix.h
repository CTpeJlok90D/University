#pragma once
#include <string>
#include <vector>

using namespace std;

class Matrix
{
private:
	void Init(int rowCount, int columnCount)
	{
		for(int i = 0; i < rowCount; i++)
		{
			vector<double> row;
			Value.push_back(row);
			for(int j = 0; j < rowCount; j++)
			{
				Value[i].push_back(0);
			}
		}
	}

public:
	vector<vector<double>> Value;

	Matrix(int rowCount, int columnCount)
	{
		Init(rowCount, columnCount);
	}

	Matrix(int size)
	{
		Init(size, size);
	}

	string ToString(string space = " ")
	{
		string result = "";
		for(int i = 0; i < Value.size(); i++)
		{
			for(int j = 0; j < Value.size(); j++)
			{
				result += to_string(Value[i][j]);
				result += space;
			}
			result += "\n";
		}
		return result;
	}

	int RowCount()
	{
		return Value.size();
	}

	int ColumnCount()
	{
		return Value[0].size();
	}

	bool IsSymmetry()
	{
		for(int x = 0; x < RowCount()/2 + 2; x++)
		{
			for(int y = 0; y < ColumnCount()/2 + 2; y++)
			{
				if(Value[x][y] != Value[y][x])
				{
					return false;
				}
			}
		}
		return true;
	}

	Matrix operator+(Matrix a)
	{
		if(a.RowCount() != RowCount() || a.ColumnCount() != ColumnCount())
		{
			throw "Row and Column count must be identity";
		}

		Matrix result(RowCount(), ColumnCount());
		for(int x = 0; x < Value.size(); x++)
		{
			for(int y = 0; y < Value[x].size(); y++)
			{
				result.Value[x][y] = a.Value[x][y] + Value[x][y];
			}
		}
		return result;
	}

	Matrix operator-(Matrix a)
	{
		if(a.RowCount() != RowCount() || a.ColumnCount() != ColumnCount())
		{
			throw "Row and Column count must be identity";
		}

		Matrix result(RowCount(), ColumnCount());
		for(int x = 0; x < Value.size(); x++)
		{
			for(int y = 0; y < Value[x].size(); y++)
			{
				result.Value[x][y] = a.Value[x][y] - Value[x][y];
			}
		}
		return result;
	}

	static Matrix CreateRandom(int size)
	{
		return CreateRandom(size, size);
	}

	static Matrix CreateRandom(int rowCount, int columnCount)
	{
		Matrix result(rowCount, columnCount);
		for(int x = 0; x < rowCount; x++)
		{
			for(int y = 0; y < columnCount; y++)
			{
				result.Value[x][y] = rand()%100 - 50;
			}
		}
		return result;
	}
};