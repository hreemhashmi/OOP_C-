#include<iostream>
using namespace std;
main(){
    int value;
cout<< " please enter a positive num: " ;
cin>>value;
while(value<=0)
{
cout<< " error " << value << " this is not a positive number " <<endl;
cout<< " please enter a positive num: ";
cin>>value;
}

}