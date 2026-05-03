#include <iostream>
using namespace std;
int main()
{

    int n;
    cout << " enter number of elements: ";
    cin >> n;
    int count =0;// here count tells number of filled seats.in first step there is no elemnt store so count loop so , in line 19 does not run.
    int arr[100];
     cout << " enter" << n << " number,on per line:" << endl;
       // loop for input.
    for (int i = 0; i < n; i++)
    {
       int num;
        cin >> num;

        bool alreadyexist = false;

        for (int j = 0; j < count; j++)// and j is checking  ech seat.
        // if no seats filled then no checking .
        //if 3 seats field then check 3 times .
        {
            if (arr[j] == num)
            {
                alreadyexist = true;
                cout << " already exist " << num << endl;
                break;
            }
        }
    if( alreadyexist == false)
    {
    arr[count] = num;
    count++;
    }
    }

    cout << " unique value entered: ";
    for (int i = 0; i < count;i++)
        {
        
            cout << arr[i] << " ";
        }
    return 0;
}