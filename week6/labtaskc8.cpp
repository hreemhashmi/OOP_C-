#include <iostream>
using namespace std;
int main()
{

    int n;
    cout << " enter the number of elements for first array(must be 2): ";
    cin >> n;
    int arr1[100];
    cout << " enter 2 elements for the first array, on per line:" << endl;
    // for input.
    for (int i = 0; i < n; i++)
    {
        cin >> arr1[i];
    }
    int n2;
    cout << " enter the number of elements for second array: ";
    cin >> n2;
    int arr2[100];
    cout << " enter " << n2 << " elements for the second array, on per line: " << endl;
    // for second arra input
    for (int j = 0; j < n2; j++)
    {
        cin >> arr2[j];
    }
    int arr3[100];
    int l = 0;
    arr3[l] = arr1[0];
    l++;
    // for copy arr2 into arr3.
    for (int k = 0; k < n2; k++)
    {
        arr3[l] = arr2[k];
        l++;
    }
    arr3[l] = arr1[1];
    l++;
    cout << " resulting array is: ";
    // for printing output.
    for (int i = 0; i < l; i++)
    {
        cout << arr3[i] << "  ";
    }
    return 0;
}
