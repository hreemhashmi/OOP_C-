#include <iostream>
using namespace std;
main()
{

    string word ;
    int n;
    cout<< " how many charachter you want to enter ";
    cin>>n;
    cout << " enter string: ";
   cin>>word;
    cout<< " reverse string ";
 
    for (int i = n-1; i >= 0; i--)
    {

        cout << word[i];
    }
}
