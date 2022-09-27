#pragma once
#include "Client.h"
#include "Queue.h"
class Cass
{
private:
	Client* _currentClient = nullptr;
	Queue* _queue = nullptr;
	List<ServiseType> _servicesProvided;

public:

	Cass(Queue* queue, List<ServiseType> servicesProvided)
	{
		_queue = queue;
		_servicesProvided = servicesProvided;
	}
	List<ServiseType> ServicesProvided();

	void NextClient();
	void ShowCurrentClient()
	{
		cout << _currentClient->ToString() << endl;
	}
};

inline List<ServiseType> Cass::ServicesProvided()
{
	return _servicesProvided;
}

inline void Cass::NextClient()
{
	if(_queue->HaveClientWithType(_servicesProvided) == false)
	{
		return;
	}
	Client* nextClient = _queue->GetFirstClientByType(_servicesProvided);
	_queue->RemoveClientByType(nextClient->GetServiseType());
	_currentClient = nextClient;
}