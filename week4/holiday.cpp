#include<iostream>
using namespace std;
main(){
int sleep_per_time = 30000;
cout<< " enter the number of holidays ";
int holiday;
cin>>holiday;
int working_days = 365 - holiday ;
float time_for_games = (working_days * 63) + (holiday * 127);
int difference = time_for_games - 30000 ;
int hours = difference/60;
int minutes = difference%60;
if(sleep_per_time>= time_for_games){
cout<< " tom sleep well " <<endl;
cout<<hours<< "hours"<<minutes<<" minutes is less for play "<<endl;}
else{
cout<< " tom will run away "<<endl;
cout<<hours<< "hours"<<minutes<< " minutes is more for play ";}}


