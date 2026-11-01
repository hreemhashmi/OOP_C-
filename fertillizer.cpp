#include<iostream>
using namespace std;
main(){
cout<< " enter the weight of the fertillizer bag in pounds: ";
float weight;
cin>>weight;
cout<< " enter the cost of the bag: ";
float cost;
cin>>cost;
cout<<" enter the area  in square feet that can be covered by the bag: ";
float area;
cin>>area;
float price_for_each_pound = cost/weight;
float cost_for_each_square_foot_area = cost/area ;
cout<< " cost of fertillizer per pound: " << price_for_each_pound <<endl;
cout<< " cost of fertillizing per square foot " << cost_for_each_square_foot_area ;}

