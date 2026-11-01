#include <iostream>
using namespace std;
main()
{

    string word;
    cout << " enter a word: ";
    getline(cin,word);
    char next;
    for (int i = 0; word[i] != '\0'; i++)
    {
        next = word[i] + 1;
        cout << next ;
    }
}