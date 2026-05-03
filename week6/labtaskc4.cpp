#include <iostream>
using namespace std;
main()
{

    int n;
    cout << " enter how many nuber do you want to enter: ";
    cin >> n;
    if (n <= 0)
    {
        cout << " invelid input . enter number must be greater than 0 " << endl;
    }
    int num[n];
    cout << " enter " << n << " number . on per line " << endl;
    for (int i = 0; i <= n; i++)
    {
        cin >> num[i];
    }

    cout << " number in reverse order: " << endl;
    for (int i = n - 1; i >= 0; i--)
    {
        cout << num[i] << endl;
    }
}