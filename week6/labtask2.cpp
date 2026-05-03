#include <iostream>
using namespace std;
main()
{

    int num[5];
    num[0] = 67;
    num[1] = 23;
    num[2] = 45;
    num[3] = 98;
    num[4] = 07;
    for( int i =0;i <5;i++)
    {
    if( i ==1 || i == 3)
    {
    cout<< num[i]<<endl;
    }
    }
}