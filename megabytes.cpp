#include<iostream>
using namespace std;
main(){
cout<<"enter the size in megabytes (mb):";
float magabytes;
cin>>magabytes;
float kb = magabytes * 1024;
float bytes = kb * 1024;
float bits = bytes *8;
cout<<magabytes<< " mb is equivalent to " << bits << " bits";}