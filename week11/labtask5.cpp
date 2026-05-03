#include<iostream>
using namespace std;

int nessancars(int cars[5][5])
{
int sum =0;
for( int i =0; i<5; i++)
{
    sum += cars[2][i];
}
return sum;

}
  int main(){
int cars[5][5] =
        {
            {10, 7, 12, 10, 4},
            {18, 11, 15, 17, 2},
            {23, 19, 12, 16, 14},
            {7, 12, 16, 0, 2},
            {3, 5, 6, 2, 1}

        };

 int result = nessancars(cars);
 cout<< " total nessan cars "<< result <<endl;
 return 0;
}