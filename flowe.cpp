#include<iostream>
using namespace std;
main(){
int red;
cout<< "  red roses: ";
cin>>red;
int white;
cout<< " white roses: ";
cin>>white;
int tulip;
cout<< " tulips: ";
cin>>tulip;
float p1,p2,p3;
p1 = red * 2.00;
p2 = white * 4.10;
p3 = tulip * 2.50;
float sum;
sum = p1 + p2 + p3 ;
float discount;
if(sum >= 200){
discount = 0.20;}
float afterdiscount = sum - (sum * discount ) ;
cout<< " original price: "<< sum <<endl;
cout<< " price after discount: "<< afterdiscount ;}




