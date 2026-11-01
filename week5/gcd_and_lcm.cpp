#include <iostream>
using namespace std;
main()
{
    int n1, n2, gcd;
    cout << " enter number 1: ";
    cin >> n1;
    cout << "enter number 2: ";
    cin >> n2;
    for (int i = 1; i <= n1 && i <= n2; i = i + 1)
    {
        if (n1 % i == 0 && n2 % i == 0)
            gcd = i;
    }
    int lcm = (n1 * n2) / gcd;
    cout << " gcd of " << n1 << " and " << n2 << " is: " << gcd << endl;
    cout << " lcm Of " << n1 << " and " << n2 << " is: " << lcm << endl;
}