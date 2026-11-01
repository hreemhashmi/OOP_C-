#include <iostream>
#include <cmath>
using namespace std;
void menu(){
cout<< " 1 . solve equation " <<endl;
cout<< " 2. exit " << endl;
}

float determinant(int a, int b, int c)
{
    float power = pow(b, 2);
    float d1 = power - (4 * a * c);
    return d1;
}
void rootfind(int a, int b, int c)
{
    float d2 = determinant(a, b, c);

    if (d2 > 0)

    {
        float x1 = (-b + sqrt(d2)) / (2 * a);
        float x2 = (-b - sqrt(d2)) / (2 * a);
        cout << " solution : x1 = " << x1 << " and x2 = " << x2 << endl;
    }
    else if (d2 == 0)
    {
        float x = -b / (2 * a);
        cout << " soluion  : x = " << x << endl;
    }
    else if (d2 < 0)
    {

        float real = -b / (2 * a);
        float imagenary = sqrt(-(d2)) / (2 * a);
        cout << " complex solution x1 = " << real << " + " << imagenary << " i ";
        cout << " x2 = " << real << " + " << imagenary << " i ";
    }
}


int main()
{
    while(true)
    {
    menu();
    int choice;
    cin>> choice;
    if( choice ==1 )
    {
     int a, b, c;
    cout << " enter a : ";
    cin >> a;
    cout << " enter b : ";
    cin >> b;
    cout << " enter c : ";
    cin >> c;
 rootfind(a, b, c);
    
    }
    else if ( choice == 2 )
    {
        break;
    }
    else 
    {
    cout<< " invalid choice "<<endl;
    }
}
    return 0;
}
