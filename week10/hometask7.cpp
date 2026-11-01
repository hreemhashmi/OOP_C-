#include<iostream>
using namespace std;

float calbalance(float b,int y)
{   
    float interest = 0;
    if( b < 10,000)

    {
        interest = 0.05 * b;
    
       
    }else if( b >= 10,000 && b <= 50,000){
        interest = 0.07 * b;
        return interest;
    }else if ( b> 50,000)
    {
        interest = 0.1 * b;
        return interest;
    }  if( y >= 3)
    {
        return interest + ( b * 0.02);
    
    }else{
        return interest ;}

   
    
}
int main (){
float balance;
int years;
cout<< " enter balanace and years : ";
cin>>balance>>years;
cout<< " updated balance "<< calbalance(balance,years);
return 0;
}