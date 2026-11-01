#include <iostream>
using namespace std;
int x = 10;
void myfunction()
{
    cout << " x is " << x<<endl;
    int x = 20;
}
int main()
{
    myfunction();
    int x = 30;
    cout << " the value of x is " << x<<endl;
    myfunction();
}