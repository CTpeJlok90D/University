#include <iostream>
#include "Queue.h"

using namespace std;

int main()
{
    std::cout << "Hello World!\n";
    Queue<int> queue;
    queue.Add(3);
    queue.Add(5);
    queue.Add(7);

    cout << queue.ToString() << endl;
    cout << queue.Next() << endl;

    queue.Add(4);
    queue.Add(7);
    queue.Add(1);

    cout << queue.ToString() << endl;
    cout << queue.Next() << endl;
    cout << queue.ToString() << endl;
}