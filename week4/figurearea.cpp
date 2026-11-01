#include<iostream>
using namespace std;
main(){
string figure;
cin>> figure;
float area;
if( figure == "square"){
int side;
cin>>side;
area = side * side ;
cout<< "the area of square is " << area ;}
else if( figure =="rectangle"){
int length;
cin>>length;
float width;
cin>>width;
area = length * width;
cout<<" THE area of rectangle is " << area ;}
else if(figure == "circle"){
float radius;
cin>>radius;
area = 3.14 * ( radius * radius);
cout<< " the area of circle is "<< area ;}
else if(figure == "triangle"){
float base;
cin>>base;
int height;
cin>>height;
area = 0.5 * (base *height);
cout<< " the area of triangle is "<< area;}}









