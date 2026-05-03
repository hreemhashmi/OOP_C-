#include <iostream>
#include <cmath>
using namespace std;

int main()
{

    float num1, num2;
    cout << " enter number 1 : ";
    cin >> num1;
    cout << " enter numer 2 : ";
    cin >> num2;
    float result = min(num1, num2);
    cout << " the minimam number is " << result;
    return 0;
}
