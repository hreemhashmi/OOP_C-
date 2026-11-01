#include <iostream>
using namespace std;
main()
{

    int inherited_money, years;
    double totalmoney = 0;
    int age = 18;
    cout << " enter years: ";
    cin >> years;
    cout << " enter  inherited_money: ";
    cin >> inherited_money;
    for (int i = 1800; i <= years; i++)
    {
        if (i % 2 == 0)
        {
            totalmoney = totalmoney + 12000;
        }
        else
        {
            totalmoney = totalmoney + (12000 + 50 * age);
        }
        age++;
    }
    if (inherited_money >= totalmoney)
    {
        cout << " he! wil leave cearfull life and will have " << inherited_money - totalmoney << " dollars left " << endl;
    }
    else
    {
        cout << " he will need " << totalmoney - inherited_money << " dollars for survival " << endl;
    }
}