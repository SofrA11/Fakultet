#pragma once
#include"Figura.h"
class Kolekcija
{
private:
	Figura** Fig;
	int maxFig;
	int trenFig;
public:
	Kolekcija();
	Kolekcija(int);
	~Kolekcija();
	int DodajElement(Figura* F);
	friend ostream& operator<<(ostream&, Kolekcija&);
	double Povrsina();
	double Obim();
	void OSortRastuce();
	void OSortOpadajuce();
};

