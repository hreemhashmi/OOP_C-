#include <iostream>
using namespace std;
main()
{

    int n;
    cout << " enter how many number do you want to enter: ";
    cin >> n;
    int arra[n];
    for (int i = 0; i < n; i++)
    {
        cout << " enter the " << i + 1 << " number: ";
        cin >> arra[i];
    }
    for(int i =0; i<n ; i++)
    {
    cout<< arra[i] << ", ";
    }
}