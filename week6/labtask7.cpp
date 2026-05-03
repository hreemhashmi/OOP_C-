#include <iostream>
using namespace std;
main()
{

    string word;
    char letter;
    bool found = false;
    cout<< " enter the word ";
    cin>>word;
    cout<< " enter the letter ";
    cin>>letter;
    for (int x = 0; word[x] != '\0'; x++)
        if (word[x] == letter)
        {
            found = true;
            break;
        }
    if (found)
    {
        cout << letter << " is found in " << word << endl;
    }
    else
    {
        cout << letter << " is not found in " << word << endl;
    }
}