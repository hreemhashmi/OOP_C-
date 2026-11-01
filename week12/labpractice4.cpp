#include<iostream>
using namespace std;


void modifywithpointers(int *p)
{
    *p = 50;
}
void modifywithreference(int &r)
{
r = 100;
}
int main(){
int a = 10, b = 20;
modifywithpointers(&a);
modifywithreference(b);
cout<< " value of a after pointer modification: " << a <<endl;
cout<< " value of b after reference modification: "<<b<<endl;
return 0;

}
