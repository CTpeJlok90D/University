#pragma once
#include <vector>

namespace ArraySteck
{
	using namespace std;
	template <typename T>
	class Stek
	{
	public:
		Stek()
		{

		}

		void Add(T value)
		{
			_value.push_back(value);
		}

		T Remove()
		{
			T value = _value[_value.size() - 1];
			_value.pop_back();
			return value;
		}

		T GetAt(int position)
		{
			return _value[position];
		}

		string ToString()
		{
			string result = "";
			for(int i = 0; i < _value.size(); i++)
			{
				result += to_string(_value[i]) + " ";
			}
			return result;
		}

	private:
		vector<T> _value;
	};
}