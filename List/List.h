#pragma once
template<typename T>
class List
{
private:
	struct Item;

public:
	void Add(T value);
	void Add(T value, int position);
	void AddForward(T value);
	void RemoveAt(int position);
	int Lenght();
	T GetLast() 
	{
		return GetLastItem()->Value;
	}
	T GetFirst() 
	{
		return _first->Value;
	}

	T operator[](int position);

private:
	Item* _first = nullptr;

	Item* GetLastItem()
	{
		Item* result = _first;
		while (result->Next != nullptr)
		{
			result = result->Next;
		}
		return result;
	}

	Item* GetItemByIndex(int i)
	{
		Item* result = _first;
		int j = 0;
		while (j != i)
		{
			result = result->Next;
			j++;
		}
		return result;
	}

	class Item
	{
	public:
		Item(T value)
		{
			Value = value;
		}
		Item* Next = nullptr;
		T Value;
	};
};

template<typename T>
inline void List<T>::Add(T value)
{
	if (_first == nullptr) 
	{
		_first = new Item(value);
		return;
	}
	GetLastItem()->Next = new Item(value);
}

template<typename T>
inline void List<T>::Add(T value, int position)
{
	if (position == 0)
	{
		AddForward(value);
		return;
	}
	if (position == Lenght() - 1)
	{
		Add(value);
	}
	Item newItem(value);
	Item* beforeItem = GetItemByIndex(position - 1);
	newItem.Next = beforeItem->Next;
	beforeItem->Next = &newItem;
}

template<typename T>
inline void List<T>::AddForward(T value)
{
	Item newItem(value);
	newItem.Next = _first;
	_first = &newItem;
}

template<typename T>
inline void List<T>::RemoveAt(int position)
{
	if(position == 0)
	{
		Item* first = _first;
		_first = _first->Next;
		delete first;
		return;
	}
	Item* item = GetItemByIndex(position-1);
	Item* removedItem = item->Next;
	item->Next = item->Next->Next;
	delete removedItem;
}

template<typename T>
inline int List<T>::Lenght()
{
	if (_first == nullptr)
	{
		return 0;
	}
	Item* Item = _first;
	int result = 1;
	while (Item->Next != nullptr)
	{
		Item = Item->Next;
		result++;
	}
	return result;
}

template<typename T>
inline T List<T>::operator[](int position)
{
	return GetItemByIndex(position)->Value;
}