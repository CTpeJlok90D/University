#pragma once
#include <string>

using namespace std;

template <typename T>
class Queue
{
public:
	Queue()
	{

	}

	void Add(T value)
	{
		Item* newItem = new Item(value);
		if(_first == nullptr)
		{
			_first = newItem;
			_last = _first;
			return;
		}
		_last->Next = newItem;
		_last = newItem;
	}

	T First()
	{
		if(_first != nullptr)
		{
			return _first->Value;
		}
		return NULL;
	}

	T Last()
	{
		if(_last != nullptr)
		{
			return _last->Value;
		}
		return NULL;
	}

	T Next()
	{
		if(_first == nullptr)
		{
			throw "No items in queue";
		}

		T result = _first->Value;

		Item* new_first_item = _first->Next;
		delete _first;
		_first = new_first_item;

		return result;
	}

	string ToString()
	{
		string result = "";
		Item* currentItem = _first;
		while(currentItem != nullptr)
		{
			result += to_string(currentItem->Value) + " ";
			currentItem = currentItem->Next;
		}
		return "Queue: " + result;
	}

	int Lenght()
	{
		int result = 0;
		Item* currentItem = _first;
		while(currentItem != nullptr)
		{
			result++;
			currentItem = currentItem->Next;
		}
		return result;
	}

	bool IsEmpty()
	{
		return _first != nullptr;
	}

private:
	class Item
	{
	public:
		Item(T value)
		{
			Value = value;
		}
		Item* Next;
		T Value;
	};

	Item* _first;
	Item* _last;
};