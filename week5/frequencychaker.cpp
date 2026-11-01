#include <iostream>
using namespace std;
main()
{
    int  frequancy = 0;
    cout << " enter a number: ";
    long long n;
    cin >> n;
    cout << " enter digit: ";
    int digit;
    cin >> digit;
    while (n > 0)
    {
        int digitn = n % 10;
        if (digitn == digit)
        {
            frequancy++;
        }
        n = n / 10;
    }
    cout << " frequancy of number is " << frequancy << endl;
}
