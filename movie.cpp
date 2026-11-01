#include<iostream>
using namespace std;
main(){
cout<< " movie name: " ;
string name;
cin>>name;
cout<< " price of an adult ticket: " ;
int adult;
cin>>adult;
cout<< " price of child ticket: ";
int child;
cin>>child;
cout<< " the number of adult ticket sold: ";
int adult_sold_tickets;
cin>>adult_sold_tickets;
cout<< " the number of children tickets sold: ";
int child_sold_tickets;
cin>>child_sold_tickets;
cout<< " the percentage of the total money to donate to charity: ";
float charity_percentage;
cin>>charity_percentage;
int total_adult_sold_tickets = adult * adult_sold_tickets;
int total_child_sold_tickets = child * child_sold_tickets;
int total_earning = total_adult_sold_tickets + total_child_sold_tickets;
float donated_charity_percentage = (charity_percentage/100) * total_earning;
int remaining_money = total_earning - donated_charity_percentage ;
cout<< "---------------------------------------"<<endl;
cout<< " movie:" << name <<endl;
cout<< " total money earned from all the tickets is: " << total_earning <<endl;
cout<< " money will be given to the charity is: " << donated_charity_percentage <<endl;
cout<< " remaining money earned from the movie is: " << remaining_money ;}    

