#include<iostream>
using namespace std;
main(){
cout<< " enter the price of vegetables kg(n) in coins ";
float n;
cin>>n;
cout<< " enter the price of fruits kg(m) in coins ";
float m;
cin>>m;
cout<< " enter total kg of vegetables ";
int total_veg;
cin>>total_veg;
cout<< " enter total kg of fruits ";
int total_fruit;
cin>>total_fruit;
float total_earning = ((n*total_veg)+(m*total_fruit))/1.94 ;
cout<< " total earning in rps is: " << total_earning ;}

