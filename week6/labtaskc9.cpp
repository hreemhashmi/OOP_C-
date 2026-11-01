#include <iostream>
using namespace std;
int main()
{

    int coins[4];
    float bill;
    float total;
    cout << " enter quarters: ";
    cin >> coins[0];
    cout << " enter dimes: ";
    cin >> coins[1];
    cout << " enter nickels: ";
    cin >> coins[2];
    cout << " enter pannies: ";
    cin >> coins[3];

    cout << " enter the total amount due: $ ";
    cin >> bill;
    total = ((coins[0] * 0.25) + (coins[1] * 0.10) + (coins[2] * 0.05) + (coins[3] * 0.01));

    if (total >= bill)
    {
        cout << " can you  pay the amoount ? yes " << endl;
    }
    else
    {
        cout << " can you pay the amount ? no " << endl;
    }
    return 0;
}