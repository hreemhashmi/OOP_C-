#include<iostream>
using namespace std;
main(){
string a,b,c;
int a1,b2,c3;
cout<< " enter the name of first brother: ";
cin>>a;
cout<< " enter the age of first brother: ";
cin>>a1;
cout<< "enter the name of second brother: ";
cin>>b;
cout<< "enter the age of second brother: ";
cin>>b2;
cout<< " enter the name of third brother: ";
cin>>c;
cout<< " enter the age of third brother: ";
cin>>c3;
if(a1<b2){
if(a1<c3){
cout<<a<<" is the  youngest ";}}
if(b2<a1){
if(b2<c3){
cout<<b<<" is the youngest ";}}
if(c3<a1){
if(c3<b2){
cout<<c<< "is the youngest ";}}
}






