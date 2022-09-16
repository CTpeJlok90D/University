#pragma once
#include "List.h"
#include <string>

using namespace std;

namespace ListStek
{
	template <typename T>
	class Stek
	{
	public:
		Stek()
		{

		}

		void Add(T value)
		{
			_value.Add(value);
		}

		T Remove()
		{
			T value = _value.GetLast();
			_value.RemoveAt(_value.Lenght() - 1);
			return value;
		}

		T GetAt(int position)
		{
			return _value[position];
		}

		string ToString()
		{
			string result = "";
			for(int i = 0; i < _value.Lenght(); i++)
			{
				result += to_string(_value[i]) + " ";
			}
			return result;
		}

	private:
		List<T> _value;
	};
}