// Se defineste si se utilizeaza functia fib
// Programul afiseaza n elemente din sirul lui Fibonacci 
// adica:  f(0)=0, f(1)=1, f(n)=f(n-1)+f(n-2), daca n>1
#include "stdafx.h"
#include < iostream >
#include < string >

using namespace std;
double fib(double n); // prototipul
int main(void)
{
	int i,nr;
	double f;
	cout << "\n\n\tProgramul afiseaza n elemente din sirul lui Fibonacci";
	cout << "\n\n\tIntroduceri n: ";
	cin >> nr;
	cout << "\n\n";
	for (i=0; i<=nr-1 ;i++){
	f=fib(i);
	cout << "\tf(" << i << ")= " << f << "\n";
	}
	cin.ignore();
	cin.get();
	return 0;
}

double fib(double n)	
{
	if (n==0) return 0;
	if (n==1) return 1;
	int i; double a, b, c; a=0; b=1;
	for (i=2; i<=n; i++){
		c=a+b;
		a=b; 
		b=c; 
		
	}
	return c;
}