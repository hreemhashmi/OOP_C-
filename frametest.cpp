#include<iostream>
using namespace std;
main(){
cout<< " enter minutes:";
int minutes;
cin>>minutes;
cout<< " enter frame per second:";
int fps;
cin>>fps;
int total_frames = minutes * 60 * fps  ;
cout<<" the total number of frames is " << total_frames ;}