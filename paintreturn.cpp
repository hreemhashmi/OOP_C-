#include<iostream>
using namespace std;
main(){
cout<< " number of square meters you can paint: ";
int number;
cin>>number;
cout<< " enter width of the wall: ";
int width;
cin>>width;
cout<< " enter hight of the wall: ";
int hight;
cin>>hight;
int wall_no = number/(width*hight);
cout<< " the number of walls you can paint is " << wall_no ;} 