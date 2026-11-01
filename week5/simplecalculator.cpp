#include<iostream>
using namespace std;
main(){
int choice,sum,diff,multi;
float num1,num2,divi;

for(int i=1;i<=7;i++)
{
 cout<< " ------simple calculator------ "<<endl;
 cout<< " 1. addition "<<endl;
 cout<< " 2. substraction "<<endl;
 cout<< " 3. multiplication "<<endl;
 cout<< " 4. division "<<endl;
 cout<< " 5. clear screan "<<endl;
 cout<< " 6. exit "<<endl;
 cout<< " enter your choice(1-6): ";
 cin>>choice;
 if(choice>=1 && choice <=4)
 {
 cout<< " enter first number: ";
 cin>>num1;
 cout<< " enter second number: ";
 cin>>num2;
 }

 if(choice==1)
 {
    sum = num1 + num2;
 cout<< " result: " << sum <<endl;
 }
 else if(choice==2)
 {
 diff = num1 - num2;
 cout<< " result: " << diff <<endl;
 }
 else if(choice==3)
 {
multi = num1 * num2;
cout<< " result: " << multi <<endl;
 }
 else if(choice==4)
 {
if(num2 == 0)
cout<< " infinity "<<endl;
else
{
divi = num1/num2;
cout<< " result: " << divi <<endl;
 }}
 else if(choice==5)
 {
cout<< " cleared screan "<<endl;
 }
 else if(choice==6)
 {
cout<< " program ends "<<endl;
break;
 }
 else
 {
cout<< " invalid choice "<<endl;
 }

}
}