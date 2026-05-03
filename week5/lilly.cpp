#include <iostream>
using namespace std;
main()
{

    int age, machineprice, toyprice;
    cout << " enter lilly age: ";
    cin >> age;
    cout << " enter machine price: ";
    cin >> machineprice;
    cout << " enter toys price: ";
    cin >> toyprice;
    int toy = 0;
    int money = 0;
    int gift_price = 10;
    for (int i = 1; i <= age; i++)
    {
        if (i % 2 == 0)
        {
            money = money + (gift_price - 1);
            gift_price = gift_price + 10;
        }
        else
        {
            toy++;
        }
    }
    money = money + (toy * toyprice);
    if (money >= machineprice)
    {
        cout << " yes ! " << money - machineprice << endl;
    }
    else
    {
        cout << " no " << machineprice - money << endl;
    }
}
