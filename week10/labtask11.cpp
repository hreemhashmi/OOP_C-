#include<iostream>
using namespace std;
bool fun(int a)
{
    int first = a/100;
    int last = a%10;
    if ( first == last)
   return true;
    
    else if( first != last)
    return false;}
    

    
    
int main(){
    int n1;
cout<< " ennter a three- digit number : " ;
cin>> n1;
bool result = fun(n1);
if(result)
{
    cout<< "the number is symmetrical ";

}
else
cout<< " the number is not symmetrical ";
return 0;
}



