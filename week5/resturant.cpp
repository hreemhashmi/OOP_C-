#include<iostream>
using namespace std;
main(){
    int choice;

    for(int i = 1; i<=7;i++)
    {
    cout<<" ----------restaurant management system----------"<<endl;
    cout<<" 1. view food menu "<<endl;
    cout<<" 2. place order "<<endl;
    cout<<" 3. view order status "<<endl;
    cout<<" 4. generate bill "<<endl;
    cout<<" 5. contact staff "<<endl;
    cout<<" 6. exit "<<endl;
    
    cout<<" enter youe choice (1-6): ";
    cin>>choice;
    if(choice == 1)
    {
    cout<<" you selected: view food menu. "<<endl;
    }
    else if(choice == 2)
    {
    cout<<" you selected: place order. "<<endl;
    }
    else if(choice ==3)
    {
    cout<<" you selected: view order status. "<<endl;
    }
    else if(choice == 4)
    {
    cout<<" you selected: generate bill. "<<endl;
    }
    else if(choice==5)
    {
    cout<<" you selected: contact staff. "<<endl;
    }
    else if(choice == 6)
    {
    cout<<" programm ends. "<<endl; 
    break;
    }
    else
    {
        cout<< " invalid choice "<<endl;}
    }}
    
    
    
    

    
    


