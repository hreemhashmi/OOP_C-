#include <iostream>
using namespace std;
int main()
{

    int n;
    cout << " enter the number of resistors in the series circuit: ";

    cin >> n;

    float arr[100];

    float sum = 0;

    cout << " enter the resistance values(in ohms) of the " << n << " resistors, on per lines: "<<endl;
    
    for (int i = 0; i < n; i++)
    {
        cin >> arr[i];
        
        sum = sum + arr[i];
    }
    cout << " sum of resistance in series is: " << sum << endl;

    return 0;

}