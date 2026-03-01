#include<iostream>
using namespace std;
main(){
cout<<"enter imposter: ";
float imposter;
cin>>imposter;
cout<< "enter players: ";
int players;
cin>>players;
double chance = 100 * (imposter/players);
cout<<"the chance is " << chance << " % " ;}  