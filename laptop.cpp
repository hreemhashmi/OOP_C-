#include<iostream>
using namespace std;
main(){
int salary = 10000;
int laptop_price = 50000;
int advance = 50;
int month = 6;
int totaladvansalary = (salary * 50/100)*month;
if(totaladvansalary>= laptop_price){
cout<< " you can buy the laptop ";}
if(totaladvansalary < laptop_price){
int require_month = laptop_price/(salary * 50/100);
cout<< " you have require "<< require_month << " month to buy laptop" ;}
}
