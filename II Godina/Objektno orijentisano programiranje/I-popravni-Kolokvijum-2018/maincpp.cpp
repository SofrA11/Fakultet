#include<iostream>
#include"Azdaja.h"
using namespace std;
void main()
{

	Azdaja* A=new Azdaja();
	char c;
	int i = 1;
	do {
		do {
			cout << "Unesi deo"<<i<< ". tela: ";
			cin >> c;
		} while (c != 'g' && c != 'r' && c != 'k' && c != 'x');
		if(c!='x')
		A->DodajDeoTela(c);
		i++;
		system("cls");
	} while (c != 'x');
	A->PrikaziSpisak(cout);

}