#include <iostream>
using namespace std;
void timetravel(int h, int m)
{
    int m1 = m + 15;
    if (m1 >= 60)
    {
        h = h + 1;
        m = m1 - 60;
        if (h == 24)
        {

            h = 0;
        }
    }

    else
    {
        m = m1;
    }

    cout << h << " : " << m << endl;
}
int main()
{

    int hours, minutes;
    cout << " enter hours: ";
    cin >> hours;
    cout << " enter minutes: ";
    cin >> minutes;
    timetravel(hours, minutes);
    return 0;
}
