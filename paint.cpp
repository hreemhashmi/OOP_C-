#include<iostream>
using namespace std;
main(){
cout<< " enter the paint area(n) : ";
int n;
cin>>n;
cout<< " enter the width(w): ";
int w;
cin>>w;
cout<< " enter the hight(h): ";
int h;
cin>>h;
int walls_painted = n/(w * h);
cout<< " the total number of walls painted = " << walls_painted ;}  