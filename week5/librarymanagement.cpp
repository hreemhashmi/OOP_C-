#include<iostream>
using namespace std;
main(){

int choice;
string name;

for(int i=1;i<=6;i++)
{
cout<< " ----------library system----------"<<endl;
cout<< " 1. add book "<<endl;
cout<< " 2. view book "<<endl;
cout<< " 3. borrow book "<<endl;
cout<< " 4. issue book "<<endl;
cout<< " 5. exit "<<endl;

cout<< " enter your choice(1-5): ";
cin>>choice;
if(choice==1)
{
cout<< " enter book name: " ;
cin>>name;
cout<< " you added a book: " << name <<endl;
}
else if(choice==2)
{
cout<< " view book "<<endl;
}
else if(choice==3)
{
cout<< " borrow book "<<endl;
}
else if(choice==4)
{
cout<< " issue book "<<endl;
}
else if(choice == 5) 
{
cout<< " existing library system.goodbye! "<<endl;
break;}
else
{
cout<< " invalid choice " <<endl;
}


}
}