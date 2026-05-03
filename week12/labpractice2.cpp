#include<iostream>
using namespace std;

int main(){

int arr[5] = {10,60,70,10,30};
int *ptr = arr;
for(int i = 0; i < 5 ; i++){
cout<<i <<" : "<< *(ptr+i)<<endl;}
return 0;
}