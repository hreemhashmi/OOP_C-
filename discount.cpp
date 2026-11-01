#include<iostream>
using namespace std;
main(){
cout<< " enter your bill ";
float  bill_amount;
cin>>bill_amount;
int discount;
if(bill_amount <= 5000){
discount = (bill_amount * 0.05);}
else{
discount = (bill_amount * 0.10);}
float final_amount = bill_amount - discount;
cout<< " your discount bill is: "<< final_amount;
}


