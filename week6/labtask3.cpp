#include <iostream>
using namespace std;
main()
{
    int num[5];
    cout << " enter 1st num: ";
    cin >> num[0];
    cout << " enter 2nd num: ";
    cin >> num[1];
    cout << " enter 3rd num: ";
    cin >> num[2];
    cout << " enter 4th num: ";
    cin >> num[3];
    cout << " enter 5th num: ";
    cin >> num[4];
for( int i=0; i<5; i++)
{
if( i==0 || i== 4)
{
cout<< num[i]<<endl;
}
}
}