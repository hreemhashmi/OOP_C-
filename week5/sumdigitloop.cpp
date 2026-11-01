#include<iostream>
using namespace std;
main(){

int num, sum = 0;
cout<< " enter the number: ";
cin>>num;
while( num != 0)
{
sum = sum +(num % 10);
num = num /10;}
cout<< " sum of digits = "<< sum <<endl;

}