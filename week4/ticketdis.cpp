#include<iostream>
using namespace std;
main(){
cout<< " enter the name of the country: ";
string name;
cin>>name;
cout<< " enter the price of the ticket: ";
float price;
cin>>price;
float discount;
float final_price;
if(name == "ireland" ){
discount = 0.10;}
else{
discount = 0.05;}
final_price = price - (price * discount);
cout<< " discount price " << final_price ;}




