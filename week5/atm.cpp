#include<iostream>
using namespace std;
main(){
int pin;
int choice,amount;
int balance = 1000;

for(int i =1 ; i <=3;i++)
{
cout<< " enter pin: ";
cin>>pin;
if(pin == 1234)
{
    cout<< " login successful "<<endl;
 break;}
else {
cout << " try again "<<endl;}
if(i ==3 && pin != 1234)
{cout<< " to many attemps . program end. "<<endl;}
}
for(int i = 1;i <=5;i++)
{
cout<< "-----------ATM-MENU-----------"<<endl;
cout<< "1. check balance: "<<endl;
cout<< "2. Deposit money: "<<endl;
cout<< "3. Withdraw money: "<<endl;
cout<< "4. Exit "<<endl;

cout<< " enter choice: ";
cin>>choice;
if(choice == 1)
{cout<< " current balance: " << balance <<endl;}
else if (choice == 2 )
{cout<< " enter amount to deposit: ";
 cin>> amount;
 balance = balance + amount ;}
 else if (choice == 3)
 { cout<< " enter amount to withdraw: ";
 cin>> amount;
 if(amount <= balance )
 {
balance = balance - amount;}
else {
 cout<< " insufficient balance "<<endl;}}
 else if (choice == 4 )
 { cout<< " program end "<< endl;
    break;}
else 
{cout<< " invalid choice "<<endl;}
}
 }



 


