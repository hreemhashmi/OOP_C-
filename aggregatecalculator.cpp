#include<iostream>
using namespace std;
main(){
cout<<"  Enter the students name:";
string name;
cin>>name;
cout<<"  Enter matric marks (out of 1100):";
float matric_marks;
cin>> matric_marks;
cout<<"  Enter inter marks (out of 550):";
float inter_marks;
cin>> inter_marks;
cout<<" Enter ECAT marks (out of 400):";
float ECAT_marks;
cin>> ECAT_marks;
double Aggregate = (ECAT_marks/400)*50 + (inter_marks/550)*40 + (matric_marks/1100)*10;
cout<<" ECAT Aggregate of "<<name<<" is "<<Aggregate<< "%";}  