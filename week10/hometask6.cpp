#include <iostream>
using namespace std;
  string tostrong(int num)
{
    int fact =1;
    int sum = 0;
    int digit =0;
   for( int i = 0; i<num ;i++)
   {
    digit = num % 10;
    num = num / 10;
        fact = fact * num;
    sum = sum + fact;}
    if (sum == num)
    {
        return  " strong number";
        
    }
    else
    {
        return  " not strong number ";
    }
}
int main (){

int number;
cout<< " enter the number ";
cin>> number;
cout<< tostrong(number)<<endl;
return 0;
}