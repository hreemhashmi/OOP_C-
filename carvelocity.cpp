#include<iostream>
using namespace std;
main(){
cout<<"  enter initial velocity: ";
int initial_velocity;
cin>>initial_velocity;
cout<<"  enter accelaration:";
int accelaration;
cin>>accelaration;
cout<<"  enter time: ";
int time;
cin>>time;
int final_velocity = ((accelaration * time) + initial_velocity );
cout<< " the final velocity is " << final_velocity;}
 

