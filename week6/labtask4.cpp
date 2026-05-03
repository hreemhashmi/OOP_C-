#include <iostream>
using namespace std;
main()
{
    int size = 5;
    int num[size];
    for (int i = 0; i < size; i++)
    {
        cout << " enter the " << i + 1 << " number ";
        cin >> num[i];
    }
    cout << " the 1st number is " << num[0] << endl;
    cout << " the last number is " << num[4] << endl;
}