#include <iostream>
using namespace std;
main()
{
    int size = 5;
    float sum = 0;
    float averrage;
    int num[size] = {
        1,
        2,
        3,
        4,
        5,
    };
    for (int i = 0; i < size; i++)
    {
        sum += num[i];
    }
    averrage = sum / size;
    cout << " the sum is = " << sum << endl;
    cout << " the averrage is = " << averrage << endl;
}