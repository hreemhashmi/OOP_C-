#include<iostream>
using namespace std;
float taxcalculator(char type,float price)
{
    float taxamount ;
    float finalprice;
    if( type == 'm')
    {
    taxamount = price * 0.06;
    finalprice =  price + taxamount;
    return finalprice;
    }
    else if( type =='e')
    {
    taxamount = price * 0.08;
    finalprice = price + taxamount ;
    return finalprice;
    }
    else if( type == 's')
    {
    taxamount = price * 0.1;
    finalprice = price + taxamount;
    return finalprice;

    }
    else if(type == 'v'){
    taxamount =  price * 0.12;
   
    }else if( type == 't')
    {
    taxamount = price * 0.15;
 finalprice = price + taxamount;
    return finalprice;
    }

    
}int main(){

char vehicletype ;
float itemprice;
cout<< " enter the vehicle type : " ;
cin>>vehicletype;
cout<< " enter the item price : ";
cin>>itemprice;
cout<< " the fina price on the vehicle of type " << vehicletype << " after tax is$"<<taxcalculator(vehicletype,itemprice);
}