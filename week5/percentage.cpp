#include <iostream>
using namespace std;
main()
{

    int n = 0, digit = 0;
    float p1 = 0, p2 = 0, p3 = 0 , p4 = 0 , p5 = 0;
    cout << " enter the number: ";
    cin >> n;
    for (int i = 1; i <= n; i++)
    {
        cout << " enter digit: ";
        cin >> digit;
        if (digit >= 1 && digit <= 200)
        {
            p1++;
        }
        else if ( digit <= 399)
        {
            p2++;
        }
        else if ( digit <= 599)
        {
            p3++;
        }
        else if ( digit <= 799)
        {
            p4++;
        }
        else if ( digit <= 1000)
        {
            p5++;
        }
        else
        {
            cout << " invalid range " << endl;
        }
    }

    cout << (p1 * 100) / n << "%" << endl;
    cout << (p2 * 100) / n << "%" << endl;
    cout << (p3 * 100) / n << "%" << endl;
    cout << (p4 * 100) / n << "%" << endl;
    cout << (p5 * 100) / n << "%" << endl;
}