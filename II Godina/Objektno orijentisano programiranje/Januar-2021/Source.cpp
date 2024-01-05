#include<iostream>
#include<fstream>
#include "Kolekcija.h"
#include  "Kvadrat.h"
#include "Pravougaonik.h"
using namespace std;

void main()
{
	Kolekcija* kol = new Kolekcija(3);
	Kvadrat* k = new Kvadrat(2, 1, 1);
	Pravougaonik* p = new Pravougaonik(6, 2, 0, 0);
	Kvadrat* k2 = new Kvadrat(36, 5, 3);
	kol->DodajElement(k);
	kol->DodajElement(k2);
	kol->DodajElement(p);
	kol->OSortRastuce();
	ofstream izlaz("HAHAHA.txt");
	izlaz << *kol;
	kol->OSortOpadajuce();
	izlaz << *kol;
}