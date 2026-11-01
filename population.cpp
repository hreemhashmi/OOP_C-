#include<iostream>
using namespace std;
main(){
cout<<"Enter the current world pupolation: ";
int population;
cin>>population;
cout<<"Enter the monthly birth rate (number of births per month): ";
int birth_rate;
cin>>birth_rate;
int month_in_three_decades = 30 * 12;
int total_births = birth_rate * month_in_three_decades;
int population_in_three_decades = population + total_births;
cout<<"population in three decades will be: " << population_in_three_decades;}   