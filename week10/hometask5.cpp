#include<iostream>
using namespace std;
 int calsalary(float base , int  score, int experiance)
 {float bonus = 0;
 if( score >= 90)
 {
 bonus = 0.2;
 }
 else if(score >= 75 && score <=89)
 {
 bonus = 0.1;
 }
 else
 {
 bonus = 0.05;
 }
 if ( experiance >= 5)
 {
bonus += 0.05;
 }
 float totalbonous = base * bonus;
 float final = base + totalbonous;
 return final;
 }
 int main(){

float base;
int score , experiance;
cout<< " enter base ";
cin>>base;
cout<< " enter score ";
cin>>score;
cout<< " enter experiance ";
cin>>experiance;

cout<< " final salary : "<<calsalary( base,score,experiance);
return 0;
 }