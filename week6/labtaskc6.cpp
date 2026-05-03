#include <iostream>
using namespace std;
int main()
{

    int n;
    cout << " enter the number of elements: ";

    cin >> n;

    int arr[100];

    cout << " enter " << n << " numbers, on per line: " << endl;
       // loop for taking input.
    for (int i = 0; i < n; i++)
    {
        cin >> arr[i];
    }
          // this just imagin.
    int largest = arr[0];
         // for compairing and find largest
    for (int i = 1; i < n; i++)
    //both loops are saparate not nested in this program.
    {
        if (arr[i] > largest)
        {
            largest = arr[i];
        }
    }

    cout << " the largest number is: " << largest;
    
    return 0;
}