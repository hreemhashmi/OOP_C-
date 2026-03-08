#include<iostream>
using namespace std;
main(){
int number1,number2;
cout<< " enter number one: ";
cin>>number1;
cout<< " enter the operator: ";
string ope;
cin>>ope;
cout<< " enter number two: ";
cin>>number2;
if(ope=="+"){
cout<<number1<< "-" <<number2<< "=" << number1 - number2 ;}
if(ope== "-"){
cout<<number1<< "+" <<number2<< "=" << number1 + number2 ;}
if(ope== "*"){
cout<<number1<< "/"<<number2<< "=" << number1/number2 ;}
if(ope== "/" ){
cout<<number1<< "x" <<number2<< "=" << number1 * number2 ;}}




