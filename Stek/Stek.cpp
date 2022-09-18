#include <iostream>
#include "ListStek.h"
#include "ArrayStack.h"

using namespace std;

int main()
{
    int choose = 0;

    cin >> choose;

    if(choose == 0)
    {
        ArraySteck::Stek<int> newStek;

        newStek.Add(2);
        newStek.Add(4);
        newStek.Add(3);
        newStek.Add(1);

        newStek.Remove();

        cout << newStek.ToString() << endl;

        newStek.Add(7);
        newStek.Add(1);
        newStek.Add(3);
        newStek.Add(10);

        cout << newStek.ToString() << endl;

        newStek.Remove();
        newStek.Remove();

        cout << newStek.ToString() << endl;
    }
    else
    {
        ListStek::Stek<int> newStek;

        newStek.Add(2);
        newStek.Add(4);
        newStek.Add(3);
        newStek.Add(1);

        newStek.Remove();

        cout << newStek.ToString() << endl;

        newStek.Add(7);
        newStek.Add(1);
        newStek.Add(3);
        newStek.Add(10);

        cout << newStek.ToString() << endl;

        newStek.Remove();
        newStek.Remove();

        cout << newStek.ToString() << endl;
    }
}