#include <iostream>
using namespace std;
int main()
{

    string n;
    cout << " enter the string: ";
    getline(cin, n);
    for (int i = 0; i < n.length(); i++)
    {
        if (n[i] == 'a' || n[i] == 'e' || n[i] == 'i' || n[i] == 'o' || n[i] == 'u')
        {

        }
        else
        {
            cout << n[i];
        }
    }
    cout << endl;
    return 0;
}