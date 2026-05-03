#include<iostream>
using namespace std;

void swap(int *p, int *b)
{
 int temp = *p;
 *p = *b;
 *b = temp;
}
int main(){
int p = 10;
int q = 20;
int *a = &p;
int *b = &q;

swap(a,b);
cout<<*a;
return 0;


}

