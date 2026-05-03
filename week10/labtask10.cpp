#include <iostream>
using namespace std;

void checkalphacase(string a)
{
    for (int i = 0; i < a.length(); i++)
    {
        char alphabet = a[i];
        if (alphabet >= 'A' && alphabet <= 'Z')
            cout << " you enter capital " << alphabet << endl;
        else if (alphabet >= 'a' && alphabet <= 'z')
            cout << " you entered small " << alphabet << endl;
    }
}
int main()
{

    string n1;
    cout << " enter a character (A/a): ";
    cin >> n1;
    checkalphacase(n1);
    return 0;
}
