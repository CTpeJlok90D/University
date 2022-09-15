#pragma once
#include "List.h"
#include "Client.h"
#include <string>

using namespace std;

class Queue
{
private:
	List<Client*> _clientList;

public:
	Queue(){}
	void AddClient(Client* client);
	Client* GetFirstClientByType(ServiseType serviseType);
	Client* GetFirstClientByType(List<ServiseType> serviceTypes);
	void RemoveClientByType(ServiseType serviseType);
	bool HaveClientWithType(ServiseType serviseType)
	{
		for(int i = 0; i < _clientList.Lenght(); i++)
		{
			if(_clientList[i]->GetServiseType() == serviseType)
			{
				return true;
			}
		}
		return false;
	}
	bool HaveClientWithType(List<ServiseType> serviseTypes)
	{
		for(int i = 0; i < serviseTypes.Lenght(); i++)
		{
			if(HaveClientWithType(serviseTypes[i]))
			{
				return true;
			}
		}
		return false;
	}
	void ShowClients()
	{
		for (int i = 0; i < _clientList.Lenght(); i++)
		{
			cout << _clientList[i]->ToString() << " ";
		}
		cout << endl;
	}


private:
	int GetClientTypeIndex(ServiseType serviseType);
};

inline void Queue::AddClient(Client* client)
{
	_clientList.Add(client);
}

inline Client* Queue::GetFirstClientByType(ServiseType serviseType)
{
	int index = GetClientTypeIndex(serviseType);
	if (index == -1)
	{
		return nullptr;
	}
	Client* result = _clientList[index];
	return result;
}

inline Client* Queue::GetFirstClientByType(List<ServiseType> serviceTypes)
{
	for (int i = 0; i < serviceTypes.Lenght(); i++)
	{
		Client* result = GetFirstClientByType(serviceTypes[i]);
		if(result != nullptr)
		{
			return result;
		}
	}
	return nullptr;
}

inline void Queue::RemoveClientByType(ServiseType serviseType)
{
	int index = GetClientTypeIndex(serviseType);
	if (index == -1)
	{
		return;
	}
	_clientList.RemoveAt(index);
}

int Queue::GetClientTypeIndex(ServiseType serviseType)
{
	for (int i = 0; i < _clientList.Lenght(); i++)
	{
		if (_clientList[i]->GetServiseType() == serviseType)
		{
			return i;
		}
	}
	return -1;
}