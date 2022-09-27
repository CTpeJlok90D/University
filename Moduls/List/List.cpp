#include <iostream>
#include "List.h"
#include "Queue.h"
#include "Cass.h"

using namespace std;

void ListTest();
void QueueTest();

int main()
{
    QueueTest();
}

void ListTest() 
{
    List<int> list;
    list.Add(5);
    list.Add(7);
    list.Add(4);
    list.Add(1);
    list.Add(9);
    list.Add(11);

    list.RemoveAt(5);
    list.RemoveAt(1);
    list.RemoveAt(1);

    cout << "List lenght -> " << list.Lenght() << endl << "List contains:\n";

    for (int i = 0; i < list.Lenght(); i++)
    {
        cout << list[i] << " ";
    }
    cout << "\n";

    cin.get();
}

const map<ServiseType, string> ServiseTypeToString =
{
    {ServiseType::Payment, "Payment"},
    {ServiseType::Withdrawal, "Withdrawal"},
    {ServiseType::TransferOfFunds, "TransferOfFunds"}
};

void QueueTest() 
{
    Queue queue;

    List<ServiseType> serviseTypeCass1;
    serviseTypeCass1.Add(ServiseType::Payment);
    serviseTypeCass1.Add(ServiseType::TransferOfFunds);
    Cass cass1(&queue, serviseTypeCass1);

    List<ServiseType> serviseTypeCass2;
    serviseTypeCass2.Add(ServiseType::Withdrawal);
    serviseTypeCass2.Add(ServiseType::Payment);
    Cass cass2(&queue, serviseTypeCass2);

    Client client1(ServiseType::Payment);
    Client client2(ServiseType::Withdrawal);
    Client client3(ServiseType::TransferOfFunds);
    Client client4(ServiseType::Payment);
    Client client5(ServiseType::Payment);
    Client client6(ServiseType::Payment);
    Client client7(ServiseType::TransferOfFunds);
    Client client8(ServiseType::Withdrawal);

    queue.AddClient(&client1);
    queue.AddClient(&client2);
    queue.AddClient(&client3);
    queue.AddClient(&client4);
    queue.AddClient(&client5);
    queue.AddClient(&client6);
    queue.AddClient(&client7);

    queue.ShowClients();

    cout << "===============\n";
    cass1.NextClient();
    cass1.ShowCurrentClient();
    cass2.NextClient();
    cass2.ShowCurrentClient();
    cout << "===============\n";
    queue.ShowClients();
    cout << "===============\n";
    cass1.NextClient();
    cass1.ShowCurrentClient();
    cass2.NextClient();
    cass2.ShowCurrentClient();
    cout << "===============\n";
    queue.ShowClients();
}