#include <iostream>
using namespace std;
int main()
{

    int n;
    cout << " enter the size of array: ";
    cin >> n;
    int arr[100];
    cout << " enter " << n << " of the array: ";
    for (int i = 0; i < n; i++)
    {
        cin >> arr[i];
    }
    bool special = true;

    for (int i = 0; i < n; i++)
    {
        if (i % 2 == 0)
        {
            if (arr[i] % 2 == 0)
            {
                if (arr[i] != 0)
                {
                    special = false;
                    break;
                }
            }
            else if (arr[i] % 2 == 0)
            {

                {
                    special = false;
                    break;
                }
            }
        }
    }
    if (special)
        cout << " array is special ";
    else
        cout << " array is not special ";
    return 0;
}