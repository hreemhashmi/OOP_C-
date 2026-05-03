#include<iostream>
using namespace std;
 string result( int a)
{
int n1 = a % 10;
a = a/10;
int n2 = a% 10;
a = a/10;
int n3 = a% 10 ;
a = a/10;
int n4 = a % 10;
a = a/10;
int n5 = a%10;
a = a/10;
int sum = n1 + n2 + n3 + n4 + n5 ;
if( sum % 2 == 0)
return " evenish";
else if( sum % 2 == 1)
return " oddish ";
}
int main(){

int num;
cout<< " enter the four-digit number ";
cin>>num;
cout<<result(num);
return 0;
}