#include<iostream>
using namespace std;
main(){
cout<< "enter the 4-digit number: ";
int number;
cin>>number;
int original_number = number;
int digits = number%10;
number = number/10;
int digit_1 = number%10;
number = number/10;
int digit_2 = number%10;
number = number/10;
int digit_3 = number%10;
int sum = digits + digit_1 + digit_2 + digit_3 ;
cout<< " the sum of the digits of " << original_number << " is " << sum ;}


