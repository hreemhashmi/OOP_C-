#include <iostream>
using namespace std;

void tyotabluecars(int cars[5][5])
{

    cout << " tyota blue cars " << cars[1][3] << endl;
}

int redcars(int cars[5][5])

{
    int sum = 0;
    for (int i = 0; i < 5; i++)
    {
        sum = sum + cars[i][0];
    }

    return sum;
}

int main()
{

    int cars[5][5] =
        {
            {10, 7, 12, 10, 4},
            {18, 11, 15, 17, 2},
            {23, 19, 12, 16, 14},
            {7, 12, 16, 0, 2},
            {3, 5, 6, 2, 1}

        };

    tyotabluecars(cars);
    int result = redcars(cars);
    cout << " total red " << result << endl;

    return 0;
}