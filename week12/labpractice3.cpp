#include<iostream>
using namespace std;

int main(){
int y = 20;
int &ref = y;
 cout<< " the original value of y is "<< y <<endl;
 ref = 30;
 cout<< " the modified value of  y "<< y <<endl;
 return 0;
}