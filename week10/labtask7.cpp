#include <iostream>
#include <cmath>
using namespace std;

int main()
{
    float hieght, distance, angle;
    cout << " enter tha distance ";
    cin >> distance;
    cout << " enter the angle ";
    cin >> angle;
    float radian = angle / 57.29;
    hieght = distance * tan(radian);
    cout << " the hieght is " << hieght;
    return 0;
}