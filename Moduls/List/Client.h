#pragma once

#include <map>
#include <string>

using namespace std;

enum ServiseType
{
	Payment,
	Withdrawal,
	TransferOfFunds
};

class Client
{
private:
	ServiseType _servieseType;
	map<ServiseType, string> ServiseTypeToString =
	{
		{ServiseType::Payment, "Payment"},
		{ServiseType::Withdrawal, "Withdrawal"},
		{ServiseType::TransferOfFunds, "TransferOfFunds"}
	};

public:
	Client(ServiseType type);

	ServiseType GetServiseType();
	string ToString()
	{
		return ServiseTypeToString[_servieseType];
	}
};

Client::Client(ServiseType type)
{
	_servieseType = type;
}

inline ServiseType Client::GetServiseType()
{
	return _servieseType;
}
